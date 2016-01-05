using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace cs511_g11
{
	public class TextLine : IComparable
	{
		public string m_content;
		public int m_hashCode;

		public int m_ignoredLine;

		public TextLine(string str)
		{
			m_content = str.Replace("\t", "    ");
			m_content = m_content.Replace("\n", "");
			m_content = m_content.Replace("\r", "");
			m_hashCode = m_content.GetHashCode();

			m_ignoredLine = 0;
		}

		public void ReplaceContent(string str)
		{
			m_content = str.Replace("\t", "    ");
			m_content = m_content.Replace("\n", "");
			m_hashCode = m_content.GetHashCode();
		}

		public int CompareTo(object obj)
		{
			return m_hashCode.CompareTo(((TextLine)obj).m_hashCode);
		}
	}

	public class TextController
	{
		ArrayList m_lines;
		public ArrayList Lines
		{
			get { return m_lines; }
		}

		private const int m_limitedLineLength = 1024;

		int m_maxLength;
		public int MaxLength
		{
			get { return m_maxLength; }
		}

		public TextController()
		{
			m_lines = new ArrayList();
			m_maxLength = 0;
		}

		public TextController(string fileContent)
		{
			m_lines = new ArrayList();
			m_maxLength = 0;
			Setup(fileContent);
		}

		public void Setup(string fileContent)
		{
			string[] _tokens = fileContent.Split('\n');

			foreach (string _item in _tokens)
			{
				if (_item.Length > m_limitedLineLength)
				{
					throw new InvalidOperationException(
						string.Format("File contains a line greater than {0} characters.",
						m_limitedLineLength.ToString()));
				}

				if (_item.Length > m_maxLength)
					m_maxLength = _item.Length;

				m_lines.Add(new TextLine(_item));
			}
		}

		public void UpdateLine(int index, string content)
		{
			((TextLine)GetLineByIndex(index)).ReplaceContent(content);

			if (m_maxLength < content.Length)
				m_maxLength = content.Length;
		}

		public void UpdateLinesWithEnter(int index, string content, string previousLineContent)
		{
			((TextLine)GetLineByIndex(index - 1)).ReplaceContent(previousLineContent);
			m_lines.Insert(index, new TextLine(content));
		}

		public void UpdateLinesWithDelete(int index, string content)
		{
			string _temp = ((TextLine)GetLineByIndex(index)).m_content + ((TextLine)GetLineByIndex(index + 1)).m_content;

			if (_temp.CompareTo(content) == 0)
			{
				m_lines.RemoveAt(index + 1);
			}

			((TextLine)GetLineByIndex(index)).ReplaceContent(content);

			if (m_maxLength < content.Length)
				m_maxLength = content.Length;
		}

		public IComparable GetLineByIndex(int index)
		{
			if (m_lines.Count == index)
				m_lines.Add(new TextLine(""));

			return (TextLine)m_lines[index];
		}

		public int GetLine(int index)
		{
			int _sum = 0;
			int _currentLine = 0;

			while(_sum < index)
			{
				_sum += ((TextLine)GetLineByIndex(_currentLine++)).m_ignoredLine + 1;
			}

			if (_sum > index)
			{
				((TextLine)GetLineByIndex(_currentLine - 1)).m_ignoredLine--;
				m_lines.Insert(_currentLine, new TextLine(""));
			}

			return _currentLine;
		}

		public int Count()
		{
			return m_lines.Count;
		}

		public void Clear()
		{
			m_lines.Clear();
		}
	}

	public static class FileCompareUtils
	{
		public static ArrayList CompareFile(TextController leftController, TextController rightController)
		{
			try
			{
				double _time = 0;
				FileCompareEngine _engine = new FileCompareEngine();

				_engine.Setup(leftController, rightController);
				_time = _engine.Execute();

				return _engine.GetResult();
			}
			catch (Exception ex)
			{
				string tmp = string.Format("{0}{1}{1}***STACK***{1}{2}",
					ex.Message,
					Environment.NewLine,
					ex.StackTrace);
				MessageBox.Show(tmp, "Compare Error");
				return null;
			}
		}

		public static void AppendText(this RichTextBoxAdvanced box, string text, Color foreColor, Color backColor)
		{
			text += '\n';

			box.SelectionStart = box.TextLength;
			box.SelectionLength = text.Length;

			box.SelectionColor = foreColor;
			box.SelectionBackColor = backColor;
			box.AppendText(text);
		}

		public static void Highlighting(this RichTextBoxAdvanced box, int index, Color highlightColor)
		{
			int _lineWidth = System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
			int _lineHeight = Convert.ToInt32(box.Font.Height * box.ZoomFactor);

			using (Graphics g = box.CreateGraphics())
			{
				Pen _pen = new Pen(highlightColor, 2);
				Brush brush = new SolidBrush(highlightColor);

				Rectangle _line = new Rectangle(0, _lineHeight * index, 500, _lineHeight);

				g.DrawRectangle(_pen, _line);

				_pen.Dispose();
			}
		}
	}
}

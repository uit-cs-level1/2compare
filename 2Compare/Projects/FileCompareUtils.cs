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

		public TextLine(string str)
		{
			m_content = str.Replace("\t", "    ");
			m_hashCode = str.GetHashCode();
		}

		public int CompareTo(object obj)
		{
			return m_hashCode.CompareTo(((TextLine)obj).m_hashCode);
		}
	}

	public class FileController
	{
		private ArrayList m_lines;
		private const int m_maxlength = 1024;

		public FileController(string fileContent)
		{
			m_lines = new ArrayList();

			string[] _tokens = fileContent.Split('\n');

			foreach(string item in _tokens)
			{
				if(item.Length > m_maxlength)
				{
					throw new InvalidOperationException(
						string.Format("File contains a line greater than {0} characters.",
						m_maxlength.ToString()));
				}

				m_lines.Add(new TextLine(item));
			}
		}

		public int Count()
		{
			return m_lines.Count;
		}

		public IComparable GetByIndex(int index)
		{
			return (TextLine)m_lines[index];
		}
	}

	public static class FileCompareUtils
	{
		public static FileController m_controllerFileLeft = null;
		public static FileController m_controllerFileRight = null;

		public static ArrayList CompareFile(string fileLeft, string fileRight)
		{
			try
			{
				m_controllerFileLeft = new FileController(fileLeft);
				m_controllerFileRight = new FileController(fileRight);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "File Error");
				return null;
			}

			try
			{
				double time = 0;
				FileCompareEngine _engine = new FileCompareEngine();

				_engine.Setup(m_controllerFileLeft, m_controllerFileRight);
				time = _engine.Execute();

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

		public static void AppendText(this RichTextBox box, string text, Color foreColor, Color backColor)
		{
			text += '\n';

			box.SelectionStart = box.TextLength;
			box.SelectionLength = text.Length;

			box.SelectionColor = foreColor;
			box.SelectionBackColor = backColor;
			box.AppendText(text);
		}
	}
}

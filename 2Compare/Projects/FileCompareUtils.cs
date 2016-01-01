using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace cs511_g11
{
	public class TextLine
	{
		public string m_content;
		public int m_hashCode;

		public TextLine(string str)
		{
			//m_content = str.Replace("\t", "    ");
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
	}

	public static class FileCompareUtils
	{
		public static void CompareFile(string fileLeft, string fileRight)
		{
			FileController _controllerFileLeft = null;
			FileController _controllerFileRight = null;
			try
			{
				_controllerFileLeft = new FileController(fileLeft);
				_controllerFileRight = new FileController(fileRight);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "File Error");
				return;
			}

			/*try
			{
				double time = 0;
				FileCompareEngine de = new FileCompareEngine();
				time = de.ProcessDiff(_controllerFileLeft, _controllerFileRight, 0);

				ArrayList rep = de.DiffReport();
				Results dlg = new Results(_controllerFileLeft, _controllerFileRight, rep, time);
				dlg.ShowDialog();
				dlg.Dispose();
			}
			catch (Exception ex)
			{
				string tmp = string.Format("{0}{1}{1}***STACK***{1}{2}",
					ex.Message,
					Environment.NewLine,
					ex.StackTrace);
				MessageBox.Show(tmp, "Compare Error");
				return;
			}*/
		}
	}
}

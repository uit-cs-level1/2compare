using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DifferenceEngine;

namespace _2Compare.Sources
{
	public partial class mainform : Office2007RibbonForm
	{
		public mainform()
		{

			InitializeComponent();
		}

		private void TextCompare_Click(object sender, EventArgs e)
		{
			this.panel_folder.Show();
			button_back1.Hide();
			button_back2.Hide();
		}

		private void FolderCompare_Click(object sender, EventArgs e)
		{
			button_back1.Show();
			button_back2.Show();
		}



		private bool ValidFile(string fname)
		{
			if (fname != string.Empty)
			{
				if (File.Exists(fname))
				{
					return true;
				}
			}
			return false;
		}

		private void TextDiff(string _first, string _second)
		{
			this.Cursor = Cursors.WaitCursor;

			DiffList_TextFile sLF = null;
			DiffList_TextFile dLF = null;
			try
			{
				sLF = new DiffList_TextFile(_first);
				dLF = new DiffList_TextFile(_second);
			}
			catch (Exception ex)
			{
				this.Cursor = Cursors.Default;
				MessageBox.Show(ex.Message, "File Error");
				return;
			}

			try
			{
				double time = 0;
				DiffEngine de = new DiffEngine();
				time = de.ProcessDiff(sLF, dLF, 0);

				ArrayList rep = de.DiffReport();
				Results dlg = new Results(sLF, dLF, rep, time);
				dlg.ShowDialog();
				dlg.Dispose();
			}
			catch (Exception ex)
			{
				this.Cursor = Cursors.Default;
				string tmp = string.Format("{0}{1}{1}***STACK***{1}{2}",
					ex.Message,
					Environment.NewLine,
					ex.StackTrace);
				MessageBox.Show(tmp, "Compare Error");
				return;
			}
			this.Cursor = Cursors.Default;
		}



		private void button_compare_Click(object sender, EventArgs e)
		{
			string _first = path_1.Text.Trim();
			string _second = path_2.Text.Trim();

			if (!ValidFile(_first))
			{
				MessageBox.Show("Source file name is invalid.", "Invalid File");
				path_1.Focus();
				return;
			}

			if (!ValidFile(_second))
			{
				MessageBox.Show("Destination file name is invalid.", "Invalid File");
				path_2.Focus();
				return;
			}

			TextDiff(_first, _second);
		}

		private void button_help_Click(object sender, EventArgs e)
		{
			helpform help = new helpform();
			help.Show();
		}

		private void button_about_Click(object sender, EventArgs e)
		{
			aboutform about = new aboutform();
			about.Show();
		}

		private void button_exit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(" Save change before exit programme ?", "Exit", MessageBoxButtons.YesNoCancel);
			if (result == DialogResult.Yes)
			{
				MessageBox.Show(" button save clicked ");
				Application.Exit();
			}
			if (result == DialogResult.No)
			{
				Application.Exit();
			}
		}
		public void write_history()
		{
			//string path = @"C:\Users\mai\Desktop\2Compare\Datas\History.txt";

			//StreamWriter sw = new StreamWriter(path,true);
			//string day = DateTime.Now.Day.ToString();
			//string month = DateTime.Now.Month.ToString();
			//string year = DateTime.Now.Year.ToString();
			//string hour = DateTime.Now.Hour.ToString();
			//string minute = DateTime.Now.Minute.ToString();
			//string second = DateTime.Now.Second.ToString();
			//string datetime = day + "/" + month + "/" + year + "......" + hour + ":" + minute + ":" + second;
			//sw.Write(datetime);
			////sw.Flush();
			//sw.Close();


		}

		private void button_history_Click(object sender, EventArgs e)
		{

			string path = @"C:\Users\mai\Desktop\2Compare\Datas\History.txt";


			//string patha = @"C:\Users\an\Documents\Mai.txt";
			//FileStream file = new FileStream(path, FileMode.Open);
			StreamReader shichiki = new StreamReader(path);
			MessageBox.Show(shichiki.ReadToEnd());
			shichiki.Close();
		}

		private void button_open1_Click(object sender, EventArgs e)
		{
			string pathname;
			OpenFileDialog a = new OpenFileDialog();
			if (a.ShowDialog() == DialogResult.OK)
			{
				pathname = a.FileName.ToString();
				path_1.Text = pathname;
				//string patha = @"C:\Users\an\Documents\Mai.txt";
				FileStream file = new FileStream(a.FileName, FileMode.Open);
				StreamReader shichiki = new StreamReader(file, Encoding.UTF8);
				// bame1_1.Text = shichiki.ReadToEnd();

				shichiki.Close();

			}
		}

		private void button_open2_Click(object sender, EventArgs e)
		{
			string pathname;
			OpenFileDialog a = new OpenFileDialog();
			if (a.ShowDialog() == DialogResult.OK)
			{
				pathname = a.FileName.ToString();
				path_2.Text = pathname;
				//string patha = @"C:\Users\an\Documents\Mai.txt";
				FileStream file = new FileStream(a.FileName, FileMode.Open);
				StreamReader shichiki = new StreamReader(file, Encoding.UTF8);
				shichiki.Close();

			}
		}

		private void compare_Click(object sender, EventArgs e)
		{
			write_history();

			string _first = path_1.Text.Trim();
			string _second = path_2.Text.Trim();

			if (!ValidFile(_first))
			{
				MessageBox.Show("Source file name is invalid.", "Invalid File");
				path_1.Focus();
				return;
			}

			if (!ValidFile(_second))
			{
				MessageBox.Show("Destination file name is invalid.", "Invalid File");
				path_2.Focus();
				return;
			}

			TextDiff(_first, _second);
		}

		private void button_save_Click(object sender, EventArgs e)
		{
			SaveFileDialog a = new SaveFileDialog();
			if (a.ShowDialog() == DialogResult.OK)
			{
				//File.WriteAllText(saveFileDialog1.FileName,);

			}

		}
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO;
using System.Collections;

namespace cs511_g11
{
	public partial class MainForm : MetroForm
    {
		RichTextBoxAdvanced m_focusTextBox;

		public MainForm()
		{
			InitializeComponent();
			SetupRichTextbox();

			TextBoxLeft.m_textController = new TextController();
			TextBoxRight.m_textController = new TextController();

			TextBoxLeft.m_textController.Clear();
			TextBoxRight.m_textController.Clear();

			m_focusTextBox = TextBoxLeft;
		}

		private void SetupRichTextbox()
		{
			TextBoxLeft.BindScroll(TextBoxRight);
		}

		private void metroTile2_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(metroTabPage3);
        }

        private void metroTile1_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile1.Style = (MetroColorStyle)5;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            metroTile1.Style = (MetroColorStyle)0;
        }

        private void metroTile2_MouseLeave(object sender, EventArgs e)
        {
            metroTile2.Style = (MetroColorStyle)0;
        }

        private void metroTile2_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile2.Style = (MetroColorStyle)5;
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroContextMenu2.Show(metroButton2, new Point(0, metroButton2.Height));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (White.Checked == true)
            {
                this.Theme = MetroThemeStyle.Light;
                metroStyleManager.Theme = MetroThemeStyle.Light;
                metroUserControl1.BackColor = this.BackColor;
                metroTrackBar2.BackColor = this.BackColor;
                treeView1.BackColor = this.BackColor;
                treeView2.BackColor = this.BackColor;
                HistoryText.BackColor = this.BackColor;

            }
            else
            {
                this.Theme = MetroThemeStyle.Dark;
                metroStyleManager.Theme = MetroThemeStyle.Dark;
                metroUserControl1.BackColor = this.BackColor;
                metroTrackBar2.BackColor = this.BackColor;
                treeView1.BackColor = this.BackColor;
                treeView2.BackColor = this.BackColor;
                HistoryText.BackColor = this.BackColor;

            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Style = (MetroColorStyle)metroTrackBar2.Value;
            metroStyleManager.Style = (MetroColorStyle)metroTrackBar2.Value;
           
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load_1(object sender, EventArgs e)
        {

        }

 

        private void metroTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            int valuecolor= metroTrackBar2.Value;
            if (valuecolor == 0)
                metroTrackBar2.BackColor = Color.Blue;
            else if(valuecolor == 1)
                metroTrackBar2.BackColor = Color.Black;
            else if (valuecolor == 2)
                metroTrackBar2.BackColor = Color.White;
            else if (valuecolor == 3)
                metroTrackBar2.BackColor = Color.Silver;
            else if (valuecolor == 4)
                metroTrackBar2.BackColor = Color.Blue;
            else if (valuecolor == 5)
                metroTrackBar2.BackColor = Color.Green;
            else if (valuecolor == 6)
                metroTrackBar2.BackColor = Color.Lime;
            else if (valuecolor == 7)
                metroTrackBar2.BackColor = Color.Teal;
            else if (valuecolor == 8)
                metroTrackBar2.BackColor = Color.Orange;
            else if (valuecolor == 9)
                metroTrackBar2.BackColor = Color.Brown;
            else if (valuecolor == 10)
                metroTrackBar2.BackColor = Color.Pink;
            else if (valuecolor == 11)
                metroTrackBar2.BackColor = Color.Magenta;
            else if (valuecolor == 12)
                metroTrackBar2.BackColor = Color.Purple;
            else
                metroTrackBar2.BackColor = Color.Red;
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

       

        private void addFolderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        private void show_folder(string path,TreeNode node)//ham liet ket dic
        {
            DirectoryInfo direcinfo = new DirectoryInfo(path);
            DirectoryInfo[] dics = direcinfo.GetDirectories();
            int i = 0;
            foreach (DirectoryInfo dic in dics)
            {

                node.Nodes.Add(dic.Name);
                TreeNode nodes = node.Nodes[i];
                show_folder(path + '/' + dic.Name, nodes);
                i++;

            }
            FileInfo[] files = direcinfo.GetFiles();
            foreach (FileInfo file in files)
            {
                node.Nodes.Add(file.Name);
            }
        }
        private void show_treenode(TreeView x)
        {
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    x.Nodes.Clear();
                    if (x == treeView1)
                    {
                        metroLabel3.Text = fd.SelectedPath;
                    }
                    else { metroLabel4.Text = fd.SelectedPath; }
                    DirectoryInfo direcinfo = new DirectoryInfo(fd.SelectedPath);
                    DirectoryInfo[] dics = direcinfo.GetDirectories();
                    int i = 0;
                    foreach (DirectoryInfo dic in dics)
                    {
                        x.Nodes.Add(dic.Name);
                        TreeNode node = x.Nodes[i];
                        show_folder(fd.SelectedPath + '/' + dic.Name, node);
                        i++;

                    }
                    FileInfo[] files = direcinfo.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        x.Nodes.Add(file.Name);
                    }
                }
            }
            catch
            {
                
            }
        }
        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                show_treenode(treeView1);
            }
            else
                show_treenode(treeView2);
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroContextMenu2_Opening(object sender, CancelEventArgs e)
        {

        }
        bool checkfile(string path1,string path2)
        {
            string s1, s2;
            string line;
            using (StreamReader sr = new StreamReader(path1))
            {
                s1 = sr.ReadToEnd().ToString();
                sr.Close();
            }
            using (StreamReader sr2 = new StreamReader(path2))
            {
                s2 = sr2.ReadToEnd().ToString();
                sr2.Close();
            }
            if (s2.CompareTo(s1) == 0)
                return true;
            else
                return false;
            long length1 = new System.IO.FileInfo(path1).Length;
            long length2 = new System.IO.FileInfo(path2).Length;
            if (length1 != length2)
                return true;
            else
                return false;
        }
        private string listname(TreeNode node)
        {

            int k = 0;
            string name = "";
        nhaylai:
            try
            {

                while (k != 1)
                {
                    name =name+'\\'+node.Text;
                    node = node.NextNode;

                }
            }
            catch
            {
                k = 1;
                goto nhaylai;
            }
            return name;
        }
        private void tomau(TreeNode Node, TreeView xx)
        {
            string[] arrListStr = Node.FullPath.Split('\\');
            string t = arrListStr[0];
            TreeNode X;
            X = xx.Nodes[0];
            while (X.Text != t)
            {
                X = X.NextNode;
            }
            for (int i = 1; i <= arrListStr.Length - 1; i++)
            {
                X.ForeColor = Color.Red;
                X = X.Nodes[0];
                while (X.Text != arrListStr[i])
                {
                    X = X.NextNode;
                }
            }
        }
        private void kiemtradisc(TreeNode Node,TreeView x,TreeView y)
        {
            string[] arrListStr = Node.FullPath.Split('\\');
            string firstnode;
            firstnode = arrListStr[0];

            TreeNode Node2 = y.Nodes[0];
            while (firstnode != Node2.Text)
            {
                Node2 = Node2.NextNode;
            }
            Node = Node.Nodes[0];
            string nodetxt = Node.FullPath;


            int j = 0;
        trl:
            try
            {
                while (j != 1)
                {
                    for (int i = 0; i <= nodetxt.Length - 1; i++)
                    {
                        if (nodetxt[i] == '\\')
                        {
                            Node2 = Node2.Nodes[0];
                        }

                    }
                repeat:
                    string t1 = '\\' + Node.Text;
                    string t2 = Node.Text + '\\';
                    string t = listname(Node2);
                    if ((t.Contains(t1) == false) /*|| (t.Contains(t2) == false)*/)
                    {
                        tomau(Node,x);
                        Node.ForeColor = Color.Red;
                    }
                    else
                    {
                        string te;
                        if (x == treeView1)
                            te = metroLabel3.Text;
                        else
                            te = metroLabel4.Text;
                        FileAttributes attr = File.GetAttributes(te + '\\' + Node.FullPath);

                        //detect whether its a directory or file
                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            kiemtradisc(Node,x,y);
                        }
                        else
                        {

                            if (checkfile(metroLabel3.Text+'\\' + Node.FullPath, metroLabel4.Text + '\\' + Node.FullPath) == false)
                            {
                                tomau(Node,x);
                                Node.ForeColor = Color.Red;
                            }
                        }

                    }
                    Node = Node.NextNode;
                    goto repeat;
                }
            }
            catch
            {
                j = 1;
                goto trl;
            }

        }
        private void compare(TreeView x,TreeView y)
        {
            int j = 0;
        trolai:
            try
            {
                TreeNode knode;
                knode = x.Nodes[0];
                while (j != 1)
                {
                    
                    TreeNode knodes = y.Nodes[0];
                    string t1 = '\\' + knode.Text;
                    string t2 = knode.Text + '\\';
                    string t = listname(knodes);
                    if ((t.Contains(t1) == false) /*|| (t.Contains(t2) == false)*/)
                    {
                        knode.ForeColor = Color.Red;
                    }
                    else
                    {
                        string te;
                        if (x == treeView1)
                            te = metroLabel3.Text;
                        else
                            te = metroLabel4.Text;
                        FileAttributes attr = File.GetAttributes(te + '\\' + knode.FullPath);

                        //detect whether its a directory or file
                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            kiemtradisc(knode, x, y);
                        }
                        else
                        {

                            if (checkfile(metroLabel3.Text + '\\' + knode.FullPath, metroLabel4.Text + '\\' + knode.FullPath) == false)
                            {
                                knode.ForeColor = Color.Red;
                            }
                        }
                    }

                    knode = knode.NextNode;
                }
            }
            catch
            {
                j = 1;
                goto trolai;
            }
        }
        private void compareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((treeView1.Nodes.Count == 0) || (treeView2.Nodes.Count == 0))
            {
                MetroMessageBox.Show(this, "Please Add Folder first.", "Folder Not Found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                compare(treeView1, treeView2);
                compare(treeView2, treeView1);
            }

            // get history when compare text
            

            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string min = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            string result = ngay + "/" + thang + "/" + year + "........" + hour + ":" + min + ":" + second + " Compare Folder "+metroLabel3.Text+"<=>" + metroLabel4.Text;
            string path = @"../../Data/History.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(result);
            sw.Close();
            //sw.Close();
         
        }

		///////////////////////////////////////////////////////////////////////////////
		// File Compare
		private void FileCompareToolbox_Click(object sender, EventArgs e)
		{
			TextCompareMenu.Show(FileCompareToolbox, new Point(0, FileCompareToolbox.Height));
		}

		private bool FileCompare()
		{
			bool _returnValue = true;

			ArrayList _result = FileCompareUtils.CompareFile(TextBoxLeft.m_textController, TextBoxRight.m_textController);

			TextController _leftController = TextBoxLeft.m_textController;
			TextController _rightController = TextBoxRight.m_textController;

			TextBoxLeft.Clear();
			TextBoxRight.Clear();
            // get history when compare
          
          

			for (int i = 0; i < _result.Count; i++)
			{
				DiffResultSpan _item = ((DiffResultSpan)_result[i]);

				switch (_item.Status)
				{
					case DiffResultSpanStatus.SameText:
						for (int j = 0; j < _item.Length; j++)
						{
							string _contentLeft = ((TextLine)_leftController.GetLineByIndex(_item.SourceIndex + j)).m_content;
							string _contentRight = ((TextLine)_rightController.GetLineByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(TextBoxLeft, _contentLeft, Color.Black, Color.White);
							FileCompareUtils.AppendText(TextBoxRight, _contentRight, Color.Black, Color.White);
						}
						break;
					case DiffResultSpanStatus.DiffrenentText:
						for (int j = 0; j < _item.Length; j++)
						{
							string _contentLeft = ((TextLine)_leftController.GetLineByIndex(_item.SourceIndex + j)).m_content;
							string _contentRight = ((TextLine)_rightController.GetLineByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(TextBoxLeft, _contentLeft, Color.Red, Color.LightPink);
							FileCompareUtils.AppendText(TextBoxRight, _contentRight, Color.Red, Color.LightPink);

							//FileCompareUtils.Highlighting(TextBoxLeft, _item.SourceIndex + j, Color.LightPink);
							//FileCompareUtils.Highlighting(TextBoxRight, _item.DestIndex + j, Color.LightPink);
						}

						_returnValue = false;
						break;
					case DiffResultSpanStatus.LeftNotExist:
						for (int j = 0; j < _item.Length; j++)
						{
							//string _contentLeft = ((TextLine)_leftController.GetByIndex(_item.SourceIndex + j)).m_content;
							string _contentRight = ((TextLine)_rightController.GetLineByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(TextBoxLeft, "", Color.Red, Color.LightPink);
							FileCompareUtils.AppendText(TextBoxRight, _contentRight, Color.Red, Color.LightPink);

							//FileCompareUtils.Highlighting(TextBoxLeft, _item.SourceIndex + j, Color.Gray);
							//FileCompareUtils.Highlighting(TextBoxRight, _item.DestIndex + j, Color.LightPink);
						}

						if (_leftController.Lines.Count > 0)   // Left Exist
						{
							int _index = ((DiffResultSpan)_result[i - 1]).SourceIndex + ((DiffResultSpan)_result[i - 1]).Length - 1;
							((TextLine)_leftController.GetLineByIndex(_index)).m_ignoredLine = _item.Length;
						}

						_returnValue = false;
						break;
					case DiffResultSpanStatus.RightNotExist:
						for (int j = 0; j < _item.Length; j++)
						{
							string _contentLeft = ((TextLine)_leftController.GetLineByIndex(_item.SourceIndex + j)).m_content;
							//String _contentRight = ((TextLine)_rightController.GetByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(TextBoxLeft, _contentLeft, Color.Red, Color.LightPink);
							FileCompareUtils.AppendText(TextBoxRight, "", Color.Red, Color.LightPink);

							//FileCompareUtils.Highlighting(TextBoxLeft, _item.SourceIndex + j, Color.LightPink);
							//FileCompareUtils.Highlighting(TextBoxRight, _item.DestIndex + j, Color.Gray);
						}

						if (_rightController.Lines.Count > 0)    // Right Exist
						{
							int _index = ((DiffResultSpan)_result[i - 1]).DestIndex + ((DiffResultSpan)_result[i - 1]).Length - 1;
							((TextLine)_rightController.GetLineByIndex(_index)).m_ignoredLine = _item.Length;
						}

						_returnValue = false;
						break;
				}
			}
            string path1 = File_1.Text;
            string path2 = File_2.Text;
            if (path1 != "" && path2 !="")
            {
                string ngay = DateTime.Now.Day.ToString();
                string thang = DateTime.Now.Month.ToString();
                string year = DateTime.Now.Year.ToString();
                string hour = DateTime.Now.Hour.ToString();
                string min = DateTime.Now.Minute.ToString();
                string second = DateTime.Now.Second.ToString();
                string result = ngay + "/" + thang + "/" + year + "........" + hour + ":" + min + ":" + second + " Compare Text " + File_1.Text + "<=>" + File_2.Text;
                string path = @"../../Data/History.txt";
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(result);
                sw.Close();
            }

			return _returnValue;
		}

        private void SaveFile()
		{
			try
			{
				using (FileStream fs = new FileStream(m_focusTextBox.m_path, FileMode.Create, FileAccess.Write))
				using (StreamWriter _writeStream = new StreamWriter(fs))
				{
					TextController _textController = m_focusTextBox.m_textController;
					for (int i = 0; i < _textController.Lines.Count - 1; i++)
					{
						_writeStream.WriteLine(((TextLine)_textController.GetLineByIndex(i)).m_content);
					}

					_writeStream.Write(((TextLine)_textController.GetLineByIndex(_textController.Lines.Count - 1)).m_content);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: Could not write file to disk. Original error: " + ex.Message);
			}
		}

		private void Add_LeftFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog _dialog = new OpenFileDialog();
			Stream _readStream = null;
           

			if (_dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((_readStream = _dialog.OpenFile()) != null)
					{
						using (_readStream)
						{
							TextBoxLeft.m_textController.Clear();
							TextBoxLeft.m_textController.Setup(File.ReadAllText(_dialog.FileName));
							TextBoxLeft.m_path = _dialog.FileName;
                            File_1.Text = _dialog.FileName.ToString();
							FileCompare();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void Add_RightFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog _dialog = new OpenFileDialog();
			Stream _readStream = null;

			if (_dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((_readStream = _dialog.OpenFile()) != null)
					{
						using (_readStream)
						{
							TextBoxRight.m_textController.Clear();
							TextBoxRight.m_textController.Setup(File.ReadAllText(_dialog.FileName));
							TextBoxRight.m_path = _dialog.FileName;
                            File_2.Text = _dialog.FileName.ToString();
							FileCompare();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void TextCompare_Save_Click(object sender, EventArgs e)
		{
			SaveFile();
		}

		private void TextCompare_Compare_Click(object sender, EventArgs e)
		{
			FileCompare();
		}

		private void TextBoxLeft_TextChanged(object sender, EventArgs e)
		{
			//FileCompare();
		}

		private void TextBoxRight_TextChanged(object sender, EventArgs e)
		{
			//FileCompare();
		}

		private void TextBoxLeft_KeyPress(object sender, KeyPressEventArgs e)
		{
			int _index = TextBoxLeft.SelectionStart;
			int _currentLine = TextBoxLeft.GetLineFromCharIndex(_index);

			int _firstCharIndex = TextBoxLeft.GetFirstCharIndexFromLine(_currentLine);

			if (e.KeyChar == Convert.ToChar(Keys.Return))
			{
				string _content = TextBoxLeft.Lines[_currentLine];
				string _previousLineContent = TextBoxLeft.Lines[_currentLine - 1];
				TextBoxLeft.m_textController.UpdateLinesWithEnter(TextBoxLeft.m_textController.GetLine(_currentLine), _content, _previousLineContent);
			}
		}

		private void TextBoxRight_KeyPress(object sender, KeyPressEventArgs e)
		{
			int _index = TextBoxRight.SelectionStart;
			int _currentLine = TextBoxRight.GetLineFromCharIndex(_index);

			int _firstCharIndex = TextBoxRight.GetFirstCharIndexFromLine(_currentLine);

			if (e.KeyChar == Convert.ToChar(Keys.Return))
			{
				string _content = TextBoxRight.Lines[TextBoxRight.m_textController.GetLine(_currentLine)];
				string _previousLineContent = TextBoxRight.Lines[TextBoxRight.m_textController.GetLine(_currentLine) - 1];
				TextBoxRight.m_textController.UpdateLinesWithEnter(TextBoxRight.m_textController.GetLine(_currentLine), _content, _previousLineContent);
			}
		}

		private void TextBoxLeft_KeyUp(object sender, KeyEventArgs e)
		{
			int _index = TextBoxLeft.SelectionStart;
			int _currentLine = TextBoxLeft.GetLineFromCharIndex(_index);

			string _newContent = TextBoxLeft.Lines[_currentLine];
			TextBoxLeft.m_textController.UpdateLine(TextBoxLeft.m_textController.GetLine(_currentLine), _newContent);
		}

		private void TextBoxRight_KeyUp(object sender, KeyEventArgs e)
		{
			int _index = TextBoxRight.SelectionStart;
			int _currentLine = TextBoxRight.GetLineFromCharIndex(_index);

			string _newContent = TextBoxRight.Lines[_currentLine];
			TextBoxRight.m_textController.UpdateLine(TextBoxRight.m_textController.GetLine(_currentLine), _newContent);
		}

		private void TextBoxLeft_KeyDown(object sender, KeyEventArgs e)
		{
			int _index = TextBoxLeft.SelectionStart;
			int _currentLine = TextBoxLeft.GetLineFromCharIndex(_index);

			if (e.Control && e.KeyCode == Keys.S)
			{
				SaveFile();
			}

			//if (e.Control && e.KeyCode == Keys.C)
			//{
			//	string s = TextBoxLeft.SelectedText;
			//}

			if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
			{
				try
				{
					int _firstCharIndexFromNextLine = TextBoxLeft.GetFirstCharIndexFromLine(_currentLine + 1);

					if (_index + 1 == _firstCharIndexFromNextLine)
					{
						string _content = TextBoxLeft.Lines[_currentLine];
						string _previousContent = TextBoxLeft.Lines[_currentLine + 1];

						TextBoxLeft.m_textController.UpdateLinesWithDelete(TextBoxLeft.m_textController.GetLine(_currentLine), _content + _previousContent, true);
					}
					else
					{
						int _firstCharIndex = TextBoxLeft.GetFirstCharIndexFromLine(_currentLine);

						string _content = TextBoxLeft.Lines[_currentLine];
						_content = _content.Remove(_index - _firstCharIndex, 1);

						TextBoxLeft.m_textController.UpdateLinesWithDelete(TextBoxLeft.m_textController.GetLine(_currentLine), _content);
					}
				}
				catch
				{
					if(TextBoxLeft.Text == "")
						MessageBox.Show("Không có dữ liệu để xử lý!");
				}
			}
			/*else if (e.KeyCode == Keys.Back)
			{
				try
				{
					string _content = TextBoxLeft.Lines[_currentLine];
					TextBoxLeft.m_textController.UpdateLinesWithDelete(TextBoxLeft.m_textController.GetLine(_currentLine), _content);
				}
				catch
				{
					if (TextBoxLeft.Text == "")
						MessageBox.Show("Không có dữ liệu để xử lý!");
				}
			}*/
		}

		private void TextBoxRight_KeyDown(object sender, KeyEventArgs e)
		{
			int _index = TextBoxRight.SelectionStart;
			int _currentLine = TextBoxRight.GetLineFromCharIndex(_index);

			if (e.Control && e.KeyCode == Keys.S)
			{
				SaveFile();
			}

			if (e.KeyCode == Keys.Delete)
			{
				try
				{
					string _content = TextBoxRight.Lines[_currentLine];
					string _previousContent = TextBoxRight.Lines[_currentLine + 1];
					TextBoxRight.m_textController.UpdateLinesWithDelete(TextBoxRight.m_textController.GetLine(_currentLine), _content + _previousContent);
				}
				catch
				{
					if (TextBoxRight.Text == "")
						MessageBox.Show("Không có dữ liệu để xử lý!");
				}
			}
			else if (e.KeyCode == Keys.Back)
			{
				try
				{
					string _content = TextBoxRight.Lines[_currentLine];
					TextBoxRight.m_textController.UpdateLinesWithDelete(TextBoxRight.m_textController.GetLine(_currentLine), _content);
				}
				catch
				{
					if (TextBoxRight.Text == "")
						MessageBox.Show("Không có dữ liệu để xử lý!");
				}
			}
		}

		private void TextBoxLeft_LostFocus(object sender, EventArgs e)
		{
			m_focusTextBox = TextBoxLeft;
		}

		private void TextBoxRight_LostFocus(object sender, EventArgs e)
		{
			m_focusTextBox = TextBoxRight;
		}

    
        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();
            metroLabel3.Text= " ";
            metroLabel4.Text = " ";
        }

        private void History_TextChanged(object sender, EventArgs e)
        {

        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            string path = @"../../Data/History.txt";
            StreamReader a = new StreamReader(path);
            HistoryText.Text = a.ReadToEnd();
            a.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(metroTabPage2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

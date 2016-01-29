using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO;
using System.Collections;
using System.Linq;

namespace cs511_g11
{
	public partial class MainForm : MetroForm
	{
		RichTextBoxAdvanced m_focusTextBox;

		public MainForm()
		{
			InitializeComponent();
			SetupRichTextbox();

			if (!System.IO.Directory.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\2Compare"))
				Directory.CreateDirectory(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\2Compare");

			if (!File.Exists(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\2Compare\\History.cs511"))
				File.CreateText(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\2Compare\\History.cs511");

			TextBoxLeft.m_textController = new TextController();
			TextBoxRight.m_textController = new TextController();

			TextBoxLeft.m_textController.Clear();
			TextBoxRight.m_textController.Clear();

			m_focusTextBox = TextBoxLeft;

			tab_controller.SelectTab(2);

		}

		private void SetupRichTextbox()
		{
			TextBoxLeft.BindScroll(TextBoxRight);
		}

		private void metroTile1_MouseMove(object sender, MouseEventArgs e)
		{
			metroTile1.Style = (MetroColorStyle)5;
		}

		private void metroTile1_MouseLeave(object sender, EventArgs e)
		{
			metroTile1.Style = (MetroColorStyle)0;
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			tab_controller.SelectTab(tab_textCompare);
		}

		private void metroTile2_MouseLeave(object sender, EventArgs e)
		{
			metroTile2.Style = (MetroColorStyle)0;
		}

		private void metroTile2_MouseMove(object sender, MouseEventArgs e)
		{
			metroTile2.Style = (MetroColorStyle)5;
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			tab_controller.SelectTab(tab_folderCompare);
		}

		private void FolderCompareToolbox_Click(object sender, EventArgs e)
		{
			FolderCompareMenu.Show(FolderCompareToolbox, new Point(0, FolderCompareToolbox.Height));
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			if (White.Checked == true)
			{
				this.Theme = MetroThemeStyle.Light;
				metroStyleManager.Theme = MetroThemeStyle.Light;
				metroUserControl1.BackColor = this.BackColor;
				metroTrackBar2.BackColor = this.BackColor;
				TreeViewLeft.BackColor = this.BackColor;
				TreeViewRight.BackColor = this.BackColor;
				HistoryText.BackColor = this.BackColor;

			}
			else
			{
				this.Theme = MetroThemeStyle.Dark;
				metroStyleManager.Theme = MetroThemeStyle.Dark;
				metroUserControl1.BackColor = this.BackColor;
				metroTrackBar2.BackColor = this.BackColor;
				TreeViewLeft.BackColor = this.BackColor;
				TreeViewRight.BackColor = this.BackColor;
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
			int valuecolor = metroTrackBar2.Value;
			if (valuecolor == 0)
				metroTrackBar2.BackColor = Color.Blue;
			else if (valuecolor == 1)
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

		private void TreeViewLeft_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{

		}

		private void TreeViewRight_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{

		}

		private void TreeViewLeft_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.Nodes.Count == 0)
			{
				tab_controller.SelectedIndex = 1;
				string _leftPath = lbl_pathLeft.Text + "\\" + e.Node.FullPath;
				string _rightPath = lbl_pathRight.Text + "\\" + e.Node.FullPath;

				TextBoxLeft.m_textController.Clear();
				TextBoxRight.m_textController.Clear();

				lbl_fileLeft.Text = "";
				lbl_fileRight.Text = "";

				try
				{
					TextBoxLeft.m_textController.Setup(File.ReadAllText(_leftPath));
					TextBoxLeft.m_path = _leftPath;
					lbl_fileLeft.Text = _leftPath.ToString();

					TextBoxRight.m_path = _rightPath;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}

				if (File.Exists(_rightPath))
				{
					try
					{
						TextBoxRight.m_textController.Setup(File.ReadAllText(_rightPath));
						lbl_fileRight.Text = _rightPath.ToString();

						AddHistoryTracking(lbl_fileLeft.Text, lbl_fileRight.Text);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
					}
				}

				FileCompare();
			}
			else
			{
				try
				{
					TreeNode _compareNode = TreeViewRight.Nodes.Find(e.Node.Name, true).First();

					if(e.Node.IsExpanded == true)
					{
						_compareNode.Expand();
					}
					else
					{
						_compareNode.Collapse();
					}
				}
				catch
				{

				}
			}
		}

		private void TreeViewRight_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.Nodes.Count == 0)
			{
				tab_controller.SelectedIndex = 1;
				string _leftPath = lbl_pathLeft.Text + "\\" + e.Node.FullPath;
				string _rightPath = lbl_pathRight.Text + "\\" + e.Node.FullPath;

				TextBoxLeft.m_textController.Clear();
				TextBoxRight.m_textController.Clear();

				lbl_fileLeft.Text = "";
				lbl_fileRight.Text = "";

				try
				{
					TextBoxRight.m_textController.Setup(File.ReadAllText(_rightPath));
					TextBoxRight.m_path = _rightPath;
					lbl_fileRight.Text = _rightPath.ToString();

					TextBoxLeft.m_path = _leftPath;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}

				if (File.Exists(_leftPath))
				{
					try
					{
						TextBoxLeft.m_textController.Setup(File.ReadAllText(_leftPath));
						lbl_fileLeft.Text = _leftPath.ToString();

						AddHistoryTracking(lbl_fileLeft.Text, lbl_fileRight.Text);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
					}
				}

				FileCompare();
			}
			else
			{
				try
				{
					TreeNode _compareNode = TreeViewLeft.Nodes.Find(e.Node.Name, true).First();

					if (e.Node.IsExpanded == true)
					{
						_compareNode.Expand();
					}
					else
					{
						_compareNode.Collapse();
					}
				}
				catch
				{

				}
			}
		}

		private void Add_LeftFolder_Click(object sender, EventArgs e)
		{
			LoadTreeView(TreeViewLeft);

			if (TreeViewRight.Nodes.Count != 0)
			{
				AddHistoryTracking(lbl_pathLeft.Text, lbl_pathRight.Text);
			}
		}

		private void Add_RightFolder_Click(object sender, EventArgs e)
		{
			LoadTreeView(TreeViewRight);

			if (TreeViewLeft.Nodes.Count != 0)
			{
				AddHistoryTracking(lbl_pathLeft.Text, lbl_pathRight.Text);
			}
		}

		private void LoadSubDirectory(string path, TreeNode node)
		{
			DirectoryInfo _rootDirectory = new DirectoryInfo(path);
			DirectoryInfo[] _directories = _rootDirectory.GetDirectories();
			FileInfo[] _files = _rootDirectory.GetFiles();

			foreach (DirectoryInfo dic in _directories)
			{
				LoadSubDirectory(path + '/' + dic.Name, node.Nodes.Add(dic.Name, dic.Name));
			}

			foreach (FileInfo file in _files)
			{
				node.Nodes.Add(file.Name, file.Name);
			}
		}
		private void LoadTreeView(TreeView treeView)
		{
			try
			{
				FolderBrowserDialog _dialog = new FolderBrowserDialog();
				if (_dialog.ShowDialog() == DialogResult.OK)
				{
					treeView.Nodes.Clear();
					if (treeView == TreeViewLeft)
					{
						lbl_pathLeft.Text = _dialog.SelectedPath;
					}
					else
					{
						lbl_pathRight.Text = _dialog.SelectedPath;
					}

					DirectoryInfo _rootDirectory = new DirectoryInfo(_dialog.SelectedPath);
					DirectoryInfo[] _directories = _rootDirectory.GetDirectories();
					FileInfo[] _files = _rootDirectory.GetFiles();

					foreach (DirectoryInfo dic in _directories)
					{
						LoadSubDirectory(_dialog.SelectedPath + '/' + dic.Name, treeView.Nodes.Add(dic.Name, dic.Name));
					}

					foreach (FileInfo file in _files)
					{
						treeView.Nodes.Add(file.Name, file.Name);
					}
				}
			}
			catch
			{

			}
		}

		bool CompareFile(string path1, string path2)
		{
			//string s1, s2;
			//string line;
			//using (StreamReader sr = new StreamReader(path1))
			//{
			//	s1 = sr.ReadToEnd().ToString();
			//	sr.Close();
			//}
			//using (StreamReader sr2 = new StreamReader(path2))
			//{
			//	s2 = sr2.ReadToEnd().ToString();
			//	sr2.Close();
			//}
			//if (s2.GetHashCode().CompareTo(s1.GetHashCode()) == 0)
			//	return true;
			//else
			//	return false;
			//long length1 = new System.IO.FileInfo(path1).Length;
			//long length2 = new System.IO.FileInfo(path2).Length;
			//if (length1 != length2)
			//	return true;
			//else
			//	return false;

			FileInfo _left = new FileInfo(path1);
			FileInfo _right = new FileInfo(path2);

			if (_left.Length != _right.Length)
				return false;
			return true;
		}

		private bool Analyze(TreeNode source, TreeNode element, string sourceRootDirectory, string elementRootDirectory)
		{
			try
			{
				TreeNode _compareNode = source.Nodes
									.Cast<TreeNode>()
									.Where(r => r.Text == element.Text)
									.First();

				TreeNodeCollection _nodes = element.Nodes;

				if (_nodes.Count > 0)
				{
					bool _isSame = true;
					foreach (TreeNode _node in _nodes)
					{
						if(Analyze(_compareNode, _node, sourceRootDirectory, elementRootDirectory) == false)
							_isSame = false;
					}

					if (_isSame == false)
					{
						element.ForeColor = Color.Red;
						_compareNode.ForeColor = Color.Red;

						return false;
					}
				}
				else if (_compareNode.Nodes.Count == 0)
				{
					if (CompareFile(sourceRootDirectory + "\\" + element.FullPath, elementRootDirectory + "\\" + _compareNode.FullPath) == false)
					{
						element.ForeColor = Color.Red;
						_compareNode.ForeColor = Color.Red;

						return false;
					}
				}

				return true;
			}
			catch
			{
				element.ForeColor = Color.Red;
				return false;
			}
		}

		private void TreeViewCompare(TreeView firstTreeView, TreeView secondTreeView, string firstRootDirectory, string secondRootDirectory)
		{
			TreeNodeCollection _nodes = firstTreeView.Nodes;
			foreach (TreeNode _node in _nodes)
			{
				try
				{
					TreeNode _compareNode = secondTreeView.Nodes
									.Cast<TreeNode>()
									.Where(r => r.Text == _node.Text)
									.First();

					TreeNodeCollection _subNodes = _node.Nodes;

					if (_subNodes.Count > 0)
					{
						bool _isSame = true;
						foreach (TreeNode _subNode in _subNodes)
						{
							if(Analyze(_compareNode, _subNode, firstRootDirectory, secondRootDirectory) == false)
								_isSame = false;
						}

						if (_isSame == false)
						{
							_node.ForeColor = Color.Red;
							_compareNode.ForeColor = Color.Red;
						}
					}
					else if (_compareNode.Nodes.Count == 0)
					{
						if (CompareFile(firstRootDirectory + "\\" + _node.FullPath, secondRootDirectory + "\\" + _compareNode.FullPath) == false)
						{
							_node.ForeColor = Color.Red;
							_compareNode.ForeColor = Color.Red;
						}
					}
				}
				catch
				{
					_node.ForeColor = Color.Red;
				}
			}
		}

		private void FolderCompare_Compare_Click(object sender, EventArgs e)
		{
			if ((TreeViewLeft.Nodes.Count == 0) || (TreeViewRight.Nodes.Count == 0))
			{
				MetroMessageBox.Show(this, "Please Add Folder first.", "Folder Not Found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
			else
			{
				//compare(TreeViewLeft, TreeViewRight);
				//compare(TreeViewRight, TreeViewLeft);

				TreeViewCompare(TreeViewLeft, TreeViewRight, lbl_pathLeft.Text, lbl_pathRight.Text);
				TreeViewCompare(TreeViewRight, TreeViewLeft, lbl_pathRight.Text, lbl_pathLeft.Text);
			}
		}

		private void FolderCompare_Reset_Click(object sender, EventArgs e)
		{
			TreeViewLeft.Nodes.Clear();
			TreeViewRight.Nodes.Clear();
			lbl_pathLeft.Text = " ";
			lbl_pathRight.Text = " ";
		}

		///////////////////////////////////////////////////////////////////////////////
		// File Compare
		private void FileCompareToolbox_Click(object sender, EventArgs e)
		{
			TextCompareMenu.Show(FileCompareToolbox, new Point(0, FileCompareToolbox.Height));
		}

		private void FileCompare()
		{
			ArrayList _result = FileCompareUtils.CompareFile(TextBoxLeft.m_textController, TextBoxRight.m_textController);

			TextController _leftController = TextBoxLeft.m_textController;
			TextController _rightController = TextBoxRight.m_textController;

			TextBoxLeft.Clear();
			TextBoxRight.Clear();
			// get history when compare



			for (int i = 0; i < _result.Count; i++)
			{
				DifferentResult _item = ((DifferentResult)_result[i]);

				switch (_item.Status)
				{
					case ResultStatus.SameText:
						for (int j = 0; j < _item.Length; j++)
						{
							string _contentLeft = ((TextLine)_leftController.GetLineByIndex(_item.SourceIndex + j)).m_content;
							string _contentRight = ((TextLine)_rightController.GetLineByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(TextBoxLeft, _contentLeft, Color.Black, Color.White);
							FileCompareUtils.AppendText(TextBoxRight, _contentRight, Color.Black, Color.White);
						}
						break;
					case ResultStatus.DiffrenentText:
						for (int j = 0; j < _item.Length; j++)
						{
							string _contentLeft = ((TextLine)_leftController.GetLineByIndex(_item.SourceIndex + j)).m_content;
							string _contentRight = ((TextLine)_rightController.GetLineByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(TextBoxLeft, _contentLeft, Color.Red, Color.LightPink);
							FileCompareUtils.AppendText(TextBoxRight, _contentRight, Color.Red, Color.LightPink);

							//FileCompareUtils.Highlighting(TextBoxLeft, _item.SourceIndex + j, Color.LightPink);
							//FileCompareUtils.Highlighting(TextBoxRight, _item.DestIndex + j, Color.LightPink);
						}
						break;
					case ResultStatus.LeftNotExist:
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
							try
							{
								int _index = ((DifferentResult)_result[i - 1]).SourceIndex + ((DifferentResult)_result[i - 1]).Length - 1;
								((TextLine)_leftController.GetLineByIndex(_index)).m_ignoredLine = _item.Length;
							}
							catch
							{

							}
						}
						break;
					case ResultStatus.RightNotExist:
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
							try
							{
								int _index = ((DifferentResult)_result[i - 1]).DestIndex + ((DifferentResult)_result[i - 1]).Length - 1;
								((TextLine)_rightController.GetLineByIndex(_index)).m_ignoredLine = _item.Length;
							}
							catch
							{

							}
						}
						break;
				}
			}
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
							lbl_fileLeft.Text = _dialog.FileName.ToString();

							if (TextBoxRight.m_textController.Lines.Count != 0)
							{
								AddHistoryTracking(lbl_fileLeft.Text, lbl_fileRight.Text);
							}

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
							lbl_fileRight.Text = _dialog.FileName.ToString();

							if (TextBoxLeft.m_textController.Lines.Count != 0)
							{
								AddHistoryTracking(lbl_fileLeft.Text, lbl_fileRight.Text);
							}

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

		private void TextBoxLeft_LostFocus(object sender, EventArgs e)
		{
			m_focusTextBox = TextBoxLeft;
		}

		private void TextBoxRight_LostFocus(object sender, EventArgs e)
		{
			m_focusTextBox = TextBoxRight;
		}

		private void btn_toRight_Click(object sender, EventArgs e)
		{
			TextBoxRight.Clear();
			TextBoxRight.m_textController.Clear();

			TextController _textController = TextBoxLeft.m_textController;

			for (int i = 0; i < _textController.Lines.Count; i++)
			{
				string _content = ((TextLine)_textController.GetLineByIndex(i)).m_content;
				TextBoxRight.Text += _content;
				TextBoxRight.m_textController.AddLine(_content);
			}

			FileCompare();
		}

		private void btn_toLeft_Click(object sender, EventArgs e)
		{
			TextBoxLeft.Clear();
			TextBoxLeft.m_textController.Clear();

			TextController _textController = TextBoxRight.m_textController;

			for (int i = 0; i < _textController.Lines.Count; i++)
			{
				string _content = ((TextLine)_textController.GetLineByIndex(i)).m_content;
				TextBoxLeft.Text += _content;
				TextBoxLeft.m_textController.AddLine(_content);
			}

			FileCompare();
		}


		//////////////////////////////////////////////////////////////
		// History
		private void HistoryButton_Click(object sender, EventArgs e)
		{
			string path = Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\2Compare\\History.cs511";
			StreamReader a = new StreamReader(path);
			HistoryText.Text = a.ReadToEnd();
			a.Close();
		}

		private void AddHistoryTracking(string leftPath, string rightPath)
		{
			DateTime _currentTime = DateTime.Now;
			string result = leftPath + "<=>" + rightPath + " | " + _currentTime.ToShortDateString() + " " + _currentTime.ToLongTimeString();

			StreamWriter sw = new StreamWriter(Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\2Compare\\History.cs511", true);
			sw.WriteLine(result);
			sw.Close();
		}
	}
}

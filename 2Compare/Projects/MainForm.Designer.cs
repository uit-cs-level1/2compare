namespace cs511_g11
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tab_controller = new MetroFramework.Controls.MetroTabControl();
			this.tab_howToUse = new MetroFramework.Controls.MetroTabPage();
			this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.tab_textCompare = new MetroFramework.Controls.MetroTabPage();
			this.btn_toLeftFile = new System.Windows.Forms.Button();
			this.btn_toRightFile = new System.Windows.Forms.Button();
			this.lbl_fileRight = new MetroFramework.Controls.MetroLabel();
			this.lbl_fileLeft = new MetroFramework.Controls.MetroLabel();
			this.FileCompareToolbox = new MetroFramework.Controls.MetroButton();
			this.TextBoxLeft = new cs511_g11.RichTextBoxAdvanced();
			this.TextBoxRight = new cs511_g11.RichTextBoxAdvanced();
			this.tab_folderCompare = new MetroFramework.Controls.MetroTabPage();
			this.TreeViewRight = new System.Windows.Forms.TreeView();
			this.lbl_pathRight = new MetroFramework.Controls.MetroLabel();
			this.lbl_pathLeft = new MetroFramework.Controls.MetroLabel();
			this.TreeViewLeft = new System.Windows.Forms.TreeView();
			this.FolderCompareToolbox = new MetroFramework.Controls.MetroButton();
			this.tab_theme = new MetroFramework.Controls.MetroTabPage();
			this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
			this.White = new MetroFramework.Controls.MetroRadioButton();
			this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.tab_information = new MetroFramework.Controls.MetroTabPage();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.tab_history = new MetroFramework.Controls.MetroTabPage();
			this.HistoryText = new System.Windows.Forms.RichTextBox();
			this.HistoryButton = new MetroFramework.Controls.MetroButton();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
			this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
			this.TextCompareMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.TextCompare_AddFile = new System.Windows.Forms.ToolStripMenuItem();
			this.Add_LeftFile = new System.Windows.Forms.ToolStripMenuItem();
			this.Add_RightFile = new System.Windows.Forms.ToolStripMenuItem();
			this.TextCompare_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.TextCompare_Compare = new System.Windows.Forms.ToolStripMenuItem();
			this.FolderCompareMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.FolderCompare_AddFile = new System.Windows.Forms.ToolStripMenuItem();
			this.Add_LeftFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.Add_RightFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.FolderCompare_Compare = new System.Windows.Forms.ToolStripMenuItem();
			this.FolderCompare_Reset = new System.Windows.Forms.ToolStripMenuItem();
			this.tab_controller.SuspendLayout();
			this.tab_howToUse.SuspendLayout();
			this.tab_textCompare.SuspendLayout();
			this.tab_folderCompare.SuspendLayout();
			this.tab_theme.SuspendLayout();
			this.tab_information.SuspendLayout();
			this.tab_history.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
			this.TextCompareMenu.SuspendLayout();
			this.FolderCompareMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_controller
			// 
			this.tab_controller.Controls.Add(this.tab_howToUse);
			this.tab_controller.Controls.Add(this.tab_textCompare);
			this.tab_controller.Controls.Add(this.tab_folderCompare);
			this.tab_controller.Controls.Add(this.tab_theme);
			this.tab_controller.Controls.Add(this.tab_information);
			this.tab_controller.Controls.Add(this.tab_history);
			this.tab_controller.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_controller.Location = new System.Drawing.Point(23, 60);
			this.tab_controller.Name = "tab_controller";
			this.tab_controller.SelectedIndex = 5;
			this.tab_controller.Size = new System.Drawing.Size(978, 520);
			this.tab_controller.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tab_controller.TabIndex = 0;
			this.tab_controller.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.tab_controller.UseSelectable = true;
			this.tab_controller.UseStyleColors = true;
			// 
			// tab_howToUse
			// 
			this.tab_howToUse.BackColor = System.Drawing.SystemColors.Control;
			this.tab_howToUse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tab_howToUse.Controls.Add(this.metroUserControl1);
			this.tab_howToUse.Controls.Add(this.metroTile2);
			this.tab_howToUse.Controls.Add(this.metroLabel2);
			this.tab_howToUse.Controls.Add(this.metroTile1);
			this.tab_howToUse.HorizontalScrollbarBarColor = true;
			this.tab_howToUse.HorizontalScrollbarHighlightOnWheel = false;
			this.tab_howToUse.HorizontalScrollbarSize = 10;
			this.tab_howToUse.Location = new System.Drawing.Point(4, 38);
			this.tab_howToUse.Name = "tab_howToUse";
			this.tab_howToUse.Size = new System.Drawing.Size(970, 478);
			this.tab_howToUse.TabIndex = 0;
			this.tab_howToUse.Text = "How To Use";
			this.tab_howToUse.VerticalScrollbarBarColor = true;
			this.tab_howToUse.VerticalScrollbarHighlightOnWheel = false;
			this.tab_howToUse.VerticalScrollbarSize = 3;
			// 
			// metroUserControl1
			// 
			this.metroUserControl1.BackColor = System.Drawing.Color.White;
			this.metroUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroUserControl1.BackgroundImage")));
			this.metroUserControl1.Location = new System.Drawing.Point(332, 172);
			this.metroUserControl1.Name = "metroUserControl1";
			this.metroUserControl1.Size = new System.Drawing.Size(113, 98);
			this.metroUserControl1.TabIndex = 4;
			this.metroUserControl1.UseSelectable = true;
			this.metroUserControl1.UseStyleColors = true;
			this.metroUserControl1.Load += new System.EventHandler(this.metroUserControl1_Load_1);
			// 
			// metroTile2
			// 
			this.metroTile2.ActiveControl = null;
			this.metroTile2.AutoSize = true;
			this.metroTile2.Location = new System.Drawing.Point(445, 243);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(203, 77);
			this.metroTile2.TabIndex = 3;
			this.metroTile2.Text = "Folder Compare";
			this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.metroTile2, "Use To Compare 2 Folder\r\n");
			this.metroTile2.UseSelectable = true;
			this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
			this.metroTile2.MouseLeave += new System.EventHandler(this.metroTile2_MouseLeave);
			this.metroTile2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile2_MouseMove);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.Location = new System.Drawing.Point(107, 210);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(230, 25);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "We have two main functions:";
			this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroLabel2.UseStyleColors = true;
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.AutoSize = true;
			this.metroTile1.Location = new System.Drawing.Point(445, 117);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(203, 77);
			this.metroTile1.TabIndex = 2;
			this.metroTile1.Text = "Text Compare";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroToolTip1.SetToolTip(this.metroTile1, "Use to Compare 2 Text Files");
			this.metroTile1.UseSelectable = true;
			this.metroTile1.UseStyleColors = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
			this.metroTile1.MouseLeave += new System.EventHandler(this.metroTile1_MouseLeave);
			this.metroTile1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile1_MouseMove);
			// 
			// tab_textCompare
			// 
			this.tab_textCompare.Controls.Add(this.btn_toLeftFile);
			this.tab_textCompare.Controls.Add(this.btn_toRightFile);
			this.tab_textCompare.Controls.Add(this.lbl_fileRight);
			this.tab_textCompare.Controls.Add(this.lbl_fileLeft);
			this.tab_textCompare.Controls.Add(this.FileCompareToolbox);
			this.tab_textCompare.Controls.Add(this.TextBoxLeft);
			this.tab_textCompare.Controls.Add(this.TextBoxRight);
			this.tab_textCompare.HorizontalScrollbarBarColor = true;
			this.tab_textCompare.HorizontalScrollbarHighlightOnWheel = false;
			this.tab_textCompare.HorizontalScrollbarSize = 10;
			this.tab_textCompare.Location = new System.Drawing.Point(4, 38);
			this.tab_textCompare.Name = "tab_textCompare";
			this.tab_textCompare.Size = new System.Drawing.Size(970, 478);
			this.tab_textCompare.TabIndex = 1;
			this.tab_textCompare.Text = "Text Compare";
			this.tab_textCompare.VerticalScrollbarBarColor = true;
			this.tab_textCompare.VerticalScrollbarHighlightOnWheel = false;
			this.tab_textCompare.VerticalScrollbarSize = 3;
			// 
			// btn_toLeftFile
			// 
			this.btn_toLeftFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_toLeftFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_toLeftFile.Location = new System.Drawing.Point(465, 258);
			this.btn_toLeftFile.Name = "btn_toLeftFile";
			this.btn_toLeftFile.Size = new System.Drawing.Size(42, 44);
			this.btn_toLeftFile.TabIndex = 12;
			this.btn_toLeftFile.Text = "<<";
			this.btn_toLeftFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_toLeftFile.UseVisualStyleBackColor = false;
			this.btn_toLeftFile.Click += new System.EventHandler(this.btn_toLeft_Click);
			// 
			// btn_toRightFile
			// 
			this.btn_toRightFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_toRightFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_toRightFile.Location = new System.Drawing.Point(465, 188);
			this.btn_toRightFile.Name = "btn_toRightFile";
			this.btn_toRightFile.Size = new System.Drawing.Size(42, 44);
			this.btn_toRightFile.TabIndex = 11;
			this.btn_toRightFile.Text = ">>";
			this.btn_toRightFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_toRightFile.UseVisualStyleBackColor = false;
			this.btn_toRightFile.Click += new System.EventHandler(this.btn_toRight_Click);
			// 
			// lbl_fileRight
			// 
			this.lbl_fileRight.AutoSize = true;
			this.lbl_fileRight.Location = new System.Drawing.Point(515, 37);
			this.lbl_fileRight.Name = "lbl_fileRight";
			this.lbl_fileRight.Size = new System.Drawing.Size(63, 19);
			this.lbl_fileRight.TabIndex = 8;
			this.lbl_fileRight.Text = "File Right";
			this.lbl_fileRight.UseStyleColors = true;
			// 
			// lbl_fileLeft
			// 
			this.lbl_fileLeft.AutoSize = true;
			this.lbl_fileLeft.Location = new System.Drawing.Point(0, 37);
			this.lbl_fileLeft.Name = "lbl_fileLeft";
			this.lbl_fileLeft.Size = new System.Drawing.Size(54, 19);
			this.lbl_fileLeft.TabIndex = 7;
			this.lbl_fileLeft.Text = "File Left";
			this.lbl_fileLeft.UseStyleColors = true;
			// 
			// FileCompareToolbox
			// 
			this.FileCompareToolbox.Location = new System.Drawing.Point(3, 3);
			this.FileCompareToolbox.Name = "FileCompareToolbox";
			this.FileCompareToolbox.Size = new System.Drawing.Size(77, 27);
			this.FileCompareToolbox.TabIndex = 2;
			this.FileCompareToolbox.Text = "ToolBox";
			this.FileCompareToolbox.UseSelectable = true;
			this.FileCompareToolbox.UseStyleColors = true;
			this.FileCompareToolbox.Click += new System.EventHandler(this.FileCompareToolbox_Click);
			// 
			// TextBoxLeft
			// 
			this.TextBoxLeft.AcceptsTab = true;
			this.TextBoxLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.TextBoxLeft.EnableAutoDragDrop = true;
			this.TextBoxLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxLeft.Location = new System.Drawing.Point(0, 60);
			this.TextBoxLeft.Margin = new System.Windows.Forms.Padding(5);
			this.TextBoxLeft.Name = "TextBoxLeft";
			this.TextBoxLeft.ReadOnly = true;
			this.TextBoxLeft.Size = new System.Drawing.Size(455, 418);
			this.TextBoxLeft.TabIndex = 9;
			this.TextBoxLeft.Text = "";
			this.TextBoxLeft.WordWrap = false;
			this.TextBoxLeft.LostFocus += new System.EventHandler(this.TextBoxLeft_LostFocus);
			// 
			// TextBoxRight
			// 
			this.TextBoxRight.AcceptsTab = true;
			this.TextBoxRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.TextBoxRight.EnableAutoDragDrop = true;
			this.TextBoxRight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxRight.Location = new System.Drawing.Point(516, 59);
			this.TextBoxRight.Margin = new System.Windows.Forms.Padding(5);
			this.TextBoxRight.Name = "TextBoxRight";
			this.TextBoxRight.ReadOnly = true;
			this.TextBoxRight.Size = new System.Drawing.Size(455, 418);
			this.TextBoxRight.TabIndex = 10;
			this.TextBoxRight.Text = "";
			this.TextBoxRight.WordWrap = false;
			this.TextBoxRight.LostFocus += new System.EventHandler(this.TextBoxRight_LostFocus);
			// 
			// tab_folderCompare
			// 
			this.tab_folderCompare.Controls.Add(this.TreeViewRight);
			this.tab_folderCompare.Controls.Add(this.lbl_pathRight);
			this.tab_folderCompare.Controls.Add(this.lbl_pathLeft);
			this.tab_folderCompare.Controls.Add(this.TreeViewLeft);
			this.tab_folderCompare.Controls.Add(this.FolderCompareToolbox);
			this.tab_folderCompare.HorizontalScrollbarBarColor = true;
			this.tab_folderCompare.HorizontalScrollbarHighlightOnWheel = false;
			this.tab_folderCompare.HorizontalScrollbarSize = 10;
			this.tab_folderCompare.Location = new System.Drawing.Point(4, 38);
			this.tab_folderCompare.Name = "tab_folderCompare";
			this.tab_folderCompare.Size = new System.Drawing.Size(970, 478);
			this.tab_folderCompare.TabIndex = 2;
			this.tab_folderCompare.Text = "Folder Compare";
			this.tab_folderCompare.VerticalScrollbarBarColor = true;
			this.tab_folderCompare.VerticalScrollbarHighlightOnWheel = false;
			this.tab_folderCompare.VerticalScrollbarSize = 3;
			// 
			// TreeViewRight
			// 
			this.TreeViewRight.ForeColor = System.Drawing.Color.Gray;
			this.TreeViewRight.Location = new System.Drawing.Point(515, 60);
			this.TreeViewRight.Name = "TreeViewRight";
			this.TreeViewRight.Size = new System.Drawing.Size(455, 418);
			this.TreeViewRight.TabIndex = 7;
			this.TreeViewRight.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewRight_AfterCollapse);
			this.TreeViewRight.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewRight_AfterExpand);
			this.TreeViewRight.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewRight_NodeMouseClick);
			this.TreeViewRight.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewRight_NodeMouseDoubleClick);
			// 
			// lbl_pathRight
			// 
			this.lbl_pathRight.AutoSize = true;
			this.lbl_pathRight.Location = new System.Drawing.Point(515, 37);
			this.lbl_pathRight.Name = "lbl_pathRight";
			this.lbl_pathRight.Size = new System.Drawing.Size(68, 19);
			this.lbl_pathRight.TabIndex = 6;
			this.lbl_pathRight.Text = "Path Right";
			this.lbl_pathRight.UseStyleColors = true;
			// 
			// lbl_pathLeft
			// 
			this.lbl_pathLeft.AutoSize = true;
			this.lbl_pathLeft.Location = new System.Drawing.Point(0, 37);
			this.lbl_pathLeft.Name = "lbl_pathLeft";
			this.lbl_pathLeft.Size = new System.Drawing.Size(59, 19);
			this.lbl_pathLeft.TabIndex = 5;
			this.lbl_pathLeft.Text = "Path Left";
			this.lbl_pathLeft.UseStyleColors = true;
			// 
			// TreeViewLeft
			// 
			this.TreeViewLeft.ForeColor = System.Drawing.Color.Gray;
			this.TreeViewLeft.Location = new System.Drawing.Point(0, 60);
			this.TreeViewLeft.Name = "TreeViewLeft";
			this.TreeViewLeft.Size = new System.Drawing.Size(455, 418);
			this.TreeViewLeft.TabIndex = 3;
			this.TreeViewLeft.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewLeft_AfterCollapse);
			this.TreeViewLeft.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewLeft_AfterExpand);
			this.TreeViewLeft.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewLeft_NodeMouseClick);
			this.TreeViewLeft.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewLeft_NodeMouseDoubleClick);
			// 
			// FolderCompareToolbox
			// 
			this.FolderCompareToolbox.Location = new System.Drawing.Point(3, 3);
			this.FolderCompareToolbox.Name = "FolderCompareToolbox";
			this.FolderCompareToolbox.Size = new System.Drawing.Size(77, 27);
			this.FolderCompareToolbox.TabIndex = 2;
			this.FolderCompareToolbox.Text = "ToolBox";
			this.FolderCompareToolbox.UseSelectable = true;
			this.FolderCompareToolbox.UseStyleColors = true;
			this.FolderCompareToolbox.Click += new System.EventHandler(this.FolderCompareToolbox_Click);
			// 
			// tab_theme
			// 
			this.tab_theme.Controls.Add(this.metroRadioButton2);
			this.tab_theme.Controls.Add(this.White);
			this.tab_theme.Controls.Add(this.metroTrackBar2);
			this.tab_theme.Controls.Add(this.metroButton4);
			this.tab_theme.Controls.Add(this.metroButton3);
			this.tab_theme.HorizontalScrollbarBarColor = true;
			this.tab_theme.HorizontalScrollbarHighlightOnWheel = false;
			this.tab_theme.HorizontalScrollbarSize = 10;
			this.tab_theme.Location = new System.Drawing.Point(4, 38);
			this.tab_theme.Name = "tab_theme";
			this.tab_theme.Size = new System.Drawing.Size(970, 478);
			this.tab_theme.TabIndex = 3;
			this.tab_theme.Text = "Theme";
			this.tab_theme.VerticalScrollbarBarColor = true;
			this.tab_theme.VerticalScrollbarHighlightOnWheel = false;
			this.tab_theme.VerticalScrollbarSize = 3;
			this.tab_theme.Click += new System.EventHandler(this.metroTabPage4_Click);
			// 
			// metroRadioButton2
			// 
			this.metroRadioButton2.AutoSize = true;
			this.metroRadioButton2.Location = new System.Drawing.Point(165, 68);
			this.metroRadioButton2.Name = "metroRadioButton2";
			this.metroRadioButton2.Size = new System.Drawing.Size(51, 15);
			this.metroRadioButton2.TabIndex = 7;
			this.metroRadioButton2.Text = "Black";
			this.metroRadioButton2.UseSelectable = true;
			// 
			// White
			// 
			this.White.AutoSize = true;
			this.White.Checked = true;
			this.White.Location = new System.Drawing.Point(165, 46);
			this.White.Name = "White";
			this.White.Size = new System.Drawing.Size(54, 15);
			this.White.TabIndex = 6;
			this.White.TabStop = true;
			this.White.Text = "White";
			this.White.UseSelectable = true;
			this.White.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
			// 
			// metroTrackBar2
			// 
			this.metroTrackBar2.BackColor = System.Drawing.Color.White;
			this.metroTrackBar2.ForeColor = System.Drawing.Color.Red;
			this.metroTrackBar2.LargeChange = 4;
			this.metroTrackBar2.Location = new System.Drawing.Point(133, 100);
			this.metroTrackBar2.Maximum = 13;
			this.metroTrackBar2.Name = "metroTrackBar2";
			this.metroTrackBar2.Size = new System.Drawing.Size(233, 55);
			this.metroTrackBar2.TabIndex = 5;
			this.metroTrackBar2.Text = "metroTrackBar2";
			this.metroTrackBar2.UseCustomBackColor = true;
			this.metroTrackBar2.Value = 0;
			this.metroTrackBar2.ValueChanged += new System.EventHandler(this.metroTrackBar2_ValueChanged);
			// 
			// metroButton4
			// 
			this.metroButton4.Location = new System.Drawing.Point(16, 115);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new System.Drawing.Size(112, 23);
			this.metroButton4.TabIndex = 4;
			this.metroButton4.Text = "Change Style";
			this.metroButton4.UseSelectable = true;
			this.metroButton4.UseStyleColors = true;
			this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(16, 51);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(112, 23);
			this.metroButton3.TabIndex = 2;
			this.metroButton3.Text = "Change Theme";
			this.metroButton3.UseSelectable = true;
			this.metroButton3.UseStyleColors = true;
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// tab_information
			// 
			this.tab_information.Controls.Add(this.metroLabel1);
			this.tab_information.HorizontalScrollbarBarColor = true;
			this.tab_information.HorizontalScrollbarHighlightOnWheel = false;
			this.tab_information.HorizontalScrollbarSize = 10;
			this.tab_information.Location = new System.Drawing.Point(4, 38);
			this.tab_information.Name = "tab_information";
			this.tab_information.Size = new System.Drawing.Size(970, 478);
			this.tab_information.TabIndex = 4;
			this.tab_information.Text = "Information";
			this.tab_information.VerticalScrollbarBarColor = true;
			this.tab_information.VerticalScrollbarHighlightOnWheel = false;
			this.tab_information.VerticalScrollbarSize = 3;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(286, 59);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(205, 133);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "SOFTWARE DEVELOPED BY............\r\n\r\nRye Nguyen\r\nShichi Ki\r\nKen Pop\r\nKhoa Pham\r\n";
			this.metroLabel1.UseStyleColors = true;
			// 
			// tab_history
			// 
			this.tab_history.Controls.Add(this.HistoryText);
			this.tab_history.Controls.Add(this.HistoryButton);
			this.tab_history.HorizontalScrollbarBarColor = true;
			this.tab_history.HorizontalScrollbarHighlightOnWheel = false;
			this.tab_history.HorizontalScrollbarSize = 10;
			this.tab_history.Location = new System.Drawing.Point(4, 38);
			this.tab_history.Name = "tab_history";
			this.tab_history.Size = new System.Drawing.Size(970, 478);
			this.tab_history.TabIndex = 5;
			this.tab_history.Text = "History";
			this.tab_history.VerticalScrollbarBarColor = true;
			this.tab_history.VerticalScrollbarHighlightOnWheel = false;
			this.tab_history.VerticalScrollbarSize = 3;
			// 
			// HistoryText
			// 
			this.HistoryText.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.HistoryText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HistoryText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.HistoryText.Location = new System.Drawing.Point(338, 20);
			this.HistoryText.Name = "HistoryText";
			this.HistoryText.ReadOnly = true;
			this.HistoryText.Size = new System.Drawing.Size(592, 430);
			this.HistoryText.TabIndex = 4;
			this.HistoryText.Text = "";
			this.HistoryText.WordWrap = false;
			// 
			// HistoryButton
			// 
			this.HistoryButton.Location = new System.Drawing.Point(65, 213);
			this.HistoryButton.Name = "HistoryButton";
			this.HistoryButton.Size = new System.Drawing.Size(109, 45);
			this.HistoryButton.TabIndex = 3;
			this.HistoryButton.Text = "Show History";
			this.HistoryButton.UseSelectable = true;
			this.HistoryButton.UseStyleColors = true;
			this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
			// 
			// metroToolTip1
			// 
			this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroToolTip1.StyleManager = null;
			this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
			// 
			// metroStyleManager
			// 
			this.metroStyleManager.Owner = this;
			// 
			// TextCompareMenu
			// 
			this.TextCompareMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextCompare_AddFile,
            this.TextCompare_Save,
            this.TextCompare_Compare});
			this.TextCompareMenu.Name = "metroContextMenu1";
			this.TextCompareMenu.Size = new System.Drawing.Size(124, 70);
			this.TextCompareMenu.UseStyleColors = true;
			// 
			// TextCompare_AddFile
			// 
			this.TextCompare_AddFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_LeftFile,
            this.Add_RightFile});
			this.TextCompare_AddFile.Name = "TextCompare_AddFile";
			this.TextCompare_AddFile.Size = new System.Drawing.Size(123, 22);
			this.TextCompare_AddFile.Text = "Add File";
			// 
			// Add_LeftFile
			// 
			this.Add_LeftFile.Name = "Add_LeftFile";
			this.Add_LeftFile.Size = new System.Drawing.Size(123, 22);
			this.Add_LeftFile.Text = "Left File";
			this.Add_LeftFile.Click += new System.EventHandler(this.Add_LeftFile_Click);
			// 
			// Add_RightFile
			// 
			this.Add_RightFile.Name = "Add_RightFile";
			this.Add_RightFile.Size = new System.Drawing.Size(123, 22);
			this.Add_RightFile.Text = "Right File";
			this.Add_RightFile.Click += new System.EventHandler(this.Add_RightFile_Click);
			// 
			// TextCompare_Save
			// 
			this.TextCompare_Save.Name = "TextCompare_Save";
			this.TextCompare_Save.Size = new System.Drawing.Size(123, 22);
			this.TextCompare_Save.Text = "Save";
			this.TextCompare_Save.Click += new System.EventHandler(this.TextCompare_Save_Click);
			// 
			// TextCompare_Compare
			// 
			this.TextCompare_Compare.Name = "TextCompare_Compare";
			this.TextCompare_Compare.Size = new System.Drawing.Size(123, 22);
			this.TextCompare_Compare.Text = "Compare";
			this.TextCompare_Compare.Click += new System.EventHandler(this.TextCompare_Compare_Click);
			// 
			// FolderCompareMenu
			// 
			this.FolderCompareMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderCompare_AddFile,
            this.FolderCompare_Compare,
            this.FolderCompare_Reset});
			this.FolderCompareMenu.Name = "metroContextMenu2";
			this.FolderCompareMenu.Size = new System.Drawing.Size(133, 70);
			// 
			// FolderCompare_AddFile
			// 
			this.FolderCompare_AddFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_LeftFolder,
            this.Add_RightFolder});
			this.FolderCompare_AddFile.Name = "FolderCompare_AddFile";
			this.FolderCompare_AddFile.Size = new System.Drawing.Size(132, 22);
			this.FolderCompare_AddFile.Text = "Add Folder";
			// 
			// Add_LeftFolder
			// 
			this.Add_LeftFolder.Name = "Add_LeftFolder";
			this.Add_LeftFolder.Size = new System.Drawing.Size(138, 22);
			this.Add_LeftFolder.Text = "Left Folder";
			this.Add_LeftFolder.Click += new System.EventHandler(this.Add_LeftFolder_Click);
			// 
			// Add_RightFolder
			// 
			this.Add_RightFolder.Name = "Add_RightFolder";
			this.Add_RightFolder.Size = new System.Drawing.Size(138, 22);
			this.Add_RightFolder.Text = "Right Folder";
			this.Add_RightFolder.Click += new System.EventHandler(this.Add_RightFolder_Click);
			// 
			// FolderCompare_Compare
			// 
			this.FolderCompare_Compare.Name = "FolderCompare_Compare";
			this.FolderCompare_Compare.Size = new System.Drawing.Size(132, 22);
			this.FolderCompare_Compare.Text = "Compare";
			this.FolderCompare_Compare.Click += new System.EventHandler(this.FolderCompare_Compare_Click);
			// 
			// FolderCompare_Reset
			// 
			this.FolderCompare_Reset.Name = "FolderCompare_Reset";
			this.FolderCompare_Reset.Size = new System.Drawing.Size(132, 22);
			this.FolderCompare_Reset.Text = "Reset";
			this.FolderCompare_Reset.Click += new System.EventHandler(this.FolderCompare_Reset_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 600);
			this.Controls.Add(this.tab_controller);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
			this.Resizable = false;
			this.Text = "2Compare";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.TransparencyKey = System.Drawing.Color.Gainsboro;
			this.tab_controller.ResumeLayout(false);
			this.tab_howToUse.ResumeLayout(false);
			this.tab_howToUse.PerformLayout();
			this.tab_textCompare.ResumeLayout(false);
			this.tab_textCompare.PerformLayout();
			this.tab_folderCompare.ResumeLayout(false);
			this.tab_folderCompare.PerformLayout();
			this.tab_theme.ResumeLayout(false);
			this.tab_theme.PerformLayout();
			this.tab_information.ResumeLayout(false);
			this.tab_information.PerformLayout();
			this.tab_history.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
			this.TextCompareMenu.ResumeLayout(false);
			this.FolderCompareMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl tab_controller;
		private MetroFramework.Controls.MetroTabPage tab_howToUse;
		private MetroFramework.Controls.MetroTabPage tab_folderCompare;
		private MetroFramework.Controls.MetroTabPage tab_theme;
		private MetroFramework.Controls.MetroTabPage tab_information;
		private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTile metroTile2;
		private MetroFramework.Controls.MetroUserControl metroUserControl1;
		private MetroFramework.Components.MetroToolTip metroToolTip1;
		private MetroFramework.Components.MetroStyleManager metroStyleManager;
		private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
		private MetroFramework.Controls.MetroContextMenu TextCompareMenu;
		private System.Windows.Forms.ToolStripMenuItem TextCompare_AddFile;
		private System.Windows.Forms.ToolStripMenuItem TextCompare_Save;
		private MetroFramework.Controls.MetroButton FolderCompareToolbox;
		private System.Windows.Forms.ToolStripMenuItem TextCompare_Compare;
		private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
		private MetroFramework.Controls.MetroButton metroButton4;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
		private MetroFramework.Controls.MetroRadioButton White;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroContextMenu FolderCompareMenu;
		private System.Windows.Forms.ToolStripMenuItem FolderCompare_AddFile;
		private System.Windows.Forms.ToolStripMenuItem FolderCompare_Compare;
		private System.Windows.Forms.TreeView TreeViewRight;
		private MetroFramework.Controls.MetroLabel lbl_pathRight;
		private MetroFramework.Controls.MetroLabel lbl_pathLeft;
		private System.Windows.Forms.TreeView TreeViewLeft;
		private MetroFramework.Controls.MetroTabPage tab_textCompare;
		private MetroFramework.Controls.MetroLabel lbl_fileRight;
		private MetroFramework.Controls.MetroLabel lbl_fileLeft;
		private MetroFramework.Controls.MetroButton FileCompareToolbox;
		private System.Windows.Forms.ToolStripMenuItem Add_LeftFile;
		private System.Windows.Forms.ToolStripMenuItem Add_RightFile;
		private RichTextBoxAdvanced TextBoxLeft;
		private RichTextBoxAdvanced TextBoxRight;
        private System.Windows.Forms.ToolStripMenuItem FolderCompare_Reset;
        private MetroFramework.Controls.MetroTabPage tab_history;
        private MetroFramework.Controls.MetroButton HistoryButton;
        private System.Windows.Forms.RichTextBox HistoryText;
        private System.Windows.Forms.ToolStripMenuItem Add_LeftFolder;
        private System.Windows.Forms.ToolStripMenuItem Add_RightFolder;
		private System.Windows.Forms.Button btn_toLeftFile;
		private System.Windows.Forms.Button btn_toRightFile;
	}
}


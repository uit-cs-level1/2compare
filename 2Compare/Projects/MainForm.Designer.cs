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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.File_2 = new MetroFramework.Controls.MetroLabel();
            this.File_1 = new MetroFramework.Controls.MetroLabel();
            this.FileCompareToolbox = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.history_btn = new MetroFramework.Controls.MetroButton();
            this.History = new System.Windows.Forms.RichTextBox();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.White = new MetroFramework.Controls.MetroRadioButton();
            this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.TextCompareMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.TextCompare_AddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_LeftFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_RightFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TextCompare_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.TextCompare_Compare = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu2 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.TextCompareMenu.SuspendLayout();
            this.metroContextMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(978, 520);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroTabPage1.Controls.Add(this.metroUserControl1);
            this.metroTabPage1.Controls.Add(this.metroTile2);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(970, 478);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "How To Use";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 3;
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
            this.metroTile1.MouseLeave += new System.EventHandler(this.metroTile1_MouseLeave);
            this.metroTile1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile1_MouseMove);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.File_2);
            this.metroTabPage2.Controls.Add(this.File_1);
            this.metroTabPage2.Controls.Add(this.FileCompareToolbox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(970, 478);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Text Compare";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 3;
            // 
            // File_2
            // 
            this.File_2.AutoSize = true;
            this.File_2.Location = new System.Drawing.Point(509, 38);
            this.File_2.Name = "File_2";
            this.File_2.Size = new System.Drawing.Size(40, 19);
            this.File_2.TabIndex = 8;
            this.File_2.Text = "File 2";
            this.File_2.UseStyleColors = true;
            // 
            // File_1
            // 
            this.File_1.AutoSize = true;
            this.File_1.Location = new System.Drawing.Point(3, 38);
            this.File_1.Name = "File_1";
            this.File_1.Size = new System.Drawing.Size(38, 19);
            this.File_1.TabIndex = 7;
            this.File_1.Text = "File 1";
            this.File_1.UseStyleColors = true;
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
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.treeView2);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.treeView1);
            this.metroTabPage3.Controls.Add(this.metroButton2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(970, 478);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Folder Compare";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 3;
            // 
            // treeView2
            // 
            this.treeView2.ForeColor = System.Drawing.Color.Magenta;
            this.treeView2.Location = new System.Drawing.Point(444, 63);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(378, 376);
            this.treeView2.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(447, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Folder 2";
            this.metroLabel4.UseStyleColors = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 37);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Folder 1";
            this.metroLabel3.UseStyleColors = true;
            // 
            // treeView1
            // 
            this.treeView1.ForeColor = System.Drawing.Color.Magenta;
            this.treeView1.Location = new System.Drawing.Point(19, 63);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(378, 376);
            this.treeView1.TabIndex = 3;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(5, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(77, 27);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "ToolBox";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.history_btn);
            this.metroTabPage4.Controls.Add(this.History);
            this.metroTabPage4.Controls.Add(this.metroRadioButton2);
            this.metroTabPage4.Controls.Add(this.White);
            this.metroTabPage4.Controls.Add(this.metroTrackBar2);
            this.metroTabPage4.Controls.Add(this.metroButton4);
            this.metroTabPage4.Controls.Add(this.metroButton3);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(970, 478);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Theme";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 3;
            this.metroTabPage4.Click += new System.EventHandler(this.metroTabPage4_Click);
            // 
            // history_btn
            // 
            this.history_btn.Location = new System.Drawing.Point(16, 186);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(112, 23);
            this.history_btn.TabIndex = 9;
            this.history_btn.Text = "Show History";
            this.history_btn.UseSelectable = true;
            this.history_btn.UseStyleColors = true;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(502, 51);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(465, 407);
            this.History.TabIndex = 8;
            this.History.Text = "";
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
            this.metroTrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar2_Scroll);
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
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.metroLabel1);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(970, 478);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Information";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 3;
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
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
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
=======
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.TextBoxLeft = new cs511_g11.RichTextBoxAdvanced();
			this.TextBoxRight = new cs511_g11.RichTextBoxAdvanced();
			this.File_2 = new MetroFramework.Controls.MetroLabel();
			this.File_1 = new MetroFramework.Controls.MetroLabel();
			this.FileCompareToolbox = new MetroFramework.Controls.MetroButton();
			this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
			this.history_btn = new MetroFramework.Controls.MetroButton();
			this.History = new System.Windows.Forms.RichTextBox();
			this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
			this.White = new MetroFramework.Controls.MetroRadioButton();
			this.metroTrackBar2 = new MetroFramework.Controls.MetroTrackBar();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
			this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
			this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
			this.TextCompareMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.TextCompare_AddFile = new System.Windows.Forms.ToolStripMenuItem();
			this.Add_LeftFile = new System.Windows.Forms.ToolStripMenuItem();
			this.Add_RightFile = new System.Windows.Forms.ToolStripMenuItem();
			this.TextCompare_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.TextCompare_Compare = new System.Windows.Forms.ToolStripMenuItem();
			this.metroContextMenu2 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.metroTabControl1.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.metroTabPage2.SuspendLayout();
			this.metroTabPage3.SuspendLayout();
			this.metroTabPage4.SuspendLayout();
			this.metroTabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
			this.TextCompareMenu.SuspendLayout();
			this.metroContextMenu2.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Controls.Add(this.metroTabPage3);
			this.metroTabControl1.Controls.Add(this.metroTabPage4);
			this.metroTabControl1.Controls.Add(this.metroTabPage5);
			this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTabControl1.Location = new System.Drawing.Point(23, 60);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 1;
			this.metroTabControl1.Size = new System.Drawing.Size(978, 520);
			this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.metroTabControl1.TabIndex = 0;
			this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.metroTabControl1.UseSelectable = true;
			this.metroTabControl1.UseStyleColors = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.metroTabPage1.Controls.Add(this.metroUserControl1);
			this.metroTabPage1.Controls.Add(this.metroTile2);
			this.metroTabPage1.Controls.Add(this.metroLabel2);
			this.metroTabPage1.Controls.Add(this.metroTile1);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(970, 478);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "How To Use";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 3;
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
			this.metroTile1.MouseLeave += new System.EventHandler(this.metroTile1_MouseLeave);
			this.metroTile1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile1_MouseMove);
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.Controls.Add(this.TextBoxLeft);
			this.metroTabPage2.Controls.Add(this.TextBoxRight);
			this.metroTabPage2.Controls.Add(this.File_2);
			this.metroTabPage2.Controls.Add(this.File_1);
			this.metroTabPage2.Controls.Add(this.FileCompareToolbox);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(970, 478);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "Text Compare";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 3;
			// 
			// TextBoxLeft
			// 
			this.TextBoxLeft.AcceptsTab = true;
			this.TextBoxLeft.EnableAutoDragDrop = true;
			this.TextBoxLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxLeft.Location = new System.Drawing.Point(0, 60);
			this.TextBoxLeft.Margin = new System.Windows.Forms.Padding(5);
			this.TextBoxLeft.Name = "TextBoxLeft";
			this.TextBoxLeft.Size = new System.Drawing.Size(475, 418);
			this.TextBoxLeft.TabIndex = 9;
			this.TextBoxLeft.Text = "";
			this.TextBoxLeft.WordWrap = false;
			this.TextBoxLeft.TextChanged += new System.EventHandler(this.TextBoxLeft_TextChanged);
			this.TextBoxLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLeft_KeyPress);
			this.TextBoxLeft.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxLeft_KeyUp);
			this.TextBoxLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxLeft_KeyDown);
			this.TextBoxLeft.LostFocus += new System.EventHandler(this.TextBoxLeft_LostFocus);
			//
			// TextBoxRight
			//
			this.TextBoxRight.AcceptsTab = true;
			this.TextBoxRight.EnableAutoDragDrop = true;
			this.TextBoxRight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxRight.Location = new System.Drawing.Point(496, 60);
			this.TextBoxRight.Margin = new System.Windows.Forms.Padding(5);
			this.TextBoxRight.Name = "TextBoxRight";
			this.TextBoxRight.Size = new System.Drawing.Size(475, 418);
			this.TextBoxRight.TabIndex = 10;
			this.TextBoxRight.Text = "";
			this.TextBoxRight.WordWrap = false;
			this.TextBoxRight.TextChanged += new System.EventHandler(this.TextBoxRight_TextChanged);
			this.TextBoxRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRight_KeyPress);
			this.TextBoxRight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxRight_KeyUp);
			this.TextBoxRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxRight_KeyDown);
			this.TextBoxRight.LostFocus += new System.EventHandler(TextBoxRight_LostFocus);
			// 
			// File_2
			// 
			this.File_2.AutoSize = true;
			this.File_2.Location = new System.Drawing.Point(509, 38);
			this.File_2.Name = "File_2";
			this.File_2.Size = new System.Drawing.Size(40, 19);
			this.File_2.TabIndex = 8;
			this.File_2.Text = "File 2";
			this.File_2.UseStyleColors = true;
			// 
			// File_1
			// 
			this.File_1.AutoSize = true;
			this.File_1.Location = new System.Drawing.Point(3, 38);
			this.File_1.Name = "File_1";
			this.File_1.Size = new System.Drawing.Size(38, 19);
			this.File_1.TabIndex = 7;
			this.File_1.Text = "File 1";
			this.File_1.UseStyleColors = true;
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
			// metroTabPage3
			// 
			this.metroTabPage3.Controls.Add(this.treeView2);
			this.metroTabPage3.Controls.Add(this.metroLabel4);
			this.metroTabPage3.Controls.Add(this.metroLabel3);
			this.metroTabPage3.Controls.Add(this.treeView1);
			this.metroTabPage3.Controls.Add(this.metroButton2);
			this.metroTabPage3.HorizontalScrollbarBarColor = true;
			this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.HorizontalScrollbarSize = 10;
			this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage3.Name = "metroTabPage3";
			this.metroTabPage3.Size = new System.Drawing.Size(970, 478);
			this.metroTabPage3.TabIndex = 2;
			this.metroTabPage3.Text = "Folder Compare";
			this.metroTabPage3.VerticalScrollbarBarColor = true;
			this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.VerticalScrollbarSize = 3;
			// 
			// treeView2
			// 
			this.treeView2.ForeColor = System.Drawing.Color.Magenta;
			this.treeView2.Location = new System.Drawing.Point(444, 63);
			this.treeView2.Name = "treeView2";
			this.treeView2.Size = new System.Drawing.Size(378, 376);
			this.treeView2.TabIndex = 7;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(447, 34);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(58, 19);
			this.metroLabel4.TabIndex = 6;
			this.metroLabel4.Text = "Folder 2";
			this.metroLabel4.UseStyleColors = true;
			this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(19, 37);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(56, 19);
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "Folder 1";
			this.metroLabel3.UseStyleColors = true;
			// 
			// treeView1
			// 
			this.treeView1.ForeColor = System.Drawing.Color.Magenta;
			this.treeView1.Location = new System.Drawing.Point(19, 63);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(378, 376);
			this.treeView1.TabIndex = 3;
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(5, 3);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(77, 27);
			this.metroButton2.TabIndex = 2;
			this.metroButton2.Text = "ToolBox";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.UseStyleColors = true;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroTabPage4
			// 
			this.metroTabPage4.Controls.Add(this.history_btn);
			this.metroTabPage4.Controls.Add(this.History);
			this.metroTabPage4.Controls.Add(this.metroRadioButton2);
			this.metroTabPage4.Controls.Add(this.White);
			this.metroTabPage4.Controls.Add(this.metroTrackBar2);
			this.metroTabPage4.Controls.Add(this.metroButton4);
			this.metroTabPage4.Controls.Add(this.metroButton3);
			this.metroTabPage4.HorizontalScrollbarBarColor = true;
			this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage4.HorizontalScrollbarSize = 10;
			this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage4.Name = "metroTabPage4";
			this.metroTabPage4.Size = new System.Drawing.Size(970, 478);
			this.metroTabPage4.TabIndex = 3;
			this.metroTabPage4.Text = "Theme";
			this.metroTabPage4.VerticalScrollbarBarColor = true;
			this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage4.VerticalScrollbarSize = 3;
			this.metroTabPage4.Click += new System.EventHandler(this.metroTabPage4_Click);
			// 
			// history_btn
			// 
			this.history_btn.Location = new System.Drawing.Point(16, 186);
			this.history_btn.Name = "history_btn";
			this.history_btn.Size = new System.Drawing.Size(112, 23);
			this.history_btn.TabIndex = 9;
			this.history_btn.Text = "Show History";
			this.history_btn.UseSelectable = true;
			this.history_btn.UseStyleColors = true;
			this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
			// 
			// History
			// 
			this.History.Location = new System.Drawing.Point(502, 51);
			this.History.Name = "History";
			this.History.Size = new System.Drawing.Size(465, 407);
			this.History.TabIndex = 8;
			this.History.Text = "";
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
			this.metroTrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar2_Scroll);
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
			// metroTabPage5
			// 
			this.metroTabPage5.Controls.Add(this.metroLabel1);
			this.metroTabPage5.HorizontalScrollbarBarColor = true;
			this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage5.HorizontalScrollbarSize = 10;
			this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage5.Name = "metroTabPage5";
			this.metroTabPage5.Size = new System.Drawing.Size(970, 478);
			this.metroTabPage5.TabIndex = 4;
			this.metroTabPage5.Text = "Information";
			this.metroTabPage5.VerticalScrollbarBarColor = true;
			this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage5.VerticalScrollbarSize = 3;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(286, 59);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(205, 76);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "SOFTWARE DEVELOPED BY............\r\n\r\nPHAN NAY GHI THONG :))\r\n";
			this.metroLabel1.UseStyleColors = true;
			this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
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
>>>>>>> 26de547b9d460e99b6f75a16cbbc76ec522c2efd
            this.TextCompare_AddFile,
            this.TextCompare_Save,
            this.TextCompare_Compare});
			this.TextCompareMenu.Name = "metroContextMenu1";
			this.TextCompareMenu.Size = new System.Drawing.Size(124, 70);
			this.TextCompareMenu.UseStyleColors = true;
			this.TextCompareMenu.Opening += new System.ComponentModel.CancelEventHandler(this.metroContextMenu1_Opening);
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
			// metroContextMenu2
			// 
			this.metroContextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolStripMenuItem,
            this.compareToolStripMenuItem1});
			this.metroContextMenu2.Name = "metroContextMenu2";
			this.metroContextMenu2.Size = new System.Drawing.Size(133, 48);
			this.metroContextMenu2.Opening += new System.ComponentModel.CancelEventHandler(this.metroContextMenu2_Opening);
			// 
			// addFolderToolStripMenuItem
			// 
			this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
			this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.addFolderToolStripMenuItem.Text = "Add Folder";
			this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
			// 
			// compareToolStripMenuItem1
			// 
			this.compareToolStripMenuItem1.Name = "compareToolStripMenuItem1";
			this.compareToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
			this.compareToolStripMenuItem1.Text = "Compare";
			this.compareToolStripMenuItem1.Click += new System.EventHandler(this.compareToolStripMenuItem1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 600);
			this.Controls.Add(this.metroTabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
			this.Resizable = false;
			this.Text = "2Compare";
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.TransparencyKey = System.Drawing.Color.Gainsboro;
			this.metroTabControl1.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.metroTabPage1.PerformLayout();
			this.metroTabPage2.ResumeLayout(false);
			this.metroTabPage2.PerformLayout();
			this.metroTabPage3.ResumeLayout(false);
			this.metroTabPage3.PerformLayout();
			this.metroTabPage4.ResumeLayout(false);
			this.metroTabPage4.PerformLayout();
			this.metroTabPage5.ResumeLayout(false);
			this.metroTabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
			this.TextCompareMenu.ResumeLayout(false);
			this.metroContextMenu2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage3;
		private MetroFramework.Controls.MetroTabPage metroTabPage4;
		private MetroFramework.Controls.MetroTabPage metroTabPage5;
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
		private MetroFramework.Controls.MetroButton metroButton2;
		private System.Windows.Forms.ToolStripMenuItem TextCompare_Compare;
		private MetroFramework.Controls.MetroTrackBar metroTrackBar2;
		private MetroFramework.Controls.MetroButton metroButton4;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
		private MetroFramework.Controls.MetroRadioButton White;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroContextMenu metroContextMenu2;
		private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem1;
		private System.Windows.Forms.TreeView treeView2;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private System.Windows.Forms.TreeView treeView1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private MetroFramework.Controls.MetroLabel File_2;
		private MetroFramework.Controls.MetroLabel File_1;
		private MetroFramework.Controls.MetroButton FileCompareToolbox;
		private System.Windows.Forms.ToolStripMenuItem Add_LeftFile;
		private System.Windows.Forms.ToolStripMenuItem Add_RightFile;
		private System.Windows.Forms.RichTextBox History;
		private MetroFramework.Controls.MetroButton history_btn;
		private RichTextBoxAdvanced TextBoxLeft;
		private RichTextBoxAdvanced TextBoxRight;
	}
}


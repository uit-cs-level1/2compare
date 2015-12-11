
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace _2Compare.Sources
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        //


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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
			this.panel_folder = new DevComponents.DotNetBar.RibbonPanel();
			this.button_cut = new DevComponents.DotNetBar.ButtonX();
			this.button_redo = new DevComponents.DotNetBar.ButtonX();
			this.button_copy = new DevComponents.DotNetBar.ButtonX();
			this.button_paste = new DevComponents.DotNetBar.ButtonX();
			this.button_undo = new DevComponents.DotNetBar.ButtonX();
			this.FolderCompare = new DevComponents.DotNetBar.RibbonTabItem();
			this.TextCompare = new DevComponents.DotNetBar.RibbonTabItem();
			this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
			this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
			this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
			this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
			this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
			this.button_save = new DevComponents.DotNetBar.ButtonItem();
			this.button_saveas = new DevComponents.DotNetBar.ButtonItem();
			this.button_share = new DevComponents.DotNetBar.ButtonItem();
			this.button_print = new DevComponents.DotNetBar.ButtonItem();
			this.button_about = new DevComponents.DotNetBar.ButtonItem();
			this.button_help = new DevComponents.DotNetBar.ButtonItem();
			this.button_options = new DevComponents.DotNetBar.ButtonItem();
			this.button_close = new DevComponents.DotNetBar.ButtonItem();
			this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
			this.label_documents = new DevComponents.DotNetBar.LabelItem();
			this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
			this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
			this.itemContainer9 = new DevComponents.DotNetBar.ItemContainer();
			this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
			this.group_fileleft = new DevComponents.DotNetBar.Controls.GroupPanel();
			this.button_back1 = new DevComponents.DotNetBar.ButtonX();
			this.button_open1 = new DevComponents.DotNetBar.ButtonX();
			this.text_diachi1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.label_path1 = new DevComponents.DotNetBar.LabelX();
			this.text_vungsosanh1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
			this.group_fileright = new DevComponents.DotNetBar.Controls.GroupPanel();
			this.button_back2 = new DevComponents.DotNetBar.ButtonX();
			this.button_open2 = new DevComponents.DotNetBar.ButtonX();
			this.text_diachi2 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.label_path2 = new DevComponents.DotNetBar.LabelX();
			this.text_vungsosanh2 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.panel_folder.SuspendLayout();
			this.ribbonControl.SuspendLayout();
			this.group_fileleft.SuspendLayout();
			this.group_fileright.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_folder
			// 
			this.panel_folder.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.panel_folder.Controls.Add(this.button_cut);
			this.panel_folder.Controls.Add(this.button_redo);
			this.panel_folder.Controls.Add(this.button_copy);
			this.panel_folder.Controls.Add(this.button_paste);
			this.panel_folder.Controls.Add(this.button_undo);
			this.panel_folder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_folder.Location = new System.Drawing.Point(0, 0);
			this.panel_folder.Name = "panel_folder";
			this.panel_folder.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.panel_folder.Size = new System.Drawing.Size(681, 184);
			this.panel_folder.TabIndex = 1;
			this.panel_folder.Visible = false;
			// 
			// button_cut
			// 
			this.button_cut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_cut.Image = ((System.Drawing.Image)(resources.GetObject("button_cut.Image")));
			this.button_cut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.button_cut.Location = new System.Drawing.Point(116, 2);
			this.button_cut.Name = "button_cut";
			this.button_cut.Size = new System.Drawing.Size(104, 125);
			this.button_cut.TabIndex = 2;
			this.button_cut.Text = "redo";
			// 
			// button_redo
			// 
			this.button_redo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_redo.Image = ((System.Drawing.Image)(resources.GetObject("button_redo.Image")));
			this.button_redo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.button_redo.Location = new System.Drawing.Point(447, 3);
			this.button_redo.Name = "button_redo";
			this.button_redo.Size = new System.Drawing.Size(104, 125);
			this.button_redo.TabIndex = 3;
			this.button_redo.Text = "redo";
			// 
			// button_copy
			// 
			this.button_copy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_copy.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.button_copy.Image = ((System.Drawing.Image)(resources.GetObject("button_copy.Image")));
			this.button_copy.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.button_copy.Location = new System.Drawing.Point(6, 3);
			this.button_copy.Name = "button_copy";
			this.button_copy.Size = new System.Drawing.Size(104, 125);
			this.button_copy.TabIndex = 1;
			this.button_copy.Text = "Copy";
			this.button_copy.Click += new System.EventHandler(this.buttonX1_Click);
			// 
			// button_paste
			// 
			this.button_paste.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_paste.Image = ((System.Drawing.Image)(resources.GetObject("button_paste.Image")));
			this.button_paste.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.button_paste.Location = new System.Drawing.Point(226, 3);
			this.button_paste.Name = "button_paste";
			this.button_paste.Size = new System.Drawing.Size(104, 125);
			this.button_paste.TabIndex = 5;
			this.button_paste.Text = "paste";
			// 
			// button_undo
			// 
			this.button_undo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_undo.Image = ((System.Drawing.Image)(resources.GetObject("button_undo.Image")));
			this.button_undo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.button_undo.Location = new System.Drawing.Point(336, 2);
			this.button_undo.Name = "button_undo";
			this.button_undo.Size = new System.Drawing.Size(105, 125);
			this.button_undo.TabIndex = 1;
			this.button_undo.Text = "undo";
			this.button_undo.Click += new System.EventHandler(this.buttonX1_Click);
			// 
			// FolderCompare
			// 
			this.FolderCompare.ImagePaddingHorizontal = 8;
			this.FolderCompare.Name = "FolderCompare";
			this.FolderCompare.Panel = this.panel_folder;
			this.FolderCompare.Text = "Folder Compare";
			this.FolderCompare.Click += new System.EventHandler(this.FolderCompare_Click);
			// 
			// TextCompare
			// 
			this.TextCompare.Checked = true;
			this.TextCompare.ImagePaddingHorizontal = 8;
			this.TextCompare.Name = "TextCompare";
			this.TextCompare.Text = "Text Compare";
			this.TextCompare.Click += new System.EventHandler(this.TextCompare_Click);
			// 
			// qatCustomizeItem1
			// 
			this.qatCustomizeItem1.Name = "qatCustomizeItem1";
			// 
			// office2007StartButton1
			// 
			this.office2007StartButton1.AutoExpandOnClick = true;
			this.office2007StartButton1.CanCustomize = false;
			this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
			this.office2007StartButton1.ImagePaddingHorizontal = 2;
			this.office2007StartButton1.ImagePaddingVertical = 2;
			this.office2007StartButton1.Name = "office2007StartButton1";
			this.office2007StartButton1.ShowSubItems = false;
			this.office2007StartButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
			this.office2007StartButton1.Text = "&File";
			// 
			// itemContainer1
			// 
			// 
			// 
			// 
			this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
			this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemContainer1.MinimumSize = new System.Drawing.Size(0, 0);
			this.itemContainer1.Name = "itemContainer1";
			this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer5});
			// 
			// itemContainer2
			// 
			// 
			// 
			// 
			this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
			this.itemContainer2.ItemSpacing = 0;
			this.itemContainer2.MinimumSize = new System.Drawing.Size(0, 0);
			this.itemContainer2.Name = "itemContainer2";
			this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.itemContainer4});
			// 
			// itemContainer3
			// 
			// 
			// 
			// 
			this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
			this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
			this.itemContainer3.Name = "itemContainer3";
			this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.button_save,
            this.button_saveas,
            this.button_share,
            this.button_print,
            this.button_about,
            this.button_help,
            this.button_options,
            this.button_close});
			// 
			// button_save
			// 
			this.button_save.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.button_save.ImagePaddingHorizontal = 8;
			this.button_save.Name = "button_save";
			this.button_save.SubItemsExpandWidth = 24;
			this.button_save.Text = "&Save...";
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// button_saveas
			// 
			this.button_saveas.ImagePaddingHorizontal = 8;
			this.button_saveas.Name = "button_saveas";
			this.button_saveas.Text = "Save as...";
			this.button_saveas.Click += new System.EventHandler(this.button_saveas_Click);
			// 
			// button_share
			// 
			this.button_share.BeginGroup = true;
			this.button_share.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.button_share.ImagePaddingHorizontal = 8;
			this.button_share.Name = "button_share";
			this.button_share.SubItemsExpandWidth = 24;
			this.button_share.Text = "S&hare...";
			this.button_share.Click += new System.EventHandler(this.button_share_Click);
			// 
			// button_print
			// 
			this.button_print.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.button_print.ImagePaddingHorizontal = 8;
			this.button_print.Name = "button_print";
			this.button_print.SubItemsExpandWidth = 24;
			this.button_print.Text = "&Print...";
			this.button_print.Click += new System.EventHandler(this.button_print_Click);
			// 
			// button_about
			// 
			this.button_about.ImagePaddingHorizontal = 8;
			this.button_about.Name = "button_about";
			this.button_about.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.button_about.SplitButton = true;
			this.button_about.Stretch = true;
			this.button_about.Text = "About";
			this.button_about.Tooltip = "A";
			this.button_about.Click += new System.EventHandler(this.button_about_Click);
			// 
			// button_help
			// 
			this.button_help.ImagePaddingHorizontal = 8;
			this.button_help.Name = "button_help";
			this.button_help.Text = "Help";
			this.button_help.Click += new System.EventHandler(this.button_help_Click);
			// 
			// button_options
			// 
			this.button_options.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.button_options.ImagePaddingHorizontal = 8;
			this.button_options.Name = "button_options";
			this.button_options.Text = "Opt&ions";
			this.button_options.Click += new System.EventHandler(this.button_options_Click);
			// 
			// button_close
			// 
			this.button_close.BeginGroup = true;
			this.button_close.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.button_close.ImagePaddingHorizontal = 8;
			this.button_close.Name = "button_close";
			this.button_close.SubItemsExpandWidth = 24;
			this.button_close.Text = "&Close";
			this.button_close.Click += new System.EventHandler(this.button_close_Click);
			// 
			// itemContainer4
			// 
			// 
			// 
			// 
			this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
			this.itemContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemContainer4.MinimumSize = new System.Drawing.Size(180, 0);
			this.itemContainer4.Name = "itemContainer4";
			this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.label_documents});
			// 
			// label_documents
			// 
			this.label_documents.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.label_documents.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
			this.label_documents.CanCustomize = false;
			this.label_documents.Name = "label_documents";
			this.label_documents.PaddingBottom = 2;
			this.label_documents.PaddingTop = 2;
			this.label_documents.Stretch = true;
			this.label_documents.Text = "Recent Documents";
			// 
			// itemContainer5
			// 
			// 
			// 
			// 
			this.itemContainer5.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
			this.itemContainer5.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
			this.itemContainer5.MinimumSize = new System.Drawing.Size(0, 0);
			this.itemContainer5.Name = "itemContainer5";
			// 
			// ribbonControl
			// 
			this.ribbonControl.CaptionVisible = true;
			this.ribbonControl.Controls.Add(this.panel_folder);
			this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.FolderCompare,
            this.TextCompare});
			this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
			this.ribbonControl.Location = new System.Drawing.Point(4, 1);
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1,
            this.qatCustomizeItem1});
			this.ribbonControl.Size = new System.Drawing.Size(681, 186);
			this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.ribbonControl.TabGroupHeight = 14;
			this.ribbonControl.TabIndex = 0;
			this.ribbonControl.Text = "ribbonControl1";
			// 
			// itemContainer9
			// 
			// 
			// 
			// 
			this.itemContainer9.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
			this.itemContainer9.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemContainer9.MinimumSize = new System.Drawing.Size(180, 0);
			this.itemContainer9.Name = "itemContainer9";
			// 
			// labelItem1
			// 
			this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
			this.labelItem1.CanCustomize = false;
			this.labelItem1.Name = "labelItem1";
			// 
			// group_fileleft
			// 
			this.group_fileleft.CanvasColor = System.Drawing.SystemColors.Control;
			this.group_fileleft.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.group_fileleft.Controls.Add(this.button_back1);
			this.group_fileleft.Controls.Add(this.button_open1);
			this.group_fileleft.Controls.Add(this.text_diachi1);
			this.group_fileleft.Controls.Add(this.label_path1);
			this.group_fileleft.Controls.Add(this.text_vungsosanh1);
			this.group_fileleft.Controls.Add(this.buttonX3);
			this.group_fileleft.Location = new System.Drawing.Point(4, 193);
			this.group_fileleft.Name = "group_fileleft";
			this.group_fileleft.ShowFocusRectangle = true;
			this.group_fileleft.Size = new System.Drawing.Size(338, 354);
			// 
			// 
			// 
			this.group_fileleft.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.group_fileleft.Style.BackColorGradientAngle = 90;
			this.group_fileleft.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.group_fileleft.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.group_fileleft.Style.BorderBottomWidth = 1;
			this.group_fileleft.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.group_fileleft.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.group_fileleft.Style.BorderLeftWidth = 1;
			this.group_fileleft.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.group_fileleft.Style.BorderRightWidth = 1;
			this.group_fileleft.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.group_fileleft.Style.BorderTopWidth = 1;
			this.group_fileleft.Style.CornerDiameter = 4;
			this.group_fileleft.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.group_fileleft.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.group_fileleft.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.group_fileleft.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.group_fileleft.TabIndex = 1;
			this.group_fileleft.Text = "File Left";
			// 
			// button_back1
			// 
			this.button_back1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_back1.Location = new System.Drawing.Point(270, 14);
			this.button_back1.Name = "button_back1";
			this.button_back1.Size = new System.Drawing.Size(35, 30);
			this.button_back1.TabIndex = 2;
			this.button_back1.Text = "▲";
			// 
			// button_open1
			// 
			this.button_open1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_open1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_open1.Location = new System.Drawing.Point(229, 14);
			this.button_open1.Name = "button_open1";
			this.button_open1.Size = new System.Drawing.Size(35, 30);
			this.button_open1.TabIndex = 2;
			this.button_open1.Text = "...";
			// 
			// text_diachi1
			// 
			// 
			// 
			// 
			this.text_diachi1.Border.Class = "TextBoxBorder";
			this.text_diachi1.Location = new System.Drawing.Point(63, 14);
			this.text_diachi1.Name = "text_diachi1";
			this.text_diachi1.Size = new System.Drawing.Size(159, 30);
			this.text_diachi1.TabIndex = 1;
			// 
			// label_path1
			// 
			this.label_path1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_path1.Location = new System.Drawing.Point(10, 14);
			this.label_path1.Name = "label_path1";
			this.label_path1.Size = new System.Drawing.Size(39, 30);
			this.label_path1.TabIndex = 0;
			this.label_path1.Text = "Path";
			// 
			// text_vungsosanh1
			// 
			// 
			// 
			// 
			this.text_vungsosanh1.Border.Class = "TextBoxBorder";
			this.text_vungsosanh1.Location = new System.Drawing.Point(6, 50);
			this.text_vungsosanh1.Name = "text_vungsosanh1";
			this.text_vungsosanh1.Size = new System.Drawing.Size(329, 281);
			this.text_vungsosanh1.TabIndex = 3;
			// 
			// buttonX3
			// 
			this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX3.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.buttonX3.Location = new System.Drawing.Point(181, 150);
			this.buttonX3.Name = "buttonX3";
			this.buttonX3.Size = new System.Drawing.Size(104, 125);
			this.buttonX3.TabIndex = 6;
			this.buttonX3.Text = "cmdCopy";
			// 
			// group_fileright
			// 
			this.group_fileright.CanvasColor = System.Drawing.SystemColors.Control;
			this.group_fileright.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.group_fileright.Controls.Add(this.button_back2);
			this.group_fileright.Controls.Add(this.button_open2);
			this.group_fileright.Controls.Add(this.text_diachi2);
			this.group_fileright.Controls.Add(this.label_path2);
			this.group_fileright.Controls.Add(this.text_vungsosanh2);
			this.group_fileright.Location = new System.Drawing.Point(343, 193);
			this.group_fileright.Name = "group_fileright";
			this.group_fileright.ShowFocusRectangle = true;
			this.group_fileright.Size = new System.Drawing.Size(338, 354);
			// 
			// 
			// 
			this.group_fileright.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.group_fileright.Style.BackColorGradientAngle = 90;
			this.group_fileright.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.group_fileright.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.group_fileright.Style.BorderBottomWidth = 1;
			this.group_fileright.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.group_fileright.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.group_fileright.Style.BorderLeftWidth = 1;
			this.group_fileright.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.group_fileright.Style.BorderRightWidth = 1;
			this.group_fileright.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.group_fileright.Style.BorderTopWidth = 1;
			this.group_fileright.Style.CornerDiameter = 4;
			this.group_fileright.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.group_fileright.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.group_fileright.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.group_fileright.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.group_fileright.TabIndex = 1;
			this.group_fileright.Text = "File Right";
			this.group_fileright.UseWaitCursor = true;
			// 
			// button_back2
			// 
			this.button_back2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_back2.Location = new System.Drawing.Point(270, 14);
			this.button_back2.Name = "button_back2";
			this.button_back2.Size = new System.Drawing.Size(35, 30);
			this.button_back2.TabIndex = 2;
			this.button_back2.Text = "▲";
			this.button_back2.UseWaitCursor = true;
			// 
			// button_open2
			// 
			this.button_open2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.button_open2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_open2.Location = new System.Drawing.Point(229, 14);
			this.button_open2.Name = "button_open2";
			this.button_open2.Size = new System.Drawing.Size(35, 30);
			this.button_open2.TabIndex = 2;
			this.button_open2.Text = "...";
			this.button_open2.UseWaitCursor = true;
			// 
			// text_diachi2
			// 
			// 
			// 
			// 
			this.text_diachi2.Border.Class = "TextBoxBorder";
			this.text_diachi2.Location = new System.Drawing.Point(63, 14);
			this.text_diachi2.Name = "text_diachi2";
			this.text_diachi2.Size = new System.Drawing.Size(159, 30);
			this.text_diachi2.TabIndex = 1;
			this.text_diachi2.UseWaitCursor = true;
			// 
			// label_path2
			// 
			this.label_path2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_path2.Location = new System.Drawing.Point(10, 14);
			this.label_path2.Name = "label_path2";
			this.label_path2.Size = new System.Drawing.Size(39, 30);
			this.label_path2.TabIndex = 0;
			this.label_path2.Text = "Path";
			this.label_path2.UseWaitCursor = true;
			// 
			// text_vungsosanh2
			// 
			// 
			// 
			// 
			this.text_vungsosanh2.Border.Class = "TextBoxBorder";
			this.text_vungsosanh2.Location = new System.Drawing.Point(10, 50);
			this.text_vungsosanh2.Name = "text_vungsosanh2";
			this.text_vungsosanh2.Size = new System.Drawing.Size(319, 286);
			this.text_vungsosanh2.TabIndex = 3;
			this.text_vungsosanh2.UseWaitCursor = true;
			// 
			// mainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 561);
			this.Controls.Add(this.ribbonControl);
			this.Controls.Add(this.group_fileleft);
			this.Controls.Add(this.group_fileright);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "mainform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "2comapre";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel_folder.ResumeLayout(false);
			this.ribbonControl.ResumeLayout(false);
			this.ribbonControl.PerformLayout();
			this.group_fileleft.ResumeLayout(false);
			this.group_fileright.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonPanel panel_folder;

        private DevComponents.DotNetBar.ButtonX button_undo;
        private DevComponents.DotNetBar.ButtonX button_copy;
        private DevComponents.DotNetBar.RibbonTabItem FolderCompare;
        private DevComponents.DotNetBar.RibbonTabItem TextCompare;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem button_save;
        private DevComponents.DotNetBar.ButtonItem button_saveas;
        private DevComponents.DotNetBar.ButtonItem button_share;
        private DevComponents.DotNetBar.ButtonItem button_print;
        private DevComponents.DotNetBar.ButtonItem button_about;
        private DevComponents.DotNetBar.ButtonItem button_help;
        private DevComponents.DotNetBar.ButtonItem button_close;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.LabelItem label_documents;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.ButtonItem button_options;
        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.ItemContainer itemContainer9;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Controls.GroupPanel group_fileleft;
        private DevComponents.DotNetBar.ButtonX button_cut;
        private DevComponents.DotNetBar.ButtonX button_redo;
        private DevComponents.DotNetBar.ButtonX button_paste;

        private DevComponents.DotNetBar.Controls.TextBoxX text_vungsosanh1;
        private DevComponents.DotNetBar.ButtonX button_back1;
        private DevComponents.DotNetBar.ButtonX button_open1;
        private DevComponents.DotNetBar.Controls.TextBoxX text_diachi1;
        private DevComponents.DotNetBar.LabelX label_path1;
        private DevComponents.DotNetBar.Controls.GroupPanel group_fileright;
        private DevComponents.DotNetBar.Controls.TextBoxX text_vungsosanh2;
        private DevComponents.DotNetBar.ButtonX button_back2;
        private DevComponents.DotNetBar.ButtonX button_open2;
        private DevComponents.DotNetBar.Controls.TextBoxX text_diachi2;
        private DevComponents.DotNetBar.LabelX label_path2;
        private ButtonX buttonX3;


    }
}
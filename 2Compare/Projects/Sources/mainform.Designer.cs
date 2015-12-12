
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
            this.compare = new System.Windows.Forms.Button();
            this.button_exit = new DevComponents.DotNetBar.ButtonX();
            this.button_about = new DevComponents.DotNetBar.ButtonX();
            this.button_help = new DevComponents.DotNetBar.ButtonX();
            this.button_history = new DevComponents.DotNetBar.ButtonX();
            this.button_save = new DevComponents.DotNetBar.ButtonX();
            this.button_compare = new DevComponents.DotNetBar.ButtonX();
            this.FolderCompare = new DevComponents.DotNetBar.RibbonTabItem();
            this.TextCompare = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.itemContainer9 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.group_fileleft = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_back1 = new DevComponents.DotNetBar.ButtonX();
            this.button_open1 = new DevComponents.DotNetBar.ButtonX();
            this.path_1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_path1 = new DevComponents.DotNetBar.LabelX();
            this.group_fileright = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_back2 = new DevComponents.DotNetBar.ButtonX();
            this.button_open2 = new DevComponents.DotNetBar.ButtonX();
            this.path_2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_path2 = new DevComponents.DotNetBar.LabelX();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bame1_1 = new System.Windows.Forms.TextBox();
            this.panel_folder.SuspendLayout();
            this.ribbonControl.SuspendLayout();
            this.group_fileleft.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.group_fileright.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_folder
            // 
            this.panel_folder.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panel_folder.Controls.Add(this.compare);
            this.panel_folder.Controls.Add(this.button_exit);
            this.panel_folder.Controls.Add(this.button_about);
            this.panel_folder.Controls.Add(this.button_help);
            this.panel_folder.Controls.Add(this.button_history);
            this.panel_folder.Controls.Add(this.button_save);
            this.panel_folder.Controls.Add(this.button_compare);
            this.panel_folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_folder.Location = new System.Drawing.Point(0, 54);
            this.panel_folder.Name = "panel_folder";
            this.panel_folder.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel_folder.Size = new System.Drawing.Size(681, 50);
            this.panel_folder.TabIndex = 1;
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(316, 0);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(75, 47);
            this.compare.TabIndex = 0;
            this.compare.Text = "COMPARE";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // button_exit
            // 
            this.button_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(595, 3);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(74, 41);
            this.button_exit.TabIndex = 6;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_about
            // 
            this.button_about.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_about.Image = ((System.Drawing.Image)(resources.GetObject("button_about.Image")));
            this.button_about.Location = new System.Drawing.Point(515, 3);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(74, 41);
            this.button_about.TabIndex = 6;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_help
            // 
            this.button_help.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_help.Image = ((System.Drawing.Image)(resources.GetObject("button_help.Image")));
            this.button_help.Location = new System.Drawing.Point(435, 3);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(74, 41);
            this.button_help.TabIndex = 6;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // button_history
            // 
            this.button_history.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_history.Image = ((System.Drawing.Image)(resources.GetObject("button_history.Image")));
            this.button_history.Location = new System.Drawing.Point(174, 3);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(74, 41);
            this.button_history.TabIndex = 5;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // button_save
            // 
            this.button_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.Location = new System.Drawing.Point(94, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(74, 41);
            this.button_save.TabIndex = 4;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_compare
            // 
            this.button_compare.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_compare.Image = ((System.Drawing.Image)(resources.GetObject("button_compare.Image")));
            this.button_compare.Location = new System.Drawing.Point(14, 3);
            this.button_compare.Name = "button_compare";
            this.button_compare.Size = new System.Drawing.Size(74, 41);
            this.button_compare.TabIndex = 3;
            this.button_compare.Click += new System.EventHandler(this.button_compare_Click);
            // 
            // FolderCompare
            // 
            this.FolderCompare.Checked = true;
            this.FolderCompare.ImagePaddingHorizontal = 8;
            this.FolderCompare.Name = "FolderCompare";
            this.FolderCompare.Panel = this.panel_folder;
            this.FolderCompare.Text = "Folder Compare";
            this.FolderCompare.Click += new System.EventHandler(this.FolderCompare_Click);
            // 
            // TextCompare
            // 
            this.TextCompare.ImagePaddingHorizontal = 8;
            this.TextCompare.Name = "TextCompare";
            this.TextCompare.Text = "Text Compare";
            this.TextCompare.Click += new System.EventHandler(this.TextCompare_Click);
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
            this.ribbonControl.Size = new System.Drawing.Size(681, 106);
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
            this.group_fileleft.Controls.Add(this.tabControl1);
            this.group_fileleft.Controls.Add(this.button_back1);
            this.group_fileleft.Controls.Add(this.button_open1);
            this.group_fileleft.Controls.Add(this.path_1);
            this.group_fileleft.Controls.Add(this.label_path1);
            this.group_fileleft.Location = new System.Drawing.Point(4, 113);
            this.group_fileleft.Name = "group_fileleft";
            this.group_fileleft.ShowFocusRectangle = true;
            this.group_fileleft.Size = new System.Drawing.Size(338, 434);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(319, 360);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bame1_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(311, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(311, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.button_open1.Click += new System.EventHandler(this.button_open1_Click);
            // 
            // path_1
            // 
            // 
            // 
            // 
            this.path_1.Border.Class = "TextBoxBorder";
            this.path_1.Location = new System.Drawing.Point(63, 14);
            this.path_1.Name = "path_1";
            this.path_1.Size = new System.Drawing.Size(159, 30);
            this.path_1.TabIndex = 1;
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
            // group_fileright
            // 
            this.group_fileright.CanvasColor = System.Drawing.SystemColors.Control;
            this.group_fileright.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.group_fileright.Controls.Add(this.tabControl2);
            this.group_fileright.Controls.Add(this.button_back2);
            this.group_fileright.Controls.Add(this.button_open2);
            this.group_fileright.Controls.Add(this.path_2);
            this.group_fileright.Controls.Add(this.label_path2);
            this.group_fileright.Location = new System.Drawing.Point(343, 111);
            this.group_fileright.Name = "group_fileright";
            this.group_fileright.ShowFocusRectangle = true;
            this.group_fileright.Size = new System.Drawing.Size(338, 436);
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
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(10, 50);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(319, 362);
            this.tabControl2.TabIndex = 3;
            this.tabControl2.UseWaitCursor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(311, 336);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage1";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.UseWaitCursor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(311, 336);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage2";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.UseWaitCursor = true;
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
            this.button_open2.Click += new System.EventHandler(this.button_open2_Click);
            // 
            // path_2
            // 
            // 
            // 
            // 
            this.path_2.Border.Class = "TextBoxBorder";
            this.path_2.Location = new System.Drawing.Point(63, 14);
            this.path_2.Name = "path_2";
            this.path_2.Size = new System.Drawing.Size(159, 30);
            this.path_2.TabIndex = 1;
            this.path_2.UseWaitCursor = true;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bame1_1
            // 
            this.bame1_1.Location = new System.Drawing.Point(77, 57);
            this.bame1_1.Multiline = true;
            this.bame1_1.Name = "bame1_1";
            this.bame1_1.Size = new System.Drawing.Size(154, 91);
            this.bame1_1.TabIndex = 2;
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
            this.panel_folder.ResumeLayout(false);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.group_fileleft.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.group_fileright.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonPanel panel_folder;
        private DevComponents.DotNetBar.RibbonTabItem FolderCompare;
        private DevComponents.DotNetBar.RibbonTabItem TextCompare;
        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.ItemContainer itemContainer9;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Controls.GroupPanel group_fileleft;
        private DevComponents.DotNetBar.ButtonX button_back1;
        private DevComponents.DotNetBar.ButtonX button_open1;
        private DevComponents.DotNetBar.Controls.TextBoxX path_1;
        private DevComponents.DotNetBar.LabelX label_path1;
        private DevComponents.DotNetBar.Controls.GroupPanel group_fileright;
        private DevComponents.DotNetBar.ButtonX button_back2;
        private DevComponents.DotNetBar.ButtonX button_open2;
        private DevComponents.DotNetBar.Controls.TextBoxX path_2;
        private DevComponents.DotNetBar.LabelX label_path2;
        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ButtonX button_compare;
        private ButtonX button_exit;
        private ButtonX button_about;
        private ButtonX button_help;
        private ButtonX button_history;
        private ButtonX button_save;
        private System.Windows.Forms.TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private OpenFileDialog openFileDialog1;
        private Button compare;
        private SaveFileDialog saveFileDialog1;
        private TextBox bame1_1;
	}
}
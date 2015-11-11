
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
    partial class helpform
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX1.Location = new System.Drawing.Point(175, 37);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.SystemColors.ControlLight;
            this.labelX1.Size = new System.Drawing.Size(162, 91);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "2COMPARE";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(31, 136);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxX1.Size = new System.Drawing.Size(476, 197);
            this.textBoxX1.TabIndex = 2;
            this.textBoxX1.Text = "HỔ TRỢ NGƯỜI DÙNG \r\nVIẾT \r\nỞ \r\nĐÂY .......................\r\n....................." +
    ".....\r\n.................\r\n.\r\n..\r\n.\r\n.\r\n.\r\n.\r\n\r\n";
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX1.WatermarkColor = System.Drawing.Color.Green;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(526, 30);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 3;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // helpform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 369);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "helpform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỖ TRỢ";
            this.Load += new System.EventHandler(this.helpform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private RibbonControl ribbonControl1;
    }
}
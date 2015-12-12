
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
    partial class aboutform
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
            this.nameprogram = new DevComponents.DotNetBar.LabelX();
            this.devoloper = new DevComponents.DotNetBar.LabelX();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameprogram
            // 
            this.nameprogram.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameprogram.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.nameprogram.Location = new System.Drawing.Point(126, 50);
            this.nameprogram.Name = "nameprogram";
            this.nameprogram.SingleLineColor = System.Drawing.SystemColors.ControlLight;
            this.nameprogram.Size = new System.Drawing.Size(162, 91);
            this.nameprogram.TabIndex = 0;
            this.nameprogram.Text = "2COMPARE";
            this.nameprogram.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // devoloper
            // 
            this.devoloper.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.devoloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devoloper.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.devoloper.Location = new System.Drawing.Point(152, 147);
            this.devoloper.Name = "devoloper";
            this.devoloper.SingleLineColor = System.Drawing.SystemColors.ControlText;
            this.devoloper.Size = new System.Drawing.Size(122, 134);
            this.devoloper.TabIndex = 1;
            this.devoloper.Text = "DEVOLOPER :\r\n\r\nRYE NGUYEN\r\n   SHICHI KI\r\n        KEN\r\n       KHOA";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(399, 30);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 2;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(328, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.devoloper);
            this.Controls.Add(this.nameprogram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(120, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.aboutform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX nameprogram;
        private DevComponents.DotNetBar.LabelX devoloper;
        private RibbonControl ribbonControl1;
        private Button button1;
    }
}
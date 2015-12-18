using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace doan2compare
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(metroTabPage2);
           
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(metroButton1, new Point(0, metroButton1.Height));
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroContextMenu2.Show(metroButton1, new Point(0, metroButton2.Height));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (White.Checked == true)
            {
                this.Theme = MetroThemeStyle.Light;
                metroStyleManager.Theme = MetroThemeStyle.Light;
                metroUserControl1.BackColor = this.BackColor;
                metroTrackBar2.BackColor = this.BackColor;

            }
            else
            {
                this.Theme = MetroThemeStyle.Dark;
                metroStyleManager.Theme = MetroThemeStyle.Dark;
                metroUserControl1.BackColor = this.BackColor;
                metroTrackBar2.BackColor = this.BackColor;

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
    }
}

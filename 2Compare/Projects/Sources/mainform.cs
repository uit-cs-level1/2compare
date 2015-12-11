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
    public partial class mainform : Office2007RibbonForm
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button_close_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.No)
            {
                // closing without save 
                this.Close();
                while (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
            }
            if (result == DialogResult.Yes)
            {
                // save them close 
                // code save here .... :v 

                this.Close();
                while (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button \"Save\" Clicked. ");
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            aboutform about;
            about = new aboutform();
            about.Show();
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button \"options\" Clicked. ");
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            helpform help = new helpform();
            help.Show();
        }

        private void button_saveas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button \"save as\" Clicked. ");
        }

        private void button_share_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button \"Share\" Clicked. ");
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button \"Print\" Clicked. ");
        }






    }
}

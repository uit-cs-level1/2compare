using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Compare.Sources
{
    public partial class helpform : Form
    {
        public helpform()
        {
            InitializeComponent();
        }

        private void helpform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.Show();
           
        }
    }
}

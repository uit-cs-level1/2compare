using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Compare
{
    public partial class Compare1 : Form
    {
        public Compare1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compare2 c = new Compare2();
            c.Show();
            this.Hide();
        }
    }
}

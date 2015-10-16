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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compare1 a = new Compare1();
            a.Show();
            this.Hide();
        }
	}
}

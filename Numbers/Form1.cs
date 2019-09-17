using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.141592653589793;
            double c = 299792458;
            richTextBox1.AppendText(pi.ToString("0.000E00") + "\n");
            richTextBox1.AppendText(pi.ToString("0.00000E00") + "\n");
            richTextBox1.AppendText(pi.ToString("0.000000000000E00") + "\n");
            richTextBox1.AppendText(c.ToString("0.00E0") + "\n");
            richTextBox1.AppendText(c.ToString("0.000000000000000E0") + "\n");
            richTextBox1.AppendText(c.ToString("0") + "\n");
            richTextBox1.AppendText(c.ToString("N0") + "\n");

            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integer");
            }
            string s2 = "3.2";
            try
            {
                int it = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + " is not an integer");
                int i2 = 0;
            }
            string s3 = "pi";
            try
            {
                double d2 = double.Parse(s3);
            }
            catch
            {
                double d2 = 0;
            }
        }


        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

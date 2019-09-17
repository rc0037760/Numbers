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
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

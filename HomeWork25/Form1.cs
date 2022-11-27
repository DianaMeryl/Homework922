using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace HomeWork25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min 0 - max 255");




        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min -128 - max 127");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min -32768 - max 32767");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min 0 - max 65535");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min -2147483648 - max 2147483647");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min 0 - max 4294967295");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min -9223372036854775808 - max 9223372036854775807");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min 0 - max 18446744073709551615");
        }
    }
}

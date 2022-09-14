using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Put your name");
                return;
            }
            for(int i = 0; i < 10; i++)
            {
                richTextBox1.AppendText(textBox1.Text + "\n");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

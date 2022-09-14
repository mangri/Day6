using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter some number");
                return;
            }
            int number;
            bool goodToGo = int.TryParse(textBox1.Text, out number);
            int module = number % 2;
            if(goodToGo)
            {
                if(module == 0)
                {
                    richTextBox1.Text = $"{textBox1.Text} is an even number";
                }
                else if(module == 1)
                {
                    richTextBox1.Text = $"{textBox1.Text} is an odd number";
                }
                    
            }
            else
            {
                MessageBox.Show($"Is {textBox1.Text} a valid number?");
                return;
            }
        }
    }
}

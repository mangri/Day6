using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> Sem1 = new List<int>();
        List<int> Sem2 = new List<int>();
        List<int> Sem3 = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            int markSem1;
            bool goodToGo1 = int.TryParse(textBox1.Text, out markSem1);
            if (goodToGo1 && 0 <= markSem1 && markSem1 <= 10)
            {
                textBox1.Text = " ";
                Sem1.Add(markSem1);
                richTextBox1.Text = $"Sem1 avg. mark : {Sem1.Average()}, all marks: ";
                foreach (int m1 in Sem1)
                {
                    richTextBox1.AppendText(m1 + " ");
                }
                richTextBox1.AppendText("\n");
                if(Sem2.Count != 0)
                {
                    richTextBox1.AppendText($"Sem2 avg. mark : {Sem2.Average()}, all marks: ");
                    foreach (int m2 in Sem2)
                    {
                        richTextBox1.AppendText(m2 + " ");
                    }
                }
                richTextBox1.AppendText("\n");
                if (Sem3.Count != 0)
                {
                    richTextBox1.AppendText($"Sem3 avg. mark : {Sem3.Average()}, all marks: ");
                    foreach (int m3 in Sem3)
                    {
                        richTextBox1.AppendText(m3 + " ");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Is {textBox1.Text} a valid mark?");
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Sem1.Count != 0)
            {
                richTextBox1.Text = $"Sem1 avg. mark : {Sem1.Average()}, all marks: ";
                foreach (int m1 in Sem1)
                {
                    richTextBox1.AppendText(m1 + " ");
                }
                richTextBox1.AppendText("\n");
            }
            int markSem2;
            bool goodToGo2 = int.TryParse(textBox2.Text, out markSem2);
            if (goodToGo2 && 0 <= markSem2 && markSem2 <= 10)
            {
                textBox2.Text = " ";
                Sem2.Add(markSem2);
                richTextBox1.AppendText($"Sem2 avg. mark : {Sem2.Average()}, all marks: ");
                foreach (int m2 in Sem2)
                {
                    richTextBox1.AppendText(m2 + " ");
                }
            }
            else if(!goodToGo2)
            {
                MessageBox.Show($"Is {textBox2.Text} a valid mark?");
                return;
            }
            richTextBox1.AppendText("\n");
            if (Sem3.Count != 0)
            {
                richTextBox1.AppendText($"Sem3 avg. mark : {Sem3.Average()}, all marks: ");
                foreach (int m3 in Sem3)
                {
                    richTextBox1.AppendText(m3 + " ");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (Sem1.Count != 0)
            {
                richTextBox1.Text = $"Sem1 avg. mark : {Sem1.Average()}, all marks: ";
                foreach (int m1 in Sem1)
                {
                    richTextBox1.AppendText(m1 + " ");
                }
                richTextBox1.AppendText("\n");
            }
            if (Sem2.Count != 0)
            {
                richTextBox1.AppendText($"Sem2 avg. mark : {Sem2.Average()}, all marks: ");
                foreach (int m2 in Sem2)
                {
                    richTextBox1.AppendText(m2 + " ");
                }
            }
            richTextBox1.AppendText("\n");
            int markSem3;
            bool goodToGo3 = int.TryParse(textBox3.Text, out markSem3);
            if (goodToGo3 && 0 <= markSem3 && markSem3 <= 10)
            {
                textBox3.Text = " ";
                Sem3.Add(markSem3);
                richTextBox1.AppendText($"Sem3 avg. mark : {Sem3.Average()}, all marks: ");
                foreach (int m3 in Sem3)
                {
                    richTextBox1.AppendText(m3 + " ");
                }
            }
            else if(!goodToGo3)
            {
                MessageBox.Show($"Is {textBox3.Text} a valid mark?");
                return;
            }
        }
    }
}

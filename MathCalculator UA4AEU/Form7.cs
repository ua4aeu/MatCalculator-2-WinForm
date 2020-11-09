using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, i, num;
            a = 0;
            b = 1;
            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            num = Convert.ToInt32(textBox1.Text);

            for(i=3; i<=num; i++)
            {
                c = a + b;
                listBox1.Items.Add(c);
                a = b;
                b = c;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ряд Фибоначчи.\n\nэлементы числовой последовательности. 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, …"); // всплывающее окно
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBank.Text = textBox1.Text;
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide(); // закрыть эту форму
        }
    }
}

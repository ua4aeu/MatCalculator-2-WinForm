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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c;
            int x, y, z;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(Math.Pow(x , 2) + 2 * x * y + Math.Pow(y, 2));
            c = Convert.ToString(z);
            textBox3.Text = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c;
            int x, y, z;
            x = Convert.ToInt32(textBox4.Text);
            y = Convert.ToInt32(textBox5.Text);
            z = Convert.ToInt32(Math.Pow(x, 2) - 2 * x * y + Math.Pow(y, 2));
            c = Convert.ToString(z);
            textBox6.Text = c;
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

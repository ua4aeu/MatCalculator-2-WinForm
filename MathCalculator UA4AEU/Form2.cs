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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = DataBank.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide(); // закрыть эту форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide(); // закрыть эту форму
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
            this.Hide(); // закрыть эту форму
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
            this.Hide(); // закрыть эту форму
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
            this.Hide(); // закрыть эту форму
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа МАТЕМАТИЧЕСКИЙ КАЛЬКУЛЯТОР.\n\nАвтор: Василенко И.К.\nГруппа ПКС1-18\n2020г."); // всплывающее окно
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа МАТЕМАТИЧЕСКИЙ КАЛЬКУЛЯТОР.\n\nАвтор: Василенко И.К.\nГруппа ПКС1-18\n2020г."); // всплывающее окно
        }
    }
}

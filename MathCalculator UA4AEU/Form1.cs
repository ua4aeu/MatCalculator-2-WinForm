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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.Text = textBox1.Text;
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide(); // закрыть эту форму
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа МАТЕМАТИЧЕСКИЙ КАЛЬКУЛЯТОР.\n\nАвтор: Василенко И.К.\nГруппа ПКС1-18\n2020г."); // всплывающее окно
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Вход в программу");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа МАТЕМАТИЧЕСКИЙ КАЛЬКУЛЯТОР.\n\nАвтор: Василенко И.К.\nГруппа ПКС1-18\n2020г."); // всплывающее окно
        }
    }
}

﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string z;
            int x, y;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox4.Text);
            z = Convert.ToString( x * y);
            textBox8.Text = z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string z;
            int x, y;
            x = Convert.ToInt32(textBox2.Text);
            y = Convert.ToInt32(textBox5.Text);
            z = Convert.ToString(( x * y) / 2) ;
            textBox7.Text = z;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string z;
            int x;
            x = Convert.ToInt32(textBox3.Text);
            z = Convert.ToString(Math.PI * Math.Pow(x , 2));
            textBox6.Text = z;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
            {
                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(a + b);
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(a - b);
                        break;
                    case "*":
                        textBox3.Text = Convert.ToString(a * b);
                        break;
                    case "/":
                        textBox3.Text = Convert.ToString(a / b);
                        break;
                }
            }
            if (radioButton2.Checked)
            {
                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(a + b);
                        int q = Convert.ToInt32(textBox3.Text);
                        textBox4.Text = Convert.ToString(q, 2);
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(a - b);
                        int w = Convert.ToInt32(textBox3.Text);
                        textBox4.Text = Convert.ToString(w, 2);
                        break;
                    case "*":
                        int r = Convert.ToInt32(textBox3.Text);
                        textBox4.Text = Convert.ToString(r, 2);
                        textBox3.Text = Convert.ToString(a * b);
                        break;
                    case "/":
                        int t = Convert.ToInt32(textBox3.Text);
                        textBox4.Text = Convert.ToString(t, 2);
                        textBox3.Text = Convert.ToString(a / b);
                        break;
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

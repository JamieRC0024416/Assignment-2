using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Calculate 2 resistors in series
            try
            {
                double value1, value2, resistance;
                value1 = Convert.ToDouble(textBox8.Text);
                value2 = Convert.ToDouble(textBox9.Text);
                resistance = value1 + value2;
                label16.Text = "Resistance =" + resistance;
            }
            catch
            {
                MessageBox.Show("type in two numbers");

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Calculate 3 resistors in series
            try
            {
                double value1, value2, value3, resistance;
                value1 = Convert.ToDouble(textBox7.Text);
                value2 = Convert.ToDouble(textBox10.Text);
                value3 = Convert.ToDouble(textBox11.Text);
                resistance = value1 + value2 + value3;
                label14.Text = "Resistance =" + resistance;
            }
            catch
            {
                MessageBox.Show("type in three numbers");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Calculate 4 resistors in series
            try
            {
                double value1, value2, value3, value4, resistance;
                value1 = Convert.ToDouble(textBox6.Text);
                value2 = Convert.ToDouble(textBox12.Text);
                value3 = Convert.ToDouble(textBox13.Text);
                value4 = Convert.ToDouble(textBox14.Text);
                resistance = value1 + value2 + value3 + value4;
                label12.Text = "Resistance =" + resistance;
            }
            catch
            {
                MessageBox.Show("type in four numbers");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Calculate 5 resistors in series
            try
            {
                double value1, value2, value3, value4, value5, resistance;
                value1 = Convert.ToDouble(textBox5.Text);
                value2 = Convert.ToDouble(textBox15.Text);
                value3 = Convert.ToDouble(textBox16.Text);
                value4 = Convert.ToDouble(textBox17.Text);
                value5 = Convert.ToDouble(textBox18.Text);
                resistance = value1 + value2 + value3 + value4 + value5;
                label10.Text = "Resistance =" + resistance;
            }
            catch
            {
                MessageBox.Show("type in five numbers");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculate 2 resistors in parallel
            try
            {
                double value1, value2, resistance;
                value1 = Convert.ToDouble(textBox1.Text);
                value2 = Convert.ToDouble(textBox2.Text);
                resistance = 1 / (1/ value1 + 1/ value2 + 1);
                label4.Text = "Resistance =" + resistance;
            }
            catch
            {
                MessageBox.Show("type in two numbers");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate 3 resistors in parallel
            try
            {
                double value1, value2, value3, resistance;
                value1 = Convert.ToDouble(textBox20.Text);
                value2 = Convert.ToDouble(textBox19.Text);
                value3 = Convert.ToDouble(textBox21.Text);
                resistance = 1 / (1 / value1 + 1 / value2 + 1 / value3 + 1);
                label2.Text = "Resistance =" + resistance;
            }
            catch
            {
                MessageBox.Show("type in three numbers");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Calculate 4 resistors in parallel
            try
            {
                double value1, value2, value3, value4, resistance;
                value1 = Convert.ToDouble(textBox3.Text);
                value2 = Convert.ToDouble(textBox24.Text);
                value3 = Convert.ToDouble(textBox23.Text);
                value4 = Convert.ToDouble(textBox22.Text);
                resistance = 1 / (1 / value1 + 1 / value2 + 1 / value3 + 1 / value4 + 1);
                label6.Text = "Resistance =" + resistance;
            }
            catch
            {
                MessageBox.Show("type in four numbers");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Calculate 5 resistors in parallel
            try
            {
                double value1, value2, value3, value4, value5, resistance;
                value1 = Convert.ToDouble(textBox28.Text);
                value2 = Convert.ToDouble(textBox27.Text);
                value3 = Convert.ToDouble(textBox26.Text);
                value4 = Convert.ToDouble(textBox25.Text);
                value5 = Convert.ToDouble(textBox4.Text);
                resistance = 1 / (1 / value1 + 1 / value2 + 1 / value3 + 1 / value4 + 1);
                label8.Text = "Resistance =" + resistance;
            }
            catch
            {
                MessageBox.Show("type in five numbers");
            }
        }
    }
}

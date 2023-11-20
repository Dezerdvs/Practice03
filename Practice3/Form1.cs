using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int FirstNumber, SecondNumber, ThirdNumber;

            FirstNumber = Convert.ToInt32(textBox1.Text);
            SecondNumber = Convert.ToInt32(textBox2.Text);
            ThirdNumber = Convert.ToInt32(textBox3.Text);

            var nubmerCalc = new NumberCalculations();

            label4.Text = nubmerCalc.PerformCalculation().ToString();

            int Start, End;

            Start = Convert.ToInt32(textBox6.Text);
            End = Convert.ToInt32(textBox5.Text);

            var inter = new Interval(Start, End);

            label6.Text = inter.IntervalCalculation().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmiproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textBox1.Text);
            double height = Convert.ToDouble(textBox2.Text);



            double bmi = weight / (height * height);
            label2.Text = bmi.ToString();

            if (bmi < 18)
            {
                label1.Text = "Thin";
                label1.ForeColor = Color.Orange;

            }

            else if (bmi >= 18 && bmi < 25)
            {
                label1.Text = "Normal";
                label1.ForeColor = Color.Yellow;
            }
            else if (bmi >= 25 && bmi < 30)
            {
                label1.Text = "Fat";
                label1.ForeColor = Color.Black;
            }
            else if (bmi >= 30 && bmi < 35)
            {
                label1.Text = "Obese";
                label1.ForeColor = Color.Red;
            }


        }
    }
}

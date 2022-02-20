using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Below code has been used for calculating factorial of a number by using static class member "Factorial".
        private void btn_factorial_Click(object sender, EventArgs e)
        {
            lbl_result.Text = Simple_Equations.Factorial(Convert.ToInt32(txt_number.Text)).ToString();

            txt_number.Clear();
        }

        //Below codes has been created for calculating cube of a given number.
        private void btn_cubic_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cube of the number given is {Simple_Equations.Cubic(double.Parse(txt_cubic.Text))}");

            txt_cubic.Clear();
        }
    }
}

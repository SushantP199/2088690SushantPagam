using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_TextChanged(object sender, EventArgs e) { }

        private void Calculate_Result(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(input1.Text);
                num2 = Convert.ToInt32(input2.Text);

                int result = 0;

                if (rbtnAddition.Checked)
                {
                    result = num1 + num2;

                }

                if (rbtnSubstraction.Checked)
                {
                    result = num1 - num2;
                }
                if (rbtnMultiplication.Checked)
                {
                    result = num2 * num1;
                }
                if (rbtnDivision.Checked)
                {
                    result = num1 / num2;
                }
                MessageBox.Show("" + result);

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid input for the operands");
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}

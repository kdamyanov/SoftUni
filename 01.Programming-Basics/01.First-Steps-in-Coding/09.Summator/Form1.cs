using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09.Summator
{
    public partial class formCalculator : Form
    {
        public formCalculator()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var firstNumber = decimal.Parse(numberOne.Text);
                var secondNumber = decimal.Parse(numberTwo.Text);

                decimal sumOfTwoNumbers = firstNumber + secondNumber;
                sum.Text = sumOfTwoNumbers.ToString();
            }
            catch (Exception)
            {

                sum.Text ="eror";
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForIoT
{
    public partial class Form1 : Form
    {
        double _firstNumber;
        bool _cleanScreen;
        private char _process;
        string secondLabel;
        public Form1()
        {
            InitializeComponent();
        }      
        private void btn_Click(object sender, EventArgs e)
        {
            Button selected_Button = (Button)sender;

            if (_cleanScreen == true)
            {
                lblScreen.Text = "";
                _cleanScreen = false;
            }

            if(lblScreen.Text == "0")
                lblScreen.Text = "";

            lblScreen.Text += selected_Button.Text;
        }          
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;
            secondNumber = Convert.ToDouble(lblScreen.Text);
            switch (_process)
            {
                case '+':
                    result = _firstNumber + secondNumber;
                    lblScreen.Text = result.ToString();
                    lblFirstNumber.Text = secondLabel + secondNumber;
                    break;

                case '-':
                    result = _firstNumber - secondNumber;
                    lblScreen.Text = result.ToString();
                    lblFirstNumber.Text = secondLabel + secondNumber;
                    break;
                case '*':
                    result = _firstNumber * secondNumber;
                    lblScreen.Text = result.ToString();
                    lblFirstNumber.Text = secondLabel + secondNumber;
                    break;
                case '/':
                    result = _firstNumber / secondNumber;
                    lblScreen.Text = result.ToString();
                    lblFirstNumber.Text = secondLabel + secondNumber;
                    break;
                case 's':
                    result = _firstNumber * _firstNumber;
                    lblScreen.Text = result.ToString();
                    lblFirstNumber.Text = secondLabel + secondNumber;
                    break;
                case 'r':
                    result = Math.Sqrt(Convert.ToDouble(_firstNumber));
                    lblScreen.Text = result.ToString();
                    lblFirstNumber.Text = secondLabel + secondNumber;
                    break;

            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblScreen.Text = "0";
            lblFirstNumber.Text = "";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Button selectedProcess_Button = (Button)sender;

            if (selectedProcess_Button.Text.Equals("+"))
            {
                _process = '+';
                _firstNumber = Convert.ToDouble(lblScreen.Text); 
                _cleanScreen = true;
                secondLabel = Convert.ToString(_firstNumber)+_process;
                lblFirstNumber.Text = secondLabel;
            }
            else if (selectedProcess_Button.Text.Equals("-"))
            {
                _process = '-';
                _firstNumber = Convert.ToDouble(lblScreen.Text);
                _cleanScreen = true;
                secondLabel = Convert.ToString(_firstNumber) + _process;
                lblFirstNumber.Text = secondLabel;
            }
            else if (selectedProcess_Button.Text.Equals("*"))
            {
                _process = '*';
                _firstNumber = Convert.ToDouble(lblScreen.Text);
                _cleanScreen = true;
                secondLabel = Convert.ToString(_firstNumber)+_process;
                lblFirstNumber.Text = secondLabel;

            }
            else if (selectedProcess_Button.Text.Equals("/"))
            {
                _process = '/';
                _firstNumber = Convert.ToDouble(lblScreen.Text);
                _cleanScreen = true;
                secondLabel = Convert.ToString(_firstNumber) + _process;
                lblFirstNumber.Text = secondLabel;
            }
            else if (selectedProcess_Button.Text.Equals("x²"))
            {
                _process = 's';
                _firstNumber = Convert.ToDouble(lblScreen.Text);
                _cleanScreen = true;
                secondLabel = Convert.ToString(_firstNumber) + "²";
                lblFirstNumber.Text = secondLabel;
            }
            else if (selectedProcess_Button.Text.Equals("√¯"))
            {
                _process = 'r';
                _firstNumber = Convert.ToDouble(lblScreen.Text);
                _cleanScreen = true;
                secondLabel = "√¯" + Convert.ToString(_firstNumber);
                lblFirstNumber.Text = secondLabel;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(lblScreen.Text) > 0)
            {
                lblScreen.Text=lblScreen.Text.Remove(lblScreen.Text.Length-1,1);
            }
            lblFirstNumber.Text = "";
        }
    }
}

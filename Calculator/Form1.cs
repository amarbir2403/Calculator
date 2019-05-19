using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calculator.Calculate;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        double firstNum;
        double secondNum;
        private Calculate obj;
        private CalculatorDelegate del;

        public CalculatorForm()
        {
            InitializeComponent();
            obj = new Calculate();
            del = obj.GetDelegateRef(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox_Result.Text == "0")
                TextBox_Result.Clear();
            Button button = (Button)sender;
            TextBox_Result.Text = TextBox_Result.Text + button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox_Result.Text = TextBox_Result.Text + 2;

        }

        private void TextBox_Result_TextChanged(object sender, EventArgs e)
        {


        }

        private void operator_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (button == BtnAdd)
            {
                firstNum = double.Parse(TextBox_Result.Text);

                TextBox_Result.Text = "";
                del = obj.GetDelegateRef(1);
            }

            if (button == BtnSubtract)
            {
                firstNum = double.Parse(TextBox_Result.Text);

                TextBox_Result.Text = "";
                del = obj.GetDelegateRef(2);
            }
            if (button == BtnMultiply)
            {
                firstNum = double.Parse(TextBox_Result.Text);

                TextBox_Result.Text = "";
                del = obj.GetDelegateRef(3);
            }
            if (button == BtnDivide)
            {
                firstNum = double.Parse(TextBox_Result.Text);

                TextBox_Result.Text = "";
                del = obj.GetDelegateRef(4);
            }
            if (button == Btn1byX)
            {
                firstNum = double.Parse(TextBox_Result.Text);
                del = obj.GetDelegateRef(5);

                double res = del.Invoke(1, firstNum);
                firstNum = res;
                double result = Math.Round(res, 2);
                TextBox_Result.Text = result+ "";
                
            }
            if (button == BtnX2)
            {
                firstNum = double.Parse(TextBox_Result.Text);
                
                del = obj.GetDelegateRef(6);

                double res = del.Invoke(firstNum, firstNum);

                firstNum = res;

                TextBox_Result.Text = res + "";
            }
            else if(button == BtnEquals)
            {
                secondNum = double.Parse(TextBox_Result.Text);
                double res = del.Invoke(firstNum,secondNum);

                firstNum = res;
                double result = Math.Round(res, 2);
                TextBox_Result.Text = result+"";
            }

        }

        private void Button_clear(object sender, EventArgs e)
        {
            TextBox_Result.Clear();
            firstNum = 0;
            secondNum = 0;


        }

        private void button_Backspace(object sender, EventArgs e)
        {
            string result = TextBox_Result.Text;
            
            TextBox_Result.Text = result.Substring(0,result.Length - 1);
        }

        private void plusminus_click(object sender, EventArgs e)
        {

            double res = Double.Parse(TextBox_Result.Text);
            TextBox_Result.Text = (-res).ToString();
        }
    }
}

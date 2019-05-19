using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        //Declare Delegate
        public delegate double CalculatorDelegate(double x, double y);

        //Create Delegate Reference
        CalculatorDelegate delegateObj = null;

        //Depending upon request we will assign Delegate
        public CalculatorDelegate GetDelegateRef(int intoperation)
        {
            //And Finally assign based on request
            switch (intoperation)
            {
                
                case 1:
                    delegateObj = Add;
                    break;
                case 2:
                    delegateObj = Sub;
                    break;
                case 3:
                    delegateObj = Multi;
                    break;
                case 4:
                    delegateObj = Div;
                    break;
                case 5:
                    delegateObj = OneByX;
                    break;
                case 6:
                    delegateObj = XSquare;
                    break;
                default: break;
                
            }
            return delegateObj;
        }

        private double Add(double a, double b) { return a + b; }
        private double Sub(double a, double b) { return a - b; }
        private double Multi(double x, double y) { return x * y; }
        private double Div(double x, double y) { return x / y; }
        private double OneByX(double x, double y) { return x / y; }
        private double XSquare(double x, double y) { return (x * y); }
    }
}

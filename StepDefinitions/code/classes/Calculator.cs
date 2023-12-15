using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Threading.Tasks;
using SpecFlowProject1.StepDefinitions.Interfaces;

namespace SpecFlowProject1.StepDefinitions.classes
{
    [Binding]
    public class Calculator : ICalculator
    {
        //private CalculatorView view;
        //public Calculator() { view = new CalculatorView(); }

        [Then("the result of Sum is (.*)")]
        public double Sum (double a, double b)
        {
            return a + b;
        }

        [Then("enter num(.*)")]
        public double EnterNumber(double num)
        {
            if (num < 0) return 1;

            return num;
        }

        [Then("the result of Subtract is (.*)")]
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        [Then("the result of Multiply is (.*)")]
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        [Then("the result of Divide is (.*)")]
        public double Divide(double a, double b)
        {
            //if (b == 0 || b < 10e-8) { view.DisplayError(new ArithmeticException()); return double.NaN; };
            return a / b;
        }

        /*public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }*/
    }
}

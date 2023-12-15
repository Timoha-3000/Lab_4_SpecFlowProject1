using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject1.StepDefinitions.Interfaces;

namespace SpecFlowProject1.StepDefinitions.classes
{
    [Binding]
    public class CalculatorPresenter : ICalculatorPresenter
    {
        public double FirstArgument { get; set; } = 0;
        public double SecondArgument { get; set; } = 0;
        public double Result { get; set; } = 0;
        private Calculator Calculator { get; set; } = new Calculator();
        private CalculatorView CalculatorView { get; set; } = new CalculatorView();

        /*public CalculatorPresenter()
        {
            Calculator = new Calculator();
            CalculatorView = new CalculatorView();
        }*/

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(double number)
        {
            FirstArgument = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(double number)
        {
            SecondArgument = number;
        }

        [When("the two numbers are added for Sum")]
        public void OnPlusClicked()
        {
            Result = Calculator.Sum(FirstArgument, SecondArgument);
            CalculatorView.PrintResult(Result);
        }

        [When("the two numbers are added for Minus")]
        public void OnMinusClicked()
        {
            Result = Calculator.Subtract(FirstArgument, SecondArgument);
            CalculatorView.PrintResult(Result);
        }

        [When("the two numbers are added for Divide")]
        public void OnDivideClicked()
        {
            Result = Calculator.Divide(FirstArgument, SecondArgument);
            CalculatorView.PrintResult(Result);
        }

        [When("the two numbers are added for Multiply")]
        public void OnMultiplyClicked()
        {
            Result = Calculator.Multiply(FirstArgument, SecondArgument);
            CalculatorView.PrintResult(Result);
        }

        [Then("the result should be (.*)")]
        public void PrintResult(double result)
        {
            //return result;
            if (result != Result)
            {
                throw new Exception($"Expected result is {Result}, but was {result}");
            }
            //MessageBox.Show($"{result}", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

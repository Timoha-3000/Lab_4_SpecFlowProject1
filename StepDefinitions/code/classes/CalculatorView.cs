using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SpecFlowProject1.StepDefinitions.Interfaces;

namespace SpecFlowProject1.StepDefinitions.classes
{
    public class CalculatorView : ICalculatorView
    {
        public double FirstArgument { get; set; }
        public double SecondArgument { get; set; }

        public CalculatorView() { }

        public void PrintResult(double result)
        {
            //return result;
            //MessageBox.Show($"{result}", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public SystemException DisplayError(SystemException message)
        {
            return message;
            //MessageBox.Show($"{message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public string GetFirstArgumentAsString()
        {
            return FirstArgument.ToString();
        }

        public string GetSecondArgumentAsString()
        {
            return SecondArgument.ToString();
        }
    }
}

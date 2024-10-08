﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.StepDefinitions.Interfaces
{
    public interface ICalculatorView
    {
        /**
        * Отображает результат вычисления
        */
        void PrintResult(double result);

        /**
         * Показывает ошибку, например деление на 0, пустые аргументы и прочее
         */
        SystemException DisplayError(SystemException message);

        /**
         * Возвращает значение, введенное в поле первого аргументы
         */
        string GetFirstArgumentAsString();

        /**
         * Возвращает значение, введенное в поле второго аргументы
         */
        string GetSecondArgumentAsString();

    }
}

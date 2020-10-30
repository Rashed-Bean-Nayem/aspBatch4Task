using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCalculatorLibrary;

namespace TestAutoFac.Models
{
    public class CalculatorModel
    {
        public double FirstVariable { get; set; }
        public double SecondVariable { get; set; }


        public readonly ICalculator _calculator;

        public CalculatorModel(ICalculator calculator)
        {
            _calculator = calculator;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TestCalculatorLibrary
{
    public interface ICalculator
    {
        double Addition(double a, double b);
        double subtraction(double a, double b);
        double multiplication(double a, double b);
        double division(double a, double b); 
    }
}

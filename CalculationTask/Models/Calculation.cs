
using CalculationTask.Interfaces;

namespace CalculationTask.Models
{
    internal class Calculation : ICalculation
    {
        public double Divide(double number, double number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("0-a bolmek olmur");
            }
          return number/number2;   
        }

        public double Minus(double number, double number2)
        {
           return number - number2;
        }

        public double Multiple(double number, double number2)
        {
           return number*number2;
        }

        public double Sum(double number, double number2)
        {
          return number+number2;
        }
    }
}

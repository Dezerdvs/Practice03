using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class NumberCalculations
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int ThirdNumber { get; set; }

        public NumberCalculations()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            ThirdNumber = 0;
        }

        public NumberCalculations(int firstNumber, int secondNumber, int thirdNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            ThirdNumber = thirdNumber;
        }

        public double CalculateProduct()
        {
            return FirstNumber * SecondNumber * ThirdNumber;
        }

        public double CalculateSquareOfSum()
        {
            return Math.Pow(FirstNumber + SecondNumber + ThirdNumber, 2);
        }

        public double PerformCalculation()
        {
            return (FirstNumber % 2 == 0 && SecondNumber % 2 == 0 && ThirdNumber % 2 == 0)
                ? CalculateProduct() : CalculateSquareOfSum();
        }
    }
}

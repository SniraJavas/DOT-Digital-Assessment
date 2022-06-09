using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Interfaces;

namespace Utilities.Repository
{
    public class Calculator : ICalculator
    {
        int ICalculator.Calculate(string expression)
        {
            var digits = expression.Split('+','-');
            var intDigits = new int[digits.Length];
            int index = 0;
            int sum = 0;
            foreach (var digit in digits) {
               
                    sum += int.Parse(digit);
         
            }

            return sum;
         
        }
    }
}

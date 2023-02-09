using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsCalc
{
    internal class calcService
    {
        public decimal Add(decimal num1, decimal num2)
        {
            var addNum = num1 + num2;
            return addNum;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            var subNum = num1 - num2;
            return subNum;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            var multNum = num1 * num2;
            return multNum;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            var divNum = num1 / num2;
            return divNum;
        }
    }
}

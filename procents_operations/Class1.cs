using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace procents_operations
{
    public class Class1
    {
        public static double PercentageOfTheNumber(double number, double percent)
        {
            if (double.IsNaN(number) || double.IsNaN(percent))
            {
                throw new ArgumentException("Числа не должны быть NaN.");
            }

            return number * (percent / 100);
        }

        public static double FindTheOriginalNumber(double number, double percent)
        {
            if (double.IsNaN(number) || double.IsNaN(percent))
            {
                throw new ArgumentException("Числа не должны быть NaN.");
            }

            if (percent == 0)
            {
                throw new DivideByZeroException("Процент не может быть равен нулю.");
            }

            return number / (percent / 100);
        }
    }
}

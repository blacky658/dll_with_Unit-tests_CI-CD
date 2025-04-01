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
            return number * (percent/100);
        }

        public static double FindTheOriginalNumber(double number, double percent)
        {
            return (number / (percent/100));
        }
    }
}


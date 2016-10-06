using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class Calculator
    {
        public static double divide(double a, double b)
        {
            if (b == 0) throw new ArgumentException();
            return a / b;
        }
    }
}

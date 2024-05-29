using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___XUnit
{
    public class Calculator
    {
        public double Addition(double a, double b)
        {                               
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divide by 0 is not allowed");                
            }
            return a / b;
        }

        public double Multiplikation(double a, double b)
        {
            return a * b;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Calculator : ICalculator
    {
        public double Add(double n1, double n2)
        {
            Console.WriteLine("Called : Add {0} and {1}", n1, n2);
            return n1 + n2;
        }

        public double Divide(double n1, double n2)
        {
            Console.WriteLine("Called : Divide {0} by {1}", n1, n2);
            return n1 / n2;
        }

        public double Multiply(double n1, double n2)
        {
            Console.WriteLine("Called : Multiply {0} by {1}", n1, n2);
            return n1 * n2;
        }

        public double Power(double n1, double n2)
        {
            Console.WriteLine("Called : Power {0} by {1}", n1, n2);
            return Math.Pow(n1,n2);
        }

        public double Subtract(double n1, double n2)
        {
            Console.WriteLine("Called : Subtract {0} by {1}", n1, n2);
            return n1 - n2;
        }
    }
}

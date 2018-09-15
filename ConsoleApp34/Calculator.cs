using System;

namespace ConsoleApp34
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            double result;
            result = x + y;
            return result;
        }

        public double Subtract(double x, double y)
        {
            double result;
            result = x - y;
            return result;
        }

        public double Multiply(double x, double y)
        {
            double result;
            result = x * y;
            return result;
        }

        public double Divide(double x, double y)
        {
            double result;
            if (y == 0)
                throw new SystemException("ypu can not divide with a null number");
            result = x / y;
            return result;
        }
    }
}

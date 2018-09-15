using System;

namespace ConsoleApp34
{
    public class Result : Calculator
    {
        public double PartResult(string part)
        {
            string[] numbersInPart = part.Split('*', '/');
            int totalNumbersInPart = numbersInPart.Length;
            double[] floatsInPart = new double[totalNumbersInPart];

            for (int i = 0; i < numbersInPart.Length; i++)
            {
                floatsInPart[i] = Convert.ToDouble(numbersInPart[i]);
            }

            double partResult = floatsInPart[0];
            int j = 1;
            foreach (char c in part)
            {
                if (c == '*')
                {
                    partResult = Multiply(partResult, floatsInPart[j]);
                    j++;
                }
                else if (c == '/')
                {
                    partResult = Divide(partResult, floatsInPart[j]);
                    j++;
                }
            }

            return partResult;
        }

        public double FullResult(string function, double[] partResults)
        {
            double result = partResults[0];
            int i = 1;
            foreach (char c in function)
            {
                if (c == '+')
                {
                    result = Add(result, partResults[i]);
                    i++;
                }
                else if (c == '-')
                {
                    result = Subtract(result, partResults[i]);
                    i++;
                }
            }

            return result;
        }
    }
}

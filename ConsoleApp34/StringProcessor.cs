using System;

namespace ConsoleApp34
{
    public class StringProcessor : Result
    {
        public string Process (string function)
        {
            string[] partsInFunction = function.Split('+', '-');
            int numberOfParts = partsInFunction.Length;

            double[] partResults = new double[numberOfParts];
            for (int i = 0; i < numberOfParts; i++)
            {
                partResults[i] = PartResult(partsInFunction[i]);
            }

            double functionResult = FullResult(function, partResults);
            return  Convert.ToString(functionResult);
        }
    }
}

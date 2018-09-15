using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = false;
            var subString = new SubStringCreator();
            var stringpProcessor = new StringProcessor();
            Console.WriteLine("input data to calculate:");
            Console.WriteLine("example: 1.5+(1.7*(1.8+1.9)-1.3*1.4)+0*(0.3+2)-2*(3*(3*(3)))");
            string function = Console.ReadLine();
            Console.WriteLine("conversion process: ");

            for(int i = 0; i < function.Length; i++)
            {
                if (function[i] == '(')
                {
                    subString.pFrom = i;
                    start = true;
                }
                else if(function[i] ==')')
                {
                    if (start == true)
                    {
                        subString.pTo = i+1;
                        start = false;

                        string subFunction = subString.Create(function);
                        string subFunctionWithoutBrackett = subFunction.Trim('(', ')');
                        string subFunctionResult = stringpProcessor.Process(subFunctionWithoutBrackett);
                        function = function.Replace(subFunction, subFunctionResult);
                        Console.WriteLine(function);
                        i = 0;
                    }
                }
            }

            function = function.Trim('(', ')');
            string result = stringpProcessor.Process(function);
            Console.WriteLine("final result" + result);
        }
    }
}

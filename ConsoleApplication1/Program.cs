using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteProgram();
            Console.ReadKey();
        }


        private static void ExecuteProgram()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(GetTextToPrint(i));
            }
        }

        private static string GetTextToPrint(int i)
        {
            bool isMultipleOf3 = i % 3 == 0;
            bool isMultipleOf5 = i % 5 == 0;

            if (isMultipleOf3 && isMultipleOf5)
            {
                return "FizzBuzz";
            }
            else if (isMultipleOf3)
            {
                return "Fizz";
            }
            else if (isMultipleOf5)
            {
                return "Buzz";
            }
            else
            {
                return i.ToString();
            }
        }
    }
}

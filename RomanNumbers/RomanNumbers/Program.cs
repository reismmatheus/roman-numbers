using System;
using System.Collections.Generic;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the Roman Number");
            var romanNumber = Console.ReadLine();

            var result = ToRomanNumbers(romanNumber.ToLower());            

            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }

        private static int ToRomanNumbers(string romanNumber)
        {
            var result = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (romanNumber[i] == 'x')
                {
                    result += 10;
                }
                else if (romanNumber[i] == 'v')
                {
                    result += 5;
                }
                else if (romanNumber[i] == 'i')
                {
                    if (romanNumber.Length > i + 1 && romanNumber[i + 1] == 'x')
                    {
                        result += 9;
                        i++;
                    }
                    else if (romanNumber.Length > i + 1 && romanNumber[i + 1] == 'v')
                    {
                        result += 4;
                        i++;
                    }
                    else
                    {
                        result += 1;
                    }
                }
            }

            return result;
        }
    }
}

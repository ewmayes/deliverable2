using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {




            Console.WriteLine("This program will check, given two numbers, if each corresponding place");
            Console.WriteLine("in the two numbers (ones, tens, hundreds, ...) sums to the same total.");
            Console.WriteLine("Enter integer value: ");
            string number1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter another integer value with the same number of digits as previously:");
            string number2 = Convert.ToString(Console.ReadLine());

            int Length1 = number1.Length;
            int Length2 = number2.Length;

            if (Length1 == Length2)
            {
                Math(number1, number2);
            }

            else
            { Console.WriteLine("The same number of digits, please."); }

            Console.ReadKey();
        }

        static void Math(string number1, string number2)
        {
            int Length1 = number1.Length;
            int length = Length1 - 1;
            int num = Length1;
            int combined = 0;
            int letter = 0;
            HashSet<int> sum = new HashSet<int> { };

            while (num > 0)
            {
                letter = Int32.Parse(number1.Substring(length, 1));
                int letter2 = Int32.Parse(number2.Substring(length, 1));
                combined = letter + letter2;
                sum.Add(combined);
                Console.WriteLine(combined);
                length--;
                num--;
            }

            if (sum.Count == 1)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }

        }

    }
}

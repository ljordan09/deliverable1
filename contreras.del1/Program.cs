using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contreras.del1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = SumDigits();
            int sum2 = SumDigits2();
            if (sum == sum2)
            {
                Console.WriteLine("True - The sums of both integers' digits are equal!");
            }

            else
            {
                Console.WriteLine("False - The sums of both integers' digits are not equal");
            }

            Console.ReadLine();
        }

        public static int SumDigits()

        {
            int input1, sum = 0, r;
            Console.WriteLine("Enter an integer : ");
            input1 = int.Parse(Console.ReadLine());
            while (input1 != 0)
            {
                r = input1 % 10;
                input1 = input1 / 10;
                sum = sum + r;
            }
            return sum;

        }

        public static int SumDigits2()
        {
            int input2, sum2 = 0, q;
            Console.WriteLine("Enter another integer with the same number of digits : ");
            input2 = int.Parse(Console.ReadLine());
            while (input2 != 0)
            {
                q = input2 % 10;
                input2 = input2 / 10;
                sum2 = sum2 + q;
            }
            return sum2;

        }
    }
}


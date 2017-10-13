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

            //checks that the sum of the integers' digit values are equal
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
            //requests, recieves, and parses the users first integer input
        {
            int input1, sum = 0, r;
            Console.WriteLine("Enter an integer : ");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number you entered is {0}.", input1);

            while (input1 != 0)
            {
                r = input1 % 10;
                input1 = input1 / 10;
                sum = sum + r;
            }
            return sum;//returns a sum value to the main method to be checked by the if/else statement

        }

        public static int SumDigits2()
        //requests, recieves, and parses the users second integer input
        {
            int input2, sum2 = 0, q;
            Console.WriteLine("Enter another integer with the same number of digits : ");
            input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number you entered is {0}.", input2);

            while (input2 != 0)
            {
                q = input2 % 10;
                input2 = input2 / 10;
                sum2 = sum2 + q;
            }

            
            return sum2;//returns a sum value to the main method to be checked by the if/else statement

        }
    }
}


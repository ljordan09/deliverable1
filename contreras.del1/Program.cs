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
            SumDigits();
            Console.ReadLine();
        }

        public static void SumDigits()
        {
            //Here is what i have after many hours spent last weekend trying to complete this deliverable. I feel like I'm close but it still isn't doing what I want it to do. I would be grateful for some guidance on this. I welcome your feedback positivity as I am beginning to become frustrated with my inability to get this working properly. What am I missing here? What concept should I gain a better understanding of? I have so many questions and I would be most grateful for positive feedback. I will continue to put in as many hours as necessary to get this deliverable complete ASAP.  
            


            //User inputs first integer
            //bool repeat = true;
            Console.WriteLine("Please enter an integer: ");
            string input1 = Console.ReadLine();
            int count1 = 0;
            for (int i = 0; i < input1.Length; i++)//validation: calculates the number of digits of the integer 
            {
                count1++;
            }

            if (!int.TryParse(input1, out int result1))//validation: determines that the user inputs an integer 
            {
                while (result1 < 1)
                {
                    Console.WriteLine(input1 + " Invalid Entry: Please enter a valid integer");//displays an error message
                    int.TryParse(Console.ReadLine(), out result1);
                    
                }
            }


            string input2 = Console.ReadLine();
            int count2 = 0;
            for (int i = 0; i < input2.Length; i++)
            {
                count2++;
            }
          
                if (count1 != count2)//determines that the lengths of the two integers are equal
                {
                    Console.WriteLine("Invalid Entry: The two integers entered do not have the same number of digits.");//error message
                    
                }
            
                if (!int.TryParse(input2, out int result2))//validation: determines that the user inputs an integer 
                {
                    while (result2 < 1)
                    {
                        Console.WriteLine(input1 + " is not a valid entry. Please enter a valid integer");
                        int.TryParse(Console.ReadLine(), out result2);
                    }
                }
                    
            else
            {
                //This code runs if all user inputs are validated
                //digit sum component
                List<int> ListOfInput1 = new List<int>();
                List<int> ListOfInput2 = new List<int>();
                {
                    List<int> Input1Display = new List<int>();//isolates the first integer's digits into a list
                    foreach (char c in input1)
                    {
                        Input1Display.Add(Int32.Parse(c.ToString()));
                        Console.Write($"{c},");
                    }

                    List<int> Input2Display = new List<int>();//isolates the second integer's digits into a list
                    foreach (char c in input2)
                    {
                        Input2Display.Add(Int32.Parse(c.ToString()));
                        Console.Write($"{c},");
                    }

                    List<int> finalSum = new List<int>();// I think this loop increments the placeholders of both integers and adds their values. 

                    for (int i = 0; i < ListOfInput1.Count; i++)
                    {
                        finalSum.Add(ListOfInput1[i] + ListOfInput2[i]);
                    }
                }
            }
        }
    }
}
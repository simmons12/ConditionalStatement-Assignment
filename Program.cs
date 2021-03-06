﻿using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What total score (out of 100) do you expect to get in ISM 4300?");
            Console.WriteLine("**(Please round to the nearest whole number)**");

            string UserInput;
            int Grade;
                       
            UserInput = Console.ReadLine();
            Console.WriteLine(" You entered: " + UserInput);

            if (!Int32.TryParse(UserInput, out Grade))
            {
                Console.WriteLine("Invalid data input");
            }
            else if ((Grade < 0) || (Grade > 100))
            {
                Console.WriteLine(" Error message: Out of range: Enter a number between 0 and 100");
            }
            else if (Grade <= 100 && Grade >= 98)
            {
                Console.WriteLine("A+");
            }
            else if (Grade <= 97 && Grade >= 92)
            {
                Console.WriteLine("A");
            }
            else if (Grade <= 91 && Grade >= 90)
            {
                Console.WriteLine("A-");
            }
            else if (Grade <= 89 && Grade >= 88)
            {
                Console.WriteLine("B+");
            }
            else if (Grade <= 87 && Grade >= 82)
            {
                Console.WriteLine("B");
            }
            else if (Grade <= 81 && Grade >= 80)
            {
                Console.WriteLine("B-");
            }
            else if (Grade <= 79 && Grade >= 78)
            {
                Console.WriteLine("C+");
            }
            else if (Grade <= 77 && Grade >= 72)
            {
                Console.WriteLine("C");
            }
            else if (Grade <= 71 && Grade >= 70)
            {
                Console.WriteLine("C-");
            }
            else if (Grade <= 69 && Grade >= 68)
            {
                Console.WriteLine("D+");
            }
            else if (Grade <= 67 && Grade >= 62)
            {
                Console.WriteLine("D");
            }
            else if (Grade <= 61 && Grade >= 60)
            {
                Console.WriteLine("D-");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}

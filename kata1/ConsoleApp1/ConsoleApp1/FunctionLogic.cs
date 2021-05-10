using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FunctionLogic
    {
       

        public static Tuple<int, int> NbrOfLaps()
        {
            Console.WriteLine("Enter the value of first lap:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of second lap:");
            int y = Convert.ToInt32(Console.ReadLine());
            int num1 = x, num2 = y;
            int lcm;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            lcm = (x * y) / num1;
            int NoOfRoundForA, NoOfRoundForB;

            NoOfRoundForA = lcm / x;
            NoOfRoundForB = lcm / y;
            return new Tuple<int, int>(NoOfRoundForA, NoOfRoundForB);
        }
    }
}

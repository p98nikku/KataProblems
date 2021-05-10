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
            int LengthofFirstLap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of second lap:");
            int LengthofSecondLap = Convert.ToInt32(Console.ReadLine());
            int num1 = LengthofFirstLap;
            int num2 = LengthofSecondLap;
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
            lcm = (LengthofFirstLap * LengthofSecondLap) / num1;
            int RoundCompletedbyA = 0;
            int RoundCompletedbyB = 0;
            RoundCompletedbyA = lcm / LengthofFirstLap;
            RoundCompletedbyB = lcm / LengthofSecondLap;
            return new Tuple<int, int>(RoundCompletedbyA, RoundCompletedbyB);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProductandLcm
{
    public class FunctionLogic
    {
        public static void EntryLogic()
        {
            Console.Write("Enter Number to Define Rows & Column:- ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[arrayLength, 2];
            for (int i = 0; i < arrayLength; i++)  
            {  
                for (int j = 0; j < arrayLength; j++)  
                {  
                    Console.Write("Array Index [{0}][{1}]:- ",i,j);  
                    array[i, j] = Convert.ToInt32(Console.ReadLine());  
                }  
            }
            var result=SumDifferencesBetweenProductsAndLCMs(array,arrayLength);
            Console.WriteLine($"Result is :{result}");

        }
        public static int SumDifferencesBetweenProductsAndLCMs(int[,] array,int lengthofarray)
        {
            int[] arr1 = new int[lengthofarray];
            int[] arr2 = new int[lengthofarray];
            for (int i = 0; i < lengthofarray; i++)
            {
                int x = array[i, 0];
                int y = array[i, 1];
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
                arr1[i] = x * y;
                arr2[i] = lcm;
                
            }
            int output = 0;
            for(int i=0;i<lengthofarray;i++)
            {
                output += arr1[i] - arr2[i];
            }
            return output;
        }
    }
}

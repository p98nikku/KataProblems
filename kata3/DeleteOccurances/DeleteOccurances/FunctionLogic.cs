using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeleteOccurances
{
    public class FunctionLogic
    {
        public static void EntryLogic()
        {
            int[] array = DeleteNth(new int[] { 20, 37, 20, 21 }, 1);
            Console.WriteLine("Enter the length of array:");
            int length=Convert.ToInt32(Console.ReadLine());
            DeleteNth(array, length);
            Console.WriteLine("Output: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }
        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> result = new List<int>();
            foreach (int number in arr)
            {
                if (result.Where(c => c == number).Count() < x)
                {
                    result.Add(number);
                }
            }
            return result.ToArray();
        }
    }
    }


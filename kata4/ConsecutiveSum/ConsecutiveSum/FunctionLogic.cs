using System;
using System.Collections.Generic;
using System.Text;

namespace ConsecutiveSum
{
    public class FunctionLogic
    {
       public static void EntryLogic()
        {
            List<int> userList = new List<int>();
            Console.WriteLine("How many values you want to enter:");
            int ListCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values:");

            for (int i=0;i<ListCount;i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                userList.Add(input);
            }
            List<int> UpdatedList = ConsecutiveSum(userList);
            Console.WriteLine("Output is:");
            foreach (var user in UpdatedList)
            {
                Console.WriteLine(user);
            }

        }
        public static List<int> ConsecutiveSum(List<int> Unmodifiedlist)
        {
            List<int> ModifiedList = new List<int>();
            int[] Array = Unmodifiedlist.ToArray();
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                int UpdatedValue = Array[i];

                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] == Array[i])
                    {
                        UpdatedValue += Array[j];
                        count = count + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                ModifiedList.Add(UpdatedValue);
                i = i + count;
            }
            return ModifiedList;
        }
        	
     }
}


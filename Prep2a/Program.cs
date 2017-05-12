using System;
using System.Collections.Generic;

namespace Prep2a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();


            while (nums.Count < 10)
            {

                Random newNum = new Random();
                int newNums = newNum.Next(1, 100);

                if (!nums.Contains(newNums))
                {
                    nums.Add(newNums);
                }

                
            }

            nums.ForEach(i => Console.Write("{0}, ", i));
            Console.WriteLine("");

            Console.WriteLine(FindSum(nums));
            Console.ReadLine();
        }

        static int FindSum(List<int> nums)
        {
            int totalNum = 0;
            for (int i = 0; i < nums.Count; i++)
            { 
                totalNum += nums[i];
            }
            return totalNum;
        }
    }
}
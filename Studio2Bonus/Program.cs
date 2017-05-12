using System;
using System.Collections.Generic;

namespace Studio2Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() {3, 4, 5, 1};
            List<int> numList2 = new List<int>() {1, 6};

            List<int> newList = AddLists(numList, numList2);

            foreach (int num in newList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }

        static List<int> AddLists(List<int> numList, List<int> numList2)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < numList.Count || numList2.Count > i; i++)
            {
                if (numList2.Count <= i)
                {
                    newList.Add(numList[i]);
                } else if (numList.Count <= i)
                {
                    newList.Add(numList[i]);
                } else
                {
                    newList.Add(numList[i] + numList2[i]);
                }
            }

            return newList;
        }
    }
}
using System;
using System.Collections.Generic;
namespace Studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < sent.Length; i++)
            {
                if (!counts.ContainsKey(sent[i]))
                {
                    counts.Add(sent[i], 1);
                } else
                {
                    counts[sent[i]]++;
                }
            }

            foreach (KeyValuePair<char, int> count in counts)
            {
                Console.WriteLine(count.Key + ": " + count.Value);
            }
            Console.ReadLine();
        }
    }
}
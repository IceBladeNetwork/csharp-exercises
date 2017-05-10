using System;
using System.Collections.Generic;

namespace Prep2b
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "Hello",
                                                      "Cake",
                                                      "Orange",
                                                      "wish",
                                                      "asdfk",
                                                      "sharp",
                                                      "clock" };
            FiveLetterWord(words);
            Console.ReadLine();
        }

        static void FiveLetterWord(List<string> words)
        {
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
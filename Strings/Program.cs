using System;

namespace Strings {
    class Program {
        static void Main(string[] args) {
            string sent = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'".ToLower();
            string word;

            Console.WriteLine("Give me a word to search for.");
            word = Console.ReadLine();

            Console.WriteLine(sent.IndexOf(word.ToLower()) >= 0);
            Console.ReadLine();
        }
    }
}
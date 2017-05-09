using System;

namespace NumericTypes1
{
    class Program
    {
        static void Main(string[] args)
        {
            string length;
            string width;

            Console.WriteLine("What is the length of the rectangle?");
            length = Console.ReadLine();

            Console.WriteLine("What is the width of the rectangle?");
            width = Console.ReadLine();

            int area = Int32.Parse(length) * Int32.Parse(width);

            Console.WriteLine("The area of your rectangle is: " + area.ToString());
            width = Console.ReadLine();
        }
    }
}
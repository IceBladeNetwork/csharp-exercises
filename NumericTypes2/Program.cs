using System;

namespace NumericTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;
            int gallons;

            Console.WriteLine("How many miles have you driven?");
            miles = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons have you consumed?");
            gallons = Int32.Parse(Console.ReadLine());

            int milesPerGallon = miles / gallons;

            Console.WriteLine("Your MPG is: {0}", milesPerGallon);
            Console.ReadLine();
        }
    }
}
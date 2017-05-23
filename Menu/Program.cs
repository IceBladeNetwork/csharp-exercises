using System;
using System.Collections.Generic;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class MenuItem 
    {
        float price { get; set; }
        string desc { get; set; };
        static string catagory { get; set; }
        public DateTime dateAdded;
        bool isNew;
    }

    class Menu
    {
        public DateTime lastUpdated;
        public 
    }
}
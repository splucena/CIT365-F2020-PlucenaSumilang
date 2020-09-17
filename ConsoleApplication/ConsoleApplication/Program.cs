using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your country: ");
            country = Console.ReadLine();
            Console.WriteLine("Hello my name is " + name + ", I am from the " + country);
        }
    }
}

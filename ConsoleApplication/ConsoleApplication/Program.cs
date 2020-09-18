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

            // String interpolation
            Console.WriteLine($"My name is {name}, I am from {country}\n");

            string date;
            date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            // String concatenation using '+' sign
            Console.WriteLine("The current date is " + date.ToString() + " \n");

            DateTime dateChristmas, currentDate;
            currentDate = DateTime.Now;
            dateChristmas = Convert.ToDateTime("12/25/2020");

            // Composite formatting
            Console.WriteLine("{0} Days before Christmas!\n", (dateChristmas - currentDate).Days);

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            // String.Concat()
            Console.WriteLine(String.Concat("The length of the wood ", woodLength, " is feet"));
            Console.WriteLine(String.Concat("The area of the glass is ", glassArea, " square meters"));

            Console.ReadKey();
        }
    }
}

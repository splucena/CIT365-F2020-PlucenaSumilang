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

            Console.WriteLine("My name is {0}, I am from {1}\n",name, country);

            string date;
            date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            Console.WriteLine("The current date is {0}\n", date);

            DateTime dateChristmas, currentDate;
            currentDate = DateTime.Now;
            dateChristmas = Convert.ToDateTime("12/25/2020");

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

            Console.WriteLine("The length of the wood is {0} feet", woodLength);
            Console.WriteLine("The area of the glass is {0} square meters\n", glassArea);

            Console.ReadKey();
        }
    }
}

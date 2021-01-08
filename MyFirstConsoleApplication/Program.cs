using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Today);
            GlazerApp.RunExample();
        }

        private static void GetUserNameAndLocation()
        {
            Person person = new Person();
            Console.Write("What is your name? ");
            person.name = Console.ReadLine();
            Console.Write($"Hi {person.name} Where are you from? ");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice.\n");
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();     
        }

        private static void ChristmasCountdown(DateTime currentDate)
        {
            DateTime date = currentDate;
            Console.WriteLine($"Today's date is: {date.ToShortDateString()}");
            DateTime christmas = DateTime.Parse("12/25");
            Console.WriteLine($"\nThere are {christmas.Subtract(date).Days}  days until Christmas!\n");
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}

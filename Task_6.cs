using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

            Console.Write("Введiть кiлькiсть хвилин: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int hours = N / 60; 
            int minutes = N % 60; 

            hours %= 24;

            Console.WriteLine($"Електронний годинник показує: {hours:D2}:{minutes:D2}");

            Console.ReadLine();
        }
    }
}

using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть хвилин: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int hours = minutes / 60;
            int remainingMinutes = minutes % 60;

            Console.WriteLine($"Результат: {hours}:{remainingMinutes:D2}");

            Console.ReadLine();
        }
    }
}

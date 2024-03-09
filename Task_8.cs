using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

            Console.Write("Введiть суму грошей: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int fiftyNotes = 0, twentyNotes = 0, tenNotes = 0, fiveNotes = 0, oneNotes = 0;

            while (amount > 0)
            {
                if (amount >= 50)
                {
                    fiftyNotes++;
                    amount -= 50;
                }
                else if (amount >= 20)
                {
                    twentyNotes++;
                    amount -= 20;
                }
                else if (amount >= 10)
                {
                    tenNotes++;
                    amount -= 10;
                }
                else if (amount >= 5)
                {
                    fiveNotes++;
                    amount -= 5;
                }
                else
                {
                    oneNotes++;
                    amount -= 1;
                }
            }

            Console.WriteLine("\nКiлькiсть купюр кожного номiналу, яку потрiбно видати:");
            Console.WriteLine($"50 грн: {fiftyNotes}");
            Console.WriteLine($"20 грн: {twentyNotes}");
            Console.WriteLine($"10 грн: {tenNotes}");
            Console.WriteLine($"5 грн: {fiveNotes}");
            Console.WriteLine($"1 грн: {oneNotes}");

            Console.ReadLine();
        }
    }
}

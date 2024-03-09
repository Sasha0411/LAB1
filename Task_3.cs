using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

            Console.Write("Введiть цiну булочки у гривнях: ");
            double X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть цiну булочки у копiйках: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть кiлькiсть булочок: ");
            int N = Convert.ToInt32(Console.ReadLine());

            double totalCostInHrn = X * N;
            int totalCostInMonet = Y * N;

            if (totalCostInMonet >= 100)
            {
                totalCostInHrn += totalCostInMonet / 100;
                totalCostInMonet %= 100;
            }

            Console.WriteLine($"\nЗа {N} булочок необхiдно заплатити {totalCostInHrn} гривень {totalCostInMonet} копiйок.");

            Console.ReadLine();
        }
    }
}

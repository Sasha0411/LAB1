using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

            Console.Write("Введiть значення для змiнної a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть значення для змiнної b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nЗначення змiнної a до обмiну: {a}");
            Console.WriteLine($"Значення змiнної b до обмiну: {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"\nЗначення змiнної a пiсля обмiну: {a}");
            Console.WriteLine($"Значення змiнної b пiсля обмiну: {b}");

            Console.ReadLine();
        }
    }
}

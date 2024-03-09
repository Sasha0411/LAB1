using System;

namespace LAB1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Горкун Олександр");

            Console.Write("Введіть значення змінної 'a': ");
            double a = Convert.ToDouble(Console.ReadLine());

            double x = 12.5 * a;
            double y = (8.5 * x + 9 + 3 * a) / (a + 1);

            Console.WriteLine("\nРезультати обчислень:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"√y = {Math.Sqrt(y)}");
            Console.WriteLine($"x^a = {Math.Pow(x, a)}");

            Console.ReadLine();
        }
    }
}

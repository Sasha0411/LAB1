using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

            Console.Write("Введiть чотиризначне число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int thousands = number / 1000;
            int hundreds = (number % 1000) / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            int sum = thousands + hundreds + tens + units;

            Console.WriteLine($"\nСума цифр числа: {sum}");
            Console.WriteLine($"Кiлькiсть тисяч: {thousands}");
            Console.WriteLine($"Кiлькiсть сотень: {hundreds}");
            Console.WriteLine($"Кiлькiсть десяткiв: {tens}");
            Console.WriteLine($"Кiлькiсть одиниць: {units}");

            Console.ReadLine();
        }
    }
}

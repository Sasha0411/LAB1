using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

            int C1, C2; 

            
            Console.Write("Введiть кiлькiсть комп'ютерiв у класi No1: ");
            C1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть кiлькiсть комп'ютерiв у класi No2: ");
            C2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"Кiлькiсть комп'ютерiв у класi No1 у вереснi: {C1}");
            Console.WriteLine($"Кiлькiсть комп'ютерiв у класi No2 у вереснi: {C2}");

            
            int temp = C1;
            C1 = C2;
            C2 = temp;

            
            Console.WriteLine($"\nКiлькiсть комп'ютерiв у класi No1 у жовтнi: {C1}");
            Console.WriteLine($"Кiлькiсть комп'ютерiв у класi No2 у жовтнi: {C2}");

            
            C1 += 3;
            C2 -= 2;

            
            Console.WriteLine($"\nКiлькiсть комп'ютерiв у класi No1 у груднi: {C1}");
            Console.WriteLine($"Кiлькiсть комп'ютерiв у класi No2 у груднi: {C2}");

            Console.ReadLine();
        }
    }
}

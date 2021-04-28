using System;

namespace Rekursiya_HW5
{
    class Program
    {
        enum DayWeek
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите номер дня недели.");
            int n = 0;
            while (n==0)
            {
             int.TryParse(Console.ReadLine(), out n);
                if (n<1||n>7)
                {
                    Console.WriteLine("Некорректная информация, укажите правильно.");
                    n = 0;
                }
            }
            DayWeek day = (DayWeek)n;
            Console.WriteLine($"It is {day}");
            Console.ReadKey();
        }
    }
}

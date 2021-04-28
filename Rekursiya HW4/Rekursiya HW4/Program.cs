using System;

namespace Rekursiya_HW4
{
    class Program
    {
        static int Diap(int x,int y)
        {
            if (x==y)
            {
                return x;
            }
            else if (y > x)
            {
                int temp = x;
                x = y;
                y = temp;
                return x + Diap(--x, y);
            }
            else
            {
                return x + Diap(--x, y);
            }
        }
        static void Main(string[] args) 
        {
            Console.WriteLine("Укажите часть диапазона");
            int start = 0;
            bool temp = false;
            while (temp == false)
            {
                temp = int.TryParse(Console.ReadLine(), out start);
                if (temp==false)
                {
                    Console.WriteLine("Некорректная информация, укажите правильно.");
                }
            }
            Console.WriteLine("Укажите другую часть диапазона");
            int end = 0;
            temp = false;
            while (temp == false)
            {
                temp = int.TryParse(Console.ReadLine(), out end);
                if (temp == false)
                {
                    Console.WriteLine("Некорректная информация, укажите правильно.");
                }
            }
            int sumDiap = Diap(start, end);
            Console.WriteLine($"Cумма чисел из диапазона между {start} и {end} равно:{sumDiap}");
            Console.ReadKey();
        }
    }
}

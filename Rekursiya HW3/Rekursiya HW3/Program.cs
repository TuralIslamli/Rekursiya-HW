using System;

namespace Rekursiya_HW3
{
    class Program
    {
        static int Pow(int num,int pow)
        {
            if (pow ==0)
            {
                return 1;
            }
            else
            {
                return num * Pow(num, --pow);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите число");
            int num = 0;
            bool temp= false;
            while (temp==false)
            {
                temp = int.TryParse(Console.ReadLine(), out num);
                if (temp==false)
                {
                    Console.WriteLine("Не правильно, надо указать целое число");
                    
                }
                else
                {
                    temp = true;
                }
               
            }
            Console.WriteLine("Укажите степень");
            int pow = 0;
            temp =false;
            while (temp == false|| pow<0)
            {
                temp = int.TryParse(Console.ReadLine(), out pow);
                if (temp == false||pow<0)
                {
                    Console.WriteLine("Не правильно, укажите степень правильно");
                }
                else
                {
                    temp = true;
                }
                
            }
            int powResult = Pow(num, pow);
            Console.WriteLine($"Число {num} в степени {pow} равно:{powResult}");
            Console.ReadKey();

        }
    }
}

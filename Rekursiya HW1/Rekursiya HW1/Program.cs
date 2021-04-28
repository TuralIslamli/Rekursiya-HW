using System;

namespace Rekursiya_HW1
{
    class Program
    {
        static int PowSum(int num,int pow)
        {
            if (pow==2)
            {
                return num = num * num;
            }
            else
            {
                return num * num + (num * PowSum(num, --pow));
            }
        }
        static void Main(string[] args)
        {

            int result = PowSum(2, 10);
            Console.WriteLine($"Сумма степеней числа 2, от 2 степени до 10 степени, равно:{result}");
            Console.ReadKey();
        }
    }
}

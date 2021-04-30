using System;

namespace Rekursiya_HW6
{
    class Program
    {

        static int Num(int n)
        {
            Console.WriteLine($"Введите цифру №{n}");
            bool a = false;
            int num = 0;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num >= 0&&num<=9)
                    {
                        a = true;
                    }
                    else
                    {
                        Console.WriteLine("Не правильный ввод;\nВведите заного");
                    }
                }
                catch { Console.WriteLine("Не правильный ввод;\nВведите заного"); }
            }
            while (a == false);
            return num;
        }

        static int[] Random ()
        {
            
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            bool temp = false;
            while (temp==false)
            {
                Random rnd = new Random();
                
                a = rnd.Next(0,9);
                b = rnd.Next(0, 9);
                c = rnd.Next(0, 9);
                d = rnd.Next(0, 9);
                if (a == b || a == c || a == d || b == c || b == d || c == d)
                {
                    temp = false;
                }
                else
                {
                    temp = true;
                }
            }
            int[] r = new int[4] { a, b, c, d };
            return r;
        }

        static void BullsAndCows(int[] randomNums, int test)
        {
            int bulls = 0;
            int cows = 0;
            Console.WriteLine("Сможешь угадать 4 цифр?");
            int num1 = Num(1);
            int num2 = Num(2);
            int num3 = Num(3);
            int num4 = Num(4);
            int[] userValue = new int[4] { num1, num2, num3, num4 };
            for (int i = 0; i < randomNums.Length; i++)
            {
                for (int j = 0; j < userValue.Length; j++)
                {

                    if (userValue[i] == randomNums[i])
                    {
                        cows++;
                        break;
                    }
                    else if (userValue[j] == randomNums[i])
                    {
                        bulls++;
                        break;
                    }
                }

            }
            if (cows == 4)
            {
                Console.WriteLine($"Вы отгадали все цифры. Попытки которые вам понадобились:{test}");
            }
            else
            {
                Console.WriteLine($"korovi={cows},biki={bulls}. Попытка №{test}.");
                BullsAndCows(randomNums, ++test);

            }
        }
        static void Main(string[] args)
        {
           int[] rnd=Random();
           BullsAndCows(rnd, 1);
           Console.ReadKey();
           


        }


    }
}


using System;

namespace Rekursiya_HW2
{
    class Program
    {
        static int Nod(int num1,int num2)
        {
            if (num1<0)
            {
               return Nod(num1 * -1,num2);
            }
            if (num2<0)
            {
               return Nod(num1, num2*-1);
            }
            if (num1==num2)
            {
                return num1;
            }
            else if (num2>num1)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            return Nod(num1 - num2, num2);
        }  
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите первое число");
            int firstNum=0;
            while (firstNum == 0)
            {
               int.TryParse(Console.ReadLine(), out firstNum);
                if (firstNum==0)
                {
                    Console.WriteLine("Укажите корректное, целое число");
                    
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine("Укажите второе число");
            int secondNum = 0;
            while (secondNum == 0)
            {
                int.TryParse(Console.ReadLine(), out secondNum);
                if (secondNum == 0)
                {
                    Console.WriteLine("Укажите корректное, целое число");

                }
                else
                {
                    break;
                }

            }
            

            int result = Nod(firstNum, secondNum);
            Console.WriteLine($"НОД чисел {firstNum} и {secondNum} равна:{result}");
            Console.ReadKey();
        }
    }
}

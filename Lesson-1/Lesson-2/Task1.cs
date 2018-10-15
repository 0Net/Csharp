using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задоров Вадим
// 1. Написать метод, возвращающий минимальное из трех чисел.

namespace Menu
{
    partial class Program
    {
        static int MinNumber(int a,int b,int c)
        {
            int min;
            if (a > b)
            {
                min = b;
            }
            else if (a > c)
            {
                min = c;
            }
            else
            {
                min = a;
            }
            return min;
        }
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Введите 1-е число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3-е число");
            int c = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Минимальное число: " + MinNumber(a,b,c));
        }
    }
            
}
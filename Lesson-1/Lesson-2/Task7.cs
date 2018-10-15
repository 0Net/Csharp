using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
//    б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.


namespace Menu
{
    partial class Program
    {
        static void Loop(int a, int b)
        {
            if (a <= b)
            { 
                Console.Write(a + " ");
                Loop(++a, b);

            }

        }

        static void Task7()
        {
            Console.Clear();
            Console.WriteLine("Введите 1-е число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число");
            int b = Convert.ToInt32(Console.ReadLine());
            Loop(a, b);
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Задоров Вадим Вадимович
// 2. Написать метод подсчета количества цифр числа.
namespace Menu
{
    partial class Program
    {
        static int Count(Int64 N)
        {
            int number = 0;
            while (N != 0)
            {
                number++;
                N /= 10;
            }
            return number;
        }
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Введите число");
            Int64 a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(Count(a));

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. 
// Реализовать подсчет времени выполнения программы, используя структуру DateTime.


namespace Menu
{
    partial class Program
    {
        static bool GoodNumber (int number)
        {
            return number % Count(number) == 0;
        }

        static void Task6()
        {
            // Count определён в задаче №2
            Console.Clear();
            DateTime begin = DateTime.Now;
            int gnCount = 0;
            for(int i = 1; i <= 1000000000; i++)
            {
                if (GoodNumber(i))
                {
                    gnCount++;
                }
            }
            Console.WriteLine($"Количество хороших чисел: {gnCount}");
            Console.WriteLine();
            Console.Write("Время выполнения задачи: ");
            Console.WriteLine(DateTime.Now - begin);
        }
    }
}

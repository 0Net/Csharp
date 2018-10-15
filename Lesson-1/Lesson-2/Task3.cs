using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Menu
{
    partial class Program
    {
        static void Task3()
        {
            Console.Clear();
            double N = 1;
            double summ = 0;
            do
            {
                Console.WriteLine("Введите число");
                N = Convert.ToDouble(Console.ReadLine());
                if (N > 0 && N % 2 != 0)
                {
                    summ += N;
                }

            }
            while (N != 0);

            Console.WriteLine("Сумма всех нечётных положительных чисел равна " + summ);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задоров Вадим. Домашнее задание №4.
1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
*/

namespace Menu
{
    partial class Program
    {
        static void Task1()
        {
            Console.Clear();

            int[] array = new int[20];
            int count = 0;
            Random rnd = new Random();
            for(int i=0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10001);
                Console.WriteLine(array[i]);
            }

            for(int i=0; i < array.Length; i+=2)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {count}");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
5. а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, 
свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
  * б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
  ** в) Обработать возможные исключительные ситуации при работе с файлами. 
*/
namespace Menu
{
    class DoubleArray
    {
        int[,] a;
        int rows, lines;

        Random rnd = new Random();

        public DoubleArray(int n, int m)
        {
            a = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) { 
                a[i,j] = rnd.Next();
                }
            }
            lines = n;
            rows = m;
        }

        public double Summ()
        {
            double summ = 0;
            for(int i = 0; i < lines; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    summ += a[i, j];
                }
            }
            return summ;
        }

        public int Min
        {
            get
            {
                int min = a[0,0];
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        if (a[i, j] < min) 
                        {
                            min = a[i, j];
                        }
                    }
                }
                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        if (a[i, j] >= max)
                        {
                            max = a[i, j];
                        }
                    }
                }
                return max;
            }
        }

        public string MaxIndex()
        {
            string index = "";
            int max = a[0, 0];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (a[i, j] >= max)
                    {
                        max = a[i, j];
                        index = i + " " + j;
                    }
                }
            }
            return index;
        }

    }

    partial class Program
    {
        static void Task5()
        {
            Console.Clear();
            DoubleArray array = new DoubleArray(3, 5);
            Console.WriteLine(array.Summ());
            Console.WriteLine(array.Min);
            Console.WriteLine(array.Max);
            Console.WriteLine(array.MaxIndex());

        }
    }
}
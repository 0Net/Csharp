using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Задоров Вадим. Домашнее задание №4.
3. 
а) Дописать класс для работы с одномерным массивом. 
Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива 
(старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число, 
свойство MaxCount, возвращающее количество максимальных элементов. 
б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
*/

namespace Menu
{

    class CoolArray
    {
        private int[] a;
        Random rnd = new Random();

        public CoolArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 101);
            }
        }

        public CoolArray(string filename)
        {
            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    a[i] = int.Parse(ss[i]);
                }
            }
            else Console.WriteLine("Error load file");
        }

        public CoolArray(int n, int fe, int step) // fe - first element
        {
            a = new int[n];
            a[0] = fe;
            for (int i = 1; i < n; i++)
            {
                a[i] = a[i-1] + step;
            }
        }

        public int Max
        {
            get
            {
                return a.Max();
            }
        }

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public int Summ()
        {
            int summ = 0;
            for (int i = 0; i < a.Length; i++)
            {
                summ += a[i];
            }
            return summ;
        }

        public int[] Inverse()
        {
            int[] newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArray[i] = -a[i];
            }
            return newArray;
        }

        public int[] Multi(int[] a, int multiplier)
        {
            int[] newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArray[i] = multiplier * a[i];
            }

            return newArray;
        }

        public void Print()
        {
            foreach (int el in a)
            {
                Console.WriteLine("{0,4}", el);
            }
        }
    }

    partial class Program
    {
        static void Task3()
        {
            Console.Clear();
            CoolArray array = new CoolArray(20, 15, 7);
            array.Print();
            Console.WriteLine();
            Console.WriteLine("Сумма всех элементов массива: " + array.Summ());
            Console.WriteLine("Максимальный элемент: " + array.Max);
            Console.ReadKey();
        }
    }
}

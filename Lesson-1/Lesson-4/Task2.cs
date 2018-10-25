using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Задоров Вадим. Домашнее задание №2.
2. Реализуйте задачу 1 в виде статического класса StaticClass; 
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1; 
б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел; 
в)*Добавьте обработку ситуации отсутствия файла на диске.
*/

namespace Menu
{
    static class StaticClass
    {
        static int[] array = new int[20];
        public static bool Error = false;

        public static int[] Array()
        {
            string filename = "array.txt";
            StreamWriter sw = null;
            sw = new StreamWriter(filename);
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10001);
                sw.WriteLine(array[i]);
            }
            sw.Close();
            return array;
        }

        static int[] ReadArray()
        {
            StreamReader sr = null;
            string filename = "array.txt";
            try
            {
                sr = new StreamReader(filename);
                int i = 0;
                while (!sr.EndOfStream)
                {
                    array[i] = int.Parse(sr.ReadLine());
                    i++;
                }

            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                Error = true;
            }
            catch (DirectoryNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                Error = true;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Error = true;
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            Console.WriteLine(_ToString());
            return array;
        }

        static string _ToString()
        {
            string s = " ";
            for (int i = 0; i < array.Length; i++)
                s = s + String.Format("{0,7}", array[i]);
            return s;
        }

        public static int Count()
        {
            int count = 0;
            array = ReadArray();
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
    partial class Program
    {
        static void Task2()
        {
            Console.Clear();
            StaticClass.Array(); //Создание файла с массивом
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3: {StaticClass.Count()}");
        }
    }
}

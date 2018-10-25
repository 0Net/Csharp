using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Задоров Вадим. Домашнее задание №4.
4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
*/
namespace Menu
{
    partial class Program
    {
        static bool Check(string filename)
            {
            int count = 1;
            string[] lines = File.ReadAllLines(filename);
            string[,] array = new string[lines.Length, lines[0].Split(';').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(';');
                for (int j = 0; j < temp.Length; j++)
                    array[i, j] = temp[j];
            }

            do
            {
                count++;
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();
                for(int i = 0; i < lines.Length; i++)
                { 
                    if (login == array[i,0] && password == array[i,1])
                    {
                        return true;
                    }
                }
            }
            while (count <= 3);
            return false;
    }


        static void Task4()
        {
            Console.Clear();
            //Блок создания файла с логинами и паролями. Табуляция через ";"
            string filename = "auth.txt";
            StreamWriter sw = null;
            sw = new StreamWriter(filename);
            sw.WriteLine("root;GeekBrains");
            sw.WriteLine("admin; GeekBrains");
            sw.Close();

            Console.WriteLine(Check(filename));
        }
    }
}

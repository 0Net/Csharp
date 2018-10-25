using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/* Задоров Вадим. Домашнее задание №5.
1. Создать программу, которая будет проверять корректность ввода логина. Корректным
логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
*/

namespace Lesson_5
{

    partial class Program
    {
        static bool Check (string l)
        {
            char[] loginCheck = l.ToCharArray();
            if (char.IsNumber(l[0]))
            {
                Console.WriteLine("Первый символ не может быть цифрой");
                return false;
            }
            else if (l.Length <= 2 || l.Length >= 10)
            {
                Console.WriteLine("Логин должен быть более 2-х символов, но менее 10");
                return false;
            }

            for(int i = 0; i < l.Length; i++)
            {
                if ((int)l[i] >= 48 && (int)l[i] <= 57 || (int)l[i] >= 65 && (int)l[i] <= 90 || (int)l[i] >= 97 && (int)l[i] <= 122) { }
                else
                {
                    Console.WriteLine("Логин должен содержать только латинские буквы и цифры");
                    return false;
                }
            }


            return true;

        }
       
        static void Task1()
        {
            Console.Clear();
            bool i = false;

            // Без использования регулярных выражений
            //do
            //{
            //    Console.WriteLine("Ввдите логин");
            //    string login = Console.ReadLine();
            //    i = Check(login);
            //}
            //while(i == false);
            //Console.WriteLine(i);    
            
            // С использованием регулярных выражений
            do
            {
                Console.WriteLine("Ввдите логин");
                string login = Console.ReadLine();
                Regex l = new Regex("^[a-zA-Z]{1}[A-Za-z0-9]{1,9}$");
                if (l.IsMatch(login)) i = true;
                else Console.WriteLine("Логин должен содержать только латинские буквы и цифры и начинаться с буквы");
            }
            while (i == false);
            Console.WriteLine("Correct");
        }
    }
}
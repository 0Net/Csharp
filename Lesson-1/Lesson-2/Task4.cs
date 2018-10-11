using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
*/
namespace Menu
{
    partial class Program
    {
        static bool Check()
        {
            int count = 1;
            do
            {
                count++;
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();
                Console.Clear();
                if(login == "root" && password == "GeekBrains")
                {
                    return true;
                }
            }
            while (count <= 3);
            return false;
        }

        static void Task4()
        {
            Console.Clear();
            Console.WriteLine(Check());
        }
    }
}

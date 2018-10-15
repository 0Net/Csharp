using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задоров Вадим. Домашнее задание №2

1. Написать метод, возвращающий минимальное из трех чисел.
2. Написать метод подсчета количества цифр числа.
3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
   б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
   б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
Достаточно решить 4 задачи. Разбивайте программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы делайте в одном решении.
 
     
*/

namespace Menu
{
    partial class Program
    {
        static void Menu()
        {

            Console.WriteLine("1 - Task 1");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("3 - Task 3");
            Console.WriteLine("4 - Task 4");
            Console.WriteLine("5 - Task 5");
            Console.WriteLine("6 - Task 6");
            Console.WriteLine("7 - Task 7");
            Console.WriteLine("0 - Exit");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Program.Task1();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Program.Task2();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Program.Task3();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Program.Task4();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Program.Task5();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Program.Task6();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Program.Task7();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    Console.WriteLine("Всего доброго!");
                    return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

        }

        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}

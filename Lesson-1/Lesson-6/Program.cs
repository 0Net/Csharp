using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задоров Вадим. ДЗ №6
1.Изменить программу вывода таблицы функции так,чтобы можно было передавать функции
типа double(double,double).Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
2.Модифицировать программу нахождения минимума функции так,чтобы можно было
передавать функцию в виде делегата.
а)Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов,
в котором хранятся различные функции.
б)*Переделать функцию Load, чтобы она возвращала коллекцию List<double> считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).
3.*Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
в) отсортировать список по возрасту студента;
г)*отсортировать список по курсу и возрасту студента;
4.**Считайте файл различными способами. Смотрите “Пример записи файла различными
способами”. Создайте методы, которые возвращают массив byte(FileStream,BufferedStream), строку для StreamReader и массив int для BinaryReader.
 */

namespace Lesson_6
{
    partial class Program
    {
        static void Menu()
        {

            Console.WriteLine("1 - Task 1");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("3 - Task 3");
            Console.WriteLine("4 - Task 4");
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

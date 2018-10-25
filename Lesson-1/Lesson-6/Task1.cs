using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задоров Вадим. ДЗ №6
1.Изменить программу вывода таблицы функции так,чтобы можно было передавать функции
типа double(double,double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
*/

namespace Lesson_6
{
    //Описываем делегат. В делегате описывается сигнатура(или прототип, как угодно) функций, на
    //которые сможет ссылатся делегат в дальнейшем
    public delegate double Fun(double x ,double a);

    partial class Program
    {
        //Таблица значений функции F от a до b
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double MyFuncSin(double x, double a)
        {
            return a * Math.Sin(x);
        }
        static void Task1()
        {
            Console.Clear();

            Console.WriteLine("Таблица функции a*x^2:");
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(MyFuncSin, -2, 2);
            Console.ReadLine();

        }
    }
}

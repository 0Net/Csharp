using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//    б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace Menu
{
    partial class Program
    {
        static double WeightChange(double imt, double weight, double height)
        {
            if (imt < 18.5)
            {
                return 18.5 * height * height / 10000 - weight;
            }
            else
            {
                return weight - 25 * (height * height / 10000);
            }
        }
        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Введите  Ваш рост в сантиметрах");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес в киллограммах");
            double weight = Convert.ToDouble(Console.ReadLine());
            double imt = weight / (height * height / 10000);
            Console.WriteLine("Индекс массы тела: {0:F2}", imt);
            if (imt < 18.5)
            {
                Console.WriteLine("У Вас недостаточная масса тела");
                Console.WriteLine("Вам необходимо набрать {0:F2} кг", WeightChange(imt, weight, height));
            }
            else if (imt >= 18.5 && imt < 25)
            {
                Console.WriteLine("У Вас нормальная масса тела");
            }
            else if (imt > 25)
            {
                Console.WriteLine("У Вас избыточная масса тела");
                Console.WriteLine("Вам необходимо сбросить {0:F2} кг", WeightChange(imt, weight, height));
            }
        }
    }
}


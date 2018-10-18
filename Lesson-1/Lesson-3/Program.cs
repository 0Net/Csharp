using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Задоров Вадим. Домашнее задание №3
 
 * По словам преподавателя, достаточно выполнить задание №3 для получения "отлично".
 
3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
*** Добавить упрощение дробей
*/
namespace Lesson_3
{

    class Fraction
    {
        int numerator, denominator;

        public Fraction()
        {
            numerator = denominator = 1;            
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int N
        {
            get
            {
                return numerator;
            }

            set
            {
                numerator = value;
            }
        }

        public int D
        {
            get
            {
                return denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0!");
                }
                else denominator = value;
            }
        }

        static Fraction FractionReduction(Fraction C)
        {
            int max = 0;
            if (C.N > C.D)
            {
                max = C.N;
            }
            else max = C.D;

            for(int i = max; i>=2; i--)
            {
                if(C.N %i ==0 && C.D %i == 0)
                {
                    C.N /= i;
                    C.D /= i;
                }
            }


            return C;
        }

        public static Fraction operator +(Fraction A, Fraction B)
        {
            Fraction summ = new Fraction();
            summ.N = A.N * B.D + A.D * B.N;
            summ.D = A.D * B.D;
            return FractionReduction(summ);
        }

        public static Fraction operator -(Fraction A, Fraction B)
        {
            Fraction odds = new Fraction();
            odds.N = A.N * B.D - A.D * B.N;
            odds.D = A.D * B.D;
            return FractionReduction(odds);
        }

        public static Fraction operator *(Fraction A, Fraction B)
        {
            Fraction composition = new Fraction();
            composition.N = A.N * B.N;
            composition.D = A.D * B.D;
            return FractionReduction(composition);
        }

        public static Fraction operator /(Fraction A, Fraction B)
        {
            Fraction quotient = new Fraction();
            quotient.N = A.N * B.D;
            quotient.D = A.D * B.N;
            return FractionReduction(quotient);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction A = new Fraction();
            Fraction B = new Fraction();
            Fraction C = new Fraction();
            Console.WriteLine("Введите числитель превой дроби");
            A.N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби");
            A.D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числитель второй дроби");
            B.N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби");
            B.D = Convert.ToInt32(Console.ReadLine());
            C = A + B;
            Console.WriteLine("Сумма дробей равна: " + Convert.ToString(C.N) + "/" + Convert.ToString(C.D));
            C = A - B;
            Console.WriteLine("Разница дробей равна: " + Convert.ToString(C.N) + "/" + Convert.ToString(C.D));
            C = A * B;
            Console.WriteLine("Произведение дробей равна: " + Convert.ToString(C.N) + "/" + Convert.ToString(C.D));
            C = A / B;
            Console.WriteLine("Частное дробей равна: " + Convert.ToString(C.N) + "/" + Convert.ToString(C.D));
            Console.Read();
        }
    }
}
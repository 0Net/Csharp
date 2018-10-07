using System;

/*
 * Задоров
 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.

2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

4. Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.

5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
Достаточно решить 3 задачи. Записывайте в начало программы условие и свою фамилию. Все программы создавайте в одном решении. Задания со звездочками выполняйте в том случае, если вы решили задачи без звездочек.

 */

namespace HomeworkLesson1
{
    class Program
    {
        // Метод для задачи 3
        static double distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        // Метод для задачи 6
        static void Pause(string message = "\n\nНажмите любую клавишу для продолжения")
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        // Метод для задач 5 и 6
        static void Print(string message, int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Console.Title = "Автор: Задоров Вадим";

            // 1. Анкета
            Console.WriteLine("Задание 1. Анкета");
            Console.WriteLine("Введите Ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите город проживания");
            string city = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  Ваш рост в сантиметрах");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес в киллограммах");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(surname + " " + name + ", возраст: " + age + ", рост: " + height + ", вес: " + weight);
            Console.WriteLine("{0} {1}, возраст: {2}, рост: {3}, вес: {4}", surname, name, age, height, weight);
            Console.WriteLine($"{surname} {name}, возраст: {age}, рост: {height}, вес: {weight}");

            Pause();
            Console.Clear();

            // 2. Расчёт ИМТ
            Console.WriteLine("Задание 2. Расчёт Индекса Массы Тела");
            double imt = weight / (height * height / 10000);
            Console.WriteLine("Индекс массы тела: {0:F2}", imt);
            if (imt < 16)
            {
                Console.WriteLine($"{name}, у Вас выраженный дефицит массы тела");
            }
            else if (imt >= 16 && imt < 18.5)
            {
                Console.WriteLine($"{name}, у Вас недостаточная масса тела");
            }
            else if (imt >= 18.5 && imt < 25)
            {
                Console.WriteLine($"{name}, у Вас нормальная масса тела");
            }
            else if (imt >= 25 && imt < 30)
            {
                Console.WriteLine($"{name}, у Вас избыточная масса тела (предожирение)");
            }
            else if (imt >= 30 && imt < 35)
            {
                Console.WriteLine($"{name}, у Вас ожирение 1-ой степени");
            }
            else if (imt >= 35 && imt < 40)
            {
                Console.WriteLine($"{name}, у Вас ожирение 2-ой степени");
            }
            else if (imt >= 40)
            {
                Console.WriteLine($"{name}, у Вас ожирение 3-ой степени");
            }

            Pause();
            Console.Clear();

            // 3. Расчёт расстояния между точками с координатами x1, y1 и x2, y2
            Console.WriteLine("Задание 3. Расстояние между точками");
            Console.WriteLine("Введите координаты по оси OX 1-й точки (x1)");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты по оси OY 1-й точки (y1)");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты по оси OX 2-й точки (x2)");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты по оси OY 1-й точки (y2)");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние между точек: {0:F2}", distance(x1, y1, x2, y2));

            Pause();
            Console.Clear();

            // 4. Обмен значениями между двумя переменными
            Console.WriteLine("Задание 4. Обмен значениями между переменными");
            Console.WriteLine("Введите значение переменной X");
            double intX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y");
            double intY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Значение переменной X: {intX}\nЗначение переменной Y: {intY}");
            // Решение с использованием третьей переменной
            double intZ = intX;
            intX = intY;
            intY = intZ;
            Console.WriteLine($"С помощью магии, кода и третьей переменной получаем новые значения переменных\nЗначение переменной X: {intX}\nЗначение переменной Y: {intY}");
            // Решение без использования третьей переменной
            intX = intX + intY;
            intY = intX - intY;
            intX = intX - intY;
            Console.WriteLine($"Тут происходит обратный обмен значениями уже без использования третьей переменной\nЗначение переменной X: {intX}\nЗначение переменной Y: {intY}");

            Pause();
            Console.Clear();

            // 5. Выводит на экран имени, фамилии и города проживания в центре экрана с использованием собственных методов 
            Print($"{name} {surname}, город {city}", Console.WindowWidth / 3, Console.WindowHeight / 2);
            Console.SetCursorPosition(0, 0);
            Pause();

        }
    }
}


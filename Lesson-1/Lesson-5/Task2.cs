using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Задоров Вадим. Домашнее задание №5.
2. Разработать статический класс ​Message​, содержащий следующие статические методы для
обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в
него передается массив слов и текст, в качестве результата метод возвращает сколько раз
каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 
     
*/


namespace Lesson_5
{
    static class Message
    {
        public static List<string> ShorterThanN(string l, int n)
        {
            var str = new List<string>();
            foreach (var m in l.Split(' '))
            {
                if (n > m.Length) str.Add(m);
            }
            return str;
        }

        public static List<string> RemoveWords(string l, char a)
        {
            var str = new List<string>();
            foreach (var m in l.Split(' '))
            {
                if (!m.EndsWith(a.ToString())) str.Add(m);
            }
            return str;
        }

        public static string LongestWord (string l)
        {
            var str = l.Split(' ');
            var longestWord = "";
            foreach (var word in str)
            {
                if (word.Length > longestWord.Length) longestWord = word;
            }
            return longestWord;
        }

        public static List<string> LongestWords(string l)
        {
            var longestWords = new List<string>();
            var lengthOfTheLongestWord = 0;
            var words = l.Split(' ');
            foreach (var word in words)
            {
                if (word.Length > lengthOfTheLongestWord) lengthOfTheLongestWord = word.Length;
            }
            foreach (var word in words)
            {
                if (word.Length == lengthOfTheLongestWord) longestWords.Add(word);
            }
            return longestWords;
        }
    }

    partial class Program
    {
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Введите предложение");
            string b = Console.ReadLine();
            Console.WriteLine("Вывести только те слова сообщения, которые содержат не более n букв. Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Message.ShorterThanN(b, n));
            Console.WriteLine("Удалить из сообщения все слова, которые заканчиваются на заданный символ. Введите символ");
            ConsoleKeyInfo key = Console.ReadKey();
            char a = key.KeyChar;
            Console.WriteLine(Message.RemoveWords(b, a));
            Console.WriteLine("Cамое длинное слово сообщения:");
            Console.WriteLine(Message.LongestWord(b));

        }
    }
}

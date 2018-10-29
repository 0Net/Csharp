using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Задоров Вадим ДЗ №7
 1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте
обобщенный класс Stack
*/
namespace Lesson7
{
    class Udvoitel
    {
        int finish;
        int current;
        int movecount;
        int usermoves;
        Stack<int> waypoints = new Stack<int>();

        public Udvoitel(int min,int max)
        {
            Random rnd = new Random();
            this.finish = rnd.Next(min,max+1);
            current = 1;
            usermoves = 0;
            waypoints.Push(current);

        }
        
        public void Plus()
        {
            current++;
            waypoints.Push(current);
            usermoves++;
        }

        public void Multi()
        {
            current *= 2;
            waypoints.Push(current);
            usermoves++;
        }

        public void Reset()
        {
            waypoints.Clear();
            current = 1;
            waypoints.Push(current);
            usermoves = 0; ;
        }

        public void Back()
        {
            if(waypoints.Count > 1)
            { 
                waypoints.Pop();
                current = waypoints.Peek();
                usermoves--;
            }
        }

        public int Current
        {
            get { return current; }
        }

        public int Finish
        {
            get { return finish; }
        }
        
        public void moveCounts()
        {
            int c = Finish;
            movecount = 0;
            do
            {
                if (c % 2 == 0)
                {
                    c /= 2;
                    movecount++;
                }
                else
                {
                    c -= 1;
                    movecount++;
                }
            }
            while (c != 1);
        }

        public int MoveCount
        {
            get { return movecount; }
        }

        public int UserMoves
        {
            get { return usermoves; }
        }

        //1=>25 +1 x2
    }
}

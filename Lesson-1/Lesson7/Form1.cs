using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lesson7;
/* Задоров Вадим ДЗ №7
 1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте
обобщенный класс Stack
*/
namespace Lesson7
{
    public partial class fMain : Form
    {
        Udvoitel udvoitel;

        public fMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel(10, 100);
            UpdateInfo();
            udvoitel.moveCounts();
            MessageBox.Show("Вас приветствует игра \"Удвоитель\"!\nВы должны минимальными действиями получить число " + udvoitel.Finish + "\nИдеальный вариант: " + udvoitel.MoveCount + " ходов");
        }

        private void UpdateInfo()
        {
            lblFinish.Text = udvoitel.Finish.ToString();
            tbCurrent.Text = udvoitel.Current.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            udvoitel.Plus();
            UpdateInfo();
            CheckEnd();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (udvoitel == null)
            {
                MessageBox.Show("Start game!");
                return;
            }
            udvoitel.Multi();
            UpdateInfo();
            CheckEnd();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbCurrent.Text = "1";
            udvoitel.Reset();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            udvoitel.Back();
            tbCurrent.Text = udvoitel.Current.ToString();
        }

        public void CheckEnd()
        {
            if (udvoitel.Current == udvoitel.Finish)
            {
                MessageBox.Show("Ура! Получилось! Вам это удалось сделать за " + udvoitel.UserMoves + " ходов");
            }
        }
    }
}

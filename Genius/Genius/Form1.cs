using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genius
{
    public partial class Form1 : Form
    {
        string[] questions = { "У блогера было загружено 26 видео. Все кроме последних 19 видео удалили модераторы. Сколько видео осталось?",
                "В старом доме 9 окон. Если помыть 4 грязных окна, то чистых станет в 2 раза больше, чем грязных. Сколько было изначально чистых окон?",
                "Если 1+1=10, то сколько будет 1+10?",
                "Бревно надо распилить на 10 частей. Сколько нужно сделать распилов?",
                "У вас было 5 яблок, 2 яблока вы положили к себе в карман, а одним яблоком угостили друга. Сколько яблок у вас осталось?"};
        string[] answers = { "19", "2", "11", "9", "4"};
        string[] diagnoses = { "идиот","дебил","дурак","норма","талант","гений"};
        int k_question = 0, right_answers=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = tbAnswer.Text.Trim();
            if (answer.Length > 0) {
                if (answer == answers[k_question]) right_answers++;
                k_question++;
                if (k_question < questions.Length)
                {
                    if (k_question < questions.Length - 1) {
                        bNext.Visible = true;
                        bFinish.Visible = false;
                    }
                    if (k_question == questions.Length - 1) {
                        bNext.Visible = false;
                        bFinish.Visible = true;
                    }
                    bPrevious.Visible = true;
                    lQuestion.Text = questions[k_question];
                    tbAnswer.Text = "";
                }
                tbAnswer.Focus();
            }
        }

        public void start_test()
        {
            lQuestion.Text = questions[0];
            k_question = 0;
            right_answers = 0;
            tbAnswer.Text = "";
            bPrevious.Visible = false;
            bFinish.Visible = false;
            bNext.Visible=true;
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            string answer = tbAnswer.Text.Trim();
            if (answer.Length > 0)
            {
                if (answer == answers[k_question]) right_answers++;
                k_question--;
                if (k_question >0)
                {
                    if (k_question > 0)
                    {
                        bPrevious.Visible = true;
                    }
                    if (k_question == 0)
                    {
                        bPrevious.Visible = false;
                    }
                    bFinish.Visible = false;
                    bNext.Visible = true;
                    lQuestion.Text = questions[k_question];
                    tbAnswer.Text = "";
                }
                tbAnswer.Focus();
            }
        }

        private void bFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы" + diagnoses[right_answers], "Диагноз");
            start_test();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start_test();
        }
    }
}

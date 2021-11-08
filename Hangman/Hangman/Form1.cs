using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        string originalWord = "программирование";
        int errorCount = 0;
        string usedLetters = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void Restart()
        {
            string tmp = "";
            for (int i = 0; i < originalWord.Length; i++) tmp += '*';
            lMasked.Text = tmp;
            errorCount = 0;
            usedLetters = "";
            lUsed.Text = "";
            pbError.Image = Image.FromFile("images/0.png");
            tbLetter.Text = "";
            tbLetter.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letter = tbLetter.Text.Trim().ToLower();
            if (letter.Length == 1 && letter[0] >= 'а' && letter[0] <= 'я' && usedLetters.IndexOf(letter[0])<0) {
                usedLetters += letter;
                lUsed.Text = usedLetters;
                if (originalWord.IndexOf(letter[0]) < 0)
                {
                    errorCount++;
                    pbError.Image = Image.FromFile("images/" + errorCount + ".png");
                    if (errorCount == 6) {
                        MessageBox.Show("К сожалению, вы проиграли(", "Результат");
                        Restart();
                    }
                }
                else {
                    for (int i = 0; i < originalWord.Length; i++)
                    {
                        if (originalWord[i] == letter[0])
                        {
                            lMasked.Text=lMasked.Text.Insert(i, letter);
                            lMasked.Text=lMasked.Text.Remove(i + 1, 1);
                            //lMasked.Text = lMasked.Text.Substring(0, i) + letter[0] + lMasked.Text.Substring(i + 1, lMasked.Text.Length - i - 1);
                        }
                    }
                    if (lMasked.Text.IndexOf('*') < 0) {
                        MessageBox.Show("Ура!!! Вы выиграли)", "Результат");
                        Restart();
                    }
                }
            }
            tbLetter.Focus();
            tbLetter.Text = "";
        }

        private void tbLetter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) button1_Click(sender, e);
        }
    }
}

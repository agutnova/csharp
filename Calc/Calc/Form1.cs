using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        char operation = ' ';
        bool ispressed = false;
        Int64 first = 0;
        char digit = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string t = "";
            if (digit == ' ') t = ((Button)sender).Text;
            else t = ""+digit;
            digit = ' ';
            if (tbResult.Text == "0" || ispressed)
            {
                tbResult.Text = t;
                ispressed = false;
            } 
            else tbResult.Text = tbResult.Text + t;
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if (operation!=' ') bEquals_Click(sender, e);
            ispressed = true;
            if (digit == ' ') operation = ((Button)sender).Text[0];
            else operation = digit;
            digit = ' ';
            first = Convert.ToInt64(tbResult.Text);
        }

        private void bEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case '+':tbResult.Text = Convert.ToString(first + Convert.ToInt64(tbResult.Text)); break;
                case '-':tbResult.Text = Convert.ToString(first - Convert.ToInt64(tbResult.Text)); break;
                case '*':tbResult.Text = Convert.ToString(first * Convert.ToInt64(tbResult.Text)); break;
                case '/':if (tbResult.Text == "0")
                        tbResult.Text = "На ноль делить нельзя!";
                    else tbResult.Text = Convert.ToString(first / Convert.ToInt64(tbResult.Text)); break;
            }
            operation = ' ';
            ispressed = true;
            first = 0;
        }

        private void bCLeft_Click(object sender, EventArgs e)
        {
            tbResult.Text = tbResult.Text.Substring(0, tbResult.Text.Length - 1);
            if (tbResult.Text == "") tbResult.Text = "0";
        }

        private void bClearAll_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            first = 0;
            operation = ' ';
            ispressed = false;
        }

        private void button9_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= (int)Keys.D0 && e.KeyValue <= (int)Keys.D9) ||
                    (e.KeyValue >= (int)Keys.NumPad0 && e.KeyValue <= (int)Keys.NumPad9))
            {
                switch (e.KeyCode)
                {
                    case Keys.D0: case Keys.NumPad0: digit = '0'; break;
                    case Keys.D1: case Keys.NumPad1: digit = '1'; break;
                    case Keys.D2: case Keys.NumPad2: digit = '2'; break;
                    case Keys.D3: case Keys.NumPad3: digit = '3'; break;
                    case Keys.D4: case Keys.NumPad4: digit = '4'; break;
                    case Keys.D5: case Keys.NumPad5: digit = '5'; break;
                    case Keys.D6: case Keys.NumPad6: digit = '6'; break;
                    case Keys.D7: case Keys.NumPad7: digit = '7'; break;
                    case Keys.D8: case Keys.NumPad8: digit = '8'; break;
                    case Keys.D9: case Keys.NumPad9: digit = '9'; break;
                }
                button9_Click(sender, e);
            }
            if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.Multiply ||
                e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract) {
                switch (e.KeyCode) {
                    case Keys.Divide: digit = '/';break;
                    case Keys.Multiply: digit = '*'; break;
                    case Keys.Add: digit = '+'; break;
                    case Keys.Subtract: digit = '-'; break;
                }
                bDiv_Click(sender, e);
            }
            if (e.KeyCode == Keys.Back) bCLeft_Click(sender, e);
            if (e.KeyCode == Keys.C) bClearAll_Click(sender, e);
            //if (e.KeyCode == Keys.Enter) bEquals_Click(sender, e);
        }
    }
}

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
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string t = ((Button)sender).Text;
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
            operation = ((Button)sender).Text[0];
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
                    {
                        tbResult.Text = "На ноль делить нельзя!";
                        ispressed = true;
                    }
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

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}

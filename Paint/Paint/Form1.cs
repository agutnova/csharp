using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        bool isPressed = false;
        int prevX = 0, prevY=0;
        int startX = 0, startY = 0;
        string tool = "pen";
        Color forecolor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbWorkarea.BackColor = Color.White;
            canvas = pbWorkarea.CreateGraphics();
            isPressed = false;
            tool = "pen";
            forecolor = Color.Black;
            pForeColor.BackColor = forecolor;
        }

        private void pbWorkarea_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void pbWorkarea_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            prevX = e.X;
            prevY = e.Y;
            startX = e.X;
            startY = e.Y;
        }

        private void bPen_Click(object sender, EventArgs e)
        {
            tool = "pen";
        }

        private void bLine_Click(object sender, EventArgs e)
        {
            tool = "line";
        }

        private void bEllipse_Click(object sender, EventArgs e)
        {
            tool = "ellipse";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                forecolor = colorDialog1.Color;
                pForeColor.BackColor = forecolor;
            }
        }

        private void bRect_Click(object sender, EventArgs e)
        {
            tool = "rect";
        }

        private void pbWorkarea_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                Pen p = new Pen(forecolor);
                Pen pbg = new Pen(Color.White);
                switch (tool)
                {
                    case "pen": 
                        canvas.DrawLine(p, prevX, prevY, e.X, e.Y);
                         break;
                    case "line":
                        canvas.DrawLine(pbg, startX, startY, prevX, prevY);
                        canvas.DrawLine(p, startX, startY, e.X, e.Y);
                        break;
                    case "ellipse":
                        canvas.DrawEllipse(pbg, startX, startY, prevX - startX, prevY - startY);
                        canvas.DrawEllipse(p,startX,startY,e.X-startX, e.Y-startY);
                        break;
                    case "rect":
                        int x= startX, y= startY,w=Math.Abs(prevX - startX),h=Math.Abs(prevY - startY);
                        if (prevX - startX < 0) x = startX - w;
                        if (prevY - startY < 0) y = startY - h;
                        canvas.DrawRectangle(pbg, x,y,w,h);
                        x = startX; y = startY; w = Math.Abs(e.X - startX); h = Math.Abs(e.Y - startY);
                        if (e.X - startX < 0) x = startX - w;
                        if (e.Y - startY < 0) y = startY - h;
                        canvas.DrawRectangle(p, x,y,w,h);
                        break;
                }
                prevX = e.X;
                prevY = e.Y;
            }
        }
    }
}

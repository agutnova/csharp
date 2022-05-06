using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demon
{
    public class Atom
    {
        char type, vessel;
        Color color;
        int x, y, radius;
        double v, alpha;

        public Atom()
        {
            type = 'h';
            color = Color.Red;
            vessel = 'l';
            x = 0; y = 0;
            radius = 2;
            v = 0;  alpha = 0;
        }

        public Atom(char vessel, char type, int radius, Point left_top, Point right_bottom)
        {
            Point lt=left_top, rb=right_bottom;
            if (vessel == 'l') rb.X = right_bottom.X/2;
            else lt.X=right_bottom.X/2;

            this.vessel = vessel;
            this.type = type;
            if (type=='h') color = Color.Red;
            else color= Color.Blue;
            this.radius = radius;
            Random rnd = new Random();
            x = rnd.Next(lt.X+20+radius, rb.X-20-radius);
            y = rnd.Next(lt.Y + 20 + radius, rb.Y - 20 - radius);
            alpha = rnd.NextDouble()*2*Math.PI;
            v = rnd.Next(0,5);
        }

        public void Draw(Graphics g, bool clear)
        {
            SolidBrush b;
            if (clear) b = new SolidBrush(Color.White);
            else b = new SolidBrush(color);
            g.FillEllipse(b, x - radius, y - radius, 2 * radius, 2 * radius);
        }

        public void Move(Graphics g)
        {
            Draw(g, true);
            x = (int)(x + radius * Math.Cos(alpha));
            y = (int)(y + radius * Math.Sin(alpha));
            Draw(g, false);
        }
    }
}

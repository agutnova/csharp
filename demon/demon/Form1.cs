namespace demon
{
    public partial class Form1 : Form
    {
        Graphics g;
        static int N = 20;
        Atom[] atoms=new Atom[N];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            g = pbVessels.CreateGraphics();
            pbVessels.BackColor= Color.White;
        }

        public void CreateField()
        {
            Pen p = new Pen(Color.Black, 15);
            g.DrawRectangle(p, 0, 0, pbVessels.Width, pbVessels.Height);
            g.DrawLine(p, pbVessels.Width / 2, 0, pbVessels.Width / 2, pbVessels.Height / 2 - 30);
            g.DrawLine(p, pbVessels.Width / 2, pbVessels.Height / 2 + 30, pbVessels.Width / 2, pbVessels.Height);

            char vessel, type;
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                if (i<N/2) vessel = 'l'; else vessel = 'r';
                if (rnd.NextDouble() < 0.5) type = 'h'; else type = 'c';
                atoms[i] = new Atom(vessel, type, 5,new Point(0,0), new Point(pbVessels.Width, pbVessels.Height));
                atoms[i].Draw(g,false);
            }
        }

        private void pbVessels_Click(object sender, EventArgs e)
        {
            CreateField();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
                try
                {
                    atoms[i].Move(g);
                } catch {}
        }
    }
}
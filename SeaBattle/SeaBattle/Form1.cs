using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class Form1 : Form
    {
        PictureBox ship, bomb, canon;
        Image ship_png, bomb_png, canon_png;
        int dx_ship;

        private void tShip_Tick(object sender, EventArgs e)
        {
            ship.Left += dx_ship;
            if ((dx_ship > 0 && ship.Left > pictureBox1.Width-ship.Width) ||
               (dx_ship < 0 && ship.Left <0)) dx_ship = -dx_ship;
            canon.Focus();
        }

        private void tBomb_Tick(object sender, EventArgs e)
        {
            bomb.Top -= 5;
            if (Math.Abs(bomb.Left - ship.Left) < 30 && Math.Abs(bomb.Top - ship.Top) < 30) {
                MessageBox.Show("Попал!!!");
                tBomb.Enabled = false;
                bomb.Visible= false;
            }
            if (bomb.Top < 0) {
                tBomb.Enabled = false;
                bomb.Visible = false;
            }
        }

        private void CanonKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show(""+e.KeyCode);
            if (e.KeyCode == Keys.Space) {
                bomb.Top = 580;
                bomb.Visible = true;
                tBomb.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        void Init()
        {
            ship_png = Image.FromFile("ship.png");
            bomb_png = Image.FromFile("bomb.png");
            canon_png = Image.FromFile("canon.png");
            ship = new PictureBox { 
                Parent=pictureBox1,
                Size=new Size(130,50),
                Top=400,
                Left=0,
                SizeMode=PictureBoxSizeMode.StretchImage,
                Image=ship_png
            };
            canon = new PictureBox
            {
                Parent = pictureBox1,
                Size = new Size(50, 70),
                Top = 600,
                Left = 400,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = canon_png
            };
            canon.PreviewKeyDown += CanonKeyDown;
            bomb = new PictureBox
            {
                Parent = pictureBox1,
                Size = new Size(30, 30),
                Top = 400,
                Left = 400,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = bomb_png,
                Visible=false
            };
        }

        void Start() {
            dx_ship = 5;
            tShip.Interval = 10;
            tShip.Enabled = true;
            canon.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }
    }
}

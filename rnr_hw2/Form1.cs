using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_clone
{
    public partial class Form1 : Form
    {
        public int p1score = 0;
        public int p2score = 0;
        public int count =0;
        public bool p1up;
        public bool p2up;
        public bool p1down;
        public bool p2down;
        public int speedx = 2;
        public int speedy = 2;

        public void ResetAll()
        {
            btRelease.Visible = true;
            btReset.Visible = true;
            btQuit.Visible = true;
            p1up = false;
            p1down = false;
            p2up = false;
            p2down = false;
        }

        public void check()
        {
            if ((ball.Location.Y == 300) || (ball.Location.Y == 100))
                speedy = -speedy;
            
            if ((ball.Location.X == 20) && (ball.Location.Y >= p1bar.Location.Y - 9) && (ball.Location.Y <= p1bar.Location.Y + 59))
                speedx = -speedx;
            else if ((ball.Location.X == 290) && (ball.Location.Y >= p2bar.Location.Y - 9) && (ball.Location.Y <= p2bar.Location.Y + 59))
                speedx = -speedx;
        }

        public void move()
        {
            if ((p1up)&&(p1bar.Location.Y != 100))
                p1bar.Location = new Point(p1bar.Location.X, p1bar.Location.Y - 5);
            if ((p1down) && (p1bar.Location.Y != 260))
                p1bar.Location = new Point(p1bar.Location.X, p1bar.Location.Y + 5);
            if ((p2up) && (p2bar.Location.Y != 100))
                p2bar.Location = new Point(p2bar.Location.X, p2bar.Location.Y - 5);
            if ((p2down) && (p2bar.Location.Y != 260))
                p2bar.Location = new Point(p2bar.Location.X, p2bar.Location.Y + 5);
            
        }

        public void win()
        {
            if (ball.Location.X == 310)
            {
                ResetAll();
                p1score += 1;
                lblp1score.Text = p1score + "";
                MessageBox.Show("P1 wins!");  
            }
            if (ball.Location.X == 10)
            {
                ResetAll();
                p2score += 1;
                lblp2score.Text = p2score + "";
                MessageBox.Show("P2 wins!");
            }
        }

        public void timecount_Tick(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + speedx, ball.Location.Y + speedy);
            move();
            check();
            win();
        }


        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            Timer timecount = new Timer();
            timecount.Enabled = true;
            timecount.Interval = 1;
            timecount.Tick += new EventHandler(timecount_Tick);
            ball.Location = new Point(999, 999);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    p1up = false;
                    break;
                case Keys.S:
                    p1down = false;
                    break;
                case Keys.O:
                    p2up = false;
                    break;
                case Keys.K:
                    p2down = false;
                    break;
            }
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                        p1up = true;
                    break;
                case Keys.S:
                        p1down = true;
                    break;

                case Keys.O:
                        p2up = true;
                    break;
                case Keys.K:
                        p2down = true;
                    break;
            }
        }

        private void btRelease_Click(object sender, EventArgs e)
        {
                count = 1;
                ball.Visible = true;
                lblp1score.Visible = true;
                lblScore.Visible = true;
                lblp2score.Visible = true;
                ball.Location = new Point(150, 200);

                btRelease.Visible = false;
                btReset.Visible = false;
                btQuit.Visible = false;
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            p1score = 0;
            lblp1score.Text = p1score + "";
            p2score = 0;
            lblp2score.Text = p1score + "";
        }
    }
}
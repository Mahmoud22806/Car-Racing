using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cccccc
{
    public partial class me : Form
    {
        public me()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coincollection();
        }

        int collectedcoin = 0;

        Random r = new Random();
        int x;

        void enemy(int speed)
        {

            if (enemy1.Top >= 420)
            {
                x = r.Next(30, 280);
                enemy1.Location = new Point(x, 0);
            }
            else
            { enemy1.Top += speed; }

            if (enemy2.Top >= 420)
            {
                x = r.Next(50, 280);
                enemy2.Location = new Point(x, 0);
            }
            else
            { enemy2.Top += speed; }

            if (enemy3.Top >= 420)
            {
                x = r.Next(30, 280);
                enemy3.Location = new Point(x, 0);
            }
            else
            { enemy3.Top += speed; }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 420)
            {
                x = r.Next(30, 280);
                coin1.Location = new Point(x, 0);
            }
            else
            { coin1.Top += speed; }

            if (coin2.Top >= 420)
            {
                x = r.Next(30, 280);
                coin2.Location = new Point(x, 0);
            }
            else
            { coin2.Top += speed; }

            if (coin3.Top >= 420)
            {
                x = r.Next(30, 280);
                coin3.Location = new Point(x, 0);
            }
            else
            { coin3.Top += speed; }

        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }

        }


        void moveline(int speed)
        {

            if (pictureBox1.Top >= 420)
                pictureBox1.Top = 0;
            else
                pictureBox1.Top += speed;

            if (pictureBox4.Top >= 420)
                pictureBox4.Top = 0;
            else
                pictureBox4.Top += speed;

            if (pictureBox5.Top >= 420)
                pictureBox5.Top = 0;
            else
                pictureBox5.Top += speed;

            if (pictureBox6.Top >= 420)
                pictureBox6.Top = 0;
            else
                pictureBox6.Top += speed;

            if (pictureBox7.Top >= 420)
                pictureBox7.Top = 0;
            else
                pictureBox7.Top += speed;

            if (pictureBox8.Top >= 420)
                pictureBox8.Top = 0;
            else
                pictureBox8.Top += speed;

            if (pictureBox9.Top >= 420)
                pictureBox9.Top = 0;
            else
                pictureBox9.Top += speed;

            if (pictureBox10.Top >= 420)
                pictureBox10.Top = 0;
            else
                pictureBox10.Top += speed;

        }

        void coincollection()
        {

            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label2.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(30, 280);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label2.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(30, 280);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label2.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(30, 280);
                coin3.Location = new Point(x, 0);
            }
        }

        int gamespeed = 2;

        private void me_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Left || e.KeyCode == Keys.A)
            {
                if (car.Left > 10)
                    car.Left += -8;
            }

            if(e.KeyCode==Keys.Right || e.KeyCode == Keys.D)
            {
                if (car.Right < 295)
                    car.Left += 8;
            }

            if(e.KeyCode==Keys.Up || e.KeyCode == Keys.W)
            {
                if (gamespeed < 16)
                    gamespeed++;
            }

            if(e.KeyCode==Keys.Down || e.KeyCode == Keys.S)
            {
                if (gamespeed > 0)
                    gamespeed--;
            }
        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }
    }
}

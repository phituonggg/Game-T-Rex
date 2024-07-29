using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net.Security;
using System.Threading;

namespace Midterm_Project___TRex
{
    public partial class Form1 : Form
    {
        bool jump=false;
        int JumpSpeed;
        int Force = 12;
        int score = 0;
        int scorepast = 0;
        int stage = 0;
        SoundPlayer sound = new SoundPlayer(@"C:\Users\Hi\Downloads\jumpsound`1.wav");
        PictureBox pictureBox = new PictureBox();
        int Dinasourhealth = 100;
        int check;
        int ObstacleSpeed = 10;
        Random rand=new Random();
        int position;
        int count = 0;
        int round = 0;
        bool GameOver=false;
        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            
            trex.Top += JumpSpeed;
            Score.Text = "Score: " + score;
            if (jump == true && Force < 0)
            {

                jump = false;
            }
            if (jump == true)
            {
                JumpSpeed = -12;
                Force -= 1;
            }
            else
            {
                JumpSpeed = 12;
            }
            if (trex.Top > 269 && jump == false)
            {
                Force = 12;
                trex.Top = 270;
                JumpSpeed = 0;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle" && stage == 0)
                {
                    x.Left -= ObstacleSpeed;
                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 300) + (x.Width * 10);
                        score++;
                    }
                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        Score.Text = "Press R to restart the game";
                        GameOver = true;
                    }
                }
                else
                {
                    continue;
                }

            }

            if (score > 5 && stage == 0)
            {

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "BIRD")
                    {

                        j.Left -= ObstacleSpeed;
                        if (j.Left < -100)

                        {
                            position = this.ClientSize.Width + rand.Next(500, 800) + (j.Width * 10);
                            j.Left = position;
                        }



                        if (trex.Bounds.IntersectsWith(j.Bounds))
                        {
                            gameTimer.Stop();
                            trex.Image = Properties.Resources.dead;
                            Score.Text = "Press R to restart the game";
                            GameOver = true;
                        }
                    }

                }
            }
            foreach (Control x in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "BIRD")
                    {
                        if (j.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                        }

                    }
                }
            }
            if (score - scorepast == 10 && count==0)
            {
                stage = 1;
                Boss.Left = 400;
                Boss.Top = 100;
                HealthBoss.Left = Boss.Left + 30;
            }
            if (score - scorepast == 10)
            {
                count = 1;
                Thread.Sleep(20);

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "bullet")
                    {
                        if (Boss.Bounds.IntersectsWith(x.Bounds))
                        {
                            Dinasourhealth -= 1;
                            HealthBoss.Value = Dinasourhealth;

                        }
                    }
                }
                if (Boss.Top == 200)
                {
                    check = 0;
                }
                if (Boss.Top == 50)
                {
                    check = 1;
                }
                if (check == 0)
                {
                    Boss.Top -= 10;

                    round++;
                }
                else
                {
                    Boss.Top += 10;

                    round++;
                }
                if (round == 20)
                {
                    BossShootBullet("Boss");
                    round = 0;
                }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "Bossbullet")
                    {
                        if (trex.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            trex.Image = Properties.Resources.dead;
                            Score.Text = "Press R to restart the game";
                            GameOver = true;
                        }

                    }
                    if (Dinasourhealth < 1)
                    {

                        round = 0;
                        Boss.Left = this.ClientSize.Width + 500;
                        HealthBoss.Left = Boss.Left + 30;
                        Dinasourhealth = 100;
                        HealthBoss.Value = Dinasourhealth;
                        score++;
                        count = 0;
                        scorepast += 15;
                        stage = 0;
                        ObstacleSpeed += 10;
                    }


                }




            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode==Keys.Space && jump == false)
            {
                //sound.Play();
                jump = true;
                
            }
            if (e.KeyCode == Keys.M)
            {
                ShootBullet("Player");
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (jump == true)
                {
                    jump = false;

                }
            }
            if(e.KeyCode==Keys.R && GameOver == true)
            {
                GameReset();
                
            }
        }
        private void GameReset() {
            Force = 12;
            JumpSpeed = 0;
            jump = false;
            stage = 0;
            score = 0;
            scorepast = 0;
            round = 0;
            count = 0;
            ObstacleSpeed = 10;
            Dinasourhealth = 100;
            HealthBoss.Value = Dinasourhealth;
            Score.Text = "Score : " + score;
            trex.Image = Properties.Resources.running;
            Boss.Image = Properties.Resources.bird1_removebg_preview;
            GameOver = false;
            trex.Top = 270;
            count = 0;
            Boss.Left = this.ClientSize.Width + 500;
            HealthBoss.Left = Boss.Left + 30;
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left= position;
                }
               
                
            }
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && (string)j.Tag == "BIRD")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (j.Width * 10);
                    j.Left = position;
                }


            }
            

            gameTimer.Start();
        
        }
        private void ShootBullet(string name) { 
           Bullet shootbullet=new Bullet();
            shootbullet.BulletLeft=trex.Left+(trex.Width/2);
            shootbullet.BulletTop= trex.Top+(trex.Height/2);
            shootbullet.MakeBullet(this);
        
        }
        private void BossShootBullet(string name)
        {

            Bullet shootbullet = new Bullet();
            shootbullet.BulletLeft = Boss.Left + (Boss.Width / 2);
            shootbullet.BulletTop = Boss.Top + (Boss.Height / 2);
            shootbullet.BossBullet(this);
            

        }
    }
}

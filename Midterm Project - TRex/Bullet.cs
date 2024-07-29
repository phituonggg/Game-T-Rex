using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace Midterm_Project___TRex
{
    class Bullet
    {
        public int BulletLeft;
        public int BulletTop;
        private int speed = 20;
        private int bossspeed = 40;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();
        public string name;


        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.Black;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = BulletLeft;
            bullet.Top = BulletTop;
            bullet.BringToFront();
            form.Controls.Add(bullet);
            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }
        public void BossBullet(Form form)
        {
            bullet.BackColor = Color.Black;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "Bossbullet";
            bullet.Left = BulletLeft;
            bullet.Top = BulletTop;
            bullet.BringToFront();
            form.Controls.Add(bullet);
            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BossBulletTimerEvent);
            bulletTimer.Start();
        }
        private void BulletTimerEvent(object sender, EventArgs e)
        {
            
            
                bullet.Left += speed;
            
            if (bullet.Left < -100 || bullet.Left > 600)
            {  
                {
                    bulletTimer.Stop();
                    bulletTimer.Dispose();
                    bullet.Dispose();
                    bulletTimer = null;
                    bullet = null;
                }


            }
        }
        private void BossBulletTimerEvent(object sender, EventArgs e)
        {


            bullet.Left -= bossspeed;

            if (bullet.Left < -100 || bullet.Left > 600)
            {
                {
                    bulletTimer.Stop();
                    bulletTimer.Dispose();
                    bullet.Dispose();
                    bulletTimer = null;
                    bullet = null;
                }


            }

        }
    }
}

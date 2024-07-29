using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Project___TRex
{
    public partial class StartScreencs : Form
    {
        SoundPlayer sound = new SoundPlayer("C:/Users/Hi/Downloads/ES_Video Game Play TV - SFX Producer.wav");
        public StartScreencs()
        {
            InitializeComponent();
            
            //sound.Play();
        }

        private void GameStart(object sender, EventArgs e)
        {
            Form1 game= new Form1();
            StartScreencs mainscreen= new StartScreencs();
            game.ShowDialog();
            this.Close();
            sound.Stop();

        }

        private void ShowHelp(object sender, EventArgs e)
        {
            HelpScreencs help= new HelpScreencs();
            help.ShowDialog();

        }
    }
}

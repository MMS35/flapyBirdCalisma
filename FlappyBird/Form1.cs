using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class FlappyBird : Form
    {
        int boruHizi = 8;
        int gravity = 15;
        int score = 0;
        public FlappyBird()
        {
            InitializeComponent();
        }
       

        private void GameTimerEvent(object sender, EventArgs e)
        {
            
                bird.Top += gravity;
                boruAlt.Left -= boruHizi;
                boruUst.Left -= boruHizi;
                scoreText.Text = "score: " + score;
                if (boruAlt.Left < -150)
                {
                    boruAlt.Left = 800;
                    score++;
                }
                if (boruUst.Left < -180)
                {
                    boruUst.Left = 950;
                    score++;
                }


                if (bird.Bounds.IntersectsWith(boruAlt.Bounds) || bird.Bounds.IntersectsWith(boruUst.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds)||bird.Bounds.IntersectsWith(lblUstCizgi.Bounds)) //Sınır belirlemeler 
                {

                endGame();
                    #region OyunSonuDiyalogPenceresi

                    DialogResult dr = MessageBox.Show("Oyunu Kaybettin!  \nOyun Yeniden Başlatılsın mı", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Application.Restart();
                        scoreText.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                    #endregion



                }



                ////Hızlandırma
                //if(score > 5)
                //{
                //    boruHizi = 15;
                //}

                if (bird.Top < -25)
                {



                    DialogResult dr = MessageBox.Show("Oyunu Kaybettin! \nOyun Yeniden Başlasın mı ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        scoreText.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }




                    endGame();
                }
            
        
            
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            scoreText.Text = "Game Over :("; //Oyun bitirme
           
            gameTimer.Stop();
        }
      
        
    } 
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class PongGame : Form
    {
        public PongGame()
        {
            InitializeComponent();
        }

        enum enWinner
        {
            Player1,
            Player2,
            None
        }
        enWinner Winner = enWinner.None;

        int BallStep =5;
        int P1Score = 0;
        int P2Score = 0;

        int YDirection = -1;
        int XDirection = 1;
        Random rn = new Random();
        private void PongGame_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 1;


            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, this.Width/2, 10, this.Width/2, 550);
        }




        void GoUp(Keys key)
        {
            if(key == Keys.Up)
            {
                pnWallPlayer1.Location=new Point(pnWallPlayer1.Location.X, Math.Max(pnWallPlayer1.Location.Y-10,0));
                return;
            }

            if(key == Keys.W)  
                pnWallPlayer2.Location = new Point(pnWallPlayer2.Location.X, Math.Max(pnWallPlayer2.Location.Y - 10, 0));
         
        }


        void GoDown(Keys key)
        {
            if (key == Keys.Down)
            {        
                pnWallPlayer1.Location = new Point(pnWallPlayer1.Location.X, Math.Min(pnWallPlayer1.Location.Y + 10, this.ClientSize.Height-pnWallPlayer1.Height));
                return;
            } 

            if (key == Keys.S)
            
                pnWallPlayer2.Location = new Point(pnWallPlayer2.Location.X, Math.Min(pnWallPlayer2.Location.Y + 10, this.ClientSize.Height - pnWallPlayer2.Height));
          
        }
        
        void Move(Keys key)
        {
            if(key == Keys.W || key ==Keys.Up)
            {
                GoUp(key);
                return;
            }

            if(key == Keys.S || key == Keys.Down)
            {
                GoDown(key);
            }
        }

        private void PongGame_KeyDown(object sender, KeyEventArgs e)
        {
            Move(e.KeyData);
        }

        void ResetRound()
        {
            YDirection = rn.Next(0, 2) == 0 ? -1 : 1;
            XDirection = rn.Next(0, 2) == 0 ? -1 : 1;
            pnBall.Location = new Point(this.Width / 2, this.Height / 2);
        }
        void EndRound(enWinner Winner)
        {
            if(Winner == enWinner.Player1)
            {
                P1Score++;
                lblPlayer1Score.Text = P1Score.ToString();
            }

            if(Winner ==enWinner.Player2)
            {
                P2Score++;
                lblPlayer2Score.Text = P2Score.ToString();
            }
            ResetRound();
        }

        bool IsGameOver()
        {
            return P1Score == 10 || P2Score == 10;
        }
        void ResetGame()
        {
             Winner = enWinner.None;
             P1Score = 0;
             P2Score = 0;
             lblPlayer1Score.Text = "0";
             lblPlayer2Score.Text = "0";
             ResetRound();
        }
        void EndGame()
        {
            string Message = "";
            Message = (P1Score == 10) ? "Player1 Win\nDo you want to paly again?" :
                "Player2 Win\nDo you want to play again?";

            if (MessageBox.Show(Message, "Game Over!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ResetGame();
                timer1.Start();
            }
            else
                this.Close();
           
        }

        void MoveTheBall()
        {
            pnBall.Location = new Point(pnBall.Location.X + (BallStep * XDirection), pnBall.Location.Y + (BallStep *YDirection));

            if (pnBall.Location.Y <= 0 ||
                pnBall.Location.Y >= this.ClientSize.Height - pnBall.Height)     
                YDirection *= -1;
        

            if(pnBall.Bounds.IntersectsWith(pnWallPlayer1.Bounds) && XDirection > 0 ||
               pnBall.Bounds.IntersectsWith(pnWallPlayer2.Bounds) && XDirection < 0)
                XDirection *= -1;
           
            if(pnBall.Location.X > this.ClientSize.Width)
            {
                EndRound(enWinner.Player2);
            }

            if(pnBall.Location.X < 0)
            {
                EndRound(enWinner.Player1);
            }

            if(IsGameOver())
            {
                timer1.Stop();
                EndGame();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveTheBall();
        }

       
    }
}

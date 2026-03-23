namespace Pong_Game
{
    partial class PongGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.pnWallPlayer1 = new System.Windows.Forms.Panel();
            this.pnWallPlayer2 = new System.Windows.Forms.Panel();
            this.pnBall = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Score.Location = new System.Drawing.Point(445, 22);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(68, 73);
            this.lblPlayer2Score.TabIndex = 0;
            this.lblPlayer2Score.Text = "0";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Score.Location = new System.Drawing.Point(595, 22);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(68, 73);
            this.lblPlayer1Score.TabIndex = 1;
            this.lblPlayer1Score.Text = "0";
            // 
            // pnWallPlayer1
            // 
            this.pnWallPlayer1.BackColor = System.Drawing.Color.White;
            this.pnWallPlayer1.Location = new System.Drawing.Point(1050, 220);
            this.pnWallPlayer1.Name = "pnWallPlayer1";
            this.pnWallPlayer1.Size = new System.Drawing.Size(30, 116);
            this.pnWallPlayer1.TabIndex = 2;
            // 
            // pnWallPlayer2
            // 
            this.pnWallPlayer2.BackColor = System.Drawing.Color.White;
            this.pnWallPlayer2.Location = new System.Drawing.Point(0, 220);
            this.pnWallPlayer2.Name = "pnWallPlayer2";
            this.pnWallPlayer2.Size = new System.Drawing.Size(30, 116);
            this.pnWallPlayer2.TabIndex = 3;
            // 
            // pnBall
            // 
            this.pnBall.BackColor = System.Drawing.Color.White;
            this.pnBall.Location = new System.Drawing.Point(539, 276);
            this.pnBall.Name = "pnBall";
            this.pnBall.Size = new System.Drawing.Size(21, 24);
            this.pnBall.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1081, 578);
            this.Controls.Add(this.pnBall);
            this.Controls.Add(this.pnWallPlayer2);
            this.Controls.Add(this.pnWallPlayer1);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblPlayer2Score);
            this.MaximizeBox = false;
            this.Name = "PongGame";
            this.Text = " ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PongGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PongGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Panel pnWallPlayer1;
        private System.Windows.Forms.Panel pnWallPlayer2;
        private System.Windows.Forms.Panel pnBall;
        private System.Windows.Forms.Timer timer1;
    }
}


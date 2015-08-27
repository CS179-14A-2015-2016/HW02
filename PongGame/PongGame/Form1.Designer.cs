namespace PongGame
{
    partial class Form1
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
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP1MoveUp = new System.Windows.Forms.Label();
            this.labelP1MoveDown = new System.Windows.Forms.Label();
            this.labelP2MoveUp = new System.Windows.Forms.Label();
            this.labelP2MoveDown = new System.Windows.Forms.Label();
            this.panelPlaySpace = new System.Windows.Forms.Panel();
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.pictureBoxP2Paddle = new System.Windows.Forms.PictureBox();
            this.pictureBoxP1Paddle = new System.Windows.Forms.PictureBox();
            this.labelEnterToStart = new System.Windows.Forms.Label();
            this.labelScoreP1 = new System.Windows.Forms.Label();
            this.labelScoreP2 = new System.Windows.Forms.Label();
            this.panelPlaySpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP2Paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP1Paddle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.Location = new System.Drawing.Point(295, 439);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(52, 36);
            this.labelP1.TabIndex = 0;
            this.labelP1.Text = "P1";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.Location = new System.Drawing.Point(540, 439);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(52, 36);
            this.labelP2.TabIndex = 1;
            this.labelP2.Text = "P2";
            // 
            // labelP1MoveUp
            // 
            this.labelP1MoveUp.AutoSize = true;
            this.labelP1MoveUp.BackColor = System.Drawing.Color.White;
            this.labelP1MoveUp.Location = new System.Drawing.Point(174, 470);
            this.labelP1MoveUp.Name = "labelP1MoveUp";
            this.labelP1MoveUp.Size = new System.Drawing.Size(49, 17);
            this.labelP1MoveUp.TabIndex = 2;
            this.labelP1MoveUp.Text = "Up (E)";
            // 
            // labelP1MoveDown
            // 
            this.labelP1MoveDown.AutoSize = true;
            this.labelP1MoveDown.BackColor = System.Drawing.Color.White;
            this.labelP1MoveDown.Location = new System.Drawing.Point(156, 493);
            this.labelP1MoveDown.Name = "labelP1MoveDown";
            this.labelP1MoveDown.Size = new System.Drawing.Size(67, 17);
            this.labelP1MoveDown.TabIndex = 3;
            this.labelP1MoveDown.Text = "Down (D)";
            // 
            // labelP2MoveUp
            // 
            this.labelP2MoveUp.AutoSize = true;
            this.labelP2MoveUp.BackColor = System.Drawing.Color.White;
            this.labelP2MoveUp.Location = new System.Drawing.Point(670, 470);
            this.labelP2MoveUp.Name = "labelP2MoveUp";
            this.labelP2MoveUp.Size = new System.Drawing.Size(43, 17);
            this.labelP2MoveUp.TabIndex = 4;
            this.labelP2MoveUp.Text = "Up (I)";
            // 
            // labelP2MoveDown
            // 
            this.labelP2MoveDown.AutoSize = true;
            this.labelP2MoveDown.BackColor = System.Drawing.Color.White;
            this.labelP2MoveDown.Location = new System.Drawing.Point(670, 493);
            this.labelP2MoveDown.Name = "labelP2MoveDown";
            this.labelP2MoveDown.Size = new System.Drawing.Size(66, 17);
            this.labelP2MoveDown.TabIndex = 5;
            this.labelP2MoveDown.Text = "Down (K)";
            // 
            // panelPlaySpace
            // 
            this.panelPlaySpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPlaySpace.Controls.Add(this.pictureBoxBall);
            this.panelPlaySpace.Controls.Add(this.pictureBoxP2Paddle);
            this.panelPlaySpace.Controls.Add(this.pictureBoxP1Paddle);
            this.panelPlaySpace.Location = new System.Drawing.Point(12, 12);
            this.panelPlaySpace.Name = "panelPlaySpace";
            this.panelPlaySpace.Size = new System.Drawing.Size(879, 404);
            this.panelPlaySpace.TabIndex = 6;
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.BackColor = System.Drawing.Color.White;
            this.pictureBoxBall.Location = new System.Drawing.Point(425, 202);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxBall.TabIndex = 2;
            this.pictureBoxBall.TabStop = false;
            // 
            // pictureBoxP2Paddle
            // 
            this.pictureBoxP2Paddle.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxP2Paddle.Location = new System.Drawing.Point(850, 167);
            this.pictureBoxP2Paddle.Name = "pictureBoxP2Paddle";
            this.pictureBoxP2Paddle.Size = new System.Drawing.Size(26, 98);
            this.pictureBoxP2Paddle.TabIndex = 1;
            this.pictureBoxP2Paddle.TabStop = false;
            // 
            // pictureBoxP1Paddle
            // 
            this.pictureBoxP1Paddle.BackColor = System.Drawing.Color.Red;
            this.pictureBoxP1Paddle.Location = new System.Drawing.Point(3, 167);
            this.pictureBoxP1Paddle.Name = "pictureBoxP1Paddle";
            this.pictureBoxP1Paddle.Size = new System.Drawing.Size(26, 98);
            this.pictureBoxP1Paddle.TabIndex = 0;
            this.pictureBoxP1Paddle.TabStop = false;
            // 
            // labelEnterToStart
            // 
            this.labelEnterToStart.AutoSize = true;
            this.labelEnterToStart.Location = new System.Drawing.Point(388, 419);
            this.labelEnterToStart.Name = "labelEnterToStart";
            this.labelEnterToStart.Size = new System.Drawing.Size(132, 17);
            this.labelEnterToStart.TabIndex = 7;
            this.labelEnterToStart.Text = "Press Enter to Start";
            // 
            // labelScoreP1
            // 
            this.labelScoreP1.AutoSize = true;
            this.labelScoreP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreP1.Location = new System.Drawing.Point(30, 457);
            this.labelScoreP1.Name = "labelScoreP1";
            this.labelScoreP1.Size = new System.Drawing.Size(85, 31);
            this.labelScoreP1.TabIndex = 8;
            this.labelScoreP1.Text = "Score";
            // 
            // labelScoreP2
            // 
            this.labelScoreP2.AutoSize = true;
            this.labelScoreP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreP2.Location = new System.Drawing.Point(778, 457);
            this.labelScoreP2.Name = "labelScoreP2";
            this.labelScoreP2.Size = new System.Drawing.Size(85, 31);
            this.labelScoreP2.TabIndex = 9;
            this.labelScoreP2.Text = "Score";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 519);
            this.Controls.Add(this.labelScoreP2);
            this.Controls.Add(this.labelScoreP1);
            this.Controls.Add(this.labelEnterToStart);
            this.Controls.Add(this.panelPlaySpace);
            this.Controls.Add(this.labelP2MoveDown);
            this.Controls.Add(this.labelP2MoveUp);
            this.Controls.Add(this.labelP1MoveDown);
            this.Controls.Add(this.labelP1MoveUp);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPlaySpace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP2Paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP1Paddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP1MoveUp;
        private System.Windows.Forms.Label labelP1MoveDown;
        private System.Windows.Forms.Label labelP2MoveUp;
        private System.Windows.Forms.Label labelP2MoveDown;
        private System.Windows.Forms.Panel panelPlaySpace;
        private System.Windows.Forms.PictureBox pictureBoxP2Paddle;
        private System.Windows.Forms.PictureBox pictureBoxP1Paddle;
        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.Label labelEnterToStart;
        private System.Windows.Forms.Label labelScoreP1;
        private System.Windows.Forms.Label labelScoreP2;
    }
}


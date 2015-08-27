namespace Pong_clone
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.p1bar = new System.Windows.Forms.PictureBox();
            this.p2bar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblp1score = new System.Windows.Forms.Label();
            this.lblp2score = new System.Windows.Forms.Label();
            this.btRelease = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ball.Image = global::Pong_clone.Properties.Resources.white_dot;
            this.ball.Location = new System.Drawing.Point(150, 100);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            this.ball.Visible = false;
            // 
            // p1bar
            // 
            this.p1bar.BackColor = System.Drawing.Color.RoyalBlue;
            this.p1bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p1bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1bar.Location = new System.Drawing.Point(10, 180);
            this.p1bar.Name = "p1bar";
            this.p1bar.Size = new System.Drawing.Size(10, 50);
            this.p1bar.TabIndex = 1;
            this.p1bar.TabStop = false;
            // 
            // p2bar
            // 
            this.p2bar.BackColor = System.Drawing.Color.Red;
            this.p2bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p2bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2bar.Location = new System.Drawing.Point(300, 180);
            this.p2bar.Name = "p2bar";
            this.p2bar.Size = new System.Drawing.Size(10, 50);
            this.p2bar.TabIndex = 0;
            this.p2bar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(10, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 210);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "PONG!!!";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Virtual DJ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(121, 64);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(79, 20);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "SCORE";
            // 
            // lblp1score
            // 
            this.lblp1score.AutoSize = true;
            this.lblp1score.Font = new System.Drawing.Font("Virtual DJ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1score.ForeColor = System.Drawing.Color.Blue;
            this.lblp1score.Location = new System.Drawing.Point(36, 59);
            this.lblp1score.Name = "lblp1score";
            this.lblp1score.Size = new System.Drawing.Size(31, 28);
            this.lblp1score.TabIndex = 9;
            this.lblp1score.Text = "0";
            // 
            // lblp2score
            // 
            this.lblp2score.AutoSize = true;
            this.lblp2score.Font = new System.Drawing.Font("Virtual DJ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2score.ForeColor = System.Drawing.Color.Red;
            this.lblp2score.Location = new System.Drawing.Point(253, 59);
            this.lblp2score.Name = "lblp2score";
            this.lblp2score.Size = new System.Drawing.Size(31, 28);
            this.lblp2score.TabIndex = 10;
            this.lblp2score.Text = "0";
            // 
            // btRelease
            // 
            this.btRelease.BackColor = System.Drawing.SystemColors.Control;
            this.btRelease.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelease.ForeColor = System.Drawing.Color.Black;
            this.btRelease.Location = new System.Drawing.Point(72, 146);
            this.btRelease.Name = "btRelease";
            this.btRelease.Size = new System.Drawing.Size(173, 112);
            this.btRelease.TabIndex = 0;
            this.btRelease.TabStop = false;
            this.btRelease.Text = "RELEASE THE BALL!!";
            this.btRelease.UseVisualStyleBackColor = false;
            this.btRelease.Click += new System.EventHandler(this.btRelease_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.Control;
            this.btReset.ForeColor = System.Drawing.Color.Black;
            this.btReset.Location = new System.Drawing.Point(10, 11);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(79, 23);
            this.btReset.TabIndex = 0;
            this.btReset.TabStop = false;
            this.btReset.Text = "Reset Score";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.SystemColors.Control;
            this.btQuit.ForeColor = System.Drawing.Color.Black;
            this.btQuit.Location = new System.Drawing.Point(227, 11);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(83, 23);
            this.btQuit.TabIndex = 0;
            this.btQuit.TabStop = false;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "P1: Press W + S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(224, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "P2: Press O + K";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "<-- Instructions -->";
            // 
            // Form1
            // 
            this.AcceptButton = this.btReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 318);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRelease);
            this.Controls.Add(this.lblp2score);
            this.Controls.Add(this.lblp1score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.p1bar);
            this.Controls.Add(this.p2bar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p2bar;
        private System.Windows.Forms.PictureBox p1bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblp1score;
        private System.Windows.Forms.Label lblp2score;
        private System.Windows.Forms.Button btRelease;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


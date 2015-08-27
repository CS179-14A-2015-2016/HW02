using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame
{
    public partial class Form1 : Form
    {
        //declaring variables
        private static System.Timers.Timer timerForAssetAnims;
        delegate void setPlayerCallback(bool playerMovingUp);
        delegate void setBallCallback(bool ballMovingUp, bool ballMovingLeft);
        delegate void setScoreCallback(int score);

        bool gameRunning = false;
        bool p1Moving = false;
        bool p2Moving = false;
        bool p1MovingUp = false;
        bool p2MovingUp = false;
        bool ballMovingUP = false;
        bool ballMovingLeft = false;
        int p1Score = 0;
        int p2Score = 0;
        int playSpaceCenterX;
        int playSpaceCenterY;

        //initializing
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            
            timerForAssetAnims = new System.Timers.Timer();
            timerForAssetAnims.Interval = 1;
            timerForAssetAnims.Elapsed += AssetAnimsTimerTick;
            timerForAssetAnims.AutoReset = true;
            timerForAssetAnims.Enabled = true;

            playSpaceCenterX = panelPlaySpace.Location.X + panelPlaySpace.Width / 2;
            playSpaceCenterY = panelPlaySpace.Location.Y + panelPlaySpace.Height / 2;
        }       

        //grabbing keydown inputs
        private void Form1_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                labelP1MoveUp.BackColor = Color.Red;
                p1Moving = true;
                p1MovingUp = true;
                //pictureBoxP1Paddle.Top -= panelPlaySpace.Height / 20;
            }
            if (e.KeyCode == Keys.D)
            {
                labelP1MoveDown.BackColor = Color.Red;
                p1Moving = true;
                p1MovingUp = false;
                //pictureBoxP1Paddle.Top += panelPlaySpace.Height / 20;
            }
            if (e.KeyCode == Keys.I)
            {
                labelP2MoveUp.BackColor = Color.Blue;
                p2Moving = true;
                p2MovingUp = true;
                //pictureBoxP2Paddle.Top -= panelPlaySpace.Height / 20;
            }
            if (e.KeyCode == Keys.K)
            {
                labelP2MoveDown.BackColor = Color.Blue;
                p2Moving = true;
                p2MovingUp = false;
                //pictureBoxP2Paddle.Top += panelPlaySpace.Height / 20;
            }
        }

        //grabbing keyup events
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                labelP1MoveUp.BackColor = Color.White;
                p1Moving = false;
            }
            if (e.KeyCode == Keys.D)
            {
                labelP1MoveDown.BackColor = Color.White;
                p1Moving = false;
            }
            if (e.KeyCode == Keys.I)
            {
                labelP2MoveUp.BackColor = Color.White;
                p2Moving = false;
            }
            if (e.KeyCode == Keys.K)
            {
                labelP2MoveDown.BackColor = Color.White;
                p2Moving = false;
            }

            //timerForAssetAnims = new System.Timers.Timer();
            //timerForAssetAnims.Interval = 1;
            //timerForAssetAnims.Elapsed += AssetAnimsTimerTick;
            //timerForAssetAnims.AutoReset = true;

            if (e.KeyCode == Keys.Enter)
            {
                if (gameRunning == true)
                {
                    gameRunning = false;
                    //timerForAssetAnims.Enabled = true;
                    labelEnterToStart.Text = "Press Enter to Start";
                }
                else
                {
                    gameRunning = true;
                    //timerForAssetAnims.Enabled = false;                    
                    labelEnterToStart.Text = "Press Enter Again to Pause";
                }
            }
        }

        //Timer for animating movements on screen
        private void AssetAnimsTimerTick(Object source, System.Timers.ElapsedEventArgs e)
        {
            //testing if paused
            if (gameRunning == true)
            {
                //player movements
                if (p1Moving == true)
                {
                    this.SetPlayer1MovementIfRequired(p1MovingUp);
                }

                if (p2Moving == true)
                {
                    this.SetPlayer2MovementIfRequired(p2MovingUp);                    
                }

                //Ball Movements
                this.SetBallMovementIfRequired(ballMovingUP, ballMovingLeft);

                this.SetPlayer1ScoreIfRequired(p1Score);
                this.SetPlayer2ScoreIfRequired(p2Score);
            }
        }

        //invoking methods

        //player 1 score update
        private void SetPlayer1ScoreIfRequired(int score)
        {
            if (this.labelScoreP1.InvokeRequired)
            {
                setScoreCallback d = new setScoreCallback(SetPlayer1ScoreIfRequired);
                this.Invoke(d, new object[] { score });
            }
            else
            {
                labelScoreP1.Text = p1Score.ToString();
            }
        }
        //player 2 score update
        private void SetPlayer2ScoreIfRequired(int score)
        {
            if (this.labelScoreP1.InvokeRequired)
            {
                setScoreCallback d = new setScoreCallback(SetPlayer2ScoreIfRequired);
                this.Invoke(d, new object[] { score });
            }
            else
            {
                labelScoreP2.Text = p2Score.ToString();
            }
        }

        //player 1 movements
        private void SetPlayer1MovementIfRequired(bool playerMovementUp)
        {
            if(this.pictureBoxP1Paddle.InvokeRequired)
            {
                setPlayerCallback d = new setPlayerCallback(SetPlayer1MovementIfRequired);
                this.Invoke(d, new object[] { playerMovementUp });
            }
            else
            {
                if (playerMovementUp)
                {
                    if (PictureBoxCollidingUp(pictureBoxP1Paddle) == false)
                    {
                        this.pictureBoxP1Paddle.Top -= panelPlaySpace.Height / 50;
                    }
                }
                else if (playerMovementUp == false)
                {
                    if (PictureBoxCollidingDown(pictureBoxP1Paddle) == false)
                    {
                        this.pictureBoxP1Paddle.Top += panelPlaySpace.Height / 50;
                    }
                }
            }
        }

        //player 2 movements
        private void SetPlayer2MovementIfRequired(bool playerMovementUp)
        {
            if (this.pictureBoxP1Paddle.InvokeRequired)
            {
                setPlayerCallback d = new setPlayerCallback(SetPlayer2MovementIfRequired);
                this.Invoke(d, new object[] { playerMovementUp });
            }
            else
            {
                if (playerMovementUp)
                {
                    if (PictureBoxCollidingUp(pictureBoxP2Paddle) == false)
                    {
                        this.pictureBoxP2Paddle.Top -= panelPlaySpace.Height / 50;
                    }
                }
                else if (playerMovementUp == false)
                {
                    if (PictureBoxCollidingDown(pictureBoxP2Paddle) == false)
                    {
                        this.pictureBoxP2Paddle.Top += panelPlaySpace.Height / 50;
                    }
                }
            }
        }

        //ball movements
        private void SetBallMovementIfRequired(bool ballMovementUp, bool ballMovementLeft)
        {
            if (this.pictureBoxBall.InvokeRequired)
            {
                setBallCallback d = new setBallCallback(SetBallMovementIfRequired);
                this.Invoke(d, new object[] { ballMovementUp, ballMovementLeft });
            }
            else
            {
                //Up-Down Collision Check
                if (PictureBoxCollidingDown(pictureBoxBall))
                {
                    ballMovingUP = true;
                }
                if (PictureBoxCollidingUp(pictureBoxBall))
                {
                    ballMovingUP = false;
                }


                //Up-Down Movement
                if (ballMovementUp == false)
                {
                    this.pictureBoxBall.Top += panelPlaySpace.Height / 60;
                }
                else if (ballMovementUp)
                {
                    this.pictureBoxBall.Top -= panelPlaySpace.Height / 60;                    
                }

                //paddle collision
                if(BallCollidingP1Paddle(pictureBoxBall))
                {
                    ballMovingLeft = false;
                }
                if (BallCollidingP2Paddle(pictureBoxBall))
                {
                    ballMovingLeft = true;
                }

                //Left-Right Wall Collision
                if (BallCollidingLeftWall(pictureBoxBall))
                {
                    ballMovingLeft = false;
                    pictureBoxBall.Location = new Point(playSpaceCenterX,playSpaceCenterY);
                    p1Score += 1;
                }
                if (BallCollidingRightWall(pictureBoxBall))
                {
                    ballMovingLeft = true;
                    pictureBoxBall.Location = new Point(playSpaceCenterX,playSpaceCenterY);
                    p2Score += 1;
                }

                //Left-Right Movement
                if (ballMovementLeft)
                {
                    this.pictureBoxBall.Left -= panelPlaySpace.Width / 200;
                }
                else if (ballMovementLeft == false)
                {
                    this.pictureBoxBall.Left += panelPlaySpace.Width / 200;
                }
            }
        }

        private void SetBallCollisionIfRequired(bool ballMovementUp, bool ballMovementLeft)
        {
            if (this.pictureBoxBall.InvokeRequired)
            {
                setBallCallback d = new setBallCallback(SetBallCollisionIfRequired);
                this.Invoke(d, new object[] { ballMovementUp, ballMovementLeft });
            }
            else
            {
                if (PictureBoxCollidingDown(pictureBoxBall) == false)
                {
                    ballMovingUP = true;
                }
                else if (PictureBoxCollidingDown(pictureBoxBall) == true)
                {
                    ballMovingUP= false;
                }
            }
        }

        //collision checks
        private bool PictureBoxCollidingUp(PictureBox pbox)
        {
            if (pbox.Top <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool PictureBoxCollidingDown(PictureBox pbox)
        {
            if (pbox.Location.Y + pbox.Height >= panelPlaySpace.Height)
            {                
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool BallCollidingLeftWall(PictureBox ball)
        {
            if (ball.Left <= 0)
            {
                //p1Score++;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool BallCollidingRightWall(PictureBox ball)
        {
            if (ball.Location.X + ball.Width >= panelPlaySpace.Width)
            {
                //p2Score++;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool BallCollidingP1Paddle(PictureBox ball)
        {
            if(ball.Bounds.IntersectsWith(pictureBoxP1Paddle.Bounds))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool BallCollidingP2Paddle(PictureBox ball)
        {
            if (ball.Bounds.IntersectsWith(pictureBoxP2Paddle.Bounds))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //to make sure all threads close
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

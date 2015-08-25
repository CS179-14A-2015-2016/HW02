/*
* BAll object represents the ball in Pong.
* Has changing position, speed, and angle.
* A subclass of block, thus having a draw() and run() function
*/
import java.awt.*;

public class Ball implements Block
{
	// Euclidian speed of the ball. STUB value. Change to correct.
	private final static int SPEED = 20;
	
	// Dimensions of the ball
	private final static int WIDTH = 20;
	private final static int HEIGHT = 20;
	
	// The two paddles in the game. Needed for collision checking
	Paddle leftPaddle, rightPaddle;
	
	// speed of ball in terms of displacement in X and Y; xy position of the ball
	double xVelocity, yVelocity;
	int xPos, yPos;
	long startWait;
	long lastRecord;
	
	boolean touched;
	
	/*
	* Constructor of the ball object. Keeps track of the left and right paddle
	* 
	* Paremeters:
	* Paddle left - paddle object on the left side
	* Paddle right - paddle object on the right side
	*/
	public Ball(Paddle left, Paddle right) {
		leftPaddle = left;
		rightPaddle = right;
		xPos = Runner.XDIMENSION/2;
		yPos = Runner.YDIMENSION/2;
		xVelocity = Ball.SPEED;
		yVelocity = 0;
		
		lastRecord = System.nanoTime();
		touched = false;
	}
	
	/*
	* Checks if the ball collides with any of the two paddles
	* Changes the xVelocity and yVelocity after determining a random angle
	* Returns 1 if the ball touches the right edge, and -1 if the ball touches the left edge
	*/
	public int checkCollission(){
		double angle = -1;
		// Collission check with the walls
		if((yPos<=0 && yVelocity<0) || (yPos+Ball.HEIGHT>=Runner.YDIMENSION && yVelocity>0))
			yVelocity *= -1;
		
		// Collission check with paddles
		if(!touched && xPos<=leftPaddle.xPos+Paddle.WIDTH && xPos+Ball.WIDTH>=leftPaddle.xPos && yPos+Ball.HEIGHT>=leftPaddle.yPos && yPos<=leftPaddle.yPos+Paddle.HEIGHT) // left
		{
			touched = true;
			switch(leftPaddle.state){
				case Paddle.CLIMB:
					angle =  (Math.random()*Math.PI/4) - (Math.PI/2);
					break;
				case Paddle.STAY:
					angle = (Math.random()*Math.PI/2) - (Math.PI/4);
					break;
				case Paddle.FALL:
					angle =(Math.random()*Math.PI/4) + (Math.PI/4);
					break;
			}
		}
		else if(!touched && xPos+Ball.WIDTH>=rightPaddle.xPos  && xPos+Ball.WIDTH<=rightPaddle.xPos+Paddle.WIDTH && yPos+Ball.HEIGHT>=rightPaddle.yPos && yPos<=rightPaddle.yPos+Paddle.HEIGHT)
		{
			touched = true;
			switch(rightPaddle.state){
				case Paddle.CLIMB:
					angle = (Math.random()*Math.PI/4) + (5*Math.PI/4);
					break;
				case Paddle.STAY:
					angle = (Math.random()*Math.PI/2) + (3*Math.PI/4);
					break;
				case Paddle.FALL:
					angle = (Math.random()*Math.PI/4) + (Math.PI/2);
					break;
			}
		}
		else
			touched = false;
		
		if(xPos<=0) // hits left edge
			return -1;
		else if(xPos+Ball.WIDTH>=Runner.XDIMENSION) // hits right edge
			return 1;
			
		if(angle==-1)
			return 0;
		
		xVelocity = (int)(Math.cos(angle)*Ball.SPEED);
		yVelocity = (int)(Math.sin(angle)*Ball.SPEED);
		return 0;
	}
	
	public void reset(){
		reset(Paddle.LEFT);
	}
	
	public void reset(int winner)
	{
		xPos = Runner.XDIMENSION/2;
		yPos = Runner.YDIMENSION/2;
		yVelocity = 0;
		if(winner==Paddle.LEFT)
			xVelocity = Ball.SPEED;
		else
			xVelocity = -1*Ball.SPEED;
		
		lastRecord = System.nanoTime();
		startWait = 500000000l;
	}
	
	/*
	* Processing of the ball during runtime. 
	* Computes the x and y displacement according to angle and speed.
	*/
	public void run(){
		if(startWait>0){
			long prev = lastRecord;
			lastRecord = System.nanoTime();
			long actualTime = lastRecord-prev;
			startWait -= actualTime;
			return;
		}
		xPos += xVelocity;
		yPos += yVelocity;
	}
	
	/*
	* Draws the graphics of the paddle
	* 
	* Parameters:
	* Graphics g - the Graphics parameter passed down by the paint() function of the Canvas
	*/
	public void draw(Graphics g) {
		g.setColor(Color.ORANGE);
		g.fillOval(xPos, yPos, Ball.WIDTH, Ball.HEIGHT);
	}
}
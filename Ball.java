/*
* BAll object represents the ball in Pong.
* Has changing position, speed, and angle.
* A subclass of block, thus having a draw() and run() function
*/
import java.awt.*;

public class Ball implements Block
{
	// Euclidian speed of the ball. STUB value. Change to correct.
	private final static int SPEED = 10;
	
	// Dimensions of the ball
	private final static int WIDTH = 10;
	private final static int HEIGHT = 10;
	
	// The two paddles in the game. Needed for collision checking
	Paddle leftPaddle, rightPaddle;
	
	// speed of ball in terms of displacement in X and Y; xy position of the ball
	double xVelocity, yVelocity;
	int xPos, yPos;
	
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
		xVelocity = 10;
		yVelocity = 0;
	}
	
	/*
	* Checks if the ball collides with any of the two paddles
	* Changes the xVelocity and yVelocity after determining a random angle
	* Returns 1 if the ball touches the right edge, and -1 if the ball touches the left edge
	*/
	public int checkCollission(){
		double angle = 0;
		// Collission check with the walls
		if((yPos<=0 && yVelocity<0) || (yPos+Ball.HEIGHT>=Runner.YDIMENSION && yVelocity>0))
			yVelocity *= -1;
		
		// Collission check with paddles
		if(xPos<=leftPaddle.xPos+Paddle.WIDTH && yPos>=leftPaddle.yPos && yPos<=leftPaddle.yPos+Paddle.HEIGHT) // left
			angle = (Math.random()*2*Math.PI) - (Math.PI/2);
		else if(xPos+Ball.WIDTH>=rightPaddle.xPos && yPos>=rightPaddle.yPos && yPos<=leftPaddle.yPos+Paddle.HEIGHT)
			angle = (Math.random()*2*Math.PI) + (Math.PI/2);
		else if(xPos<=0) // hits left edge
			return -1;
		else if(xPos+Ball.WIDTH>=Runner.XDIMENSION) // hits right edge
			return 1;
		xVelocity = (int)(Math.cos(angle)*Ball.SPEED);
		yVelocity = (int)(Math.sin(angle)*Ball.SPEED);
		return 0;
	}
	
	/*
	* Processing of the ball during runtime. 
	* Computes the x and y displacement according to angle and speed.
	*/
	public void run(){
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
		g.setColor(Color.GREEN);
		g.fillOval(xPos, yPos, Ball.WIDTH, Ball.HEIGHT);
	}
}
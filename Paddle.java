/*
* Paddle represents the paddle controlled by two players
* Has a changing y position but fixed x position.
* A subclass of block, thus having a draw() and run() function
*/
import java.awt.*;

public class Paddle implements Block
{
	// Sides. LEFT is the key used if a paddle is the left one, and RIGHT if it is the right one.
	public static final int LEFT = 0;
	public static final int RIGHT = 1;
	
	// Width and height. The dimensions of the paddle. Stub values. Change to correct. 
	public static final int WIDTH = 25;
	public static final int HEIGHT = 150;
	
	// State. CLIMB is the key for going up; FALL is the key for going down; STAY is the key for stopping
	public static final int CLIMB = -1;
	public static final int STAY = 0;
	public static final int FALL = 1;
	
	// X-Coordinates. LX is the fixed x position for the left paddle and RX is the fixed position of the right paddle.
	// Y is the y position of both paddles.
	// SPEED is the speed of the paddle.
	// DEVELOPERS FIX THIS AS NECESSARY. THE VALUES ARE JUST STUBS.
	private static final int LX = 25;
	private static final int RX = Runner.XDIMENSION-WIDTH-25; 
	private static final int Y = Runner.YDIMENSION/2-(HEIGHT/2);
	private static final int SPEED = 10;
	
	// player tells which side this paddle is; state tells if the paddle is climbing, falling, or staying in place.
	private int player, state;
	
	// x-y coordinates of the paddle on the canvas
	int xPos, yPos;
	int score;
	/*
	* Constructor for Paddle object.
	* 
	* Parameters:
	* int side = tells on which side the Paddle will be.
	*/
	public Paddle(int side){
		player = side;
		if(side==0)
			xPos = LX;
		else
			xPos = RX;
		
		state = Paddle.STAY;
		yPos = Y;
		score = 0;
	}
	
	public void reset(){
		if(player==0)
			xPos = LX;
		else
			xPos = RX;
		
		state = Paddle.STAY;
		yPos = Y;
		score = 0;
	}
	
	/*
	* Sets the state of motion of the Paddle.
	* 
	* Parameters:
	* int state = can only either be equal to CLIMB, STAY, or FALL
	*/
	public void setMovement(int state){
		this.state = state;
	}
	
	/*
	* Processing of this Paddle during runtime.
	* Changes the y-Position of the paddle according to its state.
	*/
	public void run(){
		yPos += Paddle.SPEED*state;
		if(yPos<0)
			yPos = 0;
		else if(yPos+Paddle.HEIGHT>Runner.YDIMENSION)
			yPos = Runner.YDIMENSION-Paddle.HEIGHT;
	}
	
	/*
	* Draws the graphics of the paddle
	* 
	* Parameters:
	* Graphics g - the Graphics parameter passed down by the paint() function of the Canvas
	*/
	public void draw(Graphics g) {
		g.setColor(Color.BLUE);
		g.fillRect(xPos, yPos, Paddle.WIDTH, Paddle.HEIGHT);
		g.setColor(Color.WHITE);
		g.drawString(""+score, xPos, yPos+(Paddle.HEIGHT/2));
	}
	
	public void score(){
		score++;
	}
}
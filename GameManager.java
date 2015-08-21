/*
* GameManager manages the user inputs and game processes.
* Has a list of Block objects that has the method run() and draw().
* Has a run() and draw() function that acts as the main loop, and calls the run() and draw() method of all Block objects.
* Should handle the scoring, timing, and declaring the winner.
*/

import java.awt.*;

public class GameManager extends Canvas
{ 
	Block[] blocks;
	int scoreL, scoreR;
	
	
	public GameManager(){
		blocks = new Block[3];
		blocks[0] = new Paddle(Paddle.LEFT);
		blocks[1] = new Paddle(Paddle.RIGHT);
		blocks[2] = new Ball((Paddle) blocks[0], (Paddle) blocks[1]);
	}
	
	/*	
	*	Processing loop of the game.
	*/
	public void run(){
		while(true){
			
			int status = ((Ball) blocks[2]).checkCollission();
			if(status==1)
				; // left paddle scores
			else if (status==-1)
				; // right paddle scores
			
			// call the run method of each block
			for(Block b: blocks)
				b.run();
		}
	}
	
	/*	
	*	Renders the graphics of the game. Calls the draw() functions of each block.
	*
	*	Parameters:
	*	Graphics g - the Graphics object that handles the drawing of objects in the canvas
	*/
	public void paint(Graphics g){
		while(true){
			for(Block b: blocks)
				b.draw(g);
		}
	}
	
	// insert sensing functions here
}
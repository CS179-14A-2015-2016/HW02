/*
* GameManager manages the user inputs and game processes.
* Has a list of Block objects that has the method run() and draw().
* Has a run() and draw() function that acts as the main loop, and calls the run() and draw() method of all Block objects.
* Should handle the scoring, timing, and declaring the winner.
*/

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class GameManager extends Canvas implements KeyListener
{ 
	int winScore;
	Block[] blocks;
	boolean onProgress;
	
	public GameManager(){
		blocks = new Block[3];
		blocks[0] = new Paddle(Paddle.LEFT);
		blocks[1] = new Paddle(Paddle.RIGHT);
		blocks[2] = new Ball((Paddle) blocks[0], (Paddle) blocks[1]);
		
		setSize(Runner.XDIMENSION, Runner.YDIMENSION);
        setBackground(Color.BLACK);
		addKeyListener(this);
		onProgress = false;
	}
	
	public void startGame(int i){
		for(Block b: blocks)
			b.reset();
		winScore = i;
		onProgress = true;
	}
	
	/*	
	*	Processing loop of the game.
	*/
	public void run(){
			int status = ((Ball) blocks[2]).checkCollission();
			if(status==1)
			{
				((Paddle)blocks[0]).score();
				((Ball)blocks[2]).reset(Paddle.LEFT);
				if(((Paddle)blocks[0]).score==winScore)
				{
					JOptionPane.showMessageDialog(null, "PLAYER LEFT wins!");
					onProgress = false;
				}
			}
			else if (status==-1)
			{
				((Paddle)blocks[1]).score();
				((Ball)blocks[2]).reset(Paddle.RIGHT);
				if(((Paddle)blocks[1]).score==winScore)
				{
					JOptionPane.showMessageDialog(null, "PLAYER RIGHT wins!");
					onProgress = false;
				}
			}
			
			// call the run method of each block
			for(Block b: blocks)
				b.run();
			repaint();
	}
	
	/*	
	*	Renders the graphics of the game. Calls the draw() functions of each block.
	*
	*	Parameters:
	*	Graphics g - the Graphics object that handles the drawing of objects in the canvas
	*/
	public void paint(Graphics g){
        Image buffer = createImage(Runner.XDIMENSION, Runner.YDIMENSION);
        Graphics gg = buffer.getGraphics();
        for(Block b: blocks)
			b.draw(gg);
        g.drawImage(buffer, 0 , 0, this);
	}
	
    public void update(Graphics g)
    {
        paint(g);
    }
	
	public void keyPressed(KeyEvent e){
		if(e.getKeyCode()==KeyEvent.VK_DOWN)
			((Paddle)blocks[1]).setMovement(Paddle.FALL);
		else if(e.getKeyCode()==KeyEvent.VK_UP)
			((Paddle)blocks[1]).setMovement(Paddle.CLIMB);
		
		if(e.getKeyCode()==KeyEvent.VK_S)
			((Paddle)blocks[0]).setMovement(Paddle.FALL);
		else if(e.getKeyCode()==KeyEvent.VK_W)
			((Paddle)blocks[0]).setMovement(Paddle.CLIMB);
	}
	
	public void keyReleased(KeyEvent e){
		if(e.getKeyCode()==KeyEvent.VK_DOWN || e.getKeyCode()==KeyEvent.VK_UP)
			((Paddle)blocks[1]).setMovement(Paddle.STAY);
		
		if(e.getKeyCode()==KeyEvent.VK_S || e.getKeyCode()==KeyEvent.VK_W)
			((Paddle)blocks[0]).setMovement(Paddle.STAY);
	}
    
    public void keyTyped(KeyEvent e){
    }
    
    public void keyClicked(KeyEvent e){
    }
}
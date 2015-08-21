/*
* Runner serves as the frame/window of the game.
* Has an instance of GameManager to deal with input processing.
* It also manages the rendering of the game through its canvas.
* Contains the main method.
*/
import java.awt.*;
import javax.swing.*;

public class Runner extends JFrame
{
	// XDIMENSION and YDIMENSION are the xy dimension of the canvas, not the frame itself
	// Stub values. Change to correct.
	final static int XDIMENSION = 800;
	final static int YDIMENSION = 600;
	
	// Manages game processes
	GameManager gm;
	
	public Runner(){
		gm = new GameManager();
        setVisible(true);
        setResizable(false);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        add(gm);
		pack();
	}
	
	public static void main(String[] args) throws InterruptedException{
		Runner runner = new Runner();
		while(true)
		{
			runner.gm.run();
			Thread.sleep(30);
		}
	}
}
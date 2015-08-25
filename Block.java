/*
* An interface to group all visible and interacting objects in the game.
* Has a run and a draw function.
*/
import java.awt.*; 
public interface Block
{
	public void run();
	public void draw(Graphics g);
	public void reset();
}
import java.awt.Color;
import java.awt.Graphics;

public abstract class Arthropods implements IAnimal {
	protected int startPosX;

	protected int startPosY;

	public int Weight;
	public int MaxSpeed;

	public Color ColorBody;

	protected abstract void setMaxSpeed(int m);

	public abstract int getMaxSpeed();

	protected abstract void setWeight(int w);

	public abstract int getWeight();

	public abstract void drawSpiderwolf(Graphics g);

	public void setPosition(int x, int y) {
		startPosX = x;
		startPosY = y;
	}

}

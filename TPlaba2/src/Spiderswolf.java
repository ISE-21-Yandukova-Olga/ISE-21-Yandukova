import java.awt.Color;
import java.awt.Graphics;

public class Spiderswolf extends Arthropods {
	public Spiderswolf(int weight, int maxspeed, Color color) {
		this.Weight = weight;
		this.MaxSpeed = maxspeed;

		this.ColorBody = color;

		startPosX = 100;
		startPosY = 100;
	}

	protected void setWeight(int w) {
		if (w > 0 && w < 34)
			super.Weight = w;
		else
			super.Weight = 15;
	}

	public int getWeight() {
		return super.Weight;
	}

	protected void setMaxSpeed(int p) {
		if (p > 0 && p < 100)
			super.MaxSpeed = p;
		else
			super.MaxSpeed = 30;
	}

	public int getMaxSpeed() {
		return super.MaxSpeed;
	}

	public void drawSpiderwolf(Graphics g) {
		drawSpider(g);
	}

	protected void drawSpider(Graphics g) {
		g.setColor(ColorBody);
		g.fillOval(startPosX + 50, startPosY + 8,  30, 30);
		g.fillOval(startPosX + 45, startPosY + 30,  40,  40);

		g.drawLine(startPosX + 35, startPosY + 30, startPosX +  50,startPosY +  40);
		g.drawLine(startPosX + 30, startPosY + 45, startPosX +  50, startPosY + 50);
		g.drawLine(startPosX + 35, startPosY + 65, startPosX + 50, startPosY + 60);
		g.drawLine(startPosX + 25, startPosY + 40, startPosX +  35, startPosY + 30);
		g.drawLine(startPosX + 20, startPosY + 55, startPosX +  30,startPosY +  45);
		g.drawLine(startPosX + 25, startPosY + 80,startPosX + 35, startPosY + 65);
		g.drawLine(startPosX + 40, startPosY + 17, startPosX +  53, startPosY + 31);
		g.drawLine(startPosX + 50, startPosY + 7, startPosX + 40, startPosY + 17);
		g.drawLine(startPosX + 75, startPosY + 34, startPosX +  95,startPosY + 17);
		g.drawLine(startPosX + 80, startPosY + 40,startPosX +  95, startPosY + 30);
		g.drawLine(startPosX + 95, startPosY + 17, startPosX +  85, startPosY + 7);
		g.drawLine(startPosX + 95, startPosY + 30, startPosX +  105, startPosY + 42);
		g.drawLine(startPosX + 80, startPosY + 53, startPosX + 100,startPosY +  47);
		g.drawLine(startPosX + 100, startPosY + 47,startPosX + 110, startPosY + 55);
		g.drawLine(startPosX + 80, startPosY + 60,startPosX +  96, startPosY + 65);
		g.drawLine(startPosX + 96, startPosY + 65, startPosX + 103, startPosY + 80);
	}

	public void moveSpiderwolf(Graphics g) {
		startPosX += MaxSpeed * 50 / (int) Weight;
		drawSpiderwolf(g);
	}
}

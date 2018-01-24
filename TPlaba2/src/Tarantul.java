import java.awt.Color;
import java.awt.Graphics;

public class Tarantul extends Spiderswolf {
	private boolean uzor;
	private Color dopcolor;

	public Tarantul(int weight, int maxspeed, Color color, boolean uzor,
			Color dopcolor) {
		super(weight, maxspeed, color);
		this.uzor = uzor;
		this.dopcolor = dopcolor;
	}

	protected void drawSpider (Graphics g) {
		super.drawSpider(g);

		if (uzor) {
			g.setColor(dopcolor);
			g.drawOval(startPosX + 50, startPosY + 35, 30, 30);
			g.drawOval(startPosX + 55, startPosY + 40, 20, 20);
			g.drawOval(startPosX + 60, startPosY + 45, 10, 10);

			g.fillOval(startPosX + 55, startPosY + 12, 10, 10);
			g.fillOval(startPosX + 65, startPosY + 12, 10, 10);
		}

	}

}

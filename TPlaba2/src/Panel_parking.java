import java.awt.Graphics;

import javax.swing.JPanel;

public class Panel_parking extends JPanel {

	
	
	Parking p;

	public Panel_parking(Parking parking) {
		this.p = parking;
	}

	public void paint(Graphics g) {
		g.clearRect(0, 0, this.getWidth(), this.getHeight());
		p.Draw(g, this.getWidth(), this.getHeight());
	}

}
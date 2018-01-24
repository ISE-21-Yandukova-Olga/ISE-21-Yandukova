import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;


import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;


;

public class Main {

	private JFrame frame;
	Parking parking;

	private JTextField textField;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main window = new Main();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Main() {
		parking = new Parking();

		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(0, 0, 800, 500);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new Panel_parking(parking);
		panel.setBounds(0, 0, 596, 500);
		frame.getContentPane().add(panel);

		JButton btnNewButtonSpiderswolf = new JButton(
				"\u043F\u0430\u0443\u043A");
		btnNewButtonSpiderswolf.setBounds(685, 11, 89, 23);
		btnNewButtonSpiderswolf.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color colorDialog = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (colorDialog != null) {
					IAnimal ianimal = new Spiderswolf(15, 30, colorDialog);
					int place = parking.PutIAnimalInShowcase(ianimal);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваше место:" + place);
				}

			}
		});
		frame.getContentPane().add(btnNewButtonSpiderswolf);

		JButton btnNewButtonTarantul = new JButton(
				"\u0442\u0430\u0440\u0430\u043D\u0442\u0443\u043B\r\n");
		btnNewButtonTarantul.setBounds(685, 42, 89, 23);
		btnNewButtonTarantul.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null,
							"JColorChooser Sample", null);
					if (colorDialog != null) {
						IAnimal ianimal = new Tarantul(15, 30, colorDialog1,
								true, colorDialog);
						int place = parking.PutIAnimalInShowcase(ianimal);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "Ваше место:"
								+ place);
					}
				}
			}
		});
		frame.getContentPane().add(btnNewButtonTarantul);

		

		textField = new JTextField();
		textField.setBounds(720, 89, 54, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);

		JLabel label = new JLabel("\u043C\u0435\u0441\u0442\u043E");
		label.setBounds(664, 92, 46, 14);
		frame.getContentPane().add(label);

		JPanel panel_1 = new JPanel();
		panel_1.setBounds(605, 215, 169, 235);
		frame.getContentPane().add(panel_1);
	
	JButton btnNewButton = new JButton(
			"\u0437\u0430\u0431\u0440\u0430\u0442\u044C");
	btnNewButton.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent arg0) {
			if (checkPlace(textField.getText())) {
				IAnimal ianimal = parking.GetIAnimalInShowcase(Integer
						.parseInt(textField.getText()));
				Graphics gr = panel_1.getGraphics();
				gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
				ianimal.setPosition(5, 5);
				ianimal.drawSpiderwolf(gr);
				panel.repaint();
			}

		}
	});
	btnNewButton.setBounds(653, 145, 89, 28);
	frame.getContentPane().add(btnNewButton);
	}

	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}
		if (Integer.parseInt(str) > 20)
			return false;

		return true;
	}

}

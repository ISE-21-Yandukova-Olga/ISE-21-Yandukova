import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;

import javax.swing.JColorChooser;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JCheckBox;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.Font;

;

public class Main {

	private JFrame frame;
	private JTextField textves;
	private JTextField textspeed;
	Color color;
	Color dopcolor;
	int weight;
	int maxspeed;

	boolean uzor;

	private IAnimal inter;

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
		color = Color.BLACK;
		dopcolor = Color.RED;
		weight = 15;
		maxspeed = 30;

		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 564, 433);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new JPanel();
		panel.setBounds(0, 0, 548, 212);
		frame.getContentPane().add(panel);

		JLabel label = new JLabel("\u0432\u0435\u0441");
		label.setBounds(9, 238, 34, 14);
		frame.getContentPane().add(label);

		JLabel label_1 = new JLabel(
				"\u0441\u043A\u043E\u0440\u043E\u0441\u0442\u044C");
		label_1.setBounds(9, 263, 59, 14);
		frame.getContentPane().add(label_1);

		JLabel label_2 = new JLabel("\u0446\u0432\u0435\u0442");
		label_2.setBounds(197, 241, 46, 14);
		frame.getContentPane().add(label_2);

		JLabel label_3 = new JLabel(
				"\u0434\u043E\u043F. \u0446\u0432\u0435\u0442");
		label_3.setBounds(178, 266, 59, 14);
		frame.getContentPane().add(label_3);

		JLabel label_4 = new JLabel(
				"\u044F\u0434\u043E\u0432\u0438\u0442\u043E\u0441\u0442\u044C");
		label_4.setBounds(302, 272, 69, 14);
		frame.getContentPane().add(label_4);

		textves = new JTextField();
		textves.setBounds(74, 235, 46, 20);
		frame.getContentPane().add(textves);
		textves.setColumns(10);

		textspeed = new JTextField();
		textspeed.setBounds(72, 260, 48, 20);
		frame.getContentPane().add(textspeed);
		textspeed.setColumns(10);

		JButton btnNewButtoncolor = new JButton("");
		btnNewButtoncolor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color initialBackground = btnNewButtoncolor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnNewButtoncolor.setForeground(foreground);
				}
				color = foreground;
			}
		});
		btnNewButtoncolor.setForeground(new Color(0, 0, 0));
		btnNewButtoncolor.setBackground(new Color(0, 0, 0));
		btnNewButtoncolor.setFont(new Font("Times New Roman", Font.PLAIN, 11));
		btnNewButtoncolor.setBounds(246, 238, 46, 23);
		frame.getContentPane().add(btnNewButtoncolor);

		JButton btnNewButtondopcolor = new JButton("");
		btnNewButtondopcolor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color initialBackground = btnNewButtondopcolor.getForeground();
				Color foreground = JColorChooser.showDialog(null,
						"JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnNewButtondopcolor.setForeground(foreground);
				}
				dopcolor = foreground;
			}
		});
		btnNewButtondopcolor.setForeground(new Color(255, 0, 0));
		btnNewButtondopcolor.setBackground(new Color(255, 0, 0));
		btnNewButtondopcolor.setBounds(246, 263, 46, 23);
		frame.getContentPane().add(btnNewButtondopcolor);

		JCheckBox chckbxNewCheckBox = new JCheckBox("");
		chckbxNewCheckBox.setBounds(322, 254, 46, 23);
		frame.getContentPane().add(chckbxNewCheckBox);

		JButton btnNewButtondvig = new JButton("\u0434\u0432\u0438\u0436\u0435\u043D\u0438\u0435");
		btnNewButtondvig.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (inter != null) {

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.moveSpiderwolf(gr);

				}
			}
		});
		btnNewButtondvig.setBounds(227, 313, 97, 23);
		frame.getContentPane().add(btnNewButtondvig);

		JButton btnNewButtonSpiderswolf = new JButton(
				"\u043F\u0430\u0443\u043A");
		btnNewButtonSpiderswolf.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (checkFields()) {
					inter = new Spiderswolf(weight, maxspeed, color);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawSpiderwolf(gr);
				}
			}
		});
		btnNewButtonSpiderswolf.setBounds(402, 234, 89, 23);
		frame.getContentPane().add(btnNewButtonSpiderswolf);

		JButton btnNewButtonTarantul = new JButton(
				"\u0442\u0430\u0440\u0430\u043D\u0442\u0443\u043B\r\n");
		btnNewButtonTarantul.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					uzor = chckbxNewCheckBox.isSelected();
					inter = new Tarantul(weight, maxspeed, color, uzor,
							dopcolor);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawSpiderwolf(gr);
				}
			}
		});
		btnNewButtonTarantul.setBounds(402, 263, 89, 23);
		frame.getContentPane().add(btnNewButtonTarantul);
	}

	private boolean checkParse(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		return true;
	}

	private boolean checkFields() {
		if (checkParse(textves.getText())) {
			weight = Integer.parseInt(textves.getText());
		} else
			return false;

		if (checkParse(textspeed.getText())) {
			maxspeed = Integer.parseInt(textspeed.getText());
		} else
			return false;

		return true;
	}
}

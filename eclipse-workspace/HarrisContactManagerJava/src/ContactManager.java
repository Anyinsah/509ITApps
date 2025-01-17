import java.awt.EventQueue;
import java.awt.Window;

import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

/*
 * CODE COMMENTD BY JOSIAH ANYINSAH-BONDZIE
 * DUPLICATIVE/SAME CODE WILL NOT BE RECOMMENTED ON
 */

public class ContactManager {

	private JFrame menuFrame;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ContactManager window = new ContactManager();
					window.menuFrame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public ContactManager() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		menuFrame = new JFrame();
		menuFrame.setTitle("Harris & Sons Contact Manager");
		menuFrame.setBounds(100, 100, 450, 300);
		menuFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		menuFrame.getContentPane().setLayout(null);
		
		JButton btnPersonalContacts = new JButton("Personal Contacts");
		btnPersonalContacts.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnPersonalContacts.setBounds(65, 126, 126, 23);
		menuFrame.getContentPane().add(btnPersonalContacts);
		
		JButton btnBusinessContacts = new JButton("Business Contacts");
		btnBusinessContacts.setBounds(230, 126, 135, 23);
		menuFrame.getContentPane().add(btnBusinessContacts);
		
		// Event Handlers
		//When the PersonalContacts button is clicked it loads the personal contact jframe 
		btnPersonalContacts.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				PersonalEditor pEditor = new PersonalEditor();
				pEditor.setVisible(true);
				menuFrame.dispose();
			}
		});
		// When the BusinessContacts button is clicked it loads the business contact jframe
		btnBusinessContacts.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				BusinessEditor bEditor = new BusinessEditor();
				bEditor.setVisible(true);
				menuFrame.dispose();
			}
		});
		
	}
	
	
	
}


import java.awt.BorderLayout;
import java.awt.EventQueue;

/*
 * CODE COMMENTD BY JOSIAH ANYINSAH-BONDZIE
 * DUPLICATIVE/SAME CODE WILL NOT BE RECOMMENTED ON
 */

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import net.proteanit.sql.DbUtils;

import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.JScrollBar;
import javax.swing.JScrollPane;
import java.awt.Color;
import java.awt.Component;

import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.LayoutStyle.ComponentPlacement;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class PersonalEditor extends JFrame {

	private JPanel contentPane;
	private JTextField fname_textfield;
	private JTextField pnumber_textfield;
	private JTextField sname_textfield;
	private JTextField faddress_textfield;
	private JTextField email_textfield;
	private JTextField saddress_textfield;
	private JTextField cnumber_textfield;
	private JTextField city_textfield;
	private JTextField postcode_textfield;
	private JTable pContactsDataTable;
	


	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PersonalEditor frame = new PersonalEditor();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public PersonalEditor() {
		
		DbConn DbConn = new DbConn();
		
		addWindowListener(new WindowAdapter() {
			// Event handler for when form loads.
			public void windowOpened(WindowEvent e) 
			{
				/*
				 * When the window loads the getBContacts method will be called instantly
				 * Meaning that the database can be read without clicking refresh
				 */
				pContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getPContacts()));
			}
		});
		setTitle("Personal Contact Editor");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 896, 386);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		
		JScrollPane scrollPane = new JScrollPane();

		
		
		fname_textfield = new JTextField();
		fname_textfield.setEnabled(false);
		fname_textfield.setColumns(10);
		
		pnumber_textfield = new JTextField();
		pnumber_textfield.setEnabled(false);
		pnumber_textfield.setColumns(10);
		
		sname_textfield = new JTextField();
		sname_textfield.setEnabled(false);
		sname_textfield.setColumns(10);
		
		faddress_textfield = new JTextField();
		faddress_textfield.setEnabled(false);
		faddress_textfield.setColumns(10);
		
		email_textfield = new JTextField();
		email_textfield.setEnabled(false);
		email_textfield.setColumns(10);
		
		saddress_textfield = new JTextField();
		saddress_textfield.setEnabled(false);
		saddress_textfield.setColumns(10);
		
		cnumber_textfield = new JTextField();
		cnumber_textfield.setEnabled(false);
		cnumber_textfield.setColumns(10);
		
		JLabel fname_label = new JLabel("First Name");
		
		JLabel sname_label = new JLabel("Second Name");
		
		JLabel email_label = new JLabel("Email");
		
		JLabel pnumber_label = new JLabel("Personal Number");
		
		JLabel faddress_label = new JLabel("Address 1");
		
		JLabel saddress_label = new JLabel("Address 2");
		
		JLabel city_label = new JLabel("City");
		
		JLabel cnumber_label = new JLabel("Contact Number");
		
		
		city_textfield = new JTextField();
		city_textfield.setEnabled(false);
		city_textfield.setColumns(10);
		
		JLabel postcode_label = new JLabel("Post Code");
		
		postcode_textfield = new JTextField();
		postcode_textfield.setEnabled(false);
		postcode_textfield.setColumns(10);
		
		JButton btnDelete = new JButton("Delete ");
		JButton btnSaveSelected = new JButton("Save Selected");
		btnSaveSelected.setEnabled(false);
		JButton btnSaveNew = new JButton("Save New");
		
		btnSaveNew.setEnabled(false);
		JButton btnUpdateSelected = new JButton("Update Selected");
		
		JButton btnAddNew = new JButton("Add New");
		
		JButton btnRefresh = new JButton("Refresh");
		pContactsDataTable = new JTable();
		
		// Event Handlers for Buttons and Data Table
		
		pContactsDataTable.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				/*
				 * When the datatable is clicked it will set the textfield of the textboxes to the selected row and column 
				 * Corresponding to the data of that textbox. e.g Fname @ column 1
				 */
				fname_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 1).toString());
				sname_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 2).toString());
				email_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 3).toString());
				cnumber_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 4).toString());
				pnumber_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 5).toString());
				faddress_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 6).toString());
				saddress_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 7).toString());
				city_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 8).toString());
				postcode_textfield.setText(pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 9).toString());
				
			}
		});
		
		
		
		
		btnRefresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				// Refreshes the database by just calling the getPContacts() method again.
				
				pContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getPContacts()));
				
			}
		});
		
		btnAddNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				/*
				 * This sets the properties of the buttons and textfields in the application.
				 * When add new is clicked, all buttons except save new and refresh will be disabled.
				 * All the text-fields are enabled and cleared.
				 */
				btnAddNew.setEnabled(false);
				btnSaveNew.setEnabled(true);
				btnUpdateSelected.setEnabled(false);
				btnDelete.setEnabled(false);
				btnSaveSelected.setEnabled(false);
				fname_textfield.setEnabled(true);
				sname_textfield.setEnabled(true);
				email_textfield.setEnabled(true);
				cnumber_textfield.setEnabled(true);
				pnumber_textfield.setEnabled(true);
				faddress_textfield.setEnabled(true);
				saddress_textfield.setEnabled(true);
				city_textfield.setEnabled(true);
				postcode_textfield.setEnabled(true);
				fname_textfield.setText("");
				sname_textfield.setText("");
				email_textfield.setText("");
				cnumber_textfield.setText("");
				pnumber_textfield.setText("");
				faddress_textfield.setText("");
				saddress_textfield.setText("");
				city_textfield.setText("");
				postcode_textfield.setText("");
				
				
				

			}
		});
		
		btnSaveNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				/*
				 * When save new is clicked, all buttons will be re enabled except save new and save selected
				 */
				
				btnAddNew.setEnabled(true);
				btnSaveNew.setEnabled(false);
				btnDelete.setEnabled(true);
				btnUpdateSelected.setEnabled(true);
				btnSaveSelected.setEnabled(false);
				
	

				/*
				 * Set the string of the paramaters used in the inserPContacts to the text inside the textfield
				 * of each textbox.
				 */
				
				String firstName = fname_textfield.getText();
				String lastName = sname_textfield.getText();
				String cEmail = email_textfield.getText();
				String cNumber = cnumber_textfield.getText();
				String pNumber = pnumber_textfield.getText();
				String fAddress = faddress_textfield.getText();
				String sAddress = saddress_textfield.getText();
				String city = city_textfield.getText();
				String postcode = postcode_textfield.getText();
				
				/*
				 * We call the method insertPContacts and and pass through the  necessary paramaters.
				 */
				
				DbConn.insertPContacts(firstName,
						lastName, 
						cEmail, 
						cNumber, 
						pNumber, 
						fAddress, 
						sAddress, 
						city, 
						postcode);
				
				/*
				 * The textfields are disabled
				 */
				
				fname_textfield.setEnabled(false);
				sname_textfield.setEnabled(false);
				email_textfield.setEnabled(false);
				cnumber_textfield.setEnabled(false);
				pnumber_textfield.setEnabled(false);
				faddress_textfield.setEnabled(false);
				saddress_textfield.setEnabled(false);
				city_textfield.setEnabled(false);
				postcode_textfield.setEnabled(false);
				pContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getPContacts())); // refresh database
			
			}
			

		});
		
		btnUpdateSelected.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				
				btnUpdateSelected.setEnabled(false);
				btnAddNew.setEnabled(false);
				btnSaveNew.setEnabled(false);
				btnDelete.setEnabled(false);
				btnSaveSelected.setEnabled(true);
				
				fname_textfield.setEnabled(true);
				sname_textfield.setEnabled(true);
				email_textfield.setEnabled(true);
				cnumber_textfield.setEnabled(true);
				pnumber_textfield.setEnabled(true);
				faddress_textfield.setEnabled(true);
				saddress_textfield.setEnabled(true);
				city_textfield.setEnabled(true);
				postcode_textfield.setEnabled(true);
			}
		});
		
		btnSaveSelected.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				/*
				 * The update selected is similar to the inserPContacts method
				 * Only now that we pass through the ID as the first paramater.
				 * We disable the irrelevant buttons during this process again.
				 */
				btnAddNew.setEnabled(true);
				btnDelete.setEnabled(true);
				btnUpdateSelected.setEnabled(true);
				btnSaveSelected.setEnabled(false);
				btnSaveNew.setEnabled(false);
				
				/*
				 * Declare string variables which we set the position of the row and column for each individual data.
				 * So again, we get the selected row from the datagrid and set the column position to the relevant information.
				 * E.g city at column 9
				 * ID becomes the first position indexed at 0.
				 */
				String firstName = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 1).toString();
				String lastName = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 2).toString();
				String cEmail = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 3).toString();
				String cNumber = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 4).toString();
				String pNumber = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 5).toString();
				String fAddress = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 6).toString();
				String sAddress = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 7).toString();
				String city = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 8).toString();
				String postcode = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 9).toString();
				String id = pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 0).toString();
				
				/*
				 * We set the information to the text in the textfield
				 */
				firstName = fname_textfield.getText();
				lastName = sname_textfield.getText();
				cEmail = email_textfield.getText();
				cNumber = cnumber_textfield.getText();
				pNumber = pnumber_textfield.getText();
				fAddress = faddress_textfield.getText();
				sAddress = saddress_textfield.getText();
				city = city_textfield.getText();
				postcode = postcode_textfield.getText();
				
				// We pass through the paramaters into the method.
				DbConn.updatePContacts(
						firstName, 
						lastName, 
						cEmail, 
						cNumber, 
						pNumber, 
						fAddress, 
						sAddress, 
						city, 
						postcode, 
						id);
				/*
				 * The properties are then set back to its relevant positions.
				 */
				fname_textfield.setEnabled(false);
				sname_textfield.setEnabled(false);
				email_textfield.setEnabled(false);
				cnumber_textfield.setEnabled(false);
				pnumber_textfield.setEnabled(false);
				faddress_textfield.setEnabled(false);
				saddress_textfield.setEnabled(false);
				city_textfield.setEnabled(false);
				postcode_textfield.setEnabled(false);
				pContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getPContacts()));
				
				/*
				 * The text in the textfields are clear.
				 */
				fname_textfield.setText("");
				sname_textfield.setText("");
				email_textfield.setText("");
				cnumber_textfield.setText("");
				pnumber_textfield.setText("");
				faddress_textfield.setText("");
				saddress_textfield.setText("");
				city_textfield.setText("");
				postcode_textfield.setText("");
			}
		});
		
		btnDelete.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				/*
				 * Thie process is the same as the last two but we use a joption frame and a conditional statement
				 * that allows us to prompt the user with a choice to actually delete the data.
				 */
				Object[] options = {"Yes","No"};
				/*
				 * We make an array called options and store strings yes andno
				 * We create an int variable called result and assign into to a JOptionPane, show option dialog
				 * which then we pass through the properties we want on that dialog including the options
				 * from the options array.
				 */
				int result = JOptionPane.showOptionDialog(null, "Are you sure you want to delete row with ID: " + pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 0), "Warning", JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE, null, options, options[0]);
				if (result == 0) 
					/*
					 * If the result is equals to options[0] which is "Yes"
					 * We declare the string id to be the selected row of the datatable and get the column 0
					 * which represents the id
					 * Then we call the method from DbConn and pass through the paramater we just defined.
					 */
				{
					String id = (String) pContactsDataTable.getValueAt(pContactsDataTable.getSelectedRow(), 0).toString();
					DbConn.deletePConacts(id);
					/*
					 * This is an additional option pane which will show a message that the row has been deleted successfully.
					 */
					pContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getPContacts()));
					JOptionPane.showMessageDialog(null, "Row Deleted Succesfully!", "Delete Confirmation", JOptionPane.YES_NO_OPTION);
				}
			}
			
			
		
			
		});
		
		
		
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addComponent(scrollPane, GroupLayout.DEFAULT_SIZE, 850, Short.MAX_VALUE)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addComponent(fname_label)
								.addComponent(sname_label)
								.addComponent(email_label)
								.addComponent(cnumber_label))
							.addGap(26)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
										.addComponent(sname_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
										.addComponent(fname_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
										.addComponent(email_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
									.addGap(18)
									.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
										.addComponent(faddress_label)
										.addComponent(saddress_label)
										.addComponent(pnumber_label)))
								.addGroup(gl_contentPane.createSequentialGroup()
									.addComponent(cnumber_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
									.addGap(18)
									.addComponent(city_label)))
							.addGap(18)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addComponent(pnumber_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
									.addPreferredGap(ComponentPlacement.UNRELATED)
									.addComponent(postcode_label))
								.addComponent(saddress_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
								.addComponent(city_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
								.addComponent(faddress_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
							.addGap(18)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.TRAILING)
								.addComponent(btnUpdateSelected, GroupLayout.DEFAULT_SIZE, 209, Short.MAX_VALUE)
								.addComponent(btnSaveSelected, GroupLayout.DEFAULT_SIZE, 209, Short.MAX_VALUE)
								.addComponent(postcode_textfield, GroupLayout.DEFAULT_SIZE, 209, Short.MAX_VALUE))
							.addPreferredGap(ComponentPlacement.RELATED)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.TRAILING)
								.addComponent(btnRefresh, GroupLayout.DEFAULT_SIZE, 165, Short.MAX_VALUE)
								.addComponent(btnDelete, GroupLayout.DEFAULT_SIZE, 165, Short.MAX_VALUE)
								.addComponent(btnAddNew, GroupLayout.DEFAULT_SIZE, 165, Short.MAX_VALUE)
								.addComponent(btnSaveNew, GroupLayout.DEFAULT_SIZE, 165, Short.MAX_VALUE))))
					.addContainerGap())
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
						.addComponent(fname_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addComponent(fname_label)
						.addComponent(pnumber_label)
						.addComponent(pnumber_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addComponent(postcode_label)
						.addComponent(postcode_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addComponent(btnAddNew))
					.addPreferredGap(ComponentPlacement.RELATED)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.TRAILING)
						.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
							.addComponent(sname_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
							.addComponent(sname_label)
							.addComponent(faddress_label))
						.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
							.addComponent(faddress_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
							.addComponent(btnSaveNew)))
					.addGap(8)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
						.addComponent(email_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addComponent(email_label)
						.addComponent(saddress_label)
						.addComponent(saddress_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addComponent(btnDelete)
						.addComponent(btnUpdateSelected))
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(12)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
									.addComponent(cnumber_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
									.addComponent(cnumber_label)
									.addComponent(city_label))
								.addComponent(city_textfield, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addPreferredGap(ComponentPlacement.RELATED)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
								.addComponent(btnRefresh)
								.addComponent(btnSaveSelected))))
					.addPreferredGap(ComponentPlacement.RELATED, 25, Short.MAX_VALUE)
					.addComponent(scrollPane, GroupLayout.PREFERRED_SIZE, 186, GroupLayout.PREFERRED_SIZE))
		);
		

		scrollPane.setViewportView(pContactsDataTable);
		contentPane.setLayout(gl_contentPane);
	}
}

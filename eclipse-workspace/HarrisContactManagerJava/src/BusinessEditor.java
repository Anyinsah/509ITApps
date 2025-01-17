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

import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class BusinessEditor extends JFrame {

	private JPanel contentPane;
	private JTextField bname_textfield;
	private JTextField bemail_textfield;
	private JTextField bnumber_textfield;
	private JTable bContactsDataTable;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					BusinessEditor frame = new BusinessEditor();
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
	public BusinessEditor() {
		DbConn DbConn = new DbConn();
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowOpened(WindowEvent e) { 
				/*
				 * When the window loads the getBContacts method will be called instantly
				 * Meaning that the database can be read without clicking refresh
				 */
				bContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getBContacts()));
			}
		});
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 612, 407);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 158, 576, 199);
		contentPane.add(scrollPane);
		
		bContactsDataTable = new JTable();
		scrollPane.setViewportView(bContactsDataTable);
		
		JButton btnAddNew = new JButton("Add New");

		btnAddNew.setBounds(481, 11, 105, 23);
		contentPane.add(btnAddNew);
		
		JButton btnSaveNew = new JButton("Save New");
		btnSaveNew.setEnabled(false);
		btnSaveNew.setBounds(481, 45, 105, 23);
		contentPane.add(btnSaveNew);
		
		JButton btnRefresh = new JButton("Refresh");

		btnRefresh.setBounds(481, 124, 105, 23);
		contentPane.add(btnRefresh);
		
		JButton btnUpdateSelected = new JButton("Update Selected");
		btnUpdateSelected.setBounds(337, 11, 134, 23);
		contentPane.add(btnUpdateSelected);
		
		JButton btnSaveSelected = new JButton("Save Selected");
		btnSaveSelected.setEnabled(false);
		btnSaveSelected.setBounds(337, 45, 134, 23);
		contentPane.add(btnSaveSelected);
		
		JButton btnDelete = new JButton("Delete");
		btnDelete.setBounds(481, 79, 105, 23);
		contentPane.add(btnDelete);
		
		JLabel bname_label = new JLabel("Business Name");
		bname_label.setBounds(10, 15, 114, 14);
		contentPane.add(bname_label);
		
		JLabel bemail_label = new JLabel("Business Email");
		bemail_label.setBounds(10, 49, 114, 14);
		contentPane.add(bemail_label);
		
		JLabel bnumber_label = new JLabel("Business Number");
		bnumber_label.setBounds(10, 83, 114, 14);
		contentPane.add(bnumber_label);
		
		bname_textfield = new JTextField();
		bname_textfield.setEnabled(false);
		bname_textfield.setBounds(134, 12, 120, 20);
		contentPane.add(bname_textfield);
		bname_textfield.setColumns(10);
		
		bemail_textfield = new JTextField();
		bemail_textfield.setEnabled(false);
		bemail_textfield.setBounds(134, 46, 120, 20);
		contentPane.add(bemail_textfield);
		bemail_textfield.setColumns(10);
		
		bnumber_textfield = new JTextField();
		bnumber_textfield.setEnabled(false);
		bnumber_textfield.setBounds(134, 80, 120, 20);
		contentPane.add(bnumber_textfield);
		bnumber_textfield.setColumns(10);
		
		// Event Handlers
		
		bContactsDataTable.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				/*
				 * When the datatable is clicked it will set the textfield of the textboxes to the selected row and column 
				 * Corresponding to the data of that textbox. e.g bEmail @ column 2
				 */
				bname_textfield.setText(bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 1).toString());
				bemail_textfield.setText(bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 2).toString());
				bnumber_textfield.setText(bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 3).toString());

			}
		});
		
		btnRefresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				// Refreshes the database by just calling the getBContacts() method again.
				bContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getBContacts()));
				
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
				btnDelete.setEnabled(false);
				btnUpdateSelected.setEnabled(false);
				btnSaveSelected.setEnabled(false);
				bname_textfield.setEnabled(true);
				bemail_textfield.setEnabled(true);
				bnumber_textfield.setEnabled(true);
				bname_textfield.setText("");
				bemail_textfield.setText("");
				bnumber_textfield.setText("");
				
				
			}
		});
		
		btnSaveNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				/*
				 * Set the string of the paramaters used in the inserPContacts to the text inside the textfield
				 * of each textbox.
				 */
				
				String bName = bname_textfield.getText();
				String bEmail = bemail_textfield.getText();
				String bNumber = bnumber_textfield.getText();
				
				/*
				 * We call the method insertPContacts and and pass through the  necessary paramaters.
				 */
				
				DbConn.insertBContacts(bName, bEmail, bNumber);
				
				/*
				 * When save new is clicked, all buttons will be re enabled except save new and save selected
				 */
				
				btnAddNew.setEnabled(true);
				btnSaveNew.setEnabled(false);
				btnDelete.setEnabled(true);
				btnUpdateSelected.setEnabled(true);
				btnSaveSelected.setEnabled(false);
				
				/*
				 * The textfields are disabled
				 */
				
				bname_textfield.setEnabled(false);
				bemail_textfield.setEnabled(false);
				bnumber_textfield.setEnabled(false);
				
				bContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getBContacts())); // Refresh database
				
			}
		});
		
		btnUpdateSelected.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) 
			{
				btnAddNew.setEnabled(false);
				btnSaveNew.setEnabled(false);
				btnDelete.setEnabled(false);
				btnUpdateSelected.setEnabled(false);
				btnSaveSelected.setEnabled(true);
				bname_textfield.setEnabled(true);
				bemail_textfield.setEnabled(true);
				bnumber_textfield.setEnabled(true);
				
			}
		});
		
		btnSaveSelected.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e)
			{
				/*
				 * The update selected is similar to the inserBContacts method
				 * Only now that we pass through the ID as the first paramater.
				 * We disable the irrelevant buttons during this process again.
				 */
				
				String bName = bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 1).toString();
				String bEmail = bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 2).toString();
				String bNumber = bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 3).toString();
				String id = bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 0).toString();
				
				/*
				 * Declare string variables which we set the position of the row and column for each individual data.
				 * So again, we get the selected row from the datagrid and set the column position to the relevant information.
				 * E.g bNumber at column 3
				 * ID becomes the first position indexed at 0.
				 */
				
				/*
				 * We set the information to the text in the textfield
				 */
				
				bName = bname_textfield.getText();
				bEmail = bemail_textfield.getText();
				bNumber = bnumber_textfield.getText();

				// We pass through the paramaters into the method.
				
				DbConn.updateBContacts(bName, bEmail, bNumber, id);
				
				/*
				 * The properties are then set back to its relevant positions.
				 */
				btnAddNew.setEnabled(true);
				btnSaveNew.setEnabled(false);
				btnDelete.setEnabled(true);
				btnUpdateSelected.setEnabled(true);
				btnSaveSelected.setEnabled(false);
				bname_textfield.setEnabled(false);
				bemail_textfield.setEnabled(false);
				bnumber_textfield.setEnabled(false);
				
				/*
				 * The text in the textfields are clear.
				 */
				bname_textfield.setText("");
				bemail_textfield.setText("");
				bnumber_textfield.setText("");
				
				bContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getBContacts())); // refresh database

				
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
				Object[] options = {"Yes", "No"};
				/*
				 * We make an array called options and store strings yes andno
				 * We create an int variable called result and assign into to a JOptionPane, show option dialog
				 * which then we pass through the properties we want on that dialog including the options
				 * from the options array.
				 */
				int result = JOptionPane.showOptionDialog(null, "Are you sure you want to delete this row with ID: " + bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 0), "Delete Warning", JOptionPane.YES_NO_OPTION,JOptionPane.QUESTION_MESSAGE, null, options, options[0]);
				if (result == 0)
					/*
					 * If the result is equals to options[0] which is "Yes"
					 * We declare the string id to be the selected row of the datatable and get the column 0
					 * which represents the id
					 * Then we call the method from DbConn and pass through the paramater we just defined.
					 */
				{
					
					String id = bContactsDataTable.getValueAt(bContactsDataTable.getSelectedRow(), 0).toString();
					DbConn.deleteBContacts(id);
					/*
					 * This is an additional option pane which will show a message that the row has been deleted successfully.
					 */
					bContactsDataTable.setModel(DbUtils.resultSetToTableModel(DbConn.getBContacts()));
					JOptionPane.showMessageDialog(null, "Row Deleted Succesfully!", "Delete Confirmation", JOptionPane.YES_NO_OPTION);

				}
				
			}
		});
		
		
		
	}
	
	
	


}

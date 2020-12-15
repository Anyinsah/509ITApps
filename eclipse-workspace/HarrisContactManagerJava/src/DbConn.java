import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

/*
 * CODE COMMENTED BY JOSIAH ANYINSAH-BONDZIE
 * ANY REPEATED CODE WILL NOT BE COMMENTED SO PLEASE REFER ABCK TO ORIGINAL COMMENT TO UNDERSTAND 
 * 
 */

public class DbConn { /* Public class called DbConn Created
						Strings are defined for the server properties used to access the HarrisContactDb
						*/
	String ConnString = "jdbc:mysql://db509it.cdqlst5meygv.us-east-1.rds.amazonaws.com/HarrisContactDb";
	String username = "admin";
	String password = "Cultivate01!";
	Connection conn = null; // variable we will use to connect and retrieve information from the database
	
	public DbConn() // 
	{
		try { /* we call conn and pass it through the drivermanager.getconnection and plug in the 
			information of the database so that we can have access to it.
		*/
			conn = DriverManager.getConnection(ConnString, username, password);
			System.out.println("Connected to Database"); 
			/*
			 * The try catch error will is thrown so if there is a problem with connecting to the database
			 * this information will be sent to the console.
			 */
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("Not Connected");
		}
		
	}
	public ResultSet getPContacts() 
	{
		/*
		 * The block of code below retrieves the personal contacts from the database by passing the sql command method
		 * defined as the selectPersonalContacts() method.
		 * In the try catch statement, we create a callable statement which prepares the method selectPersonalContacts();
		 * We execute the query by declaring it through setResult
		 * And return setResult through the method.
		 */
		ResultSet setResult = null;
		String sql = "CALL selectPersonalContacts();";
		try {
			CallableStatement callStatement = conn.prepareCall(sql);
			setResult = callStatement.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return setResult;
	}
	
	public void insertPContacts(
			String firstName,
			String lastName,
			String cEmail,
			String cNumber,
			String pNumber,
			String fAddress,
			String sAddress,
			String city,
			String postcode
			)
	{
		/*
		 * Here we create a method insertPContacts (this is the same for business contacts)
		 * We pass trhough parameters 9 strings that are equivalent the the paramaters passed in the sql command
		 * method. We call the statement and set the string value and its indexed position.
		 * And execute the query, however this doesnt return anything, so theres no need to return any value in this
		 * method.
		 * 
		 */
		
		String sql = "CALL insertIntoPersonal(?,?,?,?,?,?,?,?,?);";
		try {
			CallableStatement callStatement = conn.prepareCall(sql);
			callStatement.setString(1, firstName);
			callStatement.setString(2, lastName);
			callStatement.setString(3, cEmail);
			callStatement.setString(4, cNumber);
			callStatement.setString(5, pNumber);
			callStatement.setString(6, fAddress);
			callStatement.setString(7, sAddress);
			callStatement.setString(8, city);
			callStatement.setString(9, postcode);
			ResultSet setResult = callStatement.executeQuery();
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}
	
	public void updatePContacts(
			String firstName, 
			String lastName,
			String cEmail,
			String cNumber,
			String pNumber, 
			String fAddress,
			String sAddress, 
			String city,
			String postcode,
			String id)
	
	{
		
		/*
		 * This is the same as the insertPContacts Method, however, we pass through the id and instead its position is 1
		 * and firstnames position is 2.
		 * This is because WHERE ContactID= ID in the command represents the first paramater and index on the table
		 * of personal contacts.
		 */

		String sql = "CALL updatePersonalContacts(?,?,?,?,?,?,?,?,?,?);";
		try {
			CallableStatement callStatement = conn.prepareCall(sql);
			callStatement.setString(1, id);
			callStatement.setString(2, firstName);
			callStatement.setString(3, lastName);
			callStatement.setString(4, cEmail);
			callStatement.setString(5, cNumber);
			callStatement.setString(6, pNumber);
			callStatement.setString(7, fAddress);
			callStatement.setString(8, sAddress);
			callStatement.setString(9, city);
			callStatement.setString(10, postcode);
			
			ResultSet setResult = callStatement.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		
		
	}
	
	public void deletePConacts(String id) 
	{
		/*
		 * This method is also the same as the last two, however only the ID gets called as the paramater
		 * and any relative data to the ID is removed along with it.
		 */
		String sql = "CALL deletePersonalContacts(?);";
		try {
			CallableStatement callStatement = conn.prepareCall(sql);
			callStatement.setString(1,  id);
			ResultSet setResult = callStatement.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	//THIS CODE HERE IS THE SAME AS FOR THE PERSONAL CONTACTS, SO IN ORDER TO UDNERSTAND PLEASE REFER TO CODE ABOVE.
	public ResultSet getBContacts() 
	{
		ResultSet setResult = null;
		String sql = "CALL selectBusinessContacts();";
		try {
			CallableStatement callStatement = conn.prepareCall(sql);
			setResult = callStatement.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return setResult;
		
		
	}
	
	public void insertBContacts(String bName, String bEmail, String bNumber)
	{
		String sql = "CALL insertIntoBusiness(?,?,?);";
		try {
			CallableStatement callStatement = conn.prepareCall(sql);
			callStatement.setString(1, bName);
			callStatement.setString(2,  bEmail);
			callStatement.setString(3, bNumber);
			ResultSet setResult = callStatement.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void updateBContacts(String bName, String bEmail, String bNumber, String id)
	{
		String sql = "CALL updateBusinessContacts(?,?,?,?)";
		try {
			CallableStatement callStatement = conn.prepareCall(sql);
			callStatement.setString(1, id);
			callStatement.setString(2, bName);
			callStatement.setString(3, bEmail);
			callStatement.setString(4, bNumber);
			ResultSet setResult = callStatement.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	
	public void deleteBContacts(String id) 
	{
		String sql = "CALL deleteBusinessContacts(?);";
		try {
			CallableStatement callStatement = conn.prepareCall(sql);
			callStatement.setString(1, id);
			ResultSet setResult = callStatement.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	
}

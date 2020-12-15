using MySqlConnector; // instantiate sql library
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* COMMENTED BY JOSIAH-ANYINSAH-BONDZIE
 * A LOT OF THE PROCEEDURES ARE THE SAME SO I WILL NOT REPEAT COMMENTING ON METHODS THAT HAVE ALREADY BEEN COMMENTED OR ARE THE SAME
 */




namespace HarrisContactManagerCSharp
{
    public class DbConn // create a class that initalizes the connection to the database
    {
        private string sConn = "Server=db509it.cdqlst5meygv.us-east-1.rds.amazonaws.com;User ID=admin;Password=Cultivate01!;Database=HarrisContactDb"; /*
        The line of code above defines the properties of the database and stores it in a string */
    

        public DataTable getPContacts()
        {
            using (var conn = new MySqlConnection(sConn)) /* this passes the database information stored in the string and passes it
             to the database connector mysqlConnection */
            {
                conn.Open(); //open connection to mysql server
                DataTable dtPersonalContacts = new DataTable(); // new datatable 
                List<PersonalContacts> pContact = new List<PersonalContacts>(); // Create a new list pCOontact that can access the attributes in the personalcontacts class
                using (var callCommand = new MySqlCommand("CALL selectPersonalContacts();", conn)) // calling the sql query commmand andcreating a method of what happens when called
                {
                    using (var reader = callCommand.ExecuteReader()) // called to retrieve and read the data from the sql database from first to last
                    {
                        while (reader.Read()) //once table is retrieved from first to last in sql database,
                        {
                            pContact.Add(new PersonalContacts // Here we call the pContact object to assign the objects of the contacts class to the paramaters in the db table
                            {
                                /* The code below will retrieve the data of the table cells at index 0-9
                                 * 
                                 */
                                ContactID = reader.GetInt32(0), 
                                cFirstName = reader.GetString(1), 
                                cSecondName = reader.GetString(2),
                                cEmail = reader.GetString(3),
                                cContactTel = reader.GetString(4),
                                pContactTel = reader.GetString(5),
                                pAddress1 = reader.GetString(6),
                                pAddress2 = reader.GetString(7),
                                pCity = reader.GetString(8),
                                aPostCode = reader.GetString(9)
                            }); 


                        }

                    }

                }
                /*
                 * The block of code adds coloumns of the parameters above into the datatable in the application.
                 * 
                 */

                dtPersonalContacts.Columns.Add("ContactID");
                dtPersonalContacts.Columns.Add("cFirstName");
                dtPersonalContacts.Columns.Add("cSecondName");
                dtPersonalContacts.Columns.Add("cEmail");
                dtPersonalContacts.Columns.Add("cContactTel");
                dtPersonalContacts.Columns.Add("pContactTel");
                dtPersonalContacts.Columns.Add("pAddress1");
                dtPersonalContacts.Columns.Add("pAddress2");
                dtPersonalContacts.Columns.Add("pCity");
                dtPersonalContacts.Columns.Add("aPostCode");


                foreach (var item in pContact) //item uses to determine the values in each cell of data in the datatable.
                    /*
                     * A variable called row is defined and given the value of a new role in the datatable.
                     * item represents the stored information for each column, in which the row being created receives the items representing the row
                     * in the database.
                     * 
                     */
                {
                    var row = dtPersonalContacts.NewRow();
                    row["ContactID"] = item.ContactID; 
                    row["cFirstName"] = item.cFirstName;
                    row["cSecondName"] = item.cSecondName;
                    row["cEmail"] = item.cEmail;
                    row["cContactTel"] = item.cContactTel;
                    row["pContactTel"] = item.pContactTel;
                    row["pAddress1"] = item.pAddress1;
                    row["pAddress2"] = item.pAddress2;
                    row["pCity"] = item.pCity;
                    row["aPostCode"] = item.aPostCode;

                    dtPersonalContacts.Rows.Add(row);


                }
                return dtPersonalContacts;
                }

            }

        public async void insertPContacts(PersonalContacts personalContact) // create an asynchronous method which we call the class and create an object which can access the attributes of the class

        {
            using (var conn = new MySqlConnection(sConn))
            {
                await conn.OpenAsync();
                using (var callCommand = new MySqlCommand())
                {
                    /* After establishing a connection to the mysql server,
                     * We pass the sql command insertIntoPersonal with the paramater we created with the command in HeidiSQL
                     * The paramaters are set to the initial parameters we called in reading the databae in the datagridview
                     * 
                     */
                    callCommand.Connection = conn;
                    callCommand.CommandText = "CALL insertIntoPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    callCommand.Parameters.AddWithValue("p1", personalContact.cFirstName);
                    callCommand.Parameters.AddWithValue("p2", personalContact.cSecondName);
                    callCommand.Parameters.AddWithValue("p3", personalContact.cEmail);
                    callCommand.Parameters.AddWithValue("p4", personalContact.cContactTel);
                    callCommand.Parameters.AddWithValue("p5", personalContact.pContactTel);
                    callCommand.Parameters.AddWithValue("p6", personalContact.pAddress1);
                    callCommand.Parameters.AddWithValue("p7", personalContact.pAddress2);
                    callCommand.Parameters.AddWithValue("p8", personalContact.pCity);
                    callCommand.Parameters.AddWithValue("p9", personalContact.aPostCode);
                    await callCommand.ExecuteNonQueryAsync(); //execute query/command.
                }

            }
        }

        public async void updatePContacts(PersonalContacts personalContact)
        {
            using (var conn = new MySqlConnection(sConn))
            {
                await conn.OpenAsync();
                using (var callCommand = new MySqlCommand())
                    /*
                     * The difference between this method and the insertIntoPersonalContacts();
                     *  is that we pass through the "first" paramater ID so that the seleted row identified can be changed when the information is matched to the ID of that row
                     *  Taking a look at Heidi SQL will show this.
                     */ 
                {
                    callCommand.Connection = conn;
                    callCommand.CommandText = "CALL updatePersonalContacts(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    callCommand.Parameters.AddWithValue("p1", personalContact.ContactID);
                    callCommand.Parameters.AddWithValue("p2", personalContact.cFirstName);
                    callCommand.Parameters.AddWithValue("p3", personalContact.cSecondName);
                    callCommand.Parameters.AddWithValue("p4", personalContact.cEmail);
                    callCommand.Parameters.AddWithValue("p5", personalContact.cContactTel);
                    callCommand.Parameters.AddWithValue("p6", personalContact.pContactTel);
                    callCommand.Parameters.AddWithValue("p7", personalContact.pAddress1);
                    callCommand.Parameters.AddWithValue("p8", personalContact.pAddress2);
                    callCommand.Parameters.AddWithValue("p9", personalContact.pCity);
                    callCommand.Parameters.AddWithValue("p10", personalContact.aPostCode);
                    await callCommand.ExecuteNonQueryAsync();
                }

            }
        }
        public async void deletePContacts(int ID)
        {
            using (var conn = new MySqlConnection(sConn))
            {
                await conn.OpenAsync();
                using (var callCommand = new MySqlCommand())
                {
                    /* 
                     * The difference between this method and the rest is that only the selected row ID is passed, which will be used to delete 
                     * the row from the table.
                     * 
                     */
                    callCommand.Connection = conn;
                    callCommand.CommandText = "CALL deletePersonalContacts(@p1);";
                    callCommand.Parameters.AddWithValue("p1", ID);
                    await callCommand.ExecuteNonQueryAsync();
                }

            }

            /* 
             * Below is the business contacts. However the same method used to read, edit, add and delete data from the table is the same
             * here. 
             * So I will not repeat the explanation here.
             * 
             */
        }


        public DataTable getBContacts()
        {
            using (var conn = new MySqlConnection(sConn))
            {
                conn.Open();
                DataTable dtBusinessContacts = new DataTable();
                List<BusinessContacts> bContact = new List<BusinessContacts>();
                using (var callCommand = new MySqlCommand("CALL selectBusinessContacts();", conn))
                {
                    using (var reader = callCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bContact.Add(new BusinessContacts
                            {
                                BusinessID = reader.GetInt32(0),
                                bName = reader.GetString(1),
                                bEmail = reader.GetString(2),
                                bNumber = reader.GetString(3)
                            });
                        }
                    }

                }
                dtBusinessContacts.Columns.Add("BusinessID");
                dtBusinessContacts.Columns.Add("bName");
                dtBusinessContacts.Columns.Add("bEmail");
                dtBusinessContacts.Columns.Add("bNumber");

                foreach (var item in bContact)
                {
                    var row = dtBusinessContacts.NewRow();
                    row["BusinessID"] = item.BusinessID;
                    row["bName"] = item.bName;
                    row["bEmail"] = item.bEmail;
                    row["bNumber"] = item.bNumber;

                    dtBusinessContacts.Rows.Add(row);
                }

                return dtBusinessContacts;
            }

                
        }
        public async void insertBContacts(BusinessContacts businessContacts)
        {
            using (var conn = new MySqlConnection(sConn))
            {
                await conn.OpenAsync();
                using (var callCommand = new MySqlCommand())
                {
                    callCommand.Connection = conn;
                    callCommand.CommandText = "CALL insertIntoBusiness(@p1,@p2,@p3);";
                    callCommand.Parameters.AddWithValue("p1", businessContacts.bName);
                    callCommand.Parameters.AddWithValue("P2", businessContacts.bEmail);
                    callCommand.Parameters.AddWithValue("p3", businessContacts.bNumber);
                    await callCommand.ExecuteNonQueryAsync();
                }

            }
        }

        public async void updateBContacts(BusinessContacts businessContacts)
        {

            using (var conn = new MySqlConnection(sConn))
            {
                await conn.OpenAsync();
                using (var callCommand = new MySqlCommand())
                {
                    callCommand.Connection = conn;
                    callCommand.CommandText = "CALL updateBusinessContacts(@p1,@p2,@p3,@p4);";
                    callCommand.Parameters.AddWithValue("p1", businessContacts.BusinessID);
                    callCommand.Parameters.AddWithValue("p2", businessContacts.bName);
                    callCommand.Parameters.AddWithValue("P3", businessContacts.bEmail);
                    callCommand.Parameters.AddWithValue("p4", businessContacts.bNumber);
                    await callCommand.ExecuteNonQueryAsync();
                }

            }

        }
        public async void deleteBContacts(int ID)
        {

            using (var conn = new MySqlConnection(sConn))
            {
                await conn.OpenAsync();
                using (var callCommand = new MySqlCommand())
                {
                    callCommand.Connection = conn;
                    callCommand.CommandText = "CALL deleteBusinessContacts(@p1);";
                    callCommand.Parameters.AddWithValue("p1", ID);
                    await callCommand.ExecuteNonQueryAsync();
                }

            }

        }


        }

        }



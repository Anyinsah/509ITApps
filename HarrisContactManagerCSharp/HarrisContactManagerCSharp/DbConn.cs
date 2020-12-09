using MySqlConnector; // instantiate sql library
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
                conn.Open();
                DataTable dtPersonalContacts = new DataTable();
                List<PersonalContacts> pContact = new List<PersonalContacts>();
                using (var callCommand = new MySqlCommand("CALL selectPersonalContacts();", conn))
                {
                    using (var reader = callCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pContact.Add(new PersonalContacts
                            {
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


                foreach (var item in pContact)
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

        public async void insertPContacts(PersonalContacts personalContact)
        {
            using (var conn = new MySqlConnection(sConn))
            {
                await conn.OpenAsync();
                using (var callCommand = new MySqlCommand())
                {
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
                    await callCommand.ExecuteNonQueryAsync();
                }

            }
        }

        public async void updatePContacts(PersonalContacts personalContact)
        {
            using (var conn = new MySqlConnection(sConn))
            {
                await conn.OpenAsync();
                using (var callCommand = new MySqlCommand())
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
                    callCommand.Connection = conn;
                    callCommand.CommandText = "CALL deletePersonalContacts(@p1);";
                    callCommand.Parameters.AddWithValue("p1", ID);
                    await callCommand.ExecuteNonQueryAsync();
                }

            }
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



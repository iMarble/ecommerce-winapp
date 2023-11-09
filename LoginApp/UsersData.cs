using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LoginApp
{
    internal class UsersData
    {
        private static List<object[]> dataArray = new List<object[]>(); //make this static so there's only one copy of list

        private int parsedUserID;

        public UsersData()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                const string sql = "SELECT * FROM LoginApp.Users";

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            //used google for getting help on this part
                            int columnCount = dataReader.FieldCount;

                            while (dataReader.Read())
                            {
                                // Create an array to store the values for the current row
                                object[] rowValues = new object[columnCount];

                                // Retrieve the values from the reader and store theminthearray
                                dataReader.GetValues(rowValues);

                                // Add the row to the data array
                                dataArray.Add(rowValues);
                            }
                        }
                    }
                    catch
                    {
                        //Nothing to catch
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        //making this method to update the list of users, on calling this
        private void updateUsers()
        {
            dataArray.Clear(); //clearing the old list first, because we have select * here. Not a good practice. Need to find out some other solution :/

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                const string sql = "SELECT * FROM LoginApp.Users";

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            //used chatgpt for getting help on this part
                            int columnCount = dataReader.FieldCount;

                            while (dataReader.Read())
                            {
                                // Create an array to store the values for the current row
                                object[] rowValues = new object[columnCount];

                                // Retrieve the values from the reader and store theminthearray
                                dataReader.GetValues(rowValues);

                                // Add the row to the data array
                                dataArray.Add(rowValues);
                            }
                        }
                    }
                    catch
                    {
                        //Nothing to catch
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public bool authUser(string username, string password)
        {
            //used google to search about find method of list.
            var user = dataArray.Find(x => x.Contains(username));

            if (user != null && user[2].ToString() == password)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public object[] getUserType(string username, string type)
        {
            var user = dataArray.Find(x => x.Contains(username));

            if (user != null && user[3].ToString() == type)
            {
                return user;
            }
            else { return null; }
        }

        public string getUserName(string username)
        {
            var user = dataArray.Find(x => x.Contains(username));

            if (user != null)
            {
                return user[1].ToString();
            }
            else { return null; }
        }

        public int newAccount(string username, string password, string type)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("LoginApp.uspNewUser", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    //username data
                    sqlCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@UserName"].Value = username;

                    //userpass data
                    sqlCommand.Parameters.Add(new SqlParameter("@UserPass", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@UserPass"].Value = password;

                    //user role data
                    sqlCommand.Parameters.Add(new SqlParameter("@UserRole", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@UserRole"].Value = type;

                    //returning user id
                    sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int));
                    sqlCommand.Parameters["@UserID"].Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();

                        // Run the stored procedure.
                        sqlCommand.ExecuteNonQuery();

                        // Customer ID is an IDENTITY value from the database.
                        this.parsedUserID = (int)sqlCommand.Parameters["@UserID"].Value;

                        // Put the Customer ID value into the read-only text box.
                        //MessageBox.Show($"New User Added With ID {parsedUserID}");
                    }
                    catch
                    {
                        //MessageBox.Show("Customer ID was not returned. Account could not be created.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }

            this.updateUsers();
            return parsedUserID;
        }
    }
}

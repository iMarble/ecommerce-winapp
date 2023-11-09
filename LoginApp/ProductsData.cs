using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LoginApp
{
    internal class ProductsData
    {
        private static List<object[]> dataArray = new List<object[]>(); //make this static so there's only one copy of list

        private static List<Product> products = new List<Product>(); //make this static so there's only one copy of list

        private int parsedProductID;

        public ProductsData()
        {
            getData();
        }

        public void clearData()
        {
            dataArray.Clear();
            products.Clear();
        }

        private void getData()
        {

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                const string sql = "SELECT * FROM LoginApp.Products";

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

                                Product getProduct = new Product(rowValues[1].ToString(), int.Parse(rowValues[0].ToString()), float.Parse(rowValues[3].ToString()), rowValues[2].ToString(), int.Parse(rowValues[4].ToString()), bool.Parse(rowValues[5].ToString()), int.Parse(rowValues[6].ToString()));
                                // Add the row to the data array
                                dataArray.Add(rowValues);
                                products.Add(getProduct);
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

        public void updateData(int Id, float price = 0.0f, string name = "", int stock = 0)
        {
            string sql;

            if (price != 0.0f)
            {
                sql = $"UPDATE LoginApp.Products SET ProductPrice = {price} WHERE ProductID = {Id}";
            }

            else if (name != "")
            {
                sql = $"UPDATE LoginApp.Products SET ProductName = '{name}' WHERE ProductID = {Id}";
            }

            else if (stock != 0)
            {
                sql = $"UPDATE LoginApp.Products SET ProductStock = {stock} WHERE ProductID = {Id}";
            }
            else
            {
                sql = "";
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.ExecuteReader();
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

        public void deleteData(int Id)
        {
            string sql = $"DELETE FROM LoginApp.Products WHERE ProductID = {Id}";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.ExecuteReader();
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

        private void updateUsers()
        {
            dataArray.Clear(); //clearing the old list first, because we have select * here. Not a good practice. Need to find out some other solution :/

            products.Clear();

            getData();
        }

        public int newProduct(string ProductName, string ProductDescription, float ProductPrice, int ProductStock, int userId, int Blocked = 0)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("LoginApp.NewProduct", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    //Productname data
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@ProductName"].Value = ProductName;

                    //productdescription data
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductDescription", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@ProductDescription"].Value = ProductDescription;

                    //Productprice data
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductPrice", SqlDbType.Float));
                    sqlCommand.Parameters["@ProductPrice"].Value = ProductPrice;

                    sqlCommand.Parameters.Add(new SqlParameter("@ProductStock", SqlDbType.Int));
                    sqlCommand.Parameters["@ProductStock"].Value = ProductStock;

                    sqlCommand.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int));
                    sqlCommand.Parameters["@UserId"].Value = userId;

                    sqlCommand.Parameters.Add(new SqlParameter("@ProductBlock", SqlDbType.Bit));
                    sqlCommand.Parameters["@ProductBlock"].Value = Blocked;

                    //returning product id
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int));
                    sqlCommand.Parameters["@ProductID"].Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();

                        // Run the stored procedure.
                        sqlCommand.ExecuteNonQuery();

                        // Customer ID is an IDENTITY value from the database.
                        this.parsedProductID = (int)sqlCommand.Parameters["@ProductID"].Value;

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
            return parsedProductID;
        }

        public object getProductByName(string name)
        {
            var product = products.Find(x => x.name == name);

            if (product != null)
            {
                return product;
            }
            else { return null; }
        }

        public object getProductByID(int ID)
        {
            var product = products.Find(x => x.id == ID);

            if (product != null)
            {
                return product;
            }
            else { return null; }
        }

        public List<Product> getProductBySellerID(int ID)
        {
            var product = products.FindAll(x => x.userId == ID);

            if (product != null)
            {
                return product;
            }
            else { return null; }
        }

        public List<Product> getAllProducts()
        {
            return products;
        }
    }
}


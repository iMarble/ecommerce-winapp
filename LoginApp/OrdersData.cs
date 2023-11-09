using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LoginApp
{
    internal class OrdersData
    {
        private static List<object[]> dataArray = new List<object[]>(); //make this static so there's only one copy of list

        private static List<Orders> orders = new List<Orders>(); //make this static so there's only one copy of list

        private int parsedOrderID;

        public OrdersData()
        {
            getData();
        }

        public void clearData()
        {
            dataArray.Clear();
            orders.Clear();
        }

        private void getData()
        {

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                const string sql = "SELECT * FROM LoginApp.Orders";

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

                                //Product getProduct = new Orders(int.Parse(rowValues[0].ToString()), rowValues[1].ToString() , float.Parse(rowValues[2].ToString()), rowValues[3].ToString(), rowValues[4].ToString(), rowValues[5].ToString(), rowValues[3].ToString(), int.Parse(rowValues[5].ToString()), bool.Parse(rowValues[5].ToString()), int.Parse(rowValues[6].ToString()));
                                // Add the row to the data array
                                //dataArray.Add(rowValues);
                                //orders.Add(getProduct);
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



        private void updateOrders()
        {
            dataArray.Clear(); //clearing the old list first, because we have select * here. Not a good practice. Need to find out some other solution :/

            getData();
        }

        public int newOrder(int BuyerId, string ProductName, string BuyerName, string BuyerAddress, string BuyerPhone, string PaymentMethod, float ProductPrice, int ProductStock, int Delieverd = 0)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("LoginApp.NewOrder", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    //BuyerId data
                    sqlCommand.Parameters.Add(new SqlParameter("@BuyerId", SqlDbType.Int));
                    sqlCommand.Parameters["@BuyerId"].Value = BuyerId;

                    //Productname data
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@ProductName"].Value = ProductName;

                    //Buyername data
                    sqlCommand.Parameters.Add(new SqlParameter("@BuyerName", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@BuyerName"].Value = BuyerName;

                    //BuyerAddress data
                    sqlCommand.Parameters.Add(new SqlParameter("@BuyerAddress", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@BuyerAddress"].Value = BuyerAddress;

                    //BuyerPhone data
                    sqlCommand.Parameters.Add(new SqlParameter("@BuyerPhone", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@BuyerPhone"].Value = BuyerPhone;


                    //PaymentMethod data
                    sqlCommand.Parameters.Add(new SqlParameter("@PaymentMethod", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@PaymentMethod"].Value = PaymentMethod;

                    //Productprice data
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductPrice", SqlDbType.Float));
                    sqlCommand.Parameters["@ProductPrice"].Value = ProductPrice;

                    //ProductStock Data
                    sqlCommand.Parameters.Add(new SqlParameter("@ProductStock", SqlDbType.Int));
                    sqlCommand.Parameters["@ProductStock"].Value = ProductStock;

                    sqlCommand.Parameters.Add(new SqlParameter("@ProductDelievered", SqlDbType.Bit));
                    sqlCommand.Parameters["@ProductDelievered"].Value = Delieverd;

                    //returning order id
                    sqlCommand.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
                    sqlCommand.Parameters["@OrderID"].Direction = ParameterDirection.Output;

                    try
                    {
                        connection.Open();

                        // Run the stored procedure.
                        sqlCommand.ExecuteNonQuery();

                        // Customer ID is an IDENTITY value from the database.
                        this.parsedOrderID = (int)sqlCommand.Parameters["@OrderID"].Value;

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

            this.updateOrders();
            return parsedOrderID;
        }

        public object getOrderByID(int ID)
        {
            var product = orders.Find(x => x.OrderId == ID);

            if (product != null)
            {
                return product;
            }
            else { return null; }
        }

        public List<Orders> getProductByBuyerID(int ID)
        {
            var order = orders.FindAll(x => x.BuyerId == ID);

            if (order != null)
            {
                return order;
            }
            else { return null; }
        }

        public List<Orders> getAllProducts()
        {
            return orders;
        }
    }
}

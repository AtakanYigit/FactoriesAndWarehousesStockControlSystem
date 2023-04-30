using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm.Project.Visual.Programming
{
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
        }

        private void GetRequests()
        {
            string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable dtRequests = new DataTable();
            if (connection.State == ConnectionState.Open){
                SqlDataAdapter adapterRequests = new SqlDataAdapter("SELECT r.ID, r.CUSTOMER_FACTORY_ID, r.MANUFACTURER_ID, r.WAREHOUSE_ID, r.PRODUCT_ID, r.QUANTITY, r.ORDER_DATE , r.REQUESTED_FOR, r.RECIEVE_DATE, r.STATUS, w.NAME " +
                                                                     "FROM REQUEST r " +
                                                                     "INNER JOIN WAREHOUSE w ON r.WAREHOUSE_ID = w.ID " +
                                                                     "INNER JOIN CUSTOMER_FACTORY c ON r.CUSTOMER_FACTORY_ID = c.ID " +
                                                                     "WHERE r.CUSTOMER_FACTORY_ID = 1;", connection);
                adapterRequests.Fill(dtRequests);
            }

            if (dtRequests.Rows[0] != null){
                for (int i = 0; i < dtRequests.Rows.Count; i++){
                    requestsTable.Rows.Add(dtRequests.Rows[i][0], dtRequests.Rows[i][1], dtRequests.Rows[i][2], dtRequests.Rows[i][3], dtRequests.Rows[i][4], dtRequests.Rows[i][5], dtRequests.Rows[i][6], dtRequests.Rows[i][7], dtRequests.Rows[i][8], dtRequests.Rows[i][9]);
                }
            }
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //SETTING WAREHOUSE INPUT VALUES
            SqlDataAdapter warehousesAdapter = new SqlDataAdapter("SELECT ID, NAME FROM WAREHOUSE", connection);
            DataTable dtWarehouses = new DataTable();
            warehousesAdapter.Fill(dtWarehouses);

            if (dtWarehouses.Rows[0] != null)
            {
                for (int i = 0; i < dtWarehouses.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        destinationWarehouse.Text = (dtWarehouses.Rows[i][0] + "-" + dtWarehouses.Rows[i][1]);
                    }
                    destinationWarehouse.Items.Add(dtWarehouses.Rows[i][0] + "-" + dtWarehouses.Rows[i][1]);
                }
            }

            //SETTING PRODUCT INPUT VALUES
            SqlDataAdapter productsAdapter = new SqlDataAdapter("SELECT ID, NAME FROM PRODUCT", connection);
            DataTable dtProducts = new DataTable();
            productsAdapter.Fill(dtProducts);
            productID.Items.Clear();
            if (dtProducts.Rows[0] != null)
            {
                for (int i = 0; i < dtProducts.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        productID.Text = (dtProducts.Rows[i][0] + "-" + dtProducts.Rows[i][1]);
                    }
                    productID.Items.Add(dtProducts.Rows[i][0] + "-" + dtProducts.Rows[i][1]);
                }
            }

            GetRequests();
        }

        private void SupplySubmitButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            DataTable dtStock = new DataTable();
            if (connection.State == ConnectionState.Open){
                SqlDataAdapter adapterRequests = new SqlDataAdapter("SELECT * FROM STOCK WHERE PRODUCT_ID = " + productID.Text.Substring(0, productID.Text.IndexOf("-")) + " AND WAREHOUSE_ID = " + Regex.Replace(destinationWarehouse.Text.ToString().Trim(), "[^0-9.]", ""), connection);
                adapterRequests.Fill(dtStock);
            }

            if (dtStock.Rows.Count > 0){
                string sqlQuery = "UPDATE STOCK SET QUANTITY = QUANTITY + @newStock WHERE PRODUCT_ID = @productId AND WAREHOUSE_ID = @warehouseId";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@newStock", numNewStock.Value);
                    command.Parameters.AddWithValue("@productId", Int32.Parse(productID.Text.Substring(0, productID.Text.IndexOf("-"))));
                    command.Parameters.AddWithValue("@warehouseId", Int32.Parse(destinationWarehouse.Text.Substring(0, destinationWarehouse.Text.IndexOf("-"))));
                    int rowsAffected = command.ExecuteNonQuery();
                    System.Diagnostics.Debug.WriteLine(sqlQuery);
                }
            }
            else
            {

            }
            connection.Close();
        }
    }
}
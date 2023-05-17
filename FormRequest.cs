using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Midterm.Project.Visual.Programming
{
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void GetStocks()
        {
            
            string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable dtCurrentStock = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                SqlDataAdapter adapterStockData = new SqlDataAdapter("SELECT p.ID, p.NAME, s.QUANTITY, p.CATEGORY " +
                                                                     "FROM STOCK s JOIN PRODUCT p " +
                                                                     "ON s.Product_ID = p.ID " +
                                                                     "WHERE s.Warehouse_ID = " + Regex.Replace(stockSearchWarehouse.Text.ToString().Trim(), "[^0-9.]", ""), connection);
                adapterStockData.Fill(dtCurrentStock);
            }
            currentStockData.Rows.Clear();
            if (dtCurrentStock.Rows.Count > 0)
            {
                for (int i = 0; i < dtCurrentStock.Rows.Count; i++)
                {
                    currentStockData.Rows.Add(dtCurrentStock.Rows[i][0], dtCurrentStock.Rows[i][1], dtCurrentStock.Rows[i][2], dtCurrentStock.Rows[i][3]);
                }
            }
        }

        private void Form_Load(object sender, EventArgs e){
            try{
                string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();


                //SETTING WAREHOUSE INPUT VALUES
                SqlDataAdapter warehousesAdapter = new SqlDataAdapter("SELECT ID, NAME FROM WAREHOUSE", connection);
                DataTable dtWarehouses = new DataTable();
                warehousesAdapter.Fill(dtWarehouses);
                stockSearchWarehouse.Items.Clear();
                if (dtWarehouses.Rows[0] != null){
                    for (int i = 0; i < dtWarehouses.Rows.Count; i++){
                        if(i == 0){
                            stockSearchWarehouse.Text = (dtWarehouses.Rows[i][0] + "-" + dtWarehouses.Rows[i][1]);
                            destinationWarehouse.Text = (dtWarehouses.Rows[i][0] + "-" + dtWarehouses.Rows[i][1]);
                        }
                        stockSearchWarehouse.Items.Add(dtWarehouses.Rows[i][0] + "-" + dtWarehouses.Rows[i][1]);
                        destinationWarehouse.Items.Add(dtWarehouses.Rows[i][0] + "-" + dtWarehouses.Rows[i][1]);
                    }
                }

                //SETTING PRODUCT INPUT VALUES
                SqlDataAdapter productsAdapter = new SqlDataAdapter("SELECT ID, NAME FROM PRODUCT", connection);
                DataTable dtProducts = new DataTable();
                productsAdapter.Fill(dtProducts);
                requestedProduct.Items.Clear();
                if (dtProducts.Rows[0] != null)
                {
                    for (int i = 0; i < dtProducts.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            requestedProduct.Text = (dtProducts.Rows[i][0] + "-" + dtProducts.Rows[i][1]);
                        }
                        requestedProduct.Items.Add(dtProducts.Rows[i][0] + "-" + dtProducts.Rows[i][1]);
                    }
                }

                //SETTING MANUFACTURER INPUT VALUES
                SqlDataAdapter manufacturerAdapter = new SqlDataAdapter("SELECT ID, NAME FROM MANUFACTURER", connection);
                DataTable dtManufacturers = new DataTable();
                manufacturerAdapter.Fill(dtManufacturers);

                requestedManufacturer.Items.Clear();
                if (dtManufacturers.Rows[0] != null)
                {
                    for (int i = 0; i < dtProducts.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            requestedManufacturer.Text = (dtManufacturers.Rows[i][0] + "-" + dtManufacturers.Rows[i][1]);
                        }
                        requestedManufacturer.Items.Add(dtManufacturers.Rows[i][0] + "-" + dtManufacturers.Rows[i][1]);
                    }
                }

                //SETTING STOCKS
                GetStocks();
            }
            catch (Exception ex){
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void RequestProduct(object sender, EventArgs e)
        {
            string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO REQUEST (CUSTOMER_FACTORY_ID, " +
                                                                             "MANUFACTURER_ID, "     +
                                                                             "WAREHOUSE_ID, "        +
                                                                             "PRODUCT_ID, "          +
                                                                             "QUANTITY, "            +
                                                                             "ORDER_DATE, "          +
                                                                             "REQUESTED_FOR, "       +
                                                                             "STATUS) "              +
                                                        "VALUES (1, '"           + 
                                                                  Regex.Replace(requestedManufacturer.Text.ToString().Trim(), "[^0-9.]", "") + "', '" + 
                                                                  Regex.Replace(destinationWarehouse.Text.ToString().Trim(), "[^0-9.]", "")  + "', '" +
                                                                  requestedProduct.Text.Split('-')[0].Trim()                                 + "', '" +
                                                                  requestedNumber.Text                                                       + "', '" +
                                                                  DateTime.Now.ToString("yyyy-MM-dd")                                        + "', '" +
                                                                  requestedDate.SelectionRange.Start.ToString("yyyy-MM-dd")                  + "', '" +
                                                                  "waiting');", connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
        }

        private void stockSearchWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStocks();
        }
    }
}

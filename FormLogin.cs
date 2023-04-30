using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Midterm.Project.Visual.Programming
{
    public partial class FormLogin : Form
    {
        Thread th;
        public FormLogin()
        {
            InitializeComponent();
        }

        //LOGIN - REGISTER
        private void CustomerLogin(object sender, EventArgs e){
            try{
                string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //string phoneNumber = phoneCustomerLogin.Text;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [PHONE],[PASSWORD] FROM [dbo].[CUSTOMER_FACTORY] WHERE PHONE = '" + Regex.Replace(phoneCustomerLogin.Text.ToString().Trim(), "[^0-9.]", "") + "' AND PASSWORD = '" + passwordCustomerLogin.Text.ToString().Trim() + "'", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows[0] != null){
                    Close();
                    th = new Thread(OpenRequestForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }catch(Exception ex){
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void OpenRequestForm(object obj){
            Application.Run(new FormRequest());
        }

        private void ManufacturerLogin(object sender, EventArgs e)
        {
            try{
                string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                System.Diagnostics.Debug.WriteLine("SELECT [PHONE],[PASSWORD] FROM [dbo].[MANUFACTURER] WHERE PHONE = '" + Regex.Replace(phoneManufacturerLogin.Text.ToString().Trim(), "[^0-9.]", "") + "' AND PASSWORD = '" + passwordCustomerLogin.Text.ToString().Trim() + "'");
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [PHONE],[PASSWORD] FROM [dbo].[MANUFACTURER] WHERE PHONE = '" + Regex.Replace(phoneManufacturerLogin.Text.ToString().Trim(), "[^0-9.]", "") + "' AND PASSWORD = '" + passwordManufacturerLogin.Text.ToString().Trim() + "'", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows[0] != null){
                    Close();
                    th = new Thread(OpenTransferForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            catch (Exception ex){
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void CustomerRegister(object sender, EventArgs e)
        {
            try{
                string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //SqlDataAdapter adapterr = new SqlDataAdapter("SELECT [PHONE],[PASSWORD] FROM [dbo].[CUSTOMER_FACTORY] WHERE PHONE = '" + Regex.Replace(phoneCustomerLogin.Text.ToString().Trim(), "[^0-9.]", "") + "' AND PASSWORD = '" + passwordCustomerLogin.Text.ToString().Trim() + "'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO CUSTOMER_FACTORY (NAME, SURNAME, PASSWORD, PHONE, COUNTRY, TAX_ID) VALUES ('"+ nameCustomerRegister.Text + "', '" + surnameCustomerRegister.Text + "', '"+ passwordCustomerRegister.Text + "', '"+ Regex.Replace(phoneCustomerRegister.Text.ToString().Trim(), "[^0-9.]", "") + "', '"+ customerRegisterCountrySelect.Text + "', "+ Int32.Parse(taxCustomerRegister.Text) + ")", connectionString);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Close();
                th = new Thread(OpenRequestForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void ManufacturerRegister(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source = PURJAXX; Initial Catalog = StockControlSystem; Integrated Security = true";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //SqlDataAdapter adapterr = new SqlDataAdapter("SELECT [PHONE],[PASSWORD] FROM [dbo].[CUSTOMER_FACTORY] WHERE PHONE = '" + Regex.Replace(phoneCustomerLogin.Text.ToString().Trim(), "[^0-9.]", "") + "' AND PASSWORD = '" + passwordCustomerLogin.Text.ToString().Trim() + "'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO MANUFACTURER (NAME, SURNAME, PASSWORD, PHONE, COUNTRY, TAX_ID) VALUES ('" + nameManufacturerRegister.Text + "', '" + surnameManufacturerRegister.Text + "', '" + passwordManufacturerRegister.Text + "', '" + Regex.Replace(phoneManufacturerRegister.Text.ToString().Trim(), "[^0-9.]", "") + "', '" + ManufacturerRegisterCountrySelect.Text + "', " + Int32.Parse(taxManufacturerRegister.Text) + ")", connectionString);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Close();
                th = new Thread(OpenTransferForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }


        private void OpenTransferForm(object obj)
        {
            Application.Run(new FormSupply());
        }


        private void CheckBoxCustomerLogin_Click(object sender, EventArgs e)
        {
            if (checkBoxCustomerLogin.Checked)
            {
                passwordCustomerLogin.PasswordChar = '\0';
            }
            else
            {
                passwordCustomerLogin.PasswordChar = '*';
            }
        }

        private void CheckBoxManufacturerLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManufacturerLogin.Checked)
            {
                passwordManufacturerLogin.PasswordChar = '\0';
            }
            else
            {
                passwordManufacturerLogin.PasswordChar = '*';
            }
        }


        private void CheckBoxCustomerRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomerRegister.Checked)
            {
                passwordCustomerRegister.PasswordChar = '\0';
            }
            else
            {
                passwordCustomerRegister.PasswordChar = '*';
            }
        }

        private void CheckBoxManufacturerRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManufacturerRegister.Checked)
            {
                passwordManufacturerRegister.PasswordChar = '\0';
            }
            else
            {
                passwordManufacturerRegister.PasswordChar = '*';
            }
        }

        private void TxtNameCust_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNameMan_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSurnameMan_TextChanged(object sender, EventArgs e)
        {

        }

        //Exit Buttons
        private void ExitButtonManufacturerLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButtonCustomerLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButtonCustomerRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButtonManufacturerRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FormLogin
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "FormLogin";
        //    this.ResumeLayout(false);

        //}
    }
}

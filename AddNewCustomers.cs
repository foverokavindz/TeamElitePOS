using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace POS_Team_Elite
{
    public partial class AddNewCustomers : Form
    {
        public AddNewCustomers()
        {
            InitializeComponent();
        }

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //assign input data to variables
            string dbCustomerName = CusNameTb.Text.Trim();
            string dbCustomerTelNo = CusPhoneTb.Text.Trim();
            string dbCustomerEmail = CusEmailTb.Text.Trim();
            string DbCustomerAddress = CusAddressTb.Text.Trim();
            string DbCustomerWhtAppNO = CusWhtAppNoTb.Text.Trim();
            string DbCustomerNICno = CusNICTb.Text.Trim();

            //data validation

            if (dbCustomerName == "" || dbCustomerTelNo == "" || DbCustomerNICno == "")
            {

                MessageBox.Show("Please Fill Out REQUIRED fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {

                //insert data to db & check connection
                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();
                if (DB_conn.State == System.Data.ConnectionState.Open)
                {

                    DateTime CurrentDateTime = DateTime.Now; //get data time when add new customer

                    string SqlQuery = "INSERT INTO SystemCustomers (CustomerNIC,CustomerName,CustomerTelNo,CustomerWhtAppNo,CustomerEmail,CustomerAddress,CustomerRegDateTime,CustomerStatus) VALUES ('" + DbCustomerNICno + "','" + dbCustomerName + "','" + dbCustomerTelNo + "','" + DbCustomerWhtAppNO + "','" + dbCustomerEmail + "','" + DbCustomerAddress + "','" + CurrentDateTime + "','Active')";

                    SqlCommand Cmd = new SqlCommand(SqlQuery, DB_conn);
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Inserted Successfully", "Customer's Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DB_conn.Close();

                }
                else {

                    MessageBox.Show("Connection Error", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //conformation msg box

            DialogResult clearInputFields = MessageBox.Show("Do you want to clear all fields", "Conform", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (clearInputFields == DialogResult.Yes)
            {  //clear all input felds

                CusNameTb.Text = "";
                CusPhoneTb.Text = "";
                CusEmailTb.Text = "";
                CusAddressTb.Text = "";
                CusNICTb.Text = "";
                CusWhtAppNoTb.Text = "";




            }
        }
    }
}

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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();

            ShowInvoices();
        }
        //public string ConnectionString = "Data Source=DEVELOPER\\SQLEXPRESS;Initial Catalog=EliteDB;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        public void ShowInvoices()
        {

            DataTable CustomerDetailsTable = new DataTable();
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            if (DB_conn.State == System.Data.ConnectionState.Open)

            {
                //get data from 3 tables

               string SqlQuery = "SELECT InvoiceID,invo.CustomerNIC,CustomerName,TotalDue,Discount,Paid,DateTime,invo.SystemUserID,PersonName from Invoice invo , SystemCustomers ,SystemUsers  Where invo.CustomerNIC = SystemCustomers.CustomerNIC and invo.SystemUserID = SystemUsers.SystemUserID";
                
               //string SqlQuery = "SELECT InvoiceID,Invoice.CustomerNIC,CustomerName,TotalDue,Discount,Paid,DateTime,Invoice.SystemUserID,PersonName  from Invoice Invoice , SystemCustomers ,SystemUsers LEFT JOIN SystemCustomers ON Invoice.CustomerNIC = SystemCustomers.CustomerNIC  LEFT JOIN SystemUsers  ON Invoice.SystemUserID = SystemUsers.SystemUserID";
        

                SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlQuery, DB_conn);
                DataAdapter.Fill(CustomerDetailsTable);

                DB_conn.Close();

                dataGridView1.DataSource = CustomerDetailsTable;
                dataGridView1.Columns[0].HeaderText = "Invoice ID";
                dataGridView1.Columns[1].HeaderText = "Cuatomer NIC";
                dataGridView1.Columns[2].HeaderText = "Cuatomer Name";
                dataGridView1.Columns[3].HeaderText = "Toatal Due";
                dataGridView1.Columns[4].HeaderText = "Discount";
                dataGridView1.Columns[5].HeaderText = "Paid";
                dataGridView1.Columns[6].HeaderText = "Date Time";
                dataGridView1.Columns[7].HeaderText = "User ID";
                dataGridView1.Columns[8].HeaderText = "User Name";

                //dataGridView1.Columns[6].HeaderText = "Customer Name";

            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }
          private void Invoices_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTableCustomer = new DataTable();
            DataTable dataTableInvoice = new DataTable();
            DataTable dataTableUser = new DataTable();
            DataTable dataTableInvoiceProduct = new DataTable();

            // get row index 
            int rowIndex = e.RowIndex;
            // get row's invoice ID number
            string invoiceID = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            //Get data from Invoice Table
            string invoiceDetails = $"Select CustomerNIC,TotalDue,Discount,DateTime,SystemUserID  from Invoice Where InvoiceID = {invoiceID}";
            SqlDataAdapter invoiceDetailsDataAdapter = new SqlDataAdapter(invoiceDetails, DB_conn);
            invoiceDetailsDataAdapter.Fill(dataTableInvoice);
            //get CusNic to retrive data from customer table
            string customerNic = dataTableInvoice.Rows[0][0].ToString();
            //get SysUSerID to retrive data from User table
            string userId = dataTableInvoice.Rows[0][4].ToString();
            //Get date time to send NewBillWindow
            string dateTime = dataTableInvoice.Rows[0][3].ToString();
            // get Total Due & Dis
            string totalDue = dataTableInvoice.Rows[0][1].ToString();
            string totalDis = dataTableInvoice.Rows[0][2].ToString();


            //Get data from CustomerTable Table
            string customerDetails = $"Select CustomerNIC,CustomerName,CustomerAddress from SystemCustomers where CustomerNIC = '{customerNic}' ";
            SqlDataAdapter customerDetailsDataAdapter = new SqlDataAdapter(customerDetails, DB_conn);
            customerDetailsDataAdapter.Fill(dataTableCustomer);
            string cusNic = dataTableCustomer.Rows[0][0].ToString();
            string cusName = dataTableCustomer.Rows[0][1].ToString();
            string cusAddress = dataTableCustomer.Rows[0][2].ToString();

            //Get Data from SystemUSerTable
            string userDetails = $"Select PersonName,UserType from SystemUsers Where SystemUserID = '{userId}'";
            SqlDataAdapter userDetailsDataAdapter = new SqlDataAdapter(userDetails, DB_conn);
            userDetailsDataAdapter.Fill(dataTableUser);
            string userName = dataTableUser.Rows[0][0].ToString();
            string userType = dataTableUser.Rows[0][1].ToString();

            //Get Data from InvoiceProduct Table and ProductName
            string invoProduct = $"Select InvoiceProduct.ProductBcode,ProductsDetails.ProductName,Qty,UnitPrice,ItemDiscount,TotalPrice from InvoiceProduct inner join ProductsDetails on InvoiceProduct.ProductBcode = ProductsDetails.ProductBcode Where InvoiceID = {invoiceID}";
            SqlDataAdapter invoProductDataAdapter = new SqlDataAdapter(invoProduct,DB_conn);
            invoProductDataAdapter.Fill(dataTableInvoiceProduct);

            DB_conn.Close();

            
            // open Bill WIndow
            NewBIllWindow newBIllWindow = new NewBIllWindow();
            //Disable all main functional buttons
            newBIllWindow.guna2Button5.Enabled = false;
            newBIllWindow.guna2Button4.Enabled = false;
            newBIllWindow.guna2Button3.Enabled = false;
            newBIllWindow.btnCashPayNew.Enabled = false;
            newBIllWindow.guna2Button1.Enabled = false;
            newBIllWindow.BtnRemoveDataGridViewRow.Enabled = false;
            newBIllWindow.guna2Button2.Enabled = false;
            newBIllWindow.buttonSearchCustomer.Enabled = false;

            //Load customer Data
            newBIllWindow.NICtb.Text = cusNic;
            newBIllWindow.NameFromDb.Text = cusName;
            newBIllWindow.AddressFromDb.Text = cusAddress;

            //Load InvoiceID and Date time
            newBIllWindow.InvoiceIDTb.Text = invoiceID;
            newBIllWindow.DateTimeTb.Text = dateTime;

            //Load tot and Dis
            newBIllWindow.FinalTotTb.Text = totalDue;
            newBIllWindow.DisTb.Text = totalDis;

            //Load User Name and type
            newBIllWindow.UserNameLabel.Text = userName;
            newBIllWindow.UserPosition.Text = userType;

            // Load data to DatagridView
            // Iterate through dataTableInvoiceProduct and add its data rows to NewBIll's Data GridView
            for (int rowNumber = 0; rowNumber < dataTableInvoiceProduct.Rows.Count; rowNumber++)
            {
                newBIllWindow.itemListDtGridViw.Rows.Add();
                
                newBIllWindow.itemListDtGridViw["ItemBcode", rowNumber].Value = dataTableInvoiceProduct.Rows[rowNumber][0].ToString();
                newBIllWindow.itemListDtGridViw["ItemName", rowNumber].Value = dataTableInvoiceProduct.Rows[rowNumber][1].ToString();
                newBIllWindow.itemListDtGridViw["ItemPrice", rowNumber].Value = dataTableInvoiceProduct.Rows[rowNumber][3].ToString();
                newBIllWindow.itemListDtGridViw["ItemQty", rowNumber].Value = dataTableInvoiceProduct.Rows[rowNumber][2].ToString();

                // Calculate itemAmount
                int unitPrice = Convert.ToInt32(dataTableInvoiceProduct.Rows[rowNumber][3]);
                int qty = Convert.ToInt32(dataTableInvoiceProduct.Rows[rowNumber][2]);
                int amount = unitPrice * qty;

                newBIllWindow.itemListDtGridViw["ItemAmount", rowNumber].Value = amount.ToString();
                                
                newBIllWindow.itemListDtGridViw["ItemDiscount", rowNumber].Value = dataTableInvoiceProduct.Rows[rowNumber][4].ToString();
                newBIllWindow.itemListDtGridViw["ItemSpend", rowNumber].Value = dataTableInvoiceProduct.Rows[rowNumber][5].ToString();

            }

            //Show Window
            newBIllWindow.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ShowInvoices();
        }
    }
}

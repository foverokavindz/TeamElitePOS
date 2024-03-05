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
    public partial class PrintBill : Form
    {
        public PrintBill()
        {
            InitializeComponent();
        }
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            //string invoiceID = PaymentCash.InvoiceIDFromPaymentCash;
            string invoiceID = PaymentCash.InvoiceIDFromPaymentCash;

            DataTable customerTable = new DataTable();
            DataTable invoiceTable = new DataTable();
            DataTable invoiceProductTable = new DataTable();

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();

                //Get data from Invoice Table
                string invoiceDetails = $"Select *  from Invoice Where InvoiceID = {invoiceID}";
                SqlDataAdapter invoiceDetailsDataAdapter = new SqlDataAdapter(invoiceDetails, conn);
                invoiceDetailsDataAdapter.Fill(invoiceTable);
                string customerId = invoiceTable.Rows[0][1].ToString();

                //Get data from Customer Table
                string customerDetails = $"Select CustomerNIC,CustomerName from SystemCustomers where CustomerNIC = '{customerId}'";
                SqlDataAdapter customerDetailsDataAdapter = new SqlDataAdapter(customerDetails, conn);
                customerDetailsDataAdapter.Fill(customerTable);

                //Get data from invoice Product Table
                string invoiceProductDetails = $"Select InvoiceID,InvoiceProduct.ProductBcode,Qty,UnitPrice,ItemDiscount,TotalPrice,ProductsDetails.ProductName from InvoiceProduct inner join ProductsDetails on InvoiceProduct.ProductBcode = ProductsDetails.ProductBcode Where InvoiceID = {invoiceID}";
                SqlDataAdapter invoiceProductDetailsDataAdapter = new SqlDataAdapter(invoiceProductDetails, conn);
                invoiceProductDetailsDataAdapter.Fill(invoiceProductTable);

                

                conn.Close();

                CrystalReport1 crystalReport1 = new CrystalReport1();
                crystalReport1.Database.Tables["SystemCustomers"].SetDataSource(customerTable);
                crystalReport1.Database.Tables["Invoice"].SetDataSource(invoiceTable);
                crystalReport1.Database.Tables["InvoiceProduct"].SetDataSource(invoiceProductTable);

                this.crystalReportViewer1.ReportSource = crystalReport1;

           
        }
    }
}

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
using System.Runtime.InteropServices;
using System.Configuration;

namespace POS_Team_Elite
{
    public partial class PaymentCash : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public PaymentCash()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //get toatal price from bill window
            PaymentTotTB.Text = NewBIllWindow.ToPaymentTotalDue;
            InvoiceIDTb.Text = NewBIllWindow.ToPaymentInvoiceID;
            CustomerNICTb.Text = NewBIllWindow.ToPaymentNIC;
            DiscountTb.Text = NewBIllWindow.ToPaymentDiscount;
            DateTimeTB.Text = NewBIllWindow.ToPaymentDateTime;
            

        }

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PaymentPaidTB_KeyUp(object sender, KeyEventArgs e)
        {   //calculate balance
            int total = Convert.ToInt32(PaymentTotTB.Text);
            int paid = Convert.ToInt32(PaymentPaidTB.Text);

            int Balance = paid - total;

            BalanceTB.Text = Balance.ToString();
        }

        public static string InvoiceIDFromPaymentCash = "";
        private void button3_Click(object sender, EventArgs e)
        {
            InvoiceIDFromPaymentCash = InvoiceIDTb.Text.Trim(); // send invoice id to print bill window (cristal report)

            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                DateTime CurrentDateTime = DateTime.Now;
                //insert data to invoice table
                string SqlQuery = "INSERT INTO [Invoice] (InvoiceID,CustomerNIC,TotalDue,Discount,Paid,DateTime,SystemUserID) VALUES ('" + InvoiceIDTb.Text.Trim() + "','" + CustomerNICTb.Text.Trim() + "','" + Convert.ToInt32(PaymentTotTB.Text.Trim()) + "','" + Convert.ToInt32(DiscountTb.Text.Trim()) + "','" + Convert.ToInt32(PaymentPaidTB.Text.Trim()) + "','" + DateTimeTB.Text.Trim() + "', '"+ SalesUserID + "')";

                SqlCommand Cmd = new SqlCommand(SqlQuery, DB_conn);
                Cmd.ExecuteNonQuery();

                MessageBox.Show(" Data inserted successfully Invoice");

                DB_conn.Close();
            }
            
            else
            {
                MessageBox.Show("Connection Error");
            }


            
            PrintBill PrintbillPaper = new PrintBill();
            PrintbillPaper.Show();
        }

        string SalesUserID = "";
        private void PaymentCash_Load(object sender, EventArgs e)
        {
             SalesUserID = NewBIllWindow.ToPaymentUserID;
        }
    }
}

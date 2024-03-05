using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace POS_Team_Elite
{
    
    public partial class UpdateCustomer : Form
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

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        public UpdateCustomer()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void button1_Click(object sender, EventArgs e)//update button action
        {
            //assign data values for database process
            string ToDBNIC = CusNICTb.Text.Trim();
            string ToDBName = CusNameTb.Text.Trim();
            string ToDBPhone = CusPhoneTb.Text.Trim();
            string ToDBWhtNo = CusWhtAppNoTb.Text.Trim();
            string ToDBEmail = CusEmailTb.Text.Trim();
            string ToDBAddress = CusAddressTb.Text.Trim();

            // radio button check status
            string ToDBCusstatus = "";
            if (RBactive.Checked)
            {
                ToDBCusstatus = "Active";

            }
            else if (RBdeactive.Checked)
            {
                ToDBCusstatus = "Deactive";

            }
            
            


            if (ToDBNIC == "" || ToDBName == "" || ToDBPhone == "" ||ToDBCusstatus == "" )
            {

                MessageBox.Show("Please Fill Out All The Details", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();
                if (DB_conn.State == System.Data.ConnectionState.Open)
                {
                    

                    string SqlQuery1 = "UPDATE SystemCustomers SET CustomerName = '" + ToDBName + "',CustomerTelNo = '" + ToDBPhone + "',CustomerWhtAppNo = '" + ToDBWhtNo + "',CustomerEmail = '" + ToDBEmail + "',CustomerAddress = '" + ToDBAddress + "',CustomerStatus = '" + ToDBCusstatus + "'  where CustomerNIC = '" + ToDBNIC + "' "; 

                    SqlCommand CmdX = new SqlCommand(SqlQuery1, DB_conn);
                    CmdX.ExecuteNonQuery();

                    MessageBox.Show(" Data Changed successfully ");


                    DB_conn.Close();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Connection Error");
                }

            }
        }


        string RbValue = "";
        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            
            //assign cus data to text boxes
            CusNICTb.Text = ViewCustomers.CUSNIC;
            CusNameTb.Text = ViewCustomers.CUSNAME;
            CusPhoneTb.Text = ViewCustomers.CUSPHONE;
            CusWhtAppNoTb.Text = ViewCustomers.CUSWHATSAPPNO;
            CusEmailTb.Text = ViewCustomers.CUSEMAIL;
            CusAddressTb.Text = ViewCustomers.CUSADDRESS;
            CusDateTime.Text = ViewCustomers.CUSDATETIME;


            //assign cus status to ratio buttons

            
            if (ViewCustomers.CUSSTATUS == "Active")
            {
                RBactive.Checked = true;
                RbValue = RBactive.Text;
            }
            else if (ViewCustomers.CUSSTATUS == "Deactive") {

                RBdeactive.Checked = true;
                RbValue = RBdeactive.Text;
            }
             
         

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CusNICTb.Text != ViewCustomers.CUSNIC || CusNameTb.Text != ViewCustomers.CUSNAME || CusPhoneTb.Text != ViewCustomers.CUSPHONE || CusWhtAppNoTb.Text != ViewCustomers.CUSWHATSAPPNO || CusEmailTb.Text != ViewCustomers.CUSEMAIL || CusAddressTb.Text != ViewCustomers.CUSADDRESS || RbValue != ViewCustomers.CUSSTATUS)
            {
                DialogResult Closethis = MessageBox.Show("Do you want cancel - Changed data will be lose", "Conform", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (Closethis == DialogResult.Yes)
                {
                    Close();
                }
            }
            else {

                Close();
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CusNICTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RBactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBdeactive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
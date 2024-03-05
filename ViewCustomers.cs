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


    public partial class ViewCustomers : Form
    {

        public ViewCustomers()
        {
            InitializeComponent();
            /* this.dataGridView1.EnableHeadersVisualStyles = false;
             this.dataGridView1.DefaultCellStyle.Font = new Font("Nirmala UI", 9);
             this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
             //this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
             BtnDeactivateUser.BackColor = Color.IndianRed;*/
            


        }
        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        public void ShowCustomers()
        {

            DataTable CustomerDetailsTable = new DataTable();
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                string SqlQuery = "SELECT CustomerNIC,CustomerName,CustomerTelNo,CustomerWhtAppNo,CustomerEmail,CustomerAddress,CustomerRegDateTime,CustomerStatus from SystemCustomers";
                SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlQuery, DB_conn);
                DataAdapter.Fill(CustomerDetailsTable);

                DB_conn.Close();

                dataGridView1.DataSource = CustomerDetailsTable;
                dataGridView1.Columns[0].HeaderText = "NIC";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "Tel No";
                dataGridView1.Columns[3].HeaderText = "Whatsapp No";
                dataGridView1.Columns[4].HeaderText = "Email";
                dataGridView1.Columns[5].HeaderText = "Address";
                dataGridView1.Columns[6].HeaderText = "Registered Date & Time";
                dataGridView1.Columns[7].HeaderText = "Status";
  
            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewCustomers AddNewCus = new AddNewCustomers();
            AddNewCus.Show();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            ShowCustomers();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string ToDBCusstatus = "";
        int RowIndex;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridView1.Rows[RowIndex];

            CusNIC.Text = DataRow.Cells[0].Value.ToString().Trim();
            CusNameTb.Text = DataRow.Cells[1].Value.ToString();
            CusPhoneTb.Text = DataRow.Cells[2].Value.ToString();
            CusWhtAppNoTb.Text = DataRow.Cells[3].Value.ToString();
            CUSEmail.Text = DataRow.Cells[4].Value.ToString();
            CusAddress.Text = DataRow.Cells[5].Value.ToString();
            CusDateTime.Text = DataRow.Cells[6].Value.ToString();
            CusStatus.Text = DataRow.Cells[7].Value.ToString();


            if (CusStatus.Text.Trim() == "Active")
            {
                BtnDeactivateUser.Text = "Deactivate User";
                BtnDeactivateCustomerNew.FillColor = Color.IndianRed;

                BtnDeactivateCustomerNew.Text = "Deactivate User";
                BtnDeactivateCustomerNew.FillColor = Color.IndianRed;
                BtnDeactivateCustomerNew.BorderColor = Color.IndianRed;
                BtnDeactivateCustomerNew.HoverState.FillColor = Color.White;
                BtnDeactivateCustomerNew.HoverState.BorderColor = Color.IndianRed;
                BtnDeactivateCustomerNew.HoverState.CustomBorderColor = Color.IndianRed;
                BtnDeactivateCustomerNew.HoverState.ForeColor = Color.IndianRed;

                ToDBCusstatus = "Deactive";

            }
            else if (CusStatus.Text.Trim() == "Deactive")
            {

                BtnDeactivateUser.Text = "Activate User";
                BtnDeactivateCustomerNew.FillColor = Color.SeaGreen;

                BtnDeactivateCustomerNew.Text = "Activate User";
                BtnDeactivateCustomerNew.FillColor = Color.SeaGreen;
                BtnDeactivateCustomerNew.BorderColor = Color.SeaGreen;
                BtnDeactivateCustomerNew.HoverState.FillColor = Color.White;
                BtnDeactivateCustomerNew.HoverState.BorderColor = Color.SeaGreen;
                BtnDeactivateCustomerNew.HoverState.CustomBorderColor = Color.SeaGreen;
                BtnDeactivateCustomerNew.HoverState.ForeColor = Color.SeaGreen;

                ToDBCusstatus = "Active";
            }


        }

        private void BtnUpdateUserData_Click(object sender, EventArgs e)
        {

        }


        public static string CUSNIC = "";
        public static string CUSNAME = "";
        public static string CUSPHONE = "";
        public static string CUSWHATSAPPNO = "";
        public static string CUSEMAIL = "";
        public static string CUSADDRESS = "";
        public static string CUSDATETIME = "";
        public static string CUSSTATUS = "";
       
        private void BtnUpdateUserData_Click_1(object sender, EventArgs e)
        {
            CUSNIC = CusNIC.Text.Trim();
            CUSNAME = CusNameTb.Text.Trim();
            CUSPHONE = CusPhoneTb.Text.Trim();
            CUSWHATSAPPNO = CusWhtAppNoTb.Text.Trim();
            CUSEMAIL = CUSEmail.Text.Trim();
            CUSADDRESS = CusAddress.Text.Trim();
            CUSDATETIME = CusDateTime.Text.Trim();
            CUSSTATUS = CusStatus.Text.Trim();
            

            if (CUSNIC == "")
            {
                MessageBox.Show("Please Select A Row", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                UpdateCustomer CusUpdate = new UpdateCustomer();
                CusUpdate.Show();

            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CusNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusWhtAppNoTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusNICTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusEmailTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CusAddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CusNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeactivateUser_Click(object sender, EventArgs e)
        {

            // update user staus from Db
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {


                string SqlQuery1 = "UPDATE SystemCustomers SET CustomerStatus = '" + ToDBCusstatus + "'  where CustomerNIC = '" + CUSNIC + "' ";

                SqlCommand CmdX = new SqlCommand(SqlQuery1, DB_conn);
                CmdX.ExecuteNonQuery();

                MessageBox.Show(" Data Changed successfully ");


                DB_conn.Close();


                //call show customer funtion to show data in datagrid view
                ShowCustomers();

            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }

        private void BtnUpdateUserDataNew_Click(object sender, EventArgs e)
        {
            CUSNIC = CusNIC.Text.Trim();
            CUSNAME = CusNameTb.Text.Trim();
            CUSPHONE = CusPhoneTb.Text.Trim();
            CUSWHATSAPPNO = CusWhtAppNoTb.Text.Trim();
            CUSEMAIL = CUSEmail.Text.Trim();
            CUSADDRESS = CusAddress.Text.Trim();
            CUSDATETIME = CusDateTime.Text.Trim();
            CUSSTATUS = CusStatus.Text.Trim();


            if (CUSNIC == "")
            {
                MessageBox.Show("Please Select A Row", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                UpdateCustomer CusUpdate = new UpdateCustomer();
                CusUpdate.Show();

            }
        }

        private void BtnRefreshNew_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }

        private void BtnDeactivateUserNew_Click(object sender, EventArgs e)
        {

            // update user staus from Db
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {


                string SqlQuery1 = "UPDATE SystemCustomers SET CustomerStatus = '" + ToDBCusstatus + "'  where CustomerNIC = '" + CUSNIC + "' ";

                SqlCommand CmdX = new SqlCommand(SqlQuery1, DB_conn);
                CmdX.ExecuteNonQuery();

                MessageBox.Show(" Data Changed successfully ");


                DB_conn.Close();


                //call show customer funtion to show data in datagrid view
                ShowCustomers();

            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }
    }
}

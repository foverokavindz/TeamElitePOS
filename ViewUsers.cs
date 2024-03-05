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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();

            // deactiva button color
            BtnDeactivateUser.Text = "Deactivate User";
            BtnDeactivateUser.BackColor = Color.IndianRed;

        }
        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        public void ShowUSers()
        {

            DataTable USerDetailsTable = new DataTable();
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                string SqlQuery = "SELECT SystemUserID,PersonName,PersonTelNo,PersonEmail,PersonAddress,UserRegDateTime,UserStatus,UserType from SystemUsers";
                SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlQuery, DB_conn);
                DataAdapter.Fill(USerDetailsTable);

                DB_conn.Close();

                dataGridView1.DataSource = USerDetailsTable;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "Tel No";
                dataGridView1.Columns[3].HeaderText = "Email";
                dataGridView1.Columns[4].HeaderText = "Address";
                dataGridView1.Columns[5].HeaderText = "Registered Date & Time";
                dataGridView1.Columns[6].HeaderText = "Status";
                dataGridView1.Columns[7].HeaderText = "User Type";

            }
            else
            {
                MessageBox.Show("Connection Error");
            }
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeactivateUser_Click(object sender, EventArgs e)
        {

        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            ShowUSers();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ShowUSers();
            
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowUSers();
        }

        private void BtnUpdateUserData_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string ToDBUserStatus = "";
        int RowIndex;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridView1.Rows[RowIndex];

            UserIdTb.Text = DataRow.Cells[0].Value.ToString().Trim();
            NameTb.Text = DataRow.Cells[1].Value.ToString();
            PhoneTb.Text = DataRow.Cells[2].Value.ToString();
            EmailTb.Text = DataRow.Cells[3].Value.ToString();
            AddressTb.Text = DataRow.Cells[4].Value.ToString();
            UserStatusTb.Text = DataRow.Cells[6].Value.ToString().Trim();
            UserTypeTb.Text = DataRow.Cells[7].Value.ToString();


            if (UserStatusTb.Text == "Active")
            {
                BtnDeactivateUser.Text = "Deactivate User";
                //BtnDeactivateUser.BackColor = Color.IndianRed; // old button
                BtnDeactivateUserNew.FillColor = Color.IndianRed; // new button
                ToDBUserStatus = "Deactive";
            }
            else if (UserStatusTb.Text == "Deactive") {
            
                BtnDeactivateUser.Text = "Activate User";
                //BtnDeactivateUser.BackColor = Color.SeaGreen; // old button 
                BtnDeactivateUserNew.FillColor = Color.SeaGreen; // new button
                ToDBUserStatus = "Active";



            }

        }


        public static string USERID = "";
        public static string USERSNAME = "";
        public static string USERPHONE = "";
        public static string USEREMAIL = "";
        public static string USERADDRESS = "";
        public static string USERSTATUS = "";
        public static string USERTYPE = "";

        private void BtnUpdateUserData_Click_1(object sender, EventArgs e)
        {
            USERID = UserIdTb.Text.Trim();
            USERSNAME = NameTb.Text.Trim();
            USERPHONE = PhoneTb.Text.Trim();
            USEREMAIL = EmailTb.Text.Trim();
            USERADDRESS = AddressTb.Text.Trim();
            USERSTATUS = UserStatusTb.Text.Trim();
            USERTYPE = UserTypeTb.Text.Trim();
            


            if (USERID == "")
            {
                MessageBox.Show("Please Select A Row", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                UpdateUser UserUp = new UpdateUser();
                UserUp.Show();

            }
        }

        private void BtnDeactivateUser_Click_1(object sender, EventArgs e)
        {
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                // SystemUsers (PersonName,PersonTelNo,PersonEmail,PersonAddress,UserRegDateTime,UserStatus,Username,UserPassword,UserType)

                string SqlQuery1 = "UPDATE SystemUsers SET UserStatus = '" + ToDBUserStatus + "'where SystemUserID = '" + UserIdTb.Text + "' ";

                SqlCommand CmdX = new SqlCommand(SqlQuery1, DB_conn);
                CmdX.ExecuteNonQuery();

                MessageBox.Show("User status updated");


                DB_conn.Close();

                ShowUSers();

            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            

            /*
           
               for (int i = 0; i < dataGridView1.Rows.Count; i++)
               {
                   

                   if (dataGridView1.Rows[i].Cells[6].Value.ToString().Trim() == "Active")
                   {
                    dataGridView1.Rows[2].Cells[i].Style.BackColor = Color.SeaGreen;

                   }
                   else if (dataGridView1.Rows[i].Cells[0].Value.ToString().Trim() == "Deactive")
                   {
                       dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.IndianRed;

                   }

               }

            */
          
           

        }

        private void BtnRefreshNew_Click(object sender, EventArgs e)
        {
            ShowUSers();
        }

        private void BtnUpdateProductDetails_Click(object sender, EventArgs e)
        {
            USERID = UserIdTb.Text.Trim();
            USERSNAME = NameTb.Text.Trim();
            USERPHONE = PhoneTb.Text.Trim();
            USEREMAIL = EmailTb.Text.Trim();
            USERADDRESS = AddressTb.Text.Trim();
            USERSTATUS = UserStatusTb.Text.Trim();
            USERTYPE = UserTypeTb.Text.Trim();



            if (USERID == "")
            {
                MessageBox.Show("Please Select A Row", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                UpdateUser UserUp = new UpdateUser();
                UserUp.Show();

            }
        }

        private void BtnDeactivateUserNew_Click(object sender, EventArgs e)
        {
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                // SystemUsers (PersonName,PersonTelNo,PersonEmail,PersonAddress,UserRegDateTime,UserStatus,Username,UserPassword,UserType)

                string SqlQuery1 = "UPDATE SystemUsers SET UserStatus = '" + ToDBUserStatus + "'where SystemUserID = '" + UserIdTb.Text + "' ";

                SqlCommand CmdX = new SqlCommand(SqlQuery1, DB_conn);
                CmdX.ExecuteNonQuery();

                MessageBox.Show("User status updated");


                DB_conn.Close();

                ShowUSers();

            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }
    }
}

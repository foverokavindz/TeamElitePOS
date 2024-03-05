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
    public partial class LoginWindow : Form
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

        // deop shadow
        /*private const int CS_DropShadow = 0x0020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }*/
        public LoginWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35,35));
        }
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";

        public void loginProcess()
        {
            string ToCheckUsername = TbLoginUsername.Text.Trim();
            string TocheckPassword = TbloginPass.Text.Trim();

            if (ToCheckUsername == "" || TocheckPassword == "")
            {
                //check is there any empty field
                MessageBox.Show("Fill all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                //open db connection to get data from db to match username and password to log in
                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();

                if (DB_conn.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand Command = new SqlCommand("SELECT PersonName,Username,UserPassword,UserType,ProfileImage,SystemUserID from SystemUsers where Username = '" + ToCheckUsername + "' AND UserPassword = '" + TocheckPassword + "'", DB_conn);
                    SqlDataReader row = Command.ExecuteReader();

                    while (row.Read())
                    {
                        // get data from db to tb for matching
                        NameFromDB.Text = row.GetValue(0).ToString();
                        UserNameFromDB.Text = row.GetValue(1).ToString();
                        PasswordFromDB.Text = row.GetValue(2).ToString();
                        UserRoleFromDB.Text = row.GetValue(3).ToString();
                        ProPicTB.Text = row.GetValue(4).ToString();
                        USerID = row.GetValue(5).ToString();

                    }

                    if (UserNameFromDB.Text == ToCheckUsername && PasswordFromDB.Text == TocheckPassword)
                    {
                        if (UserRoleFromDB.Text == "Admin user")     //check what is the user role
                        {

                            //assign user's name and position to that vsriables
                            UserNameToDashboard = NameFromDB.Text;
                            UserRoleToDashboard = UserRoleFromDB.Text;
                            UserProfilePIcNUmber = ProPicTB.Text;



                            Dashboard admindashboard = new Dashboard();
                            admindashboard.Show();
                            this.Hide();

                        }
                        else if (UserRoleFromDB.Text == "Nomal user")
                        {


                            UserDashboard  userDashboard= new UserDashboard();
                            userDashboard.Show();
                            this.Hide();
                            



                        }

                        // MessageBox.Show("UserName And Password aren't Match");
                    }
                    else if (UserNameFromDB.Text == "" && PasswordFromDB.Text == "")
                    {

                        MessageBox.Show("UserName And Password aren't Match", "Check Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }



                }

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string UserNameToDashboard = "";//send username and position to dashboard to preview
        public static string UserRoleToDashboard = "";
        public static string UserProfilePIcNUmber = "";
        public static string USerID = "";



        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string ToCheckUsername = TbLoginUsername.Text.Trim();
            string TocheckPassword = TbloginPass.Text.Trim();

            if (ToCheckUsername == "" || TocheckPassword == "")
            {
                //check is there any empty field
                MessageBox.Show("Fill all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {

                //open db connection to get data from db to match username and password to log in
                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();

                if (DB_conn.State == System.Data.ConnectionState.Open) {

                    SqlCommand Command = new SqlCommand("SELECT PersonName,Username,UserPassword,UserType,ProfileImage,SystemUserID from SystemUsers where Username = '" + ToCheckUsername + "' AND UserPassword = '" + TocheckPassword + "'", DB_conn);
                    SqlDataReader row = Command.ExecuteReader();

                    while (row.Read())
                    {
                        // get data from db to tb for matching
                        NameFromDB.Text = row.GetValue(0).ToString();
                        UserNameFromDB.Text = row.GetValue(1).ToString();
                        PasswordFromDB.Text = row.GetValue(2).ToString();
                        UserRoleFromDB.Text = row.GetValue(3).ToString();
                        ProPicTB.Text = row.GetValue(4).ToString();
                        USerID = row.GetValue(5).ToString();



                    }

                    if (UserNameFromDB.Text == ToCheckUsername && PasswordFromDB.Text == TocheckPassword)
                    {
                        if (UserRoleFromDB.Text == "Admin user")     //check what is the user role
                        {

                            //assign user's name and position to that vsriables
                            UserNameToDashboard = NameFromDB.Text;
                            UserRoleToDashboard = UserRoleFromDB.Text;
                            UserProfilePIcNUmber = ProPicTB.Text;



                            Dashboard admindashboard = new Dashboard();
                            admindashboard.Show();
                            this.Hide();

                        }
                        else if (UserRoleFromDB.Text == "Nomal user")
                        {

                            /*
                            UserDashboard UserDashbrd = new UserDashboard();
                            UserDashbrd.Show();
                            this.Hide();
                            */



                        }

                        // MessageBox.Show("UserName And Password aren't Match");
                    }
                    else if (UserNameFromDB.Text == "" && PasswordFromDB.Text == "")
                    {

                        MessageBox.Show("UserName And Password aren't Match" ,"Check Again", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }



                }

            }

            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loginProcess();
        }

        private void TbloginPass_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;


        private void AddNewUser_Load(object sender, EventArgs e)
        {
            ImageName.Text = "";
        }

        private void AddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //assign input data to variables
            string dbPersonName = NameTb.Text.Trim();
            string dbPersonTelNo = PhoneTb.Text.Trim();
            string dbPersonEmail = EmailTb.Text.Trim();
            string DbPersonAddress = AddressTb.Text.Trim();

            //User Access data

            string SystemUserName = SysUsernameTb.Text.Trim();
            string SystemPassword = SysPasstb.Text.Trim();
            string SysComPassword = SysComPAssTb.Text.Trim();

            //profileImage
            string ProfileImageNumber = "";
            if (SelectedImg.Text == "")
            {
                ProfileImageNumber = "Img1";
            }
            else
            {
                ProfileImageNumber = SelectedImg.Text.Trim();
            }
            


            //radio button check
            string SystemUserType = "";
            if (RbAdminUser.Checked) {
                 SystemUserType = RbAdminUser.Text;

            }
            else if (RbNomalUser.Checked) { 
                 SystemUserType = RbNomalUser.Text;

            }

            //data validation

            if (dbPersonName == "" || dbPersonTelNo == "" || dbPersonEmail == "" || DbPersonAddress == "" || SystemUserName == "" || SystemPassword == "" || SysComPassword == "" || SystemUserType == "") {

                MessageBox.Show("Please Fill Out All The Details", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            //check password is same or not
            if (SystemPassword != SysComPassword)
            {
                MessageBox.Show("Passwords are don't match", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else {

                //insert data to db & check connection
                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();
                if (DB_conn.State == System.Data.ConnectionState.Open)
                {

                    DateTime CurrentDateTime = DateTime.Now; //eget data time when add new user

                    string SqlQuery = "INSERT INTO SystemUsers (PersonName,PersonTelNo,PersonEmail,PersonAddress,UserRegDateTime,UserStatus,Username,UserPassword,UserType,ProfileImage) VALUES ('" + dbPersonName + "','" + dbPersonTelNo + "','" + dbPersonEmail + "','" + DbPersonAddress + "','" + CurrentDateTime + "','Active','" + SystemUserName + "','" + SystemPassword + "','" + SystemUserType + "','" + ProfileImageNumber + "')";

                    SqlCommand Cmd = new SqlCommand(SqlQuery, DB_conn);
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Inserted Successfully", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DB_conn.Close();
                }
                else {

                    MessageBox.Show("Connection Error", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //conformation msg box

            DialogResult clearInputFields = MessageBox.Show("Do you want to clear all fields","Conform",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

            if (clearInputFields == DialogResult.Yes)
            {  //clear all input felds

                NameTb.Text = "";
                PhoneTb.Text = "";
                EmailTb.Text = "";
                AddressTb.Text = "";
                SysUsernameTb.Text = "";
                SysPasstb.Text = "";
                SysComPAssTb.Text = "";
                RbAdminUser.Checked = false;
                RbNomalUser.Checked = false;
                SelectedImg.Text = "";


            }
            
        }

        private void EmailTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectedImg.Text = "Img1";
            ImageName.Text = "Image 1 Selected";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SelectedImg.Text = "Img2";
            ImageName.Text = "Image 2 Selected";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SelectedImg.Text = "Img3";
            ImageName.Text = "Image 3 Selected";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SelectedImg.Text = "Img4";
            ImageName.Text = "Image 4 Selected";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SelectedImg.Text = "Img5";
            ImageName.Text = "Image 5 Selected";
        }
    }
}

/*
 red lite #D8143A , #B4002B
blue        #2d89ef , #2b5797
green       #00A300 , #1E7145



 
 */

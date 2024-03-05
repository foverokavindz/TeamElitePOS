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
    public partial class UpdateUser : Form
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


        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        public UpdateUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void RbNomalUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbAdminUser_CheckedChanged(object sender, EventArgs e)
        {

        }


        string RbstatusValue = "";
        string RbUserTypeValue = "";
        private void UpdateUser_Load(object sender, EventArgs e)
        {
            //assign cus data to text boxes
            UserIdTb.Text = ViewUsers.USERID;
            NameTb.Text = ViewUsers.USERSNAME;
            PhoneTb.Text = ViewUsers.USERPHONE;
            EmailTb.Text = ViewUsers.USEREMAIL;
            AddressTb.Text = ViewUsers.USERADDRESS;

            //assign user status to ratio buttons

            if (ViewUsers.USERSTATUS == "Active")
            {
                RBactive.Checked = true;
                RbstatusValue = "Active";
            }
            else if (ViewUsers.USERSTATUS == "Deactive")
            {

                RBdeactive.Checked = true;
                RbstatusValue = "Deactive";
            }

            //assign user role to ratio buttons

            if (ViewUsers.USERTYPE == "Admin user")
            {
                RbAdminUser.Checked = true;
                RbUserTypeValue = "Admin user";
            }
            else if (ViewUsers.USERTYPE == "Nomal user")
            {

                RbNomalUser.Checked = true;
                RbUserTypeValue = "Nomal user";
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UserIdTb.Text != ViewUsers.USERID || NameTb.Text != ViewUsers.USERSNAME || PhoneTb.Text != ViewUsers.USERPHONE || EmailTb.Text != ViewUsers.USEREMAIL || AddressTb.Text != ViewUsers.USERADDRESS || RbstatusValue != ViewUsers.USERSTATUS || RbUserTypeValue != ViewUsers.USERTYPE)
            {
                DialogResult Closethis = MessageBox.Show("Do you want cancel - Changed data will be lose", "Conform", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (Closethis == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {

                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //assign data values for database process
            string ToDBID = UserIdTb.Text.Trim();
            string ToDBName = NameTb.Text.Trim();
            string ToDBPhone = PhoneTb.Text.Trim();
            string ToDBEmail = EmailTb.Text.Trim();
            string ToDBAddress = AddressTb.Text.Trim();

            // radio button check status
            string ToDBUserStatus = "";
            if (RBactive.Checked)
            {
                ToDBUserStatus = "Active";

            }
            else if (RBdeactive.Checked)
            {
                ToDBUserStatus = "Deactive";

            }

            // radio button check user type
            string ToDBUserType = "";
            if (RbAdminUser.Checked)
            {
                ToDBUserType = "Admin user";

            }
            else if (RbNomalUser.Checked)
            {
                ToDBUserType = "Nomal user";

            }


            if (ToDBID == "" || ToDBName == "" || ToDBPhone == "" || ToDBUserStatus == "" || ToDBUserType == "")
            {

                MessageBox.Show("Please Fill Out All The Details", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();
                if (DB_conn.State == System.Data.ConnectionState.Open)
                {
                    
                    string SqlQuery1 = "UPDATE SystemUsers SET PersonName = '" + ToDBName + "',PersonTelNo = '" + ToDBPhone + "',PersonEmail = '" + ToDBEmail + "',PersonAddress = '" + ToDBAddress + "',UserStatus = '" + ToDBUserStatus + "',UserType = '" + ToDBUserType + "'  where SystemUserID = '" + ToDBID + "' ";

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

        private void EmailTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

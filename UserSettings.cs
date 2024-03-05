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
using POS_Team_Elite.Properties; // refer settings made by user

namespace POS_Team_Elite
{
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
            ClosePanels();
            PnaelAddNew.Location = new Point(46, 212);
            UpdatePassPanel.Location = new Point(46, 306);
            UpdateAvatarImagePanel.Location = new Point(47, 399);


        }


        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";

        private void ClosePanels() // hide gray color panels when window load
        {

            PnaelAddNew.Visible = false;
            UpdatePassPanel.Visible = false;
            UpdateAvatarImagePanel.Visible = false;

        }

        private void NotoficationPreview(string Error__Success_Warning,string Message) //a funtion to show notifation when action was done
        
        {            
            SuccessNotofiLableTop.Visible = true;//make it visible when show
            SuccessNotofiLableTop.Text = Message; // assign msg to lable

            if (Error__Success_Warning == "Error") // get message type and select relevent lable setting
            {
                SuccessNotofiLableTop.ForeColor = Color.Black;
                SuccessNotofiLableTop.BackColor = Color.Red;
            }
            else if (Error__Success_Warning == "Success")
            {
                SuccessNotofiLableTop.ForeColor = Color.DarkSlateGray;
                SuccessNotofiLableTop.BackColor = Color.SpringGreen;
            }
            else if (Error__Success_Warning == "Warning") {

                SuccessNotofiLableTop.ForeColor = Color.FromArgb(64, 64, 0);
                SuccessNotofiLableTop.BackColor = Color.Gold;

            }
            // timer for dissaplear that notification after 3 seconds
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                SuccessNotofiLableTop.Hide();
                t.Stop();
            };
            t.Start();

        }       
        

        private void UserSettings_Load(object sender, EventArgs e)
        {
            ConnStringNow.Text = Settings.Default["EliteDBConnectionString"].ToString(); // assign connection string to textbox
            UserIDfromDashboard.Text = Dashboard.LoginIdOfUser.Trim(); // assign user id to that labale to change password and avatr
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreConnString.Text = Settings.Default["previousConnString"].ToString();
            UpdatePassPanel.Visible = false;
            UpdateAvatarImagePanel.Visible = false;
            PnaelAddNew.Visible = true;

            ChangePassPanel.Location = new Point(46, 443);
            ChnageAvatarPanel.Location = new Point(46, 532);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default["EliteDBConnectionString"] = ConnStringTb.Text.Trim() + "MultipleActiveResultSets=true";
            Settings.Default.Save();
            //Settings.Default["previousConnString"] = ConnStringNow.Text.Trim();
           // Settings.Default.Save();
            PnaelAddNew.Visible = false;

            ChangePassPanel.Location = new Point(46, 236);
            ChnageAvatarPanel.Location = new Point(46, 330);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClosePanels();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PnaelAddNew.Visible = false;
            ConnStringTb.Text = "";

            ChangePassPanel.Location = new Point(46, 236);
            ChnageAvatarPanel.Location = new Point(46, 330);
          

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            //UserSettings.AutoScroll = true;
            PnaelAddNew.Visible = false;
            UpdateAvatarImagePanel.Visible = false;
            UpdatePassPanel.Visible = true;

            
            ChangePassPanel.Location = new Point(46, 236);

            ChnageAvatarPanel.Location = new Point(46, 749);


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tbOldPass.Text = "";
            tbNewPass.Text = "";
            TbConfirmPass.Text = "";
            UpdatePassPanel.Visible = false;
            ChnageAvatarPanel.Location = new Point(46, 330);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string OLdPass = tbOldPass.Text.Trim();
            string NewPAss = tbNewPass.Text.Trim();
            string ConfirmPass = TbConfirmPass.Text.Trim();



            if (OLdPass == "" || NewPAss == "" || ConfirmPass == "")
            {

                //MessageBox.Show("Please Fill Out All The Details", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NotoficationPreview("Warning", "Please Fill Out All The Details");

            }
            else {

                if (NewPAss != ConfirmPass)
                {

                    //MessageBox.Show("New and conform passwords are not match", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NotoficationPreview("Error", "New and conform passwords are not match");
                }
                else if (NewPAss == ConfirmPass)
                {

                    SqlConnection DB_conn = new SqlConnection(ConnectionString);
                    DB_conn.Open();
                    if (DB_conn.State == System.Data.ConnectionState.Open)
                    {
                        // SystemUsers (PersonName,PersonTelNo,PersonEmail,PersonAddress,UserRegDateTime,UserStatus,Username,UserPassword,UserType)

                        SqlCommand Command = new SqlCommand("SELECT UserPassword from SystemUsers where SystemUserID = '" + UserIDfromDashboard.Text + "'", DB_conn);
                        SqlDataReader row = Command.ExecuteReader();

                        string OldPassFromDB = "";
                        while (row.Read())
                        {
                            // get data from db to tb for matching
                            OldPassFromDB = row.GetValue(0).ToString();

                        }
                        row.Close();
                        if (OldPassFromDB == OLdPass)
                        {
                            string SqlQuery1 = "UPDATE SystemUsers SET UserPassword = '" + NewPAss + "' where SystemUserID = '" + UserIDfromDashboard.Text + "' ";

                            SqlCommand CmdX = new SqlCommand(SqlQuery1, DB_conn);
                            CmdX.ExecuteNonQuery();

                            //MessageBox.Show(" Password Updated successfully ");
                            NotoficationPreview("Success", "Password Updated successfully");


                            DB_conn.Close();

                        }
                        else if (OldPassFromDB != OLdPass)
                        {
                            //MessageBox.Show("Old Password does not match", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NotoficationPreview("Error", "Old Password does not match");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Connection Error");
                    }

                }

            }


            

            UpdatePassPanel.Visible = false;
            ChnageAvatarPanel.Location = new Point(46, 330);


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (UpdatePassPanel.Visible == true)
            {
                UpdatePassPanel.Visible = false;
                ChnageAvatarPanel.Location = new Point(46, 284);
            }
            else
            {
                ChnageAvatarPanel.Location = new Point(46, 330);
            }
            //UpdatePassPanel.Visible = false;
            PnaelAddNew.Visible = false;
            ChangePassPanel.Location = new Point(46, 236);

            //ChnageAvatarPanel.Location = new Point(46, 330);
            UpdateAvatarImagePanel.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateAvatarImagePanel.Visible = false;
        }


        string SlectdImg = "";
        private void button9_Click(object sender, EventArgs e)
        {
            
            if (SlectdImg == "")
            {
                //MessageBox.Show("Select Image First", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NotoficationPreview("Warning", "Select Image First");
            }
            else
            {
                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();
                if (DB_conn.State == System.Data.ConnectionState.Open)
                {
                    string SqlQuery1 = "UPDATE SystemUsers SET ProfileImage = '" + SlectdImg + "' where SystemUserID = '" + UserIDfromDashboard.Text + "' ";

                        SqlCommand CmdX = new SqlCommand(SqlQuery1, DB_conn);
                        CmdX.ExecuteNonQuery();

                        //MessageBox.Show(" Prifile Image Updated successfully ");
                        NotoficationPreview("Success", "Prifile Image Updated successfully");

                    DB_conn.Close();
                    Dashboard ChangeProPic = new Dashboard();

                    if (SlectdImg == "Img1")// select correct picturebox
                    {                        
                        ChangeProPic.ShowPicture(Pic1);
                        
                    }
                    else if (SlectdImg == "Img2")
                    {
                        ChangeProPic.ShowPicture(Pic2);
                    }
                    else if (SlectdImg == "Img3")
                    {
                        ChangeProPic.ShowPicture(Pic3);
                    }
                    else if (SlectdImg == "Img4")
                    {
                        ChangeProPic.ShowPicture(Pic4);
                    }
                    else if (SlectdImg == "Img5")
                    {
                        ChangeProPic.ShowPicture(Pic5);
                    }
                    


                }
                else
                {
                    MessageBox.Show("Connection Error");
                }

            }

            //string ImageNumber = "";
            UpdateAvatarImagePanel.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PnaelAddNew_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Img1_Click(object sender, EventArgs e)
        {
            SlectdImg = "Img1";
            SELECTEDiMAGE.Text = "Image 1 Selected";
        }

        private void Img2_Click(object sender, EventArgs e)
        {
            SlectdImg = "Img2";
            SELECTEDiMAGE.Text = "Image 2 Selected";
        }

        private void Img3_Click(object sender, EventArgs e)
        {
            SlectdImg = "Img3";
            SELECTEDiMAGE.Text = "Image 3 Selected";
        }

        private void Img4_Click(object sender, EventArgs e)
        {
            SlectdImg = "Img4";
            SELECTEDiMAGE.Text = "Image 4 Selected";
        }

        private void Img5_Click(object sender, EventArgs e)
        {
            SlectdImg = "Img5";
            SELECTEDiMAGE.Text = "Image 5 Selected";
        }
    }
}

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

namespace POS_Team_Elite
{
    public partial class Dashboard : Form
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
        
        
        public Dashboard()
        {
            InitializeComponent();
            CustomizeDesign();
            CustomizeDesignCollapsed();
            OpenChildForm(new DashboardData());
            MainCollapsedSidePanel.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30,30));

        }

        public static string ShareUserName = "";//share these details between window forms
        public static string ShareUserType = "";



        //method for hide submenu Panels
        private void CustomizeDesign() {

            panelUsersSubmenu.Visible = false;
            panelStockSubmenu.Visible = false;
            panelCustomersSubmenu.Visible = false;

        }

        //method for hide Collapsed submenupanels
        private void CustomizeDesignCollapsed()
        {

            panelCollapsedUserSub.Visible = false;
            panelCollapsedStockSub.Visible = false;
            panelCustomersSubmenu.Visible = false;

        }




        //method to show sub menu panels previously hidden
        private void hideSubmenu() {

            if (panelUsersSubmenu.Visible == true) {
                panelUsersSubmenu.Visible = false;
            }
            if (panelCustomersSubmenu.Visible == true) {
                panelCustomersSubmenu.Visible = false;
            }
            if (panelStockSubmenu.Visible == true) {
                panelStockSubmenu.Visible = false;
            }

        }


        //method to show Collapsed sub menu panels previously hidden
        private void hideSubmenuCollapsed()
        {

            if (panelCollapsedUserSub.Visible == true)
            {
                panelCollapsedUserSub.Visible = false;
            }
            if (panelCollapsedStockSub.Visible == true)
            {
                panelCollapsedStockSub.Visible = false;
            }
            if (panelCollapsedCustomerSub.Visible == true)
            {
                panelCollapsedCustomerSub.Visible = false;
            }

        }


        //method for display submenu
        private void ShowSubMenu(Panel submenu) {
            if (submenu.Visible == false) {
                hideSubmenu();
                submenu.Visible = true;

            }
            else {
                submenu.Visible = false;
            }
        }

        //method for display Collapsed submenu

        private void ShowSubMenuCollapsed(Panel submenuCollapsed)
        {
            if (submenuCollapsed.Visible == false)
            {
                hideSubmenuCollapsed();
                submenuCollapsed.Visible = true;

            }
            else
            {
                submenuCollapsed.Visible = false;
            }
        }

        //childform opening method
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {

            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



        private void CloseBtn_Click(object sender, EventArgs e)
        {
            var logWind = new LoginWindow();
            logWind.Show();

            this.Hide();        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelUsersSubmenu);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewUser());
            
        }

        private void BtnViewUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewUsers());
            
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStockSubmenu);
        }

        private void BtnAddNewProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewProduct());
            
        }

        private void BtnViewProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewProduct());
            
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCustomersSubmenu);
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewCustomers());
           
            
        }

        private void BtnViewCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCustomers());
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardData());
            hideSubmenu();
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoices());
            hideSubmenu();
        }


        
        private void BtnNewBill_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            NewBIllWindow Billnew = new NewBIllWindow();
            Billnew.Show();
            
        }

        public void ShowPicture(PictureBox PicNo)//funtion to show picture rellevent to user
        {
            PicNo.Visible = true;
            //PicNo.Location = new Point(83, 39);           

            if (MainCollapsedSidePanel.Visible == true && MainSidePanel.Visible == false)
            {
                pictureBox2.Image = PicNo.Image;//it is not working
                PicNo.BringToFront();// show on top
                

            } else if (MainCollapsedSidePanel.Visible == false && MainSidePanel.Visible == true) {


                PicNo.Location = new Point(83 + panel1.AutoScrollPosition.X, 39 + panel1.AutoScrollPosition.Y);//picture show on panel1
               
                PicNo.BringToFront();// show on top

            }

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = LoginWindow.UserNameToDashboard.Trim();//get user data from login window
            UserPosition.Text = LoginWindow.UserRoleToDashboard.Trim();
            SelectedImageLabel.Text = LoginWindow.UserProfilePIcNUmber.Trim();
            UserIDfromLogin.Text = LoginWindow.USerID.Trim();



            if (SelectedImageLabel.Text == "Img1")// select correct picturebox
            {
                ShowPicture(Pic1);
            }else if(SelectedImageLabel.Text == "Img2")
            {
                ShowPicture(Pic2);
            }
            else if (SelectedImageLabel.Text == "Img3")
            {
                ShowPicture(Pic3);
            }
            else if (SelectedImageLabel.Text == "Img4")
            {
                ShowPicture(Pic4);
            }
            else if (SelectedImageLabel.Text == "Img5")
            {
                ShowPicture(Pic5);
            }
            else if (SelectedImageLabel.Text == "")
            {
                ShowPicture(Pic1);
            }

            ShareUserName = UserNameLabel.Text;//show user name and role
            ShareUserType = UserPosition.Text;



            timer1.Start();
            TimeNowDynamic.Text = DateTime.Now.ToLongTimeString();//display time dynamic
            DateDynamic.Text = DateTime.Now.ToLongDateString();//display time dynamic
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MainSidePanel.Visible = false;
            MainCollapsedSidePanel.Visible = true;
            hideSubmenu();
            hideSubmenuCollapsed();


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MainSidePanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainSidePanel.Visible = true;
            MainCollapsedSidePanel.Visible = false;
            hideSubmenu();
            hideSubmenuCollapsed();
            


        }

        private void BtnCollapsedUsers_Click(object sender, EventArgs e)
        {
            ShowSubMenuCollapsed(panelCollapsedUserSub);
        }

        private void BtnCollapsedStock_Click(object sender, EventArgs e)
        {
            ShowSubMenuCollapsed(panelCollapsedStockSub);

        }

        private void BtnCollapsedCustomers_Click(object sender, EventArgs e)
        {
            
            ShowSubMenuCollapsed(panelCollapsedCustomerSub);

        }

        private void BtnCollapsedAddUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewUser());
        }

        private void BtnCollapsedDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardData());
            hideSubmenuCollapsed();
        }

        private void BtnCollapsedInvoices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoices());
            hideSubmenuCollapsed();
        }

        private void BtnCollapsedNewBill_Click(object sender, EventArgs e)
        {
            hideSubmenuCollapsed();
            NewBIllWindow Billnew = new NewBIllWindow();
            Billnew.Show();
            this.Hide();
        }

        private void BtnCollapsedSetting_Click(object sender, EventArgs e)
        {
            LoginIdOfUser = UserIDfromLogin.Text.Trim();//assing user id to send setting window
            OpenChildForm(new UserSettings());
            hideSubmenuCollapsed();
        }

        private void BtnCollapsedViewCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCustomers());
        }
        private void BtnCollapsedAddCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewCustomers());
        }

        private void BtnCollapsedViewProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewProduct());
        }

        private void BtnCollapsedAddProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewProduct());
        }

        private void BtnCollapsedViewUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewUsers());
        }

        private void BtnSidebarOn_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BtnSidebarOff_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panelChildForm_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }


        public static string LoginIdOfUser = "";//assing user id to send setting window
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            
            LoginIdOfUser = UserIDfromLogin.Text.Trim(); //assing user id to send setting window
            OpenChildForm(new UserSettings());
            hideSubmenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNowDynamic.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();//to display time dynamicly 
        }
    }
}

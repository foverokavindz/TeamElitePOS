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

namespace POS_Team_Elite
{
    public partial class UserDashboard : Form
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



        public UserDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelExtractCollapes(mainPanel, 0, 643, 185);
            panelExtractCollapes(avatarPanel, 0, 587, 88);            
            panelExtractCollapes(passwordPanel, 0, 587, 88);
        }

        // Special methods
        // 
        Boolean isMainPanelExtracted = false;
        Boolean isPasswordPanelExtracted = false;
        Boolean isavatarPanelExtracted = false;

        private void collapesMainPanel() {

            mainPanel.Size = new Size(643, 140);
            isMainPanelExtracted = false;
        }
        private void extractMainPanel() {

            mainPanel.Size = new Size(643, 363);
            isMainPanelExtracted = true;
        }
        //private void panelExtractCollapes(Panel panel, int panelState, int width, int height, bool isExtracted)
        private void panelExtractCollapes(Panel panel, int panelState, int width, int height)
        {
            //panel state = 0 means - Panel need to be collapes
            if (panelState == 0)
            {
                panel.Size = new Size(width, height);                
            }
            else if (panelState == 1)
            {
                panel.Size = new Size(width, height);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isMainPanelExtracted == true)
            {
                
                panelExtractCollapes(mainPanel, 0, 643, 185);
                isMainPanelExtracted = false;
                panelExtractCollapes(passwordPanel, 0, 587, 88);
                isPasswordPanelExtracted = false;
                panelExtractCollapes(avatarPanel, 0, 587, 88);
                isavatarPanelExtracted = false;                
                
            }
            else if(isMainPanelExtracted == false)
            {
                
                panelExtractCollapes(mainPanel, 1, 643, 400);
                isMainPanelExtracted = true;

            }
        }

        private void showBtnPassword_Click(object sender, EventArgs e)
        {
                    
            if (isPasswordPanelExtracted == true)
            {
                panelExtractCollapes(passwordPanel, 0, 587, 88);
                isPasswordPanelExtracted = false;
                mainPanel.Size = new Size(643, 400);

            }
            else if (isPasswordPanelExtracted == false || isavatarPanelExtracted == true)
            {
                panelExtractCollapes(passwordPanel, 1, 587, 445);
                isPasswordPanelExtracted = true;
                panelExtractCollapes(avatarPanel, 0, 587, 88);
                isavatarPanelExtracted = false;
                mainPanel.Size = new Size(643, 739);
            }

        }

        private void showBtnAvatar_Click(object sender, EventArgs e)
        {

           
        }

        private void showBtnAvatar_Click_1(object sender, EventArgs e)
        {
            if (isavatarPanelExtracted == true)
            {
                panelExtractCollapes(avatarPanel, 0, 587, 88);
                isavatarPanelExtracted = false;
                mainPanel.Size = new Size(643, 400);

            }
            else if (isavatarPanelExtracted == false || isPasswordPanelExtracted == true)
            {
                panelExtractCollapes(avatarPanel, 1, 587, 347);
                isavatarPanelExtracted = true;
                panelExtractCollapes(passwordPanel, 0, 587, 88);
                isPasswordPanelExtracted = false;
                mainPanel.Size = new Size(643, 657);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

// setting box size  - 587, 88 --- 587, 445 --- 587, 347 ---- 643, 620

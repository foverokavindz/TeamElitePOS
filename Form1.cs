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
    public partial class LoadingWindow : Form
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
        public LoadingWindow()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40 , 40 ));
            ProgressBar1.Value = 0;
            
        }


        
        private void timer1_Tick(object sender, EventArgs e)
        {
           /*
           // loadingPanel.Width += 3;

            if (loadingPanel.Width <= 820)
            {
                timer2.Enabled = false;
                timer2.Stop();
                // LoginWindow lg = new LoginWindow();
                //lg.Show();
                //this.Hide();
            }*/
            

        }

        private void LoadingWindow_Load(object sender, EventArgs e)
        {

            timer1.Start(); // start timer to loading
            /*
            int x = 85;
            timer1.Start();
            while (timer1.Enabled == true)
            {
                loadingPanel.Location = new Point(364, 0);


                loadingPanel.Size = new Size(x,28);
                

                if (loadingPanel.Width <= 820)
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                    // LoginWindow lg = new LoginWindow();
                    //lg.Show();
                    //this.Hide();
                }
                x += 3;
            }*/


        }

        private void timer1_Tick_1(object sender, EventArgs e) // code to show loading panel
        {
            
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";        
                                   
            
            if (ProgressBar1.Value == 100) // panel eka ee digt awma stop wenawa
            {
                timer1.Stop();
                timer1.Enabled = false;
                LoginWindow lg = new LoginWindow();
                lg.Show();
                this.Hide();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

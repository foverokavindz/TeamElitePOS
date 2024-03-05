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
    public partial class DashboardData : Form
    {
        public DashboardData()
        {
            InitializeComponent();
            ShowIncomeToday();
            ShowTopSellingItem();
            CheckOutOfStock();
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Pink;
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Crimson;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Nirmala UI", 10,FontStyle.Bold);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 9, FontStyle.Bold);

            ReminderSettingPanel.Visible = false;
        }
        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void DashboardData_Load(object sender, EventArgs e)
        {
            

            //NotfyPanel.Location = new Point(615, 544); // collap notification panel when windows load
            NotfyPanel.Size = new Size(429, 89);
            BtnNotifyBarDown.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void ShowIncomeToday() {// to show today income

            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                // sql statement ekenma column deke sum ekak wena wenama aran result eka enne 3n weni val eka widiyt nisa 3n weni val eka read krla show kala
                SqlCommand Command1 = new SqlCommand("SELECT SUM(TotalDue) as 'tot' , SUM(Discount) as 'Dis' , (SUM (TotalDue) - SUM (Discount)) as 'Total' FROM Invoice ", DB_conn);
                SqlDataReader row = Command1.ExecuteReader();

                row.Read();
                TodayIncomeTB.Text = row.GetValue(2).ToString().Trim();
                row.Close();
                DB_conn.Close();
                
            }
            else
            {
                MessageBox.Show("Connection Error");
            }

        }

        private void ShowTopSellingItem() { // to get top selling item 

            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                //first select most repeted barcode
                SqlCommand Command = new SqlCommand("SELECT TOP 1 ProductBcode from InvoiceProduct", DB_conn); // date condion eka dnna ona
                SqlDataReader row = Command.ExecuteReader();

                if (row.HasRows)
                {

                    row.Read();
                    String TopSellingBcode = row.GetValue(0).ToString().Trim();
                    row.Close();
                    // then find rellevent product name according to barcode
                    SqlCommand Command2 = new SqlCommand("SELECT ProductName from ProductsDetails Where ProductBcode = '" + TopSellingBcode + "'", DB_conn);
                    SqlDataReader row2 = Command2.ExecuteReader();

                    row2.Read();
                    TopSellignTB.Text = row2.GetValue(0).ToString().Trim();
                    row2.Close();
                    DB_conn.Close();
                }
                else
                {
                    MessageBox.Show("No data found for the top selling item.");
                }
                row.Close();




            }
            else
            {
                MessageBox.Show("Connection Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        //method to show is there any out of stock item

        string RemainingProductCount = Settings.Default["ProductNotificationNumber"].ToString(); // call settings frm system properties
        private void CheckOutOfStock() {

            
            DataTable NotifyTable = new DataTable();
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                // run different sql query for user reminder option count
                if (RemainingProductCount == "0")
                {
                    string SqlQuery = "SELECT ProductBcode,ProductName FROM ProductsDetails WHERE ProductCount <= 0";
                    SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlQuery, DB_conn);
                    DataAdapter.Fill(NotifyTable);
                    lableProductStatus.Text = "Out of Stock";
                }
                else if(RemainingProductCount == "5")
                {
                    string SqlQuery = "SELECT ProductBcode,ProductName FROM ProductsDetails WHERE ProductCount <= 5";
                    SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlQuery, DB_conn);
                    DataAdapter.Fill(NotifyTable);
                    lableProductStatus.Text = "Almost Over";
                }
                else if(RemainingProductCount == "10")
                {
                    string SqlQuery = "SELECT ProductBcode,ProductName FROM ProductsDetails WHERE ProductCount <= 10";
                    SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlQuery, DB_conn);
                    DataAdapter.Fill(NotifyTable);
                    lableProductStatus.Text = "Few Remaining";
                }
                

                DB_conn.Close();

                dataGridView1.DataSource = NotifyTable;
                dataGridView1.Columns[0].HeaderText = "Barcode";
                dataGridView1.Columns[1].HeaderText = "Name";
                
            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }

        public void showHideNotfySettingPanel() {

            ReminderSettingPanel.Visible = true;

        }

        private void btnReminderSetting_Click(object sender, EventArgs e)
        {
            ReminderSettingPanel.Visible = true;
            ReminderSettingPanel.Location = new Point(73, 0);
            ReminderSettingPanel.BringToFront();
            comboBox1ProductCount.Text = Settings.Default["ProductNotificationNumber"].ToString();
        }

        
        private void btnNotifySettingUpdate_Click(object sender, EventArgs e)
        {

            //comboBox1ProductCount.Text = Settings.Default["ProductNotificationNumber"].ToString();

            if (comboBox1ProductCount.Text == "")
            {
                RemainingProductCount = Settings.Default["ProductNotificationNumber"].ToString(); // get previous setting from system settings made by user
            }
            else
            {
                RemainingProductCount = comboBox1ProductCount.Text.Trim();
                Settings.Default["ProductNotificationNumber"] = comboBox1ProductCount.Text.Trim();
                Settings.Default.Save();
            }

            
            CheckOutOfStock();
            ReminderSettingPanel.Visible = false;// hide reminder setting panel
        }

        private void BtnSidebarOn_Click(object sender, EventArgs e)
        {
           // notification panel eka show krnawa
            NotfyPanel.Size = new Size(429, 491);
            
            //NotfyPanel.Location = new Point(615, 142);
            
            BtnNotifyBarDown.Location = new Point(351, 16);
            BtnNotifyBarUp.Visible = false;// downkrna button eka visible krla anika off krnawa
            BtnNotifyBarDown.Visible = true;

        }

        private void BtnNotifyBarDown_Click(object sender, EventArgs e)
           // notification panel eka collapse krnawa
        {
            //NotfyPanel.Location = new Point(615, 544);
            NotfyPanel.Size = new Size(429, 89);            
            BtnNotifyBarUp.Visible = true;// upkrna button eka visible krla anika off krnawa
            BtnNotifyBarDown.Visible = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}


//SELECT TOP 1 ProductBcode from [EliteDB].[dbo].[InvoiceProduct]
// top selling item code

/*
 
Select ProductName 
from [EliteDB].[dbo].[InvoiceProduct],[EliteDB].[dbo].[ProductsDetails]
Where[EliteDB].[dbo].[ProductsDetails].ProductBcode = [EliteDB].[dbo].[InvoiceProduct].ProductBcode and



Select ProductName 
from [EliteDB].[dbo].[InvoiceProduct],[EliteDB].[dbo].[ProductsDetails]
Where ProductBcode.InvoiceProductID = ProductName.ProductBcode

*/
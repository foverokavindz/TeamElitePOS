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
using POS_Team_Elite.connection;
using System.Configuration;

namespace POS_Team_Elite
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
            

        }

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        private void AddNewProduct_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //assign textbox input data to varibles for easy
            string ItemCategory = SelectCategory.Text.Trim();
            string ItemBCode = BcodeTb.Text.Trim();
            string ItemName = ItemNameTb.Text.Trim();
            string ItemDescription = ItemDesTb.Text.Trim();
            string ItemStatus = SelectItemStatus.Text.Trim();
            string ItemCount = ItemCountTb.Text.Trim();
            string ItemUnitPrice = ItemUnitPriceTb.Text.Trim();
            string ItemCostPrice = ItemCostPriceTb.Text.Trim();
            string ItemSellingPrice = ItemSellingPriceTb.Text.Trim();
            string ItemDiscount = SelectDiscount.Text.Trim();
            string ItemProfitPrice = ItemProfitTb.Text.Trim();

            //validation is there all felds were filed
            if (ItemCategory == "" || ItemBCode == "" || ItemName == "" || ItemDescription == "" || ItemStatus == "" || ItemCount == "" || ItemUnitPrice == "" || ItemCostPrice == "" || ItemSellingPrice == "" || ItemDiscount == "" || ItemProfitPrice == "")
            {

                MessageBox.Show("Please Fill Out All The Details", "Add New Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                

                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();
                if (DB_conn.State == System.Data.ConnectionState.Open)
                {

                    string SqlQuery = "INSERT INTO ProductsDetails (ProductBcode,ProductName,ProductDescription,ProductCategory,ProductUnitPrice,ProductCostPrice,ProductCount,ProductSellPrice,ProductStatus,ProductDiscount,ProductProfit) VALUES ('" + ItemBCode + "','" + ItemName + "','" + ItemDescription + "','" + ItemCategory + "','" + ItemUnitPrice + "','" + ItemCostPrice + "','" + ItemCount + "','" + ItemSellingPrice + "','" + ItemStatus + "','" + ItemDiscount + "','" + ItemProfitPrice + "')";

                    SqlCommand Cmd = new SqlCommand(SqlQuery, DB_conn);
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("New item added Successfully", "New Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DB_conn.Close();

                }
                else
                {
                    MessageBox.Show("Connection Error", "New Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ItemProfitTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCategory.Text = "";
            BcodeTb.Text = "";
            ItemNameTb.Text = "";
            ItemDesTb.Text = "";
            SelectItemStatus.Text = "";
            ItemCountTb.Text = "";
            ItemUnitPriceTb.Text = "";
            ItemCostPriceTb.Text = "";
            ItemSellingPriceTb.Text = "";
            SelectDiscount.Text = "";
            ItemProfitTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(ItemCountTb.Text);
            int y = Convert.ToInt32(ItemUnitPriceTb.Text);
            int CostPrice = x * y;
            ItemCostPriceTb.Text = CostPrice.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

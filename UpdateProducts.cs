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
using System.Configuration;

namespace POS_Team_Elite
{
    public partial class UpdateProducts : Form
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
        public UpdateProducts()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            // assign pruduct data to text boxes

            BcodeTb.Text = ViewProduct.ITEMBARCODE;
            ItemNameTb.Text = ViewProduct. ITEMNAME;
            ItemDesTb.Text = ViewProduct. ITEMDESCRIPTION;
            SelectCategory.Text = ViewProduct. ITEMCATEGORY;
            ItemUnitPriceTb.Text = ViewProduct. ITEMUNITPRICE;
            ItemCostPriceTb.Text = ViewProduct. ITEMCOSTPRICE;
            ItemCountTb.Text = ViewProduct. ITEMSTOCK;
            SelectItemStatus.Text = ViewProduct. ITEMSTATUS;
            ItemSellingPriceTb.Text = ViewProduct. ITEMSELLPRICE;
            SelectDiscount.Text = ViewProduct. ITEMDISCOUNT;
            ItemProfitTb.Text = ViewProduct. ITEMPROFIT;
        }
        
         
        private void ItemDesTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //assign data values for database process
            string ToDBItemBcode = BcodeTb.Text.Trim();
            string ToDBItemName = ItemNameTb.Text.Trim();
            string ToDBItemDes = ItemDesTb.Text.Trim();
            string ToDBItemCategory = SelectCategory.Text.Trim();
            string ToDBItemUnitPrice = ItemUnitPriceTb.Text.Trim();
            string ToDBItemCost = ItemCostPriceTb.Text.Trim();
            string ToDBItemCount = ItemCountTb.Text.Trim();
            string ToDBItemstatus = SelectItemStatus.Text.Trim();
            string ToDBItemsellPrice = ItemSellingPriceTb.Text.Trim();
            string ToDBItemDiscount = SelectDiscount.Text.Trim();
            string ToDBItemProfit = ItemProfitTb.Text.Trim();


            if (ToDBItemBcode == "" || ToDBItemName == "" || ToDBItemCategory == "")
            {

                MessageBox.Show("Please Fill required The Details", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                SqlConnection DB_conn = new SqlConnection(ConnectionString);
                DB_conn.Open();
                if (DB_conn.State == System.Data.ConnectionState.Open)
                {
                    // ProductBcode,ProductName,ProductDescription,ProductCategory,ProductUnitPrice,ProductCostPrice,ProductCount,ProductSellPrice,ProductStatus,ProductDiscount,ProductProfit

                    string SqlQuery1 = "UPDATE ProductsDetails SET ProductName = '" + ToDBItemName + "',ProductDescription = '" + ToDBItemDes + "',ProductCategory = '" + ToDBItemCategory + "',ProductUnitPrice = '" + ToDBItemUnitPrice + "',ProductCostPrice = '" + ToDBItemCost + "',ProductCount = '" + ToDBItemCount + "' ,ProductSellPrice = '" +  ToDBItemsellPrice + "',ProductStatus = '" + ToDBItemstatus + "',ProductDiscount = '" + ToDBItemDiscount + "',ProductProfit = '" + ToDBItemProfit + "' WHERE ProductBcode = '" + ToDBItemBcode + "' "; 

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

        private void ItemCountTb_KeyUp(object sender, KeyEventArgs e)
        {
            // calculate cost price
            int x = Convert.ToInt32(ItemCountTb.Text);
            int y = Convert.ToInt32(ItemUnitPriceTb.Text);
            int CostPrice = x * y;
            ItemCostPriceTb.Text = CostPrice.ToString();
        }

        private void ItemUnitPriceTb_KeyUp(object sender, KeyEventArgs e)
        {
            // calculate cost price
            int a = Convert.ToInt32(ItemCountTb.Text);
            int b = Convert.ToInt32(ItemUnitPriceTb.Text);
            int CostPrice = a * b;
            ItemCostPriceTb.Text = CostPrice.ToString();
        }

        private void SelectDiscount_TextChanged(object sender, EventArgs e)
        {   // calculate profit
            int z = Convert.ToInt32(ItemCostPriceTb.Text);
            int c = Convert.ToInt32(ItemSellingPriceTb.Text);
            int profit = z - c;
            int d = Convert.ToInt32(SelectDiscount.Text);
            int dis = c * d / 100;
            int FinalProfit = profit - dis;
            ItemProfitTb.Text = FinalProfit.ToString();
        }

        private void ItemSellingPriceTb_KeyUp(object sender, KeyEventArgs e)
        {
            // calculate profit
            int z = Convert.ToInt32(ItemCostPriceTb.Text);
            int c = Convert.ToInt32(ItemSellingPriceTb.Text);
            int profit = z - c;
            int d = Convert.ToInt32(SelectDiscount.Text);
            int dis = c * d / 100;
            int FinalProfit = profit - dis;
            ItemProfitTb.Text = FinalProfit.ToString();
        }

        private void ItemCostPriceTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ItemCostPriceTb_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (BcodeTb.Text != ViewProduct.ITEMBARCODE || ItemNameTb.Text != ViewProduct.ITEMNAME ||ItemDesTb.Text != ViewProduct.ITEMDESCRIPTION || SelectCategory.Text != ViewProduct.ITEMCATEGORY ||ItemUnitPriceTb.Text != ViewProduct.ITEMUNITPRICE ||ItemCostPriceTb.Text != ViewProduct.ITEMCOSTPRICE ||ItemCountTb.Text != ViewProduct.ITEMSTOCK ||SelectItemStatus.Text != ViewProduct.ITEMSTATUS ||ItemSellingPriceTb.Text != ViewProduct.ITEMSELLPRICE||SelectDiscount.Text != ViewProduct.ITEMDISCOUNT ||ItemProfitTb.Text != ViewProduct.ITEMPROFIT)
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
    }
}

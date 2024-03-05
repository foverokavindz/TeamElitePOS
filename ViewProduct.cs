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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
            HidePanels();
            OpenChildPanel(panelCategoryAll);
            ViewProduts("AllCategory", dataGridViewCategoryALL);
        }
        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;




        private Panel ActivePanel = null;
        private void OpenChildPanel(Panel ChildPanels)
        {

            if (ActivePanel != null)
                ActivePanel.Visible = false;

            ActivePanel = ChildPanels;
           // ChildPanels.TopLevel = false;
            ChildPanels.BorderStyle = BorderStyle.None;
            ChildPanels.Dock = DockStyle.Fill;
            panelProductMain.Controls.Add(ChildPanels);
            panelProductMain.Tag = ChildPanels;
            ChildPanels.BringToFront();
            ChildPanels.Show();

            

        }

        //method for hide all panels when form start
        private void HidePanels()
        {

            panelCategoryAll.Visible = false;
            panelCategoryCables.Visible = false;
            panelCategoryComponent.Visible = false;
            panelCategoryInputDevices.Visible = false;
            panelCategoryMoniters.Visible = false;
            panelCategoryOther.Visible = false;
            panelCategorySound.Visible = false;
            panelCategoryStorages.Visible = false;
            panelCategoryGadgets.Visible = false;


        }

        //method to show sub menu panels previously hidden


        //method for show data from database
        public void ViewProduts(string ProductCategory,DataGridView VisibleDataGrid)
        {
            VisibleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable ItemsDataTable = new DataTable();
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                // check which is the category
                string SqlQuery;
                if (ProductCategory == "AllCategory"){

                    SqlQuery = "SELECT ProductBcode,ProductName,ProductDescription,ProductCategory,ProductUnitPrice,ProductCostPrice,ProductCount,ProductStatus,ProductSellPrice,ProductDiscount,ProductProfit from ProductsDetails ";

                }
                else
                {
                    SqlQuery = "SELECT ProductBcode,ProductName,ProductDescription,ProductCategory,ProductUnitPrice,ProductCostPrice,ProductCount,ProductStatus,ProductSellPrice,ProductDiscount,ProductProfit from ProductsDetails  Where ProductCategory = '" + ProductCategory + "' ";

                }

                SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlQuery, DB_conn);
                DataAdapter.Fill(ItemsDataTable);

                
                //assign sql data to grid columns
                VisibleDataGrid.DataSource = ItemsDataTable;
                VisibleDataGrid.Columns[0].HeaderText = "Barcode";
                VisibleDataGrid.Columns[1].HeaderText = "Name";
                VisibleDataGrid.Columns[2].HeaderText = "Description";
                VisibleDataGrid.Columns[3].HeaderText = "Category";
                VisibleDataGrid.Columns[4].HeaderText = "Unit Price";
                VisibleDataGrid.Columns[5].HeaderText = "Cost Price";
                VisibleDataGrid.Columns[6].HeaderText = "Stock Count";
                VisibleDataGrid.Columns[7].HeaderText = "Status";
                VisibleDataGrid.Columns[8].HeaderText = "Selling Price";
                VisibleDataGrid.Columns[9].HeaderText = "Discount";
                VisibleDataGrid.Columns[10].HeaderText = "Profit";


                DB_conn.Close();

            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }



        private void ViewProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void OpenChildPanel()
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            //Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategorySound);
            
            ViewProduts("Sounds", dataGridViewCategorySound);


        }

        private void buttonAll_Click(object sender, EventArgs e)
        {//Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategoryAll);
            ViewProduts("AllCategory", dataGridViewCategoryALL);
        }

        private void buttonComponents_Click(object sender, EventArgs e)
        {//Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategoryComponent);
            ViewProduts("Components", dataGridViewCategoryComponents);

        }

        private void buttonCables_Click(object sender, EventArgs e)
        {//Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategoryCables);
            ViewProduts("Cables", dataGridViewCategoryCables);


        }

        private void buttonMoniters_Click(object sender, EventArgs e)
        {//Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategoryMoniters);
            ViewProduts("Moniters", dataGridViewCategoryMoniters);



        }
        private void buttonInputDevices_Click(object sender, EventArgs e)
        {//Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategoryInputDevices);
            ViewProduts("Input Devices", dataGridViewCategoryInputDevices);



        }

        private void buttonStorages_Click(object sender, EventArgs e)
        {//Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategoryStorages);
            ViewProduts("Storages", dataGridViewCategoryStorages);


        }

        private void buttonGadgets_Click(object sender, EventArgs e)
        {//Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategoryGadgets);
            ViewProduts("Gadgets", dataGridViewCategoryGadgets);


        }

        private void buttonOther_Click(object sender, EventArgs e)
        {//Child panelShow Method call when every categoty button click
            //get data from DB Method call when every categoty button click
            OpenChildPanel(panelCategoryOther);
            ViewProduts("Other", dataGridViewCategoryOther);


        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (panelCategoryCables.Visible == true)
            {
                ViewProduts("Cables", dataGridViewCategoryCables);

            }
            else if (panelCategoryComponent.Visible == true)
            {
                ViewProduts("Components", dataGridViewCategoryComponents);

            }
            else if (panelCategorySound.Visible == true)
            {
                ViewProduts("Sounds", dataGridViewCategorySound);

            }
            else if (panelCategoryAll.Visible == true)
            {
                ViewProduts("AllCategory", dataGridViewCategoryALL);

            }
            else if (panelCategoryMoniters.Visible == true)
            {
                ViewProduts("Moniters", dataGridViewCategoryMoniters);

            }
            else if (panelCategoryInputDevices.Visible == true)
            {
                ViewProduts("Input Devices", dataGridViewCategoryInputDevices);
            }
            else if (panelCategoryStorages.Visible == true)
            {
                ViewProduts("Storages", dataGridViewCategoryStorages);
            }
            else if (panelCategoryGadgets.Visible == true)
            {
                ViewProduts("Gadgets", dataGridViewCategoryGadgets);
            }
            else if (panelCategoryOther.Visible == true)
            {
                ViewProduts("Other", dataGridViewCategoryOther);
            }
        }


       int RowIndex;

        public static string ITEMBARCODE = "";
        public static string ITEMNAME = "";
        public static string ITEMDESCRIPTION = "";
        public static string ITEMCATEGORY = "";
        public static string ITEMUNITPRICE = "";
        public static string ITEMCOSTPRICE = "";
        public static string ITEMSTOCK = "";
        public static string ITEMSTATUS = "";
        public static string ITEMSELLPRICE = "";
        public static string ITEMDISCOUNT = "";
        public static string ITEMPROFIT = "";



        private void dataGridViewCategoryALL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategoryALL.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ITEMBARCODE == "")
            {
                MessageBox.Show("Please Select A Row", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                UpdateProducts ProductUp= new UpdateProducts();
                ProductUp.Show();

            }
        }

        private void dataGridViewCategorySound_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategorySound.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();
        }

        private void dataGridViewCategoryComponents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategoryComponents.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();
        }

        private void dataGridViewCategoryCables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategoryCables.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();
        }

        private void dataGridViewCategoryMoniters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategoryMoniters.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();
        }

        private void dataGridViewCategoryInputDevices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategoryInputDevices.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();
        }

        private void dataGridViewCategoryStorages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategoryStorages.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();
        }

        private void dataGridViewCategoryGadgets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategoryGadgets.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();
        }

        private void dataGridViewCategoryOther_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

            DataGridViewRow DataRow = dataGridViewCategoryOther.Rows[RowIndex];

            ITEMBARCODE = DataRow.Cells[0].Value.ToString().Trim();
            ITEMNAME = DataRow.Cells[1].Value.ToString().Trim();
            ITEMDESCRIPTION = DataRow.Cells[2].Value.ToString().Trim();
            ITEMCATEGORY = DataRow.Cells[3].Value.ToString().Trim();
            ITEMUNITPRICE = DataRow.Cells[4].Value.ToString().Trim();
            ITEMCOSTPRICE = DataRow.Cells[5].Value.ToString().Trim();
            ITEMSTOCK = DataRow.Cells[6].Value.ToString().Trim();
            ITEMSTATUS = DataRow.Cells[7].Value.ToString().Trim();
            ITEMSELLPRICE = DataRow.Cells[8].Value.ToString().Trim();
            ITEMDISCOUNT = DataRow.Cells[9].Value.ToString().Trim();
            ITEMPROFIT = DataRow.Cells[10].Value.ToString().Trim();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnUpdateUserDataNew_Click(object sender, EventArgs e)
        {
            if (ITEMBARCODE == "")
            {
                MessageBox.Show("Please Select A Row", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                UpdateProducts ProductUp = new UpdateProducts();
                ProductUp.Show();

            }
        }

        private void BtnRefreshNew_Click(object sender, EventArgs e)
        {

            if (panelCategoryCables.Visible == true)
            {
                ViewProduts("Cables", dataGridViewCategoryCables);

            }
            else if (panelCategoryComponent.Visible == true)
            {
                ViewProduts("Components", dataGridViewCategoryComponents);

            }
            else if (panelCategorySound.Visible == true)
            {
                ViewProduts("Sounds", dataGridViewCategorySound);

            }
            else if (panelCategoryAll.Visible == true)
            {
                ViewProduts("AllCategory", dataGridViewCategoryALL);

            }
            else if (panelCategoryMoniters.Visible == true)
            {
                ViewProduts("Moniters", dataGridViewCategoryMoniters);

            }
            else if (panelCategoryInputDevices.Visible == true)
            {
                ViewProduts("Input Devices", dataGridViewCategoryInputDevices);
            }
            else if (panelCategoryStorages.Visible == true)
            {
                ViewProduts("Storages", dataGridViewCategoryStorages);
            }
            else if (panelCategoryGadgets.Visible == true)
            {
                ViewProduts("Gadgets", dataGridViewCategoryGadgets);
            }
            else if (panelCategoryOther.Visible == true)
            {
                ViewProduts("Other", dataGridViewCategoryOther);
            }
        }
    }
}

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
    public partial class NewBIllWindow : Form
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
        public NewBIllWindow()
        {
            InitializeComponent();
            this.itemListDtGridViw.EnableHeadersVisualStyles = false;


            UserNameLabel.Text = Dashboard.ShareUserName;
            UserPosition.Text = Dashboard.ShareUserType;

            // for testing
            //UserNameLabel.Text = "Kavinda Madhuranga";
            //UserPosition.Text = "Admin User";

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            DateTimeTb.Text = DateTime.Now.ToString();

            GenerateInvoiceID();
        }

        string ConnectionString = ConfigurationManager.ConnectionStrings["POS_Team_Elite.Properties.Settings.EliteDBConnectionString"].ConnectionString;

        //public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\teamElite\\POS_Team_Elite\\TeamELiteDB.mdf;Integrated Security=True";
        //private void customizeDataGridView(DataGridView dataGridView)
        //{
        //    dataGridView.
        //}
        //method to get customer data to textboxes
        private void ShowCusDetails()
        {
            string CusNic = NICtb.Text;

            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand Command = new SqlCommand("SELECT CustomerName,CustomerAddress from SystemCustomers Where CustomerNIC = '" + CusNic + "'", DB_conn);
                SqlDataReader row = Command.ExecuteReader();
                while (row.Read())
                {

                    NameFromDb.Text = row.GetValue(0).ToString().Trim();
                    AddressFromDb.Text = row.GetValue(1).ToString().Trim();
                    
                }
                row.Close();
                DB_conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }

        public void GenerateInvoiceID() {// generate max invoice number acording to database  invoice number count
            DataTable MAXInvoiceTable = new DataTable();
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                string sqlquery = ("SELECT MAX (InvoiceID) as InvoiceID from Invoice");
                SqlDataAdapter InvoiceAdapter = new SqlDataAdapter(sqlquery,DB_conn);
                InvoiceAdapter.Fill(MAXInvoiceTable);

                DataRow GetMax = MAXInvoiceTable.Rows[0];
                string MAXInvoice = GetMax["InvoiceID"].ToString();
                if (MAXInvoice == "")
                {
                    InvoiceIDTb.Text = "1";
                }
                else
                {
                    int InvoiceNo = Convert.ToInt32(MAXInvoice) + 2;
                    InvoiceIDTb.Text = InvoiceNo.ToString().Trim();
                }

                
                DB_conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error");
            }
        }

        //method to get relevent data of inputed Barcode Or ItemName
        private void SearchItemFromDb()
        {
            string BcodeTb = GetBcodeTb.Text.Trim();
            string ItemTb = ItemNameTb.Text.Trim();

            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();

            if (GetBcodeTb.Text != "" && ItemNameTb.Text != "")

            {
                MessageBox.Show("Please Clear Barcode or Item Name Box to find item details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (GetBcodeTb.Text != "")
            { // search from bcode

                if (DB_conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand Command = new SqlCommand("SELECT ProductName,ProductUnitPrice,ProductDiscount from ProductsDetails Where ProductBcode = '" + GetBcodeTb.Text + "'", DB_conn);
                    SqlDataReader row = Command.ExecuteReader();

                    while (row.Read())
                    {
                        ItemNameTb.Text = row.GetValue(0).ToString().Trim(); ;
                        PriceTb.Text = row.GetValue(1).ToString().Trim();
                        DiscountTB.Text = row.GetValue(2).ToString().Trim();
                    }

                    DB_conn.Close();

                    row.Close();

                }
                else
                {
                    MessageBox.Show("Connection Error");
                }

            }
            else if (ItemNameTb.Text != "")
            { // search From Name

                if (DB_conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand Command = new SqlCommand("SELECT ProductBcode,ProductUnitPrice,ProductDiscount from ProductsDetails Where ProductName = '" + ItemTb + "'", DB_conn);
                    SqlDataReader row = Command.ExecuteReader();

                    while (row.Read())
                    {
                        GetBcodeTb.Text = row.GetValue(0).ToString().Trim();
                        PriceTb.Text = row.GetValue(1).ToString().Trim();
                        DiscountTB.Text = row.GetValue(2).ToString().Trim();
                    }

                    DB_conn.Close();
                    row.Close();

                }
                else

                {
                    MessageBox.Show("Connection Error");
                }

            }
        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void NewBIllWindow_Load(object sender, EventArgs e)
        {



            string SelectedImageLabel = LoginWindow.UserProfilePIcNUmber.Trim();
            ToPaymentUserID = LoginWindow.USerID.Trim();

            // for testing above
            //string SelectedImageLabel = "Img2";
            //ToPaymentUserID = "1";



            if (SelectedImageLabel == "Img1")// select correct picturebox
            {
                ShowPicture(Pic1);
            }
            else if (SelectedImageLabel == "Img2")
            {
                ShowPicture(Pic2);
            }
            else if (SelectedImageLabel == "Img3")
            {
                ShowPicture(Pic3);
            }
            else if (SelectedImageLabel == "Img4")
            {
                ShowPicture(Pic4);
            }
            else if (SelectedImageLabel == "Img5")
            {
                ShowPicture(Pic5);
            }
            else if (SelectedImageLabel == "")
            {
                ShowPicture(Pic1);
            }


            BtnRemoveDataGridViewRow.BorderRadius = 20;
            guna2Button1.BorderRadius = 20;
            btnCashPayNew.BorderRadius = 20;
            guna2Button3.BorderRadius = 20;
            guna2Button4.BorderRadius = 20;
            guna2Button5.BorderRadius = 20;
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            ShowCusDetails();
        }

        private void NICtb_KeyUp(object sender, KeyEventArgs e)
        {
            ShowCusDetails();
        }

        private void ItemSearchButton_Click(object sender, EventArgs e)
        {
            SearchItemFromDb();
        }

        private void GetBcodeTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (ItemNameTb.Text == "")
            {
                SearchItemFromDb();
            }
            
        }
        private void ItemNameTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (GetBcodeTb.Text == "")
            {
                SearchItemFromDb();
            }
            
        }

        private void ItemNameTb_TextChanged(object sender, EventArgs e)
        {

        }


        //method to calculate sum of datagridview

        public void CalculateSumDataGridView() {

            // calculate total Prices

            SubTotTb.Text = "0";
            DisTb.Text = "0";
            FinalTotTb.Text = "0";

            int TotSpend = 0;
            int TotAmount = 0;

            for (int i = 0; i < itemListDtGridViw.Rows.Count; i++)
            {

                TotSpend += Convert.ToInt32(itemListDtGridViw.Rows[i].Cells[6].Value.ToString());// for get total
                TotAmount += Convert.ToInt32(itemListDtGridViw.Rows[i].Cells[4].Value.ToString());// for sum of discounts

                int TextBoxTotal = Convert.ToInt32(FinalTotTb.Text);
                int TextBoxCost = Convert.ToInt32(SubTotTb.Text);
                int TextBoxDiscount = Convert.ToInt32(DisTb.Text);

                int FinalTotal = TextBoxTotal + TotSpend;
                int FinalCost = TextBoxCost + TotAmount;
                int totalDiscount = FinalCost - FinalTotal;

                FinalTotTb.Text = FinalTotal.ToString();
                SubTotTb.Text = FinalCost.ToString();
                DisTb.Text = totalDiscount.ToString();


                TextBoxCost = 0;
                TotAmount = 0;
                TotSpend = 0;
                FinalTotal = 0;
                TextBoxTotal = 0;
                FinalCost = 0;
                totalDiscount = 0;

            }

        }
        private void buttonAddToDataGridView_Click(object sender, EventArgs e)
        {
            if (buttonAddToDataGridView.Text == "Update")//if there is update button text will chnage
            {
                if (ItemQtyTB.Text == "") {

                    ItemQtyTB.Text = "1";

                }

                //then assign updated textbox values to datagrid view cells again

                DataGridViewRow DataRow = itemListDtGridViw.Rows[RowIndex];//row which belongs to row index no
                DataRow.Cells[0].Value = GetBcodeTb.Text.ToString();
                DataRow.Cells[1].Value = ItemNameTb.Text.ToString();
                DataRow.Cells[2].Value = PriceTb.Text.ToString();
                DataRow.Cells[3].Value = ItemQtyTB.Text.ToString();

                int Updateprice = Convert.ToInt32(PriceTb.Text);
                int UpdateQty = Convert.ToInt32(ItemQtyTB.Text);
                int UpdateMultipliedAmount = Updateprice * UpdateQty;

                DataRow.Cells[4].Value = UpdateMultipliedAmount.ToString();

                int UpdateDiscount = Convert.ToInt32(DiscountTB.Text);
                int UpdateMultipliedDiscount = UpdateMultipliedAmount * UpdateDiscount / 100;
                int UpdateMultipliedSpend = UpdateMultipliedAmount - UpdateMultipliedDiscount;

                DataRow.Cells[5].Value = UpdateDiscount.ToString();
                DataRow.Cells[6].Value = UpdateMultipliedSpend.ToString();

                buttonAddToDataGridView.Text = "Add";

                CalculateSumDataGridView();
            }
            else if (buttonAddToDataGridView.Text == "Add") //if there is add button text will chnage
            {
                if (ItemQtyTB.Text == "")
                {

                    ItemQtyTB.Text = "1";

                }

                int NumberOfRow = Convert.ToInt32(itemListDtGridViw.Rows.Count);

                int row = 0;

                itemListDtGridViw.Rows.Add();
                row = itemListDtGridViw.Rows.Count - 1;
                itemListDtGridViw["ItemBcode", row].Value = GetBcodeTb.Text.ToString();
                itemListDtGridViw["ItemName", row].Value = ItemNameTb.Text.ToString();
                itemListDtGridViw["ItemPrice", row].Value = PriceTb.Text.ToString();
                itemListDtGridViw["ItemQty", row].Value = ItemQtyTB.Text.ToString();

                int price = Convert.ToInt32(PriceTb.Text);
                int qty = Convert.ToInt32(ItemQtyTB.Text);
                int MultipliedAmount = price * qty;

                itemListDtGridViw["ItemAmount", row].Value = MultipliedAmount.ToString();

                int Discount = Convert.ToInt32(DiscountTB.Text);
                int MultipliedDiscount = MultipliedAmount * Discount / 100;
                int MultipliedSpend = MultipliedAmount - MultipliedDiscount;

                itemListDtGridViw["ItemDiscount", row].Value = Discount.ToString();
                itemListDtGridViw["ItemSpend", row].Value = MultipliedSpend.ToString();

                CalculateSumDataGridView();

                }         


            GetBcodeTb.Text = "";
            ItemNameTb.Text = "";
            PriceTb.Text = "";
            DiscountTB.Text = "";
            ItemQtyTB.Text = "";
            

        }

        int RowIndex;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;//get row number

            //then assign row cell content to text boxes
            DataGridViewRow DataRow = itemListDtGridViw.Rows[RowIndex];//row which belongs to row index no
            GetBcodeTb.Text = DataRow.Cells[0].Value.ToString();
            ItemNameTb.Text = DataRow.Cells[1].Value.ToString();
            PriceTb.Text = DataRow.Cells[2].Value.ToString();
            ItemQtyTB.Text = DataRow.Cells[3].Value.ToString();
            DiscountTB.Text = DataRow.Cells[5].Value.ToString();

            buttonAddToDataGridView.Text = "Update";
            guna2Button3.Text = "Update";


        }


        
        private void button4_Click(object sender, EventArgs e)
        {
            
            //conformation msg box

            DialogResult clearInputFields = MessageBox.Show("Do you want to clear all fields", "Conform", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (clearInputFields == DialogResult.Yes)
            {  

                itemListDtGridViw.Rows.Remove(itemListDtGridViw.Rows[RowIndex]);// delete selected row reference from RowIndex
                CalculateSumDataGridView();// Sum of datagrid view method

                if (itemListDtGridViw.Rows.Count == 0) {

                    //is there not any row there will be error so i change button text to add and clear textfields
                    // remove button eka click krma update ektath ekka load wenne ee welawe anthima row eka remove kaloth update funtion eka wda na eka nisa inputfields reset krnawa

                    buttonAddToDataGridView.Text = "Add";
                    GetBcodeTb.Text = "";
                    ItemNameTb.Text = "";
                    PriceTb.Text = "";
                    DiscountTB.Text = "";
                    ItemQtyTB.Text = "";
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //clear textboxes
            GetBcodeTb.Text = "";
            ItemNameTb.Text = "";
            PriceTb.Text = "";
            DiscountTB.Text = "";
            ItemQtyTB.Text = "";
        }


        
        public static string ToPaymentInvoiceID = "";
        public static string ToPaymentNIC = "";
        public static string ToPaymentTotalDue = "";
        public static string ToPaymentDiscount = "";
        public static string ToPaymentDateTime = "";
        public static string ToPaymentUserID = "";


        private void button2_Click(object sender, EventArgs e)
        {
            ToPaymentTotalDue = FinalTotTb.Text;
            ToPaymentInvoiceID = InvoiceIDTb.Text;
            ToPaymentNIC = NICtb.Text;
            ToPaymentDiscount = DisTb.Text;
            ToPaymentDateTime = DateTimeTb.Text;

            //open paymen twindows to pay
            PaymentCash payment = new PaymentCash();
            payment.Show();

            // save data to database

            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                
                // assign datagrid view data to strings
                for (int i = 0; i < itemListDtGridViw.Rows.Count; i++)
                {
                    string GridBarcode = itemListDtGridViw.Rows[i].Cells[0].Value.ToString().Trim();
                    //string GridItemName = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string GridItemPrice = itemListDtGridViw.Rows[i].Cells[2].Value.ToString().Trim();
                    string GridItemQty = itemListDtGridViw.Rows[i].Cells[3].Value.ToString().Trim();
                    //string GridItemAmount = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string GridDiscount = itemListDtGridViw.Rows[i].Cells[5].Value.ToString().Trim();
                    string GridItemSpend = itemListDtGridViw.Rows[i].Cells[6].Value.ToString().Trim();

                    //save data in invoice product table
                    string ItemInvoiceSqlQuery = "INSERT INTO InvoiceProduct (InvoiceID,ProductBcode,Qty,UnitPrice,ItemDiscount,TotalPrice) VALUES('" + InvoiceIDTb.Text.Trim() + "','" + GridBarcode + "','" + GridItemQty + "','" + GridItemPrice + "','" + GridDiscount + "','" + GridItemSpend + "')";

                    SqlCommand ItemInvoiceCmd = new SqlCommand(ItemInvoiceSqlQuery, DB_conn);
                    ItemInvoiceCmd.ExecuteNonQuery();

                    


                }
                MessageBox.Show(" Data inserted successfully InvoiceProduct");
                DB_conn.Close();

            }
            else
            {
                MessageBox.Show("Connection Error");
            }

            ManageStock();

        }

        public void ManageStock() //  funtion for manage stock when brought items
        {
            //open connection
            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {
                //loop to read whole datagridview
                for (int i = 0; i < itemListDtGridViw.Rows.Count; i++)
                {
                    string Bcode = itemListDtGridViw.Rows[i].Cells[0].Value.ToString();// get barcode in rows

                    //get stock count acording to Barcode
                    SqlCommand Command = new SqlCommand("SELECT ProductCount from ProductsDetails where ProductBcode = '" + Bcode + "' ", DB_conn);
                    SqlDataReader row = Command.ExecuteReader();


                    // assign product count
                    row.Read();
                    string ProductCount = row.GetValue(0).ToString().Trim();  
                    int intProCount = Convert.ToInt32(ProductCount);//convert to int

                    string GetCount = itemListDtGridViw.Rows[i].Cells[3].Value.ToString();// get quentity
                    int intGetCount = Convert.ToInt32(GetCount);//convert to int
                    row.Close();
                    int newCount = intProCount - intGetCount;
                    string stringProCount = newCount.ToString();// new product count calculate

                    //update product count
                    string SqlQuery1 = "UPDATE ProductsDetails SET ProductCount = '" + stringProCount + "'  WHERE ProductBcode = '" + Bcode + "' ";
                    SqlCommand CmdForDb = new SqlCommand(SqlQuery1, DB_conn);
                    CmdForDb.ExecuteNonQuery();
                }

                DB_conn.Close();
                MessageBox.Show("Stock was Updated");
            }
            else
            {
                MessageBox.Show("Connection Error");
            }


        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void profilePic_Click(object sender, EventArgs e)
        {
            
            
        }

        public void ShowPicture(PictureBox PicNo)//funtion to show picture rellevent to user
        {
            PicNo.Visible = true;
            //PicNo.Location = new Point(83, 39);           

            PicNo.Location = new Point(28 + panel1.AutoScrollPosition.X, 27 + panel1.AutoScrollPosition.Y);//picture show on panel1
            PicNo.SizeMode = PictureBoxSizeMode.Zoom;
            PicNo.Size = new Size(111, 101);

            PicNo.BringToFront();// show on top

            



        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult LogOut = MessageBox.Show("Do you want to change user? ", "Conform", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (LogOut == DialogResult.Yes)
            {
                LoginWindow logNew = new LoginWindow();
                logNew.Show();
                this.Close();
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveDataGridViewRow_Click(object sender, EventArgs e)
        {
            //conformation msg box

            DialogResult clearInputFields = MessageBox.Show("Do you want to clear all fields", "Conform", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (clearInputFields == DialogResult.Yes)
            {

                itemListDtGridViw.Rows.Remove(itemListDtGridViw.Rows[RowIndex]);// delete selected row reference from RowIndex
                CalculateSumDataGridView();// Sum of datagrid view method

                if (itemListDtGridViw.Rows.Count == 0)
                {

                    //is there not any row there will be error so i change button text to add and clear textfields
                    // remove button eka click krma update ektath ekka load wenne ee welawe anthima row eka remove kaloth update funtion eka wda na eka nisa inputfields reset krnawa

                    buttonAddToDataGridView.Text = "Add";
                    GetBcodeTb.Text = "";
                    ItemNameTb.Text = "";
                    PriceTb.Text = "";
                    DiscountTB.Text = "";
                    ItemQtyTB.Text = "";
                }
            }
        }

        private void btnCashPayNew_Click(object sender, EventArgs e)
        {
            ToPaymentTotalDue = FinalTotTb.Text;
            ToPaymentInvoiceID = InvoiceIDTb.Text;
            ToPaymentNIC = NICtb.Text;
            ToPaymentDiscount = DisTb.Text;
            ToPaymentDateTime = DateTimeTb.Text;

            //open paymen twindows to pay
            PaymentCash payment = new PaymentCash();
            payment.Show();

            // save data to database

            SqlConnection DB_conn = new SqlConnection(ConnectionString);
            DB_conn.Open();
            if (DB_conn.State == System.Data.ConnectionState.Open)
            {

                // assign datagrid view data to strings
                for (int i = 0; i < itemListDtGridViw.Rows.Count; i++)
                {
                    string GridBarcode = itemListDtGridViw.Rows[i].Cells[0].Value.ToString().Trim();
                    //string GridItemName = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string GridItemPrice = itemListDtGridViw.Rows[i].Cells[2].Value.ToString().Trim();
                    string GridItemQty = itemListDtGridViw.Rows[i].Cells[3].Value.ToString().Trim();
                    //string GridItemAmount = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string GridDiscount = itemListDtGridViw.Rows[i].Cells[5].Value.ToString().Trim();
                    string GridItemSpend = itemListDtGridViw.Rows[i].Cells[6].Value.ToString().Trim();

                    //save data in invoice product table
                    string ItemInvoiceSqlQuery = "INSERT INTO InvoiceProduct (InvoiceID,ProductBcode,Qty,UnitPrice,ItemDiscount,TotalPrice) VALUES('" + InvoiceIDTb.Text.Trim() + "','" + GridBarcode + "','" + GridItemQty + "','" + GridItemPrice + "','" + GridDiscount + "','" + GridItemSpend + "')";

                    SqlCommand ItemInvoiceCmd = new SqlCommand(ItemInvoiceSqlQuery, DB_conn);
                    ItemInvoiceCmd.ExecuteNonQuery();




                }
                MessageBox.Show(" Data inserted successfully to InvoiceProduct");
                DB_conn.Close();

            }
            else
            {
                MessageBox.Show("Connection Error");
            }

            ManageStock();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult LogOut = MessageBox.Show("Do you want to change user? ", "Conform", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (LogOut == DialogResult.Yes)
            {
                LoginWindow logNew = new LoginWindow();
                logNew.Show();
                this.Close();

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button3.Text == "Update")//if there is update button text will chnage
            {
                if (ItemQtyTB.Text == "")
                {

                    ItemQtyTB.Text = "1";

                }

                //then assign updated textbox values to datagrid view cells again

                DataGridViewRow DataRow = itemListDtGridViw.Rows[RowIndex];//row which belongs to row index no
                DataRow.Cells[0].Value = GetBcodeTb.Text.ToString();
                DataRow.Cells[1].Value = ItemNameTb.Text.ToString();
                DataRow.Cells[2].Value = PriceTb.Text.ToString();
                DataRow.Cells[3].Value = ItemQtyTB.Text.ToString();

                int Updateprice = Convert.ToInt32(PriceTb.Text);
                int UpdateQty = Convert.ToInt32(ItemQtyTB.Text);
                int UpdateMultipliedAmount = Updateprice * UpdateQty;

                DataRow.Cells[4].Value = UpdateMultipliedAmount.ToString();

                int UpdateDiscount = Convert.ToInt32(DiscountTB.Text);
                int UpdateMultipliedDiscount = UpdateMultipliedAmount * UpdateDiscount / 100;
                int UpdateMultipliedSpend = UpdateMultipliedAmount - UpdateMultipliedDiscount;

                DataRow.Cells[5].Value = UpdateDiscount.ToString();
                DataRow.Cells[6].Value = UpdateMultipliedSpend.ToString();

                guna2Button3.Text = "Add";

                CalculateSumDataGridView();
            }
            else if (guna2Button3.Text == "Add") //if there is add button text will chnage
            {
                if (ItemQtyTB.Text == "")
                {

                    ItemQtyTB.Text = "1";

                }

                int NumberOfRow = Convert.ToInt32(itemListDtGridViw.Rows.Count);

                int row = 0;

                itemListDtGridViw.Rows.Add();
                row = itemListDtGridViw.Rows.Count - 1;
                itemListDtGridViw["ItemBcode", row].Value = GetBcodeTb.Text.ToString();
                itemListDtGridViw["ItemName", row].Value = ItemNameTb.Text.ToString();
                itemListDtGridViw["ItemPrice", row].Value = PriceTb.Text.ToString();
                itemListDtGridViw["ItemQty", row].Value = ItemQtyTB.Text.ToString();

                int price = Convert.ToInt32(PriceTb.Text);
                int qty = Convert.ToInt32(ItemQtyTB.Text);
                int MultipliedAmount = price * qty;

                itemListDtGridViw["ItemAmount", row].Value = MultipliedAmount.ToString();

                int Discount = Convert.ToInt32(DiscountTB.Text);
                int MultipliedDiscount = MultipliedAmount * Discount / 100;
                int MultipliedSpend = MultipliedAmount - MultipliedDiscount;

                itemListDtGridViw["ItemDiscount", row].Value = Discount.ToString();
                itemListDtGridViw["ItemSpend", row].Value = MultipliedSpend.ToString();

                CalculateSumDataGridView();

            }


            GetBcodeTb.Text = "";
            ItemNameTb.Text = "";
            PriceTb.Text = "";
            DiscountTB.Text = "";
            ItemQtyTB.Text = "";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //clear textboxes
            GetBcodeTb.Text = "";
            ItemNameTb.Text = "";
            PriceTb.Text = "";
            DiscountTB.Text = "";
            ItemQtyTB.Text = "";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

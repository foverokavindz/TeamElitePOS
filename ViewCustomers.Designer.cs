
namespace POS_Team_Elite
{
    partial class ViewCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnDeactivateUser = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUpdateUserData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CUSEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CusWhtAppNoTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CusStatus = new System.Windows.Forms.TextBox();
            this.CusDateTime = new System.Windows.Forms.TextBox();
            this.CusPhoneTb = new System.Windows.Forms.TextBox();
            this.CusNameTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CusNIC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.TextBox();
            this.BtnRefreshNew = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdateUserDataNew = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDeactivateCustomerNew = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDeactivateUser
            // 
            this.BtnDeactivateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeactivateUser.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateUser.FlatAppearance.BorderSize = 0;
            this.BtnDeactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeactivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeactivateUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDeactivateUser.Location = new System.Drawing.Point(165, 706);
            this.BtnDeactivateUser.Name = "BtnDeactivateUser";
            this.BtnDeactivateUser.Size = new System.Drawing.Size(137, 47);
            this.BtnDeactivateUser.TabIndex = 15;
            this.BtnDeactivateUser.Text = "Customer Deactivate";
            this.BtnDeactivateUser.UseVisualStyleBackColor = false;
            this.BtnDeactivateUser.Visible = false;
            this.BtnDeactivateUser.Click += new System.EventHandler(this.BtnDeactivateUser_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRefresh.Location = new System.Drawing.Point(658, 21);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(178, 41);
            this.BtnRefresh.TabIndex = 13;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Visible = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Location = new System.Drawing.Point(45, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(983, 581);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnUpdateUserData
            // 
            this.BtnUpdateUserData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateUserData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserData.FlatAppearance.BorderSize = 0;
            this.BtnUpdateUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUserData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUpdateUserData.Location = new System.Drawing.Point(12, 706);
            this.BtnUpdateUserData.Name = "BtnUpdateUserData";
            this.BtnUpdateUserData.Size = new System.Drawing.Size(144, 47);
            this.BtnUpdateUserData.TabIndex = 16;
            this.BtnUpdateUserData.Text = "Update";
            this.BtnUpdateUserData.UseVisualStyleBackColor = false;
            this.BtnUpdateUserData.Visible = false;
            this.BtnUpdateUserData.Click += new System.EventHandler(this.BtnUpdateUserData_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Email";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CUSEmail
            // 
            this.CUSEmail.Location = new System.Drawing.Point(75, 230);
            this.CUSEmail.MaxLength = 200;
            this.CUSEmail.Name = "CUSEmail";
            this.CUSEmail.Size = new System.Drawing.Size(316, 22);
            this.CUSEmail.TabIndex = 46;
            this.CUSEmail.Visible = false;
            this.CUSEmail.TextChanged += new System.EventHandler(this.CusNICTb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Whatsapp No";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CusWhtAppNoTb
            // 
            this.CusWhtAppNoTb.Location = new System.Drawing.Point(237, 185);
            this.CusWhtAppNoTb.MaxLength = 200;
            this.CusWhtAppNoTb.Name = "CusWhtAppNoTb";
            this.CusWhtAppNoTb.Size = new System.Drawing.Size(154, 22);
            this.CusWhtAppNoTb.TabIndex = 44;
            this.CusWhtAppNoTb.Visible = false;
            this.CusWhtAppNoTb.TextChanged += new System.EventHandler(this.CusWhtAppNoTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Status";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Datatime";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Phone Number *";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Name *";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CusStatus
            // 
            this.CusStatus.Location = new System.Drawing.Point(75, 320);
            this.CusStatus.MaxLength = 200;
            this.CusStatus.Multiline = true;
            this.CusStatus.Name = "CusStatus";
            this.CusStatus.Size = new System.Drawing.Size(320, 25);
            this.CusStatus.TabIndex = 36;
            this.CusStatus.Visible = false;
            this.CusStatus.TextChanged += new System.EventHandler(this.CusAddressTb_TextChanged);
            // 
            // CusDateTime
            // 
            this.CusDateTime.Location = new System.Drawing.Point(75, 275);
            this.CusDateTime.MaxLength = 200;
            this.CusDateTime.Name = "CusDateTime";
            this.CusDateTime.Size = new System.Drawing.Size(316, 22);
            this.CusDateTime.TabIndex = 37;
            this.CusDateTime.Visible = false;
            this.CusDateTime.TextChanged += new System.EventHandler(this.CusEmailTb_TextChanged);
            // 
            // CusPhoneTb
            // 
            this.CusPhoneTb.Location = new System.Drawing.Point(75, 185);
            this.CusPhoneTb.MaxLength = 200;
            this.CusPhoneTb.Name = "CusPhoneTb";
            this.CusPhoneTb.Size = new System.Drawing.Size(145, 22);
            this.CusPhoneTb.TabIndex = 38;
            this.CusPhoneTb.Visible = false;
            this.CusPhoneTb.TextChanged += new System.EventHandler(this.CusPhoneTb_TextChanged);
            // 
            // CusNameTb
            // 
            this.CusNameTb.Location = new System.Drawing.Point(75, 140);
            this.CusNameTb.MaxLength = 200;
            this.CusNameTb.Name = "CusNameTb";
            this.CusNameTb.Size = new System.Drawing.Size(316, 22);
            this.CusNameTb.TabIndex = 39;
            this.CusNameTb.Visible = false;
            this.CusNameTb.TextChanged += new System.EventHandler(this.CusNameTb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "NIC";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CusNIC
            // 
            this.CusNIC.Location = new System.Drawing.Point(68, 91);
            this.CusNIC.MaxLength = 200;
            this.CusNIC.Name = "CusNIC";
            this.CusNIC.Size = new System.Drawing.Size(316, 22);
            this.CusNIC.TabIndex = 48;
            this.CusNIC.Visible = false;
            this.CusNIC.TextChanged += new System.EventHandler(this.CusNIC_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 51;
            this.label9.Text = "Address";
            this.label9.Visible = false;
            // 
            // CusAddress
            // 
            this.CusAddress.Location = new System.Drawing.Point(75, 368);
            this.CusAddress.MaxLength = 200;
            this.CusAddress.Multiline = true;
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(320, 25);
            this.CusAddress.TabIndex = 50;
            this.CusAddress.Visible = false;
            // 
            // BtnRefreshNew
            // 
            this.BtnRefreshNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefreshNew.Animated = true;
            this.BtnRefreshNew.AutoRoundedCorners = true;
            this.BtnRefreshNew.BorderColor = System.Drawing.Color.MediumPurple;
            this.BtnRefreshNew.BorderRadius = 25;
            this.BtnRefreshNew.BorderThickness = 2;
            this.BtnRefreshNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefreshNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefreshNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRefreshNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRefreshNew.FillColor = System.Drawing.Color.MediumPurple;
            this.BtnRefreshNew.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.BtnRefreshNew.ForeColor = System.Drawing.Color.White;
            this.BtnRefreshNew.HoverState.BorderColor = System.Drawing.Color.MediumPurple;
            this.BtnRefreshNew.HoverState.CustomBorderColor = System.Drawing.Color.MediumPurple;
            this.BtnRefreshNew.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnRefreshNew.HoverState.ForeColor = System.Drawing.Color.MediumPurple;
            this.BtnRefreshNew.Location = new System.Drawing.Point(872, 12);
            this.BtnRefreshNew.Name = "BtnRefreshNew";
            this.BtnRefreshNew.Size = new System.Drawing.Size(156, 53);
            this.BtnRefreshNew.TabIndex = 52;
            this.BtnRefreshNew.Text = "Refresh";
            this.BtnRefreshNew.Click += new System.EventHandler(this.BtnRefreshNew_Click);
            // 
            // BtnUpdateUserDataNew
            // 
            this.BtnUpdateUserDataNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateUserDataNew.Animated = true;
            this.BtnUpdateUserDataNew.AutoRoundedCorners = true;
            this.BtnUpdateUserDataNew.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDataNew.BorderRadius = 25;
            this.BtnUpdateUserDataNew.BorderThickness = 2;
            this.BtnUpdateUserDataNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateUserDataNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateUserDataNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateUserDataNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdateUserDataNew.FillColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDataNew.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.BtnUpdateUserDataNew.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateUserDataNew.HoverState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDataNew.HoverState.CustomBorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDataNew.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnUpdateUserDataNew.HoverState.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDataNew.Location = new System.Drawing.Point(798, 700);
            this.BtnUpdateUserDataNew.Name = "BtnUpdateUserDataNew";
            this.BtnUpdateUserDataNew.Size = new System.Drawing.Size(230, 53);
            this.BtnUpdateUserDataNew.TabIndex = 53;
            this.BtnUpdateUserDataNew.Text = "Update";
            this.BtnUpdateUserDataNew.Click += new System.EventHandler(this.BtnUpdateUserDataNew_Click);
            // 
            // BtnDeactivateCustomerNew
            // 
            this.BtnDeactivateCustomerNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeactivateCustomerNew.Animated = true;
            this.BtnDeactivateCustomerNew.AutoRoundedCorners = true;
            this.BtnDeactivateCustomerNew.BorderColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateCustomerNew.BorderRadius = 25;
            this.BtnDeactivateCustomerNew.BorderThickness = 2;
            this.BtnDeactivateCustomerNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeactivateCustomerNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeactivateCustomerNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeactivateCustomerNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeactivateCustomerNew.FillColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateCustomerNew.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDeactivateCustomerNew.ForeColor = System.Drawing.Color.White;
            this.BtnDeactivateCustomerNew.HoverState.BorderColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateCustomerNew.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateCustomerNew.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnDeactivateCustomerNew.HoverState.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateCustomerNew.Location = new System.Drawing.Point(480, 700);
            this.BtnDeactivateCustomerNew.Name = "BtnDeactivateCustomerNew";
            this.BtnDeactivateCustomerNew.Size = new System.Drawing.Size(301, 53);
            this.BtnDeactivateCustomerNew.TabIndex = 54;
            this.BtnDeactivateCustomerNew.Text = "Customer Deactivate";
            this.BtnDeactivateCustomerNew.Click += new System.EventHandler(this.BtnDeactivateUserNew_Click);
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 775);
            this.Controls.Add(this.BtnDeactivateCustomerNew);
            this.Controls.Add(this.BtnUpdateUserDataNew);
            this.Controls.Add(this.BtnRefreshNew);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CusAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CusNIC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CUSEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CusWhtAppNoTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CusStatus);
            this.Controls.Add(this.CusDateTime);
            this.Controls.Add(this.CusPhoneTb);
            this.Controls.Add(this.CusNameTb);
            this.Controls.Add(this.BtnUpdateUserData);
            this.Controls.Add(this.BtnDeactivateUser);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCustomers";
            this.Text = "ViewCustomers";
            this.Load += new System.EventHandler(this.ViewCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDeactivateUser;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUpdateUserData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CUSEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CusWhtAppNoTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CusStatus;
        private System.Windows.Forms.TextBox CusDateTime;
        private System.Windows.Forms.TextBox CusPhoneTb;
        private System.Windows.Forms.TextBox CusNameTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CusNIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CusAddress;
        private Guna.UI2.WinForms.Guna2Button BtnRefreshNew;
        private Guna.UI2.WinForms.Guna2Button BtnUpdateUserDataNew;
        private Guna.UI2.WinForms.Guna2Button BtnDeactivateCustomerNew;
    }
}
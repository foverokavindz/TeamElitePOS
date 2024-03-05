
namespace POS_Team_Elite
{
    partial class ViewUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnUpdateUserData = new System.Windows.Forms.Button();
            this.BtnDeactivateUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UserIdTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UserStatusTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UserTypeTb = new System.Windows.Forms.TextBox();
            this.BtnUpdateUserDetails = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefreshNew = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDeactivateUserNew = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 587);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "System Users";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(330, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnUpdateUserData
            // 
            this.BtnUpdateUserData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateUserData.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserData.FlatAppearance.BorderSize = 0;
            this.BtnUpdateUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUserData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUpdateUserData.Location = new System.Drawing.Point(165, 681);
            this.BtnUpdateUserData.Name = "BtnUpdateUserData";
            this.BtnUpdateUserData.Size = new System.Drawing.Size(230, 47);
            this.BtnUpdateUserData.TabIndex = 18;
            this.BtnUpdateUserData.Text = "Update";
            this.BtnUpdateUserData.UseVisualStyleBackColor = false;
            this.BtnUpdateUserData.Visible = false;
            this.BtnUpdateUserData.Click += new System.EventHandler(this.BtnUpdateUserData_Click_1);
            // 
            // BtnDeactivateUser
            // 
            this.BtnDeactivateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeactivateUser.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateUser.FlatAppearance.BorderSize = 0;
            this.BtnDeactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeactivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeactivateUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDeactivateUser.Location = new System.Drawing.Point(42, 697);
            this.BtnDeactivateUser.Name = "BtnDeactivateUser";
            this.BtnDeactivateUser.Size = new System.Drawing.Size(230, 47);
            this.BtnDeactivateUser.TabIndex = 17;
            this.BtnDeactivateUser.Text = "Customer Deactivate";
            this.BtnDeactivateUser.UseVisualStyleBackColor = false;
            this.BtnDeactivateUser.Visible = false;
            this.BtnDeactivateUser.Click += new System.EventHandler(this.BtnDeactivateUser_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address *";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "E-mail *";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phone Number *";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name *";
            this.label1.Visible = false;
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(82, 505);
            this.AddressTb.MaxLength = 100;
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(313, 78);
            this.AddressTb.TabIndex = 26;
            this.AddressTb.Visible = false;
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(82, 454);
            this.EmailTb.MaxLength = 50;
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(316, 22);
            this.EmailTb.TabIndex = 24;
            this.EmailTb.Visible = false;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(253, 409);
            this.PhoneTb.MaxLength = 10;
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(145, 22);
            this.PhoneTb.TabIndex = 22;
            this.PhoneTb.Visible = false;
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(82, 409);
            this.NameTb.MaxLength = 30;
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(165, 22);
            this.NameTb.TabIndex = 20;
            this.NameTb.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "ID";
            this.label7.Visible = false;
            // 
            // UserIdTb
            // 
            this.UserIdTb.Location = new System.Drawing.Point(82, 358);
            this.UserIdTb.MaxLength = 30;
            this.UserIdTb.Name = "UserIdTb";
            this.UserIdTb.Size = new System.Drawing.Size(165, 22);
            this.UserIdTb.TabIndex = 28;
            this.UserIdTb.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "UserStatus";
            this.label8.Visible = false;
            // 
            // UserStatusTb
            // 
            this.UserStatusTb.Location = new System.Drawing.Point(82, 611);
            this.UserStatusTb.MaxLength = 30;
            this.UserStatusTb.Name = "UserStatusTb";
            this.UserStatusTb.Size = new System.Drawing.Size(165, 22);
            this.UserStatusTb.TabIndex = 30;
            this.UserStatusTb.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "UserType";
            this.label9.Visible = false;
            // 
            // UserTypeTb
            // 
            this.UserTypeTb.Location = new System.Drawing.Point(253, 611);
            this.UserTypeTb.MaxLength = 30;
            this.UserTypeTb.Name = "UserTypeTb";
            this.UserTypeTb.Size = new System.Drawing.Size(165, 22);
            this.UserTypeTb.TabIndex = 32;
            this.UserTypeTb.Visible = false;
            this.UserTypeTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BtnUpdateUserDetails
            // 
            this.BtnUpdateUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateUserDetails.Animated = true;
            this.BtnUpdateUserDetails.AutoRoundedCorners = true;
            this.BtnUpdateUserDetails.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDetails.BorderRadius = 25;
            this.BtnUpdateUserDetails.BorderThickness = 2;
            this.BtnUpdateUserDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateUserDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateUserDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateUserDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdateUserDetails.FillColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDetails.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.BtnUpdateUserDetails.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateUserDetails.HoverState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDetails.HoverState.CustomBorderColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDetails.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnUpdateUserDetails.HoverState.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateUserDetails.Location = new System.Drawing.Point(798, 700);
            this.BtnUpdateUserDetails.Name = "BtnUpdateUserDetails";
            this.BtnUpdateUserDetails.Size = new System.Drawing.Size(230, 53);
            this.BtnUpdateUserDetails.TabIndex = 58;
            this.BtnUpdateUserDetails.Text = "Update";
            this.BtnUpdateUserDetails.Click += new System.EventHandler(this.BtnUpdateProductDetails_Click);
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
            this.BtnRefreshNew.TabIndex = 57;
            this.BtnRefreshNew.Text = "Refresh";
            this.BtnRefreshNew.Click += new System.EventHandler(this.BtnRefreshNew_Click);
            // 
            // BtnDeactivateUserNew
            // 
            this.BtnDeactivateUserNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeactivateUserNew.Animated = true;
            this.BtnDeactivateUserNew.AutoRoundedCorners = true;
            this.BtnDeactivateUserNew.BorderColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateUserNew.BorderRadius = 25;
            this.BtnDeactivateUserNew.BorderThickness = 2;
            this.BtnDeactivateUserNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeactivateUserNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeactivateUserNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeactivateUserNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeactivateUserNew.FillColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateUserNew.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDeactivateUserNew.ForeColor = System.Drawing.Color.White;
            this.BtnDeactivateUserNew.HoverState.BorderColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateUserNew.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateUserNew.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnDeactivateUserNew.HoverState.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnDeactivateUserNew.Location = new System.Drawing.Point(491, 700);
            this.BtnDeactivateUserNew.Name = "BtnDeactivateUserNew";
            this.BtnDeactivateUserNew.Size = new System.Drawing.Size(301, 53);
            this.BtnDeactivateUserNew.TabIndex = 59;
            this.BtnDeactivateUserNew.Text = "User Deactivate";
            this.BtnDeactivateUserNew.Click += new System.EventHandler(this.BtnDeactivateUserNew_Click);
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 775);
            this.Controls.Add(this.BtnDeactivateUserNew);
            this.Controls.Add(this.BtnUpdateUserDetails);
            this.Controls.Add(this.BtnRefreshNew);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UserTypeTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UserStatusTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UserIdTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.EmailTb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.BtnUpdateUserData);
            this.Controls.Add(this.BtnDeactivateUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewUsers";
            this.Text = "ViewUsers";
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnUpdateUserData;
        private System.Windows.Forms.Button BtnDeactivateUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserIdTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UserStatusTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UserTypeTb;
        private Guna.UI2.WinForms.Guna2Button BtnUpdateUserDetails;
        private Guna.UI2.WinForms.Guna2Button BtnRefreshNew;
        private Guna.UI2.WinForms.Guna2Button BtnDeactivateUserNew;
    }
}
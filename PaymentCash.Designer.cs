
namespace POS_Team_Elite
{
    partial class PaymentCash
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
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PaymentTotTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentPaidTB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BalanceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscountTb = new System.Windows.Forms.TextBox();
            this.InvoiceIDTb = new System.Windows.Forms.TextBox();
            this.CustomerNICTb = new System.Windows.Forms.TextBox();
            this.DateTimeTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NICget_btn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(86, 202);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 46);
            this.label13.TabIndex = 50;
            this.label13.Text = "Total :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.PaymentTotTB);
            this.panel3.Location = new System.Drawing.Point(238, 181);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel3.Size = new System.Drawing.Size(402, 84);
            this.panel3.TabIndex = 52;
            // 
            // PaymentTotTB
            // 
            this.PaymentTotTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaymentTotTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentTotTB.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTotTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaymentTotTB.Location = new System.Drawing.Point(13, 15);
            this.PaymentTotTB.Margin = new System.Windows.Forms.Padding(0);
            this.PaymentTotTB.MaxLength = 100;
            this.PaymentTotTB.Name = "PaymentTotTB";
            this.PaymentTotTB.ReadOnly = true;
            this.PaymentTotTB.Size = new System.Drawing.Size(376, 56);
            this.PaymentTotTB.TabIndex = 1;
            this.PaymentTotTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(107, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 41);
            this.label2.TabIndex = 53;
            this.label2.Text = "Paid :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentPaidTB
            // 
            this.PaymentPaidTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaymentPaidTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentPaidTB.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentPaidTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaymentPaidTB.Location = new System.Drawing.Point(13, 12);
            this.PaymentPaidTB.Margin = new System.Windows.Forms.Padding(0);
            this.PaymentPaidTB.MaxLength = 100;
            this.PaymentPaidTB.Name = "PaymentPaidTB";
            this.PaymentPaidTB.Size = new System.Drawing.Size(376, 56);
            this.PaymentPaidTB.TabIndex = 2;
            this.PaymentPaidTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PaymentPaidTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaymentPaidTB_KeyUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.PaymentPaidTB);
            this.panel4.Location = new System.Drawing.Point(238, 316);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel4.Size = new System.Drawing.Size(402, 84);
            this.panel4.TabIndex = 54;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.BalanceTB);
            this.panel5.Location = new System.Drawing.Point(238, 456);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel5.Size = new System.Drawing.Size(402, 84);
            this.panel5.TabIndex = 56;
            // 
            // BalanceTB
            // 
            this.BalanceTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BalanceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BalanceTB.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BalanceTB.Location = new System.Drawing.Point(13, 12);
            this.BalanceTB.Margin = new System.Windows.Forms.Padding(0);
            this.BalanceTB.MaxLength = 100;
            this.BalanceTB.Name = "BalanceTB";
            this.BalanceTB.ReadOnly = true;
            this.BalanceTB.Size = new System.Drawing.Size(376, 56);
            this.BalanceTB.TabIndex = 3;
            this.BalanceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(60, 482);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 41);
            this.label3.TabIndex = 55;
            this.label3.Text = "Balance :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(592, 638);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 76);
            this.button3.TabIndex = 48;
            this.button3.Text = "Print Bill";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Firebrick;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(60, 653);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 52);
            this.button7.TabIndex = 49;
            this.button7.Text = "Cancel Payment";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 47);
            this.panel1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(304, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 41);
            this.label4.TabIndex = 58;
            this.label4.Text = "Cash Payment";
            // 
            // DiscountTb
            // 
            this.DiscountTb.Location = new System.Drawing.Point(690, 71);
            this.DiscountTb.Name = "DiscountTb";
            this.DiscountTb.Size = new System.Drawing.Size(100, 22);
            this.DiscountTb.TabIndex = 59;
            this.DiscountTb.Visible = false;
            // 
            // InvoiceIDTb
            // 
            this.InvoiceIDTb.Location = new System.Drawing.Point(584, 71);
            this.InvoiceIDTb.Name = "InvoiceIDTb";
            this.InvoiceIDTb.Size = new System.Drawing.Size(100, 22);
            this.InvoiceIDTb.TabIndex = 60;
            this.InvoiceIDTb.Visible = false;
            // 
            // CustomerNICTb
            // 
            this.CustomerNICTb.Location = new System.Drawing.Point(690, 109);
            this.CustomerNICTb.Name = "CustomerNICTb";
            this.CustomerNICTb.Size = new System.Drawing.Size(100, 22);
            this.CustomerNICTb.TabIndex = 61;
            this.CustomerNICTb.Visible = false;
            // 
            // DateTimeTB
            // 
            this.DateTimeTB.Location = new System.Drawing.Point(690, 149);
            this.DateTimeTB.Name = "DateTimeTB";
            this.DateTimeTB.Size = new System.Drawing.Size(100, 22);
            this.DateTimeTB.TabIndex = 62;
            this.DateTimeTB.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(288, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 48);
            this.label6.TabIndex = 63;
            this.label6.Text = "Cash Payment";
            // 
            // NICget_btn
            // 
            this.NICget_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NICget_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NICget_btn.FlatAppearance.BorderSize = 0;
            this.NICget_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NICget_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NICget_btn.ForeColor = System.Drawing.Color.LightGray;
            this.NICget_btn.Image = global::POS_Team_Elite.Properties.Resources.right_arrow;
            this.NICget_btn.Location = new System.Drawing.Point(648, 316);
            this.NICget_btn.Margin = new System.Windows.Forms.Padding(4);
            this.NICget_btn.Name = "NICget_btn";
            this.NICget_btn.Size = new System.Drawing.Size(90, 84);
            this.NICget_btn.TabIndex = 45;
            this.NICget_btn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseBtn.BackgroundImage = global::POS_Team_Elite.Properties.Resources.close__1_;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(772, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(54, 47);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // PaymentCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 767);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DateTimeTB);
            this.Controls.Add(this.CustomerNICTb);
            this.Controls.Add(this.InvoiceIDTb);
            this.Controls.Add(this.DiscountTb);
            this.Controls.Add(this.NICget_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PaymentCash_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PaymentTotTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaymentPaidTB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button NICget_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox BalanceTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiscountTb;
        private System.Windows.Forms.TextBox InvoiceIDTb;
        private System.Windows.Forms.TextBox CustomerNICTb;
        private System.Windows.Forms.TextBox DateTimeTB;
        private System.Windows.Forms.Label label6;
    }
}
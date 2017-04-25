namespace Shop_Inventory
{
    partial class Buyinvoices
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Buyinvoices";


            this.sal_datetoday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sal_gridview = new System.Windows.Forms.DataGridView();
            this.sal_grid_balance = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sal_ad_invoicenmbr = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sal_ad_done = new System.Windows.Forms.Button();
            this.sal_ad_status = new System.Windows.Forms.ComboBox();
            this.sal_ad_name = new System.Windows.Forms.ComboBox();
            this.sal_ad_detail = new System.Windows.Forms.TextBox();
            this.sal_ad_balance = new System.Windows.Forms.TextBox();
            this.sal_ad_pay = new System.Windows.Forms.TextBox();
            this.sal_ad_total = new System.Windows.Forms.TextBox();
            this.sal_grid_receive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sal_grid_total = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sal_srch_sal_name = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sal_srch_tody = new System.Windows.Forms.Button();
            this.sal_srch_daily = new System.Windows.Forms.Button();
            this.sal_srch_fromdate = new System.Windows.Forms.DateTimePicker();
            this.sal_srch_todate = new System.Windows.Forms.DateTimePicker();
            this.sal_srch_nmbr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sal_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();


            // 
            // sal_datetoday
            // 
            this.sal_datetoday.Location = new System.Drawing.Point(712, 34);
            this.sal_datetoday.Name = "sal_datetoday";
            this.sal_datetoday.Size = new System.Drawing.Size(213, 20);
            this.sal_datetoday.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(79, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "Perchase Details";
            // 
            // sal_gridview
            // 
            this.sal_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sal_gridview.Location = new System.Drawing.Point(17, 166);
            this.sal_gridview.Name = "sal_gridview";
            this.sal_gridview.Size = new System.Drawing.Size(1038, 434);
            this.sal_gridview.TabIndex = 24;
            // 
            // sal_grid_balance
            // 
            this.sal_grid_balance.AutoSize = true;
            this.sal_grid_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_grid_balance.ForeColor = System.Drawing.Color.DarkBlue;
            this.sal_grid_balance.Location = new System.Drawing.Point(729, 615);
            this.sal_grid_balance.Name = "sal_grid_balance";
            this.sal_grid_balance.Size = new System.Drawing.Size(59, 20);
            this.sal_grid_balance.TabIndex = 16;
            this.sal_grid_balance.Text = "00000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(656, 618);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Balance :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sal_ad_invoicenmbr);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.sal_ad_done);
            this.groupBox1.Controls.Add(this.sal_ad_status);
            this.groupBox1.Controls.Add(this.sal_ad_name);
            this.groupBox1.Controls.Add(this.sal_ad_detail);
            this.groupBox1.Controls.Add(this.sal_ad_balance);
            this.groupBox1.Controls.Add(this.sal_ad_pay);
            this.groupBox1.Controls.Add(this.sal_ad_total);
            this.groupBox1.Location = new System.Drawing.Point(17, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Expence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Invoice Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saller Name";
            // 
            // sal_ad_invoicenmbr
            // 
            this.sal_ad_invoicenmbr.Location = new System.Drawing.Point(340, 20);
            this.sal_ad_invoicenmbr.Name = "sal_ad_invoicenmbr";
            this.sal_ad_invoicenmbr.Size = new System.Drawing.Size(67, 20);
            this.sal_ad_invoicenmbr.TabIndex = 3;
            this.sal_ad_invoicenmbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sal_ad_total_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(297, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Invoice #";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Balance :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Invoice #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pay :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total :";
            // 
            // sal_ad_done
            // 
            this.sal_ad_done.Location = new System.Drawing.Point(333, 71);
            this.sal_ad_done.Name = "sal_ad_done";
            this.sal_ad_done.Size = new System.Drawing.Size(75, 23);
            this.sal_ad_done.TabIndex = 7;
            this.sal_ad_done.Text = "Done";
            this.sal_ad_done.UseVisualStyleBackColor = true;
            this.sal_ad_done.Click += new System.EventHandler(this.sal_ad_done_Click);
            // 
            // sal_ad_status
            // 
            this.sal_ad_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Petrol",
            "Entertainment",
            "Home",
            "Load",
            "Cargo",
            "Chay"});
            this.sal_ad_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sal_ad_status.FormattingEnabled = true;
            this.sal_ad_status.Items.AddRange(new object[] {
            "Invoice",
            "Pay"});
            this.sal_ad_status.Location = new System.Drawing.Point(340, 45);
            this.sal_ad_status.Name = "sal_ad_status";
            this.sal_ad_status.Size = new System.Drawing.Size(66, 21);
            this.sal_ad_status.TabIndex = 4;
            this.sal_ad_status.SelectedIndexChanged += new System.EventHandler(this.sal_ad_status_SelectedIndexChanged);
            // 
            // sal_ad_name
            // 
            this.sal_ad_name.AutoCompleteCustomSource.AddRange(new string[] {
            "Petrol",
            "Entertainment",
            "Home",
            "Load",
            "Cargo",
            "Chay"});
            this.sal_ad_name.FormattingEnabled = true;
            this.sal_ad_name.Location = new System.Drawing.Point(96, 19);
            this.sal_ad_name.Name = "sal_ad_name";
            this.sal_ad_name.Size = new System.Drawing.Size(165, 21);
            this.sal_ad_name.TabIndex = 1;
            // 
            // sal_ad_detail
            // 
            this.sal_ad_detail.Location = new System.Drawing.Point(96, 46);
            this.sal_ad_detail.Multiline = true;
            this.sal_ad_detail.Name = "sal_ad_detail";
            this.sal_ad_detail.Size = new System.Drawing.Size(165, 48);
            this.sal_ad_detail.TabIndex = 2;
            // 
            // sal_ad_balance
            // 
            this.sal_ad_balance.Enabled = false;
            this.sal_ad_balance.Location = new System.Drawing.Point(498, 69);
            this.sal_ad_balance.Name = "sal_ad_balance";
            this.sal_ad_balance.Size = new System.Drawing.Size(74, 20);
            this.sal_ad_balance.TabIndex = 1;
            this.sal_ad_balance.Text = "0";
            // 
            // sal_ad_pay
            // 
            this.sal_ad_pay.Location = new System.Drawing.Point(498, 43);
            this.sal_ad_pay.Name = "sal_ad_pay";
            this.sal_ad_pay.Size = new System.Drawing.Size(74, 20);
            this.sal_ad_pay.TabIndex = 6;
            this.sal_ad_pay.TextChanged += new System.EventHandler(this.sal_ad_pay_TextChanged);
            this.sal_ad_pay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sal_ad_total_KeyPress);
            // 
            // sal_ad_total
            // 
            this.sal_ad_total.Location = new System.Drawing.Point(498, 19);
            this.sal_ad_total.Name = "sal_ad_total";
            this.sal_ad_total.Size = new System.Drawing.Size(74, 20);
            this.sal_ad_total.TabIndex = 5;
            this.sal_ad_total.Text = "0";
            this.sal_ad_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sal_ad_total_KeyPress);
            // 
            // sal_grid_receive
            // 
            this.sal_grid_receive.AutoSize = true;
            this.sal_grid_receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_grid_receive.ForeColor = System.Drawing.Color.DarkBlue;
            this.sal_grid_receive.Location = new System.Drawing.Point(453, 615);
            this.sal_grid_receive.Name = "sal_grid_receive";
            this.sal_grid_receive.Size = new System.Drawing.Size(59, 20);
            this.sal_grid_receive.TabIndex = 18;
            this.sal_grid_receive.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Date :";
            // 
            // sal_grid_total
            // 
            this.sal_grid_total.AutoSize = true;
            this.sal_grid_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_grid_total.ForeColor = System.Drawing.Color.DarkBlue;
            this.sal_grid_total.Location = new System.Drawing.Point(175, 615);
            this.sal_grid_total.Name = "sal_grid_total";
            this.sal_grid_total.Size = new System.Drawing.Size(59, 20);
            this.sal_grid_total.TabIndex = 20;
            this.sal_grid_total.Text = "00000";
            this.sal_grid_total.Click += new System.EventHandler(this.sal_grid_total_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(407, 618);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Pay :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(121, 618);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sal_srch_sal_name);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.sal_srch_tody);
            this.groupBox2.Controls.Add(this.sal_srch_daily);
            this.groupBox2.Controls.Add(this.sal_srch_fromdate);
            this.groupBox2.Controls.Add(this.sal_srch_todate);
            this.groupBox2.Controls.Add(this.sal_srch_nmbr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(608, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // sal_srch_sal_name
            // 
            this.sal_srch_sal_name.AutoCompleteCustomSource.AddRange(new string[] {
            "Petrol",
            "Entertainment",
            "Home",
            "Load",
            "Cargo",
            "Chay"});
            this.sal_srch_sal_name.FormattingEnabled = true;
            this.sal_srch_sal_name.Location = new System.Drawing.Point(96, 19);
            this.sal_srch_sal_name.Name = "sal_srch_sal_name";
            this.sal_srch_sal_name.Size = new System.Drawing.Size(279, 21);
            this.sal_srch_sal_name.TabIndex = 2;
            this.sal_srch_sal_name.SelectedIndexChanged += new System.EventHandler(this.sal_srch_name_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(61, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "To";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(61, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Saller Name";
            // 
            // sal_srch_tody
            // 
            this.sal_srch_tody.Location = new System.Drawing.Point(6, 48);
            this.sal_srch_tody.Name = "sal_srch_tody";
            this.sal_srch_tody.Size = new System.Drawing.Size(49, 40);
            this.sal_srch_tody.TabIndex = 11;
            this.sal_srch_tody.Text = "Today";
            this.sal_srch_tody.UseVisualStyleBackColor = true;
            // 
            // sal_srch_daily
            // 
            this.sal_srch_daily.Location = new System.Drawing.Point(283, 49);
            this.sal_srch_daily.Name = "sal_srch_daily";
            this.sal_srch_daily.Size = new System.Drawing.Size(62, 45);
            this.sal_srch_daily.TabIndex = 11;
            this.sal_srch_daily.Text = "Search";
            this.sal_srch_daily.UseVisualStyleBackColor = true;
            this.sal_srch_daily.Click += new System.EventHandler(this.sal_srch_daily_Click);
            // 
            // sal_srch_fromdate
            // 
            this.sal_srch_fromdate.Location = new System.Drawing.Point(97, 46);
            this.sal_srch_fromdate.Name = "sal_srch_fromdate";
            this.sal_srch_fromdate.Size = new System.Drawing.Size(180, 20);
            this.sal_srch_fromdate.TabIndex = 10;
            // 
            // sal_srch_todate
            // 
            this.sal_srch_todate.Location = new System.Drawing.Point(97, 71);
            this.sal_srch_todate.Name = "sal_srch_todate";
            this.sal_srch_todate.Size = new System.Drawing.Size(180, 20);
            this.sal_srch_todate.TabIndex = 10;
            // 
            // sal_srch_nmbr
            // 
            this.sal_srch_nmbr.Location = new System.Drawing.Point(365, 71);
            this.sal_srch_nmbr.Name = "sal_srch_nmbr";
            this.sal_srch_nmbr.Size = new System.Drawing.Size(67, 20);
            this.sal_srch_nmbr.TabIndex = 1;
            this.sal_srch_nmbr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sal_srch_nmbr_KeyDown);
            this.sal_srch_nmbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sal_ad_total_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Invoice #";
            // 
            // Saleinvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 651);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sal_datetoday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sal_gridview);
            this.Controls.Add(this.sal_grid_balance);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sal_grid_receive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sal_grid_total);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "Saleinvoices";
            this.Text = "Saleinvoices";
            ((System.ComponentModel.ISupportInitialize)(this.sal_gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DateTimePicker sal_datetoday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView sal_gridview;
        private System.Windows.Forms.Label sal_grid_balance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sal_ad_invoicenmbr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sal_ad_done;
        private System.Windows.Forms.ComboBox sal_ad_status;
        private System.Windows.Forms.ComboBox sal_ad_name;
        private System.Windows.Forms.TextBox sal_ad_detail;
        private System.Windows.Forms.TextBox sal_ad_balance;
        private System.Windows.Forms.TextBox sal_ad_pay;
        private System.Windows.Forms.TextBox sal_ad_total;
        private System.Windows.Forms.Label sal_grid_receive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sal_grid_total;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox sal_srch_sal_name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sal_srch_tody;
        private System.Windows.Forms.Button sal_srch_daily;
        private System.Windows.Forms.DateTimePicker sal_srch_fromdate;
        private System.Windows.Forms.DateTimePicker sal_srch_todate;
        private System.Windows.Forms.TextBox sal_srch_nmbr;
        private System.Windows.Forms.Label label5;
    }
}
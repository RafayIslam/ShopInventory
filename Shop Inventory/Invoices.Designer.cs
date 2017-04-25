namespace Shop_Inventory
{
    partial class Invoices
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
            this.label2 = new System.Windows.Forms.Label();
            this.invn_srch_daily = new System.Windows.Forms.Button();
            this.invn_srch_todate = new System.Windows.Forms.DateTimePicker();
            this.invn_gridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.invn_ad_cst_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invn_ad_invoicenmbr = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.invn_ad_done = new System.Windows.Forms.Button();
            this.invn_ad_status = new System.Windows.Forms.ComboBox();
            this.inv1_ad_detail = new System.Windows.Forms.TextBox();
            this.invn_ad_balance = new System.Windows.Forms.TextBox();
            this.invn_ad_receive = new System.Windows.Forms.TextBox();
            this.invn_ad_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invn_srch_nmbr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.invn_srch_cst_name = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.invn_srch_fromdate = new System.Windows.Forms.DateTimePicker();
            this.inv_datetoday = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.total_invoice = new System.Windows.Forms.Label();
            this.recive_invo = new System.Windows.Forms.Label();
            this.invn_balance = new System.Windows.Forms.Label();
            this.invn_srch_tody = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invn_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(74, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Invoice Details";
            // 
            // invn_srch_daily
            // 
            this.invn_srch_daily.Location = new System.Drawing.Point(283, 49);
            this.invn_srch_daily.Name = "invn_srch_daily";
            this.invn_srch_daily.Size = new System.Drawing.Size(62, 45);
            this.invn_srch_daily.TabIndex = 11;
            this.invn_srch_daily.Text = "Search";
            this.invn_srch_daily.UseVisualStyleBackColor = true;
            this.invn_srch_daily.Click += new System.EventHandler(this.invn_srch_daily_Click);
            // 
            // invn_srch_todate
            // 
            this.invn_srch_todate.Location = new System.Drawing.Point(97, 71);
            this.invn_srch_todate.Name = "invn_srch_todate";
            this.invn_srch_todate.Size = new System.Drawing.Size(180, 20);
            this.invn_srch_todate.TabIndex = 10;
            // 
            // invn_gridview
            // 
            this.invn_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invn_gridview.Location = new System.Drawing.Point(12, 160);
            this.invn_gridview.Name = "invn_gridview";
            this.invn_gridview.Size = new System.Drawing.Size(1035, 434);
            this.invn_gridview.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invn_ad_cst_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.invn_ad_invoicenmbr);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.invn_ad_done);
            this.groupBox1.Controls.Add(this.invn_ad_status);
            this.groupBox1.Controls.Add(this.inv1_ad_detail);
            this.groupBox1.Controls.Add(this.invn_ad_balance);
            this.groupBox1.Controls.Add(this.invn_ad_receive);
            this.groupBox1.Controls.Add(this.invn_ad_total);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Expence";
            // 
            // invn_ad_cst_name
            // 
            this.invn_ad_cst_name.AutoCompleteCustomSource.AddRange(new string[] {
            "Petrol",
            "Entertainment",
            "Home",
            "Load",
            "Cargo",
            "Chay"});
            this.invn_ad_cst_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invn_ad_cst_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.invn_ad_cst_name.FormattingEnabled = true;
            this.invn_ad_cst_name.Location = new System.Drawing.Point(96, 19);
            this.invn_ad_cst_name.Name = "invn_ad_cst_name";
            this.invn_ad_cst_name.Size = new System.Drawing.Size(165, 21);
            this.invn_ad_cst_name.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer Name";
            // 
            // invn_ad_invoicenmbr
            // 
            this.invn_ad_invoicenmbr.Location = new System.Drawing.Point(340, 20);
            this.invn_ad_invoicenmbr.Name = "invn_ad_invoicenmbr";
            this.invn_ad_invoicenmbr.Size = new System.Drawing.Size(67, 20);
            this.invn_ad_invoicenmbr.TabIndex = 3;
            this.invn_ad_invoicenmbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(297, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Status";
            this.label18.Click += new System.EventHandler(this.label18_Click);
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
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Receive :";
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
            // invn_ad_done
            // 
            this.invn_ad_done.Location = new System.Drawing.Point(333, 71);
            this.invn_ad_done.Name = "invn_ad_done";
            this.invn_ad_done.Size = new System.Drawing.Size(75, 23);
            this.invn_ad_done.TabIndex = 7;
            this.invn_ad_done.Text = "Done";
            this.invn_ad_done.UseVisualStyleBackColor = true;
            this.invn_ad_done.Click += new System.EventHandler(this.button4_Click);
            // 
            // invn_ad_status
            // 
            this.invn_ad_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Petrol",
            "Entertainment",
            "Home",
            "Load",
            "Cargo",
            "Chay"});
            this.invn_ad_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invn_ad_status.FormattingEnabled = true;
            this.invn_ad_status.Items.AddRange(new object[] {
            "Invoice",
            "Receive"});
            this.invn_ad_status.Location = new System.Drawing.Point(340, 45);
            this.invn_ad_status.Name = "invn_ad_status";
            this.invn_ad_status.Size = new System.Drawing.Size(66, 21);
            this.invn_ad_status.TabIndex = 4;
            this.invn_ad_status.SelectedIndexChanged += new System.EventHandler(this.invn_ad_status_SelectedIndexChanged);
            // 
            // inv1_ad_detail
            // 
            this.inv1_ad_detail.Location = new System.Drawing.Point(96, 46);
            this.inv1_ad_detail.Multiline = true;
            this.inv1_ad_detail.Name = "inv1_ad_detail";
            this.inv1_ad_detail.Size = new System.Drawing.Size(165, 48);
            this.inv1_ad_detail.TabIndex = 2;
            this.inv1_ad_detail.TextChanged += new System.EventHandler(this.inv1_ad_detail_TextChanged);
            // 
            // invn_ad_balance
            // 
            this.invn_ad_balance.Enabled = false;
            this.invn_ad_balance.Location = new System.Drawing.Point(498, 69);
            this.invn_ad_balance.Name = "invn_ad_balance";
            this.invn_ad_balance.Size = new System.Drawing.Size(74, 20);
            this.invn_ad_balance.TabIndex = 1;
            this.invn_ad_balance.Text = "22";
            this.invn_ad_balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // invn_ad_receive
            // 
            this.invn_ad_receive.Location = new System.Drawing.Point(498, 43);
            this.invn_ad_receive.Name = "invn_ad_receive";
            this.invn_ad_receive.Size = new System.Drawing.Size(74, 20);
            this.invn_ad_receive.TabIndex = 6;
            this.invn_ad_receive.TextChanged += new System.EventHandler(this.invn_ad_receive_TextChanged);
            this.invn_ad_receive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // invn_ad_total
            // 
            this.invn_ad_total.Location = new System.Drawing.Point(498, 19);
            this.invn_ad_total.Name = "invn_ad_total";
            this.invn_ad_total.Size = new System.Drawing.Size(74, 20);
            this.invn_ad_total.TabIndex = 5;
            this.invn_ad_total.TextChanged += new System.EventHandler(this.inv1_ad_detail_TextChanged);
            this.invn_ad_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date :";
            // 
            // invn_srch_nmbr
            // 
            this.invn_srch_nmbr.Location = new System.Drawing.Point(365, 71);
            this.invn_srch_nmbr.Name = "invn_srch_nmbr";
            this.invn_srch_nmbr.Size = new System.Drawing.Size(67, 20);
            this.invn_srch_nmbr.TabIndex = 1;
            this.invn_srch_nmbr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.invn_srch_nmbr_KeyDown);
            this.invn_srch_nmbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.invn_srch_nmbr_KeyPress);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.invn_srch_cst_name);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.invn_srch_tody);
            this.groupBox2.Controls.Add(this.invn_srch_daily);
            this.groupBox2.Controls.Add(this.invn_srch_fromdate);
            this.groupBox2.Controls.Add(this.invn_srch_todate);
            this.groupBox2.Controls.Add(this.invn_srch_nmbr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(603, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // invn_srch_cst_name
            // 
            this.invn_srch_cst_name.AutoCompleteCustomSource.AddRange(new string[] {
            "Petrol",
            "Entertainment",
            "Home",
            "Load",
            "Cargo",
            "Chay"});
            this.invn_srch_cst_name.FormattingEnabled = true;
            this.invn_srch_cst_name.Location = new System.Drawing.Point(96, 19);
            this.invn_srch_cst_name.Name = "invn_srch_cst_name";
            this.invn_srch_cst_name.Size = new System.Drawing.Size(279, 21);
            this.invn_srch_cst_name.TabIndex = 2;
            this.invn_srch_cst_name.SelectedIndexChanged += new System.EventHandler(this.invn_srch_cst_name_SelectedIndexChanged);
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
            this.label9.Location = new System.Drawing.Point(8, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Customer Name";
            // 
            // invn_srch_fromdate
            // 
            this.invn_srch_fromdate.Location = new System.Drawing.Point(97, 46);
            this.invn_srch_fromdate.Name = "invn_srch_fromdate";
            this.invn_srch_fromdate.Size = new System.Drawing.Size(180, 20);
            this.invn_srch_fromdate.TabIndex = 10;
            // 
            // inv_datetoday
            // 
            this.inv_datetoday.Location = new System.Drawing.Point(773, 25);
            this.inv_datetoday.Name = "inv_datetoday";
            this.inv_datetoday.Size = new System.Drawing.Size(213, 20);
            this.inv_datetoday.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(116, 612);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(375, 612);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Receive :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(651, 612);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Balance :";
            // 
            // total_invoice
            // 
            this.total_invoice.AutoSize = true;
            this.total_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_invoice.ForeColor = System.Drawing.Color.DarkBlue;
            this.total_invoice.Location = new System.Drawing.Point(170, 609);
            this.total_invoice.Name = "total_invoice";
            this.total_invoice.Size = new System.Drawing.Size(59, 20);
            this.total_invoice.TabIndex = 6;
            this.total_invoice.Text = "00000";
            // 
            // recive_invo
            // 
            this.recive_invo.AutoSize = true;
            this.recive_invo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recive_invo.ForeColor = System.Drawing.Color.DarkBlue;
            this.recive_invo.Location = new System.Drawing.Point(448, 609);
            this.recive_invo.Name = "recive_invo";
            this.recive_invo.Size = new System.Drawing.Size(59, 20);
            this.recive_invo.TabIndex = 6;
            this.recive_invo.Text = "00000";
            // 
            // invn_balance
            // 
            this.invn_balance.AutoSize = true;
            this.invn_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invn_balance.ForeColor = System.Drawing.Color.DarkBlue;
            this.invn_balance.Location = new System.Drawing.Point(724, 609);
            this.invn_balance.Name = "invn_balance";
            this.invn_balance.Size = new System.Drawing.Size(59, 20);
            this.invn_balance.TabIndex = 6;
            this.invn_balance.Text = "00000";
            // 
            // invn_srch_tody
            // 
            this.invn_srch_tody.Location = new System.Drawing.Point(6, 48);
            this.invn_srch_tody.Name = "invn_srch_tody";
            this.invn_srch_tody.Size = new System.Drawing.Size(49, 40);
            this.invn_srch_tody.TabIndex = 11;
            this.invn_srch_tody.Text = "Today";
            this.invn_srch_tody.UseVisualStyleBackColor = true;
            this.invn_srch_tody.Click += new System.EventHandler(this.invn_srch_tody_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inv_datetoday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invn_gridview);
            this.Controls.Add(this.invn_balance);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recive_invo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_invoice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invn_gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button invn_srch_daily;
        private System.Windows.Forms.DateTimePicker invn_srch_todate;
        private System.Windows.Forms.DataGridView invn_gridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox invn_ad_invoicenmbr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button invn_ad_done;
        private System.Windows.Forms.ComboBox invn_ad_cst_name;
        private System.Windows.Forms.TextBox inv1_ad_detail;
        private System.Windows.Forms.TextBox invn_ad_balance;
        private System.Windows.Forms.TextBox invn_ad_receive;
        private System.Windows.Forms.TextBox invn_ad_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invn_srch_nmbr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox invn_srch_cst_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker inv_datetoday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label total_invoice;
        private System.Windows.Forms.Label recive_invo;
        private System.Windows.Forms.Label invn_balance;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox invn_ad_status;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker invn_srch_fromdate;
        private System.Windows.Forms.Button invn_srch_tody;

    }
}
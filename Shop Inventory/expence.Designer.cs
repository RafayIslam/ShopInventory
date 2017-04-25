namespace Shop_Inventory
{
    partial class Expences
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dl_exp_done = new System.Windows.Forms.Button();
            this.dl_exp_type = new System.Windows.Forms.ComboBox();
            this.dl_exp_discription = new System.Windows.Forms.TextBox();
            this.dl_exp_amouth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dl_exp_today = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dl_exp_datagrid = new System.Windows.Forms.DataGridView();
            this.dl_exp_fromdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dl_exp_rent = new System.Windows.Forms.Label();
            this.dl_exp_transport = new System.Windows.Forms.Label();
            this.dl_exp_entrmnt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dl_exp_cargo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dl_exp_bike = new System.Windows.Forms.Label();
            this.dl_exp_load = new System.Windows.Forms.Label();
            this.dl_exp_utility = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dl_exp_home = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dl_exp_petrol = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dl_exp_sallary = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dl_exp_other = new System.Windows.Forms.Label();
            this.dl_exp_chay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dl_exp_todate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dl_exp_datagrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dl_exp_done);
            this.groupBox1.Controls.Add(this.dl_exp_type);
            this.groupBox1.Controls.Add(this.dl_exp_discription);
            this.groupBox1.Controls.Add(this.dl_exp_amouth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dl_exp_today);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Expence";
            // 
            // dl_exp_done
            // 
            this.dl_exp_done.Location = new System.Drawing.Point(208, 103);
            this.dl_exp_done.Name = "dl_exp_done";
            this.dl_exp_done.Size = new System.Drawing.Size(75, 23);
            this.dl_exp_done.TabIndex = 5;
            this.dl_exp_done.Text = "Done";
            this.dl_exp_done.UseVisualStyleBackColor = true;
            this.dl_exp_done.Click += new System.EventHandler(this.button4_Click);
            // 
            // dl_exp_type
            // 
            this.dl_exp_type.AutoCompleteCustomSource.AddRange(new string[] {
            "Petrol",
            "Entertainment",
            "Home",
            "Load",
            "Cargo",
            "Chay"});
            this.dl_exp_type.FormattingEnabled = true;
            this.dl_exp_type.Items.AddRange(new object[] {
            "Petrol",
            "Entertainment",
            "Home",
            "Load",
            "Cargo",
            "Chay",
            "Bike",
            "Transport",
            "Utility bills",
            "Sallary",
            "Rent",
            "Other"});
            this.dl_exp_type.Location = new System.Drawing.Point(6, 20);
            this.dl_exp_type.Name = "dl_exp_type";
            this.dl_exp_type.Size = new System.Drawing.Size(147, 21);
            this.dl_exp_type.TabIndex = 1;
            this.dl_exp_type.Text = "Home";
            // 
            // dl_exp_discription
            // 
            this.dl_exp_discription.Location = new System.Drawing.Point(77, 49);
            this.dl_exp_discription.Name = "dl_exp_discription";
            this.dl_exp_discription.Size = new System.Drawing.Size(206, 20);
            this.dl_exp_discription.TabIndex = 3;
            // 
            // dl_exp_amouth
            // 
            this.dl_exp_amouth.Location = new System.Drawing.Point(159, 20);
            this.dl_exp_amouth.Name = "dl_exp_amouth";
            this.dl_exp_amouth.Size = new System.Drawing.Size(124, 20);
            this.dl_exp_amouth.TabIndex = 2;
            this.dl_exp_amouth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discription";
            // 
            // dl_exp_today
            // 
            this.dl_exp_today.Location = new System.Drawing.Point(77, 77);
            this.dl_exp_today.Name = "dl_exp_today";
            this.dl_exp_today.Size = new System.Drawing.Size(206, 20);
            this.dl_exp_today.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(35, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "Date";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Monthly";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dl_exp_datagrid
            // 
            this.dl_exp_datagrid.AllowUserToOrderColumns = true;
            this.dl_exp_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dl_exp_datagrid.Location = new System.Drawing.Point(12, 205);
            this.dl_exp_datagrid.Name = "dl_exp_datagrid";
            this.dl_exp_datagrid.Size = new System.Drawing.Size(895, 464);
            this.dl_exp_datagrid.TabIndex = 1;
            this.dl_exp_datagrid.TabStop = false;
            // 
            // dl_exp_fromdate
            // 
            this.dl_exp_fromdate.Location = new System.Drawing.Point(401, 40);
            this.dl_exp_fromdate.Name = "dl_exp_fromdate";
            this.dl_exp_fromdate.Size = new System.Drawing.Size(182, 20);
            this.dl_exp_fromdate.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(832, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dl_exp_rent);
            this.groupBox2.Controls.Add(this.dl_exp_transport);
            this.groupBox2.Controls.Add(this.dl_exp_entrmnt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dl_exp_cargo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.dl_exp_bike);
            this.groupBox2.Controls.Add(this.dl_exp_load);
            this.groupBox2.Controls.Add(this.dl_exp_utility);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dl_exp_home);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dl_exp_petrol);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dl_exp_sallary);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dl_exp_other);
            this.groupBox2.Controls.Add(this.dl_exp_chay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(317, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expence Amount ";
            // 
            // dl_exp_rent
            // 
            this.dl_exp_rent.AutoSize = true;
            this.dl_exp_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_rent.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_rent.Location = new System.Drawing.Point(507, 106);
            this.dl_exp_rent.Name = "dl_exp_rent";
            this.dl_exp_rent.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_rent.TabIndex = 13;
            this.dl_exp_rent.Text = "0.00";
            // 
            // dl_exp_transport
            // 
            this.dl_exp_transport.AutoSize = true;
            this.dl_exp_transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_transport.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_transport.Location = new System.Drawing.Point(507, 77);
            this.dl_exp_transport.Name = "dl_exp_transport";
            this.dl_exp_transport.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_transport.TabIndex = 13;
            this.dl_exp_transport.Text = "0.00";
            // 
            // dl_exp_entrmnt
            // 
            this.dl_exp_entrmnt.AutoSize = true;
            this.dl_exp_entrmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_entrmnt.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_entrmnt.Location = new System.Drawing.Point(507, 47);
            this.dl_exp_entrmnt.Name = "dl_exp_entrmnt";
            this.dl_exp_entrmnt.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_entrmnt.TabIndex = 13;
            this.dl_exp_entrmnt.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Transport";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(366, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Rent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enertainment";
            // 
            // dl_exp_cargo
            // 
            this.dl_exp_cargo.AutoSize = true;
            this.dl_exp_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_cargo.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_cargo.Location = new System.Drawing.Point(507, 20);
            this.dl_exp_cargo.Name = "dl_exp_cargo";
            this.dl_exp_cargo.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_cargo.TabIndex = 11;
            this.dl_exp_cargo.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(366, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cargo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(255, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "0.00";
            // 
            // dl_exp_bike
            // 
            this.dl_exp_bike.AutoSize = true;
            this.dl_exp_bike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_bike.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_bike.Location = new System.Drawing.Point(255, 74);
            this.dl_exp_bike.Name = "dl_exp_bike";
            this.dl_exp_bike.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_bike.TabIndex = 9;
            this.dl_exp_bike.Text = "0.00";
            // 
            // dl_exp_load
            // 
            this.dl_exp_load.AutoSize = true;
            this.dl_exp_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_load.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_load.Location = new System.Drawing.Point(255, 47);
            this.dl_exp_load.Name = "dl_exp_load";
            this.dl_exp_load.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_load.TabIndex = 9;
            this.dl_exp_load.Text = "0.00";
            // 
            // dl_exp_utility
            // 
            this.dl_exp_utility.AutoSize = true;
            this.dl_exp_utility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_utility.Location = new System.Drawing.Point(192, 106);
            this.dl_exp_utility.Name = "dl_exp_utility";
            this.dl_exp_utility.Size = new System.Drawing.Size(54, 20);
            this.dl_exp_utility.TabIndex = 8;
            this.dl_exp_utility.Text = "Utility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bike";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(192, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Load";
            // 
            // dl_exp_home
            // 
            this.dl_exp_home.AutoSize = true;
            this.dl_exp_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_home.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_home.Location = new System.Drawing.Point(255, 20);
            this.dl_exp_home.Name = "dl_exp_home";
            this.dl_exp_home.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_home.TabIndex = 7;
            this.dl_exp_home.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(192, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Home";
            // 
            // dl_exp_petrol
            // 
            this.dl_exp_petrol.AutoSize = true;
            this.dl_exp_petrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_petrol.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_petrol.Location = new System.Drawing.Point(83, 47);
            this.dl_exp_petrol.Name = "dl_exp_petrol";
            this.dl_exp_petrol.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_petrol.TabIndex = 5;
            this.dl_exp_petrol.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Sallary";
            this.label15.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Other";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dl_exp_sallary
            // 
            this.dl_exp_sallary.AutoSize = true;
            this.dl_exp_sallary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_sallary.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_sallary.Location = new System.Drawing.Point(83, 106);
            this.dl_exp_sallary.Name = "dl_exp_sallary";
            this.dl_exp_sallary.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_sallary.TabIndex = 1;
            this.dl_exp_sallary.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Petrol";
            // 
            // dl_exp_other
            // 
            this.dl_exp_other.AutoSize = true;
            this.dl_exp_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_other.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_other.Location = new System.Drawing.Point(83, 74);
            this.dl_exp_other.Name = "dl_exp_other";
            this.dl_exp_other.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_other.TabIndex = 1;
            this.dl_exp_other.Text = "0.00";
            // 
            // dl_exp_chay
            // 
            this.dl_exp_chay.AutoSize = true;
            this.dl_exp_chay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl_exp_chay.ForeColor = System.Drawing.Color.Maroon;
            this.dl_exp_chay.Location = new System.Drawing.Point(83, 20);
            this.dl_exp_chay.Name = "dl_exp_chay";
            this.dl_exp_chay.Size = new System.Drawing.Size(44, 20);
            this.dl_exp_chay.TabIndex = 1;
            this.dl_exp_chay.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Daily Expences Detail";
            // 
            // dl_exp_todate
            // 
            this.dl_exp_todate.Location = new System.Drawing.Point(638, 40);
            this.dl_exp_todate.Name = "dl_exp_todate";
            this.dl_exp_todate.Size = new System.Drawing.Size(180, 20);
            this.dl_exp_todate.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(359, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "From";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(611, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "To";
            // 
            // Expences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dl_exp_todate);
            this.Controls.Add(this.dl_exp_fromdate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dl_exp_datagrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Name = "Expences";
            this.Text = "expence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dl_exp_datagrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dl_exp_datagrid;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button dl_exp_done;
        private System.Windows.Forms.ComboBox dl_exp_type;
        private System.Windows.Forms.TextBox dl_exp_amouth;
        private System.Windows.Forms.DateTimePicker dl_exp_fromdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label dl_exp_entrmnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dl_exp_cargo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dl_exp_load;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dl_exp_home;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dl_exp_petrol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dl_exp_chay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dl_exp_other;
        private System.Windows.Forms.Label dl_exp_transport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dl_exp_bike;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dl_exp_discription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dl_exp_todate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dl_exp_today;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label dl_exp_utility;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label dl_exp_sallary;
        private System.Windows.Forms.Label dl_exp_rent;
        private System.Windows.Forms.Label label8;
    }
}
namespace TrigeTangCustomers
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.lv_Customers = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adr1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adr2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_RemoveSelected = new System.Windows.Forms.Button();
            this.btn_RemoveAll = new System.Windows.Forms.Button();
            this.btn_ConCSV = new System.Windows.Forms.Button();
            this.lbl_Adr1 = new System.Windows.Forms.Label();
            this.tb_Adr1 = new System.Windows.Forms.TextBox();
            this.tb_Adr2 = new System.Windows.Forms.TextBox();
            this.tb_PCode = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_PNumber = new System.Windows.Forms.TextBox();
            this.lbl_Adr2 = new System.Windows.Forms.Label();
            this.lbl_PCode = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_PNumber = new System.Windows.Forms.Label();
            this.Main_Notifyer = new System.Windows.Forms.NotifyIcon(this.components);
            this.gb_Customers = new System.Windows.Forms.GroupBox();
            this.gb_Info = new System.Windows.Forms.GroupBox();
            this.dtp_CustomerEnd = new System.Windows.Forms.DateTimePicker();
            this.lbl_CustomerEnd = new System.Windows.Forms.Label();
            this.dtp_CustomerSince = new System.Windows.Forms.DateTimePicker();
            this.lbl_CustomerID = new System.Windows.Forms.Label();
            this.tb_CustomerID = new System.Windows.Forms.TextBox();
            this.lbl_CustomerSince = new System.Windows.Forms.Label();
            this.gb_Customers.SuspendLayout();
            this.gb_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Customers
            // 
            this.lv_Customers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.FullName,
            this.Adr1,
            this.Adr2,
            this.PCode,
            this.City,
            this.Email,
            this.PNumber});
            this.lv_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Customers.Location = new System.Drawing.Point(3, 16);
            this.lv_Customers.Name = "lv_Customers";
            this.lv_Customers.Size = new System.Drawing.Size(296, 258);
            this.lv_Customers.TabIndex = 0;
            this.lv_Customers.UseCompatibleStateImageBehavior = false;
            this.lv_Customers.View = System.Windows.Forms.View.List;
            this.lv_Customers.SelectedIndexChanged += new System.EventHandler(this.lv_Customers_SelectedIndexChanged);
            // 
            // CustomerID
            // 
            this.CustomerID.DisplayIndex = 7;
            this.CustomerID.Text = "CustomerID";
            // 
            // FullName
            // 
            this.FullName.DisplayIndex = 0;
            this.FullName.Text = "Full Name";
            this.FullName.Width = 74;
            // 
            // Adr1
            // 
            this.Adr1.DisplayIndex = 1;
            this.Adr1.Text = "Address 1";
            this.Adr1.Width = 95;
            // 
            // Adr2
            // 
            this.Adr2.DisplayIndex = 2;
            this.Adr2.Text = "Address 2";
            this.Adr2.Width = 86;
            // 
            // PCode
            // 
            this.PCode.DisplayIndex = 3;
            this.PCode.Text = "Postal Code";
            this.PCode.Width = 71;
            // 
            // City
            // 
            this.City.DisplayIndex = 4;
            this.City.Text = "City";
            this.City.Width = 81;
            // 
            // Email
            // 
            this.Email.DisplayIndex = 5;
            this.Email.Text = "Email";
            // 
            // PNumber
            // 
            this.PNumber.DisplayIndex = 6;
            this.PNumber.Text = "Phone Number";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(90, 39);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(205, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(319, 18);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 33);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add Customer";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Location = new System.Drawing.Point(3, 42);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(319, 57);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 33);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save Changes";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(319, 96);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(110, 33);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove Customer";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_RemoveSelected
            // 
            this.btn_RemoveSelected.Location = new System.Drawing.Point(319, 154);
            this.btn_RemoveSelected.Name = "btn_RemoveSelected";
            this.btn_RemoveSelected.Size = new System.Drawing.Size(110, 33);
            this.btn_RemoveSelected.TabIndex = 6;
            this.btn_RemoveSelected.Text = "Remove Selected";
            this.btn_RemoveSelected.UseVisualStyleBackColor = true;
            this.btn_RemoveSelected.Click += new System.EventHandler(this.btn_RemoveSelected_Click);
            // 
            // btn_RemoveAll
            // 
            this.btn_RemoveAll.Location = new System.Drawing.Point(319, 193);
            this.btn_RemoveAll.Name = "btn_RemoveAll";
            this.btn_RemoveAll.Size = new System.Drawing.Size(110, 33);
            this.btn_RemoveAll.TabIndex = 7;
            this.btn_RemoveAll.Text = "Remove All";
            this.btn_RemoveAll.UseVisualStyleBackColor = true;
            this.btn_RemoveAll.Click += new System.EventHandler(this.btn_RemoveAll_Click);
            // 
            // btn_ConCSV
            // 
            this.btn_ConCSV.Location = new System.Drawing.Point(319, 256);
            this.btn_ConCSV.Name = "btn_ConCSV";
            this.btn_ConCSV.Size = new System.Drawing.Size(110, 33);
            this.btn_ConCSV.TabIndex = 8;
            this.btn_ConCSV.Text = "Convert To CSV";
            this.btn_ConCSV.UseVisualStyleBackColor = true;
            this.btn_ConCSV.Click += new System.EventHandler(this.btn_ConCSV_Click);
            // 
            // lbl_Adr1
            // 
            this.lbl_Adr1.AutoSize = true;
            this.lbl_Adr1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Adr1.Location = new System.Drawing.Point(3, 68);
            this.lbl_Adr1.Name = "lbl_Adr1";
            this.lbl_Adr1.Size = new System.Drawing.Size(57, 13);
            this.lbl_Adr1.TabIndex = 10;
            this.lbl_Adr1.Text = "Address 1:";
            // 
            // tb_Adr1
            // 
            this.tb_Adr1.Location = new System.Drawing.Point(90, 65);
            this.tb_Adr1.Name = "tb_Adr1";
            this.tb_Adr1.Size = new System.Drawing.Size(205, 20);
            this.tb_Adr1.TabIndex = 11;
            // 
            // tb_Adr2
            // 
            this.tb_Adr2.Location = new System.Drawing.Point(90, 91);
            this.tb_Adr2.Name = "tb_Adr2";
            this.tb_Adr2.Size = new System.Drawing.Size(205, 20);
            this.tb_Adr2.TabIndex = 12;
            // 
            // tb_PCode
            // 
            this.tb_PCode.Location = new System.Drawing.Point(90, 117);
            this.tb_PCode.Name = "tb_PCode";
            this.tb_PCode.Size = new System.Drawing.Size(205, 20);
            this.tb_PCode.TabIndex = 13;
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(90, 143);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(205, 20);
            this.tb_City.TabIndex = 14;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(90, 169);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(205, 20);
            this.tb_Email.TabIndex = 15;
            // 
            // tb_PNumber
            // 
            this.tb_PNumber.Location = new System.Drawing.Point(90, 195);
            this.tb_PNumber.Name = "tb_PNumber";
            this.tb_PNumber.Size = new System.Drawing.Size(205, 20);
            this.tb_PNumber.TabIndex = 16;
            // 
            // lbl_Adr2
            // 
            this.lbl_Adr2.AutoSize = true;
            this.lbl_Adr2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Adr2.Location = new System.Drawing.Point(4, 94);
            this.lbl_Adr2.Name = "lbl_Adr2";
            this.lbl_Adr2.Size = new System.Drawing.Size(57, 13);
            this.lbl_Adr2.TabIndex = 17;
            this.lbl_Adr2.Text = "Address 2:";
            // 
            // lbl_PCode
            // 
            this.lbl_PCode.AutoSize = true;
            this.lbl_PCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PCode.Location = new System.Drawing.Point(3, 120);
            this.lbl_PCode.Name = "lbl_PCode";
            this.lbl_PCode.Size = new System.Drawing.Size(67, 13);
            this.lbl_PCode.TabIndex = 18;
            this.lbl_PCode.Text = "Postal Code:";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.Color.Transparent;
            this.lbl_City.Location = new System.Drawing.Point(4, 146);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(27, 13);
            this.lbl_City.TabIndex = 19;
            this.lbl_City.Text = "City:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Location = new System.Drawing.Point(3, 172);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(35, 13);
            this.lbl_Email.TabIndex = 20;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_PNumber
            // 
            this.lbl_PNumber.AutoSize = true;
            this.lbl_PNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PNumber.Location = new System.Drawing.Point(3, 198);
            this.lbl_PNumber.Name = "lbl_PNumber";
            this.lbl_PNumber.Size = new System.Drawing.Size(81, 13);
            this.lbl_PNumber.TabIndex = 21;
            this.lbl_PNumber.Text = "Phone Number:";
            // 
            // Main_Notifyer
            // 
            this.Main_Notifyer.Icon = ((System.Drawing.Icon)(resources.GetObject("Main_Notifyer.Icon")));
            this.Main_Notifyer.Text = "Main Notifyer";
            this.Main_Notifyer.Visible = true;
            this.Main_Notifyer.DoubleClick += new System.EventHandler(this.Main_Notifyer_DoubleClick);
            // 
            // gb_Customers
            // 
            this.gb_Customers.BackColor = System.Drawing.Color.Transparent;
            this.gb_Customers.Controls.Add(this.lv_Customers);
            this.gb_Customers.Location = new System.Drawing.Point(435, 12);
            this.gb_Customers.Name = "gb_Customers";
            this.gb_Customers.Size = new System.Drawing.Size(302, 277);
            this.gb_Customers.TabIndex = 22;
            this.gb_Customers.TabStop = false;
            this.gb_Customers.Text = "Customers";
            // 
            // gb_Info
            // 
            this.gb_Info.BackColor = System.Drawing.Color.Transparent;
            this.gb_Info.Controls.Add(this.dtp_CustomerEnd);
            this.gb_Info.Controls.Add(this.lbl_CustomerEnd);
            this.gb_Info.Controls.Add(this.dtp_CustomerSince);
            this.gb_Info.Controls.Add(this.lbl_CustomerID);
            this.gb_Info.Controls.Add(this.tb_CustomerID);
            this.gb_Info.Controls.Add(this.lbl_CustomerSince);
            this.gb_Info.Controls.Add(this.lbl_Name);
            this.gb_Info.Controls.Add(this.tb_Name);
            this.gb_Info.Controls.Add(this.lbl_PNumber);
            this.gb_Info.Controls.Add(this.lbl_Adr1);
            this.gb_Info.Controls.Add(this.lbl_Email);
            this.gb_Info.Controls.Add(this.tb_Adr1);
            this.gb_Info.Controls.Add(this.lbl_City);
            this.gb_Info.Controls.Add(this.tb_Adr2);
            this.gb_Info.Controls.Add(this.lbl_PCode);
            this.gb_Info.Controls.Add(this.tb_PCode);
            this.gb_Info.Controls.Add(this.lbl_Adr2);
            this.gb_Info.Controls.Add(this.tb_City);
            this.gb_Info.Controls.Add(this.tb_PNumber);
            this.gb_Info.Controls.Add(this.tb_Email);
            this.gb_Info.Location = new System.Drawing.Point(12, 12);
            this.gb_Info.Name = "gb_Info";
            this.gb_Info.Size = new System.Drawing.Size(301, 277);
            this.gb_Info.TabIndex = 23;
            this.gb_Info.TabStop = false;
            this.gb_Info.Text = "Information";
            // 
            // dtp_CustomerEnd
            // 
            this.dtp_CustomerEnd.CustomFormat = "dd/MM/yyyy";
            this.dtp_CustomerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CustomerEnd.Location = new System.Drawing.Point(90, 248);
            this.dtp_CustomerEnd.Name = "dtp_CustomerEnd";
            this.dtp_CustomerEnd.Size = new System.Drawing.Size(205, 20);
            this.dtp_CustomerEnd.TabIndex = 27;
            // 
            // lbl_CustomerEnd
            // 
            this.lbl_CustomerEnd.AutoSize = true;
            this.lbl_CustomerEnd.Location = new System.Drawing.Point(3, 252);
            this.lbl_CustomerEnd.Name = "lbl_CustomerEnd";
            this.lbl_CustomerEnd.Size = new System.Drawing.Size(76, 13);
            this.lbl_CustomerEnd.TabIndex = 26;
            this.lbl_CustomerEnd.Text = "Customer End:";
            // 
            // dtp_CustomerSince
            // 
            this.dtp_CustomerSince.CustomFormat = "dd/MM/yyyy";
            this.dtp_CustomerSince.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CustomerSince.Location = new System.Drawing.Point(90, 222);
            this.dtp_CustomerSince.Name = "dtp_CustomerSince";
            this.dtp_CustomerSince.Size = new System.Drawing.Size(205, 20);
            this.dtp_CustomerSince.TabIndex = 25;
            // 
            // lbl_CustomerID
            // 
            this.lbl_CustomerID.AutoSize = true;
            this.lbl_CustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CustomerID.Location = new System.Drawing.Point(3, 16);
            this.lbl_CustomerID.Name = "lbl_CustomerID";
            this.lbl_CustomerID.Size = new System.Drawing.Size(65, 13);
            this.lbl_CustomerID.TabIndex = 24;
            this.lbl_CustomerID.Text = "CustomerID:";
            // 
            // tb_CustomerID
            // 
            this.tb_CustomerID.Enabled = false;
            this.tb_CustomerID.Location = new System.Drawing.Point(90, 13);
            this.tb_CustomerID.Name = "tb_CustomerID";
            this.tb_CustomerID.ReadOnly = true;
            this.tb_CustomerID.Size = new System.Drawing.Size(205, 20);
            this.tb_CustomerID.TabIndex = 23;
            // 
            // lbl_CustomerSince
            // 
            this.lbl_CustomerSince.AutoSize = true;
            this.lbl_CustomerSince.Location = new System.Drawing.Point(4, 225);
            this.lbl_CustomerSince.Name = "lbl_CustomerSince";
            this.lbl_CustomerSince.Size = new System.Drawing.Size(84, 13);
            this.lbl_CustomerSince.TabIndex = 22;
            this.lbl_CustomerSince.Text = "Customer Since:";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrigeTangCustomers.Properties.Resources.ipad_2_wallpaper_blue;
            this.ClientSize = new System.Drawing.Size(749, 298);
            this.Controls.Add(this.gb_Info);
            this.Controls.Add(this.gb_Customers);
            this.Controls.Add(this.btn_ConCSV);
            this.Controls.Add(this.btn_RemoveAll);
            this.Controls.Add(this.btn_RemoveSelected);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Trige And Tang Customers by Kent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.gb_Customers.ResumeLayout(false);
            this.gb_Info.ResumeLayout(false);
            this.gb_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Customers;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_RemoveSelected;
        private System.Windows.Forms.Button btn_RemoveAll;
        private System.Windows.Forms.Button btn_ConCSV;
        private System.Windows.Forms.Label lbl_Adr1;
        private System.Windows.Forms.TextBox tb_Adr1;
        private System.Windows.Forms.TextBox tb_Adr2;
        private System.Windows.Forms.TextBox tb_PCode;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_PNumber;
        private System.Windows.Forms.Label lbl_Adr2;
        private System.Windows.Forms.Label lbl_PCode;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_PNumber;
        private System.Windows.Forms.NotifyIcon Main_Notifyer;
        private System.Windows.Forms.GroupBox gb_Customers;
        private System.Windows.Forms.GroupBox gb_Info;
        private System.Windows.Forms.Label lbl_CustomerSince;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader Adr1;
        private System.Windows.Forms.ColumnHeader Adr2;
        private System.Windows.Forms.ColumnHeader PCode;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader PNumber;
        private System.Windows.Forms.Label lbl_CustomerID;
        private System.Windows.Forms.TextBox tb_CustomerID;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.DateTimePicker dtp_CustomerSince;
        private System.Windows.Forms.Label lbl_CustomerEnd;
        private System.Windows.Forms.DateTimePicker dtp_CustomerEnd;
    }
}


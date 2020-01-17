namespace ToolSys
{
    partial class frmUpdateCustomer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerLabel = new System.Windows.Forms.Label();
            this.customerInformation = new System.Windows.Forms.DataGridView();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eircode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_Box = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.eircodeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.eircodeBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // searchCustomerLabel
            // 
            this.searchCustomerLabel.AutoSize = true;
            this.searchCustomerLabel.Location = new System.Drawing.Point(37, 56);
            this.searchCustomerLabel.Name = "searchCustomerLabel";
            this.searchCustomerLabel.Size = new System.Drawing.Size(88, 13);
            this.searchCustomerLabel.TabIndex = 1;
            this.searchCustomerLabel.Text = "Search Customer";
            // 
            // customerInformation
            // 
            this.customerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cust_ID,
            this.First_Name,
            this.Last_Name,
            this.Eircode,
            this.Contact});
            this.customerInformation.Location = new System.Drawing.Point(24, 94);
            this.customerInformation.Name = "customerInformation";
            this.customerInformation.Size = new System.Drawing.Size(537, 150);
            this.customerInformation.TabIndex = 2;
            // 
            // Cust_ID
            // 
            this.Cust_ID.HeaderText = "Cust_ID";
            this.Cust_ID.Name = "Cust_ID";
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            // 
            // Eircode
            // 
            this.Eircode.HeaderText = "Eircode";
            this.Eircode.Name = "Eircode";
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact Number";
            this.Contact.Name = "Contact";
            // 
            // search_Box
            // 
            this.search_Box.Location = new System.Drawing.Point(156, 49);
            this.search_Box.Name = "search_Box";
            this.search_Box.Size = new System.Drawing.Size(216, 20);
            this.search_Box.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(427, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(204, 261);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(168, 36);
            this.btnSelectCustomer.TabIndex = 5;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(37, 324);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(37, 363);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // eircodeLabel
            // 
            this.eircodeLabel.AutoSize = true;
            this.eircodeLabel.Location = new System.Drawing.Point(37, 412);
            this.eircodeLabel.Name = "eircodeLabel";
            this.eircodeLabel.Size = new System.Drawing.Size(46, 13);
            this.eircodeLabel.TabIndex = 8;
            this.eircodeLabel.Text = "Eircode:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(37, 450);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(87, 13);
            this.contactLabel.TabIndex = 9;
            this.contactLabel.Text = "Contact Number:";
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(202, 324);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(170, 20);
            this.fNameBox.TabIndex = 10;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(202, 363);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(170, 20);
            this.lastNameBox.TabIndex = 11;
            // 
            // eircodeBox
            // 
            this.eircodeBox.Location = new System.Drawing.Point(202, 412);
            this.eircodeBox.Name = "eircodeBox";
            this.eircodeBox.Size = new System.Drawing.Size(170, 20);
            this.eircodeBox.TabIndex = 12;
            this.eircodeBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(204, 450);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(170, 20);
            this.contactBox.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 486);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 532);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.eircodeBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.eircodeLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.search_Box);
            this.Controls.Add(this.customerInformation);
            this.Controls.Add(this.searchCustomerLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUpdateCustomer";
            this.Text = "frmUpdateCustomer";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label searchCustomerLabel;
        private System.Windows.Forms.DataGridView customerInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eircode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.TextBox search_Box;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label eircodeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox eircodeBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.Button btnUpdate;
    }
}
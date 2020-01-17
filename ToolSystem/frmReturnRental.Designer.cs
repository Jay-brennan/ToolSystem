namespace ToolSys
{
    partial class frmReturnRental
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
            this.customerLabel = new System.Windows.Forms.Label();
            this.Cust_Box = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.customerInformation = new System.Windows.Forms.DataGridView();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eircode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.toolInformation = new System.Windows.Forms.DataGridView();
            this.ToolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnLabel = new System.Windows.Forms.Button();
            this.btnFinishReturn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
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
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(60, 42);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(113, 13);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Enter Customer Name:";
            // 
            // Cust_Box
            // 
            this.Cust_Box.Location = new System.Drawing.Point(211, 39);
            this.Cust_Box.Name = "Cust_Box";
            this.Cust_Box.Size = new System.Drawing.Size(179, 20);
            this.Cust_Box.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(434, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.customerInformation.Location = new System.Drawing.Point(15, 97);
            this.customerInformation.Name = "customerInformation";
            this.customerInformation.Size = new System.Drawing.Size(543, 150);
            this.customerInformation.TabIndex = 13;
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
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(211, 253);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(168, 36);
            this.btnSelectCustomer.TabIndex = 14;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            // 
            // toolInformation
            // 
            this.toolInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolID,
            this.Desc,
            this.Price,
            this.Status});
            this.toolInformation.Location = new System.Drawing.Point(86, 295);
            this.toolInformation.Name = "toolInformation";
            this.toolInformation.Size = new System.Drawing.Size(446, 150);
            this.toolInformation.TabIndex = 15;
            // 
            // ToolID
            // 
            this.ToolID.HeaderText = "Tool_ID";
            this.ToolID.Name = "ToolID";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btnReturnLabel
            // 
            this.btnReturnLabel.Location = new System.Drawing.Point(211, 451);
            this.btnReturnLabel.Name = "btnReturnLabel";
            this.btnReturnLabel.Size = new System.Drawing.Size(168, 36);
            this.btnReturnLabel.TabIndex = 16;
            this.btnReturnLabel.Text = "Return Selected";
            this.btnReturnLabel.UseVisualStyleBackColor = true;
            // 
            // btnFinishReturn
            // 
            this.btnFinishReturn.Location = new System.Drawing.Point(181, 501);
            this.btnFinishReturn.Name = "btnFinishReturn";
            this.btnFinishReturn.Size = new System.Drawing.Size(220, 36);
            this.btnFinishReturn.TabIndex = 21;
            this.btnFinishReturn.Text = "Finish";
            this.btnFinishReturn.UseVisualStyleBackColor = true;
            // 
            // frmReturnRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 549);
            this.Controls.Add(this.btnFinishReturn);
            this.Controls.Add(this.btnReturnLabel);
            this.Controls.Add(this.toolInformation);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.customerInformation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Cust_Box);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReturnRental";
            this.Text = "frmReturnRental";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox Cust_Box;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView customerInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eircode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.DataGridView toolInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnReturnLabel;
        private System.Windows.Forms.Button btnFinishReturn;
    }
}
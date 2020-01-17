namespace ToolSys
{
    partial class frmProcessRental
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
            this.customerLabel = new System.Windows.Forms.Label();
            this.Cust_Box = new System.Windows.Forms.TextBox();
            this.customerInformation = new System.Windows.Forms.DataGridView();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eircode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCustomerSelect = new System.Windows.Forms.Button();
            this.toolLabel = new System.Windows.Forms.Label();
            this.tool_Box = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.toolInfo = new System.Windows.Forms.DataGridView();
            this.ToolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnToolSelect = new System.Windows.Forms.Button();
            this.btnSearchTwo = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmTool = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.customerInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(61, 44);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(113, 13);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "Enter Customer Name:";
            // 
            // Cust_Box
            // 
            this.Cust_Box.Location = new System.Drawing.Point(211, 34);
            this.Cust_Box.Name = "Cust_Box";
            this.Cust_Box.Size = new System.Drawing.Size(179, 20);
            this.Cust_Box.TabIndex = 3;
            this.Cust_Box.TextChanged += new System.EventHandler(this.Cust_Box_TextChanged);
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
            this.customerInformation.Location = new System.Drawing.Point(64, 70);
            this.customerInformation.Name = "customerInformation";
            this.customerInformation.Size = new System.Drawing.Size(543, 150);
            this.customerInformation.TabIndex = 7;
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
            // btnCustomerSelect
            // 
            this.btnCustomerSelect.Location = new System.Drawing.Point(211, 239);
            this.btnCustomerSelect.Name = "btnCustomerSelect";
            this.btnCustomerSelect.Size = new System.Drawing.Size(168, 36);
            this.btnCustomerSelect.TabIndex = 8;
            this.btnCustomerSelect.Text = "Select Customer";
            this.btnCustomerSelect.UseVisualStyleBackColor = true;
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Location = new System.Drawing.Point(61, 294);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(90, 13);
            this.toolLabel.TabIndex = 9;
            this.toolLabel.Text = "Enter Tool Name:";
            // 
            // tool_Box
            // 
            this.tool_Box.Location = new System.Drawing.Point(211, 291);
            this.tool_Box.Name = "tool_Box";
            this.tool_Box.Size = new System.Drawing.Size(179, 20);
            this.tool_Box.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(445, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolInfo
            // 
            this.toolInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolID,
            this.Desc,
            this.Price,
            this.Status});
            this.toolInfo.Location = new System.Drawing.Point(64, 317);
            this.toolInfo.Name = "toolInfo";
            this.toolInfo.Size = new System.Drawing.Size(446, 150);
            this.toolInfo.TabIndex = 12;
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
            // btnToolSelect
            // 
            this.btnToolSelect.Location = new System.Drawing.Point(211, 473);
            this.btnToolSelect.Name = "btnToolSelect";
            this.btnToolSelect.Size = new System.Drawing.Size(168, 36);
            this.btnToolSelect.TabIndex = 13;
            this.btnToolSelect.Text = "Select Tool";
            this.btnToolSelect.UseVisualStyleBackColor = true;
            // 
            // btnSearchTwo
            // 
            this.btnSearchTwo.Location = new System.Drawing.Point(445, 289);
            this.btnSearchTwo.Name = "btnSearchTwo";
            this.btnSearchTwo.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTwo.TabIndex = 14;
            this.btnSearchTwo.Text = "Search";
            this.btnSearchTwo.UseVisualStyleBackColor = true;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(78, 556);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(64, 13);
            this.fromLabel.TabIndex = 15;
            this.fromLabel.Text = "Rental From";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(201, 550);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(167, 20);
            this.dateFrom.TabIndex = 16;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(77, 599);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(55, 13);
            this.toLabel.TabIndex = 17;
            this.toLabel.Text = "Return To";
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(201, 593);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(165, 20);
            this.dateTo.TabIndex = 18;
            // 
            // btnConfirmTool
            // 
            this.btnConfirmTool.Location = new System.Drawing.Point(198, 619);
            this.btnConfirmTool.Name = "btnConfirmTool";
            this.btnConfirmTool.Size = new System.Drawing.Size(168, 36);
            this.btnConfirmTool.TabIndex = 19;
            this.btnConfirmTool.Text = "Confirm Tool";
            this.btnConfirmTool.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(182, 681);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(220, 36);
            this.btnFinish.TabIndex = 20;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 21;
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
            // frmProcessRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 729);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnConfirmTool);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.btnSearchTwo);
            this.Controls.Add(this.btnToolSelect);
            this.Controls.Add(this.toolInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tool_Box);
            this.Controls.Add(this.toolLabel);
            this.Controls.Add(this.btnCustomerSelect);
            this.Controls.Add(this.customerInformation);
            this.Controls.Add(this.Cust_Box);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProcessRental";
            this.Text = "Process Rental";
            this.Load += new System.EventHandler(this.frmProcessRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox Cust_Box;
        private System.Windows.Forms.DataGridView customerInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eircode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.Button btnCustomerSelect;
        private System.Windows.Forms.Label toolLabel;
        private System.Windows.Forms.TextBox tool_Box;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView toolInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnToolSelect;
        private System.Windows.Forms.Button btnSearchTwo;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button btnConfirmTool;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}
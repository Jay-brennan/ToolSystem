namespace ToolSys
{
    partial class frmCustomerProfile
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
            this.rentalHistory = new System.Windows.Forms.DataGridView();
            this.Rent_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.eircodeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.custidlabel = new System.Windows.Forms.Label();
            this.custprofileLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.CustID = new System.Windows.Forms.Label();
            this.eircode = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.telNum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
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
            // rentalHistory
            // 
            this.rentalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rent_ID,
            this.prevHired,
            this.dur});
            this.rentalHistory.Location = new System.Drawing.Point(12, 271);
            this.rentalHistory.Name = "rentalHistory";
            this.rentalHistory.Size = new System.Drawing.Size(344, 150);
            this.rentalHistory.TabIndex = 1;
            // 
            // Rent_ID
            // 
            this.Rent_ID.HeaderText = "Rent ID";
            this.Rent_ID.Name = "Rent_ID";
            // 
            // prevHired
            // 
            this.prevHired.HeaderText = "Tools Hired";
            this.prevHired.Name = "prevHired";
            // 
            // dur
            // 
            this.dur.HeaderText = "Date";
            this.dur.Name = "dur";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(80, 149);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(80, 178);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // eircodeLabel
            // 
            this.eircodeLabel.AutoSize = true;
            this.eircodeLabel.Location = new System.Drawing.Point(95, 203);
            this.eircodeLabel.Name = "eircodeLabel";
            this.eircodeLabel.Size = new System.Drawing.Size(46, 13);
            this.eircodeLabel.TabIndex = 11;
            this.eircodeLabel.Text = "Eircode:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(54, 231);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(87, 13);
            this.contactLabel.TabIndex = 12;
            this.contactLabel.Text = "Contact Number:";
            // 
            // custidlabel
            // 
            this.custidlabel.AutoSize = true;
            this.custidlabel.Location = new System.Drawing.Point(73, 114);
            this.custidlabel.Name = "custidlabel";
            this.custidlabel.Size = new System.Drawing.Size(68, 13);
            this.custidlabel.TabIndex = 14;
            this.custidlabel.Text = "Customer ID:";
            // 
            // custprofileLabel
            // 
            this.custprofileLabel.AutoSize = true;
            this.custprofileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.custprofileLabel.Location = new System.Drawing.Point(127, 35);
            this.custprofileLabel.Name = "custprofileLabel";
            this.custprofileLabel.Size = new System.Drawing.Size(112, 17);
            this.custprofileLabel.TabIndex = 15;
            this.custprofileLabel.Text = "Customer Profile";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.statusLabel.Location = new System.Drawing.Point(174, 70);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(88, 16);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Status: Active";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.balanceLabel.Location = new System.Drawing.Point(45, 70);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(95, 16);
            this.balanceLabel.TabIndex = 17;
            this.balanceLabel.Text = "Balance: €0.00";
            // 
            // CustID
            // 
            this.CustID.AutoSize = true;
            this.CustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.CustID.Location = new System.Drawing.Point(174, 111);
            this.CustID.Name = "CustID";
            this.CustID.Size = new System.Drawing.Size(53, 16);
            this.CustID.TabIndex = 18;
            this.CustID.Text = "AZ1995";
            // 
            // eircode
            // 
            this.eircode.AutoSize = true;
            this.eircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.eircode.Location = new System.Drawing.Point(174, 203);
            this.eircode.Name = "eircode";
            this.eircode.Size = new System.Drawing.Size(71, 16);
            this.eircode.TabIndex = 19;
            this.eircode.Text = "V93 ABCD";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lastName.Location = new System.Drawing.Point(174, 176);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(44, 16);
            this.lastName.TabIndex = 20;
            this.lastName.Text = "Zebra";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.firstName.Location = new System.Drawing.Point(174, 147);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(35, 16);
            this.firstName.TabIndex = 21;
            this.firstName.Text = "Alan";
            // 
            // telNum
            // 
            this.telNum.AutoSize = true;
            this.telNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.telNum.Location = new System.Drawing.Point(174, 231);
            this.telNum.Name = "telNum";
            this.telNum.Size = new System.Drawing.Size(78, 16);
            this.telNum.TabIndex = 22;
            this.telNum.Text = "0871112222";
            // 
            // frmCustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.telNum);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.eircode);
            this.Controls.Add(this.CustID);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.custprofileLabel);
            this.Controls.Add(this.custidlabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.eircodeLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.rentalHistory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustomerProfile";
            this.Text = "frmCustomerProfile";
            this.Load += new System.EventHandler(this.frmCustomerProfile_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView rentalHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rent_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dur;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label eircodeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label custidlabel;
        private System.Windows.Forms.Label custprofileLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label CustID;
        private System.Windows.Forms.Label eircode;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label telNum;
    }
}
namespace ToolSys
{
    partial class frmToolAnalysis
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
            this.toolNameLabel = new System.Windows.Forms.Label();
            this.Cust_Box = new System.Windows.Forms.TextBox();
            this.btnGenerateToolAnalysis = new System.Windows.Forms.Button();
            this.toolInformation = new System.Windows.Forms.DataGridView();
            this.ToolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
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
            // toolNameLabel
            // 
            this.toolNameLabel.AutoSize = true;
            this.toolNameLabel.Location = new System.Drawing.Point(44, 43);
            this.toolNameLabel.Name = "toolNameLabel";
            this.toolNameLabel.Size = new System.Drawing.Size(62, 13);
            this.toolNameLabel.TabIndex = 4;
            this.toolNameLabel.Text = "Tool Name:";
            // 
            // Cust_Box
            // 
            this.Cust_Box.Location = new System.Drawing.Point(142, 43);
            this.Cust_Box.Name = "Cust_Box";
            this.Cust_Box.Size = new System.Drawing.Size(179, 20);
            this.Cust_Box.TabIndex = 5;
            // 
            // btnGenerateToolAnalysis
            // 
            this.btnGenerateToolAnalysis.Location = new System.Drawing.Point(172, 253);
            this.btnGenerateToolAnalysis.Name = "btnGenerateToolAnalysis";
            this.btnGenerateToolAnalysis.Size = new System.Drawing.Size(179, 23);
            this.btnGenerateToolAnalysis.TabIndex = 13;
            this.btnGenerateToolAnalysis.Text = "Generate";
            this.btnGenerateToolAnalysis.UseVisualStyleBackColor = true;
            // 
            // toolInformation
            // 
            this.toolInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolID,
            this.Desc,
            this.Price,
            this.Status});
            this.toolInformation.Location = new System.Drawing.Point(38, 78);
            this.toolInformation.Name = "toolInformation";
            this.toolInformation.Size = new System.Drawing.Size(446, 150);
            this.toolInformation.TabIndex = 16;
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
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(367, 41);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(117, 23);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmToolAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 315);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.toolInformation);
            this.Controls.Add(this.btnGenerateToolAnalysis);
            this.Controls.Add(this.Cust_Box);
            this.Controls.Add(this.toolNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmToolAnalysis";
            this.Text = "frmToolAnalysis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label toolNameLabel;
        private System.Windows.Forms.TextBox Cust_Box;
        private System.Windows.Forms.Button btnGenerateToolAnalysis;
        private System.Windows.Forms.DataGridView toolInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btn_Search;
    }
}
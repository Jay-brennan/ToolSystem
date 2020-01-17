namespace ToolSys
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.openAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.processRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitOption = new System.Windows.Forms.ToolStripMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOptions,
            this.customerOptions,
            this.rentalOptions,
            this.analysisOptions,
            this.exitOption});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolOptions
            // 
            this.toolOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolToolStripMenuItem,
            this.updateToolToolStripMenuItem,
            this.removeToolToolStripMenuItem});
            this.toolOptions.Name = "toolOptions";
            this.toolOptions.Size = new System.Drawing.Size(42, 20);
            this.toolOptions.Text = "Tool";
            // 
            // addToolToolStripMenuItem
            // 
            this.addToolToolStripMenuItem.Name = "addToolToolStripMenuItem";
            this.addToolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolToolStripMenuItem.Text = "Add Tool";
            this.addToolToolStripMenuItem.Click += new System.EventHandler(this.addToolToolStripMenuItem_Click);
            // 
            // updateToolToolStripMenuItem
            // 
            this.updateToolToolStripMenuItem.Name = "updateToolToolStripMenuItem";
            this.updateToolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolToolStripMenuItem.Text = "Update Tool";
            this.updateToolToolStripMenuItem.Click += new System.EventHandler(this.updateToolToolStripMenuItem_Click);
            // 
            // removeToolToolStripMenuItem
            // 
            this.removeToolToolStripMenuItem.Name = "removeToolToolStripMenuItem";
            this.removeToolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolToolStripMenuItem.Text = "Remove Tool";
            this.removeToolToolStripMenuItem.Click += new System.EventHandler(this.removeToolToolStripMenuItem_Click);
            // 
            // customerOptions
            // 
            this.customerOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem,
            this.closeAccountToolStripMenuItem,
            this.customerProfileToolStripMenuItem});
            this.customerOptions.Name = "customerOptions";
            this.customerOptions.Size = new System.Drawing.Size(71, 20);
            this.customerOptions.Text = "Customer";
            // 
            // openAccountToolStripMenuItem
            // 
            this.openAccountToolStripMenuItem.Name = "openAccountToolStripMenuItem";
            this.openAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAccountToolStripMenuItem.Text = "Open Account";
            this.openAccountToolStripMenuItem.Click += new System.EventHandler(this.openAccountToolStripMenuItem_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // closeAccountToolStripMenuItem
            // 
            this.closeAccountToolStripMenuItem.Name = "closeAccountToolStripMenuItem";
            this.closeAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeAccountToolStripMenuItem.Text = "Close Account";
            this.closeAccountToolStripMenuItem.Click += new System.EventHandler(this.closeAccountToolStripMenuItem_Click);
            // 
            // customerProfileToolStripMenuItem
            // 
            this.customerProfileToolStripMenuItem.Name = "customerProfileToolStripMenuItem";
            this.customerProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerProfileToolStripMenuItem.Text = "Customer Profile";
            this.customerProfileToolStripMenuItem.Click += new System.EventHandler(this.customerProfileToolStripMenuItem_Click);
            // 
            // rentalOptions
            // 
            this.rentalOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processRentalToolStripMenuItem,
            this.returnRentalToolStripMenuItem});
            this.rentalOptions.Name = "rentalOptions";
            this.rentalOptions.Size = new System.Drawing.Size(52, 20);
            this.rentalOptions.Text = "Rental";
            // 
            // processRentalToolStripMenuItem
            // 
            this.processRentalToolStripMenuItem.Name = "processRentalToolStripMenuItem";
            this.processRentalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.processRentalToolStripMenuItem.Text = "Process Rental";
            this.processRentalToolStripMenuItem.Click += new System.EventHandler(this.processRentalToolStripMenuItem_Click);
            // 
            // returnRentalToolStripMenuItem
            // 
            this.returnRentalToolStripMenuItem.Name = "returnRentalToolStripMenuItem";
            this.returnRentalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnRentalToolStripMenuItem.Text = "Return Rental";
            this.returnRentalToolStripMenuItem.Click += new System.EventHandler(this.returnRentalToolStripMenuItem_Click);
            // 
            // analysisOptions
            // 
            this.analysisOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueAnalysisToolStripMenuItem,
            this.toolAnalysisToolStripMenuItem});
            this.analysisOptions.Name = "analysisOptions";
            this.analysisOptions.Size = new System.Drawing.Size(62, 20);
            this.analysisOptions.Text = "Analysis";
            // 
            // revenueAnalysisToolStripMenuItem
            // 
            this.revenueAnalysisToolStripMenuItem.Name = "revenueAnalysisToolStripMenuItem";
            this.revenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revenueAnalysisToolStripMenuItem.Text = "Revenue Analysis";
            this.revenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.revenueAnalysisToolStripMenuItem_Click);
            // 
            // toolAnalysisToolStripMenuItem
            // 
            this.toolAnalysisToolStripMenuItem.Name = "toolAnalysisToolStripMenuItem";
            this.toolAnalysisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolAnalysisToolStripMenuItem.Text = "Tool Analysis";
            this.toolAnalysisToolStripMenuItem.Click += new System.EventHandler(this.toolAnalysisToolStripMenuItem_Click);
            // 
            // exitOption
            // 
            this.exitOption.Name = "exitOption";
            this.exitOption.Size = new System.Drawing.Size(37, 20);
            this.exitOption.Text = "Exit";
            this.exitOption.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 27);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(1204, 712);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 726);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolOptions;
        private System.Windows.Forms.ToolStripMenuItem addToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOptions;
        private System.Windows.Forms.ToolStripMenuItem openAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalOptions;
        private System.Windows.Forms.ToolStripMenuItem analysisOptions;
        private System.Windows.Forms.ToolStripMenuItem revenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitOption;
        private System.Windows.Forms.PictureBox Logo;
    }
}


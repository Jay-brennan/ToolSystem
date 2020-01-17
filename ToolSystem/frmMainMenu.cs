using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolSys
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddTool nextForm = new frmAddTool(this);
            nextForm.Show();
        }

        private void updateToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateTool nextForm = new frmUpdateTool(this);
            nextForm.Show();
        }

        private void removeToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteTool nextForm = new frmDeleteTool(this);
            nextForm.Show();
        }

        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateCustomer nextForm = new frmCreateCustomer(this);
            nextForm.Show();
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer nextForm = new frmUpdateCustomer (this);
            nextForm.Show();
        }

        private void closeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveCustomer nextForm = new frmRemoveCustomer (this);
            nextForm.Show();
        }

        private void customerProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerProfile nextForm = new frmCustomerProfile (this);
            nextForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void processRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProcessRental nextForm = new frmProcessRental(this);
            nextForm.Show();
        }

        private void returnRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnRental nextForm = new frmReturnRental(this);
            nextForm.Show();
        }

        private void revenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevenueAnalysis nextForm = new frmRevenueAnalysis(this);
            nextForm.Show();
        }

        private void toolAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmToolAnalysis nextForm = new frmToolAnalysis(this);
            nextForm.Show();
        }
    }
}

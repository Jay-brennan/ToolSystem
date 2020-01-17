using Oracle.ManagedDataAccess.Client;
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
    public partial class frmUpdateTool : Form
    {
        frmMainMenu parent;
        public frmUpdateTool()
        {
            InitializeComponent();
        }

        public frmUpdateTool(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //Validation.
            if (txtDescriptionUp.Text.Equals(""))
            {
                MessageBox.Show("Description cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescriptionUp.Focus();
                return;
            }
            if (txtToolNUp.Text.Equals(""))
            {
                MessageBox.Show("Tool name cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtToolNUp.Focus();
                return;
            }
            if (!Tool.priceVal(nudPrice.Text)){
                nudPrice.Focus();
                return;
            }
            if (!Tool.descriptionVal(txtDescriptionUp.Text))
            {
                txtDescriptionUp.Focus();
                return;
            }
            if (!Tool.toolNameVal(txtToolNUp.Text))
            {
                txtToolNUp.Focus();
                return;
            }







            
                Tool updatedTool = new Tool(Convert.ToInt32(txtToolID.Text), txtToolNUp.Text, txtDescriptionUp.Text,Convert.ToDecimal(nudPrice.Value),'A');
                updatedTool.updateTool();


                MessageBox.Show("Tool updated successfully!");
                 txtToolNUp.Clear();
                txtDescriptionUp.Clear();
                nudPrice.Value = 0;
                 txtSearch.Focus();
            
        }



        private void button1_Click(object sender, EventArgs e)


        {


            DataSet ds = new DataSet();

            retrieveToolGrid.DataSource = Tool.getTools(ds, txtSearch.Text).Tables["stk"];

            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("No item was searched for");
                txtSearch.Focus();
                return;
            }

        }

      

        private void retrieveToolGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtToolID.Text = retrieveToolGrid.Rows[retrieveToolGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtToolNUp.Text = retrieveToolGrid.Rows[retrieveToolGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtDescriptionUp.Text = retrieveToolGrid.Rows[retrieveToolGrid.CurrentCell.RowIndex].Cells[2].Value.ToString();
            nudPrice.Value = Convert.ToDecimal(retrieveToolGrid.Rows[retrieveToolGrid.CurrentCell.RowIndex].Cells[3].Value);
        }

        private void frmUpdateTool_Load(object sender, EventArgs e)
        {

        }
    }

}

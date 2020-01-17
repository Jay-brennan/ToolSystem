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
    public partial class frmAddTool : Form

    {
        frmMainMenu parent;
        public frmAddTool()
        {
            InitializeComponent();
            
        }

        public frmAddTool(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Tool Name must be entered","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtDesc.Text.Equals(""))
            {
                MessageBox.Show("Tool Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }
            if (!Tool.priceVal(nudPrice.Text.ToString()))
            {
                nudPrice.Focus();
                return;
            }
            if (!Tool.toolNameVal(txtName.Text))
            {
                txtName.Focus();
                return;
            }
            if (!Tool.descriptionVal(txtDesc.Text))
            {
                txtDesc.Focus();
                return;
            }




            //save data in DB
            //instantiate tool object
            Tool newTool = new Tool(Convert.ToInt32(txtToolId.Text), txtName.Text, txtDesc.Text, Convert.ToDecimal(nudPrice.Text), 'A');

            newTool.addTool();

            //Display confirmation message
            MessageBox.Show("Tool added successfully!");

            //reset UI

            txtToolId.Text = Tool.incrementToolNum().ToString("00000");
            txtName.Clear();
            txtDesc.Clear();
            nudPrice.Value = 0;
            txtName.Focus();

        }

        private void frmAddTool_Load(object sender, EventArgs e)
        {
            txtToolId.Text = Tool.incrementToolNum().ToString("00000");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }

    




}

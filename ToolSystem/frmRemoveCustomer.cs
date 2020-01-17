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
    public partial class frmRemoveCustomer : Form
    {

        frmMainMenu parent;
        public frmRemoveCustomer()
        {
            InitializeComponent();
        }

        public frmRemoveCustomer(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void frmRemoveCustomer_Load(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (search_Box.Text == "")
            {
                MessageBox.Show("Field cannot be empty");
            }
        }

        private void search_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

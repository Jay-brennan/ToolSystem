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
    public partial class frmReturnRental : Form
    {
        frmMainMenu parent;

        public frmReturnRental()
        {
            InitializeComponent();
        }

        public frmReturnRental(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Cust_Box.Text == "")
            {
                MessageBox.Show("No customer entered");
            }
        }
    }
}

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

  
    public partial class frmProcessRental : Form
    {

        frmMainMenu parent;
        public frmProcessRental()
        {
            InitializeComponent();
        }

        public frmProcessRental(frmMainMenu Parent)
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

        private void Cust_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Cust_Box.Text == "")
            {
                MessageBox.Show("No customer entered");
            }
        }

        private void frmProcessRental_Load(object sender, EventArgs e)
        {

        }
    }
}

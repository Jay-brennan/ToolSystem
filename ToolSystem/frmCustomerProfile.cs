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
    
    public partial class frmCustomerProfile : Form
    {

        frmMainMenu parent;
        public frmCustomerProfile()
        {
            InitializeComponent();
        }

        public frmCustomerProfile(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmCustomerProfile_Load(object sender, EventArgs e)
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
    }
}

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
    public partial class frmCreateCustomer : Form
    {
        frmMainMenu parent;
        public frmCreateCustomer()
        {
            InitializeComponent();
        }


        public frmCreateCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmCreateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fName.Text==""||lName.Text==""||eircode.Text==""||number.Text=="")
            {
                MessageBox.Show("You are missing a field");
            }
            else
            {
                MessageBox.Show("Customer created");
                fName.Clear();
                lName.Clear();
                eircode.Clear();
                number.Clear();
                fName.Focus();
            }
        }
    }
}

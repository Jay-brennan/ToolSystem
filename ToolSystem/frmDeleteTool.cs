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
    public partial class frmDeleteTool : Form
    {

        frmMainMenu parent;
        public frmDeleteTool()
        {
            InitializeComponent();
        }


        public frmDeleteTool(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Search_Box.Text == "")
            {
                MessageBox.Show("No tool searched for!");
            }
        }
    }
}

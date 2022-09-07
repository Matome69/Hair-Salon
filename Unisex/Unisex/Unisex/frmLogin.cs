using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unisex
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            this.Hide();
            signUp.ShowDialog();
            
        }
    }
}

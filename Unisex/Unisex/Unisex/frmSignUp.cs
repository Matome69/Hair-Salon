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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
                txtConPass.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                txtPass.UseSystemPasswordChar = true;
                txtConPass.UseSystemPasswordChar = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

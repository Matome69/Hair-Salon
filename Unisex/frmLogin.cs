using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Unisex
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        String conString;


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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtPassword.AutoSize = false;
            this.txtPassword.Size = new System.Drawing.Size(225, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtUsername.Text=="admin101" && txtPassword.Text=="CMPG223")
            {
                frmDash dash = new frmDash();
                
                dash.Show();
                this.Hide();
            }
            else
            {
                try
                { 
                    AppDomain.CurrentDomain.SetData("DataDirectory", "C:\\Users\\32023960\\Desktop\\Unisex\\Unisex");
                    conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Unisex.mdf;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conString);
                
                    String query="SELECT * FROM Users WHERE Username ='"+txtUsername.Text.Trim()+ "' AND Password ='" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dtlb = new DataTable();
                    adapter.Fill(dtlb);
                    if(dtlb.Rows.Count==1)
                    {
                        frmUser UserDash = new frmUser();
                        UserDash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                  
                }
                catch(SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}

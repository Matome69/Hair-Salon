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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        //String phone = txtPhone.Text;
        //public int num = int.Parse(txtPhone.Text);
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\32023960\Desktop\Unisex\Unisex\Unisex\Unisex.mdf;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="" && txtSurname.Text!="" && txtEmail.Text != "" && txtPhone.Text !="")
            {
                try
                {
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    string insert_query = "INSERT INTO Client VALUES('" + txtName.Text + "','" + txtSurname.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "')";

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(insert_query, con);
                    adapter.InsertCommand = cmd;
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Close();

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                //if (num > 10 || num<10)
                //{
                //    MessageBox.Show("Phone number should be 10 digits");
                //    txtPhone.Focus();
                //}
                //else
                //{
                    
                    
                //}
            }
            else
            {
                MessageBox.Show("Text fields cannot be empty");
            }


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

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            this.txtPass.AutoSize = false;
            this.txtPass.Size = new System.Drawing.Size(225, 25);

            this.txtConPass.AutoSize = false;
            this.txtConPass.Size = new System.Drawing.Size(225, 25);

            txtPass.UseSystemPasswordChar = true;
            txtConPass.UseSystemPasswordChar = true;
        }
    }
}

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


        public string conString;

        private void button1_Click(object sender, EventArgs e)
        {
            //if()
            
            


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
            this.txtPass.Size = new System.Drawing.Size(225, 20);

            this.txtConPass.AutoSize = false;
            this.txtConPass.Size = new System.Drawing.Size(225, 20);

            txtPass.UseSystemPasswordChar = true;
            txtConPass.UseSystemPasswordChar = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            if(tabControl1.SelectedTab==tpClient)
            {
                txtName.Text = "";
                txtSurname.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtUsername.Text = "";
                txtPass.Text = "";
                txtConPass.Text = "";
                txtName.Focus();
            }
            else if (tabControl1.SelectedTab == tpStaff)
            {
                txtStaffName.Text = "";
                txtStaffSur.Text = "";
                txtStaffPhone.Text = "";
                txtStaffUsername.Text = "";
                txtStaffPass.Text = "";
                txtStaffConPass.Text = "";
                rbHair.Checked = false;
                rbNail.Checked = false;
                txtStaffName.Focus();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtEmail.Text != "" && txtPhone.Text != "")
            {
                int length = txtPhone.TextLength;

                if (length == 10)
                {
                    if (txtUsername.Text != "" && txtPass.Text != "" && txtConPass.Text != "")
                    {
                        if (txtPass.Text == txtConPass.Text)
                        {
                            try
                            {
                                AppDomain.CurrentDomain.SetData("DataDirectory", "\\143.160.81.13\\CTX_Redirected_Data$\\32023960\\Documents\\GitHub\\Unisex\\Unisex");
                                conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Unisex.mdf;Integrated Security=True";
                                SqlConnection con = new SqlConnection(conString);
                                SqlDataAdapter adapter = new SqlDataAdapter();
                                SqlCommand cmd;

                                String insertUser_query, insert_query;

                                if (tabControl1.SelectedTab==tpClient)
                                {
                                    con.Open();

                                    insert_query = "INSERT INTO Client VALUES('" + txtName.Text + "','" + txtSurname.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "')";
                                    cmd = new SqlCommand(insert_query, con);
                                    adapter.InsertCommand = cmd;
                                    adapter.InsertCommand.ExecuteNonQuery();

                                    
                                }
                                else if (tabControl1.SelectedTab == tpStaff)
                                {
                                    String occupation="Admin";
                                    if(rbHair.Checked)
                                    {
                                        occupation = "HairDresser";
                                    }
                                    else if (rbNail.Checked)
                                    {
                                        occupation = "Nail Technicion";
                                    }

                                    con.Open();

                                    insert_query = "INSERT INTO Staff VALUES('" + txtStaffName.Text + "','" + txtStaffSur.Text + "', '" + txtStaffPhone.Text + "', '" + occupation + "')";
                                    cmd = new SqlCommand(insert_query, con);
                                    adapter.InsertCommand = cmd;
                                    adapter.InsertCommand.ExecuteNonQuery();

                                }

                                insertUser_query = "INSERT INTO Users VALUES('" + txtUsername.Text + "', '" + txtPass.Text + "')";
                                cmd = new SqlCommand(insertUser_query, con);
                                adapter.InsertCommand = cmd;
                                adapter.InsertCommand.ExecuteNonQuery();

                                con.Close();

                                MessageBox.Show("Account Created " + txtUsername.Text);
                                frmLogin login = new frmLogin();
                                login.Show();
                                this.Close();

                            }
                            catch (SqlException error)
                            {
                                MessageBox.Show(error.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password do not match!!!!!");
                            txtConPass.Text = "";
                            txtPass.Text = "";
                            txtPass.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Text fields cannot be empty");
                    }


                }
                else
                {
                    MessageBox.Show("Phone number should be 10 digits");
                    txtPhone.Focus();
                }
            }
            else
            {
                MessageBox.Show("Text fields cannot be empty");
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                txtUsername.Text = txtEmail.Text;
                txtUsername.Enabled = false;
                txtUsername.ReadOnly = true;
            }
            else
            {
                txtUsername.Enabled = true;
                txtUsername.ReadOnly = false;
            }
        }
    }
}

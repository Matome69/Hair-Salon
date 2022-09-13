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
    public partial class frmDash : Form
    {
        public frmDash()
        {
            InitializeComponent();
        }
        public string conString;
        public DataSet ds;
        public SqlDataAdapter adapter;
        public SqlConnection cnn;

        private void frmDash_Load(object sender, EventArgs e)
        {
            try
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", "C:\\Users\\32023960\\Desktop\\Unisex\\Unisex");
                conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Unisex.mdf;Integrated Security=True";
                cnn = new SqlConnection(conString);
                cnn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                SqlCommand cmd;


                String sql = @"SELECT Client_ID,Name,Surname,Email,Phone_Number FROM Client";
                cmd = new SqlCommand(sql, cnn);

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Client");

                dgvClients.DataSource = ds;
                dgvClients.DataMember = "Client";

                cnn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void tbHair_Click(object sender, EventArgs e)
        {

        }
    }
}

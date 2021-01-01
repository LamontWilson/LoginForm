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

namespace LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=KAGUYA\SQLEXPRESS;Initial Catalog=userLogin;Integrated Security=True");
            string query = "select * from logins where username='" + userNametxtbox.Text.Trim() + "'and password='"+passwordtxtbox.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                frmLoggedIn objfrmLoggedIn = new frmLoggedIn();
                this.Hide();
                objfrmLoggedIn.Show();
            }
            else
            {
                MessageBox.Show("Please check your credentials and try again.");
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

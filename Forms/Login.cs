using HMS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Showpas.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (chk_Showpas.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            {
                string Query = "SELECT * from tbl_Loginn Where Name='" + txtName.Text + "' AND Password = '" + txtPassword.Text + "'";
                SqlConnection con = new SqlConnection(SqlData.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    this.Hide();
                    Main main= new Main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password");
                    txtName.Clear();
                    txtPassword.Clear();
                    txtName.Focus();
                }
            }
        }
    }
}

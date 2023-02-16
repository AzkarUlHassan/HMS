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
    public partial class User_Setting : Form
    {
        public User_Setting()
        {
            InitializeComponent();
        }
        SqlData SqlData=new SqlData();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlData.OpenCon();
            SqlData.NonQueryExecuter("INSERT INTO tbl_Loginn VALUES('"+txt_IDr.Text+"','"+txt_UserNamer.Text+"','"+txt_Passwordr.Text+"')");
            SqlData.CloseCon();
            MessageBox.Show("User Registered Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            /////////////////////////////////////////////////////////////////////////////////

            txt_IDr.Clear();
            txt_UserNamer.Clear();
            txt_Passwordr.Clear();
            txt_IDr.Focus();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to delete this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "DELETE From tbl_Loginn Where ID='" + txt_ID.Text + "'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("User Deleted Successfully");
                Cleaning.clearAll(this);
                txt_ID.Clear();
                txt_UserNamer.Clear();
                txt_Passwordr.Clear();
                txt_ID.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
            txt_UserNamer.Clear();
            txt_Passwordr.Clear();
            txt_ID.Focus();
        }

        private void bn_Clear_Click(object sender, EventArgs e)
        {
            txt_IDr.Clear();
            txt_UserNamer.Clear();
            txt_Passwordr.Clear();
            txt_IDr.Focus(); 
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to Update this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "Update tbl_Loginn Set ID='" +cmb_ID.Text+ "',Name='"+txt_Cname.Text+"',Password='"+txt_Cpswrd.Text+"'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("User Updated Successfully");
            }
        }

        private void User_Setting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet14.tbl_Loginn' table. You can move, or remove it, as needed.
            this.tbl_LoginnTableAdapter.Fill(this.hMSDataSet14.tbl_Loginn);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Loginn Where ID='" +cmb_ID.Text+ "'";
            SqlConnection con = new SqlConnection(SqlData.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_Cname.Text = reader["Name"].ToString();

            }
        }
    }
}

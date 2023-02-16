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
    public partial class Edit_Staff : Form
    {
        public Edit_Staff()
        {
            InitializeComponent();
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to Update this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "Update tbl_Staff Set Name='" + cmb_Name.Text + "',FatherName='" + cmb_FatherName.Text + "',CNIC='" + txt_CNIC.Text + "',DateOfBirth='" + txt_DOB.Text + "',BloodGroup='" + txt_BloodGroup.Text + "',Mobile='" + txt_Mobie.Text + "',Adress='"+txt_Adress.Text+ "',JoiningDate='"+txt_JoiningDate.Text+"'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("Record Updated Successfully");
                Cleaning.clearAll(this);
                cmb_Name.Focus();
            }
        }

        private void cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Staff Where Name='" + cmb_Name.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmb_Name.Text= reader["Name"].ToString();
                cmb_FatherName.Text = reader["FatherName"].ToString();
                txt_CNIC.Text = reader["CNIC"].ToString();
                txt_DOB.Text = reader["DateOfBirth"].ToString();
                txt_BloodGroup.Text = reader["BloodGroup"].ToString();
                txt_Mobie.Text = reader["Mobile"].ToString();
                txt_Adress.Text = reader["Adress"].ToString();
                txt_JoiningDate.Text = reader["JoiningDate"].ToString();

            }
        }

        private void txt_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to delete this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "DELETE From tbl_Staff Where Name='" + cmb_Name.Text + "'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("Record Deleted Successfully");
                Cleaning.clearAll(this);
                
                cmb_Name.Focus();

            }
        }

        private void Edit_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet8.tbl_Staff' table. You can move, or remove it, as needed.
            this.tbl_StaffTableAdapter.Fill(this.hMSDataSet8.tbl_Staff);

        }
    }
}

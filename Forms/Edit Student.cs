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
    public partial class Edit_Student : Form
    {
        public Edit_Student()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to Update this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "Update tbl_Student Set Name='" + cmb_Name.Text + "',FatherName='" + cmb_FatherName.Text + "',CNIC='" + txt_CNIC.Text + "',DateOfBirth='" + txt_DOB.Text + "',BloodGroup='" + Txt_BloodGroup.Text + "',Adress='" + txt_Adress.Text + "',MobileNumber='" + txt_Mobile.Text + "',Institute='" + txt_Institute.Text + "',Class='" + txt_Class.Text + "',GuardianName='" + txt_GuardianName.Text + "',GuardianNumber='" + txtGuardianNumber.Text + "',JoiningDate='"+txt_RegDate.Text+"'";
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
            string Query = "SELECT * FROM tbl_Student Where Name='" + cmb_Name.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmb_Name.Text = reader["Name"].ToString();
                cmb_FatherName.Text = reader["FatherName"].ToString();
                txt_CNIC.Text = reader["CNIC"].ToString();
                txt_DOB.Text = reader["DateOfBirth"].ToString();
                Txt_BloodGroup.Text = reader["BloodGroup"].ToString();
                txt_Adress.Text = reader["Mobile"].ToString();
                txt_Mobile.Text = reader["Adress"].ToString();
                txt_Institute.Text = reader["JoiningDate"].ToString();
                txt_Class.Text = reader["JoiningDate"].ToString();
                txt_GuardianName.Text = reader["JoiningDate"].ToString();
                txtGuardianNumber.Text = reader["JoiningDate"].ToString();
                txt_RegDate.Text = reader["JoiningDate"].ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to delete this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "DELETE From tbl_Student Where Name='" + cmb_Name.Text + "'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("Record Deleted Successfully");
                Cleaning.clearAll(this);

                cmb_Name.Focus();

            }
        }
    }
}

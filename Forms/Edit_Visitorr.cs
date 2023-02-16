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
    public partial class Edit_Visitorr : Form
    {
        public Edit_Visitorr()
        {
            InitializeComponent();
        }

        private void cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Visitor Where VisitorName='" + cmb_Name.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmb_Name.Text = reader["VisitorName"].ToString();
                cmb_CNIC.Text = reader["CNIC"].ToString();
                cmb_VisitTime.Text = reader["VisitingTime"].ToString();
                cmb_Adress.Text = reader["Adress"].ToString();
                Cmb_WhomVisiting.Text = reader["NameWhomVisiting"].ToString();
                cmb_Relation.Text = reader["VisitorRelation"].ToString();

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to Update this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "Update tbl_Visitor Set VisitorName='" + cmb_Name.Text + "',CNIC='" + cmb_CNIC.Text + "',VisitingTime='" + cmb_VisitTime.Text + "',Adress='" + cmb_Adress.Text + "',NameWhomVisiting='" + Cmb_WhomVisiting.Text + "',VisitorRelation='" + cmb_Relation.Text + "'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("Record Updated Successfully");
                Cleaning.clearAll(this);
                cmb_Name.Focus();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to delete this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "DELETE From tbl_Visitor Where VisitorName='" + cmb_Name.Text + "'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("Record Deleted Successfully");
                Cleaning.clearAll(this);

                cmb_Name.Focus();

            }
        }

        private void Edit_Visitorr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet13.tbl_Visitor' table. You can move, or remove it, as needed.
            this.tbl_VisitorTableAdapter1.Fill(this.hMSDataSet13.tbl_Visitor);

        }
    }
}

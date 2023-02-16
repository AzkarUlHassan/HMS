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
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet4.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter1.Fill(this.hMSDataSet4.tbl_Student);
            // TODO: This line of code loads data into the 'hMSDataSet2.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter.Fill(this.hMSDataSet2.tbl_Student);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cmb.Text == "Name")
            {
                SearchWithName();
            }
            else if (cmb.Text == "CNIC")
            {
                SearchWithCNIC();
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.Text=="Name")
            {
                txt_CNIC.Enabled = false;
                txt_Name.Enabled = true;
            }
            else if (cmb.Text=="CNIC")
            {
                txt_CNIC.Enabled = true;
                txt_Name.Enabled = false;
            }
        }
        private void SearchWithName()
        {
            string Query = "SELECT * FROM tbl_Student Where Name LIKE'%" + txt_Name.Text+ "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, SqlData.constring);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DG_Student.DataSource = ds.Tables[0];
        }
        private void SearchWithCNIC()
        {
            string Query = "SELECT * FROM tbl_Student Where CNIC LIKE'%" + txt_CNIC.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query,SqlData.constring);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DG_Student.DataSource = ds.Tables[0];
        }

    }
}

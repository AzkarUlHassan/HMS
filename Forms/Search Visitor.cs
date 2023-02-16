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
    public partial class Search_Visitor : Form
    {
        public Search_Visitor()
        {
            InitializeComponent();
        }

        private void Search_Visitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet3.tbl_Visitor' table. You can move, or remove it, as needed.
            this.tbl_VisitorTableAdapter.Fill(this.hMSDataSet3.tbl_Visitor);

        }

        private void cmb_Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Choice.Text == "Name")
            {
                txt_CNIC.Enabled = false;
                txt_Name.Enabled = true;
            }
            else if (cmb_Choice.Text == "CNIC")
            {
                txt_CNIC.Enabled = true;
                txt_Name.Enabled = false;
            }
        }
        private void SearchWithName()
        {
            string Query = "SELECT * FROM tbl_Visitor Where VisitorName LIKE'%" + txt_Name.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, SqlData.constring);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DGview.DataSource = ds.Tables[0];
        }
        private void SearchWithCNIC()
        {
            string Query = "SELECT * FROM tbl_Visitor Where CNIC LIKE'%" + txt_CNIC.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, SqlData.constring);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DGview.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cmb_Choice.Text == "Name")
            {
                SearchWithName();
            }
            else if (cmb_Choice.Text == "CNIC")
            {
                SearchWithCNIC();
            }
        }
    }
}

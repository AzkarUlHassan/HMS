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
    public partial class Search_Room : Form
    {
        public Search_Room()
        {
            InitializeComponent();
        }

        private void Search_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter.Fill(this.hMSDataSet.tbl_Room);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Room Where RoomNumber ='" + txt_number.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, SqlData.constring);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            SRview.DataSource = ds.Tables[0];
        }
    }
}

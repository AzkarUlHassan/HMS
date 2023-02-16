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
    public partial class Edit_Room : Form
    {
        public Edit_Room()
        {
            InitializeComponent();
        }

        private void Edit_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet7.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter1.Fill(this.hMSDataSet7.tbl_Room);
            // TODO: This line of code loads data into the 'hMSDataSet5.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter.Fill(this.hMSDataSet5.tbl_Room);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to delete this Record", "Alert",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "DELETE From tbl_Room Where RoomNumber='" + cmb_Number.Text + "'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("Room Deleted Successfully");
                Cleaning.clearAll(this);
                cmb_Number.Items.Clear();
                cmb_Type.Items.Clear();
                txtwashrom.Items.Clear();
                cmb_Number.Focus();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to Update this Record", "Alert", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string Query = "Update tbl_Room Set RoomNumber='" + cmb_Number.Text + "',Floor='"+txt_Floor.Text+ "',Beds='"+cmb_Type.Text+ "',AttachWashroom='"+txtwashrom.Text+ "',Seats='"+txt_Seats.Text+ "',SeatRient='"+txt_Rent.Text+"'";
                SqlData sql = new SqlData();
                sql.OpenCon();
                sql.NonQueryExecuter(Query);
                sql.CloseCon();
                MessageBox.Show("Room Updated Successfully");
                Cleaning.clearAll(this);
                cmb_Number.Focus();
            }
        }

        private void cmb_Number_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Room Where RoomNumber='" + cmb_Number.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmb_Number.Text = reader["RoomNumber"].ToString();
                txt_Floor.Text = reader["Floor"].ToString();
                cmb_Type.Text = reader["Beds"].ToString();
                txtwashrom.Text = reader["AttachWashroom"].ToString();
                txt_Seats.Text = reader["Seats"].ToString();
                txt_Rent.Text = reader["SeatRient"].ToString();

            }
        }
    }
}

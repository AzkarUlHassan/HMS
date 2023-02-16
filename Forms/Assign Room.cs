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
    public partial class Assign_Room : Form
    {
        public Assign_Room()
        {
            InitializeComponent();
        }

        private void txt_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Student Where Name='" + txt_Name.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmb_RoomNumber.Text = reader["RoomNumber"].ToString();

            }
        }

        private void Assign_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet12.tbl_Student' table. You can move, or remove it, as needed.
            this.tbl_StudentTableAdapter.Fill(this.hMSDataSet12.tbl_Student);
            // TODO: This line of code loads data into the 'hMSDataSet11.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter1.Fill(this.hMSDataSet11.tbl_Room);
            // TODO: This line of code loads data into the 'hMSDataSet10.tbl_Room' table. You can move, or remove it, as needed.
            this.tbl_RoomTableAdapter.Fill(this.hMSDataSet10.tbl_Room);

        }

        private void cmb_RoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Room Where RoomNumber='" + cmb_RoomNumber.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_AvailableSeats.Text = reader["Seats"].ToString();

            }
        }

        private void cmb_CNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM tbl_Student Where CNIC='" + cmb_CNIC.Text + "'";
            SqlConnection con = new SqlConnection(SqlData.constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txt_Name.Text = reader["Name"].ToString();

            }
        }
        SqlData SqlData= new SqlData();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int NumberOfSeats ;
            String Query=("INSERT INTO tbl_AssignRoom VALUES('"+cmb_CNIC.Text+"','"+txt_Name.Text+"','"+cmb_RoomNumber.Text+"','"+txt_AvailableSeats.Text+"')");
            SqlData.OpenCon();
            SqlData.NonQueryExecuter(Query);
            NumberOfSeats = Convert.ToInt32(txt_AvailableSeats.Text);
            NumberOfSeats = NumberOfSeats - 1;
            SqlData.NonQueryExecuter("UPDATE tbl_Room SET Seats='" + NumberOfSeats + "'Where RoomNumber='" + cmb_RoomNumber.Text + "'");
            SqlData.CloseCon();
            MessageBox.Show("Room Assigned Added Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
    }
}

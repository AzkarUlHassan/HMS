using HMS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
        SqlData SqlData= new SqlData();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlData.OpenCon();
            SqlData.NonQueryExecuter("INSERT INTO tbl_Room VALUES('"+txt_Number.Text+"','"+txt_floor.Text+"','"+txt_Type.Text+"','"+txt_washroom.Text+"','"+txt_Seats.Text+"','"+txt_rient.Text+"')");
            SqlData.CloseCon();
            MessageBox.Show("Room Added Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            /////////////////////////////////////////////////////////////////////////////////

            Cleaning.clearAll(this);
            txt_Number.Focus();
        }

        private void bn_Clear_Click(object sender, EventArgs e)
        {
            Cleaning.clearAll(this);
            txt_Number.Focus();
        }
    }
}

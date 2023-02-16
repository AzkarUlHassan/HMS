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
    public partial class Register_Staff : Form
    {
        public Register_Staff()
        {
            InitializeComponent();
        }
        SqlData SqlData = new SqlData();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlData.OpenCon();
            SqlData.NonQueryExecuter("INSERT INTO tbl_Staff VALUES('"+txt_Name.Text+"','"+txt_FtaherName.Text+"','"+txt_CNIC.Text+"','"+txt_DOB.Text+"','"+txt_BloodGroup.Text+"','"+txt_Mobile.Text+"','"+txt_Adress.Text+"','"+txt_JoiningDate+"' )");
            SqlData.CloseCon();
            MessageBox.Show("Visitor Added Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            /////////////////////////////////////////////////////////////////////////////////
            
            txt_Name.Clear();
            txt_FtaherName.Clear();
            txt_BloodGroup.Clear();
            txt_CNIC.Clear();
            txt_Mobile.Clear();
            txt_Adress.Clear();
            txt_Name.Focus();


        }

        private void bn_Clear_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_FtaherName.Clear();
            txt_BloodGroup.Clear();
            txt_CNIC.Clear();
            txt_Mobile.Clear();
            txt_Adress.Clear();
            txt_Name.Focus();
        }
    }
}

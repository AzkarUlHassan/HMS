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
    public partial class Register_Student : Form
    {
        public Register_Student()
        {
            InitializeComponent();
        }
        SqlData SqlData= new SqlData();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlData.OpenCon();
            SqlData.NonQueryExecuter("INSERT INTO tbl_Student VALUES('" + txt_Name.Text + "','" + txt_FatherName.Text + "','" + txt_CNIC.Text + "','" + txt_DOB.Text + "','" + txt_BloodGroup.Text + "','" + txt_Adress.Text + "','" + txt_Mobile.Text + "','" + txt_Institute.Text + "','" + txt_Cass.Text + "','" + txt_GuardianName.Text + "','" + txt_GuardianNmber.Text + "','" + txt_RegistrationDate.Text + "')");
            SqlData.CloseCon();
            MessageBox.Show("Student Registred Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            ////////////////////////////////////////////////////////////////
            
            txt_Name.Clear();
            txt_FatherName.Clear();
            txt_CNIC.Clear();
            txt_Adress.Clear();
            txt_Mobile.Clear();
            txt_Institute.Clear();
            txt_Cass.Clear();
            txt_GuardianNmber.Clear();
            txt_GuardianNmber.Clear();
            txt_GuardianName.Clear();
            txt_BloodGroup.Clear();
            txt_Name.Focus();

        }

        private void bn_Clear_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_FatherName.Clear();
            txt_CNIC.Clear();
            txt_Adress.Clear();
            txt_Mobile.Clear();
            txt_Institute.Clear();
            txt_Cass.Clear();
            txt_GuardianNmber.Clear();
            txt_GuardianNmber.Clear();
            txt_GuardianName.Clear();
            txt_BloodGroup.Clear();
            txt_Name.Focus();
        }
    }
}

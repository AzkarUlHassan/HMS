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
    public partial class Visitor_Entry : Form
    {
        public Visitor_Entry()
        {
            InitializeComponent();
        }
        SqlData SqlData= new SqlData();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlData.OpenCon();
            SqlData.NonQueryExecuter("INSERT INTO tbl_Visitor VALUES('"+txt_Name.Text+"','"+txt_CNIC.Text+"','"+txt_VisitTime.Text+"','"+txt_Adress.Text+"','"+txt_Name_Visiting.Text+"','"+txt_Relation.Text+"')");
            SqlData.CloseCon();
            MessageBox.Show("Visitor Added Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            /////////////////////////////////////////////////////////////////////////////////


            Cleaning.clearAll(this);
            txt_Name.Focus();
        }

        private void bn_Clear_Click(object sender, EventArgs e)
        {

            Cleaning.clearAll(this);
            txt_Name.Focus();

        }
    }
}

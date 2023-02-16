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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }



        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Student student = new Register_Student();
            student.MdiParent= this;
            student.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStaff staff= new SearchStaff();
            staff.MdiParent= this;
            staff.Show();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Staff editStaff= new Edit_Staff();
            editStaff.MdiParent= this;
            editStaff.Show();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Staff staff= new Register_Staff();
            staff.MdiParent= this;
            staff.Show();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visitor_Entry visitor = new Visitor_Entry();
            visitor.MdiParent= this;
            visitor.Show();
        }

        private void searchVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Visitor visitor = new Search_Visitor();  
            visitor.MdiParent= this;
            visitor.Show();
        }

        private void editVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Visitorr visitor = new Edit_Visitorr();
            visitor.MdiParent= this;
            visitor.Show();
        }

        private void roomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Room room= new Room();
            room.MdiParent= this;
            room.Show();
        }

        private void assignRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assign_Room assign= new Assign_Room();
            assign.MdiParent= this;
            assign.Show();
        }

        private void searchRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Room room= new Edit_Room();
            room.MdiParent= this;
            room.Show();
        }

        private void registerNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Setting user= new User_Setting();
            user.MdiParent= this;
            user.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Setting user = new User_Setting();
            user.MdiParent = this;
            user.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Register_Student student = new Register_Student();
            student.MdiParent = this;
            student.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Register_Staff staff = new Register_Staff();
            staff.MdiParent = this;
            staff.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Visitor_Entry visitor = new Visitor_Entry();
            visitor.MdiParent = this;
            visitor.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Assign_Room assign = new Assign_Room();
            assign.MdiParent = this;
            assign.Show();
        }

        private void searchStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStaff staff = new SearchStaff();
            staff.MdiParent = this;
            staff.Show();
        }

        private void editStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Staff staff = new Edit_Staff();
            staff.MdiParent = this;
            staff.Show();
        }

        private void editRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Room room = new Edit_Room();
            room.MdiParent = this;
            room.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us about = new About_Us();
            about.MdiParent = this;
            about.Show();
        }

        private void aboutSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us about = new About_Us();
            about.MdiParent = this;
            about.Show();
        }
    }
}

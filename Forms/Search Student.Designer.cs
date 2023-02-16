namespace HMS.Forms
{
    partial class Search_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_Student = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_CNIC = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.hMSDataSet2 = new HMS.HMSDataSet2();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StudentTableAdapter = new HMS.HMSDataSet2TableAdapters.tbl_StudentTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instituteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datteOfRegistrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hMSDataSet4 = new HMS.HMSDataSet4();
            this.tblStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StudentTableAdapter1 = new HMS.HMSDataSet4TableAdapters.tbl_StudentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 131);
            this.panel1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(436, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Student";
            // 
            // DG_Student
            // 
            this.DG_Student.AutoGenerateColumns = false;
            this.DG_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.cNICDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.instituteDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.guardianNameDataGridViewTextBoxColumn,
            this.guardianNumberDataGridViewTextBoxColumn,
            this.datteOfRegistrationDataGridViewTextBoxColumn});
            this.DG_Student.DataSource = this.tblStudentBindingSource1;
            this.DG_Student.Location = new System.Drawing.Point(0, 231);
            this.DG_Student.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DG_Student.Name = "DG_Student";
            this.DG_Student.RowHeadersWidth = 62;
            this.DG_Student.Size = new System.Drawing.Size(1329, 442);
            this.DG_Student.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 666);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1327, 65);
            this.panel2.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 79;
            this.label2.Text = "Name:";
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Name",
            "CNIC"});
            this.cmb.Location = new System.Drawing.Point(165, 165);
            this.cmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(145, 28);
            this.cmb.TabIndex = 82;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 81;
            this.label3.Text = "Search With:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(708, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 83;
            this.label4.Text = "CNIC:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(438, 166);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(230, 26);
            this.txt_Name.TabIndex = 85;
            // 
            // txt_CNIC
            // 
            this.txt_CNIC.Location = new System.Drawing.Point(789, 168);
            this.txt_CNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CNIC.Name = "txt_CNIC";
            this.txt_CNIC.Size = new System.Drawing.Size(230, 26);
            this.txt_CNIC.TabIndex = 86;
            // 
            // btn_Search
            // 
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(1053, 142);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(162, 72);
            this.btn_Search.TabIndex = 106;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button6_Click);
            // 
            // hMSDataSet2
            // 
            this.hMSDataSet2.DataSetName = "HMSDataSet2";
            this.hMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tbl_Student";
            this.tblStudentBindingSource.DataSource = this.hMSDataSet2;
            // 
            // tbl_StudentTableAdapter
            // 
            this.tbl_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cNICDataGridViewTextBoxColumn
            // 
            this.cNICDataGridViewTextBoxColumn.DataPropertyName = "CNIC";
            this.cNICDataGridViewTextBoxColumn.HeaderText = "CNIC";
            this.cNICDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cNICDataGridViewTextBoxColumn.Name = "cNICDataGridViewTextBoxColumn";
            this.cNICDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 150;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 150;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // instituteDataGridViewTextBoxColumn
            // 
            this.instituteDataGridViewTextBoxColumn.DataPropertyName = "Institute";
            this.instituteDataGridViewTextBoxColumn.HeaderText = "Institute";
            this.instituteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.instituteDataGridViewTextBoxColumn.Name = "instituteDataGridViewTextBoxColumn";
            this.instituteDataGridViewTextBoxColumn.Width = 150;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 150;
            // 
            // guardianNameDataGridViewTextBoxColumn
            // 
            this.guardianNameDataGridViewTextBoxColumn.DataPropertyName = "GuardianName";
            this.guardianNameDataGridViewTextBoxColumn.HeaderText = "GuardianName";
            this.guardianNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.guardianNameDataGridViewTextBoxColumn.Name = "guardianNameDataGridViewTextBoxColumn";
            this.guardianNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // guardianNumberDataGridViewTextBoxColumn
            // 
            this.guardianNumberDataGridViewTextBoxColumn.DataPropertyName = "GuardianNumber";
            this.guardianNumberDataGridViewTextBoxColumn.HeaderText = "GuardianNumber";
            this.guardianNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.guardianNumberDataGridViewTextBoxColumn.Name = "guardianNumberDataGridViewTextBoxColumn";
            this.guardianNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // datteOfRegistrationDataGridViewTextBoxColumn
            // 
            this.datteOfRegistrationDataGridViewTextBoxColumn.DataPropertyName = "DatteOfRegistration";
            this.datteOfRegistrationDataGridViewTextBoxColumn.HeaderText = "DatteOfRegistration";
            this.datteOfRegistrationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datteOfRegistrationDataGridViewTextBoxColumn.Name = "datteOfRegistrationDataGridViewTextBoxColumn";
            this.datteOfRegistrationDataGridViewTextBoxColumn.Width = 150;
            // 
            // hMSDataSet4
            // 
            this.hMSDataSet4.DataSetName = "HMSDataSet4";
            this.hMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource1
            // 
            this.tblStudentBindingSource1.DataMember = "tbl_Student";
            this.tblStudentBindingSource1.DataSource = this.hMSDataSet4;
            // 
            // tbl_StudentTableAdapter1
            // 
            this.tbl_StudentTableAdapter1.ClearBeforeFill = true;
            // 
            // Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 731);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_CNIC);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DG_Student);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search_Student";
            this.Text = "Search_Student";
            this.Load += new System.EventHandler(this.Search_Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_Student;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_CNIC;
        private System.Windows.Forms.Button btn_Search;
        private HMSDataSet2 hMSDataSet2;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private HMSDataSet2TableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instituteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datteOfRegistrationDataGridViewTextBoxColumn;
        private HMSDataSet4 hMSDataSet4;
        private System.Windows.Forms.BindingSource tblStudentBindingSource1;
        private HMSDataSet4TableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter1;
    }
}
namespace HMS.Forms
{
    partial class Assign_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign_Room));
            this.txt_AvailableSeats = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_RoomNumber = new System.Windows.Forms.ComboBox();
            this.tblRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet11 = new HMS.HMSDataSet11();
            this.hMSDataSet10 = new HMS.HMSDataSet10();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RoomTableAdapter = new HMS.HMSDataSet10TableAdapters.tbl_RoomTableAdapter();
            this.tbl_RoomTableAdapter1 = new HMS.HMSDataSet11TableAdapters.tbl_RoomTableAdapter();
            this.cmb_CNIC = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.hMSDataSet12 = new HMS.HMSDataSet12();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StudentTableAdapter = new HMS.HMSDataSet12TableAdapters.tbl_StudentTableAdapter();
            this.btn_Save = new System.Windows.Forms.Button();
            this.bn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_AvailableSeats
            // 
            this.txt_AvailableSeats.Location = new System.Drawing.Point(196, 452);
            this.txt_AvailableSeats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AvailableSeats.Name = "txt_AvailableSeats";
            this.txt_AvailableSeats.Size = new System.Drawing.Size(298, 26);
            this.txt_AvailableSeats.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 451);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 73;
            this.label6.Text = "Available Seats:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "Student CNIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 68;
            this.label3.Text = "Room Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 66;
            this.label2.Text = "Student Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 55);
            this.panel2.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 131);
            this.panel1.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Room";
            // 
            // cmb_RoomNumber
            // 
            this.cmb_RoomNumber.DataSource = this.tblRoomBindingSource1;
            this.cmb_RoomNumber.DisplayMember = "RoomNumber";
            this.cmb_RoomNumber.FormattingEnabled = true;
            this.cmb_RoomNumber.Location = new System.Drawing.Point(196, 372);
            this.cmb_RoomNumber.Name = "cmb_RoomNumber";
            this.cmb_RoomNumber.Size = new System.Drawing.Size(298, 28);
            this.cmb_RoomNumber.TabIndex = 76;
            this.cmb_RoomNumber.SelectedIndexChanged += new System.EventHandler(this.cmb_RoomNumber_SelectedIndexChanged);
            // 
            // tblRoomBindingSource1
            // 
            this.tblRoomBindingSource1.DataMember = "tbl_Room";
            this.tblRoomBindingSource1.DataSource = this.hMSDataSet11;
            // 
            // hMSDataSet11
            // 
            this.hMSDataSet11.DataSetName = "HMSDataSet11";
            this.hMSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hMSDataSet10
            // 
            this.hMSDataSet10.DataSetName = "HMSDataSet10";
            this.hMSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tbl_Room";
            this.tblRoomBindingSource.DataSource = this.hMSDataSet10;
            // 
            // tbl_RoomTableAdapter
            // 
            this.tbl_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_RoomTableAdapter1
            // 
            this.tbl_RoomTableAdapter1.ClearBeforeFill = true;
            // 
            // cmb_CNIC
            // 
            this.cmb_CNIC.DataSource = this.tblStudentBindingSource;
            this.cmb_CNIC.DisplayMember = "CNIC";
            this.cmb_CNIC.FormattingEnabled = true;
            this.cmb_CNIC.Location = new System.Drawing.Point(196, 211);
            this.cmb_CNIC.Name = "cmb_CNIC";
            this.cmb_CNIC.Size = new System.Drawing.Size(298, 28);
            this.cmb_CNIC.TabIndex = 105;
            this.cmb_CNIC.SelectedIndexChanged += new System.EventHandler(this.cmb_CNIC_SelectedIndexChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(196, 297);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(298, 26);
            this.txt_Name.TabIndex = 106;
            // 
            // hMSDataSet12
            // 
            this.hMSDataSet12.DataSetName = "HMSDataSet12";
            this.hMSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tbl_Student";
            this.tblStudentBindingSource.DataSource = this.hMSDataSet12;
            // 
            // tbl_StudentTableAdapter
            // 
            this.tbl_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(99, 540);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(162, 72);
            this.btn_Save.TabIndex = 107;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // bn_Clear
            // 
            this.bn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.bn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("bn_Clear.Image")));
            this.bn_Clear.Location = new System.Drawing.Point(306, 540);
            this.bn_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bn_Clear.Name = "bn_Clear";
            this.bn_Clear.Size = new System.Drawing.Size(162, 72);
            this.bn_Clear.TabIndex = 108;
            this.bn_Clear.UseVisualStyleBackColor = false;
            // 
            // Assign_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 692);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.bn_Clear);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.cmb_CNIC);
            this.Controls.Add(this.cmb_RoomNumber);
            this.Controls.Add(this.txt_AvailableSeats);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Assign_Room";
            this.Text = "Assign_Room";
            this.Load += new System.EventHandler(this.Assign_Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_AvailableSeats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_RoomNumber;
        private HMSDataSet10 hMSDataSet10;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private HMSDataSet10TableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter;
        private HMSDataSet11 hMSDataSet11;
        private System.Windows.Forms.BindingSource tblRoomBindingSource1;
        private HMSDataSet11TableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter1;
        private System.Windows.Forms.ComboBox cmb_CNIC;
        private System.Windows.Forms.TextBox txt_Name;
        private HMSDataSet12 hMSDataSet12;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private HMSDataSet12TableAdapters.tbl_StudentTableAdapter tbl_StudentTableAdapter;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button bn_Clear;
    }
}
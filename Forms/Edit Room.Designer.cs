namespace HMS.Forms
{
    partial class Edit_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Room));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Rent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Seats = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Floor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_Number = new System.Windows.Forms.ComboBox();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet5 = new HMS.HMSDataSet5();
            this.tbl_RoomTableAdapter = new HMS.HMSDataSet5TableAdapters.tbl_RoomTableAdapter();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.txtwashrom = new System.Windows.Forms.ComboBox();
            this.hMSDataSet7 = new HMS.HMSDataSet7();
            this.tblRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RoomTableAdapter1 = new HMS.HMSDataSet7TableAdapters.tbl_RoomTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Room";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 55);
            this.panel2.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 131);
            this.panel1.TabIndex = 85;
            // 
            // txt_Rent
            // 
            this.txt_Rent.Location = new System.Drawing.Point(231, 501);
            this.txt_Rent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Rent.Name = "txt_Rent";
            this.txt_Rent.Size = new System.Drawing.Size(222, 26);
            this.txt_Rent.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 501);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 29);
            this.label7.TabIndex = 99;
            this.label7.Text = "Per Seat Rent:";
            // 
            // txt_Seats
            // 
            this.txt_Seats.Location = new System.Drawing.Point(231, 424);
            this.txt_Seats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Seats.Name = "txt_Seats";
            this.txt_Seats.Size = new System.Drawing.Size(222, 26);
            this.txt_Seats.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 424);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 29);
            this.label5.TabIndex = 97;
            this.label5.Text = "Available Seats:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 349);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 29);
            this.label6.TabIndex = 95;
            this.label6.Text = "Attach Washroom:";
            // 
            // txt_Floor
            // 
            this.txt_Floor.Location = new System.Drawing.Point(231, 214);
            this.txt_Floor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Floor.Name = "txt_Floor";
            this.txt_Floor.Size = new System.Drawing.Size(222, 26);
            this.txt_Floor.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 93;
            this.label4.Text = "Floor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 91;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 89;
            this.label2.Text = "Number:";
            // 
            // btn_Update
            // 
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.Location = new System.Drawing.Point(79, 557);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(162, 72);
            this.btn_Update.TabIndex = 102;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(253, 557);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(162, 72);
            this.btn_delete.TabIndex = 101;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb_Number
            // 
            this.cmb_Number.DataSource = this.tblRoomBindingSource1;
            this.cmb_Number.DisplayMember = "RoomNumber";
            this.cmb_Number.FormattingEnabled = true;
            this.cmb_Number.Location = new System.Drawing.Point(231, 149);
            this.cmb_Number.Name = "cmb_Number";
            this.cmb_Number.Size = new System.Drawing.Size(222, 28);
            this.cmb_Number.TabIndex = 103;
            this.cmb_Number.SelectedIndexChanged += new System.EventHandler(this.cmb_Number_SelectedIndexChanged);
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tbl_Room";
            this.tblRoomBindingSource.DataSource = this.hMSDataSet5;
            // 
            // hMSDataSet5
            // 
            this.hMSDataSet5.DataSetName = "HMSDataSet5";
            this.hMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_RoomTableAdapter
            // 
            this.tbl_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "1 bed",
            "2 beds",
            "3 beds",
            "4 beds",
            "5 beds",
            "6 beds"});
            this.cmb_Type.Location = new System.Drawing.Point(231, 284);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(222, 28);
            this.cmb_Type.TabIndex = 104;
            // 
            // txtwashrom
            // 
            this.txtwashrom.FormattingEnabled = true;
            this.txtwashrom.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.txtwashrom.Location = new System.Drawing.Point(231, 350);
            this.txtwashrom.Name = "txtwashrom";
            this.txtwashrom.Size = new System.Drawing.Size(222, 28);
            this.txtwashrom.TabIndex = 105;
            // 
            // hMSDataSet7
            // 
            this.hMSDataSet7.DataSetName = "HMSDataSet7";
            this.hMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomBindingSource1
            // 
            this.tblRoomBindingSource1.DataMember = "tbl_Room";
            this.tblRoomBindingSource1.DataSource = this.hMSDataSet7;
            // 
            // tbl_RoomTableAdapter1
            // 
            this.tbl_RoomTableAdapter1.ClearBeforeFill = true;
            // 
            // Edit_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 692);
            this.Controls.Add(this.txtwashrom);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.cmb_Number);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_Rent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Seats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Floor);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Edit_Room";
            this.Text = "Edit_Room";
            this.Load += new System.EventHandler(this.Edit_Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Rent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Seats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Floor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_Number;
        private HMSDataSet5 hMSDataSet5;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private HMSDataSet5TableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.ComboBox txtwashrom;
        private HMSDataSet7 hMSDataSet7;
        private System.Windows.Forms.BindingSource tblRoomBindingSource1;
        private HMSDataSet7TableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter1;
    }
}
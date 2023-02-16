namespace HMS.Forms
{
    partial class Edit_Visitorr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Visitorr));
            this.tbl_VisitorTableAdapter = new HMS.HMSDataSet9TableAdapters.tbl_VisitorTableAdapter();
            this.btn_Update = new System.Windows.Forms.Button();
            this.hMSDataSet9 = new HMS.HMSDataSet9();
            this.tblVisitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_Relation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cmb_WhomVisiting = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Adress = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_VisitTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_CNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hMSDataSet13 = new HMS.HMSDataSet13();
            this.tblVisitorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VisitorTableAdapter1 = new HMS.HMSDataSet13TableAdapters.tbl_VisitorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_VisitorTableAdapter
            // 
            this.tbl_VisitorTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.Location = new System.Drawing.Point(702, 514);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(162, 72);
            this.btn_Update.TabIndex = 122;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // hMSDataSet9
            // 
            this.hMSDataSet9.DataSetName = "HMSDataSet9";
            this.hMSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVisitorBindingSource
            // 
            this.tblVisitorBindingSource.DataMember = "tbl_Visitor";
            this.tblVisitorBindingSource.DataSource = this.hMSDataSet9;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(900, 514);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(162, 72);
            this.btn_delete.TabIndex = 121;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb_Name
            // 
            this.cmb_Name.DataSource = this.tblVisitorBindingSource1;
            this.cmb_Name.DisplayMember = "VisitorName";
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(163, 304);
            this.cmb_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(298, 28);
            this.cmb_Name.TabIndex = 120;
            this.cmb_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Name_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 519);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 118;
            this.label4.Text = "Adress:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(163, 180);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 55);
            this.panel3.TabIndex = 116;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(16, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "Personel Info:";
            // 
            // cmb_Relation
            // 
            this.cmb_Relation.Location = new System.Drawing.Point(858, 389);
            this.cmb_Relation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Relation.Name = "cmb_Relation";
            this.cmb_Relation.Size = new System.Drawing.Size(298, 26);
            this.cmb_Relation.TabIndex = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(635, 388);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 29);
            this.label12.TabIndex = 114;
            this.label12.Text = "Visitor Relation:";
            // 
            // Cmb_WhomVisiting
            // 
            this.Cmb_WhomVisiting.Location = new System.Drawing.Point(858, 297);
            this.Cmb_WhomVisiting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cmb_WhomVisiting.Name = "Cmb_WhomVisiting";
            this.Cmb_WhomVisiting.Size = new System.Drawing.Size(298, 26);
            this.Cmb_WhomVisiting.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(635, 298);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 29);
            this.label8.TabIndex = 112;
            this.label8.Text = "Whom Visiting:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(418, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitor Entry";
            // 
            // cmb_Adress
            // 
            this.cmb_Adress.Location = new System.Drawing.Point(163, 521);
            this.cmb_Adress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Adress.Name = "cmb_Adress";
            this.cmb_Adress.Size = new System.Drawing.Size(298, 26);
            this.cmb_Adress.TabIndex = 119;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(826, 180);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 55);
            this.panel4.TabIndex = 117;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 25);
            this.label15.TabIndex = 34;
            this.label15.Text = "Whom Visiting:";
            // 
            // cmb_VisitTime
            // 
            this.cmb_VisitTime.Location = new System.Drawing.Point(163, 450);
            this.cmb_VisitTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_VisitTime.Name = "cmb_VisitTime";
            this.cmb_VisitTime.Size = new System.Drawing.Size(298, 26);
            this.cmb_VisitTime.TabIndex = 111;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 131);
            this.panel1.TabIndex = 105;
            // 
            // cmb_CNIC
            // 
            this.cmb_CNIC.Location = new System.Drawing.Point(163, 378);
            this.cmb_CNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_CNIC.Name = "cmb_CNIC";
            this.cmb_CNIC.Size = new System.Drawing.Size(298, 26);
            this.cmb_CNIC.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 379);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 108;
            this.label3.Text = "CNIC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 107;
            this.label2.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 29);
            this.label6.TabIndex = 110;
            this.label6.Text = "Time Of Visit:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 701);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 55);
            this.panel2.TabIndex = 106;
            // 
            // hMSDataSet13
            // 
            this.hMSDataSet13.DataSetName = "HMSDataSet13";
            this.hMSDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVisitorBindingSource1
            // 
            this.tblVisitorBindingSource1.DataMember = "tbl_Visitor";
            this.tblVisitorBindingSource1.DataSource = this.hMSDataSet13;
            // 
            // tbl_VisitorTableAdapter1
            // 
            this.tbl_VisitorTableAdapter1.ClearBeforeFill = true;
            // 
            // Edit_Visitorr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 756);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cmb_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmb_Relation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Cmb_WhomVisiting);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Adress);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cmb_VisitTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_CNIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Name = "Edit_Visitorr";
            this.Text = "Edit_Visitorr";
            this.Load += new System.EventHandler(this.Edit_Visitorr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMSDataSet9TableAdapters.tbl_VisitorTableAdapter tbl_VisitorTableAdapter;
        private System.Windows.Forms.Button btn_Update;
        private HMSDataSet9 hMSDataSet9;
        private System.Windows.Forms.BindingSource tblVisitorBindingSource;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cmb_Relation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Cmb_WhomVisiting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cmb_Adress;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cmb_VisitTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cmb_CNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private HMSDataSet13 hMSDataSet13;
        private System.Windows.Forms.BindingSource tblVisitorBindingSource1;
        private HMSDataSet13TableAdapters.tbl_VisitorTableAdapter tbl_VisitorTableAdapter1;
    }
}
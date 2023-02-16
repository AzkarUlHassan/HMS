namespace HMS.Forms
{
    partial class User_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Setting));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Cpswrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Passwordr = new System.Windows.Forms.TextBox();
            this.bn_Clear = new System.Windows.Forms.Button();
            this.txt_UserNamer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IDr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_Paassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.cmb_ID = new System.Windows.Forms.ComboBox();
            this.hMSDataSet14 = new HMS.HMSDataSet14();
            this.tblLoginnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_LoginnTableAdapter = new HMS.HMSDataSet14TableAdapters.tbl_LoginnTableAdapter();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(436, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Setting";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 131);
            this.panel1.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 652);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 65);
            this.panel2.TabIndex = 102;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 138);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 506);
            this.tabControl1.TabIndex = 103;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_ID);
            this.tabPage1.Controls.Add(this.btn_Update);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txt_Cpswrd);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_Cname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1192, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update User";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(655, 342);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 72);
            this.button2.TabIndex = 92;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_Cpswrd
            // 
            this.txt_Cpswrd.Location = new System.Drawing.Point(479, 215);
            this.txt_Cpswrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Cpswrd.Name = "txt_Cpswrd";
            this.txt_Cpswrd.Size = new System.Drawing.Size(298, 32);
            this.txt_Cpswrd.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 79;
            this.label3.Text = "Password:";
            // 
            // txt_Cname
            // 
            this.txt_Cname.Location = new System.Drawing.Point(479, 135);
            this.txt_Cname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Cname.Name = "txt_Cname";
            this.txt_Cname.Size = new System.Drawing.Size(298, 32);
            this.txt_Cname.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 77;
            this.label2.Text = "UserName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 29);
            this.label6.TabIndex = 75;
            this.label6.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Save);
            this.tabPage2.Controls.Add(this.txt_Passwordr);
            this.tabPage2.Controls.Add(this.bn_Clear);
            this.tabPage2.Controls.Add(this.txt_UserNamer);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_IDr);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1192, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register New User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(439, 340);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(162, 72);
            this.btn_Save.TabIndex = 104;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Passwordr
            // 
            this.txt_Passwordr.Location = new System.Drawing.Point(479, 247);
            this.txt_Passwordr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Passwordr.Name = "txt_Passwordr";
            this.txt_Passwordr.Size = new System.Drawing.Size(298, 26);
            this.txt_Passwordr.TabIndex = 86;
            // 
            // bn_Clear
            // 
            this.bn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("bn_Clear.Image")));
            this.bn_Clear.Location = new System.Drawing.Point(646, 340);
            this.bn_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bn_Clear.Name = "bn_Clear";
            this.bn_Clear.Size = new System.Drawing.Size(162, 72);
            this.bn_Clear.TabIndex = 105;
            this.bn_Clear.UseVisualStyleBackColor = true;
            this.bn_Clear.Click += new System.EventHandler(this.bn_Clear_Click);
            // 
            // txt_UserNamer
            // 
            this.txt_UserNamer.Location = new System.Drawing.Point(479, 168);
            this.txt_UserNamer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserNamer.Name = "txt_UserNamer";
            this.txt_UserNamer.Size = new System.Drawing.Size(298, 26);
            this.txt_UserNamer.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 85;
            this.label4.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 29);
            this.label7.TabIndex = 81;
            this.label7.Text = "ID:";
            // 
            // txt_IDr
            // 
            this.txt_IDr.Location = new System.Drawing.Point(479, 96);
            this.txt_IDr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IDr.Name = "txt_IDr";
            this.txt_IDr.Size = new System.Drawing.Size(298, 26);
            this.txt_IDr.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 83;
            this.label5.Text = "UserName:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.txt_Paassword);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.txt_ID);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txt_UserName);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1192, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete User";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_Paassword
            // 
            this.txt_Paassword.Location = new System.Drawing.Point(533, 234);
            this.txt_Paassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Paassword.Name = "txt_Paassword";
            this.txt_Paassword.Size = new System.Drawing.Size(298, 26);
            this.txt_Paassword.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(323, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 29);
            this.label12.TabIndex = 106;
            this.label12.Text = "ID:";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(709, 357);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 72);
            this.button4.TabIndex = 113;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(533, 76);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(298, 26);
            this.txt_ID.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 29);
            this.label11.TabIndex = 108;
            this.label11.Text = "UserName:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(533, 154);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(298, 26);
            this.txt_UserName.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 239);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 29);
            this.label10.TabIndex = 110;
            this.label10.Text = "Password:";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(517, 357);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 72);
            this.button3.TabIndex = 116;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.Location = new System.Drawing.Point(479, 345);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(162, 72);
            this.btn_Update.TabIndex = 103;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cmb_ID
            // 
            this.cmb_ID.DataSource = this.tblLoginnBindingSource;
            this.cmb_ID.DisplayMember = "ID";
            this.cmb_ID.FormattingEnabled = true;
            this.cmb_ID.Location = new System.Drawing.Point(479, 69);
            this.cmb_ID.Name = "cmb_ID";
            this.cmb_ID.Size = new System.Drawing.Size(298, 37);
            this.cmb_ID.TabIndex = 104;
            this.cmb_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hMSDataSet14
            // 
            this.hMSDataSet14.DataSetName = "HMSDataSet14";
            this.hMSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLoginnBindingSource
            // 
            this.tblLoginnBindingSource.DataMember = "tbl_Loginn";
            this.tblLoginnBindingSource.DataSource = this.hMSDataSet14;
            // 
            // tbl_LoginnTableAdapter
            // 
            this.tbl_LoginnTableAdapter.ClearBeforeFill = true;
            // 
            // User_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 717);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User_Setting";
            this.Text = "User_Setting";
            this.Load += new System.EventHandler(this.User_Setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_Cpswrd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Passwordr;
        private System.Windows.Forms.TextBox txt_UserNamer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_IDr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button bn_Clear;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_Paassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cmb_ID;
        private HMSDataSet14 hMSDataSet14;
        private System.Windows.Forms.BindingSource tblLoginnBindingSource;
        private HMSDataSet14TableAdapters.tbl_LoginnTableAdapter tbl_LoginnTableAdapter;
    }
}
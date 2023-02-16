namespace HMS.Forms
{
    partial class Search_Visitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Visitor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CNIC = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Choice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGview = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.hMSDataSet3 = new HMS.HMSDataSet3();
            this.tblVisitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VisitorTableAdapter = new HMS.HMSDataSet3TableAdapters.tbl_VisitorTableAdapter();
            this.visitorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameWhomVisitingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorRelationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 131);
            this.panel1.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(302, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Visitor";
            // 
            // txt_CNIC
            // 
            this.txt_CNIC.Location = new System.Drawing.Point(385, 200);
            this.txt_CNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CNIC.Name = "txt_CNIC";
            this.txt_CNIC.Size = new System.Drawing.Size(230, 26);
            this.txt_CNIC.TabIndex = 104;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(385, 154);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(230, 26);
            this.txt_Name.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 102;
            this.label4.Text = "CNIC:";
            // 
            // cmb_Choice
            // 
            this.cmb_Choice.FormattingEnabled = true;
            this.cmb_Choice.Items.AddRange(new object[] {
            "Name",
            "CNIC"});
            this.cmb_Choice.Location = new System.Drawing.Point(147, 159);
            this.cmb_Choice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Choice.Name = "cmb_Choice";
            this.cmb_Choice.Size = new System.Drawing.Size(135, 28);
            this.cmb_Choice.TabIndex = 101;
            this.cmb_Choice.SelectedIndexChanged += new System.EventHandler(this.cmb_Choice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 100;
            this.label3.Text = "Search With:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 99;
            this.label2.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 660);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 65);
            this.panel2.TabIndex = 98;
            // 
            // DGview
            // 
            this.DGview.AutoGenerateColumns = false;
            this.DGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitorNameDataGridViewTextBoxColumn,
            this.cNICDataGridViewTextBoxColumn,
            this.visitingNameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.nameWhomVisitingDataGridViewTextBoxColumn,
            this.visitorRelationDataGridViewTextBoxColumn});
            this.DGview.DataSource = this.tblVisitorBindingSource;
            this.DGview.Location = new System.Drawing.Point(0, 236);
            this.DGview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGview.Name = "DGview";
            this.DGview.RowHeadersWidth = 62;
            this.DGview.Size = new System.Drawing.Size(1354, 572);
            this.DGview.TabIndex = 97;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(724, 154);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 72);
            this.button6.TabIndex = 105;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hMSDataSet3
            // 
            this.hMSDataSet3.DataSetName = "HMSDataSet3";
            this.hMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVisitorBindingSource
            // 
            this.tblVisitorBindingSource.DataMember = "tbl_Visitor";
            this.tblVisitorBindingSource.DataSource = this.hMSDataSet3;
            // 
            // tbl_VisitorTableAdapter
            // 
            this.tbl_VisitorTableAdapter.ClearBeforeFill = true;
            // 
            // visitorNameDataGridViewTextBoxColumn
            // 
            this.visitorNameDataGridViewTextBoxColumn.DataPropertyName = "VisitorName";
            this.visitorNameDataGridViewTextBoxColumn.HeaderText = "VisitorName";
            this.visitorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.visitorNameDataGridViewTextBoxColumn.Name = "visitorNameDataGridViewTextBoxColumn";
            this.visitorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cNICDataGridViewTextBoxColumn
            // 
            this.cNICDataGridViewTextBoxColumn.DataPropertyName = "CNIC";
            this.cNICDataGridViewTextBoxColumn.HeaderText = "CNIC";
            this.cNICDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cNICDataGridViewTextBoxColumn.Name = "cNICDataGridViewTextBoxColumn";
            this.cNICDataGridViewTextBoxColumn.Width = 150;
            // 
            // visitingNameDataGridViewTextBoxColumn
            // 
            this.visitingNameDataGridViewTextBoxColumn.DataPropertyName = "VisitingName";
            this.visitingNameDataGridViewTextBoxColumn.HeaderText = "VisitingName";
            this.visitingNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.visitingNameDataGridViewTextBoxColumn.Name = "visitingNameDataGridViewTextBoxColumn";
            this.visitingNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameWhomVisitingDataGridViewTextBoxColumn
            // 
            this.nameWhomVisitingDataGridViewTextBoxColumn.DataPropertyName = "NameWhomVisiting";
            this.nameWhomVisitingDataGridViewTextBoxColumn.HeaderText = "NameWhomVisiting";
            this.nameWhomVisitingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameWhomVisitingDataGridViewTextBoxColumn.Name = "nameWhomVisitingDataGridViewTextBoxColumn";
            this.nameWhomVisitingDataGridViewTextBoxColumn.Width = 150;
            // 
            // visitorRelationDataGridViewTextBoxColumn
            // 
            this.visitorRelationDataGridViewTextBoxColumn.DataPropertyName = "VisitorRelation";
            this.visitorRelationDataGridViewTextBoxColumn.HeaderText = "VisitorRelation";
            this.visitorRelationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.visitorRelationDataGridViewTextBoxColumn.Name = "visitorRelationDataGridViewTextBoxColumn";
            this.visitorRelationDataGridViewTextBoxColumn.Width = 150;
            // 
            // Search_Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 725);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_CNIC);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Choice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGview);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search_Visitor";
            this.Text = "Search_Visitor";
            this.Load += new System.EventHandler(this.Search_Visitor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CNIC;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Choice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGview;
        private System.Windows.Forms.Button button6;
        private HMSDataSet3 hMSDataSet3;
        private System.Windows.Forms.BindingSource tblVisitorBindingSource;
        private HMSDataSet3TableAdapters.tbl_VisitorTableAdapter tbl_VisitorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameWhomVisitingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorRelationDataGridViewTextBoxColumn;
    }
}
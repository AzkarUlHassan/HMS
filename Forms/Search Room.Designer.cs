namespace HMS.Forms
{
    partial class Search_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Room));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SRview = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.hMSDataSet = new HMS.HMSDataSet();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RoomTableAdapter = new HMS.HMSDataSetTableAdapters.tbl_RoomTableAdapter();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachWashroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatRientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SRview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(245, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Room";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(247, 162);
            this.txt_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(230, 26);
            this.txt_number.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 102;
            this.label4.Text = "Room Number:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 65);
            this.panel2.TabIndex = 98;
            // 
            // SRview
            // 
            this.SRview.AutoGenerateColumns = false;
            this.SRview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SRview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.bedsDataGridViewTextBoxColumn,
            this.attachWashroomDataGridViewTextBoxColumn,
            this.seatsDataGridViewTextBoxColumn,
            this.seatRientDataGridViewTextBoxColumn});
            this.SRview.DataSource = this.tblRoomBindingSource;
            this.SRview.Location = new System.Drawing.Point(-1, 223);
            this.SRview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SRview.Name = "SRview";
            this.SRview.RowHeadersWidth = 62;
            this.SRview.Size = new System.Drawing.Size(959, 477);
            this.SRview.TabIndex = 97;
            // 
            // btn_Search
            // 
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(529, 139);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(162, 72);
            this.btn_Search.TabIndex = 106;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tbl_Room";
            this.tblRoomBindingSource.DataSource = this.hMSDataSet;
            // 
            // tbl_RoomTableAdapter
            // 
            this.tbl_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.Width = 150;
            // 
            // bedsDataGridViewTextBoxColumn
            // 
            this.bedsDataGridViewTextBoxColumn.DataPropertyName = "Beds";
            this.bedsDataGridViewTextBoxColumn.HeaderText = "Beds";
            this.bedsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bedsDataGridViewTextBoxColumn.Name = "bedsDataGridViewTextBoxColumn";
            this.bedsDataGridViewTextBoxColumn.Width = 150;
            // 
            // attachWashroomDataGridViewTextBoxColumn
            // 
            this.attachWashroomDataGridViewTextBoxColumn.DataPropertyName = "AttachWashroom";
            this.attachWashroomDataGridViewTextBoxColumn.HeaderText = "AttachWashroom";
            this.attachWashroomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attachWashroomDataGridViewTextBoxColumn.Name = "attachWashroomDataGridViewTextBoxColumn";
            this.attachWashroomDataGridViewTextBoxColumn.Width = 150;
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            this.seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            this.seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            this.seatsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            this.seatsDataGridViewTextBoxColumn.Width = 150;
            // 
            // seatRientDataGridViewTextBoxColumn
            // 
            this.seatRientDataGridViewTextBoxColumn.DataPropertyName = "SeatRient";
            this.seatRientDataGridViewTextBoxColumn.HeaderText = "SeatRient";
            this.seatRientDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seatRientDataGridViewTextBoxColumn.Name = "seatRientDataGridViewTextBoxColumn";
            this.seatRientDataGridViewTextBoxColumn.Width = 150;
            // 
            // Search_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 692);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SRview);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search_Room";
            this.Text = "Search_Room";
            this.Load += new System.EventHandler(this.Search_Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SRview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView SRview;
        private System.Windows.Forms.Button btn_Search;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private HMSDataSetTableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachWashroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatRientDataGridViewTextBoxColumn;
    }
}
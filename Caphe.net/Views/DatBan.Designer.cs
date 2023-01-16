
namespace Caphe.net.Views
{
    partial class DatBan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatBan));
            this.panel18 = new System.Windows.Forms.Panel();
            this.cbbmab = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatBan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbsb = new System.Windows.Forms.ComboBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.cbbstt = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cbbsl = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel18.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel18.Controls.Add(this.cbbmab);
            this.panel18.Controls.Add(this.label3);
            this.panel18.Controls.Add(this.panel1);
            this.panel18.Controls.Add(this.cbbsb);
            this.panel18.Controls.Add(this.txttenkh);
            this.panel18.Controls.Add(this.label14);
            this.panel18.Controls.Add(this.btnLammoi);
            this.panel18.Controls.Add(this.cbbstt);
            this.panel18.Controls.Add(this.label15);
            this.panel18.Controls.Add(this.datetime);
            this.panel18.Controls.Add(this.btnThem);
            this.panel18.Controls.Add(this.label16);
            this.panel18.Controls.Add(this.cbbsl);
            this.panel18.Controls.Add(this.btnSua);
            this.panel18.Controls.Add(this.label27);
            this.panel18.Controls.Add(this.label13);
            this.panel18.Controls.Add(this.btnXoa);
            this.panel18.Controls.Add(this.label28);
            this.panel18.Controls.Add(this.btnLuu);
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1023, 362);
            this.panel18.TabIndex = 11;
            // 
            // cbbmab
            // 
            this.cbbmab.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmab.FormattingEnabled = true;
            this.cbbmab.Items.AddRange(new object[] {
            "BAN01",
            "BAN02",
            "BAN03",
            "BAN04",
            "BAN05",
            "BAN06",
            "BAN07",
            "BAN08",
            "BAN09",
            "BAN10",
            "BAN11",
            "BAN12",
            "BAN13",
            "BAN14",
            "BAN15",
            "BAN16"});
            this.cbbmab.Location = new System.Drawing.Point(378, 48);
            this.cbbmab.Name = "cbbmab";
            this.cbbmab.Size = new System.Drawing.Size(140, 25);
            this.cbbmab.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mã bàn :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvDatBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 183);
            this.panel1.TabIndex = 47;
            // 
            // dgvDatBan
            // 
            this.dgvDatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDatBan.Location = new System.Drawing.Point(13, 37);
            this.dgvDatBan.Name = "dgvDatBan";
            this.dgvDatBan.RowHeadersWidth = 51;
            this.dgvDatBan.RowTemplate.Height = 24;
            this.dgvDatBan.Size = new System.Drawing.Size(994, 141);
            this.dgvDatBan.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "DANH SÁCH ĐẶT BÀN";
            // 
            // cbbsb
            // 
            this.cbbsb.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsb.FormattingEnabled = true;
            this.cbbsb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cbbsb.Location = new System.Drawing.Point(413, 86);
            this.cbbsb.Name = "cbbsb";
            this.cbbsb.Size = new System.Drawing.Size(121, 25);
            this.cbbsb.TabIndex = 46;
            // 
            // txttenkh
            // 
            this.txttenkh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.Location = new System.Drawing.Point(664, 47);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(169, 25);
            this.txttenkh.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(352, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 45;
            this.label14.Text = "Số bàn :";
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.White;
            this.btnLammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.Location = new System.Drawing.Point(519, 120);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(80, 45);
            this.btnLammoi.TabIndex = 36;
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // cbbstt
            // 
            this.cbbstt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbstt.FormattingEnabled = true;
            this.cbbstt.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbbstt.Location = new System.Drawing.Point(123, 51);
            this.cbbstt.Name = "cbbstt";
            this.cbbstt.Size = new System.Drawing.Size(121, 25);
            this.cbbstt.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(549, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Tên khách hàng :";
            // 
            // datetime
            // 
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetime.Location = new System.Drawing.Point(679, 86);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(154, 22);
            this.datetime.TabIndex = 43;
            this.datetime.Value = new System.DateTime(2021, 10, 6, 10, 0, 0, 0);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(195, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 45);
            this.btnThem.TabIndex = 40;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(603, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Thời gian :";
            // 
            // cbbsl
            // 
            this.cbbsl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsl.FormattingEnabled = true;
            this.cbbsl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbsl.Location = new System.Drawing.Point(159, 82);
            this.cbbsl.Name = "cbbsl";
            this.cbbsl.Size = new System.Drawing.Size(121, 25);
            this.cbbsl.TabIndex = 42;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(276, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 45);
            this.btnSua.TabIndex = 39;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(48, 86);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 17);
            this.label27.TabIndex = 29;
            this.label27.Text = "Số lượng người :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(336, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 41;
            this.label13.Text = "ĐẶT BÀN";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(357, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 45);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(47, 55);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 17);
            this.label28.TabIndex = 30;
            this.label28.Text = "Số thứ tự :";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(438, 120);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 45);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "stt";
            this.Column1.HeaderText = "Số thứ tự";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "maban";
            this.Column6.HeaderText = "Mã bàn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenkh";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soban";
            this.Column3.HeaderText = "Số bàn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soluong";
            this.Column4.HeaderText = "Số lượng người";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thoigian";
            this.Column5.HeaderText = "Thời gian";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // DatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel18);
            this.Name = "DatBan";
            this.Size = new System.Drawing.Size(1023, 362);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.ComboBox cbbsb;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.ComboBox cbbstt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbsl;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbmab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

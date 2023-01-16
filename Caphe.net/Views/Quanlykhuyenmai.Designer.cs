
namespace Caphe.net.Views
{
    partial class Quanlykhuyenmai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanlykhuyenmai));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDSChuongTrinh = new System.Windows.Forms.DataGridView();
            this.Huy = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbma = new System.Windows.Forms.ComboBox();
            this.txtdate2 = new System.Windows.Forms.DateTimePicker();
            this.txtdate1 = new System.Windows.Forms.DateTimePicker();
            this.txtchieukhau = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChuongTrinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvDSChuongTrinh);
            this.panel2.Location = new System.Drawing.Point(40, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 319);
            this.panel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "DANH SÁCH CHƯƠNG TRÌNH";
            // 
            // dgvDSChuongTrinh
            // 
            this.dgvDSChuongTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChuongTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDSChuongTrinh.Location = new System.Drawing.Point(13, 55);
            this.dgvDSChuongTrinh.Name = "dgvDSChuongTrinh";
            this.dgvDSChuongTrinh.RowHeadersWidth = 51;
            this.dgvDSChuongTrinh.RowTemplate.Height = 24;
            this.dgvDSChuongTrinh.Size = new System.Drawing.Size(806, 234);
            this.dgvDSChuongTrinh.TabIndex = 3;
            // 
            // Huy
            // 
            this.Huy.BackColor = System.Drawing.Color.White;
            this.Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Huy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huy.Image = ((System.Drawing.Image)(resources.GetObject("Huy.Image")));
            this.Huy.Location = new System.Drawing.Point(406, 297);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(80, 45);
            this.Huy.TabIndex = 15;
            this.Huy.UseVisualStyleBackColor = false;
            // 
            // Luu
            // 
            this.Luu.BackColor = System.Drawing.Color.White;
            this.Luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Luu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luu.Image = ((System.Drawing.Image)(resources.GetObject("Luu.Image")));
            this.Luu.Location = new System.Drawing.Point(406, 249);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(80, 45);
            this.Luu.TabIndex = 16;
            this.Luu.UseVisualStyleBackColor = false;
            this.Luu.Click += new System.EventHandler(this.Luu_Click_1);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.White;
            this.Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.Location = new System.Drawing.Point(406, 202);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(80, 45);
            this.Xoa.TabIndex = 17;
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click_1);
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.Color.White;
            this.Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Image = ((System.Drawing.Image)(resources.GetObject("Sua.Image")));
            this.Sua.Location = new System.Drawing.Point(406, 154);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(80, 45);
            this.Sua.TabIndex = 18;
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click_1);
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.White;
            this.Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Them.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Image = ((System.Drawing.Image)(resources.GetObject("Them.Image")));
            this.Them.Location = new System.Drawing.Point(406, 106);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(80, 45);
            this.Them.TabIndex = 19;
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbma);
            this.panel1.Controls.Add(this.txtdate2);
            this.panel1.Controls.Add(this.txtdate1);
            this.panel1.Controls.Add(this.txtchieukhau);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 301);
            this.panel1.TabIndex = 14;
            // 
            // cbbma
            // 
            this.cbbma.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbma.FormattingEnabled = true;
            this.cbbma.Items.AddRange(new object[] {
            "KM01",
            "KM02",
            "KM03",
            "KM04",
            "KM05",
            "KM06",
            "KM07",
            "KM08",
            "KM09",
            "KM10"});
            this.cbbma.Location = new System.Drawing.Point(138, 19);
            this.cbbma.Name = "cbbma";
            this.cbbma.Size = new System.Drawing.Size(175, 25);
            this.cbbma.TabIndex = 13;
            // 
            // txtdate2
            // 
            this.txtdate2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate2.Location = new System.Drawing.Point(129, 230);
            this.txtdate2.Name = "txtdate2";
            this.txtdate2.Size = new System.Drawing.Size(184, 25);
            this.txtdate2.TabIndex = 2;
            // 
            // txtdate1
            // 
            this.txtdate1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate1.Location = new System.Drawing.Point(129, 189);
            this.txtdate1.Name = "txtdate1";
            this.txtdate1.Size = new System.Drawing.Size(184, 25);
            this.txtdate1.TabIndex = 2;
            // 
            // txtchieukhau
            // 
            this.txtchieukhau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchieukhau.Location = new System.Drawing.Point(129, 145);
            this.txtchieukhau.Name = "txtchieukhau";
            this.txtchieukhau.Size = new System.Drawing.Size(184, 25);
            this.txtchieukhau.TabIndex = 3;
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(29, 99);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(284, 25);
            this.txtten.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày kết thúc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã khuyến mãi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày bắt đầu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chiết khấu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chương trình :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "THÔNG TIN CHƯƠNG TRÌNH";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "makm";
            this.Column1.HeaderText = "Mã khuyến mãi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten";
            this.Column2.HeaderText = "Tên chương trình";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "chietkhau";
            this.Column3.HeaderText = "Chiết khấu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaybd";
            this.Column4.HeaderText = "Ngày bắt đầu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaykt";
            this.Column5.HeaderText = "Ngày kết thúc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Quanlykhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Quanlykhuyenmai";
            this.Size = new System.Drawing.Size(917, 739);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChuongTrinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDSChuongTrinh;
        private System.Windows.Forms.Button Huy;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbma;
        private System.Windows.Forms.DateTimePicker txtdate2;
        private System.Windows.Forms.DateTimePicker txtdate1;
        private System.Windows.Forms.TextBox txtchieukhau;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

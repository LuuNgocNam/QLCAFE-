
namespace Caphe.net.Views
{
    partial class MNdatban
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
            this.dgvdatban1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatban1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdatban1
            // 
            this.dgvdatban1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatban1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvdatban1.Location = new System.Drawing.Point(23, 3);
            this.dgvdatban1.Name = "dgvdatban1";
            this.dgvdatban1.RowHeadersWidth = 51;
            this.dgvdatban1.RowTemplate.Height = 24;
            this.dgvdatban1.Size = new System.Drawing.Size(860, 227);
            this.dgvdatban1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maban";
            this.Column1.HeaderText = "Mã bàn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "makv";
            this.Column6.HeaderText = "Mã khu vực";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenban";
            this.Column2.HeaderText = "Tên bàn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenkv";
            this.Column3.HeaderText = "Tên khu vực";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "trangthai";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // MNdatban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvdatban1);
            this.Name = "MNdatban";
            this.Size = new System.Drawing.Size(948, 227);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatban1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdatban1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

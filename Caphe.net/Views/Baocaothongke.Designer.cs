
namespace Caphe.net.Views
{
    partial class Baocaothongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocaothongke));
            this.button3 = new System.Windows.Forms.Button();
            this.xuatEX = new System.Windows.Forms.Button();
            this.thongke = new System.Windows.Forms.Button();
            this.displaytt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpY = new System.Windows.Forms.DateTimePicker();
            this.dtpX = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1067, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 44);
            this.button3.TabIndex = 54;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // xuatEX
            // 
            this.xuatEX.BackColor = System.Drawing.Color.White;
            this.xuatEX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatEX.Location = new System.Drawing.Point(1363, 196);
            this.xuatEX.Name = "xuatEX";
            this.xuatEX.Size = new System.Drawing.Size(106, 43);
            this.xuatEX.TabIndex = 53;
            this.xuatEX.Text = "Xuất Excel";
            this.xuatEX.UseVisualStyleBackColor = false;
            this.xuatEX.Click += new System.EventHandler(this.xuatEX_Click);
            // 
            // thongke
            // 
            this.thongke.BackColor = System.Drawing.Color.White;
            this.thongke.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke.Location = new System.Drawing.Point(1363, 105);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(106, 43);
            this.thongke.TabIndex = 52;
            this.thongke.Text = "Biểu đồ";
            this.thongke.UseVisualStyleBackColor = false;
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // displaytt
            // 
            this.displaytt.BackColor = System.Drawing.Color.White;
            this.displaytt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displaytt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaytt.Location = new System.Drawing.Point(940, 477);
            this.displaytt.Name = "displaytt";
            this.displaytt.Size = new System.Drawing.Size(161, 20);
            this.displaytt.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(797, 476);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "Tổng doanh thu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(696, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Từ ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // dtpY
            // 
            this.dtpY.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpY.Location = new System.Drawing.Point(767, 408);
            this.dtpY.Name = "dtpY";
            this.dtpY.Size = new System.Drawing.Size(180, 25);
            this.dtpY.TabIndex = 45;
            // 
            // dtpX
            // 
            this.dtpX.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpX.Location = new System.Drawing.Point(385, 408);
            this.dtpX.Name = "dtpX";
            this.dtpX.Size = new System.Drawing.Size(180, 25);
            this.dtpX.TabIndex = 46;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(73, 518);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1201, 290);
            this.dgv.TabIndex = 44;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(73, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "tongdoanhthu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1201, 300);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            // 
            // Baocaothongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button3);
            this.Controls.Add(this.xuatEX);
            this.Controls.Add(this.thongke);
            this.Controls.Add(this.displaytt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpY);
            this.Controls.Add(this.dtpX);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.chart1);
            this.Name = "Baocaothongke";
            this.Size = new System.Drawing.Size(1542, 835);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button xuatEX;
        private System.Windows.Forms.Button thongke;
        private System.Windows.Forms.TextBox displaytt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpY;
        private System.Windows.Forms.DateTimePicker dtpX;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

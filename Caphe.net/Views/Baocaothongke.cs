using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;


namespace Caphe.net.Views
{
    public partial class Baocaothongke : UserControl
    {
        string con_str = "Data Source = DESKTOP-27UGJ33; Initial catalog= quanlycaphe;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public Baocaothongke()
        {
            InitializeComponent();
            showData();
        }
        public static Baocaothongke bctk = new Baocaothongke();
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from baocaothongke";
            DataSet ds = new DataSet();
            SqlDataAdapter df = new SqlDataAdapter(sql, conn);
            df.Fill(ds, "baocaothongke");
            dgv.DataSource = ds.Tables["baocaothongke"];
            int sum = 0;
            for (int i = 0; i < ds.Tables["baocaothongke"].Rows.Count; i++)
            {
                sum += Convert.ToInt32(ds.Tables["baocaothongke"].Rows[i]["doanhthu"].ToString());
            }

            displaytt.Text = "" + sum;
        }

        private void dtpX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string ngaybd = dtpX.Value.ToString();
            string ngaykt = dtpY.Value.ToString();
            string sql3 = "SELECT * FROM baocaothongke WHERE ngaybd BETWEEN '" + ngaybd + "' and '" + ngaykt + "' ";
            string sql4 = "select SUM(doanhthu) from baocaothongke  WHERE ngaybd BETWEEN '" + ngaybd + "' and '" + ngaykt + "' ";
            conn.Open();
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql3, conn);
            SqlCommand cmd = new SqlCommand(sql4, conn);
            da = new SqlDataAdapter(sql3, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ngaybd", ngaybd));
            da.SelectCommand.Parameters.Add(new SqlParameter("@ngaykt", ngaykt));
            displaytt.Text = cmd.ExecuteScalar().ToString();
            da.Fill(rs, "baocaothongke");
            dgv.DataSource = rs.Tables["baocaothongke"];
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                System.Data.DataTable dt = new System.Data.DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from  baocaothongke", conn);
                conn.Open();
                da.Fill(dt);

                conn.Close();
                MessageBox.Show("thanh cong");
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Thời gian";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh thu";
                chart1.Series["tongdoanhthu"]["DrawingStyle"] = "Cylinder";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["tongdoanhthu"].Points.AddXY(dt.Rows[i]["ngaybd"], dt.Rows[i]["doanhthu"]);
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[i + 1] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 2] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void xuatEX_Click(object sender, EventArgs e)
        {
            export2Excel(dgv, @"D:\", "quanlycaphe");
        }
    }
}

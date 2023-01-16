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

namespace Caphe.net.Views
{
    public partial class Luongnhanvien : UserControl
    {
        public Luongnhanvien()
        {
            InitializeComponent();
            showData();
        }

        public static Luongnhanvien lnv = new Luongnhanvien();
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from quanlynhanvien";
            DataSet ds = new DataSet();
            SqlDataAdapter df = new SqlDataAdapter(sql, conn);
            df.Fill(ds, "quanlynhanvien");
            dgvDSNhanVien.DataSource = ds.Tables["quanlynhanvien"];
        }


        private void btnhienthi_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from  luongnhanvien", conn);
                conn.Open();
                da.Fill(dt);

                conn.Close();
                MessageBox.Show("thanh cong");
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Lương";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Chức vụ";
                chart1.Series["luong"]["DrawingStyle"] = "Cylinder";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["luong"].Points.AddXY(dt.Rows[i]["chucvu"], dt.Rows[i]["luongcoban"]);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Timkiemnhanvien : UserControl
    {
        public Timkiemnhanvien()
        {
            InitializeComponent();
        }
        private void showData(String gioitinh)
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from quanlynhanvien where gioitinh = N'" + gioitinh + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "quanlynhanvien");
            dgvDSNhanVien.DataSource = ds.Tables["quanlynhanvien"];
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn = new SqlConnection(conn_str);
            DataSet rs = new DataSet();
            string sql = "select * from quanlynhanvien where ten like '%' + @ten + '%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ten", ten));
            da.Fill(rs, "quanlynhanvien");
            dgvDSNhanVien.DataSource = rs.Tables["quanlynhanvien"];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                String sql = "select * from quanlynhanvien order by manv ";
                DataSet rs = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "quanlynhanvien");
                dgvDSNhanVien.DataSource = rs.Tables["quanlynhanvien"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("er" + ex.Message);
            }
        }

        private void cbbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            String gioitinh = cbbgt.SelectedItem.ToString();
            showData(gioitinh);
        }
    }
}

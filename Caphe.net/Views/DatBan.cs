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
    public partial class DatBan : UserControl
    {
        public DatBan()
        {
            InitializeComponent();
            datetime.ShowUpDown = true;
            showData();
        }
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from DatBan";
            DataSet ds = new DataSet();
            SqlDataAdapter df = new SqlDataAdapter(sql, conn);
            df.Fill(ds, "DatBan");
            dgvDatBan.DataSource = ds.Tables["DatBan"];
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                String sql = "select * from DatBan order by Sốthứtự ";
                DataSet rs = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(rs, "DatBan");
                dgvDatBan.DataSource = rs.Tables["DatBan"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("er" + ex.Message);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {

                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string stt = cbbstt.Text;
                string mab = cbbmab.Text;
                string ten = txttenkh.Text;
                string soluong = cbbsl.Text;
                string soban = cbbsb.Text;
                string thoigian = datetime.Text;
                string sql = "insert into DatBan values (@stt, @maban, @tenkh, @soban, @soluong, @thoigian)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@stt", stt));
                cmd.Parameters.Add(new SqlParameter("@maban", stt));
                cmd.Parameters.Add(new SqlParameter("@tenkh", ten));
                cmd.Parameters.Add(new SqlParameter("@soban", soluong));
                cmd.Parameters.Add(new SqlParameter("@soluong", soban));
                cmd.Parameters.Add(new SqlParameter("@thoigian", thoigian));
                int rs = (int)cmd.ExecuteNonQuery();
                if (rs == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    showData();
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi");

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string stt = cbbstt.Text;
                string mab = cbbmab.Text;
                string ten = txttenkh.Text;
                string soluong = cbbsl.Text;
                string soban = cbbsb.Text;
                string thoigian = datetime.Text;
                string sql = "update DatBan set maban=@maban, tenkh=@tenkh, soban=@soban, soluong=@soluong, thoigian=@thoigian where stt=@stt ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@stt", stt));
                cmd.Parameters.Add(new SqlParameter("@maban", stt));
                cmd.Parameters.Add(new SqlParameter("@tenkh", ten));
                cmd.Parameters.Add(new SqlParameter("@soban", soluong));
                cmd.Parameters.Add(new SqlParameter("@soluong", soban));
                cmd.Parameters.Add(new SqlParameter("@thoigian", thoigian));
                int rs = (int)cmd.ExecuteNonQuery();
                if (rs == 1)
                {
                    MessageBox.Show("Sửa thành công");
                    showData();
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi");

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string stt = cbbstt.Text;
                string mab = cbbmab.Text;
                string ten = txttenkh.Text;
                string soluong = cbbsl.Text;
                string soban = cbbsb.Text;
                string thoigian = datetime.Text;
                string sql = "delete DatBan where stt = @stt";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@stt", stt));
                cmd.Parameters.Add(new SqlParameter("@maban", stt));
                cmd.Parameters.Add(new SqlParameter("@tenkh", ten));
                cmd.Parameters.Add(new SqlParameter("@soban", soluong));
                cmd.Parameters.Add(new SqlParameter("@soluong", soban));
                cmd.Parameters.Add(new SqlParameter("@thoigian", thoigian));
                int rs = (int)cmd.ExecuteNonQuery();
                if (rs == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    showData();
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi");

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}

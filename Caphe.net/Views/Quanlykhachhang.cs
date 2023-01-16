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
    public partial class Quanlykhachhang : UserControl
    {
        public Quanlykhachhang()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from quanlykhachhang";
            DataSet ds = new DataSet();
            SqlDataAdapter df = new SqlDataAdapter(sql, conn);
            df.Fill(ds, "quanlykhachhang");
            dgvDSKhachHang.DataSource = ds.Tables["quanlykhachhang"];
        }
        public static Quanlykhachhang kh = new Quanlykhachhang();

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbma.Text;
                string ten = txtten.Text;
                string dienthoai = txtdienthoai.Text;
                string email = txtemail.Text;
                string diachi = txtdiachi.Text;
                string sql = "insert into quanlykhachhang values (@makh, @hoten, @dienthoai, @email, @diachi)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makh", ma));
                cmd.Parameters.Add(new SqlParameter("@hoten", ten));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
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
                string ma = cbbma.Text;
                string ten = txtten.Text;
                string dienthoai = txtdienthoai.Text;
                string email = txtemail.Text;
                string diachi = txtdiachi.Text;
                string sql = "update quanlykhachhang set hoten=@hoten, dienthoai=@dienthoai, email=@email, diachi=@diachi where makh=@makh ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makh", ma));
                cmd.Parameters.Add(new SqlParameter("@hoten", ten));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
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
                string ma = cbbma.Text;
                string ten = txtten.Text;
                string dienthoai = txtdienthoai.Text;
                string email = txtemail.Text;
                string diachi = txtdiachi.Text;
                string sql = "delete quanlykhachhang where makh = @makh ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makh", ma));
                cmd.Parameters.Add(new SqlParameter("@hoten", ten));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
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

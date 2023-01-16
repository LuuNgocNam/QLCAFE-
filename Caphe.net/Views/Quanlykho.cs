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
    public partial class Quanlykho : UserControl
    {
        public Quanlykho()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from quanlykhohang";
            DataSet ds = new DataSet();
            SqlDataAdapter df = new SqlDataAdapter(sql, conn);
            df.Fill(ds, "quanlykhohang");
            dgvDSNguyenLieu.DataSource = ds.Tables["quanlykhohang"];
        }
        public static Quanlykho KH = new Quanlykho();

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbma.Text;
                string ten = txtten.Text;
                string ncc = txtncc.Text;
                string lh = txtlh.Text;
                string tgnv = txttime.Text;
                string slnv = txtslnv.Text;
                string slcl = txtslcl.Text;
                string dongia = txtdongia.Text;
                string sql = "insert into quanlykhohang values (@manl, @ten, @nhacc, @loai, @tgnv, @slnv, @slcl, @dongia)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", ma));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@nhacc", ncc));
                cmd.Parameters.Add(new SqlParameter("@loai", lh));
                cmd.Parameters.Add(new SqlParameter("@tgnv", tgnv));
                cmd.Parameters.Add(new SqlParameter("@slnv", slnv));
                cmd.Parameters.Add(new SqlParameter("@slcl", slcl));
                cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
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
                string ncc = txtncc.Text;
                string lh = txtlh.Text;
                string tgnv = txttime.Text;
                string slnv = txtslnv.Text;
                string slcl = txtslcl.Text;
                string dongia = txtdongia.Text;
                string sql = "update quanlykhohang set  ten=@ten, nhacc=@nhacc, loai=@loai, tgnv=@tgnv, slnv=@slnv, slcl=@slcl,dongia=@dongia where ma=@ma ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", ma));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@nhacc", ncc));
                cmd.Parameters.Add(new SqlParameter("@loai", lh));
                cmd.Parameters.Add(new SqlParameter("@tgnv", tgnv));
                cmd.Parameters.Add(new SqlParameter("@slnv", slnv));
                cmd.Parameters.Add(new SqlParameter("@slcl", slcl));
                cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
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
                string ncc = txtncc.Text;
                string lh = txtlh.Text;
                string tgnv = txttime.Text;
                string slnv = txtslnv.Text;
                string slcl = txtslcl.Text;
                string dongia = txtdongia.Text;
                string sql = "delete quanlykhohang where ma = @ma ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", ma));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@nhacc", ncc));
                cmd.Parameters.Add(new SqlParameter("@loai", lh));
                cmd.Parameters.Add(new SqlParameter("@tgnv", tgnv));
                cmd.Parameters.Add(new SqlParameter("@slnv", slnv));
                cmd.Parameters.Add(new SqlParameter("@slcl", slcl));
                cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
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

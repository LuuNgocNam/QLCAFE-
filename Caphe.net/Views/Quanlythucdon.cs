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
    public partial class Quanlythucdon : UserControl
    {
        public Quanlythucdon()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from quanlythucdon";
            DataSet ds = new DataSet();
            SqlDataAdapter df = new SqlDataAdapter(sql, conn);
            df.Fill(ds, "quanlythucdon");
            dgvDSThucDon.DataSource = ds.Tables["quanlythucdon"];
        }
        public static Quanlythucdon td = new Quanlythucdon();

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbma.Text;
                string loai = cbbloai.Text;
                string ten = txtten.Text;
                string soluong = txtslt.Text;
                string dongia = txtdg.Text;
                string trangthai = cbbtt.Text;
                string sql = "insert into quanlythucdon values (@Mãthựcđơn, @loạithựcđơn, @Tênthựcđơn, @Sốlượngtồn, @Đơngiá, @Trạngthái)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Mãthựcđơn", ma));
                cmd.Parameters.Add(new SqlParameter("@loạithựcđơn", loai));
                cmd.Parameters.Add(new SqlParameter("@Tênthựcđơn", ten));
                cmd.Parameters.Add(new SqlParameter("@Sốlượngtồn", soluong));
                cmd.Parameters.Add(new SqlParameter("@Đơngiá", dongia));
                cmd.Parameters.Add(new SqlParameter("@Trạngthái", trangthai));
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

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbma.Text;
                string ma1 = cbbma2.Text;
                string loai = cbbloai.Text;
                string ten = txtten.Text;
                string soluong = txtslt.Text;
                string dongia = txtdg.Text;
                string trangthai = cbbtt.Text;
                string sql = "insert into quanlythucdon values (@matd, @maloaitd, @loaitd, @ten, @soluongton, @dongia, @trangthai)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@matd", ma));
                cmd.Parameters.Add(new SqlParameter("@maloaitd", ma1));
                cmd.Parameters.Add(new SqlParameter("@loaitd", loai));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@soluongton", soluong));
                cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
                cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
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
                string ma1 = cbbma2.Text;
                string loai = cbbloai.Text;
                string ten = txtten.Text;
                string soluong = txtslt.Text;
                string dongia = txtdg.Text;
                string trangthai = cbbtt.Text;
                string sql = "update quanlythucdon set maloaitd=@maloaitd, loaitd=@loaitd, ten=@ten, soluongton=@soluongton, dongia=@dongia, trangthai=@trangthai where matd=@matd ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@matd", ma));
                cmd.Parameters.Add(new SqlParameter("@maloaitd", ma1));
                cmd.Parameters.Add(new SqlParameter("@loaitd", loai));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@soluongton", soluong));
                cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
                cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
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
                string ma1 = cbbma2.Text;
                string loai = cbbloai.Text;
                string ten = txtten.Text;
                string soluong = txtslt.Text;
                string dongia = txtdg.Text;
                string trangthai = cbbtt.Text;
                string sql = "delete quanlythucdon where matd = @matd";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@matd", ma));
                cmd.Parameters.Add(new SqlParameter("@maloaitd", ma1));
                cmd.Parameters.Add(new SqlParameter("@loaitd", loai));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@soluongton", soluong));
                cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
                cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
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

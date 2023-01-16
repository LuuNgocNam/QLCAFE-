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
    public partial class Hethongkhuvuc : UserControl
    {
        public Hethongkhuvuc()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from hethongkhuvuc";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "hethongkhuvuc");
            dgvDSKhuVuc.DataSource = ds.Tables["hethongkhuvuc"];
        }
        public static Hethongkhuvuc htkv = new Hethongkhuvuc();

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbma.Text;
                string ten = txtten.Text;
                string diengiai = txtdg.Text;
                string trangthai = cbbtt.Text;
                string sql = "insert into hethongkhuvuc values (@makv, @tenkv, @diengiai, @trangthai)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makv", ma));
                cmd.Parameters.Add(new SqlParameter("@tenkv", ten));
                cmd.Parameters.Add(new SqlParameter("@diengiai", diengiai));
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
                string ten = txtten.Text;
                string diengiai = txtdg.Text;
                string trangthai = cbbtt.Text;
                string sql = "update hethongkhuvuc set tenkv=@tenkv, diengiai=@diengiai, trangthai=@trangthai where makv=@makv ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makv", ma));
                cmd.Parameters.Add(new SqlParameter("@tenkv", ten));
                cmd.Parameters.Add(new SqlParameter("@diengiai", diengiai));
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
                string ten = txtten.Text;
                string diengiai = txtdg.Text;
                string trangthai = cbbtt.Text;
                string sql = "delete hethongkhuvuc where makv=@makv ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@makv", ma));
                cmd.Parameters.Add(new SqlParameter("@tenkv", ten));
                cmd.Parameters.Add(new SqlParameter("@diengiai", diengiai));
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

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
    public partial class Bankhuvuc : UserControl
    {
        public Bankhuvuc()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from bankhuvuc";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "bankhuvuc");
            dgvDSBan.DataSource = ds.Tables["bankhuvuc"];
        }
        public static Bankhuvuc bkv = new Bankhuvuc();

        private void Thêm_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbmab.Text;
                string ma1 = cbbmkv.Text;
                string tenban = cbbten.Text;
                string tenkv = cbbtenkv.Text;
                string trangthai = cbbtt.Text;
                string sql = "insert into bankhuvuc values (@maban, @makv, @tenban, @tenkv, @trangthai)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@maban", ma));
                cmd.Parameters.Add(new SqlParameter("@makv", ma1));
                cmd.Parameters.Add(new SqlParameter("@tenban", tenban));
                cmd.Parameters.Add(new SqlParameter("@tenkv", tenkv));
                cmd.Parameters.Add(new SqlParameter("trangthai", trangthai));
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

        private void Sửa_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbmab.Text;
                string ma1 = cbbmkv.Text;
                string tenban = cbbten.Text;
                string tenkv = cbbtenkv.Text;
                string trangthai = cbbtt.Text;
                string sql = "update bankhuvuc set makv=@makv, tenban=@tenban, tenkv=@tenkv, trangthai=@trangthai where maban=@maban ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@maban", ma));
                cmd.Parameters.Add(new SqlParameter("@makv", ma1));
                cmd.Parameters.Add(new SqlParameter("@tenban", tenban));
                cmd.Parameters.Add(new SqlParameter("@tenkv", tenkv));
                cmd.Parameters.Add(new SqlParameter("trangthai", trangthai));
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

        private void Xóa_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbmab.Text;
                string ma1 = cbbmkv.Text;
                string tenban = cbbten.Text;
                string tenkv = cbbtenkv.Text;
                string trangthai = cbbtt.Text;
                string sql = "delete bankhuvuc where maban = @maban ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@maban", ma));
                cmd.Parameters.Add(new SqlParameter("@makv", ma1));
                cmd.Parameters.Add(new SqlParameter("@tenban", tenban));
                cmd.Parameters.Add(new SqlParameter("@tenkv", tenkv));
                cmd.Parameters.Add(new SqlParameter("trangthai", trangthai));
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

        private void Lưu_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}

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
    public partial class QLNV : UserControl
    {
        public QLNV()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from quanlynhanvien";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "quanlynhanvien");
            dgvDSNhanVien.DataSource = ds.Tables["quanlynhanvien"];
        }
        public static QLNV nv = new QLNV();
        void nhung(Control ctr)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlDSNhanVien.Controls.Add(ctr);
            pnlDSNhanVien.Show();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Timkiemnhanvien find = new Timkiemnhanvien();
            nhung(find);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.None;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbma.Text;
                string ho = txtho.Text;
                string ten = txtten.Text;
                string chucvu = txtchucvu.Text;
                string ngaysinh = dtpngaysinh.Text;
                string gioitinh = cbbgt.Text;
                string dienthoai = txtdienthoai.Text;
                string diachi = txtdiachi.Text;
                string sql = "insert into quanlynhanvien values (@manv, @ho, @ten, @chucvu, @ngaysinh, @gioitinh, @dienthoai, @diachi)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", ma));
                cmd.Parameters.Add(new SqlParameter("@ho", ho));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbma.Text;
                string ho = txtho.Text;
                string ten = txtten.Text;
                string chucvu = txtchucvu.Text;
                string ngaysinh = dtpngaysinh.Text;
                string gioitinh = cbbgt.Text;
                string dienthoai = txtdienthoai.Text;
                string diachi = txtdiachi.Text;
                string sql = "update quanlynhanvien set ho=@ho, ten=@ten, chucvu=@chucvu, ngaysinh=@ngaysinh, gioitinh=@gioitinh, dienthoai=@dienthoai, diachi=@diachi where manv=@manv ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", ma));
                cmd.Parameters.Add(new SqlParameter("@ho", ho));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Lưu ý!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbma.Text;
                string ho = txtho.Text;
                string ten = txtten.Text;
                string chucvu = txtchucvu.Text;
                string ngaysinh = dtpngaysinh.Text;
                string gioitinh = cbbgt.Text;
                string dienthoai = txtdienthoai.Text;
                string diachi = txtdiachi.Text;
                string sql = "delete quanlynhanvien where manv = @manv ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", ma));
                cmd.Parameters.Add(new SqlParameter("@ho", ho));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}

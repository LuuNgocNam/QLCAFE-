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

namespace Caphe.net
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            string tk = txttk.Text;
            string mk = txtmk.Text;
            string sql = "select count(*) from nguoidung where taikhoan = @taikhoan and matkhau = @matkhau";
            int rs = 0;
            try
            {
                SqlConnection conn = new SqlConnection(conn_str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@taikhoan", tk));
                cmd.Parameters.Add(new SqlParameter("@matkhau", mk));
                rs = (int)cmd.ExecuteScalar();
                conn.Close();
                if (rs == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!!");
                    Form Main = new frmMain();
                    Main.Show();
                    Visible = false;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("err :" + ex.Message);
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangky dky = new Dangky();
            dky.ShowDialog();
        }
    }
}

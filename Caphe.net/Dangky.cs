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
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                String tk = txttk.Text;
                String mk = txtmk.Text;
                string sql = "insert into NguoiDung values (@tk, @mk)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                int rs = (int)cmd.ExecuteNonQuery();
                if (rs == 1)
                {
                    MessageBox.Show("Đăng ký thành công!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ!!");

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dangnhap dn = new Dangnhap();
            dn.ShowDialog();
        }
    }
}

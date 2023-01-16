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
    public partial class GoiMon : UserControl
    {
        public GoiMon()
        {
            InitializeComponent();

        }
        public static GoiMon gm = new GoiMon();
        void nhung(Control ctr)
        {
            pnlGoiMon.Controls.Clear();
            pnlGoiMon.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(ctr);
            pnlGoiMon.Show();
        }
        void nhung1(Control ctr)
        {
            Pnl2.Controls.Clear();
            Pnl2.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            Pnl2.Controls.Add(ctr);
            Pnl2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void Ban16_Click(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }



        //load textbox theo combobox
        private void cbbten_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //SqlDataAdapter df = new SqlDataAdapter(sql, conn);
            //df.Fill(ds, "123");
            //txtdg.Text = ds.Tables["123"].Rows[0]["dongia"].ToString();
            //txtmatd.Text = ds.Tables["123"].Rows[0]["matd"].ToString();
        }



        private void MENU_Click_1(object sender, EventArgs e)
        {
            MENU mn = new MENU();
            nhung(mn);
            MNdatban db = new MNdatban();
            nhung1(db);
        }

        private void btnDatban_Click_1(object sender, EventArgs e)
        {
            DatBan db1 = new DatBan();
            nhung(db1);
        }

        private void btnHoaDon_Click_1(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            nhung1(hd);
        }

        private void ban1_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
            ban1.BackColor = Color.White;
            ban1.ForeColor = Color.Black;
        }

        private void ban2_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban3_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban4_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban5_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban6_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban7_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban8_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban9_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban10_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban11_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban12_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban13_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban14_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void ban15_Click_1(object sender, EventArgs e)
        {
            Thanhtoan tt = new Thanhtoan();
            tt.ShowDialog();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbmahd.Text;
                string ma1 = txtmatd.Text;
                string ma2 = cbbmanv.Text;
                string ten = cbbten.Text;
                string dongia = txtdg.Text;
                string sl = txtsl.Text;
                string sb = this.txtsb.Text;
                int tt = 0;
                string sql = "insert into HoaDon values (@mahd, @matd, @manv, @ten, @dongia, @soluong,@soban,@thanhtien)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", ma));
                cmd.Parameters.Add(new SqlParameter("@matd", ma1));
                cmd.Parameters.Add(new SqlParameter("@manv", ma2));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
                cmd.Parameters.Add(new SqlParameter("@soluong", sl));
                cmd.Parameters.Add(new SqlParameter("@soban", sb));
                cmd.Parameters.Add(new SqlParameter("@thanhtien", tt));
                int rs = (int)cmd.ExecuteNonQuery();
                if (rs == 1)
                {
                    MessageBox.Show("Tạo hóa đơn thành công!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi!!");
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
            if (MessageBox.Show("Bạn có muốn xóa không?", "Lưu ý!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                    SqlConnection conn = new SqlConnection(conn_str);
                    string ma = cbbmahd.Text;
                    string ma1 = txtmatd.Text;
                    string ma2 = cbbmanv.Text;
                    string ten = cbbten.Text;
                    string dongia = txtdg.Text;
                    string sl = txtsl.Text;
                    string sb = this.txtsb.Text;
                    int tt = 0;
                    string sql = "delete HoaDon where mahd = @mahd ";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@mahd", ma));
                    cmd.Parameters.Add(new SqlParameter("@matd", ma1));
                    cmd.Parameters.Add(new SqlParameter("@manv", ma2));
                    cmd.Parameters.Add(new SqlParameter("@ten", ten));
                    cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
                    cmd.Parameters.Add(new SqlParameter("@soluong", sl));
                    cmd.Parameters.Add(new SqlParameter("@soban", sb));
                    cmd.Parameters.Add(new SqlParameter("@thanhtien", tt));
                    int rs = (int)cmd.ExecuteNonQuery();
                    if (rs == 1)
                    {
                        MessageBox.Show("Xóa thành công");

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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                string ma = cbbmahd.Text;
                string ma1 = txtmatd.Text;
                string ma2 = cbbmanv.Text;
                string ten = cbbten.Text;
                string dongia = txtdg.Text;
                string sl = txtsl.Text;
                string sb = this.txtsb.Text;
                int tt = 0;
                string sql = "update HoaDon set matd=@matd, ten=@ten, dongia=@dongia, soluong=@soluong, soban=@soban, thanhtien=@thanhtien where mahd=@mahd ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", ma));
                cmd.Parameters.Add(new SqlParameter("@matd", ma1));
                cmd.Parameters.Add(new SqlParameter("@manv", ma2));
                cmd.Parameters.Add(new SqlParameter("@ten", ten));
                cmd.Parameters.Add(new SqlParameter("@dongia", dongia));
                cmd.Parameters.Add(new SqlParameter("@soluong", sl));
                cmd.Parameters.Add(new SqlParameter("@soban", sb));
                cmd.Parameters.Add(new SqlParameter("@thanhtien", tt));
                int rs = (int)cmd.ExecuteNonQuery();
                if (rs == 1)
                {
                    MessageBox.Show("Sửa thành công");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cbbten_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            string tenmon = cbbten.Text;
            string sql = "select * from quanlythucdon where ten = '"+tenmon+"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                txtdg.Text = reader["dongia"].ToString();
                txtmatd.Text = reader["matd"].ToString();
            }

        }
    }
}

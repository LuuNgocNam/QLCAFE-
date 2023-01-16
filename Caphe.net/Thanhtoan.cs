using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Caphe.net
{
    public partial class Thanhtoan : Form
    {
        public Thanhtoan()
        {
            InitializeComponent();
        }
        private void showData(string soban)
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from HoaDon where soban = '" + soban + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "HoaDon");
            dgvThanhToan.DataSource = ds.Tables["HoaDon"];
            int sum = 0;
            for (int i = 0; i < ds.Tables["HoaDon"].Rows.Count; i++)
            {
                sum += Convert.ToInt32(ds.Tables["HoaDon"].Rows[i]["thanhtien"].ToString());
            }

            displaytt.Text = "" + sum;
        }

        //public void GetTT()
        //{
        //    double Gettt = 0;
        //    for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
        //    {
        //        Console.WriteLine(dgvThanhToan.Rows[i].Cells["Thànhtiền"].Value.ToString());
        //        Gettt = Gettt + double.Parse(dgvThanhToan.Rows[i].Cells["Thànhtiền"].Value.ToString());
        //    }
        //    displaytt.Text = Gettt.ToString();

        //}


        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            //GetTT();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String soban = cbbsb.SelectedItem.ToString();
            showData("1");
            showData(soban);
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            string soban = cbbsb.Text;
            String sql = "delete HoaDon where soban = @soban";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@soban", soban));
            int rs = (int)cmd.ExecuteNonQuery();
            if (rs == 1)
            {
                MessageBox.Show("Thanh toán thành công");
                showData("1");
                return;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

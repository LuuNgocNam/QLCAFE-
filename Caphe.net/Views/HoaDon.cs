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
    public partial class HoaDon : UserControl
    {
        public HoaDon()
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
            dgvHoaDon.DataSource = ds.Tables["HoaDon"];
            int sum = 0;
            for (int i = 0; i < ds.Tables["HoaDon"].Rows.Count; i++)
            {
                sum += Convert.ToInt32(ds.Tables["HoaDon"].Rows[i]["thanhtien"].ToString());
            }

            displaytt.Text = "" + sum;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void cbbsb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String soban = cbbsb.SelectedItem.ToString();
            showData(soban);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            string soban = cbbsb.Text;
            conn = new SqlConnection(conn_str);
            DataSet ds = new DataSet();
            string sql = "select * from HoaDon where soban like '%' + @soban + '%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@soban", soban));
            da.Fill(ds, "HoaDon");
            dgvHoaDon.DataSource = ds.Tables["HoaDon"];
        }
    }
}

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
    public partial class Monyeuthich : UserControl
    {
        public Monyeuthich()
        {
            InitializeComponent();
        }
        public static Monyeuthich myt = new Monyeuthich();
        private void showData(string tenmon)
        {
            String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            String sql = "select * from monuathich where tentd = '" + tenmon + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "monuathich");
            dgv1.DataSource = ds.Tables["monuathich"];
            int sum = 0;
            for (int i = 0; i < ds.Tables["monuathich"].Rows.Count; i++)
            {
                sum += Convert.ToInt32(ds.Tables["monuathich"].Rows[i]["doanhthu"].ToString());
            }

            displaytt.Text = "" + sum;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String conn_str = "Data Source =DESKTOP-27UGJ33; Initial catalog=quanlycaphe;User ID =sa;Password = 123456";
                SqlConnection conn = new SqlConnection(conn_str);
                System.Data.DataTable dt = new System.Data.DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from  monuathich", conn);
                conn.Open();
                da.Fill(dt);

                conn.Close();
                MessageBox.Show("thanh cong");
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên món";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Số lượng";
                chart1.ChartAreas.Add("EX");
                chart1.Series["soluong"]["DrawingStyle"] = "Cylinder";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["soluong"].Points.AddXY(dt.Rows[i]["tentd"], dt.Rows[i]["soluong"]);
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tenmon = cbbmonan.SelectedItem.ToString();
            showData(tenmon);
        }

        private void change_Click(object sender, EventArgs e)
        {
        }
    }
}

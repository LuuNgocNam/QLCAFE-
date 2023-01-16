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
    public partial class MNdatban : UserControl
    {
        public MNdatban()
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
            SqlDataAdapter df = new SqlDataAdapter(sql, conn);
            df.Fill(ds, "bankhuvuc");
            dgvdatban1.DataSource = ds.Tables["bankhuvuc"];
        }
    }
}

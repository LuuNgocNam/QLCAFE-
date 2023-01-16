using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caphe.net
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();

        public void ThemTabPages(UserControl uct, byte typeControl, String tenTab)
        {
            //Kiểm tra tồn tại trang này chưa
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        //Đóng tab hiện tại 
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        //Đóng all tab
        public void DongAllTab()
        {
            while(TabHienThi.TabPages.Count>0)
            {
                DongTabHienTai();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemTabPages(Views.QLNV.nv, 4, "Quản lý nhân viên");
        }

        private void đóngTrangHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngTấtCảCácTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Quanlykhachhang.kh, 4, "Quản lý khách hàng");
        }

        private void quảnLýKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Quanlykhuyenmai.km, 4, "Quản lý khuyến mãi");
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Quanlykho.KH, 4, "Quản lý kho");
        }

        private void bànKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Bankhuvuc.bkv, 4, "Bàn khu vực");
        }

        private void hệThốngKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Hethongkhuvuc.htkv, 4, "Hệ thống khu vực");
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Quanlyloaithucdon.ltd, 4, "Quản lý thực đơn");

        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.GoiMon.gm, 4, "Bán hàng");
        }

        private void danhSáchThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Quanlythucdon.td, 4, "Danh sách thực đơn");
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Lienhe.lh, 4, "Liên hệ");
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Gioithieu.gt, 4, "Giới thiệu");
        }

        private void tuyểnDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Tuyendung.td, 4, "Tuyển dụng");
        }

        private void thốngKêNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Luongnhanvien.lnv, 4, "Lương nhân viên");
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Baocaothongke.bctk, 4, "Báo cáo thống kê");
        }

        private void mónĂnĐượcYêuThíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.Monyeuthich.myt, 4, "Món yêu thích");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaThuocTay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Program.chucvu== "Nhân Viên")
            {
                btnNhaCungCap.Enabled = false;
                btnNhapHang.Enabled = false;
                btnQLNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
                btnThuoc.Enabled = false;
            }    
            label1.Text = "Xin chào " + Program.tennv;
            label3.Text = "Ngày: " +System.DateTime.Now.ToString();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            this.Hide();
            frm.Show();

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            this.Hide();
            frm.Show();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
          
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            frmThuoc t = new frmThuoc();
            this.Hide();
            t.ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang bh = new frmBanHang();
            this.Hide();
            bh.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn thoát!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult.Yes == thongbao)
            {
                frmDangNhap frm = new frmDangNhap();
                this.Hide();
                frm.Show();
            }    
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang();
            this.Hide();
            frm.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKeNgay frm = new frmThongKeNgay();
            this.Hide();
            frm.Show();
        }
    }
}

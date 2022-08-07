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
    public partial class frmDangNhap : Form
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text !="" &&txtMatKhau.Text !="")
            {
                var dangNhap = (from dm in ntt.NhanViens where dm.MaNV.Equals(txtTaiKhoan.Text) && dm.MatKhau.Equals(txtMatKhau.Text) select dm).FirstOrDefault();
                
                if (dangNhap != null)
                {
                    Program.tennv = dangNhap.TenNV;
                    Program.manv = txtTaiKhoan.Text.Trim();
                    Program.chucvu = dangNhap.ChucVu;
                    MessageBox.Show("Đăng nhập thành công");
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Sai Tên tài khoản hoặc mất khẩu!!");
                    Reset();
                    txtTaiKhoan.Focus();
                }    
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được bỏ trống");
                txtTaiKhoan.Focus();
            }
           
                
        }
        public void Reset()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongBao = MessageBox.Show("Bạn muốn thoát chương trình", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           if(thongBao == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void ckb_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_HienThi.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

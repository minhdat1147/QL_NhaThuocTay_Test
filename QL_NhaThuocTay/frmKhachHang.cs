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
    public partial class frmKhachHang : Form
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        KhachHang_SP kh = new KhachHang_SP();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTen.Text != "" && dtpNgaySinh.Text != "" && txtGioiTinh.Text != "" && txtDiaChi.Text !="" && txtSDT.Text !="" && txtBenhAn.Text !="")
            {
                if (kh.them(txtMaKH.Text, txtTen.Text,dtpNgaySinh.Value,txtGioiTinh.Text, txtDiaChi.Text, Convert.ToInt32(txtSDT.Text),txtBenhAn.Text) == 1)
                {
                    MessageBox.Show("Thêm Thành công");
                }

                else
                {
                    MessageBox.Show("Trùng mã nhân viên!!");
                }

                dataGridView1.DataSource = kh.getDs();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (kh.xoa(txtMaKH.Text) == 1)
            {
                MessageBox.Show("Xóa Thành công");
                dataGridView1.DataSource = kh.getDs();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kh.sua(txtMaKH.Text, txtTen.Text, dtpNgaySinh.Value, txtGioiTinh.Text, txtDiaChi.Text, Convert.ToInt32(txtSDT.Text), txtBenhAn.Text) == 1)
            {
                MessageBox.Show("Sửa Thành công");
                dataGridView1.DataSource = kh.getDs();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaKH.Text = dataGridView1[0, li].Value.ToString();
            txtTen.Text = dataGridView1[1, li].Value.ToString();
            dtpNgaySinh.Text = dataGridView1[2, li].Value.ToString();
            txtGioiTinh.Text = dataGridView1[3, li].Value.ToString();
            txtDiaChi.Text = dataGridView1[4, li].Value.ToString();
            txtSDT.Text = dataGridView1[5, li].Value.ToString();
            txtBenhAn.Text = dataGridView1[6, li].Value.ToString();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kh.getDs();
        }
    }
}

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
    public partial class frmLoaiThuoc : Form
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        LoaiThuoc loai = new LoaiThuoc();
        public frmLoaiThuoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaLoai.Text !="" && txtTenLoai.Text !="" && txtMaNCC.Text !="")
            {
                if(loai.them(txtMaLoai.Text,txtTenLoai.Text,txtMaNCC.Text)==1)
                {
                    MessageBox.Show("Thêm thành công");
                }    
                else
                {
                    MessageBox.Show("Trùng Mã Loại!!, thêm không thành công!","Thông Báo");
                }
                dgvDSLoai.DataSource = loai.getLoai();

            }   
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }    
        }

        private void dgvDSLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaLoai.Text = dgvDSLoai[0, li].Value.ToString();
            txtTenLoai.Text = dgvDSLoai[1, li].Value.ToString();
            txtMaNCC.Text = dgvDSLoai[2, li].Value.ToString();
        }

        private void frmLoaiThuoc_Load(object sender, EventArgs e)
        {
            dgvDSLoai.DataSource = loai.getLoai();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThuoc frm = new frmThuoc();
            this.Hide();
            frm.Show();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if(loai.xoa(txtMaLoai.Text)==1)
            {
                MessageBox.Show("Xóa thành công");
            }    
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            }
            dgvDSLoai.DataSource = loai.getLoai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text != "" && txtTenLoai.Text != "" && txtMaNCC.Text != "")
            {
                if (loai.sua(txtMaLoai.Text, txtTenLoai.Text, txtMaNCC.Text) == 1)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!", "Thông Báo");
                }
                dgvDSLoai.DataSource = loai.getLoai();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
        }
    }
}

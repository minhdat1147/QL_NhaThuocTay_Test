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
    public partial class frmNhaCungCap : Form
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        NhaCC ncc = new NhaCC();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != "" && txtTen.Text != "" && txtDiachi.Text != "" && txtSDt.Text != "")
            {
                if (ncc.them(txtMaNCC.Text, txtTen.Text, txtDiachi.Text, Convert.ToInt32(txtSDt.Text))== 1)
                {
                    MessageBox.Show("Thêm Thành công");
                }

                else
                {
                    MessageBox.Show("Trùng mã nhà cung cấp!!","Thông báo");
                }

                dataGridView1.DataSource = ncc.getLoai();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ncc.getLoai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ncc.sua(txtMaNCC.Text, txtTen.Text, txtDiachi.Text, Convert.ToInt32(txtSDt.Text)) == 1)
            {
                MessageBox.Show("Sửa Thành công");
                dataGridView1.DataSource = ncc.getLoai();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ncc.xoa(txtMaNCC.Text) == 1)
            {
                MessageBox.Show("Xóa Thành công");
                dataGridView1.DataSource = ncc.getLoai();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }

        private void btnDSPN_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaNCC.Text = dataGridView1[0, li].Value.ToString();
            txtTen.Text = dataGridView1[1, li].Value.ToString();
            txtDiachi.Text = dataGridView1[2, li].Value.ToString();
            txtSDt.Text = dataGridView1[3, li].Value.ToString();
        }
    }
}

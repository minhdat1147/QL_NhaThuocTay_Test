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
    public partial class frmThuoc : Form
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        Thuoc_DAL thuoc1 = new Thuoc_DAL();
        public frmThuoc()
        {
            InitializeComponent();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NhaThuocTayDataSet.LOAITHUOC' table. You can move, or remove it, as needed.
            this.lOAITHUOCTableAdapter.Fill(this.qL_NhaThuocTayDataSet.LOAITHUOC);
            dataGridView1.DataSource = thuoc1.getLoai();
            cboMaLoai.Text = "Tất cả";
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = thuoc1.timkiem(cboLoaiSP.SelectedValue.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMT.Text != "" && txtTen.Text != "" && cboMaLoai.Text != ""&& txtGia.Text !="" && cboDVT.Text != "" && comboBox1.Text !="")
            {
                if (thuoc1.them(txtMT.Text, txtTen.Text,cboDVT.Text, Convert.ToInt32(txtGia.Text),comboBox1.Text, cboMaLoai.Text) == 1)
                {
                    MessageBox.Show("Thêm Thành công");
                }

                else
                {
                    MessageBox.Show("Trùng mã nhà cung cấp!!", "Thông báo");
                }

                dataGridView1.DataSource = thuoc1.getLoai();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMT.Text = dataGridView1[0, li].Value.ToString();
            txtTen.Text = dataGridView1[1, li].Value.ToString();
            cboDVT.Text = dataGridView1[2, li].Value.ToString();
            txtGia.Text = dataGridView1[3, li].Value.ToString();
            comboBox1.Text = dataGridView1[4, li].Value.ToString();
            cboMaLoai.Text = dataGridView1[5, li].Value.ToString();
        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (thuoc1.xoa(txtMT.Text) == 1)
            {
                MessageBox.Show("Xóa Thành công");
               
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            } 
            dataGridView1.DataSource = thuoc1.getLoai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (thuoc1.sua(txtMT.Text, txtTen.Text, cboDVT.Text, Convert.ToInt32(txtGia.Text), comboBox1.Text, cboMaLoai.Text) == 1)
            {
                MessageBox.Show("Sửa Thành công");
               
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            } 
            dataGridView1.DataSource = thuoc1.getLoai();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLoaiThuoc frm = new frmLoaiThuoc();
            this.Hide();
            frm.Show();
        }
    }
}

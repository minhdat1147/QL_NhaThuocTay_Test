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
    public partial class frmNhanVien : Form
    {

        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        NhanVien_NTT nv = new NhanVien_NTT();
        public static List<QL_NhaThuocTay.NhanVien> ds;
        public frmNhanVien()
        {

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {   
            if(txtMaNV.Text !=""&& txtTenNV.Text !="" && cboGT.Text != "" && txtDiaChi.Text != "" && txtSDT.Text !="" && txtCCCD.Text !="" && cboCV.Text != ""&& txtMatKhau.Text !="")
            {
                if (nv.them(txtMaNV.Text, txtTenNV.Text, dtNS.Value,cboGT.Text, txtDiaChi.Text, Convert.ToInt32(txtSDT.Text), Convert.ToInt32(txtCCCD.Text),cboCV.Text,txtMatKhau.Text) == 1)
                {
                    MessageBox.Show("Thêm Thành công");
                }    
               
                else
                {
                    MessageBox.Show("Trùng mã nhân viên!!");
                }    
                
                dataGridView1.DataSource = nv.getLoai();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
           
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.getLoai();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaNV.Text = dataGridView1[0, li].Value.ToString();
            txtTenNV.Text = dataGridView1[1, li].Value.ToString();
            dtNS.Text = dataGridView1[2, li].Value.ToString();
            cboGT.Text = dataGridView1[3, li].Value.ToString();
            txtDiaChi.Text = dataGridView1[4, li].Value.ToString();
            txtSDT.Text = dataGridView1[5, li].Value.ToString();
            txtCCCD.Text = dataGridView1[6, li].Value.ToString();
            cboCV.Text = dataGridView1[7, li].Value.ToString();
            //txtMatKhau.Text = dataGridView1[8, li].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (nv.sua(txtMaNV.Text, txtTenNV.Text, dtNS.Value, cboGT.Text, txtDiaChi.Text, Convert.ToInt32(txtSDT.Text), Convert.ToInt32(txtCCCD.Text), cboCV.Text, txtMatKhau.Text) == 1)
            {
                MessageBox.Show("Sửa Thành công");
                dataGridView1.DataSource = nv.getLoai();
                //Reset();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }    
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(nv.xoa(txtMaNV.Text)==1)
            {
                MessageBox.Show("Xóa Thành công");
                dataGridView1.DataSource = nv.getLoai();
                //Reset();
            }   
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.timkiem(textBox1.Text);
        }
    }
}

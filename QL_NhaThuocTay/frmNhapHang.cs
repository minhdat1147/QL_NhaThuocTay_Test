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
    public partial class frmNhapHang : Form
    {
        NhapHang pn = new NhapHang();
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        string mathuoc = "";
        int gia = 0;
        int thanhtien = 0;
        string dvt = "";
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NhaThuocTayDataSet.LOAITHUOC' table. You can move, or remove it, as needed.
            this.lOAITHUOCTableAdapter.Fill(this.qL_NhaThuocTayDataSet.LOAITHUOC);
            txtMaCTPN.Enabled = false;
            cboTenLoai.Text = "Hãy chọn loại thuốc";
            cboTenThuoc.Text = "Hãy chọn thuốc";

            txtGia.Text = "0";
            txtTT.Text = "0";
            numericUpDown1.Value = 1;
            txtGia.Enabled = false;
            txtTT.Enabled = false;

        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            pn.taoPN();
            List<PhieuNhap> lstPN = new List<PhieuNhap>();

            int mapn = 0;
            lstPN = pn.laymaPN();
            foreach (var a in lstPN)
            {
                mapn = a.MaPN;
            }
            txtMaCTPN.Text = mapn.ToString();
        }

        private void cboTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTenThuoc.Items.Clear();
            loadCbo();
            if (cboTenThuoc.SelectedItem == null)
            {
                return;
            }
            cboTenThuoc.Text = "Hãy chọn thuốc";
        }
        public void reset()
        {
            cboTenLoai.Text = "Hãy chọn loại thuốc";
            cboTenThuoc.Text = "Hãy chọn thuốc";
            cboTenThuoc.SelectedItem = "Hãy chọn thuốc";
            txtDVT.Text = "";
            txtGia.Text = "0";
            txtTT.Text = "0";
            numericUpDown1.Value = 1;
        }
        public void LoadDaTa()
        {
            dgvPN.DataSource = pn.getLoai(int.Parse(txtMaCTPN.Text));
            dgvPN.Columns["PhieuNhap"].Visible = false;

            dgvPN.Columns[0].HeaderText = "Mã hóa đơn";
            dgvPN.Columns[1].HeaderText = "Tên loại thuốc";
            dgvPN.Columns[2].HeaderText = "Tên thuốc";
            dgvPN.Columns[3].HeaderText = "Số lượng";
            dgvPN.Columns[4].HeaderText = "DVT";
            dgvPN.Columns[5].HeaderText = "Đơn giá";
            dgvPN.Columns[6].HeaderText = "Thành tiền";

        }

        public void loadCbo()
        {
            List<Thuoc> lstThuoc = new List<Thuoc>();


            lstThuoc = pn.laycombox(cboTenLoai.SelectedValue.ToString());
            foreach (var a in lstThuoc)
            {
                cboTenThuoc.Items.Add(a.TenThuoc);

            }

        }
        public void updateTT()
        {
            List<ChiTietPN> lstpn = new List<ChiTietPN>();
            lstpn = pn.UDTongTien(Convert.ToInt32(txtMaCTPN.Text));
            foreach (var a in lstpn)
            {
                int tien = 0;
                tien = tien + Convert.ToInt32(a.THANHTIEN);
                Program.tongtien = tien;

            }

        }
        private void cboTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = (from s in ntt.Thuocs where s.TenThuoc.Equals(cboTenThuoc.SelectedItem.ToString()) select s);


            foreach (var a in q)
            {
                mathuoc = a.MaThuoc;
                gia = Convert.ToInt32(a.DonGia);
                dvt = a.DVT;
            }
            int sl = int.Parse(numericUpDown1.Value.ToString());
            thanhtien = sl * gia;
            txtGia.Text = gia.ToString();
            txtTT.Text = thanhtien.ToString();
            txtDVT.Text = dvt;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int sl = int.Parse(numericUpDown1.Value.ToString());
            thanhtien = sl * gia;
            txtGia.Text = gia.ToString();
            txtTT.Text = thanhtien.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCTPN.Text != "" && cboTenLoai.Text != "" && cboTenThuoc.Text != "" && numericUpDown1.Text != "" && txtDVT.Text != "" && txtGia.Text != "" && txtTT.Text != "")
            {
                int sl = Convert.ToInt32(numericUpDown1.Value.ToString());
                if (pn.themPN(Convert.ToInt32(txtMaCTPN.Text), cboTenLoai.SelectedValue.ToString(), mathuoc, sl, txtDVT.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtTT.Text)) == 1)
                {
                    MessageBox.Show("Thêm Thành công");
                    pn.themTam(Convert.ToInt32(txtMaCTPN.Text), cboTenLoai.Text.ToString(), cboTenThuoc.Text.ToString(), sl, txtDVT.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtTT.Text));
                    LoadDaTa();
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm Hóa đơn không thành công!!");
                }

            }
        }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaCTPN.Text = dgvPN[0, li].Value.ToString();
            cboTenLoai.Text = dgvPN[1, li].Value.ToString();
            cboTenThuoc.Text = dgvPN[2, li].Value.ToString();
            numericUpDown1.Text = dgvPN[3, li].Value.ToString();
            txtDVT.Text = dgvPN[4, li].Value.ToString();
            txtGia.Text = dgvPN[5, li].Value.ToString();
            txtTT.Text = dgvPN[6, li].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (pn.xoaPN(Convert.ToInt32(txtMaCTPN.Text), cboTenLoai.SelectedValue.ToString(), mathuoc) == 1)
            {
                MessageBox.Show("Xóa Thành công");
                pn.xoaPNTam1(Convert.ToInt32(txtMaCTPN.Text), cboTenLoai.Text, cboTenThuoc.Text);
                LoadDaTa();
                reset();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(numericUpDown1.Value.ToString());
            if (pn.suapn(Convert.ToInt32(txtMaCTPN.Text), cboTenLoai.SelectedValue.ToString(), mathuoc, sl, txtDVT.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtTT.Text)) == 1)
            {

                MessageBox.Show("Sửa Thành công");
                pn.suaPNTam(Convert.ToInt32(txtMaCTPN.Text), cboTenLoai.Text.ToString(), cboTenThuoc.Text, sl, txtDVT.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtTT.Text));
                LoadDaTa();
                reset();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }
    }
}

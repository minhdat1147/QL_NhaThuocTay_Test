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
    public partial class frmBanHang : Form
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        BanHang hd = new BanHang();
        string mathuoc = "";
        int gia = 0;
        int thanhtien = 0;
        string dvt = "";
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            hd.taoHD();
            List<HoaDon> lstHD = new List<HoaDon>();
            
            int mahd = 0;
            lstHD=hd.laymaHD();
            foreach(var a in lstHD)
            {
                mahd = a.MaHD;
            }
            txtMaCTHD.Text = mahd.ToString();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NhaThuocTayDataSet1.LOAITHUOC' table. You can move, or remove it, as needed.
            this.lOAITHUOCTableAdapter.Fill(this.qL_NhaThuocTayDataSet1.LOAITHUOC);
            txtMaCTHD.Enabled = false;
            cboTenLoai.Text = "Hãy chọn loại thuốc";
            cboTenThuoc.Text = "Hãy chọn thuốc";
            button1.Enabled = false;
            txtGia.Text = "0";
            txtTT.Text = "0";
            numericUpDown1.Value = 1;
            txtGia.Enabled = false;
            txtTT.Enabled = false;
            textBox1.Enabled = false;
            txtTienKhachDua.Text = "0";
            txtTienThua.Text = "0";
            txtTienThua.Enabled = false;
            txtTienKhachDua.Enabled = false;
        }
        public void reset()
        {
            cboTenLoai.Text = "Hãy chọn loại thuốc";  
            cboTenThuoc.Text = "Hãy chọn thuốc";
            cboTenThuoc.SelectedItem = "Hãy chọn thuốc";
            textBox1.Text = "";
            txtGia.Text = "0";
            txtTT.Text = "0";
            txtTienKhachDua.Text = "0";
            txtTienThua.Text = "0";
            numericUpDown1.Value = 1;
            
        }
        public void LoadDaTa()
        {
            dgvBH.DataSource = hd.getLoai(int.Parse(txtMaCTHD.Text));
            dgvBH.Columns["Hoadon"].Visible = false;
     
            dgvBH.Columns[0].HeaderText = "Mã hóa đơn";
            dgvBH.Columns[1].HeaderText = "Tên loại thuốc";
            dgvBH.Columns[2].HeaderText = "Tên thuốc";
            dgvBH.Columns[3].HeaderText = "Số lượng";
            dgvBH.Columns[4].HeaderText = "DVT";
            dgvBH.Columns[5].HeaderText = "Đơn giá";
            dgvBH.Columns[6].HeaderText = "Thành tiền";

        }

        public void loadCbo()
        {
            List<Thuoc> lstThuoc = new List<Thuoc>();

           
            lstThuoc = hd.laycombox(cboTenLoai.SelectedValue.ToString());
            foreach (var a in lstThuoc)
            {
                cboTenThuoc.Items.Add(a.TenThuoc);
               
            }

        }
        public void updateTT()
        {
            List<ChiTietHD> lsthd = new List<ChiTietHD>();
            lsthd = hd.UDTongTien(Convert.ToInt32(txtMaCTHD.Text));
            foreach (var a in lsthd)
            {
                int tien = 0;
                tien = tien + Convert.ToInt32(a.THANHTIEN);
                Program.tongtien = tien;

            }

        }
        private void cboTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTenThuoc.Items.Clear();
            loadCbo();
            if(cboTenThuoc.SelectedItem==null)
            {
                return;
            }
            cboTenThuoc.Text = "Hãy chọn thuốc";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            textBox1.Text = dvt;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int sl = int.Parse(numericUpDown1.Value.ToString());
            
            thanhtien = sl * gia ;
            txtGia.Text = gia.ToString();
            txtTT.Text = thanhtien.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDown1.Value.ToString()) == 0)
            {
                MessageBox.Show("Thêm không thành công! Vui lòng kiểm tra lại nhập liệu!");
                return;
            }
            txtTienKhachDua.Enabled = true;
            if(txtMaCTHD.Text !="" && cboTenLoai.Text !="" && cboTenThuoc.Text !="" && numericUpDown1.Text != ""&& textBox1.Text !="" && txtGia.Text !=""&& txtTT.Text !="")
            {
                int sl = Convert.ToInt32(numericUpDown1.Value.ToString());
                if(hd.themCTHD(Convert.ToInt32(txtMaCTHD.Text), cboTenLoai.SelectedValue.ToString(),mathuoc,sl, textBox1.Text,Convert.ToInt32(txtGia.Text),Convert.ToInt32(txtTT.Text))==1)
                {
                    MessageBox.Show("Thêm Thành công");

                    hd.themTam(Convert.ToInt32(txtMaCTHD.Text), cboTenLoai.Text.ToString(), cboTenThuoc.Text.ToString(), sl, textBox1.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtTT.Text));
                    LoadDaTa();
                    reset();
                    int sc = dgvBH.Rows.Count;
                    float thanhtien = 0;
                    for (int i = 0; i < sc; i++)
                        thanhtien += float.Parse(dgvBH.Rows[i].Cells["thanhtien"].Value.ToString());
                    txtTT.Text = thanhtien.ToString();
                }
                else
                {
                    MessageBox.Show("Thêm Hóa đơn không thành công!!");
                }
                
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<ChiTietHD> lsthd = new List<ChiTietHD>();
            lsthd = hd.UDTongTien(Convert.ToInt32(txtMaCTHD.Text));
            int tien = 0;
            foreach (var b in lsthd)
            {              
                tien = tien + Convert.ToInt32(b.THANHTIEN);
            }
            Program.tongtien = tien;
            hd.UpdateTT(Convert.ToInt32(txtMaCTHD.Text), Program.tongtien);
            hd.xoaHDTam(Convert.ToInt32(txtMaCTHD.Text));
            Program.mahd = int.Parse(txtMaCTHD.Text);
            if (Convert.ToInt32(txtTT.Text) > Convert.ToInt32(txtTienKhachDua.Text))
            {
                MessageBox.Show("Thanh toán thất bại do khách chưa đưa đủ số tiền!");
            }
            else
            {
                if (Program.mahd!=0)
                {
                    MessageBox.Show("Thanh toán thành công!");
                    reset();
                    dgvBH.DataSource = null;
                }    
            }
            if(Program.manv!="NV001")
            {
                BienLaiHD a = new BienLaiHD();
                this.Hide();
                a.ShowDialog();
            }    
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (hd.xoaHD(Convert.ToInt32(txtMaCTHD.Text),cboTenLoai.SelectedValue.ToString(),mathuoc) == 1)
            {
                MessageBox.Show("Xóa Thành công");
                hd.xoaHDTam1(Convert.ToInt32(txtMaCTHD.Text),cboTenLoai.Text,cboTenThuoc.Text);
                LoadDaTa();
                reset();
                int sc = dgvBH.Rows.Count;
                float thanhtien =0;
                for (int i = 0; i < sc; i++)
                    thanhtien += float.Parse(dgvBH.Rows[i].Cells["thanhtien"].Value.ToString());
                txtTT.Text = thanhtien.ToString();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(numericUpDown1.Value.ToString());
            if (sl == 0)
            {
                MessageBox.Show("Sửa không thành công! Vui lòng kiểm tra lại nhập liệu!");
                return;
            }
            if (hd.suaHD(Convert.ToInt32(txtMaCTHD.Text), cboTenLoai.SelectedValue.ToString(), mathuoc, sl, textBox1.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtTT.Text)) == 1)
            {
                
                MessageBox.Show("Sửa Thành công");
                hd.suaHDTam(Convert.ToInt32(txtMaCTHD.Text), cboTenLoai.Text.ToString(), cboTenThuoc.Text, sl, textBox1.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtTT.Text));
                LoadDaTa();
                reset();
                int sc = dgvBH.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < sc; i++)
                    thanhtien += float.Parse(dgvBH.Rows[i].Cells["thanhtien"].Value.ToString());
                txtTT.Text = thanhtien.ToString();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }

        private void dgvBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;        
            txtMaCTHD.Text = dgvBH[0, li].Value.ToString();
            cboTenLoai.Text = dgvBH[1, li].Value.ToString();
            cboTenThuoc.Text = dgvBH[2, li].Value.ToString();
            numericUpDown1.Text= dgvBH[3, li].Value.ToString();
            textBox1.Text = dgvBH[4, li].Value.ToString();
            txtGia.Text = dgvBH[5, li].Value.ToString();
            txtTT.Text = dgvBH[6, li].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            int intTienKhachDua = 0; int intTongTien = 0; int intTienThua = 0;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]"))
            {
                textBox1.Text = "";
            }
            if (txtTienKhachDua.Text != "")
            {
                 intTienKhachDua = Convert.ToInt32(txtTienKhachDua.Text);
                 intTongTien = Convert.ToInt32(txtTT.Text);
                 intTienThua = intTienKhachDua - intTongTien;
            }    
            if (intTienThua >= 0)
            {
                button1.Enabled = true;
            }
            else {
                button1.Enabled = false;
            }
            txtTienThua.Text = Convert.ToString(intTienThua);
        }

        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class frmThongKeNgay : Form
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        public static DateTime ngay;
        public frmThongKeNgay()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            {
                ngay = e.Start;
                label1.Text = "Ngày: " + ngay.ToShortDateString();
                var q = ntt.HoaDons.Where(p => p.NgayLap.Value.Day == ngay.Day);
                if (q.Count() != 0)
                {
                    int tongtien = (int)q.Sum(p =>p.TongTien);
                    label2.Text = "Tổng tiền:" + tongtien.ToString();
                }
                else
                    label2.Text = "Tổng tiền: 0";
                dataGridView1.DataSource = q;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmThongKeNgay_Load(object sender, EventArgs e)
        {
            ngay = DateTime.Now;
        }
    }
}

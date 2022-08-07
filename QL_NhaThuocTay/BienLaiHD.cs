using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QL_NhaThuocTay
{
    public partial class BienLaiHD : Form
    {
        BanHang hd = new BanHang();
        public BienLaiHD()
        {
            InitializeComponent();
        }

        private void BienLaiHD_Load(object sender, EventArgs e)
        {
          
            XuatHD rpt = new XuatHD();
            rpt.SetDatabaseLogon("sa","sa2012",@"DESKTOP-SOF5J9B\SQLEXPRESS", "QL_NhaThuocTay");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();          
            rpt.SetParameterValue("NgayLap", System.DateTime.Now);
            rpt.SetParameterValue("HoTen", Program.tennv);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}

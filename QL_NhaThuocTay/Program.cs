using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaThuocTay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static String tennv = "";

        public static String manv = "";
        public static String tenncc = "";

        public static String makh = "";
        public static String tenkh = "";
        public static String gtinh = "";
        public static String sdt = "";
        public static String chucvu = "";

        public static int mahd = 0;
        public static int mapn = 0;
        public static int tongtien = 0;
        public static String TK = "";
        public static String MK = "";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}

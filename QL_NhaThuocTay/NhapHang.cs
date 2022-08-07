using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuocTay
{
    public class NhapHang
    {
        NhaThuocTayDataContext NTT = new NhaThuocTayDataContext();
        public bool kt(int mapn, string mathuoc)
        {
            var p = from l in NTT.ChiTietPNs
                    where l.MaPN.Equals(mapn) && l.MaThuoc.Equals(mathuoc)
                    select l;
            return p.Count() == 0 ? false : true;
        }
        public List<PhieuNhap> laymaPN()
        {
            var q = (from s in NTT.PhieuNhaps orderby s.MaPN descending select s).Take(1);
            return q.ToList();
        }
        public List<ChiTietPN1> getLoai(int mapn)
        {
            var q = from l in NTT.ChiTietPN1s
                    where l.MaPN.Equals(mapn)
                    select l;
            return q.ToList();
        }
        public List<Thuoc> laycombox(string ma)
        {
            var q = (from s in NTT.Thuocs where s.MALOAI.Equals(ma) select s);
            return q.ToList();
        }
        public List<ChiTietPN> UDTongTien(int mapn)
        {
            var q = (from s in NTT.ChiTietPNs where s.MaPN.Equals(mapn) select s);
            return q.ToList();
        }
        public int taoPN()
        {

            PhieuNhap pn = new PhieuNhap();
            pn.MaNV = Program.manv;
            pn.NgayLap = System.DateTime.Now.Date;
            pn.TongTien = 0;
            NTT.PhieuNhaps.InsertOnSubmit(pn);
            NTT.SubmitChanges();
            return 1;
        }
        public int themPN(int mapn, string maloai, string mathuoc, int sl, string dvt, int gia, int thanhtien)
        {
            if (kt(mapn, mathuoc) == true)
            {
                return 0;
            }
            ChiTietPN ctpn = new ChiTietPN();
            ctpn.MaPN = mapn;
            ctpn.MALOAI = maloai;
            ctpn.MaThuoc = mathuoc;
            ctpn.SOLUONG = sl;
            ctpn.DVT = dvt;
            ctpn.GIA = gia;
            ctpn.THANHTIEN = thanhtien;
            NTT.ChiTietPNs.InsertOnSubmit(ctpn);

            NTT.SubmitChanges();
            return 1;
        }
        public void themTam(int mapn, string maloai, string mathuoc, int sl, string dvt, int gia, int thanhtien)
        {

            ChiTietPN1 ctpn = new ChiTietPN1();
            ctpn.MaPN = mapn;
            ctpn.MALOAI = maloai;
            ctpn.MaThuoc = mathuoc;
            ctpn.SOLUONG = sl;
            ctpn.DVT = dvt;
            ctpn.GIA = gia;
            ctpn.THANHTIEN = thanhtien;
            NTT.ChiTietPN1s.InsertOnSubmit(ctpn);
            NTT.SubmitChanges();

        }
        public int suapn(int mapn, string maloai, string mathuoc, int soluong, string dvt, int gia, int thanhtien)
        {
            var q = from l in NTT.ChiTietPNs
                    where l.MaPN.Equals(mapn) && l.MALOAI.Equals(maloai) && l.MaThuoc.Equals(mathuoc)
                    select l;
            if (q.Count() != 0)
            {
                q.First().SOLUONG = soluong;
                q.First().DVT = dvt;
                q.First().GIA = gia;
                q.First().THANHTIEN = thanhtien;
                NTT.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public void suaPNTam(int mapn, string maloai, string mathuoc, int soluong, string dvt, int gia, int thanhtien)
        {
            var q = from l in NTT.ChiTietPN1s
                    where l.MaPN.Equals(mapn) && l.MALOAI.Equals(maloai) && l.MaThuoc.Equals(mathuoc)
                    select l;
            if (q.Count() != 0)
            {
                q.First().SOLUONG = soluong;
                q.First().DVT = dvt;
                q.First().GIA = gia;
                q.First().THANHTIEN = thanhtien;
                NTT.SubmitChanges();
            }

        }
        public int UpdateTT(int mahd, int tongtien)
        {
            var q = from l in NTT.HoaDons
                    where l.MaHD.Equals(mahd)
                    select l;
            if (q.Count() != 0)
            {
                q.First().TongTien = tongtien;
                NTT.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoaPN(int mapn, string maloaithuoc, string mathuoc)
        {
            var q = from l in NTT.ChiTietPNs
                    where l.MaPN.Equals(mapn) && l.MALOAI.Equals(maloaithuoc) && l.MaThuoc.Equals(mathuoc)
                    select l;
            if (q.Count() != 0)
            {
                NTT.ChiTietPNs.DeleteOnSubmit(q.First());
                NTT.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public void xoaPNTam1(int mapn, string maloaithuoc, string mathuoc)
        {
            var q = from l in NTT.ChiTietPN1s
                    where l.MaPN.Equals(mapn) && l.MALOAI.Equals(maloaithuoc) && l.MaThuoc.Equals(mathuoc)
                    select l;
            if (q.Count() != 0)
            {
                NTT.ChiTietPN1s.DeleteOnSubmit(q.First());
                NTT.SubmitChanges();
            }
        }
        public int xoaPNTam(int mapn)
        {
            mapn -= 1;
            var q = from l in NTT.ChiTietPN1s
                    where l.MaPN.Equals(mapn)
                    select l;
            if (q.Count() != 0)
            {
                NTT.ChiTietPN1s.DeleteAllOnSubmit(q);
                NTT.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}

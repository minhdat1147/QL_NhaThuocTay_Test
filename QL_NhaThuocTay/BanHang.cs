using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuocTay
{
    public class BanHang
    {
        NhaThuocTayDataContext NTT = new NhaThuocTayDataContext();
        public bool kt(int mahd,string mathuoc)
        {
            var p = from l in NTT.ChiTietHDs
                     where l.MaHD.Equals(mahd) && l.MaThuoc.Equals(mathuoc)
                    select l;
            return p.Count() == 0 ? false : true;
        }
        public List<HoaDon> laymaHD()
        {
            var q = (from s in NTT.HoaDons orderby s.MaHD descending select s).Take(1);
            return q.ToList();
        }
        public List<ChiTietHD1> getLoai(int mahd)
        {
            var q = from l in NTT.ChiTietHD1s 
                    where l.MaHD.Equals(mahd)
                    select l;
            return q.ToList();
        }
        public List<Thuoc> laycombox(string ma)
        {
            var q = (from s in NTT.Thuocs  where s.MALOAI.Equals(ma) select s);
            return q.ToList();
        }
        public List<ChiTietHD> UDTongTien(int mahd )
        {
            var q = (from s in NTT.ChiTietHDs where s.MaHD.Equals(mahd) select s);
            return q.ToList();
        }
        public int taoHD()
        {
         
            HoaDon hd = new HoaDon();
            hd.MaNV = Program.manv;
            hd.NgayLap = System.DateTime.Now.Date;
            hd.TongTien = 0;
            NTT.HoaDons.InsertOnSubmit(hd);
            NTT.SubmitChanges();
            return 1;
        }
        public int themCTHD(int mahd, string maloai, string mathuoc, int sl,string dvt,int gia,int thanhtien)
        {
            if (kt(mahd, mathuoc) == true)
            {
                return 0;
            }             
            ChiTietHD cthd = new ChiTietHD();
            cthd.MaHD = mahd;
            cthd.MALOAI = maloai;
            cthd.MaThuoc = mathuoc;
            cthd.SOLUONG = sl;
            cthd.DVT = dvt;
            cthd.GIA = gia;
            cthd.THANHTIEN = thanhtien;
            NTT.ChiTietHDs.InsertOnSubmit(cthd);
                 
            NTT.SubmitChanges();
            return 1;
        }
        public void themTam(int mahd, string maloai, string mathuoc, int sl, string dvt, int gia, int thanhtien)
        {
          
            ChiTietHD1 cthd = new ChiTietHD1();
            cthd.MaHD = mahd;
            cthd.MALOAI = maloai;
            cthd.MaThuoc = mathuoc;
            cthd.SOLUONG = sl;
            cthd.DVT = dvt;
            cthd.GIA = gia;
            cthd.THANHTIEN = thanhtien;
            NTT.ChiTietHD1s.InsertOnSubmit(cthd);
            NTT.SubmitChanges();
          
        }
        public int suaHD(int mahd, string maloai, string mathuoc, int soluong, string dvt, int gia, int thanhtien)
        {
            var q = from l in NTT.ChiTietHDs
                    where l.MaHD.Equals(mahd)&& l.MALOAI.Equals(maloai)&& l.MaThuoc.Equals(mathuoc)
                    select l;
            if(q.Count() !=0)
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
        public void suaHDTam(int mahd, string maloai, string mathuoc, int soluong, string dvt, int gia, int thanhtien)
        {
            var q = from l in NTT.ChiTietHD1s
                    where l.MaHD.Equals(mahd) && l.MALOAI.Equals(maloai) && l.MaThuoc.Equals(mathuoc)
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
        public int UpdateTT(int mahd,  int tongtien)
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
        public int xoaHD(int mahd,string maloaithuoc,string mathuoc)
        {
            var q = from l in NTT.ChiTietHDs
                    where l.MaHD.Equals(mahd) && l.MALOAI.Equals(maloaithuoc) && l.MaThuoc.Equals(mathuoc)
                    select l;
            if (q.Count() != 0)
            {
                NTT.ChiTietHDs.DeleteOnSubmit(q.First()) ;
                NTT.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public void xoaHDTam1(int mahd, string maloaithuoc, string mathuoc)
        {
            var q = from l in NTT.ChiTietHD1s
                    where l.MaHD.Equals(mahd) && l.MALOAI.Equals(maloaithuoc) && l.MaThuoc.Equals(mathuoc)
                    select l;
            if (q.Count() != 0)
            {
                NTT.ChiTietHD1s.DeleteOnSubmit(q.First());
                NTT.SubmitChanges();
            }
        }
        public int xoaHDTam(int mahd)
        {
            mahd = mahd - 1;
            var q = from l in NTT.ChiTietHD1s
                    where l.MaHD.Equals(mahd)
                    select l;
            if (q.Count() != 0)
            {
                NTT.ChiTietHD1s.DeleteAllOnSubmit(q);
                NTT.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}

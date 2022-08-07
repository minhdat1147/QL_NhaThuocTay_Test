using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuocTay
{
    public class Thuoc_DAL
    {
        NhaThuocTayDataContext NTT = new NhaThuocTayDataContext();
        public List<Thuoc> getLoai()
        {
            var q = from s in NTT.Thuocs select s;
            return q.ToList();
        }
        public bool kt(string ma)
        {
            var p = from l in NTT.Thuocs
                    where l.MaThuoc.Equals(ma)
                    select l;
            return p.Count() == 0 ? false : true;
        }
        public int them(string mathuoc, string tenthuoc, string dvt, int dongia,string hsd,string maloai)
        {
            if (kt(mathuoc) == true)

                return 0;
            Thuoc thuoc = new Thuoc();
            thuoc.MaThuoc = mathuoc;
            thuoc.TenThuoc = tenthuoc;
            thuoc.DVT = dvt;
            thuoc.DonGia = dongia;
            thuoc.HSD = hsd;
            thuoc.MALOAI = maloai;
            NTT.Thuocs.InsertOnSubmit(thuoc);
            NTT.SubmitChanges();
            return 1;
        }
        public int sua(string mathuoc, string tenthuoc, string dvt, int dongia, string hsd, string maloai)
        {
            var q = from l in NTT.Thuocs
                    where l.MaThuoc.Equals(mathuoc)
                    select l;
            if (q.Count() != 0)
            {
                q.First().TenThuoc = tenthuoc;
                q.First().DVT = dvt;
                q.First().DonGia = dongia;
                q.First().HSD = hsd;
                q.First().MALOAI = maloai;
            
                NTT.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoa(string ma)
        {
            var q = from l in NTT.Thuocs
                    where l.MaThuoc.Equals(ma)
                    select l;
            if (q.Count() != 0)
            {
                NTT.Thuocs.DeleteOnSubmit(q.First());
                NTT.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public List<Thuoc> timkiem(string ten)
        {
            var q = from s in NTT.Thuocs.Where(l => l.MALOAI.Equals(ten))
                    select s;
            return q.ToList();
        }
    }
}

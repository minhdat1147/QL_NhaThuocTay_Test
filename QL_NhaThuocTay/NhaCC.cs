using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuocTay
{
    public class NhaCC
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        public List<NhaCungCap> getLoai()
        {
            var q = from s in ntt.NhaCungCaps select s;
            return q.ToList();
        }
        public bool kt(string ma)
        {
            var p = from l in ntt.NhaCungCaps
                    where l.MaNCC.Equals(ma)
                    select l;
            return p.Count() == 0 ? false : true;
        }
        public int them(string mancc , string ten , string diachi, int sdt)
        {
            if (kt(mancc) == true)

                return 0;
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = mancc;
            ncc.TenNCC = ten;
            ncc.DiaChi = diachi;
            ncc.SDT = sdt;
            ntt.NhaCungCaps.InsertOnSubmit(ncc);
            ntt.SubmitChanges();
            return 1;
        }
        public int sua(string mancc, string ten, string diachi, int sdt)
        {
            var q = from l in ntt.NhaCungCaps
                    where l.MaNCC.Equals(mancc)
                    select l;
            if (q.Count() != 0)
            {
                q.First().TenNCC = ten;
                q.First().DiaChi = diachi;
                q.First().SDT = sdt;
                ntt.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoa(string ma)
        {
            var q = from l in ntt.NhaCungCaps
                    where l.MaNCC.Equals(ma)
                    select l;
            if (q.Count() != 0)
            {
                ntt.NhaCungCaps.DeleteOnSubmit(q.First());
                ntt.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public List<NhaCungCap> timkiem(string ten)
        {
            var q = from s in ntt.NhaCungCaps.Where(l => l.TenNCC.Contains(ten))
                    select s;
            return q.ToList();
        }
    }
}

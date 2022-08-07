using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuocTay
{
    public class KhachHang_SP
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        public List<KhachHang_NTT> getDs()
        {
            var q = from s in ntt.KhachHangs select s;
            return q.ToList();
        }
        public bool kt(string ma)
        {
            var p = from l in ntt.KhachHangs
                    where l.MaKH.Equals(ma)
                    select l;
            return p.Count() == 0 ? false : true;
        }
        public int them(string makh, string ten,DateTime ngaysinh,string gioitinh, string diachi, int sdt, string benhan)
        {
            if (kt(makh) == true)

                return 0;
            KhachHang_NTT kh = new KhachHang_NTT();
            kh.MaKH = makh;
            kh.TenKH = ten;
            kh.NgaySinh = ngaysinh;
            kh.GioiTinh = gioitinh;
            kh.DiaChi = diachi;
            kh.SDT = sdt;
            kh.BenhAn = benhan;
            ntt.KhachHangs.InsertOnSubmit(kh);
            ntt.SubmitChanges();
            return 1;
        }
        public int sua(string makh, string ten, DateTime ngaysinh, string gioitinh, string diachi, int sdt, string benhan)
        {
            var q = from l in ntt.KhachHangs
                    where l.MaKH.Equals(makh)
                    select l;
            if (q.Count() != 0)
            {
                q.First().TenKH = ten;
                q.First().NgaySinh = ngaysinh;
                q.First().GioiTinh = gioitinh;
                q.First().DiaChi = diachi;
                q.First().SDT = sdt;
                q.First().BenhAn = benhan;
                ntt.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoa(string ma)
        {
            var q = from l in ntt.KhachHangs
                    where l.MaKH.Equals(ma)
                    select l;
            if (q.Count() != 0)
            {
                ntt.KhachHangs.DeleteOnSubmit(q.First());
                ntt.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}

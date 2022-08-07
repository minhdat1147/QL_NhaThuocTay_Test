using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuocTay
{
    public class NhanVien_NTT
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
        public List<NhanVien> getLoai()
        {
            var q = from s in ntt.NhanViens select s;
            return q.ToList();
        }
        public List<NhanVien> timkiem(string ten)
        {
            var q = from s in ntt.NhanViens where s.TenNV.StartsWith(ten) select s ;
            return q.ToList();
        }
        public bool kt(string ma)
        {
            var p = from l in ntt.NhanViens
                    where l.MaNV.Equals(ma)
                    select l;
            return p.Count() == 0 ? false : true;
        }
        public int them(string manv, string ten,DateTime ngaysinh,string gioitinh, string diachi, int sdt, int cccd,string chucvu, string matkhau)
        {
            if (kt(manv) == true)

                return 0;
            NhanVien nv = new NhanVien();
            nv.MaNV = manv;
            nv.TenNV = ten;
            nv.NgaySinh = ngaysinh;
            nv.GioiTinh = gioitinh;
            nv.DiaChi = diachi;
            nv.SDT = Convert.ToInt32(sdt);
            nv.CCCD = Convert.ToInt32(cccd);
            nv.ChucVu = chucvu;
            ntt.NhanViens.InsertOnSubmit(nv);
            ntt.SubmitChanges();
            return 1;
        }
        public int sua(string manv, string ten, DateTime ngaysinh, string gioitinh, string diachi, int sdt, int cccd, string chucvu, string matkhau)
        {
            var q = from l in ntt.NhanViens
                    where l.MaNV.Equals(manv)
                    select l;
            if (q.Count() != 0)
            {
                q.First().TenNV = ten;
                q.First().NgaySinh = ngaysinh;
                q.First().GioiTinh = gioitinh;
                q.First().DiaChi = diachi;
                q.First().SDT = sdt;
                q.First().CCCD = cccd;
                q.First().ChucVu = chucvu;
                q.First().MatKhau = matkhau;
                ntt.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoa(string ma)
        {
            var q = from l in ntt.NhanViens
                    where l.MaNV.Equals(ma)
                    select l;
            if (q.Count() != 0)
            {
                ntt.NhanViens.DeleteOnSubmit(q.First());
                ntt.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}

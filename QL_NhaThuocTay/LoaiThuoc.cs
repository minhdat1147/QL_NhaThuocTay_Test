using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuocTay
{
    public class LoaiThuoc
    {
        NhaThuocTayDataContext ntt = new NhaThuocTayDataContext();
         public List<LOAITHUOC> getLoai()
        {
            var q = from l in ntt.LOAITHUOCs select l;
            return q.ToList();
        }
        public bool kt(string ma)
        {
            var q = from l in ntt.LOAITHUOCs
                    where l.MALOAI.Equals(ma)
                    select l;
            return q.Count() == 0 ? false : true;
        }
        public int them(string ma ,string ten, string mancc)
        {
            if(kt(ma)== true)
            {
                return 0;
            }
            LOAITHUOC loai = new LOAITHUOC();
            loai.MALOAI = ma;
            loai.TENLOAI = ten;
            loai.MANCC = mancc;
            ntt.LOAITHUOCs.InsertOnSubmit(loai);
            ntt.SubmitChanges();
            return 1;
        }
        public int sua(string ma, string ten, string mancc)
        {
            var q = from l in ntt.LOAITHUOCs
                    where l.MALOAI.Equals(ma)
                    select l;
            if(q.Count() !=0)
            {
                q.First().TENLOAI = ten;
                q.First().MANCC = mancc;
                ntt.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoa(string ma)
        {
            var q = from l in ntt.LOAITHUOCs
                    where l.MALOAI.Equals(ma)
                    select l;
            if(q.Count() !=0)
            {
                ntt.LOAITHUOCs.DeleteOnSubmit(q.First());
                ntt.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}

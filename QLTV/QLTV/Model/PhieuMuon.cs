using QLTV.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Model
{
   public class PhieuMuon
    {
        public string ma { get; set; }
        public string docgiama { get; set; }
        public DateTime ngaymuon { get; set; }
        public string sachma { get; set; }
        public DateTime hantra { get; set; }
        public string nhanvienma { get; set; }
        public DateTime ngaytra { get; set; }
        public float phathong { get; set; }
        public float phatmat { get; set; }
        public float phatquahan { get; set; }
        public int trangthai { get; set; }
        public string phieumuonma { get; set; }
        DataAcess da = new DataAcess();
        public void ThemPhieuMuon(string docgiama, DateTime ngaymuon, string nhanvienma, DateTime hantra)
        {
            da.NonQuery("ThemVaoPhieuMuon", new SqlParameter("@docgiama", docgiama),
                                             new SqlParameter("@ngaymuon", ngaymuon),
                                             new SqlParameter("@nhanvienma", nhanvienma),
                                             new SqlParameter("@hantra", hantra));
        }
    }
}

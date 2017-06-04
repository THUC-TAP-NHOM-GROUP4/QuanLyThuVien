using QLTV.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Model
{
    class ChiTietPhieuMuon
    {
        public string sachma { get; set; }
        public string nhaxuatbanma { get; set; }
        public string theloaima { get; set; }
        public string tacgiama { get; set; }
        public string phieumuonma { get; set; }
        DataAcess da = new DataAcess();
        public void ThemVaoChiTietPhieuMuon(string sachma, string nhaxuatban, string theloaima, string tacgiama)
        {
            da.NonQuery("ThemVaoChiTietPhieuMuon", new SqlParameter("@sachma", sachma),
                                                   new SqlParameter("@nhaxuatbanma", nhaxuatban),
                                                   new SqlParameter("@theloaima", theloaima),
                                                   new SqlParameter("@tacgiama", tacgiama));
        }
    }
}

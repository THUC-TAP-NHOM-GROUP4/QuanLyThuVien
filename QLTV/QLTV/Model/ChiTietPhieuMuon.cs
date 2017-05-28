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
        DataAcess da = new DataAcess();
       public void ThemVaoChiTietPhieuMuon(string sachma)
        {
            da.NonQuery("ThemVaoChiTietPhieuMuon", new SqlParameter("@sachma", sachma));
        }
    }
}

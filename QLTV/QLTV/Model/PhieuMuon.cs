using System;
using System.Collections.Generic;
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
    }
}

using QLTV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controller
{
    class Controllers
    {
        private DataAcess dataAcess = new DataAcess();

        public Controllers()
        {

        }
        public List<DocGia> getListDocGia()
        {
            List<DocGia> listDocGia = new List<DocGia>();
            DataTable table = dataAcess.Query("select nv.ma, nv.ten, "
                + " nv.gioitinh, nv.ngaysinh, nv.dienthoai, nv.diachi, nv.email, nv.matkhau, nv.quyenhan "
                + " from NhanVien nv");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;

            for (i = 0; i < n; i++)
            {
                listDocGia.Add(getDocGia(table.Rows[i]));
            }

            return listDocGia;
        }
        public List<Sach> getListSach()
        {
            List<Sach> listSach = new List<Sach>();
            DataTable table = dataAcess.Query("select s.ma, s.ten, s.noidungtomtat, s.sotrang, "
                + " s.gia, s.soluong, s.ngaynhap, s.NXBma, s.TacGiama, s.TheLoaima, s.tinhtrang from Sach s");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;

            for (i = 0; i < n; i++)
            {
                listSach.Add(getSach(table.Rows[i]));
            }
            return listSach;
        }

        public Sach getSach(DataRow row)
        {
            Sach sach = new Sach();
            sach.ma = row["ma"].ToString().Trim();
            sach.ten = row["ten"].ToString().Trim();
            sach.gia = int.Parse(row["gia"].ToString().Trim());

            return sach;
        }
        public DocGia getDocGia(DataRow row)
        {
            DocGia docgia = new DocGia();


            return docgia;
        }
    }
}

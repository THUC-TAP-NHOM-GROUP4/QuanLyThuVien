using QLTV.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            DataTable table = dataAcess.Query("select dg.ma, dg.ten, dg.ngaysinh, dg.gioitinh,dg.diachi, dg.ngaylamthe, dg.ngayhethan, dg.hoatdong from docgia dg ");
               
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
            DataTable table = dataAcess.Query("select s.ma, s.ten, s.noidungtomtat, s.sotrang, s.gia, s.soluong, s.ngaynhap, s.NXBma, s.TacGiama, s.TheLoaima, s.tinhtrang from Sach s");
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
            sach.ngaynhap = DateTime.Parse(row["ngaynhap"].ToString().Trim());
            sach.tinhtrang = bool.Parse(row["tinhtrang"].ToString().Trim());
            sach.theloaima = row["TheLoaima"].ToString().Trim();
            sach.tacgiama = row["TacGiama"].ToString().Trim();
            sach.sotrang=int.Parse(row["sotrang"].ToString().Trim());
            sach.nhaxuatbanma = row["NXBma"].ToString().Trim();
            sach.noidungtomtat = row["noidungtomtat"].ToString().Trim();
            sach.soluong = int.Parse(row["soluong"].ToString().Trim());
            return sach;
        }
        public DocGia getDocGia(DataRow row)
        {
           
            DocGia docgia = new DocGia();
            docgia.ma = row["ma"].ToString().Trim();
            docgia.ten = row["ten"].ToString().Trim();
            docgia.diachi = row["diachi"].ToString().Trim();
            docgia.gioitinh = bool.Parse(row["gioitinh"].ToString().Trim());
            docgia.hoatdong = bool.Parse(row["hoatdong"].ToString().Trim());
           
            DateTime datetime = new DateTime();
            if (DateTime.TryParse(row["ngaysinh"].ToString().Trim(), out datetime))
            {
                docgia.ngaysinh = datetime;
            }
            
           
            if (DateTime.TryParse(row["ngaylamthe"].ToString().Trim(), out datetime))
            {
                docgia.ngaylamthe = datetime;
            }
            if (DateTime.TryParse(row["ngayhethan"].ToString().Trim(), out datetime))
            {
                docgia.ngayhethan = datetime;
            }
            
            return docgia;
        }
    
        public bool addnewBook(Sach s)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ten",s.ten),
                new SqlParameter("noidungtomtat",s.noidungtomtat),
                new SqlParameter("sotrang",s.sotrang),
                new SqlParameter("gia",s.gia),
                new SqlParameter("soluong",s.soluong),        
                new SqlParameter("nhaxuatbanma",s.nhaxuatbanma),
                new SqlParameter("tacgiama",s.tacgiama),
                new SqlParameter("theloaima",s.theloaima),
                new SqlParameter("tinhtrang",s.tinhtrang)

            };
            dataAcess.Query("procedure_insertSach", para);
            return true;
        }
        public bool addnewReader(DocGia dg)
        {
            //select dg.ma, dg.ten, dg.ngaysinh, dg.gioitinh, 
            //dg.diachi, dg.ngaylamthe, dg.ngayhethan, dg.hoatdong from docgia dg
            SqlParameter[] para =
           {
                new SqlParameter("ten",dg.ten),
                new SqlParameter("ngaysinh",dg.ngaysinh),
                new SqlParameter("gioitinh",dg.gioitinh),
                new SqlParameter("diachi",dg.diachi),
                new SqlParameter("ngaylamthe",dg.ngaylamthe),
                new SqlParameter("ngayhethan",dg.ngayhethan),
                new SqlParameter("hoatdong",dg.hoatdong),
             
            };
            dataAcess.Query("procedure_insertDocGia", para);
            return true;
        }

        public bool deleteDocGia(String ma)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ma", ma),
            };
            dataAcess.Query("deleteDocGia", para);
            return true;
        }
        public bool deleteSach(String ma)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ma", ma),
            };
            dataAcess.Query("procedure_deleteSach", para);
            return true;
        }
    }
}

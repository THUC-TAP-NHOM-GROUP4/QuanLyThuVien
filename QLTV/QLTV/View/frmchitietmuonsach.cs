using QLTV.Controller;
using QLTV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.View
{
    public partial class frmchitietmuonsach : Form
    {
        public frmchitietmuonsach()
        {
            InitializeComponent();
        }

        List<object> lst = new List<object>();
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataAcess da = new DataAcess();
        private void btnluulai_Click(object sender, EventArgs e)
        {
           
        }

        private void frmchitietmuonsach_Load(object sender, EventArgs e)
        {
            ChiTietPhieuMuon chitiet = new ChiTietPhieuMuon();
            cbbmasach.DataSource = da.Convert(da.Query("Select ten from Sach"));
            cbbnhaxuatban.DataSource = da.Convert(da.Query("select ten from Nhaxuatban"));
            cbbtacgia.DataSource = da.Convert(da.Query("select ten from Tacgia"));
            cbbtheloai.DataSource = da.Convert(da.Query("select ten from TheLoai"));
            List<Object> lst = new List<object>();
            lst = da.Convert(da.Query("select max(ma) from PhieuMuon"));
            txtphieumuon.Text = lst[0].ToString();
            if (txtphieumuon.Text != null)
            {
                chitiet.phieumuonma = txtphieumuon.Text;
                DSChitietphieumuon.DataSource = da.Query("DanhSachChiTietPhieuMuon", new SqlParameter("@phieumuonma", chitiet.phieumuonma));
            }
        }

        private void btnluulai_Click_1(object sender, EventArgs e)
        {
            ChiTietPhieuMuon chitiet = new ChiTietPhieuMuon();
            List<Object> lst = new List<object>();
            lst = da.Convert(da.Query("select ma from Sach where ten=N'" + cbbmasach.Text + "'"));

            chitiet.sachma = lst[0].ToString();

            lst = da.Convert(da.Query("select ma from TacGia where ten=N'" + cbbtacgia.Text + "'"));
            chitiet.tacgiama = lst[0].ToString();
            List<Object> lst3 = new List<object>();
            lst3 = da.Convert(da.Query("select ma from NhaXuatBan where ten=N'" + cbbnhaxuatban.Text + "'"));
            chitiet.nhaxuatbanma = lst3[0].ToString();
            lst = da.Convert(da.Query("select ma from TheLoai where ten=N'" + cbbtheloai.Text + "'"));
            chitiet.theloaima = lst[0].ToString();
            string[] str = { chitiet.sachma, chitiet.theloaima, chitiet.tacgiama, chitiet.nhaxuatbanma };
            if (da.Dieukhien(str) == 1)
            {
                chitiet.ThemVaoChiTietPhieuMuon(chitiet.sachma, chitiet.nhaxuatbanma, chitiet.theloaima, chitiet.tacgiama);
                MessageBox.Show("Thành công");
                chitiet.phieumuonma = txtphieumuon.Text;
                DSChitietphieumuon.DataSource = da.Query("DanhSachChiTietPhieuMuon", new SqlParameter("@phieumuonma", chitiet.phieumuonma));
            }
            else
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

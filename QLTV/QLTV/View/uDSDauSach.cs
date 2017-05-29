using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.Controller;
using QLTV.Model;
using QLTV.View;

namespace QLTV
{
    public partial class uDSDauSach : UserControl
    {
        private Controllers controller;
        List<DocGia> listDocGia;
        List<Sach> listSach;
        AddBook ab;
        public uDSDauSach()
        {
            InitializeComponent();
            controller = new Controllers();
            listDocGia = new List<DocGia>();
            listSach = new List<Sach>();
        }
        private void uDSDauSach_Load(object sender, EventArgs e)
        {
            listDocGia = controller.getListDocGia();
            listSach = controller.getListSach();

            grcDSDauSach.DataSource = listSach;
            grvSach.OptionsBehavior.Editable = false;
            grvSach.OptionsSelection.EnableAppearanceFocusedCell = false;

        }

        public void sbtnXoaDS_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.ma = grvSach.GetFocusedRowCellValue("ma").ToString();
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa ?" + sach.ma , "Xóa sách", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                controller.deleteSach(sach.ma);
                uDSDauSach_Load(sender, e);
            }
            else
            {
                uDSDauSach_Load(sender, e);
            }
        }

        private void ssbtnTimkiemDS_Click(object sender, EventArgs e)
        {

            SearchBook search = new SearchBook();
            search.ShowDialog();
            listSach = controller.getListSach();
            grcDSDauSach.DataSource = listSach;
        }

        private void ssbtnThemDS_Click(object sender, EventArgs e)
        {
            ab = new AddBook();
            ab.ShowDialog();
            listSach = controller.getListSach();
            grcDSDauSach.DataSource = listSach;

        }

        private void sbtnSuaDS_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.ma = grvSach.GetFocusedRowCellValue("ma").ToString();
            sach.ten = grvSach.GetFocusedRowCellValue("ten").ToString();
            sach.sotrang = int.Parse(grvSach.GetFocusedRowCellValue("sotrang").ToString());
            sach.gia = int.Parse(grvSach.GetFocusedRowCellValue("gia").ToString());
            sach.soluong = int.Parse(grvSach.GetFocusedRowCellValue("soluong").ToString());
            // sach.ngaynhap = DateTime.Parse(grvSach.GetFocusedRowCellValue("ngaynhap").ToString());
            sach.nhaxuatbanma = grvSach.GetFocusedRowCellValue("nhaxuatbanma").ToString();
            sach.tacgiama = grvSach.GetFocusedRowCellValue("tacgiama").ToString();
            sach.theloaima = grvSach.GetFocusedRowCellValue("theloaima").ToString();
            if (bool.Parse(grvSach.GetFocusedRowCellValue("tinhtrang").ToString()) == true)
                sach.tinhtrang = true;
            //sach.tinhtrang = true;
            else sach.tinhtrang = false;
            sach.noidungtomtat = grvSach.GetFocusedRowCellValue("noidungtomtat").ToString();
            EditBook edit = new EditBook(sach);
            edit.ShowDialog();
            listSach = controller.getListSach();
            grcDSDauSach.DataSource = listSach;


        }
    }
}

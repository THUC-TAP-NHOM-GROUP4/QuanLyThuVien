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
    public partial class uDSDocGia : UserControl
    {
        private Controllers controller;
        private List<DocGia> listDocGia;
        AddReader ar = new AddReader();
        public uDSDocGia()
        {
            InitializeComponent();
            controller = new Controllers();
            listDocGia = new List<DocGia>();
        }

        private void ssbtnTimkiemDG_Click(object sender, EventArgs e)
        {

        }

        private void uDSDocGia_Load(object sender, EventArgs e)
        {
            listDocGia = controller.getListDocGia();
            grcDSDocGia.DataSource = listDocGia;
            grvDocGia.OptionsBehavior.Editable = false;
            grvDocGia.OptionsSelection.EnableAppearanceFocusedCell = false;

        }

        private void grcDSDocGia_Click(object sender, EventArgs e)
        {

        }

        private void ssbtnThemDG_Click(object sender, EventArgs e)
        {
            ar.ShowDialog();
            listDocGia = controller.getListDocGia();
            grcDSDocGia.DataSource = listDocGia;
        }

        public void sbtnXoaDG_Click(object sender, EventArgs e)
        {
            DocGia docgia = new DocGia();
            docgia.ma = grvDocGia.GetFocusedRowCellValue("ma").ToString();
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa ?" + docgia.ma , "Xóa độc giả", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                controller.deleteDocGia(docgia.ma);
                uDSDocGia_Load(sender, e);
            }
            else
            {
                uDSDocGia_Load(sender, e);
            }
        }

        private void sbtnSuaDG_Click(object sender, EventArgs e)
        {
            DocGia docgia = new DocGia();
            docgia.ma = grvDocGia.GetFocusedRowCellValue("ma").ToString();
            docgia.ten = grvDocGia.GetFocusedRowCellValue("ten").ToString();
            docgia.ngaysinh = DateTime.Parse(grvDocGia.GetFocusedRowCellValue("ngaysinh").ToString());
            if (bool.Parse(grvDocGia.GetFocusedRowCellValue("gioitinh").ToString()) == true)
                docgia.gioitinh = true;
            //sach.tinhtrang = true;
            else docgia.gioitinh = false;
            docgia.diachi = grvDocGia.GetFocusedRowCellValue("diachi").ToString();
            docgia.ngaylamthe = DateTime.Parse(grvDocGia.GetFocusedRowCellValue("ngaylamthe").ToString());
            docgia.ngayhethan = DateTime.Parse(grvDocGia.GetFocusedRowCellValue("ngayhethan").ToString());
            if (bool.Parse(grvDocGia.GetFocusedRowCellValue("hoatdong").ToString()) == true)
                docgia.hoatdong = true;
            //sach.tinhtrang = true;
            else docgia.hoatdong = false;

            EditReader editreader = new EditReader(docgia);
            editreader.ShowDialog();
            listDocGia = controller.getListDocGia();
            grcDSDocGia.DataSource = listDocGia;

        }
    }
}

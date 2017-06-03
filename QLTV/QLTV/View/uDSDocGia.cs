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
using System.Data.SqlClient;

namespace QLTV
{
    public partial class uDSDocGia : UserControl
    {
        private string str { get; set; }
        private Controllers controller;
        private List<DocGia> listDocGia;
        AddReader ar = new AddReader();
        public uDSDocGia()
        {
            InitializeComponent();
            controller = new Controllers();
            listDocGia = new List<DocGia>();
        }
        public uDSDocGia(string str)
        {
            InitializeComponent();
            this.str = str;
        }
        private void ssbtnTimkiemDG_Click(object sender, EventArgs e)
        {

            SearchReader searchRD = new SearchReader();
            searchRD.ShowDialog();
            listDocGia = controller.getListDocGia();
            grcDSDocGia.DataSource = listDocGia;

            if (str == "1")
            {
                frmtimkiem frm = new frmtimkiem();
                frm.ShowDialog();
            }
        }
        DataAcess da = new DataAcess();
        private void uDSDocGia_Load(object sender, EventArgs e)
        {
            if (str == "1")
            {
                
                labelControl1.Text = "Danh sách mượn";
                grcDSDocGia.DataSource = da.Query("DanhSachPhieuMuon");
            }
            else if (str=="2")
            {
                ssbtnThemDG.Visible = false;
                ssbtnTimkiemDG.Visible = false;
                sbtnSuaDG.Visible = false;
                sbtnXoaDG.Visible = false;

                labelControl1.Text = "Danh sách trả sách";
                grcDSDocGia.DataSource = da.Query("DanhSachTraSach");

            }
            else
            {
                listDocGia = controller.getListDocGia();
                grcDSDocGia.DataSource = listDocGia;
                grvDocGia.OptionsBehavior.Editable = false;
                grvDocGia.OptionsSelection.EnableAppearanceFocusedCell = false;
            }
        }

        private void grcDSDocGia_Click(object sender, EventArgs e)
        {

        }

        private void ssbtnThemDG_Click(object sender, EventArgs e)
        {
            if (str == "1")
            {
                frmthem them = new frmthem();
                them.ShowDialog();
            }
            else
            {
                ar.ShowDialog();
                listDocGia = controller.getListDocGia();
                grcDSDocGia.DataSource = listDocGia;
            }
        }

        public void sbtnXoaDG_Click(object sender, EventArgs e)
        {
            if (str == "1")
            {
                PhieuMuon pm = new PhieuMuon();
                string str =
                pm.ma = grvDocGia.GetFocusedRowCellValue("Mã phiếu").ToString();
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Bạn có thực sự muốn xóa ?" + pm.ma, "Xóa sách", MessageBoxButtons.OKCancel);
                da.NonQuery("delete PhieuMuon where ma='" + pm.ma + "'");
                grcDSDocGia.DataSource = da.Query("DanhSachPhieuMuon");
            }
            else
            {
                DocGia docgia = new DocGia();
                docgia.ma = grvDocGia.GetFocusedRowCellValue("ma").ToString();
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa ?" + docgia.ma, "Xóa độc giả", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    controller.deleteDocGia(docgia.ma);
                    uDSDocGia_Load(sender, e);
                }
                else
                {
                    uDSDocGia_Load(sender, e);
                }
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


            if (str == "1")
            {
                PhieuMuon pm = new PhieuMuon();
                pm.ma = grvDocGia.GetFocusedRowCellValue("Mã phiếu").ToString();
                pm.docgiama = grvDocGia.GetFocusedRowCellValue("Mã độc giả").ToString();
                pm.ngaymuon = DateTime.Parse(grvDocGia.GetFocusedRowCellValue("Ngày mượn").ToString());
                pm.hantra = DateTime.Parse(grvDocGia.GetFocusedRowCellValue("Hạn trả").ToString());
                pm.phathong = 0;
                pm.phatmat = 0;
                pm.phatquahan = 0;
                pm.ngaytra = DateTime.Now;
                string str1 = pm.ma + "_" + pm.docgiama + "_" + pm.ngaymuon + "_"
                    + pm.ngaytra + "_" + pm.hantra + "_" + pm.phathong + "_" + pm.phatmat + "_" + pm.phatquahan;
                frmUpdate frm = new frmUpdate(str1);
                frm.ShowDialog();
                grcDSDocGia.DataSource = da.Query("DanhSachPhieuMuon");
            }
        }

        private void cbbmasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}

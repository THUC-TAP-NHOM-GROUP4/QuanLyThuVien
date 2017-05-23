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
            frmtimkiem frm = new frmtimkiem();
            frm.ShowDialog();
        }
        DataAcess da = new DataAcess();
        private void uDSDocGia_Load(object sender, EventArgs e)
        {
            if (str == "1")
            {
                lbmasv.Visible = true;
                cbbmasv.Visible = true;

                labelControl1.Text = "Danh sách mượn";
                cbbmasv.DataSource = da.Convert(da.Query("SELECT ma FROM DocGia"));
                
            }
            else if (str=="2")
            {
                ssbtnThemDG.Visible = false;
                ssbtnTimkiemDG.Visible = false;
                sbtnSuaDG.Visible = false;
                sbtnXoaDG.Visible = false;
                lbmasv.Visible = true;
                cbbmasv.Visible = true;
                labelControl1.Text = "Danh sách trả sách";
                cbbmasv.DataSource = da.Convert(da.Query("SELECT ma FROM DocGia"));
               
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
                pm.ma = grvDocGia.GetFocusedRowCellValue("ma").ToString();
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa ?" + pm.ma, "Xóa sách", MessageBoxButtons.OKCancel);
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
            if (str == "1")
            {
                PhieuMuon pm = new PhieuMuon();
                pm.ma= grvDocGia.GetFocusedRowCellValue("ma").ToString();
                pm.docgiama = grvDocGia.GetFocusedRowCellValue("DocGiama").ToString();
                pm.sachma = grvDocGia.GetFocusedRowCellValue("Sachma").ToString();
                pm.ngaymuon = DateTime.Parse(grvDocGia.GetFocusedRowCellValue("ngaymuon").ToString());
                pm.nhanvienma = grvDocGia.GetFocusedRowCellValue("NhanVienma").ToString();
                pm.ngaytra = DateTime.Parse(grvDocGia.GetFocusedRowCellValue("ngaytra").ToString());
                pm.hantra = DateTime.Parse(grvDocGia.GetFocusedRowCellValue("hantra").ToString());
                pm.phatquahan =int.Parse( grvDocGia.GetFocusedRowCellValue("phatquahan").ToString());
                pm.phathong = int.Parse(grvDocGia.GetFocusedRowCellValue("phathong").ToString());
                pm.phatmat = int.Parse(grvDocGia.GetFocusedRowCellValue("phatmat").ToString());
                string str1 = pm.ma + "_" + pm.docgiama + "_" + pm.sachma + "_" + pm.ngaymuon + "_"
                    + pm.nhanvienma + "_" + pm.ngaytra + "_" + pm.hantra + "_" + pm.phathong + "_" + pm.phatmat + "_" + pm.phatquahan;
                frmUpdate frm = new frmUpdate("1");
                frm.ShowDialog();
            }
        }

        private void cbbmasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(str=="2")
            grcDSDocGia.DataSource = da.Query("ProcPhieuTra", new SqlParameter("@docgiama", cbbmasv.Text));
            if (str=="1")
                grcDSDocGia.DataSource = da.Query("DSPhieuMuon", new SqlParameter("@docgiama", cbbmasv.Text));
            
        }
    }
}

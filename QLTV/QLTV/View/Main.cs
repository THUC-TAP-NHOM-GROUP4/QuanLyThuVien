using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using QLTV.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QLTV
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static XtraTabControl tabstatic;
        public Main()
        {
            InitializeComponent();
            tabstatic = xtraTabControl1;
          

        }
        public void Skins()
        {
            DevExpress.UserSkins.BonusSkins.Register();

            DevExpress.UserSkins.OfficeSkins.Register();

            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem2, true);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Skins();
            //    foreach (Control child in this.Controls)
            //    {
            //        if (child.Name!="bbiDN")
            //            child.IsEnabled = false;
            //    }
        }


        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            int h = 0;

            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            if (xtraTabControl1.SelectedTabPage.Equals((arg.Page as XtraTabPage)))
                h = xtraTabControl1.SelectedTabPageIndex;
            xtraTabControl1.TabPages.Remove((arg.Page as XtraTabPage));
            xtraTabControl1.SelectedTabPageIndex = h - 1;
        }
        public static bool KiemTraTabPage(string Ten)
        {
            bool ok = false;
            foreach (XtraTabPage tabpage in tabstatic.TabPages)
            {
                if (tabpage.Text == Ten)
                {
                    return ok = true;
                }
            }
            return ok;
        }
        public static int ViTriTabPage(string Ten)
        {
            int vitri = 0;
            for (int i = 0; i < tabstatic.TabPages.Count; i++)
            {
                if (tabstatic.TabPages[i].Text == Ten)
                    vitri = i;
            }
            return vitri;
        }
       
        public static void thoattab()
        {
            int i = tabstatic.SelectedTabPageIndex;
            tabstatic.TabPages.RemoveAt(i);
            tabstatic.SelectedTabPageIndex = i - 1;
        }

        private void bbiDSDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          XtraTabPage tabDSDauSach = new XtraTabPage();
          tabDSDauSach.Text = "Danh sách đầu sách";
            if (KiemTraTabPage(tabDSDauSach.Text) == false)
                xtraTabControl1.TabPages.Add(tabDSDauSach);
            else
                tabDSDauSach.PageVisible = true;
            uDSDauSach ds = new uDSDauSach();
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabDSDauSach.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabDSDauSach.Text)];
      
        }

        private void bbiDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login lg = new Login();
            lg.Show();

        }

        private void bbtiDSSDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage tabDSDocGia = new XtraTabPage();
            tabDSDocGia.Text = "Danh sách độc giả";
            if (KiemTraTabPage(tabDSDocGia.Text) == false)
                xtraTabControl1.TabPages.Add(tabDSDocGia);
            else
                tabDSDocGia.PageVisible = true;
            uDSDocGia ds = new uDSDocGia();
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabDSDocGia.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabDSDocGia.Text)];


        }

        private void bbiXoaDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new uDSDauSach()).sbtnXoaDS_Click(sender, e);
        }

        private void nvbiQDMS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraTabPage tabQuyDinhMuonSach = new XtraTabPage();
            tabQuyDinhMuonSach.Text = "Quy định mượn sách";
            if (KiemTraTabPage(tabQuyDinhMuonSach.Text) == false)
                xtraTabControl1.TabPages.Add(tabQuyDinhMuonSach);
            else
                tabQuyDinhMuonSach.PageVisible = true;
            uQuyDinhMuonSach ds = new uQuyDinhMuonSach();
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabQuyDinhMuonSach.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabQuyDinhMuonSach.Text)];

        }

      

        private void nbiQDC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            XtraTabPage tabQuyDinhChung = new XtraTabPage();
            tabQuyDinhChung.Text = "Quy định chung";
            if (KiemTraTabPage(tabQuyDinhChung.Text) == false)
                xtraTabControl1.TabPages.Add(tabQuyDinhChung);
            else
                tabQuyDinhChung.PageVisible = true;
            uQuyDinhChung ds = new uQuyDinhChung();
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabQuyDinhChung.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabQuyDinhChung.Text)];

        }

        private void bbiXoaDG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new uDSDocGia()).sbtnXoaDG_Click(sender, e);
        }

        private void bbiTimKiemDG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiThemDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void nvbiQDBVTL_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            XtraTabPage tabQuyDinhBaoVeTaiLieu = new XtraTabPage();
            tabQuyDinhBaoVeTaiLieu.Text = "Quy định bảo vệ tài liệu";
            if (KiemTraTabPage(tabQuyDinhBaoVeTaiLieu.Text) == false)
                xtraTabControl1.TabPages.Add(tabQuyDinhBaoVeTaiLieu);
            else
                tabQuyDinhBaoVeTaiLieu.PageVisible = true;
            uQuyDinhBaoVeTaiLieu ds = new uQuyDinhBaoVeTaiLieu();
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabQuyDinhBaoVeTaiLieu.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabQuyDinhBaoVeTaiLieu.Text)];
        }

        private void nvbiQDLT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            XtraTabPage tabQuyDinhLamThe = new XtraTabPage();
            tabQuyDinhLamThe.Text = "Quy định làm thẻ";
            if (KiemTraTabPage(tabQuyDinhLamThe.Text) == false)
                xtraTabControl1.TabPages.Add(tabQuyDinhLamThe);
            else
                tabQuyDinhLamThe.PageVisible = true;
            uQuyDinhLamThe ds = new uQuyDinhLamThe();
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabQuyDinhLamThe.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabQuyDinhLamThe.Text)];
        }

        private void nvbiHVUX_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraTabPage tabHanhVi = new XtraTabPage();
            tabHanhVi.Text = "Hành vi ứng xử";
            if (KiemTraTabPage(tabHanhVi.Text) == false)
                xtraTabControl1.TabPages.Add(tabHanhVi);
            else
                tabHanhVi.PageVisible = true;
            uHanhViUngXu ds = new uHanhViUngXu();
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabHanhVi.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabHanhVi.Text)];
        }

        private void bbiThemDG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void rbcMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnmuonsach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage tabDSDocGia = new XtraTabPage();
            tabDSDocGia.Text = "Mượn sách";
            if (KiemTraTabPage(tabDSDocGia.Text) == false)
                xtraTabControl1.TabPages.Add(tabDSDocGia);
            else
                tabDSDocGia.PageVisible = true;
            uDSDocGia ds = new uDSDocGia("1");
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabDSDocGia.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabDSDocGia.Text)];
        }

        private void btntrasach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraTabPage tabDSDocGia = new XtraTabPage();
            tabDSDocGia.Text = "Trả sách";
            if (KiemTraTabPage(tabDSDocGia.Text) == false)
                xtraTabControl1.TabPages.Add(tabDSDocGia);
            else
                tabDSDocGia.PageVisible = true;
            uDSDocGia ds = new uDSDocGia("2");
            ds.Parent = xtraTabControl1.TabPages[ViTriTabPage(tabDSDocGia.Text)];
            ds.Dock = DockStyle.Fill;
            ds.Show();
            xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[ViTriTabPage(tabDSDocGia.Text)];
        }
    }
}

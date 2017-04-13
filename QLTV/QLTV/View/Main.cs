using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
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
        
        private void Main_Load(object sender, EventArgs e)
        {
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

        }
    }
}

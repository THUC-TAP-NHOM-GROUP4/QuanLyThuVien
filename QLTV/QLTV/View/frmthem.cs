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
    public partial class frmthem : Form
    {
        public frmthem()
        {
            InitializeComponent();
            cbbsach.DataSource = da.Convert(da.Query("select ten from Sach"));
            cbbnhanvienma.DataSource = da.Convert(da.Query("select ten from NhanVien"));
        }
        DataAcess da = new DataAcess();
        List<ChiTietPhieuMuon> lst = new List<ChiTietPhieuMuon>();
        private void btnthem_Click(object sender, EventArgs e)
        {
            string[] str = {txtdocgiama.Text,txthantra.Text,txtngaymuon.Text,cbbnhanvienma.Text,cbbsach.Text};
            if (da.Dieukhien(str) == 1)
            {
               
                ChiTietPhieuMuon ctpm = new ChiTietPhieuMuon();
                ctpm.sachma = cbbsach.Text;
                lst.Add(ctpm);
                MessageBox.Show("Thành công");


            }
            else
                MessageBox.Show("Vui long dien day du thong tin");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluulai_Click(object sender, EventArgs e)
        {
            PhieuMuon pm = new PhieuMuon();
            pm.docgiama = txtdocgiama.Text;
            pm.ngaymuon = DateTime.Parse(txtngaymuon.Text);
            pm.nhanvienma = cbbnhanvienma.Text;
            pm.hantra = DateTime.Parse(txthantra.Text);
            pm.ThemPhieuMuon(pm.docgiama, pm.ngaymuon, pm.nhanvienma, pm.hantra);
            foreach(var item in lst)
            {
                ChiTietPhieuMuon chitiet = new ChiTietPhieuMuon();
                chitiet.sachma = item.sachma;
                chitiet.ThemVaoChiTietPhieuMuon(chitiet.sachma);
            }
            MessageBox.Show("Thanh công");
        }
    }
}

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
            cbbdocgia.DataSource = da.Convert(da.Query("select ma from DocGia "));
            cbbnhanvienma.DataSource = da.Convert(da.Query("select ma from NhanVien"));
        }
        DataAcess da = new DataAcess();
        List<ChiTietPhieuMuon> lst = new List<ChiTietPhieuMuon>();
        private void btnthem_Click(object sender, EventArgs e)
        {
            string[] str = { cbbdocgia.Text, txthantra.Text, txtngaymuon.Text, cbbnhanvienma.Text };
            if (da.Dieukhien(str) == 1)
            {
                PhieuMuon pm = new PhieuMuon();
                pm.docgiama = cbbdocgia.Text;
                pm.ngaymuon = DateTime.Parse(txtngaymuon.Text);
                pm.nhanvienma = cbbnhanvienma.Text;
                pm.hantra = DateTime.Parse(txthantra.Text);
                pm.ThemPhieuMuon(pm.docgiama, pm.ngaymuon, pm.nhanvienma, pm.hantra);
                frmchitietmuonsach frm = new frmchitietmuonsach();
                frm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng xem lại");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluulai_Click(object sender, EventArgs e)
        {
        }

        private void frmthem_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        private void btnthem_Click(object sender, EventArgs e)
        {
            PhieuMuon pm = new PhieuMuon();
            List<object> lst = new List<object>();
            lst = da.Convert(da.Query("select ma from DocGia"));
            foreach (object o in lst)
            {
                if (txtdocgiama.Text.Equals(o.ToString()))
                {


                    pm.docgiama = txtdocgiama.Text;
                    List<object> lst1 = new List<object>();
                    lst1 = da.Convert(da.Query("select ma from Sach where ten=N'" + cbbsach.Text + "'"));
                    cbbsach.Text = lst1[0].ToString();
                    pm.sachma = cbbsach.Text;
                    pm.ngaymuon = DateTime.Parse(txtngaymuon.Text);
                    pm.ngaytra = DateTime.Parse(txtngaymuon.Text);
                    pm.hantra = DateTime.Parse(txthantra.Text);
                    pm.phatmat = 0;
                    pm.phatquahan = 0;
                    pm.phathong = 0;
                    lst1 = da.Convert(da.Query("select ma from NhanVien where ten=N'" + cbbnhanvienma.Text + "'"));
                    cbbnhanvienma.Text = lst1[0].ToString();
                    pm.nhanvienma = cbbnhanvienma.Text;
                    da.NonQuery("dbo.procedure_insertPhieuMuon", new SqlParameter("@docgiama", pm.docgiama),
                                                                 new SqlParameter("@ngaymuon", pm.ngaymuon)
                                                                 , new SqlParameter("@sachma", pm.sachma)
                                                                 , new SqlParameter("@nhanvienma", pm.nhanvienma)
                                                                 , new SqlParameter("@hantra", pm.hantra)
                                                                  , new SqlParameter("@ngaytra", pm.ngaytra)
                                                                  , new SqlParameter("@phathong", pm.phathong)
                                                                  , new SqlParameter("@phatquahan", pm.phatquahan)
                                                                  , new SqlParameter("@phatmat", pm.phatmat));
                    MessageBox.Show("Thành công");
                    cbbsach.DataSource = da.Convert(da.Query("select ten from Sach"));
                    break;
                }
                else
                {
                    MessageBox.Show("Vui lòng xem lại, không tồn tại mã này");
                    break;
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

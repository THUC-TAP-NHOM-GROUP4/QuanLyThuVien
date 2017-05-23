using QLTV.Controller;
using QLTV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.View
{
    public partial class frmtimkiem : Form
    {
        public frmtimkiem()
        {
            InitializeComponent();
            dgrtimkiemphieumuon.DataSource = da.Query("select *from PhieuMuon ");
        }
        DataAcess da = new DataAcess();
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            PhieuMuon pm = new PhieuMuon();
            if (txttukhoa.Text != ""||txttukhoa.Text!= "  ---Nhập từ khóa---")
            {
                if (rdbmadocgia.Checked == true)
                    dgrtimkiemphieumuon.DataSource = da.Query("select *from PhieuMuon where Docgiama='" + txttukhoa.Text + "'");
                else if (rdbhantra.Checked == true)
                {
                    pm.hantra = DateTime.Parse(txttukhoa.Text);
                    dgrtimkiemphieumuon.DataSource = da.Query("select *from PhieuMuon where hantra='" + pm.hantra + "'");
                }
                else if (rdbngaymuon.Checked == true)
                {
                    pm.ngaymuon =DateTime.Parse( txttukhoa.Text);
                    dgrtimkiemphieumuon.DataSource = da.Query("select *from PhieuMuon where ngaymuon='" + pm.ngaymuon+ "'");
                }
                else if (rdbmasach.Checked == true)
                    dgrtimkiemphieumuon.DataSource = da.Query("select *from PhieuMuon where sachma='" + txttukhoa.Text + "'");
                else
                    MessageBox.Show("Bạn chọn một đối tượng");
            }
            else
                MessageBox.Show("Vui lòng nhập từ khóa");
        }
    }
}

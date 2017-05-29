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
            if (sach.ma == null) return;

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

        }

        private void ssbtnThemDS_Click(object sender, EventArgs e)
        {
            ab = new AddBook();
            ab.ShowDialog();
            listSach = controller.getListSach();
            grcDSDauSach.DataSource = listSach;

        }

        private void grcDSDauSach_Click(object sender, EventArgs e)
        {

        }
    }
}

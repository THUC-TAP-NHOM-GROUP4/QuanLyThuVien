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
           
        }

        private void sbtnXoaDS_Click(object sender, EventArgs e)
        {

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
    }
}

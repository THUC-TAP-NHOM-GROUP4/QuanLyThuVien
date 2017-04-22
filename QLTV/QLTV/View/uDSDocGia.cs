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
    public partial class uDSDocGia : UserControl
    {
        private Controllers controller;
        private List<DocGia> listDocGia;
        AddReader ar = new AddReader();
        public uDSDocGia()
        {
            InitializeComponent();
            controller = new Controllers();
            listDocGia = new List<DocGia>();
        }

        private void ssbtnTimkiemDG_Click(object sender, EventArgs e)
        {

        }

        private void uDSDocGia_Load(object sender, EventArgs e)
        {
            listDocGia = controller.getListDocGia();
            grcDSDocGia.DataSource = listDocGia;

        
            
        }

        private void grcDSDocGia_Click(object sender, EventArgs e)
        {

        }

        private void ssbtnThemDG_Click(object sender, EventArgs e)
        {
            ar.ShowDialog();
            listDocGia = controller.getListDocGia();
            grcDSDocGia.DataSource = listDocGia;
        }
    }
}

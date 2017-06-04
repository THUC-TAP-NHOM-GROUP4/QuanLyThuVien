using QLTV.Controller;
using QLTV.Model;
using QLTV.View;
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
    public partial class SearchReader : Form
    {
        Controllers control = new Controllers();

        public SearchReader()
        {
            InitializeComponent();
        }

        private void SearchReader_Load(object sender, EventArgs e)
        {
            dgvReader.DataSource = control.getListDocGia();

        }

        private void btnTKDG_Click(object sender, EventArgs e)
        {
            if (txtTKDG.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DataAcess da = new DataAcess();
                //bắt đầu tìm kiếm
                DataTable dt = new DataTable();
                Sach sach = new Sach();
                sach.ma = txtTKDG.Text;
                dgvReader.DataSource = da.Query("select *from Sach where ma='" + sach.ma + "'");
            }
        }
    }
}

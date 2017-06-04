using QLTV.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.Model;
using QLTV.View;
namespace QLTV.View
{
    public partial class SearchBook : Form
    {
        Controllers control = new Controllers();
        public SearchBook()
        {
            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource = control.getListSach();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DataAcess da = new DataAcess();
                //bắt đầu tìm kiếm
                DataTable dt = new DataTable();
                Sach sach = new Sach();
                sach.ma = txtTimKiem.Text;
                dgvBook.DataSource = da.Query("select *from Sach where ma='" + sach.ma + "'");
             }
        }
    }
}

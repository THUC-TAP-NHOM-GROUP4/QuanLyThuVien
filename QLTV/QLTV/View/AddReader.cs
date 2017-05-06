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
using QLTV.Controller;
namespace QLTV.View
{
    public partial class AddReader : Form
    {
        Controllers control = new Controllers();
        Form Main = new Form();
        public AddReader()
        {
            InitializeComponent();
        }
        public bool KiemTra()
        {
            if (txtTenDocGia.Text.ToString().Trim().Equals(""))
            {
                errTenDG.SetError(txtTenDocGia, "Nhập đủ tên độc giả");
                return false;
            }
            errTenDG.Clear();
            if (rtbDiaChi.Text.ToString().Trim().Equals(""))
            {
                errDiaChi.SetError(rtbDiaChi, "Nhập đủ số trang");
                return false;
            }
            errDiaChi.Clear();

            if (!(rdbNam.Checked || rdbNu.Checked))
            {
                errGioiTinh.SetError(rdbNam, "Chưa nhập giới tính");
                return false;
            }

            errGioiTinh.Clear();
            if (!(rdbFalse.Checked || rdbTrue.Checked))
            {
                errHoatDong.SetError(rdbFalse, "Chưa nhập hoạt động");
                return false;
            }

            errHoatDong.Clear();
            return true;
        }
        private void ssbtnThemDG_Click(object sender, EventArgs e)
        {

            if (KiemTra())
            {
                DocGia dg = new DocGia();
                dg.ten = txtTenDocGia.Text.ToString().Trim();
                dg.ngaysinh = DateTime.Parse(dtpNgaySinh.Text.ToString().Trim());
                dg.diachi = rtbDiaChi.Text.ToString().Trim();
                dg.ngaylamthe = DateTime.Parse(dtpNgayLamThe.Text.ToString().Trim());
                dg.ngayhethan = DateTime.Parse(dtpNgayHetHan.Text.ToString().Trim());
                if (rdbNam.Checked)
                    dg.gioitinh = true;
                else dg.gioitinh = false;
                if (rdbTrue.Checked)
                    dg.hoatdong = true;
                else dg.hoatdong = false;
                if (control.addnewReader(dg))
                {
                    this.Close();
                    this.Main.Visible = true;
                }
            }
        }

        private void sbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

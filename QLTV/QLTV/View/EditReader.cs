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
    public partial class EditReader : Form
    {
        Controllers control = new Controllers();
        Form Main = new Form();
        private uDSDauSach uDSDauSach;

        DocGia docgia = new DocGia();


        public EditReader()
        {
            InitializeComponent();
        }

        public EditReader(DocGia docgia)
        {
            InitializeComponent();
            this.docgia = docgia;
        }

        private void EditReader_Load(object sender, EventArgs e)
        {
            txtTenDocGia.Text = docgia.ten;
            dtpNgaySinh.Text = docgia.ngaysinh.ToString();
            if (docgia.gioitinh == true)
            {

                rdbTrue.Checked = true;
                rdbFalse.Checked = false;
            }
            else rdbFalse.Checked = true;
            rtbDiaChi.Text = docgia.diachi.ToString();
            dtpNgayLamThe.Text = docgia.ngaylamthe.ToString();
            dtpNgayHetHan.Text = docgia.ngayhethan.ToString();

            if (docgia.hoatdong == true)
            {

                rdbTrue.Checked = true;
                rdbFalse.Checked = false;
            }
            else rdbFalse.Checked = true;

        }

        private void ssbtnSuaDG_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                DocGia dg = new DocGia();
                dg.ma = docgia.ma;
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
                if (control.editReader(dg))
                {
                    this.Close();
                    this.Main.Visible = true;
                }
            }
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
    }
}

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
    public partial class EditBook : Form
    {
        Controllers control = new Controllers();
        Form Main = new Form();
        Sach sach = new Sach();
        private uDSDauSach uDSDauSach;

        public EditBook()
        {
            InitializeComponent();
        }

        public EditBook(Sach sach)
        {
            InitializeComponent();
            this.sach = sach;
        }

        private void sbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ssbtnSuaDS_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                Sach s = new Sach();
                s.ma = sach.ma;
                s.ten = txtTenSach.Text.ToString().Trim();
                s.sotrang = int.Parse(txtSoTrang.Text.ToString().Trim());
                s.gia = int.Parse(txtGia.Text);
                s.nhaxuatbanma = txtNhaXuatBanMa.Text.ToString().Trim();
                s.tacgiama = txtTacGiaMa.Text.ToString().Trim();
                s.theloaima = txtTheLoaiMa.Text.ToString().Trim();
                s.soluong = int.Parse(txtSoLuong.Text);
                s.noidungtomtat = rtbNoiDungTomTat.Text;
                if (rdbTrue.Checked)
                    s.tinhtrang = true;
                else s.tinhtrang = false;
                if (control.editBook(s))
                {
                    this.Close();
                    this.Main.Visible = true;
                }
            }


        }

        public bool KiemTra()
        {
            if (txtTenSach.Text.ToString().Trim().Equals(""))
            {
                errTen.SetError(txtTenSach, "Nhập đủ tên sách");
                return false;
            }
            errTen.Clear();
            if (txtSoTrang.Text.ToString().Trim().Equals(""))
            {
                errTrang.SetError(txtSoTrang, "Nhập đủ số trang");
                return false;
            }
            errTrang.Clear();
            if (txtGia.Text.ToString().Trim().Equals(""))
            {
                errTrang.SetError(txtGia, "Nhập đủ giá");
                return false;
            }
            errGia.Clear();
            if (txtSoLuong.Text.ToString().Trim().Equals(""))
            {
                errSoLuong.SetError(txtSoLuong, "Chưa nhập số lượng");
                return false;
            }
            errSoLuong.Clear();
            if (txtNhaXuatBanMa.Text.ToString().Trim().Equals(""))
            {
                errNXBMa.SetError(txtNhaXuatBanMa, "Chưa nhập mã nhà xuất bản");
                return false;
            }
            errNXBMa.Clear();
            if (txtTacGiaMa.Text.ToString().Trim().Equals(""))
            {
                errTacGiaMa.SetError(txtTacGiaMa, "Chưa nhập mã tác giả");
                return false;
            }
            errTacGiaMa.Clear();
            if (txtTheLoaiMa.Text.ToString().Trim().Equals(""))
            {
                errTheLoaiMa.SetError(txtTheLoaiMa, "Chưa nhập mã thể loại");
                return false;
            }

            errTheLoaiMa.Clear();
            if (rtbNoiDungTomTat.Text.ToString().Trim().Equals(""))
            {
                errNoiDungTomTat.SetError(rtbNoiDungTomTat, "Chưa nhập nội dung tóm tắt");
                return false;
            }
            errNoiDungTomTat.Clear();
            if (!(rdbFalse.Checked || rdbTrue.Checked))
            {
                errTinhTrang.SetError(rdbFalse, "Chưa nhập tình trạng");
                return false;
            }

            errTinhTrang.Clear();
            return true;
        }




        private void EditBook_Load(object sender, EventArgs e)
        {
            txtTenSach.Text = sach.ten;
            txtSoTrang.Text = sach.sotrang.ToString();
            txtGia.Text = sach.gia.ToString();
            txtSoLuong.Text = sach.soluong.ToString();
            txtNhaXuatBanMa.Text = sach.nhaxuatbanma;
            txtTacGiaMa.Text = sach.tacgiama;
            txtTheLoaiMa.Text = sach.theloaima;
            if (sach.tinhtrang == true)
            {

                rdbTrue.Checked = true;
                rdbFalse.Checked = false;
            }
            else rdbFalse.Checked = true;
            rtbNoiDungTomTat.Text = sach.noidungtomtat;

        }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.Controller;
using QLTV.Model;
using QLTV.View;


namespace QLTV.View
{
    public partial class AddBook : Form
    {
        Controllers control = new Controllers();
        Form Main = new Form();
        private uDSDauSach uDSDauSach;

        public AddBook()
        {
            InitializeComponent();

            cbbNhaXuatBanMa.DataSource = control.getListNhaXuatBan();
            cbbNhaXuatBanMa.DisplayMember = "ten";
            cbbNhaXuatBanMa.ValueMember = "ma";
            cbbTacGiaMa.DataSource = control.getListTacGia();
            cbbTacGiaMa.DisplayMember = "ten";
            cbbTacGiaMa.ValueMember = "ma";
            cbbTheLoaiMa.DataSource = control.getListTheLoai();
            cbbTheLoaiMa.DisplayMember = "ten";
            cbbTheLoaiMa.ValueMember = "ma";
         
        }
        private void ssbtnThemDS_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                Sach s = new Sach();
                s.ten = txtTenSach.Text.ToString().Trim();
                s.sotrang = int.Parse(txtSoTrang.Text.ToString().Trim());
                s.gia = int.Parse(txtGia.Text);
                s.nhaxuatbanma = cbbNhaXuatBanMa.SelectedValue.ToString().Trim();
               
                s.tacgiama = cbbTacGiaMa.SelectedValue.ToString().Trim();
                s.theloaima = cbbTheLoaiMa.SelectedValue.ToString().Trim();
                s.soluong = int.Parse(txtSoLuong.Text);
                s.noidungtomtat = rtbNoiDungTomTat.Text;
                
                if (control.addnewBook(s))
                {
                    this.Close();
                    this.Main.Visible = true;
                }
            }
        }
        public bool KiemTra()
        {
           if(txtTenSach.Text.ToString().Trim().Equals(""))
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
            if (cbbNhaXuatBanMa.Text.ToString().Trim().Equals(""))
            {
                errNXBMa.SetError(cbbNhaXuatBanMa, "Chưa nhập mã nhà xuất bản");
                return false;
            }
            errNXBMa.Clear();
            if (cbbTacGiaMa.Text.ToString().Trim().Equals(""))
            {
                errTacGiaMa.SetError(cbbTacGiaMa, "Chưa nhập mã tác giả");
                return false;
            }
            errTacGiaMa.Clear();
            if (cbbTheLoaiMa.Text.ToString().Trim().Equals(""))
            {
                errTheLoaiMa.SetError(cbbTheLoaiMa, "Chưa nhập mã thể loại");
                return false;
            }

            errTheLoaiMa.Clear();
            if (rtbNoiDungTomTat.Text.ToString().Trim().Equals(""))
            {
                errNoiDungTomTat.SetError(rtbNoiDungTomTat, "Chưa nhập nội dung tóm tắt");
                return false;
            }
            errNoiDungTomTat.Clear();
            //if (!(rdbFalse.Checked||rdbTrue.Checked))
            //{
            //    errTinhTrang.SetError(rdbFalse, "Chưa nhập tình trạng");
            //    return false;
            //}
      
            errTinhTrang.Clear();
            return true;
        }
        private void sbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLTV.View
{
    public partial class uHuongDanSuDung : UserControl
    {
        public uHuongDanSuDung()
        {
            InitializeComponent();
        }

        private void uHuongDanMuonSach_Load(object sender, EventArgs e)
        {
            HuongDanMuonSach_rtb.Text = 
                                      "(1) \t\t\tTHÔNG TIN ĐẦU SÁCH: Vào mục Quản lý đầu sách: \n"
                                    + "  Xem danh sách:\n"
                                    + "  Thêm mới: \n"
                                    + "      o Chọn thêm mới => Nhập thông tin vào phiếu\n"
                                    + "      => Click Thêm\n"
                                    + "      => Hoặc thoát\n"
                                    + "  Sửa:\n"
                                    + "      o Vào mục Quản lý đầu sách => Chọn Sửa \n"
                                    + "      => Xác nhận chỉnh sửa\n"
                                    + "      => Hoặc thoát.\n"
                                    + "  Xóa:\n"
                                    + "      o Chọn dòng có đối tượng cần xóa => Click xóa\n"
                                    + "      => Xác nhận thông tin xóa\n"
                                    + "      => Hoặc thoát \n"
                                    + "  Tìm kiếm:\n"
                                    + "      o Click Tìm kiếm\n"
                                    + "      o Nhập thông tin tìm kiếm\n\n"
                                    + "(2) \t\t\tTHÔNG TIN ĐỘC GIẢ: Vào mục Quản lý độc giả: \n"
                                    + "  Xem danh sách:\n"
                                    + "  Thêm mới: \n"
                                    + "      o Chọn thêm mới => Nhập thông tin vào phiếu\n"
                                    + "      => Click Thêm\n"
                                    + "      => Hoặc thoát\n"
                                    + "  Sửa:\n"
                                    + "      o Vào mục Quản lý độc giả => Chọn Sửa \n"
                                    + "      => Xác nhận chỉnh sửa\n"
                                    + "      => Hoặc thoát.\n"
                                    + " 	Xóa:\n"
                                    + "      o Chọn dòng có đối tượng cần xóa => Click xóa\n"
                                    + "      => Xác nhận thông tin xóa\n"
                                    + "      => Hoặc thoát \n"
                                    + "  Tìm kiếm:\n"
                                    + "      o Click Tìm kiếm\n"
                                    + "      o Nhập thông tin tìm kiếm\n\n\n"
                                    + " Mọi thắc mắc xin gửi về hòm thư admin_group4@gmail.com\n";
        }
    }
}

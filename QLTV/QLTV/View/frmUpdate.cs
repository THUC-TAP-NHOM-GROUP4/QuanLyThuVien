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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }
        private string str { get; set; }
        public frmUpdate(string str)
        {
            InitializeComponent();
            this.str = str;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            string[] str1 = str.Split('_');
            txtma.Text = str1[0];
            txtdocgiama.Text = str1[1];
            txtngaymuon.Text = str1[2];
            txtngaytra.Text = str1[3];
            txthantra.Text = str1[4];
            txtphathong.Text = str1[5];
            txtphatmat.Text = str1[6];
            txtphatquahan.Text = str1[7];
        }
        DataAcess da = new DataAcess();
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txthantra.Text != "" && txtphathong.Text != "" && txtphatmat.Text != "" && txtphatquahan.Text != "")
            {
                PhieuMuon pm = new PhieuMuon();
                pm.ngaytra = DateTime.Parse(txthantra.Text);
                pm.phathong = int.Parse(txtphathong.Text);
                pm.phatmat = int.Parse(txtphatmat.Text);
                pm.phatquahan = int.Parse(txtphatquahan.Text);
                pm.ma = txtma.Text;
                if (rdbdatra.Checked)
                    pm.trangthai = 1;

                da.NonQuery("update PhieuMuon set ngaytra='" + pm.ngaytra + "',phathong='" + pm.phathong + "',phatquahan='" + pm.phatquahan + "',phatmat='" + pm.phatmat + "' ,trangthai='" + pm.trangthai + "' where ma='" + pm.ma + "'");
                MessageBox.Show("Thành công");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

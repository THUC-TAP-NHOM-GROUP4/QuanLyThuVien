namespace QLTV.View
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTacGiaMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTheLoaiMa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbNoiDungTomTat = new System.Windows.Forms.RichTextBox();
            this.ssbtnThemDS = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.errTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTrang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNXBMa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTacGiaMa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTheLoaiMa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTinhTrang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNoiDungTomTat = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNhaXuatBanMa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNXBMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTacGiaMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTheLoaiMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTinhTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoiDungTomTat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(143, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số trang:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gía:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(16, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhà xuất bản mã:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSach.Location = new System.Drawing.Point(144, 24);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(224, 22);
            this.txtTenSach.TabIndex = 6;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTrang.Location = new System.Drawing.Point(144, 63);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(224, 22);
            this.txtSoTrang.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(144, 107);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(224, 22);
            this.txtGia.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(144, 149);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(224, 22);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtTacGiaMa
            // 
            this.txtTacGiaMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTacGiaMa.Location = new System.Drawing.Point(144, 236);
            this.txtTacGiaMa.Name = "txtTacGiaMa";
            this.txtTacGiaMa.Size = new System.Drawing.Size(224, 22);
            this.txtTacGiaMa.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(16, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tác giả mã:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(13, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Thể loại mã:";
            // 
            // txtTheLoaiMa
            // 
            this.txtTheLoaiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTheLoaiMa.Location = new System.Drawing.Point(144, 279);
            this.txtTheLoaiMa.Name = "txtTheLoaiMa";
            this.txtTheLoaiMa.Size = new System.Drawing.Size(224, 22);
            this.txtTheLoaiMa.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(16, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nội dung tóm tắt:";
            // 
            // rtbNoiDungTomTat
            // 
            this.rtbNoiDungTomTat.Location = new System.Drawing.Point(144, 325);
            this.rtbNoiDungTomTat.Name = "rtbNoiDungTomTat";
            this.rtbNoiDungTomTat.Size = new System.Drawing.Size(224, 96);
            this.rtbNoiDungTomTat.TabIndex = 20;
            this.rtbNoiDungTomTat.Text = "";
            // 
            // ssbtnThemDS
            // 
            this.ssbtnThemDS.Image = ((System.Drawing.Image)(resources.GetObject("ssbtnThemDS.Image")));
            this.ssbtnThemDS.Location = new System.Drawing.Point(157, 431);
            this.ssbtnThemDS.Name = "ssbtnThemDS";
            this.ssbtnThemDS.Size = new System.Drawing.Size(103, 34);
            this.ssbtnThemDS.TabIndex = 21;
            this.ssbtnThemDS.Text = "Thêm";
            this.ssbtnThemDS.Click += new System.EventHandler(this.ssbtnThemDS_Click);
            // 
            // sbtnThoat
            // 
            this.sbtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("sbtnThoat.Image")));
            this.sbtnThoat.Location = new System.Drawing.Point(262, 431);
            this.sbtnThoat.Name = "sbtnThoat";
            this.sbtnThoat.Size = new System.Drawing.Size(103, 34);
            this.sbtnThoat.TabIndex = 22;
            this.sbtnThoat.Text = "Thoát";
            this.sbtnThoat.Click += new System.EventHandler(this.sbtnThoat_Click);
            // 
            // errTen
            // 
            this.errTen.ContainerControl = this;
            // 
            // errTrang
            // 
            this.errTrang.ContainerControl = this;
            // 
            // errGia
            // 
            this.errGia.ContainerControl = this;
            // 
            // errSoLuong
            // 
            this.errSoLuong.ContainerControl = this;
            // 
            // errNXBMa
            // 
            this.errNXBMa.ContainerControl = this;
            // 
            // errTacGiaMa
            // 
            this.errTacGiaMa.ContainerControl = this;
            // 
            // errTheLoaiMa
            // 
            this.errTheLoaiMa.ContainerControl = this;
            // 
            // errTinhTrang
            // 
            this.errTinhTrang.ContainerControl = this;
            // 
            // errNoiDungTomTat
            // 
            this.errNoiDungTomTat.ContainerControl = this;
            // 
            // txtNhaXuatBanMa
            // 
            this.txtNhaXuatBanMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhaXuatBanMa.Location = new System.Drawing.Point(144, 191);
            this.txtNhaXuatBanMa.Name = "txtNhaXuatBanMa";
            this.txtNhaXuatBanMa.Size = new System.Drawing.Size(224, 22);
            this.txtNhaXuatBanMa.TabIndex = 10;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 465);
            this.Controls.Add(this.sbtnThoat);
            this.Controls.Add(this.ssbtnThemDS);
            this.Controls.Add(this.rtbNoiDungTomTat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTheLoaiMa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTacGiaMa);
            this.Controls.Add(this.txtNhaXuatBanMa);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.errTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNXBMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTacGiaMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTheLoaiMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTinhTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoiDungTomTat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTacGiaMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTheLoaiMa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbNoiDungTomTat;
        private DevExpress.XtraEditors.SimpleButton ssbtnThemDS;
        private DevExpress.XtraEditors.SimpleButton sbtnThoat;
        private System.Windows.Forms.ErrorProvider errTen;
        private System.Windows.Forms.ErrorProvider errTrang;
        private System.Windows.Forms.ErrorProvider errGia;
        private System.Windows.Forms.ErrorProvider errSoLuong;
        private System.Windows.Forms.ErrorProvider errNXBMa;
        private System.Windows.Forms.ErrorProvider errTacGiaMa;
        private System.Windows.Forms.ErrorProvider errTheLoaiMa;
        private System.Windows.Forms.ErrorProvider errTinhTrang;
        private System.Windows.Forms.ErrorProvider errNoiDungTomTat;
        private System.Windows.Forms.TextBox txtNhaXuatBanMa;
    }
}
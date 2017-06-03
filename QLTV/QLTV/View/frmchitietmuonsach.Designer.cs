namespace QLTV.View
{
    partial class frmchitietmuonsach
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
            this.txtphieumuon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DSChitietphieumuon = new System.Windows.Forms.DataGridView();
            this.cbbtacgia = new System.Windows.Forms.ComboBox();
            this.cbbnhaxuatban = new System.Windows.Forms.ComboBox();
            this.cbbtheloai = new System.Windows.Forms.ComboBox();
            this.cbbmasach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluulai = new System.Windows.Forms.Button();
            this.lbsachma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSChitietphieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtphieumuon
            // 
            this.txtphieumuon.Enabled = false;
            this.txtphieumuon.Location = new System.Drawing.Point(153, 84);
            this.txtphieumuon.Name = "txtphieumuon";
            this.txtphieumuon.Size = new System.Drawing.Size(194, 20);
            this.txtphieumuon.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Phiếu Mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Danh sách mượn của độc giả";
            // 
            // DSChitietphieumuon
            // 
            this.DSChitietphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSChitietphieumuon.Location = new System.Drawing.Point(18, 143);
            this.DSChitietphieumuon.Name = "DSChitietphieumuon";
            this.DSChitietphieumuon.Size = new System.Drawing.Size(733, 172);
            this.DSChitietphieumuon.TabIndex = 59;
            // 
            // cbbtacgia
            // 
            this.cbbtacgia.FormattingEnabled = true;
            this.cbbtacgia.Location = new System.Drawing.Point(153, 44);
            this.cbbtacgia.Name = "cbbtacgia";
            this.cbbtacgia.Size = new System.Drawing.Size(194, 21);
            this.cbbtacgia.TabIndex = 58;
            // 
            // cbbnhaxuatban
            // 
            this.cbbnhaxuatban.FormattingEnabled = true;
            this.cbbnhaxuatban.Location = new System.Drawing.Point(521, 6);
            this.cbbnhaxuatban.Name = "cbbnhaxuatban";
            this.cbbnhaxuatban.Size = new System.Drawing.Size(194, 21);
            this.cbbnhaxuatban.TabIndex = 57;
            // 
            // cbbtheloai
            // 
            this.cbbtheloai.FormattingEnabled = true;
            this.cbbtheloai.Location = new System.Drawing.Point(521, 42);
            this.cbbtheloai.Name = "cbbtheloai";
            this.cbbtheloai.Size = new System.Drawing.Size(194, 21);
            this.cbbtheloai.TabIndex = 56;
            // 
            // cbbmasach
            // 
            this.cbbmasach.FormattingEnabled = true;
            this.cbbmasach.Location = new System.Drawing.Point(153, 9);
            this.cbbmasach.Name = "cbbmasach";
            this.cbbmasach.Size = new System.Drawing.Size(194, 21);
            this.cbbmasach.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nhà xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tác giả";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(595, 321);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 44);
            this.btnthoat.TabIndex = 51;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnluulai
            // 
            this.btnluulai.Location = new System.Drawing.Point(513, 321);
            this.btnluulai.Name = "btnluulai";
            this.btnluulai.Size = new System.Drawing.Size(84, 44);
            this.btnluulai.TabIndex = 50;
            this.btnluulai.Text = "Lưu lại";
            this.btnluulai.UseVisualStyleBackColor = true;
            this.btnluulai.Click += new System.EventHandler(this.btnluulai_Click_1);
            // 
            // lbsachma
            // 
            this.lbsachma.AutoSize = true;
            this.lbsachma.Location = new System.Drawing.Point(47, 9);
            this.lbsachma.Name = "lbsachma";
            this.lbsachma.Size = new System.Drawing.Size(48, 13);
            this.lbsachma.TabIndex = 49;
            this.lbsachma.Text = "Mã sách";
            // 
            // frmchitietmuonsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 370);
            this.Controls.Add(this.txtphieumuon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DSChitietphieumuon);
            this.Controls.Add(this.cbbtacgia);
            this.Controls.Add(this.cbbnhaxuatban);
            this.Controls.Add(this.cbbtheloai);
            this.Controls.Add(this.cbbmasach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluulai);
            this.Controls.Add(this.lbsachma);
            this.Name = "frmchitietmuonsach";
            this.Text = "frmchitietmuonsach";
            this.Load += new System.EventHandler(this.frmchitietmuonsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSChitietphieumuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtphieumuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DSChitietphieumuon;
        private System.Windows.Forms.ComboBox cbbtacgia;
        private System.Windows.Forms.ComboBox cbbnhaxuatban;
        private System.Windows.Forms.ComboBox cbbtheloai;
        private System.Windows.Forms.ComboBox cbbmasach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluulai;
        private System.Windows.Forms.Label lbsachma;
    }
}
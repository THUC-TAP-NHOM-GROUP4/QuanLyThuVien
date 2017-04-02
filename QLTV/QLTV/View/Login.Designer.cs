namespace QLTV
{
    partial class Login
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.tedTenDN = new DevExpress.XtraEditors.TextEdit();
            this.tedMK = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(55, 64);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(183, 23);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Đăng Nhập";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(55, 120);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật Khẩu:";
            // 
            // sbtnDangNhap
            // 
            this.sbtnDangNhap.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sbtnDangNhap.Appearance.Options.UseFont = true;
            this.sbtnDangNhap.Location = new System.Drawing.Point(157, 238);
            this.sbtnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.sbtnDangNhap.Name = "sbtnDangNhap";
            this.sbtnDangNhap.Size = new System.Drawing.Size(100, 28);
            this.sbtnDangNhap.TabIndex = 3;
            this.sbtnDangNhap.Text = "Đăng Nhập";
            // 
            // tedTenDN
            // 
            this.tedTenDN.Location = new System.Drawing.Point(183, 58);
            this.tedTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.tedTenDN.Name = "tedTenDN";
            this.tedTenDN.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tedTenDN.Properties.Appearance.Options.UseFont = true;
            this.tedTenDN.Size = new System.Drawing.Size(159, 24);
            this.tedTenDN.TabIndex = 5;
            // 
            // tedMK
            // 
            this.tedMK.Location = new System.Drawing.Point(183, 114);
            this.tedMK.Margin = new System.Windows.Forms.Padding(4);
            this.tedMK.Name = "tedMK";
            this.tedMK.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tedMK.Properties.Appearance.Options.UseFont = true;
            this.tedMK.Size = new System.Drawing.Size(159, 24);
            this.tedMK.TabIndex = 6;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(55, 186);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Hiển thị mật khẩu";
            this.checkEdit1.Size = new System.Drawing.Size(132, 22);
            this.checkEdit1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(410, 291);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.tedMK);
            this.Controls.Add(this.tedTenDN);
            this.Controls.Add(this.sbtnDangNhap);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.tedTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbtnDangNhap;
        private DevExpress.XtraEditors.TextEdit tedTenDN;
        private DevExpress.XtraEditors.TextEdit tedMK;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}
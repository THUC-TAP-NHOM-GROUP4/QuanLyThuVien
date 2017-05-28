namespace QLTV.View
{
    partial class frmthem
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
            this.txthantra = new System.Windows.Forms.TextBox();
            this.txtngaymuon = new System.Windows.Forms.TextBox();
            this.cbbnhanvienma = new System.Windows.Forms.ComboBox();
            this.lbnhanvienma = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbbsach = new System.Windows.Forms.ComboBox();
            this.txtdocgiama = new System.Windows.Forms.TextBox();
            this.lbhantra = new System.Windows.Forms.Label();
            this.lbsachma = new System.Windows.Forms.Label();
            this.lbngaymuon = new System.Windows.Forms.Label();
            this.lbdocgiama = new System.Windows.Forms.Label();
            this.btnluulai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthantra
            // 
            this.txthantra.Location = new System.Drawing.Point(127, 112);
            this.txthantra.Name = "txthantra";
            this.txthantra.Size = new System.Drawing.Size(200, 20);
            this.txthantra.TabIndex = 31;
            // 
            // txtngaymuon
            // 
            this.txtngaymuon.Location = new System.Drawing.Point(475, 61);
            this.txtngaymuon.Name = "txtngaymuon";
            this.txtngaymuon.Size = new System.Drawing.Size(200, 20);
            this.txtngaymuon.TabIndex = 30;
            // 
            // cbbnhanvienma
            // 
            this.cbbnhanvienma.FormattingEnabled = true;
            this.cbbnhanvienma.Location = new System.Drawing.Point(475, 24);
            this.cbbnhanvienma.Name = "cbbnhanvienma";
            this.cbbnhanvienma.Size = new System.Drawing.Size(200, 21);
            this.cbbnhanvienma.TabIndex = 29;
            // 
            // lbnhanvienma
            // 
            this.lbnhanvienma.AutoSize = true;
            this.lbnhanvienma.Location = new System.Drawing.Point(363, 31);
            this.lbnhanvienma.Name = "lbnhanvienma";
            this.lbnhanvienma.Size = new System.Drawing.Size(72, 13);
            this.lbnhanvienma.TabIndex = 28;
            this.lbnhanvienma.Text = "Mã nhân viên";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(717, 327);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 44);
            this.btnthoat.TabIndex = 27;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(571, 327);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 44);
            this.btnthem.TabIndex = 26;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbbsach
            // 
            this.cbbsach.FormattingEnabled = true;
            this.cbbsach.Location = new System.Drawing.Point(127, 68);
            this.cbbsach.Name = "cbbsach";
            this.cbbsach.Size = new System.Drawing.Size(200, 21);
            this.cbbsach.TabIndex = 25;
            // 
            // txtdocgiama
            // 
            this.txtdocgiama.Location = new System.Drawing.Point(127, 31);
            this.txtdocgiama.Name = "txtdocgiama";
            this.txtdocgiama.Size = new System.Drawing.Size(200, 20);
            this.txtdocgiama.TabIndex = 24;
            // 
            // lbhantra
            // 
            this.lbhantra.AutoSize = true;
            this.lbhantra.Location = new System.Drawing.Point(30, 115);
            this.lbhantra.Name = "lbhantra";
            this.lbhantra.Size = new System.Drawing.Size(42, 13);
            this.lbhantra.TabIndex = 22;
            this.lbhantra.Text = "Hạn trả";
            // 
            // lbsachma
            // 
            this.lbsachma.AutoSize = true;
            this.lbsachma.Location = new System.Drawing.Point(30, 71);
            this.lbsachma.Name = "lbsachma";
            this.lbsachma.Size = new System.Drawing.Size(32, 13);
            this.lbsachma.TabIndex = 21;
            this.lbsachma.Text = "Sách";
            // 
            // lbngaymuon
            // 
            this.lbngaymuon.AutoSize = true;
            this.lbngaymuon.Location = new System.Drawing.Point(363, 68);
            this.lbngaymuon.Name = "lbngaymuon";
            this.lbngaymuon.Size = new System.Drawing.Size(61, 13);
            this.lbngaymuon.TabIndex = 20;
            this.lbngaymuon.Text = "Ngày mượn";
            // 
            // lbdocgiama
            // 
            this.lbdocgiama.AutoSize = true;
            this.lbdocgiama.Location = new System.Drawing.Point(30, 34);
            this.lbdocgiama.Name = "lbdocgiama";
            this.lbdocgiama.Size = new System.Drawing.Size(61, 13);
            this.lbdocgiama.TabIndex = 19;
            this.lbdocgiama.Text = "Mã độc giả";
            // 
            // btnluulai
            // 
            this.btnluulai.Location = new System.Drawing.Point(645, 327);
            this.btnluulai.Name = "btnluulai";
            this.btnluulai.Size = new System.Drawing.Size(75, 44);
            this.btnluulai.TabIndex = 32;
            this.btnluulai.Text = "Lưu lại";
            this.btnluulai.UseVisualStyleBackColor = true;
            this.btnluulai.Click += new System.EventHandler(this.btnluulai_Click);
            // 
            // frmthem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 396);
            this.Controls.Add(this.btnluulai);
            this.Controls.Add(this.txthantra);
            this.Controls.Add(this.txtngaymuon);
            this.Controls.Add(this.cbbnhanvienma);
            this.Controls.Add(this.lbnhanvienma);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbbsach);
            this.Controls.Add(this.txtdocgiama);
            this.Controls.Add(this.lbhantra);
            this.Controls.Add(this.lbsachma);
            this.Controls.Add(this.lbngaymuon);
            this.Controls.Add(this.lbdocgiama);
            this.Name = "frmthem";
            this.Text = "frmthem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthantra;
        private System.Windows.Forms.TextBox txtngaymuon;
        private System.Windows.Forms.ComboBox cbbnhanvienma;
        private System.Windows.Forms.Label lbnhanvienma;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbbsach;
        private System.Windows.Forms.TextBox txtdocgiama;
        private System.Windows.Forms.Label lbhantra;
        private System.Windows.Forms.Label lbsachma;
        private System.Windows.Forms.Label lbngaymuon;
        private System.Windows.Forms.Label lbdocgiama;
        private System.Windows.Forms.Button btnluulai;
    }
}
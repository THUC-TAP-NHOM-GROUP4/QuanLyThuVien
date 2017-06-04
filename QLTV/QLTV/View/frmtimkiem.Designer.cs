namespace QLTV.View
{
    partial class frmtimkiem
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
            this.dgrtimkiemphieumuon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.rdbhantra = new System.Windows.Forms.RadioButton();
            this.rdbmasach = new System.Windows.Forms.RadioButton();
            this.rdbphieumuonma = new System.Windows.Forms.RadioButton();
            this.rdbmadocgia = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrtimkiemphieumuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrtimkiemphieumuon
            // 
            this.dgrtimkiemphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrtimkiemphieumuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrtimkiemphieumuon.Location = new System.Drawing.Point(0, 195);
            this.dgrtimkiemphieumuon.Name = "dgrtimkiemphieumuon";
            this.dgrtimkiemphieumuon.Size = new System.Drawing.Size(941, 223);
            this.dgrtimkiemphieumuon.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.rdbhantra);
            this.groupBox1.Controls.Add(this.rdbmasach);
            this.groupBox1.Controls.Add(this.rdbphieumuonma);
            this.groupBox1.Controls.Add(this.rdbmadocgia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(176, 59);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(176, 16);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 5;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(265, 20);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(245, 20);
            this.txttukhoa.TabIndex = 4;
            this.txttukhoa.Text = "  ---Nhập từ khóa---";
            this.txttukhoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttukhoa_MouseClick);
            this.txttukhoa.TextChanged += new System.EventHandler(this.txttukhoa_TextChanged);
            // 
            // rdbhantra
            // 
            this.rdbhantra.AutoSize = true;
            this.rdbhantra.Location = new System.Drawing.Point(566, 88);
            this.rdbhantra.Name = "rdbhantra";
            this.rdbhantra.Size = new System.Drawing.Size(60, 17);
            this.rdbhantra.TabIndex = 3;
            this.rdbhantra.TabStop = true;
            this.rdbhantra.Text = "Hạn trả";
            this.rdbhantra.UseVisualStyleBackColor = true;
            // 
            // rdbmasach
            // 
            this.rdbmasach.AutoSize = true;
            this.rdbmasach.Location = new System.Drawing.Point(566, 65);
            this.rdbmasach.Name = "rdbmasach";
            this.rdbmasach.Size = new System.Drawing.Size(66, 17);
            this.rdbmasach.TabIndex = 2;
            this.rdbmasach.TabStop = true;
            this.rdbmasach.Text = "Mã sách";
            this.rdbmasach.UseVisualStyleBackColor = true;
            // 
            // rdbphieumuonma
            // 
            this.rdbphieumuonma.AutoSize = true;
            this.rdbphieumuonma.Location = new System.Drawing.Point(566, 42);
            this.rdbphieumuonma.Name = "rdbphieumuonma";
            this.rdbphieumuonma.Size = new System.Drawing.Size(98, 17);
            this.rdbphieumuonma.TabIndex = 1;
            this.rdbphieumuonma.TabStop = true;
            this.rdbphieumuonma.Text = "Mã phiếu mượn";
            this.rdbphieumuonma.UseVisualStyleBackColor = true;
            // 
            // rdbmadocgia
            // 
            this.rdbmadocgia.AutoSize = true;
            this.rdbmadocgia.Location = new System.Drawing.Point(566, 19);
            this.rdbmadocgia.Name = "rdbmadocgia";
            this.rdbmadocgia.Size = new System.Drawing.Size(62, 17);
            this.rdbmadocgia.TabIndex = 0;
            this.rdbmadocgia.TabStop = true;
            this.rdbmadocgia.Text = "Độc giả";
            this.rdbmadocgia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách ";
            // 
            // frmtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrtimkiemphieumuon);
            this.Name = "frmtimkiem";
            this.Text = "frmtimkiem";
            this.Load += new System.EventHandler(this.frmtimkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrtimkiemphieumuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrtimkiemphieumuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbphieumuonma;
        private System.Windows.Forms.RadioButton rdbmadocgia;
        private System.Windows.Forms.RadioButton rdbhantra;
        private System.Windows.Forms.RadioButton rdbmasach;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
    }
}
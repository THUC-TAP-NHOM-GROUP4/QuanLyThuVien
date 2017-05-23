namespace QLTV
{
    partial class uDSDocGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uDSDocGia));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ssbtnTimkiemDG = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoaDG = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSuaDG = new DevExpress.XtraEditors.SimpleButton();
            this.ssbtnThemDG = new DevExpress.XtraEditors.SimpleButton();
            this.grcDSDocGia = new DevExpress.XtraGrid.GridControl();
            this.grvDocGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbbmasv = new System.Windows.Forms.ComboBox();
            this.lbmasv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grcDSDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(4, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 16);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Danh sách độc giả";
            // 
            // ssbtnTimkiemDG
            // 
            this.ssbtnTimkiemDG.Image = ((System.Drawing.Image)(resources.GetObject("ssbtnTimkiemDG.Image")));
            this.ssbtnTimkiemDG.Location = new System.Drawing.Point(783, 408);
            this.ssbtnTimkiemDG.Name = "ssbtnTimkiemDG";
            this.ssbtnTimkiemDG.Size = new System.Drawing.Size(103, 44);
            this.ssbtnTimkiemDG.TabIndex = 10;
            this.ssbtnTimkiemDG.Text = "Tìm Kiếm";
            this.ssbtnTimkiemDG.Click += new System.EventHandler(this.ssbtnTimkiemDG_Click);
            // 
            // sbtnXoaDG
            // 
            this.sbtnXoaDG.Image = ((System.Drawing.Image)(resources.GetObject("sbtnXoaDG.Image")));
            this.sbtnXoaDG.Location = new System.Drawing.Point(679, 408);
            this.sbtnXoaDG.Name = "sbtnXoaDG";
            this.sbtnXoaDG.Size = new System.Drawing.Size(103, 44);
            this.sbtnXoaDG.TabIndex = 9;
            this.sbtnXoaDG.Text = "Xóa";
            this.sbtnXoaDG.Click += new System.EventHandler(this.sbtnXoaDG_Click);
            // 
            // sbtnSuaDG
            // 
            this.sbtnSuaDG.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSuaDG.Image")));
            this.sbtnSuaDG.Location = new System.Drawing.Point(575, 408);
            this.sbtnSuaDG.Name = "sbtnSuaDG";
            this.sbtnSuaDG.Size = new System.Drawing.Size(103, 44);
            this.sbtnSuaDG.TabIndex = 8;
            this.sbtnSuaDG.Text = "Sửa";
            this.sbtnSuaDG.Click += new System.EventHandler(this.sbtnSuaDG_Click);
            // 
            // ssbtnThemDG
            // 
            this.ssbtnThemDG.Image = ((System.Drawing.Image)(resources.GetObject("ssbtnThemDG.Image")));
            this.ssbtnThemDG.Location = new System.Drawing.Point(471, 408);
            this.ssbtnThemDG.Name = "ssbtnThemDG";
            this.ssbtnThemDG.Size = new System.Drawing.Size(103, 44);
            this.ssbtnThemDG.TabIndex = 7;
            this.ssbtnThemDG.Text = "Thêm";
            this.ssbtnThemDG.Click += new System.EventHandler(this.ssbtnThemDG_Click);
            // 
            // grcDSDocGia
            // 
            this.grcDSDocGia.Location = new System.Drawing.Point(3, 34);
            this.grcDSDocGia.MainView = this.grvDocGia;
            this.grcDSDocGia.Name = "grcDSDocGia";
            this.grcDSDocGia.Size = new System.Drawing.Size(883, 368);
            this.grcDSDocGia.TabIndex = 6;
            this.grcDSDocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDocGia});
            this.grcDSDocGia.Click += new System.EventHandler(this.grcDSDocGia_Click);
            // 
            // grvDocGia
            // 
            this.grvDocGia.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grvDocGia.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grvDocGia.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grvDocGia.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvDocGia.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grvDocGia.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.grvDocGia.Appearance.Row.Options.UseBackColor = true;
            this.grvDocGia.GridControl = this.grcDSDocGia;
            this.grvDocGia.Name = "grvDocGia";
            // 
            // cbbmasv
            // 
            this.cbbmasv.FormattingEnabled = true;
            this.cbbmasv.Location = new System.Drawing.Point(163, 425);
            this.cbbmasv.Name = "cbbmasv";
            this.cbbmasv.Size = new System.Drawing.Size(178, 21);
            this.cbbmasv.TabIndex = 12;
            this.cbbmasv.SelectedIndexChanged += new System.EventHandler(this.cbbmasv_SelectedIndexChanged);
            // 
            // lbmasv
            // 
            this.lbmasv.AutoSize = true;
            this.lbmasv.Location = new System.Drawing.Point(85, 425);
            this.lbmasv.Name = "lbmasv";
            this.lbmasv.Size = new System.Drawing.Size(61, 13);
            this.lbmasv.TabIndex = 13;
            this.lbmasv.Text = "Mã độc giả";
            // 
            // uDSDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.lbmasv);
            this.Controls.Add(this.cbbmasv);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ssbtnTimkiemDG);
            this.Controls.Add(this.sbtnXoaDG);
            this.Controls.Add(this.sbtnSuaDG);
            this.Controls.Add(this.ssbtnThemDG);
            this.Controls.Add(this.grcDSDocGia);
            this.Name = "uDSDocGia";
            this.Size = new System.Drawing.Size(889, 473);
            this.Load += new System.EventHandler(this.uDSDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcDSDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ssbtnTimkiemDG;
        private DevExpress.XtraEditors.SimpleButton sbtnXoaDG;
        private DevExpress.XtraEditors.SimpleButton sbtnSuaDG;
        private DevExpress.XtraEditors.SimpleButton ssbtnThemDG;
        private DevExpress.XtraGrid.GridControl grcDSDocGia;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDocGia;
        private System.Windows.Forms.ComboBox cbbmasv;
        private System.Windows.Forms.Label lbmasv;
    }
}

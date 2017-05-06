namespace QLTV
{
    partial class uDSDauSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uDSDauSach));
            this.grcDSDauSach = new DevExpress.XtraGrid.GridControl();
            this.grvSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ssbtnThemDS = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSuaDS = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoaDS = new DevExpress.XtraEditors.SimpleButton();
            this.ssbtnTimkiemDS = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcDSDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grcDSDauSach
            // 
            this.grcDSDauSach.Location = new System.Drawing.Point(0, 31);
            this.grcDSDauSach.MainView = this.grvSach;
            this.grcDSDauSach.Name = "grcDSDauSach";
            this.grcDSDauSach.Size = new System.Drawing.Size(886, 402);
            this.grcDSDauSach.TabIndex = 0;
            this.grcDSDauSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSach});
            // 
            // grvSach
            // 
            this.grvSach.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grvSach.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grvSach.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grvSach.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvSach.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grvSach.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.grvSach.Appearance.Row.Options.UseBackColor = true;
            this.grvSach.GridControl = this.grcDSDauSach;
            this.grvSach.Name = "grvSach";
            // 
            // ssbtnThemDS
            // 
            this.ssbtnThemDS.Image = ((System.Drawing.Image)(resources.GetObject("ssbtnThemDS.Image")));
            this.ssbtnThemDS.Location = new System.Drawing.Point(472, 439);
            this.ssbtnThemDS.Name = "ssbtnThemDS";
            this.ssbtnThemDS.Size = new System.Drawing.Size(103, 47);
            this.ssbtnThemDS.TabIndex = 1;
            this.ssbtnThemDS.Text = "Thêm";
            this.ssbtnThemDS.Click += new System.EventHandler(this.ssbtnThemDS_Click);
            // 
            // sbtnSuaDS
            // 
            this.sbtnSuaDS.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSuaDS.Image")));
            this.sbtnSuaDS.Location = new System.Drawing.Point(576, 439);
            this.sbtnSuaDS.Name = "sbtnSuaDS";
            this.sbtnSuaDS.Size = new System.Drawing.Size(103, 47);
            this.sbtnSuaDS.TabIndex = 2;
            this.sbtnSuaDS.Text = "Sửa";
            this.sbtnSuaDS.Click += new System.EventHandler(this.sbtnSuaDS_Click);
            // 
            // sbtnXoaDS
            // 
            this.sbtnXoaDS.Image = ((System.Drawing.Image)(resources.GetObject("sbtnXoaDS.Image")));
            this.sbtnXoaDS.Location = new System.Drawing.Point(680, 439);
            this.sbtnXoaDS.Name = "sbtnXoaDS";
            this.sbtnXoaDS.Size = new System.Drawing.Size(103, 47);
            this.sbtnXoaDS.TabIndex = 3;
            this.sbtnXoaDS.Text = "Xóa";
            this.sbtnXoaDS.Click += new System.EventHandler(this.sbtnXoaDS_Click);
            // 
            // ssbtnTimkiemDS
            // 
            this.ssbtnTimkiemDS.Image = ((System.Drawing.Image)(resources.GetObject("ssbtnTimkiemDS.Image")));
            this.ssbtnTimkiemDS.Location = new System.Drawing.Point(784, 439);
            this.ssbtnTimkiemDS.Name = "ssbtnTimkiemDS";
            this.ssbtnTimkiemDS.Size = new System.Drawing.Size(103, 47);
            this.ssbtnTimkiemDS.TabIndex = 4;
            this.ssbtnTimkiemDS.Text = "Tìm Kiếm";
            this.ssbtnTimkiemDS.Click += new System.EventHandler(this.ssbtnTimkiemDS_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(4, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Danh sách đầu sách";
            // 
            // uDSDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ssbtnTimkiemDS);
            this.Controls.Add(this.sbtnXoaDS);
            this.Controls.Add(this.sbtnSuaDS);
            this.Controls.Add(this.ssbtnThemDS);
            this.Controls.Add(this.grcDSDauSach);
            this.Name = "uDSDauSach";
            this.Size = new System.Drawing.Size(889, 509);
            this.Load += new System.EventHandler(this.uDSDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcDSDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcDSDauSach;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSach;
        private DevExpress.XtraEditors.SimpleButton ssbtnThemDS;
        private DevExpress.XtraEditors.SimpleButton sbtnSuaDS;
        private DevExpress.XtraEditors.SimpleButton sbtnXoaDS;
        private DevExpress.XtraEditors.SimpleButton ssbtnTimkiemDS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

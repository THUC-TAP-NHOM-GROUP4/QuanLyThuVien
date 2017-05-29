namespace QLTV.View
{
    partial class uHuongDanSuDung
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
            this.label1 = new System.Windows.Forms.Label();
            this.HuongDanMuonSach_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(333, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "HƯỚNG DẪN SỬ DỤNG PHẦN MỀM";
            // 
            // HuongDanMuonSach_rtb
            // 
            this.HuongDanMuonSach_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HuongDanMuonSach_rtb.Location = new System.Drawing.Point(0, 37);
            this.HuongDanMuonSach_rtb.Name = "HuongDanMuonSach_rtb";
            this.HuongDanMuonSach_rtb.Size = new System.Drawing.Size(881, 401);
            this.HuongDanMuonSach_rtb.TabIndex = 0;
            this.HuongDanMuonSach_rtb.Text = "";
            // 
            // uHuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HuongDanMuonSach_rtb);
            this.Name = "uHuongDanSuDung";
            this.Size = new System.Drawing.Size(881, 438);
            this.Load += new System.EventHandler(this.uHuongDanMuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox HuongDanMuonSach_rtb;
    }
}

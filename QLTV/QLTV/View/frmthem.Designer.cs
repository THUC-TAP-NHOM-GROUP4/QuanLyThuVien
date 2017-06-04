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
            this.btnthem = new System.Windows.Forms.Button();
            this.cbbdocgia = new System.Windows.Forms.ComboBox();
            this.txthantra = new System.Windows.Forms.TextBox();
            this.txtngaymuon = new System.Windows.Forms.TextBox();
            this.cbbnhanvienma = new System.Windows.Forms.ComboBox();
            this.lbnhanvienma = new System.Windows.Forms.Label();
            this.lbhantra = new System.Windows.Forms.Label();
            this.lbngaymuon = new System.Windows.Forms.Label();
            this.lbdocgiama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(159, 322);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 44);
            this.btnthem.TabIndex = 26;
            this.btnthem.Text = "Mượn sách";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbbdocgia
            // 
            this.cbbdocgia.FormattingEnabled = true;
            this.cbbdocgia.Location = new System.Drawing.Point(135, 18);
            this.cbbdocgia.Name = "cbbdocgia";
            this.cbbdocgia.Size = new System.Drawing.Size(198, 21);
            this.cbbdocgia.TabIndex = 42;
            // 
            // txthantra
            // 
            this.txthantra.Location = new System.Drawing.Point(133, 199);
            this.txthantra.Name = "txthantra";
            this.txthantra.Size = new System.Drawing.Size(200, 20);
            this.txthantra.TabIndex = 41;
            // 
            // txtngaymuon
            // 
            this.txtngaymuon.Location = new System.Drawing.Point(135, 78);
            this.txtngaymuon.Name = "txtngaymuon";
            this.txtngaymuon.Size = new System.Drawing.Size(200, 20);
            this.txtngaymuon.TabIndex = 40;
            // 
            // cbbnhanvienma
            // 
            this.cbbnhanvienma.FormattingEnabled = true;
            this.cbbnhanvienma.Location = new System.Drawing.Point(135, 138);
            this.cbbnhanvienma.Name = "cbbnhanvienma";
            this.cbbnhanvienma.Size = new System.Drawing.Size(200, 21);
            this.cbbnhanvienma.TabIndex = 39;
            // 
            // lbnhanvienma
            // 
            this.lbnhanvienma.AutoSize = true;
            this.lbnhanvienma.Location = new System.Drawing.Point(36, 146);
            this.lbnhanvienma.Name = "lbnhanvienma";
            this.lbnhanvienma.Size = new System.Drawing.Size(72, 13);
            this.lbnhanvienma.TabIndex = 38;
            this.lbnhanvienma.Text = "Mã nhân viên";
            // 
            // lbhantra
            // 
            this.lbhantra.AutoSize = true;
            this.lbhantra.Location = new System.Drawing.Point(36, 202);
            this.lbhantra.Name = "lbhantra";
            this.lbhantra.Size = new System.Drawing.Size(42, 13);
            this.lbhantra.TabIndex = 35;
            this.lbhantra.Text = "Hạn trả";
            // 
            // lbngaymuon
            // 
            this.lbngaymuon.AutoSize = true;
            this.lbngaymuon.Location = new System.Drawing.Point(36, 85);
            this.lbngaymuon.Name = "lbngaymuon";
            this.lbngaymuon.Size = new System.Drawing.Size(61, 13);
            this.lbngaymuon.TabIndex = 34;
            this.lbngaymuon.Text = "Ngày mượn";
            // 
            // lbdocgiama
            // 
            this.lbdocgiama.AutoSize = true;
            this.lbdocgiama.Location = new System.Drawing.Point(36, 27);
            this.lbdocgiama.Name = "lbdocgiama";
            this.lbdocgiama.Size = new System.Drawing.Size(61, 13);
            this.lbdocgiama.TabIndex = 33;
            this.lbdocgiama.Text = "Mã độc giả";
            // 
            // frmthem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 396);
            this.Controls.Add(this.cbbdocgia);
            this.Controls.Add(this.txthantra);
            this.Controls.Add(this.txtngaymuon);
            this.Controls.Add(this.cbbnhanvienma);
            this.Controls.Add(this.lbnhanvienma);
            this.Controls.Add(this.lbhantra);
            this.Controls.Add(this.lbngaymuon);
            this.Controls.Add(this.lbdocgiama);
            this.Controls.Add(this.btnthem);
            this.Name = "frmthem";
            this.Text = "frmthem";
            this.Load += new System.EventHandler(this.frmthem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbbdocgia;
        private System.Windows.Forms.TextBox txthantra;
        private System.Windows.Forms.TextBox txtngaymuon;
        private System.Windows.Forms.ComboBox cbbnhanvienma;
        private System.Windows.Forms.Label lbnhanvienma;
        private System.Windows.Forms.Label lbhantra;
        private System.Windows.Forms.Label lbngaymuon;
        private System.Windows.Forms.Label lbdocgiama;
    }
}
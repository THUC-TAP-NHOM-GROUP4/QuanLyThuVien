namespace QLTV.View
{
    partial class SearchReader
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
            this.btnTKDG = new System.Windows.Forms.Button();
            this.txtTKDG = new System.Windows.Forms.TextBox();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTKDG
            // 
            this.btnTKDG.Location = new System.Drawing.Point(75, 95);
            this.btnTKDG.Name = "btnTKDG";
            this.btnTKDG.Size = new System.Drawing.Size(75, 23);
            this.btnTKDG.TabIndex = 0;
            this.btnTKDG.Text = "Tìm Kiếm";
            this.btnTKDG.UseVisualStyleBackColor = true;
            this.btnTKDG.Click += new System.EventHandler(this.btnTKDG_Click);
            // 
            // txtTKDG
            // 
            this.txtTKDG.Location = new System.Drawing.Point(169, 95);
            this.txtTKDG.Name = "txtTKDG";
            this.txtTKDG.Size = new System.Drawing.Size(251, 20);
            this.txtTKDG.TabIndex = 1;
            // 
            // dgvReader
            // 
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Location = new System.Drawing.Point(2, 164);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.Size = new System.Drawing.Size(611, 218);
            this.dgvReader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÌM KIẾM ĐỘC GIẢ";
            // 
            // SearchReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReader);
            this.Controls.Add(this.txtTKDG);
            this.Controls.Add(this.btnTKDG);
            this.Name = "SearchReader";
            this.Text = "SearchReader";
            this.Load += new System.EventHandler(this.SearchReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTKDG;
        private System.Windows.Forms.TextBox txtTKDG;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Label label1;
    }
}
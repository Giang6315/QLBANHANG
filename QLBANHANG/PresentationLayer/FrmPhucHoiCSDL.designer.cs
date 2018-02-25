namespace QLBANHANG.PresentationLayer
{
    partial class FrmPhucHoiCSDL
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
            this.btnPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaoLuu = new DevExpress.XtraEditors.TextEdit();
            this.btnDuyet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaoLuu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoi.Appearance.Options.UseFont = true;
            this.btnPhucHoi.Location = new System.Drawing.Point(234, 132);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(106, 28);
            this.btnPhucHoi.TabIndex = 3;
            this.btnPhucHoi.Text = "Phục Hồi ";
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Chọn nơi lưu";
            // 
            // txtSaoLuu
            // 
            this.txtSaoLuu.Location = new System.Drawing.Point(107, 55);
            this.txtSaoLuu.Name = "txtSaoLuu";
            this.txtSaoLuu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaoLuu.Properties.Appearance.Options.UseFont = true;
            this.txtSaoLuu.Size = new System.Drawing.Size(310, 26);
            this.txtSaoLuu.TabIndex = 6;
            // 
            // btnDuyet
            // 
            this.btnDuyet.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.Appearance.Options.UseFont = true;
            this.btnDuyet.Location = new System.Drawing.Point(439, 53);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(69, 28);
            this.btnDuyet.TabIndex = 7;
            this.btnDuyet.Text = "Duyệt...";
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // FrmPhucHoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 225);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.txtSaoLuu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPhucHoi);
            this.Name = "FrmPhucHoiCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi phục cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.FrmSaoLuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSaoLuu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPhucHoi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSaoLuu;
        private DevExpress.XtraEditors.SimpleButton btnDuyet;
    }
}
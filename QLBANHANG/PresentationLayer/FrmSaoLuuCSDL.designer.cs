namespace QLBANHANG.PresentationLayer
{
    partial class FrmSaoLuuCSDL
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
            this.btnDuyet = new DevExpress.XtraEditors.SimpleButton();
            this.txtSaoLuu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSaoLuu = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaoLuu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuyet
            // 
            this.btnDuyet.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.Appearance.Options.UseFont = true;
            this.btnDuyet.Location = new System.Drawing.Point(426, 52);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(69, 28);
            this.btnDuyet.TabIndex = 15;
            this.btnDuyet.Text = "Duyệt...";
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // txtSaoLuu
            // 
            this.txtSaoLuu.Location = new System.Drawing.Point(129, 54);
            this.txtSaoLuu.Name = "txtSaoLuu";
            this.txtSaoLuu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaoLuu.Properties.Appearance.Options.UseFont = true;
            this.txtSaoLuu.Size = new System.Drawing.Size(270, 26);
            this.txtSaoLuu.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(18, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 19);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Chọn nơi lưu";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuu.Appearance.Options.UseFont = true;
            this.btnSaoLuu.Location = new System.Drawing.Point(214, 115);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(106, 28);
            this.btnSaoLuu.TabIndex = 12;
            this.btnSaoLuu.Text = "Sao Lưu";
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "QUANLYKHACHHANG";
            this.saveFileDialog.Filter = "Tất cả tập tin|*.*";
            // 
            // FrmSaoLuuCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 191);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.txtSaoLuu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSaoLuu);
            this.Name = "FrmSaoLuuCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSaoLuuCSDL";
            ((System.ComponentModel.ISupportInitialize)(this.txtSaoLuu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDuyet;
        private DevExpress.XtraEditors.TextEdit txtSaoLuu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSaoLuu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
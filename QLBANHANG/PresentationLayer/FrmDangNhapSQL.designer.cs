namespace QLBANHANG
{
    partial class FrmDangNhapSQL
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
            this.btn_DangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.rd_SQLServer = new System.Windows.Forms.RadioButton();
            this.rd_Windows = new System.Windows.Forms.RadioButton();
            this.txt_TenServer = new System.Windows.Forms.TextBox();
            this.txt_TenUser = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CoSoDuLieu = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Appearance.Options.UseFont = true;
            this.btn_DangNhap.Location = new System.Drawing.Point(91, 381);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(88, 36);
            this.btn_DangNhap.TabIndex = 0;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(242, 381);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 36);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(24, 43);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên Server";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(24, 85);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên User";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(24, 125);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Mật Khẩu";
            // 
            // rd_SQLServer
            // 
            this.rd_SQLServer.AutoSize = true;
            this.rd_SQLServer.Location = new System.Drawing.Point(25, 71);
            this.rd_SQLServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rd_SQLServer.Name = "rd_SQLServer";
            this.rd_SQLServer.Size = new System.Drawing.Size(174, 23);
            this.rd_SQLServer.TabIndex = 1;
            this.rd_SQLServer.TabStop = true;
            this.rd_SQLServer.Text = "Tài khoản SQL Server";
            this.rd_SQLServer.UseVisualStyleBackColor = true;
            // 
            // rd_Windows
            // 
            this.rd_Windows.AutoSize = true;
            this.rd_Windows.Location = new System.Drawing.Point(26, 35);
            this.rd_Windows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rd_Windows.Name = "rd_Windows";
            this.rd_Windows.Size = new System.Drawing.Size(163, 23);
            this.rd_Windows.TabIndex = 0;
            this.rd_Windows.TabStop = true;
            this.rd_Windows.Text = "Tài Khoản Windows";
            this.rd_Windows.UseVisualStyleBackColor = true;
            this.rd_Windows.CheckedChanged += new System.EventHandler(this.rd_Windows_CheckedChanged);
            // 
            // txt_TenServer
            // 
            this.txt_TenServer.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenServer.Location = new System.Drawing.Point(123, 36);
            this.txt_TenServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TenServer.MaxLength = 12;
            this.txt_TenServer.Name = "txt_TenServer";
            this.txt_TenServer.Size = new System.Drawing.Size(226, 27);
            this.txt_TenServer.TabIndex = 5;
            // 
            // txt_TenUser
            // 
            this.txt_TenUser.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenUser.Location = new System.Drawing.Point(123, 77);
            this.txt_TenUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TenUser.Name = "txt_TenUser";
            this.txt_TenUser.Size = new System.Drawing.Size(226, 27);
            this.txt_TenUser.TabIndex = 5;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(123, 118);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MatKhau.MaxLength = 12;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(226, 27);
            this.txt_MatKhau.TabIndex = 5;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(23, 163);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Cơ sở dữ liệu";
            // 
            // txt_CoSoDuLieu
            // 
            this.txt_CoSoDuLieu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CoSoDuLieu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoSoDuLieu.Location = new System.Drawing.Point(123, 156);
            this.txt_CoSoDuLieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_CoSoDuLieu.MaxLength = 252;
            this.txt_CoSoDuLieu.Name = "txt_CoSoDuLieu";
            this.txt_CoSoDuLieu.Size = new System.Drawing.Size(226, 27);
            this.txt_CoSoDuLieu.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_CoSoDuLieu);
            this.groupControl1.Controls.Add(this.txt_MatKhau);
            this.groupControl1.Controls.Add(this.txt_TenUser);
            this.groupControl1.Controls.Add(this.txt_TenServer);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(23, 147);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(364, 201);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông tin đăng nhập";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rd_SQLServer);
            this.groupControl2.Controls.Add(this.rd_Windows);
            this.groupControl2.Location = new System.Drawing.Point(69, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(262, 119);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Tài khoản đăng nhập";
            // 
            // FrmDangNhapSQL
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 449);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDangNhapSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập SQL";
            this.Load += new System.EventHandler(this.FrmDangNhapSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_DangNhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RadioButton rd_SQLServer;
        private System.Windows.Forms.RadioButton rd_Windows;
        private System.Windows.Forms.TextBox txt_TenServer;
        private System.Windows.Forms.TextBox txt_TenUser;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_CoSoDuLieu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;

    }
}
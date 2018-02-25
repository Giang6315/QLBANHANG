namespace QLBANHANG.PresentationLayer
{
    partial class xfrmQuiCach
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
            this.dgvDonViTinh = new System.Windows.Forms.DataGridView();
            this.MADVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonViTinh
            // 
            this.dgvDonViTinh.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonViTinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADVI,
            this.TENDVI});
            this.dgvDonViTinh.Location = new System.Drawing.Point(29, 11);
            this.dgvDonViTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDonViTinh.Name = "dgvDonViTinh";
            this.dgvDonViTinh.RowTemplate.Height = 24;
            this.dgvDonViTinh.Size = new System.Drawing.Size(375, 378);
            this.dgvDonViTinh.TabIndex = 1;
            // 
            // MADVI
            // 
            this.MADVI.DataPropertyName = "MADVI";
            this.MADVI.HeaderText = "Mã Đơn Vị";
            this.MADVI.Name = "MADVI";
            this.MADVI.ReadOnly = true;
            this.MADVI.Width = 150;
            // 
            // TENDVI
            // 
            this.TENDVI.DataPropertyName = "TENDVI";
            this.TENDVI.HeaderText = "Tên Đơn Vị";
            this.TENDVI.Name = "TENDVI";
            this.TENDVI.Width = 180;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(410, 193);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Location = new System.Drawing.Point(410, 70);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(88, 32);
            this.btn_CapNhat.TabIndex = 41;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(410, 130);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 32);
            this.btn_Xoa.TabIndex = 40;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Enabled = false;
            this.btn_Them.Location = new System.Drawing.Point(410, 11);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(88, 32);
            this.btn_Them.TabIndex = 39;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // xfrmQuiCach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 461);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgvDonViTinh);
            this.Name = "xfrmQuiCach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "xfrmQuiCach";
            this.Load += new System.EventHandler(this.xfrmQuiCach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonViTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDVI;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
    }
}
namespace QLBANHANG.PresentationLayer
{
    partial class FrmLoaiKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xtraTabControl_LoaiKhachHang = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_LoaiKhachHang = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvLoaiKH = new System.Windows.Forms.DataGridView();
            this.MALOAIKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAIKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_LoaiKhachHang)).BeginInit();
            this.xtraTabControl_LoaiKhachHang.SuspendLayout();
            this.xtraTabPage_LoaiKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKH)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl_LoaiKhachHang
            // 
            this.xtraTabControl_LoaiKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_LoaiKhachHang.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_LoaiKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl_LoaiKhachHang.Name = "xtraTabControl_LoaiKhachHang";
            this.xtraTabControl_LoaiKhachHang.SelectedTabPage = this.xtraTabPage_LoaiKhachHang;
            this.xtraTabControl_LoaiKhachHang.Size = new System.Drawing.Size(529, 402);
            this.xtraTabControl_LoaiKhachHang.TabIndex = 0;
            this.xtraTabControl_LoaiKhachHang.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_LoaiKhachHang});
            // 
            // xtraTabPage_LoaiKhachHang
            // 
            this.xtraTabPage_LoaiKhachHang.Controls.Add(this.panelControl1);
            this.xtraTabPage_LoaiKhachHang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage_LoaiKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage_LoaiKhachHang.Name = "xtraTabPage_LoaiKhachHang";
            this.xtraTabPage_LoaiKhachHang.Size = new System.Drawing.Size(524, 377);
            this.xtraTabPage_LoaiKhachHang.Text = "Loại Khách Hàng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btn_CapNhat);
            this.panelControl1.Controls.Add(this.btn_Xoa);
            this.panelControl1.Controls.Add(this.btn_Them);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(524, 377);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvLoaiKH);
            this.groupControl1.Location = new System.Drawing.Point(24, 18);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(477, 249);
            this.groupControl1.TabIndex = 36;
            this.groupControl1.Text = "Thông tin loại khách hàng";
            // 
            // dgvLoaiKH
            // 
            this.dgvLoaiKH.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLoaiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAIKH,
            this.TENLOAIKH});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiKH.Location = new System.Drawing.Point(14, 40);
            this.dgvLoaiKH.Name = "dgvLoaiKH";
            this.dgvLoaiKH.Size = new System.Drawing.Size(445, 191);
            this.dgvLoaiKH.TabIndex = 0;
            // 
            // MALOAIKH
            // 
            this.MALOAIKH.DataPropertyName = "MALOAIKH";
            this.MALOAIKH.HeaderText = "Mã loại khách hàng";
            this.MALOAIKH.Name = "MALOAIKH";
            this.MALOAIKH.ReadOnly = true;
            this.MALOAIKH.Width = 200;
            // 
            // TENLOAIKH
            // 
            this.TENLOAIKH.DataPropertyName = "TENLOAIKH";
            this.TENLOAIKH.HeaderText = "Tên loại khách hàng";
            this.TENLOAIKH.Name = "TENLOAIKH";
            this.TENLOAIKH.Width = 200;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Location = new System.Drawing.Point(351, 290);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(79, 24);
            this.btn_CapNhat.TabIndex = 35;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(223, 290);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(79, 24);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Enabled = false;
            this.btn_Them.Location = new System.Drawing.Point(97, 290);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(79, 24);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FrmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 402);
            this.Controls.Add(this.xtraTabControl_LoaiKhachHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLoaiKhachHang";
            this.Text = "FrmKhuVuc";
            this.Load += new System.EventHandler(this.FrmLoaiKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_LoaiKhachHang)).EndInit();
            this.xtraTabControl_LoaiKhachHang.ResumeLayout(false);
            this.xtraTabPage_LoaiKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl_LoaiKhachHang;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_LoaiKhachHang;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAIKH;

    }
}
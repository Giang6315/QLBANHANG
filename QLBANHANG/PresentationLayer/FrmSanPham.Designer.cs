namespace QLBANHANG.PresentationLayer
{
    partial class FrmSanPham
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
            this.xtraTabControl_SanPham = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_SanPham = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtgSanPham = new System.Windows.Forms.DataGridView();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtMASP = new DevExpress.XtraEditors.TextEdit();
            this.btTim1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvTraCuu = new System.Windows.Forms.DataGridView();
            this.MASP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDVI1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDVI = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_SanPham)).BeginInit();
            this.xtraTabControl_SanPham.SuspendLayout();
            this.xtraTabPage_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl_SanPham
            // 
            this.xtraTabControl_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_SanPham.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl_SanPham.Name = "xtraTabControl_SanPham";
            this.xtraTabControl_SanPham.SelectedTabPage = this.xtraTabPage_SanPham;
            this.xtraTabControl_SanPham.Size = new System.Drawing.Size(847, 555);
            this.xtraTabControl_SanPham.TabIndex = 1;
            this.xtraTabControl_SanPham.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_SanPham,
            this.xtraTabPage1});
            // 
            // xtraTabPage_SanPham
            // 
            this.xtraTabPage_SanPham.Controls.Add(this.panelControl1);
            this.xtraTabPage_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage_SanPham.Name = "xtraTabPage_SanPham";
            this.xtraTabPage_SanPham.Size = new System.Drawing.Size(841, 527);
            this.xtraTabPage_SanPham.Text = "Sản Phẩm";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.cbLoaiSP);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btn_CapNhat);
            this.panelControl1.Controls.Add(this.btn_Xoa);
            this.panelControl1.Controls.Add(this.btn_Them);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(841, 527);
            this.panelControl1.TabIndex = 0;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoaiSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(269, 10);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(159, 27);
            this.cbLoaiSP.TabIndex = 2;
            this.cbLoaiSP.Text = "--Vui lòng chọn--";
            this.cbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSP_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(166, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Loại sản phẩm";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtgSanPham);
            this.groupControl1.Location = new System.Drawing.Point(11, 48);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(815, 409);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Thông tin về sản phẩm";
            // 
            // dtgSanPham
            // 
            this.dtgSanPham.AllowUserToOrderColumns = true;
            this.dtgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.TENDVI,
            this.DONGIA,
            this.MOTA});
            this.dtgSanPham.Location = new System.Drawing.Point(8, 31);
            this.dtgSanPham.Name = "dtgSanPham";
            this.dtgSanPham.Size = new System.Drawing.Size(788, 365);
            this.dtgSanPham.TabIndex = 25;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Location = new System.Drawing.Point(527, 480);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(69, 24);
            this.btn_CapNhat.TabIndex = 23;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(383, 480);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(60, 24);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Enabled = false;
            this.btn_Them.Location = new System.Drawing.Point(248, 480);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(60, 24);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(841, 527);
            this.xtraTabPage1.Text = "Tra cứu sản phẩm";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl4);
            this.panelControl2.Controls.Add(this.groupControl3);
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(841, 529);
            this.panelControl2.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtTenSP);
            this.groupControl4.Controls.Add(this.simpleButton2);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Location = new System.Drawing.Point(447, 25);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(279, 110);
            this.groupControl4.TabIndex = 28;
            this.groupControl4.Text = "Tra cứu theo tên sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(121, 35);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Properties.Appearance.Options.UseFont = true;
            this.txtTenSP.Size = new System.Drawing.Size(125, 26);
            this.txtTenSP.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(76, 72);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(90, 24);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Tìm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(13, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên sản phẩm";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtMASP);
            this.groupControl3.Controls.Add(this.btTim1);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Location = new System.Drawing.Point(119, 25);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(279, 110);
            this.groupControl3.TabIndex = 28;
            this.groupControl3.Text = "Tra cứu theo mã sản phẩm";
            // 
            // txtMASP
            // 
            this.txtMASP.Location = new System.Drawing.Point(121, 35);
            this.txtMASP.Name = "txtMASP";
            this.txtMASP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASP.Properties.Appearance.Options.UseFont = true;
            this.txtMASP.Size = new System.Drawing.Size(125, 26);
            this.txtMASP.TabIndex = 2;
            // 
            // btTim1
            // 
            this.btTim1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim1.Appearance.Options.UseFont = true;
            this.btTim1.Location = new System.Drawing.Point(76, 72);
            this.btTim1.Name = "btTim1";
            this.btTim1.Size = new System.Drawing.Size(90, 24);
            this.btTim1.TabIndex = 1;
            this.btTim1.Text = "Tìm";
            this.btTim1.Click += new System.EventHandler(this.btTim1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(5, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã sản phẩm";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvTraCuu);
            this.groupControl2.Location = new System.Drawing.Point(11, 157);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(823, 331);
            this.groupControl2.TabIndex = 27;
            this.groupControl2.Text = "Thông tin về sản phẩm";
            // 
            // dgvTraCuu
            // 
            this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP1,
            this.TENSP1,
            this.MOTA1,
            this.DONGIA1,
            this.TENDVI1});
            this.dgvTraCuu.Location = new System.Drawing.Point(14, 31);
            this.dgvTraCuu.Name = "dgvTraCuu";
            this.dgvTraCuu.Size = new System.Drawing.Size(789, 284);
            this.dgvTraCuu.TabIndex = 25;
            // 
            // MASP1
            // 
            this.MASP1.DataPropertyName = "MASP";
            this.MASP1.HeaderText = "Mã sản phẩm";
            this.MASP1.Name = "MASP1";
            this.MASP1.ReadOnly = true;
            this.MASP1.Width = 150;
            // 
            // TENSP1
            // 
            this.TENSP1.DataPropertyName = "TENSP";
            this.TENSP1.HeaderText = "Tên sản phẩm";
            this.TENSP1.Name = "TENSP1";
            this.TENSP1.Width = 150;
            // 
            // MOTA1
            // 
            this.MOTA1.DataPropertyName = "MOTA";
            this.MOTA1.HeaderText = "Mô tả";
            this.MOTA1.Name = "MOTA1";
            this.MOTA1.Width = 200;
            // 
            // DONGIA1
            // 
            this.DONGIA1.DataPropertyName = "DONGIATHAMKHAO";
            this.DONGIA1.HeaderText = "Đơn giá";
            this.DONGIA1.Name = "DONGIA1";
            // 
            // TENDVI1
            // 
            this.TENDVI1.DataPropertyName = "TENDVI";
            this.TENDVI1.HeaderText = "Tên đơn vị tính";
            this.TENDVI1.Name = "TENDVI1";
            this.TENDVI1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TENDVI1.Width = 140;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.Width = 150;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.Width = 150;
            // 
            // TENDVI
            // 
            this.TENDVI.DataPropertyName = "TENDVI";
            this.TENDVI.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.TENDVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TENDVI.HeaderText = "Qui Cách";
            this.TENDVI.Name = "TENDVI";
            this.TENDVI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TENDVI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TENDVI.Width = 140;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle1.NullValue = null;
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle1;
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            this.MOTA.Width = 200;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 555);
            this.Controls.Add(this.xtraTabControl_SanPham);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_SanPham)).EndInit();
            this.xtraTabControl_SanPham.ResumeLayout(false);
            this.xtraTabPage_SanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl_SanPham;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_SanPham;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dtgSanPham;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvTraCuu;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtMASP;
        private DevExpress.XtraEditors.SimpleButton btTim1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDVI1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewComboBoxColumn TENDVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;

    }
}
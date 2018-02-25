namespace QLBANHANG.PresentationLayer
{
    partial class ACustomer
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KhachHang_gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.KhachHang_gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Dienthoaikh = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMakh = new DevExpress.XtraEditors.TextEdit();
            this.txt_Diachikh = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cb_TinhThanh = new System.Windows.Forms.ComboBox();
            this.cb_QuanHuyen = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cb_NhanVienQuanLy = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHang_gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHang_gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dienthoaikh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Diachikh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.KhachHang_gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // KhachHang_gridControl1
            // 
            this.KhachHang_gridControl1.Location = new System.Drawing.Point(11, 188);
            this.KhachHang_gridControl1.MainView = this.KhachHang_gridView1;
            this.KhachHang_gridControl1.Name = "KhachHang_gridControl1";
            this.KhachHang_gridControl1.Size = new System.Drawing.Size(769, 265);
            this.KhachHang_gridControl1.TabIndex = 16;
            this.KhachHang_gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.KhachHang_gridView1,
            this.gridView2,
            this.gridView1});
            // 
            // KhachHang_gridView1
            // 
            this.KhachHang_gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.KhachHang_gridView1.GridControl = this.KhachHang_gridControl1;
            this.KhachHang_gridView1.Name = "KhachHang_gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Khách Hàng";
            this.gridColumn1.FieldName = "MAKH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Khách Hàng";
            this.gridColumn2.FieldName = "HOTENKH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Điện thoại";
            this.gridColumn3.FieldName = "DIENTHOAIKH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa chỉ";
            this.gridColumn4.FieldName = "DCHIKH";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tỉnh/Thành Phố";
            this.gridColumn5.FieldName = "MATINH";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Huyện/Quận";
            this.gridColumn6.FieldName = "MAHUYEN";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nhân Viên Quản Lý";
            this.gridColumn7.FieldName = "MANV";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.KhachHang_gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(532, 71);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 38);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Điện thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(247, 43);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên khách hàng";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl18.Location = new System.Drawing.Point(18, 43);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(111, 26);
            this.labelControl18.TabIndex = 1;
            this.labelControl18.Text = "Mã khách hàng";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(280, 114);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 38);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Quận/Huyện";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(18, 71);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 38);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Địa chỉ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(18, 114);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 38);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Tỉnh/Thành";
            // 
            // txt_Dienthoaikh
            // 
            this.txt_Dienthoaikh.EditValue = "";
            this.txt_Dienthoaikh.Location = new System.Drawing.Point(615, 74);
            this.txt_Dienthoaikh.Name = "txt_Dienthoaikh";
            this.txt_Dienthoaikh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txt_Dienthoaikh.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Dienthoaikh.Properties.Appearance.Options.UseFont = true;
            this.txt_Dienthoaikh.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Dienthoaikh.Size = new System.Drawing.Size(166, 26);
            this.txt_Dienthoaikh.TabIndex = 2;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.AllowDrop = true;
            this.txt_TenKH.EditValue = "";
            this.txt_TenKH.Location = new System.Drawing.Point(368, 40);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txt_TenKH.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_TenKH.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKH.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TenKH.Size = new System.Drawing.Size(202, 26);
            this.txt_TenKH.TabIndex = 2;
            this.txt_TenKH.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // txtMakh
            // 
            this.txtMakh.AllowDrop = true;
            this.txtMakh.EditValue = "";
            this.txtMakh.Location = new System.Drawing.Point(127, 42);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtMakh.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtMakh.Properties.Appearance.Options.UseFont = true;
            this.txtMakh.Properties.Appearance.Options.UseForeColor = true;
            this.txtMakh.Size = new System.Drawing.Size(112, 26);
            this.txtMakh.TabIndex = 2;
            this.txtMakh.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // txt_Diachikh
            // 
            this.txt_Diachikh.EditValue = "";
            this.txt_Diachikh.Location = new System.Drawing.Point(127, 77);
            this.txt_Diachikh.Name = "txt_Diachikh";
            this.txt_Diachikh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txt_Diachikh.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Diachikh.Properties.Appearance.Options.UseFont = true;
            this.txt_Diachikh.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Diachikh.Size = new System.Drawing.Size(386, 26);
            this.txt_Diachikh.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 472);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 27);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(114, 472);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 27);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(219, 472);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 27);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(331, 472);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 27);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            // 
            // cb_TinhThanh
            // 
            this.cb_TinhThanh.FormattingEnabled = true;
            this.cb_TinhThanh.Location = new System.Drawing.Point(127, 124);
            this.cb_TinhThanh.Name = "cb_TinhThanh";
            this.cb_TinhThanh.Size = new System.Drawing.Size(121, 21);
            this.cb_TinhThanh.TabIndex = 20;
            // 
            // cb_QuanHuyen
            // 
            this.cb_QuanHuyen.FormattingEnabled = true;
            this.cb_QuanHuyen.Location = new System.Drawing.Point(387, 124);
            this.cb_QuanHuyen.Name = "cb_QuanHuyen";
            this.cb_QuanHuyen.Size = new System.Drawing.Size(121, 21);
            this.cb_QuanHuyen.TabIndex = 20;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.Controls.Add(this.cb_QuanHuyen);
            this.groupControl1.Controls.Add(this.cb_NhanVienQuanLy);
            this.groupControl1.Controls.Add(this.cb_TinhThanh);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.KhachHang_gridControl1);
            this.groupControl1.Controls.Add(this.txt_Diachikh);
            this.groupControl1.Controls.Add(this.txtMakh);
            this.groupControl1.Controls.Add(this.txt_TenKH);
            this.groupControl1.Controls.Add(this.txt_Dienthoaikh);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl18);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(0, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(804, 520);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Thông tin cơ bản của khách hàng";
            // 
            // cb_NhanVienQuanLy
            // 
            this.cb_NhanVienQuanLy.FormattingEnabled = true;
            this.cb_NhanVienQuanLy.Location = new System.Drawing.Point(162, 157);
            this.cb_NhanVienQuanLy.Name = "cb_NhanVienQuanLy";
            this.cb_NhanVienQuanLy.Size = new System.Drawing.Size(223, 21);
            this.cb_NhanVienQuanLy.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(20, 153);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 30);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nhân viên quản lý";
            // 
            // ACustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.groupControl1);
            this.Name = "ACustomer";
            this.Text = "ACustomer";
            this.Load += new System.EventHandler(this.ACustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHang_gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHang_gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dienthoaikh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Diachikh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl KhachHang_gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView KhachHang_gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_Dienthoaikh;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private DevExpress.XtraEditors.TextEdit txtMakh;
        private DevExpress.XtraEditors.TextEdit txt_Diachikh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ComboBox cb_TinhThanh;
        private System.Windows.Forms.ComboBox cb_QuanHuyen;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cb_NhanVienQuanLy;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}
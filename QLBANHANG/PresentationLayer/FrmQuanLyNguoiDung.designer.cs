namespace QLBANHANG.PresentationLayer
{
    partial class FrmQuanLyNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNguoiDung));
            this.xtraTabControl_PhanQuyen = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_PhanQuyen = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvQuanLyNguoiDung = new System.Windows.Forms.DataGridView();
            this.TENDANGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLQUYENADMIN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COLQUYENTHEM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COLQUYENXOA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.COLQUYENSUA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSoanLai = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlThongTinVeQuyen = new DevExpress.XtraEditors.GroupControl();
            this.checkEditSua = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditXoa = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditThem = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.groupControlMaHoaVaGiaiMaMatKhau = new DevExpress.XtraEditors.GroupControl();
            this.txtMatKhauMaHoaVaGiaiMa = new DevExpress.XtraEditors.TextEdit();
            this.lbMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.btnGiaiMa = new DevExpress.XtraEditors.SimpleButton();
            this.btnMaHoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gclThonngTinDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_PhanQuyen)).BeginInit();
            this.xtraTabControl_PhanQuyen.SuspendLayout();
            this.xtraTabPage_PhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinVeQuyen)).BeginInit();
            this.groupControlThongTinVeQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditXoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditThem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMaHoaVaGiaiMaMatKhau)).BeginInit();
            this.groupControlMaHoaVaGiaiMaMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMaHoaVaGiaiMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclThonngTinDangNhap)).BeginInit();
            this.gclThonngTinDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl_PhanQuyen
            // 
            this.xtraTabControl_PhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_PhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_PhanQuyen.Name = "xtraTabControl_PhanQuyen";
            this.xtraTabControl_PhanQuyen.SelectedTabPage = this.xtraTabPage_PhanQuyen;
            this.xtraTabControl_PhanQuyen.Size = new System.Drawing.Size(1039, 550);
            this.xtraTabControl_PhanQuyen.TabIndex = 1;
            this.xtraTabControl_PhanQuyen.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_PhanQuyen});
            // 
            // xtraTabPage_PhanQuyen
            // 
            this.xtraTabPage_PhanQuyen.Controls.Add(this.panelControl1);
            this.xtraTabPage_PhanQuyen.Name = "xtraTabPage_PhanQuyen";
            this.xtraTabPage_PhanQuyen.Size = new System.Drawing.Size(1034, 525);
            this.xtraTabPage_PhanQuyen.Text = "Phân Quyền";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btnSoanLai);
            this.panelControl1.Controls.Add(this.groupControlThongTinVeQuyen);
            this.panelControl1.Controls.Add(this.groupControlMaHoaVaGiaiMaMatKhau);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.gclThonngTinDangNhap);
            this.panelControl1.Controls.Add(this.btnCapNhat);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1034, 525);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvQuanLyNguoiDung);
            this.groupControl1.Location = new System.Drawing.Point(27, 193);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(986, 247);
            this.groupControl1.TabIndex = 62;
            this.groupControl1.Text = "Thông tin người dùng";
            // 
            // dgvQuanLyNguoiDung
            // 
            this.dgvQuanLyNguoiDung.AllowUserToAddRows = false;
            this.dgvQuanLyNguoiDung.AllowUserToDeleteRows = false;
            this.dgvQuanLyNguoiDung.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvQuanLyNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENDANGNHAP,
            this.MATKHAU,
            this.COLQUYENADMIN,
            this.COLQUYENTHEM,
            this.COLQUYENXOA,
            this.COLQUYENSUA});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuanLyNguoiDung.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanLyNguoiDung.Location = new System.Drawing.Point(23, 36);
            this.dgvQuanLyNguoiDung.Name = "dgvQuanLyNguoiDung";
            this.dgvQuanLyNguoiDung.ReadOnly = true;
            this.dgvQuanLyNguoiDung.Size = new System.Drawing.Size(950, 193);
            this.dgvQuanLyNguoiDung.TabIndex = 61;
            this.dgvQuanLyNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyNguoiDung_CellClick_1);
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.DataPropertyName = "TENDANGNHAP";
            this.TENDANGNHAP.HeaderText = "Tên Đăng Nhập";
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.ReadOnly = true;
            this.TENDANGNHAP.Width = 150;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật Khẩu";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.ReadOnly = true;
            this.MATKHAU.Width = 150;
            // 
            // COLQUYENADMIN
            // 
            this.COLQUYENADMIN.DataPropertyName = "QUYENADMIN";
            this.COLQUYENADMIN.FalseValue = "2";
            this.COLQUYENADMIN.HeaderText = "Quyền Admin";
            this.COLQUYENADMIN.Name = "COLQUYENADMIN";
            this.COLQUYENADMIN.ReadOnly = true;
            this.COLQUYENADMIN.TrueValue = "1";
            this.COLQUYENADMIN.Width = 150;
            // 
            // COLQUYENTHEM
            // 
            this.COLQUYENTHEM.DataPropertyName = "QUYENTHEM";
            this.COLQUYENTHEM.FalseValue = "0";
            this.COLQUYENTHEM.HeaderText = "Quyền Thêm";
            this.COLQUYENTHEM.Name = "COLQUYENTHEM";
            this.COLQUYENTHEM.ReadOnly = true;
            this.COLQUYENTHEM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLQUYENTHEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.COLQUYENTHEM.TrueValue = "1";
            this.COLQUYENTHEM.Width = 150;
            // 
            // COLQUYENXOA
            // 
            this.COLQUYENXOA.DataPropertyName = "QUYENXOA";
            this.COLQUYENXOA.FalseValue = "0";
            this.COLQUYENXOA.HeaderText = "Quyền Xóa";
            this.COLQUYENXOA.Name = "COLQUYENXOA";
            this.COLQUYENXOA.ReadOnly = true;
            this.COLQUYENXOA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLQUYENXOA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.COLQUYENXOA.TrueValue = "1";
            this.COLQUYENXOA.Width = 150;
            // 
            // COLQUYENSUA
            // 
            this.COLQUYENSUA.DataPropertyName = "QUYENSUA";
            this.COLQUYENSUA.FalseValue = "0";
            this.COLQUYENSUA.HeaderText = "Quyền Sửa";
            this.COLQUYENSUA.Name = "COLQUYENSUA";
            this.COLQUYENSUA.ReadOnly = true;
            this.COLQUYENSUA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLQUYENSUA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.COLQUYENSUA.TrueValue = "1";
            this.COLQUYENSUA.Width = 150;
            // 
            // btnSoanLai
            // 
            this.btnSoanLai.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoanLai.Appearance.Options.UseFont = true;
            this.btnSoanLai.Image = ((System.Drawing.Image)(resources.GetObject("btnSoanLai.Image")));
            this.btnSoanLai.Location = new System.Drawing.Point(800, 459);
            this.btnSoanLai.Name = "btnSoanLai";
            this.btnSoanLai.Size = new System.Drawing.Size(112, 40);
            this.btnSoanLai.TabIndex = 61;
            this.btnSoanLai.Text = "Soạn Lại";
            this.btnSoanLai.Click += new System.EventHandler(this.btnSoanLai_Click);
            // 
            // groupControlThongTinVeQuyen
            // 
            this.groupControlThongTinVeQuyen.Controls.Add(this.checkEditSua);
            this.groupControlThongTinVeQuyen.Controls.Add(this.checkEditXoa);
            this.groupControlThongTinVeQuyen.Controls.Add(this.checkEditThem);
            this.groupControlThongTinVeQuyen.Controls.Add(this.checkEditAdmin);
            this.groupControlThongTinVeQuyen.Location = new System.Drawing.Point(370, 24);
            this.groupControlThongTinVeQuyen.Name = "groupControlThongTinVeQuyen";
            this.groupControlThongTinVeQuyen.Size = new System.Drawing.Size(195, 158);
            this.groupControlThongTinVeQuyen.TabIndex = 59;
            this.groupControlThongTinVeQuyen.Text = "Thông Tin Về Quyền";
            // 
            // checkEditSua
            // 
            this.checkEditSua.Location = new System.Drawing.Point(51, 117);
            this.checkEditSua.Name = "checkEditSua";
            this.checkEditSua.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditSua.Properties.Appearance.Options.UseFont = true;
            this.checkEditSua.Properties.Caption = "Sửa";
            this.checkEditSua.Size = new System.Drawing.Size(75, 23);
            this.checkEditSua.TabIndex = 62;
            // 
            // checkEditXoa
            // 
            this.checkEditXoa.Location = new System.Drawing.Point(51, 92);
            this.checkEditXoa.Name = "checkEditXoa";
            this.checkEditXoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditXoa.Properties.Appearance.Options.UseFont = true;
            this.checkEditXoa.Properties.Caption = "Xóa";
            this.checkEditXoa.Size = new System.Drawing.Size(75, 23);
            this.checkEditXoa.TabIndex = 61;
            // 
            // checkEditThem
            // 
            this.checkEditThem.Location = new System.Drawing.Point(51, 61);
            this.checkEditThem.Name = "checkEditThem";
            this.checkEditThem.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditThem.Properties.Appearance.Options.UseFont = true;
            this.checkEditThem.Properties.Caption = "Thêm";
            this.checkEditThem.Size = new System.Drawing.Size(75, 23);
            this.checkEditThem.TabIndex = 1;
            // 
            // checkEditAdmin
            // 
            this.checkEditAdmin.Location = new System.Drawing.Point(51, 33);
            this.checkEditAdmin.Name = "checkEditAdmin";
            this.checkEditAdmin.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditAdmin.Properties.Appearance.Options.UseFont = true;
            this.checkEditAdmin.Properties.Caption = "Admin";
            this.checkEditAdmin.Size = new System.Drawing.Size(75, 23);
            this.checkEditAdmin.TabIndex = 0;
            this.checkEditAdmin.CheckedChanged += new System.EventHandler(this.checkEditAdmin_CheckedChanged);
            // 
            // groupControlMaHoaVaGiaiMaMatKhau
            // 
            this.groupControlMaHoaVaGiaiMaMatKhau.Controls.Add(this.txtMatKhauMaHoaVaGiaiMa);
            this.groupControlMaHoaVaGiaiMaMatKhau.Controls.Add(this.lbMatKhau);
            this.groupControlMaHoaVaGiaiMaMatKhau.Controls.Add(this.btnGiaiMa);
            this.groupControlMaHoaVaGiaiMaMatKhau.Controls.Add(this.btnMaHoa);
            this.groupControlMaHoaVaGiaiMaMatKhau.Location = new System.Drawing.Point(578, 24);
            this.groupControlMaHoaVaGiaiMaMatKhau.Name = "groupControlMaHoaVaGiaiMaMatKhau";
            this.groupControlMaHoaVaGiaiMaMatKhau.Size = new System.Drawing.Size(412, 158);
            this.groupControlMaHoaVaGiaiMaMatKhau.TabIndex = 58;
            this.groupControlMaHoaVaGiaiMaMatKhau.Text = "Mã Hóa Và Giải Mã Mật Khẩu";
            // 
            // txtMatKhauMaHoaVaGiaiMa
            // 
            this.txtMatKhauMaHoaVaGiaiMa.EditValue = "";
            this.txtMatKhauMaHoaVaGiaiMa.Location = new System.Drawing.Point(244, 48);
            this.txtMatKhauMaHoaVaGiaiMa.Name = "txtMatKhauMaHoaVaGiaiMa";
            this.txtMatKhauMaHoaVaGiaiMa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMaHoaVaGiaiMa.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhauMaHoaVaGiaiMa.Properties.UseSystemPasswordChar = true;
            this.txtMatKhauMaHoaVaGiaiMa.Size = new System.Drawing.Size(163, 26);
            this.txtMatKhauMaHoaVaGiaiMa.TabIndex = 60;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(15, 55);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(205, 19);
            this.lbMatKhau.TabIndex = 59;
            this.lbMatKhau.Text = "Mật Khẩu Mã Hóa Và Giải Mã";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiMa.Appearance.Options.UseFont = true;
            this.btnGiaiMa.Location = new System.Drawing.Point(242, 99);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(92, 37);
            this.btnGiaiMa.TabIndex = 58;
            this.btnGiaiMa.Text = "Giải Mã";
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoa.Appearance.Options.UseFont = true;
            this.btnMaHoa.Location = new System.Drawing.Point(80, 104);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(92, 37);
            this.btnMaHoa.TabIndex = 57;
            this.btnMaHoa.Text = "Mã Hóa";
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(333, 459);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 40);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gclThonngTinDangNhap
            // 
            this.gclThonngTinDangNhap.Controls.Add(this.txtMatKhau);
            this.gclThonngTinDangNhap.Controls.Add(this.txtTenDangNhap);
            this.gclThonngTinDangNhap.Controls.Add(this.labelControl2);
            this.gclThonngTinDangNhap.Controls.Add(this.labelControl1);
            this.gclThonngTinDangNhap.Location = new System.Drawing.Point(26, 24);
            this.gclThonngTinDangNhap.Name = "gclThonngTinDangNhap";
            this.gclThonngTinDangNhap.Size = new System.Drawing.Size(338, 158);
            this.gclThonngTinDangNhap.TabIndex = 54;
            this.gclThonngTinDangNhap.Text = "Thông Tin Đăng Nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(156, 92);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(157, 26);
            this.txtMatKhau.TabIndex = 12;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(156, 44);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(157, 26);
            this.txtTenDangNhap.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(24, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 19);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(24, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(566, 459);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(116, 40);
            this.btnCapNhat.TabIndex = 51;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(104, 459);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 40);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 550);
            this.Controls.Add(this.xtraTabControl_PhanQuyen);
            this.Name = "FrmQuanLyNguoiDung";
            this.Text = "FrmQuanLyNguoiDung";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_PhanQuyen)).EndInit();
            this.xtraTabControl_PhanQuyen.ResumeLayout(false);
            this.xtraTabPage_PhanQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinVeQuyen)).EndInit();
            this.groupControlThongTinVeQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditXoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditThem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMaHoaVaGiaiMaMatKhau)).EndInit();
            this.groupControlMaHoaVaGiaiMaMatKhau.ResumeLayout(false);
            this.groupControlMaHoaVaGiaiMaMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMaHoaVaGiaiMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclThonngTinDangNhap)).EndInit();
            this.gclThonngTinDangNhap.ResumeLayout(false);
            this.gclThonngTinDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl_PhanQuyen;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_PhanQuyen;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.GroupControl gclThonngTinDangNhap;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnMaHoa;
        private DevExpress.XtraEditors.GroupControl groupControlMaHoaVaGiaiMaMatKhau;
        private DevExpress.XtraEditors.LabelControl lbMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnGiaiMa;
        private DevExpress.XtraEditors.TextEdit txtMatKhauMaHoaVaGiaiMa;
        private DevExpress.XtraEditors.GroupControl groupControlThongTinVeQuyen;
        private DevExpress.XtraEditors.CheckEdit checkEditSua;
        private DevExpress.XtraEditors.CheckEdit checkEditXoa;
        private DevExpress.XtraEditors.CheckEdit checkEditThem;
        private DevExpress.XtraEditors.CheckEdit checkEditAdmin;
        private DevExpress.XtraEditors.SimpleButton btnSoanLai;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvQuanLyNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDANGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLQUYENADMIN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLQUYENTHEM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLQUYENXOA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn COLQUYENSUA;

    }
}
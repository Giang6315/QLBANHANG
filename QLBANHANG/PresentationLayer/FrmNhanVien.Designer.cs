namespace QLBANHANG.PresentationLayer
{
    partial class FrmNhanVien
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
            this.xtraTabPage_NhanVien = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControlNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl_NhanVien = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_NhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNhanVien)).BeginInit();
            this.groupControlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_NhanVien)).BeginInit();
            this.xtraTabControl_NhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabPage_NhanVien
            // 
            this.xtraTabPage_NhanVien.Controls.Add(this.panelControl1);
            this.xtraTabPage_NhanVien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage_NhanVien.Name = "xtraTabPage_NhanVien";
            this.xtraTabPage_NhanVien.Size = new System.Drawing.Size(990, 457);
            this.xtraTabPage_NhanVien.Text = "Nhân Viên";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControlNhanVien);
            this.panelControl1.Controls.Add(this.btn_CapNhat);
            this.panelControl1.Controls.Add(this.btn_Xoa);
            this.panelControl1.Controls.Add(this.btn_Them);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(990, 457);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControlNhanVien
            // 
            this.groupControlNhanVien.Controls.Add(this.dgvNhanVien);
            this.groupControlNhanVien.Location = new System.Drawing.Point(11, 15);
            this.groupControlNhanVien.Name = "groupControlNhanVien";
            this.groupControlNhanVien.Size = new System.Drawing.Size(968, 349);
            this.groupControlNhanVien.TabIndex = 5;
            this.groupControlNhanVien.Text = "Thông tin chi tiết";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTENNV,
            this.DIENTHOAINV,
            this.CHUCVU});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.Location = new System.Drawing.Point(9, 32);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(946, 299);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Width = 150;
            // 
            // HOTENNV
            // 
            this.HOTENNV.DataPropertyName = "HOTENNV";
            this.HOTENNV.HeaderText = "Họ tên nhân viên";
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.Width = 250;
            // 
            // DIENTHOAINV
            // 
            this.DIENTHOAINV.DataPropertyName = "DIENTHOAINV";
            this.DIENTHOAINV.HeaderText = "Điện thoại nhân viên";
            this.DIENTHOAINV.Name = "DIENTHOAINV";
            this.DIENTHOAINV.Width = 200;
            // 
            // CHUCVU
            // 
            this.CHUCVU.DataPropertyName = "TENCV";
            this.CHUCVU.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.CHUCVU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHUCVU.HeaderText = "Tên chức vụ";
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.Width = 300;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Location = new System.Drawing.Point(547, 401);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(81, 29);
            this.btn_CapNhat.TabIndex = 1;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(405, 402);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(81, 29);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Enabled = false;
            this.btn_Them.Location = new System.Drawing.Point(249, 401);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 29);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // xtraTabControl_NhanVien
            // 
            this.xtraTabControl_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl_NhanVien.Name = "xtraTabControl_NhanVien";
            this.xtraTabControl_NhanVien.SelectedTabPage = this.xtraTabPage_NhanVien;
            this.xtraTabControl_NhanVien.Size = new System.Drawing.Size(995, 482);
            this.xtraTabControl_NhanVien.TabIndex = 0;
            this.xtraTabControl_NhanVien.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_NhanVien});
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 482);
            this.Controls.Add(this.xtraTabControl_NhanVien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.xtraTabPage_NhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNhanVien)).EndInit();
            this.groupControlNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_NhanVien)).EndInit();
            this.xtraTabControl_NhanVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage_NhanVien;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl_NhanVien;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.GroupControl groupControlNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAINV;
        private System.Windows.Forms.DataGridViewComboBoxColumn CHUCVU;

    }
}
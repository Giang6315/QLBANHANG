namespace QLBANHANG.PresentationLayer
{
    partial class FrmTinhThanh
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
            this.xtraTabControl_TinhThanh = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_TinhThanh = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvTinhThanh = new System.Windows.Forms.DataGridView();
            this.MATINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_TinhThanh)).BeginInit();
            this.xtraTabControl_TinhThanh.SuspendLayout();
            this.xtraTabPage_TinhThanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhThanh)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl_TinhThanh
            // 
            this.xtraTabControl_TinhThanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_TinhThanh.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_TinhThanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl_TinhThanh.Name = "xtraTabControl_TinhThanh";
            this.xtraTabControl_TinhThanh.SelectedTabPage = this.xtraTabPage_TinhThanh;
            this.xtraTabControl_TinhThanh.Size = new System.Drawing.Size(644, 486);
            this.xtraTabControl_TinhThanh.TabIndex = 0;
            this.xtraTabControl_TinhThanh.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_TinhThanh});
            // 
            // xtraTabPage_TinhThanh
            // 
            this.xtraTabPage_TinhThanh.Controls.Add(this.panelControl1);
            this.xtraTabPage_TinhThanh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage_TinhThanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage_TinhThanh.Name = "xtraTabPage_TinhThanh";
            this.xtraTabPage_TinhThanh.Size = new System.Drawing.Size(639, 461);
            this.xtraTabPage_TinhThanh.Text = "Tỉnh Thành";
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
            this.panelControl1.Size = new System.Drawing.Size(639, 461);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvTinhThanh);
            this.groupControl1.Location = new System.Drawing.Point(9, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(578, 314);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "Thông tin tỉnh thành";
            // 
            // dgvTinhThanh
            // 
            this.dgvTinhThanh.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTinhThanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhThanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATINH,
            this.TENTINH});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTinhThanh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTinhThanh.Location = new System.Drawing.Point(13, 35);
            this.dgvTinhThanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTinhThanh.Name = "dgvTinhThanh";
            this.dgvTinhThanh.RowTemplate.Height = 24;
            this.dgvTinhThanh.Size = new System.Drawing.Size(547, 265);
            this.dgvTinhThanh.TabIndex = 32;
            // 
            // MATINH
            // 
            this.MATINH.DataPropertyName = "MATINH";
            this.MATINH.HeaderText = "Mã Tỉnh";
            this.MATINH.Name = "MATINH";
            this.MATINH.ReadOnly = true;
            this.MATINH.Width = 150;
            // 
            // TENTINH
            // 
            this.TENTINH.DataPropertyName = "TENTINH";
            this.TENTINH.HeaderText = "Tên Tỉnh";
            this.TENTINH.Name = "TENTINH";
            this.TENTINH.Width = 200;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Location = new System.Drawing.Point(441, 365);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(79, 35);
            this.btn_CapNhat.TabIndex = 31;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Location = new System.Drawing.Point(282, 365);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(79, 35);
            this.btn_Xoa.TabIndex = 29;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Location = new System.Drawing.Point(122, 365);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(79, 35);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FrmTinhThanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 486);
            this.Controls.Add(this.xtraTabControl_TinhThanh);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTinhThanh";
            this.Text = "FrmTinhThanh";
            this.Load += new System.EventHandler(this.FrmTinhThanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_TinhThanh)).EndInit();
            this.xtraTabControl_TinhThanh.ResumeLayout(false);
            this.xtraTabPage_TinhThanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhThanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl_TinhThanh;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_TinhThanh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.DataGridView dgvTinhThanh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTINH;

    }
}
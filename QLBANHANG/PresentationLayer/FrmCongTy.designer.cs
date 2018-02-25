namespace QLBANHANG.PresentationLayer
{
    partial class FrmCongTy
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
            this.xtraTabControl_Congty = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_Congty = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvCongty = new System.Windows.Forms.DataGridView();
            this.MACTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHICTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAICTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Congty)).BeginInit();
            this.xtraTabControl_Congty.SuspendLayout();
            this.xtraTabPage_Congty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongty)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl_Congty
            // 
            this.xtraTabControl_Congty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_Congty.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_Congty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl_Congty.Name = "xtraTabControl_Congty";
            this.xtraTabControl_Congty.SelectedTabPage = this.xtraTabPage_Congty;
            this.xtraTabControl_Congty.Size = new System.Drawing.Size(1169, 527);
            this.xtraTabControl_Congty.TabIndex = 4;
            this.xtraTabControl_Congty.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_Congty});
            // 
            // xtraTabPage_Congty
            // 
            this.xtraTabPage_Congty.Controls.Add(this.panelControl1);
            this.xtraTabPage_Congty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage_Congty.Name = "xtraTabPage_Congty";
            this.xtraTabPage_Congty.Size = new System.Drawing.Size(1167, 505);
            this.xtraTabPage_Congty.Text = "Công ty";
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
            this.panelControl1.Size = new System.Drawing.Size(1167, 505);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvCongty);
            this.groupControl1.Location = new System.Drawing.Point(29, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1111, 392);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "Thông tin công ty";
            // 
            // dgvCongty
            // 
            this.dgvCongty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACTY,
            this.TENCTY,
            this.DIACHICTY,
            this.DIENTHOAICTY});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCongty.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCongty.Location = new System.Drawing.Point(20, 29);
            this.dgvCongty.Name = "dgvCongty";
            this.dgvCongty.Size = new System.Drawing.Size(1072, 347);
            this.dgvCongty.TabIndex = 36;
            // 
            // MACTY
            // 
            this.MACTY.DataPropertyName = "MACTY";
            this.MACTY.HeaderText = "Mã công ty";
            this.MACTY.Name = "MACTY";
            this.MACTY.ReadOnly = true;
            // 
            // TENCTY
            // 
            this.TENCTY.DataPropertyName = "TENCTY";
            this.TENCTY.HeaderText = "Tên công ty";
            this.TENCTY.Name = "TENCTY";
            this.TENCTY.Width = 380;
            // 
            // DIACHICTY
            // 
            this.DIACHICTY.DataPropertyName = "DIACHICTY";
            this.DIACHICTY.HeaderText = "Địa chỉ công ty";
            this.DIACHICTY.Name = "DIACHICTY";
            this.DIACHICTY.Width = 380;
            // 
            // DIENTHOAICTY
            // 
            this.DIENTHOAICTY.DataPropertyName = "DIENTHOAICTY";
            this.DIENTHOAICTY.HeaderText = "Điện thoại công ty";
            this.DIENTHOAICTY.Name = "DIENTHOAICTY";
            this.DIENTHOAICTY.Width = 150;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(637, 449);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(79, 24);
            this.btn_CapNhat.TabIndex = 35;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(524, 449);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(79, 24);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(414, 449);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(79, 24);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FrmCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 527);
            this.Controls.Add(this.xtraTabControl_Congty);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCongTy";
            this.Text = "FrmCongTy";
            this.Load += new System.EventHandler(this.FrmCongTy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Congty)).EndInit();
            this.xtraTabControl_Congty.ResumeLayout(false);
            this.xtraTabPage_Congty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl_Congty;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_Congty;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvCongty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENCTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHICTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAICTY;

    }
}
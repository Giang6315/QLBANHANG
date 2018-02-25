namespace QLBANHANG.PresentationLayer
{
    partial class FrmDanToc
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
            this.xtraTabControl_DanToc = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_DanToc = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDantoc = new System.Windows.Forms.DataGridView();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_DanToc)).BeginInit();
            this.xtraTabControl_DanToc.SuspendLayout();
            this.xtraTabPage_DanToc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDantoc)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl_DanToc
            // 
            this.xtraTabControl_DanToc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_DanToc.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_DanToc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl_DanToc.Name = "xtraTabControl_DanToc";
            this.xtraTabControl_DanToc.SelectedTabPage = this.xtraTabPage_DanToc;
            this.xtraTabControl_DanToc.Size = new System.Drawing.Size(475, 427);
            this.xtraTabControl_DanToc.TabIndex = 3;
            this.xtraTabControl_DanToc.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_DanToc});
            // 
            // xtraTabPage_DanToc
            // 
            this.xtraTabPage_DanToc.Controls.Add(this.panelControl1);
            this.xtraTabPage_DanToc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage_DanToc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage_DanToc.Name = "xtraTabPage_DanToc";
            this.xtraTabPage_DanToc.Size = new System.Drawing.Size(473, 405);
            this.xtraTabPage_DanToc.Text = "Dân Tộc";
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
            this.panelControl1.Size = new System.Drawing.Size(473, 405);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvDantoc);
            this.groupControl1.Location = new System.Drawing.Point(22, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(414, 300);
            this.groupControl1.TabIndex = 36;
            this.groupControl1.Text = "Thông tin dân tộc";
            // 
            // dgvDantoc
            // 
            this.dgvDantoc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDantoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDantoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADT,
            this.TENDT});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDantoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDantoc.Location = new System.Drawing.Point(20, 43);
            this.dgvDantoc.Name = "dgvDantoc";
            this.dgvDantoc.Size = new System.Drawing.Size(372, 239);
            this.dgvDantoc.TabIndex = 0;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Enabled = false;
            this.btn_CapNhat.Location = new System.Drawing.Point(322, 345);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(79, 32);
            this.btn_CapNhat.TabIndex = 35;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(198, 345);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(79, 32);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Enabled = false;
            this.btn_Them.Location = new System.Drawing.Point(72, 345);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(79, 32);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // MADT
            // 
            this.MADT.DataPropertyName = "MADT";
            this.MADT.HeaderText = "Mã dân tộc";
            this.MADT.Name = "MADT";
            this.MADT.ReadOnly = true;
            this.MADT.Width = 150;
            // 
            // TENDT
            // 
            this.TENDT.DataPropertyName = "TENDT";
            this.TENDT.HeaderText = "Tên dân tộc";
            this.TENDT.Name = "TENDT";
            this.TENDT.Width = 150;
            // 
            // FrmDanToc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 427);
            this.Controls.Add(this.xtraTabControl_DanToc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDanToc";
            this.Text = "FrmDanToc";
            this.Load += new System.EventHandler(this.FrmDanToc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_DanToc)).EndInit();
            this.xtraTabControl_DanToc.ResumeLayout(false);
            this.xtraTabPage_DanToc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDantoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl_DanToc;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_DanToc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvDantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDT;

    }
}
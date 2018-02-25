namespace QLBANHANG.PresentationLayer
{
    partial class FrmThongTinDonDatHang
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_ThongTinDDH = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvThongTinDDH = new System.Windows.Forms.DataGridView();
            this.MADDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage_ThongTinDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage_ThongTinDDH;
            this.xtraTabControl1.Size = new System.Drawing.Size(1083, 436);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_ThongTinDDH});
            // 
            // xtraTabPage_ThongTinDDH
            // 
            this.xtraTabPage_ThongTinDDH.Controls.Add(this.panelControl1);
            this.xtraTabPage_ThongTinDDH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage_ThongTinDDH.Name = "xtraTabPage_ThongTinDDH";
            this.xtraTabPage_ThongTinDDH.Size = new System.Drawing.Size(1081, 414);
            this.xtraTabPage_ThongTinDDH.Text = "Thông tin đơn đặt hàng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1081, 414);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvThongTinDDH);
            this.groupControl1.Location = new System.Drawing.Point(20, 22);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(678, 297);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin về các đơn đặt hàng";
            // 
            // dgvThongTinDDH
            // 
            this.dgvThongTinDDH.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvThongTinDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADDH,
            this.MAKH,
            this.NGAYDAT});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinDDH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinDDH.Location = new System.Drawing.Point(10, 35);
            this.dgvThongTinDDH.Name = "dgvThongTinDDH";
            this.dgvThongTinDDH.Size = new System.Drawing.Size(649, 248);
            this.dgvThongTinDDH.TabIndex = 0;
            this.dgvThongTinDDH.DoubleClick += new System.EventHandler(this.dgvThongTinDDH_DoubleClick);
            // 
            // MADDH
            // 
            this.MADDH.DataPropertyName = "MADDH";
            this.MADDH.HeaderText = "Mã đơn đặt hàng";
            this.MADDH.Name = "MADDH";
            this.MADDH.Width = 150;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 150;
            // 
            // NGAYDAT
            // 
            this.NGAYDAT.DataPropertyName = "NGAYDAT";
            this.NGAYDAT.HeaderText = "Ngày đặt";
            this.NGAYDAT.Name = "NGAYDAT";
            // 
            // FrmThongTinDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 436);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmThongTinDonDatHang";
            this.Text = "FrmThongTinDonDatHang";
            this.Load += new System.EventHandler(this.FrmThongTinDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage_ThongTinDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_ThongTinDDH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvThongTinDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDAT;
    }
}
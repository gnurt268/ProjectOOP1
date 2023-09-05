namespace ProjectOOP1
{
    partial class frmQuanlyphieuxuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlyphieuxuat));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstLamMoi = new System.Windows.Forms.ToolStripButton();
            this.tstThem = new System.Windows.Forms.ToolStripButton();
            this.tstChiTietPhieuXuat = new System.Windows.Forms.ToolStripButton();
            this.tsXoa = new System.Windows.Forms.ToolStripButton();
            this.tsTimKiem = new System.Windows.Forms.ToolStripButton();
            this.tsQuayLai = new System.Windows.Forms.ToolStripButton();
            this.tstThoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbQuanLyPhieuXuat = new System.Windows.Forms.Label();
            this.groupBoxdasachpx = new System.Windows.Forms.GroupBox();
            this.dgPhieuXuat = new System.Windows.Forms.DataGridView();
            this.groupBoxchucnangpx = new System.Windows.Forms.GroupBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtMapx = new System.Windows.Forms.ComboBox();
            this.msNgayBan = new System.Windows.Forms.MaskedTextBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.cbBanSo = new System.Windows.Forms.ComboBox();
            this.lbBanSo = new System.Windows.Forms.Label();
            this.lbNgayXuat = new System.Windows.Forms.Label();
            this.lbMaPhieuXuat = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxdasachpx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuXuat)).BeginInit();
            this.groupBoxchucnangpx.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstLamMoi,
            this.tstThem,
            this.tstChiTietPhieuXuat,
            this.tsXoa,
            this.tsTimKiem,
            this.tsQuayLai,
            this.tstThoat});
            this.toolStrip1.Location = new System.Drawing.Point(4, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstLamMoi
            // 
            this.tstLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstLamMoi.Image = global::ProjectOOP1.Properties.Resources.Thêm;
            this.tstLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstLamMoi.Name = "tstLamMoi";
            this.tstLamMoi.Size = new System.Drawing.Size(97, 25);
            this.tstLamMoi.Text = "Làm mới";
            this.tstLamMoi.Click += new System.EventHandler(this.tstLamMoi_Click_1);
            // 
            // tstThem
            // 
            this.tstThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstThem.Image = global::ProjectOOP1.Properties.Resources.icons8_add_48;
            this.tstThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstThem.Name = "tstThem";
            this.tstThem.Size = new System.Drawing.Size(76, 25);
            this.tstThem.Text = "Thêm";
            this.tstThem.Click += new System.EventHandler(this.tstThem_Click_1);
            // 
            // tstChiTietPhieuXuat
            // 
            this.tstChiTietPhieuXuat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstChiTietPhieuXuat.Image = global::ProjectOOP1.Properties.Resources.book_open;
            this.tstChiTietPhieuXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstChiTietPhieuXuat.Name = "tstChiTietPhieuXuat";
            this.tstChiTietPhieuXuat.Size = new System.Drawing.Size(169, 25);
            this.tstChiTietPhieuXuat.Text = "Chi tiết phiếu xuất";
            this.tstChiTietPhieuXuat.Click += new System.EventHandler(this.tstChiTietPhieuXuat_Click_1);
            // 
            // tsXoa
            // 
            this.tsXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsXoa.Image = global::ProjectOOP1.Properties.Resources.delete;
            this.tsXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXoa.Name = "tsXoa";
            this.tsXoa.Size = new System.Drawing.Size(62, 25);
            this.tsXoa.Text = "Xóa";
            this.tsXoa.Click += new System.EventHandler(this.tsXoa_Click_1);
            // 
            // tsTimKiem
            // 
            this.tsTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTimKiem.Image = global::ProjectOOP1.Properties.Resources.search;
            this.tsTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTimKiem.Name = "tsTimKiem";
            this.tsTimKiem.Size = new System.Drawing.Size(104, 25);
            this.tsTimKiem.Text = "Tìm Kiếm";
            this.tsTimKiem.Click += new System.EventHandler(this.tsTimKiem_Click);
            // 
            // tsQuayLai
            // 
            this.tsQuayLai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsQuayLai.Image = global::ProjectOOP1.Properties.Resources.back;
            this.tsQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuayLai.Name = "tsQuayLai";
            this.tsQuayLai.Size = new System.Drawing.Size(81, 25);
            this.tsQuayLai.Text = "Trở lại";
            this.tsQuayLai.Click += new System.EventHandler(this.tsQuayLai_Click);
            // 
            // tstThoat
            // 
            this.tstThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstThoat.Image = global::ProjectOOP1.Properties.Resources.exit;
            this.tstThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstThoat.Name = "tstThoat";
            this.tstThoat.Size = new System.Drawing.Size(77, 25);
            this.tstThoat.Text = "Thoát";
            this.tstThoat.Click += new System.EventHandler(this.tstThoat_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel1.Controls.Add(this.lbQuanLyPhieuXuat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxdasachpx);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxchucnangpx);
            this.splitContainer1.Panel2.Controls.Add(this.grbThongTin);
            this.splitContainer1.Size = new System.Drawing.Size(1137, 715);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 3;
            // 
            // lbQuanLyPhieuXuat
            // 
            this.lbQuanLyPhieuXuat.AutoSize = true;
            this.lbQuanLyPhieuXuat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyPhieuXuat.Location = new System.Drawing.Point(388, 24);
            this.lbQuanLyPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuanLyPhieuXuat.Name = "lbQuanLyPhieuXuat";
            this.lbQuanLyPhieuXuat.Size = new System.Drawing.Size(348, 36);
            this.lbQuanLyPhieuXuat.TabIndex = 0;
            this.lbQuanLyPhieuXuat.Text = "QUẢN LÝ PHIẾU XUẤT";
            // 
            // groupBoxdasachpx
            // 
            this.groupBoxdasachpx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxdasachpx.Controls.Add(this.dgPhieuXuat);
            this.groupBoxdasachpx.Location = new System.Drawing.Point(4, 248);
            this.groupBoxdasachpx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxdasachpx.Name = "groupBoxdasachpx";
            this.groupBoxdasachpx.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxdasachpx.Size = new System.Drawing.Size(1133, 360);
            this.groupBoxdasachpx.TabIndex = 2;
            this.groupBoxdasachpx.TabStop = false;
            this.groupBoxdasachpx.Text = "Danh sách";
            // 
            // dgPhieuXuat
            // 
            this.dgPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPhieuXuat.ColumnHeadersHeight = 29;
            this.dgPhieuXuat.Location = new System.Drawing.Point(0, 26);
            this.dgPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgPhieuXuat.Name = "dgPhieuXuat";
            this.dgPhieuXuat.RowHeadersWidth = 51;
            this.dgPhieuXuat.Size = new System.Drawing.Size(1133, 327);
            this.dgPhieuXuat.TabIndex = 0;
            this.dgPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhieuXuat_CellClick_1);
            // 
            // groupBoxchucnangpx
            // 
            this.groupBoxchucnangpx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxchucnangpx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxchucnangpx.Controls.Add(this.toolStrip1);
            this.groupBoxchucnangpx.Location = new System.Drawing.Point(0, 5);
            this.groupBoxchucnangpx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxchucnangpx.Name = "groupBoxchucnangpx";
            this.groupBoxchucnangpx.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxchucnangpx.Size = new System.Drawing.Size(1137, 77);
            this.groupBoxchucnangpx.TabIndex = 1;
            this.groupBoxchucnangpx.TabStop = false;
            this.groupBoxchucnangpx.Text = "Chức năng";
            // 
            // grbThongTin
            // 
            this.grbThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbThongTin.Controls.Add(this.txtMapx);
            this.grbThongTin.Controls.Add(this.msNgayBan);
            this.grbThongTin.Controls.Add(this.cbManv);
            this.grbThongTin.Controls.Add(this.lbMaNhanVien);
            this.grbThongTin.Controls.Add(this.cbBanSo);
            this.grbThongTin.Controls.Add(this.lbBanSo);
            this.grbThongTin.Controls.Add(this.lbNgayXuat);
            this.grbThongTin.Controls.Add(this.lbMaPhieuXuat);
            this.grbThongTin.Location = new System.Drawing.Point(0, 80);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbThongTin.Size = new System.Drawing.Size(1137, 168);
            this.grbThongTin.TabIndex = 0;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // txtMapx
            // 
            this.txtMapx.FormattingEnabled = true;
            this.txtMapx.Items.AddRange(new object[] {
            "px01",
            "px02",
            "px03",
            "px04",
            "px05",
            "px06",
            "px07",
            "px08",
            "px09"});
            this.txtMapx.Location = new System.Drawing.Point(156, 43);
            this.txtMapx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMapx.Name = "txtMapx";
            this.txtMapx.Size = new System.Drawing.Size(370, 29);
            this.txtMapx.TabIndex = 16;
            this.txtMapx.SelectedIndexChanged += new System.EventHandler(this.txtMapx_SelectedIndexChanged);
            // 
            // msNgayBan
            // 
            this.msNgayBan.Location = new System.Drawing.Point(159, 104);
            this.msNgayBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msNgayBan.Name = "msNgayBan";
            this.msNgayBan.Size = new System.Drawing.Size(370, 28);
            this.msNgayBan.TabIndex = 15;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(696, 43);
            this.cbManv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(370, 29);
            this.cbManv.TabIndex = 3;
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(558, 54);
            this.lbMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(108, 21);
            this.lbMaNhanVien.TabIndex = 2;
            this.lbMaNhanVien.Text = "Mã nhân viên";
            // 
            // cbBanSo
            // 
            this.cbBanSo.FormattingEnabled = true;
            this.cbBanSo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbBanSo.Location = new System.Drawing.Point(696, 104);
            this.cbBanSo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBanSo.Name = "cbBanSo";
            this.cbBanSo.Size = new System.Drawing.Size(370, 29);
            this.cbBanSo.TabIndex = 7;
            // 
            // lbBanSo
            // 
            this.lbBanSo.AutoSize = true;
            this.lbBanSo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanSo.Location = new System.Drawing.Point(558, 105);
            this.lbBanSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBanSo.Name = "lbBanSo";
            this.lbBanSo.Size = new System.Drawing.Size(60, 21);
            this.lbBanSo.TabIndex = 6;
            this.lbBanSo.Text = "Bàn số";
            // 
            // lbNgayXuat
            // 
            this.lbNgayXuat.AutoSize = true;
            this.lbNgayXuat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayXuat.Location = new System.Drawing.Point(12, 104);
            this.lbNgayXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayXuat.Name = "lbNgayXuat";
            this.lbNgayXuat.Size = new System.Drawing.Size(84, 21);
            this.lbNgayXuat.TabIndex = 4;
            this.lbNgayXuat.Text = "Ngày xuất";
            // 
            // lbMaPhieuXuat
            // 
            this.lbMaPhieuXuat.AutoSize = true;
            this.lbMaPhieuXuat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieuXuat.Location = new System.Drawing.Point(12, 43);
            this.lbMaPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaPhieuXuat.Name = "lbMaPhieuXuat";
            this.lbMaPhieuXuat.Size = new System.Drawing.Size(114, 21);
            this.lbMaPhieuXuat.TabIndex = 0;
            this.lbMaPhieuXuat.Text = "Mã phiếu xuất";
            // 
            // frmQuanlyphieuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1137, 715);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanlyphieuxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ PHIẾU XUẤT";
            this.Load += new System.EventHandler(this.frmQuanlyphieuxuat_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxdasachpx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuXuat)).EndInit();
            this.groupBoxchucnangpx.ResumeLayout(false);
            this.groupBoxchucnangpx.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstThem;
        private System.Windows.Forms.ToolStripButton tstLamMoi;
        private System.Windows.Forms.ToolStripButton tstChiTietPhieuXuat;
        private System.Windows.Forms.ToolStripButton tstThoat;
        private System.Windows.Forms.ToolStripButton tsXoa;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbQuanLyPhieuXuat;
        private System.Windows.Forms.GroupBox groupBoxdasachpx;
        private System.Windows.Forms.DataGridView dgPhieuXuat;
        private System.Windows.Forms.GroupBox groupBoxchucnangpx;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.MaskedTextBox msNgayBan;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.ComboBox cbBanSo;
        private System.Windows.Forms.Label lbBanSo;
        private System.Windows.Forms.Label lbNgayXuat;
        private System.Windows.Forms.Label lbMaPhieuXuat;
        private System.Windows.Forms.ToolStripButton tsTimKiem;
        private System.Windows.Forms.ToolStripButton tsQuayLai;
        private System.Windows.Forms.ComboBox txtMapx;
    }
}
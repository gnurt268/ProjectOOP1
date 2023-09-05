namespace ProjectOOP1
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtMasp = new System.Windows.Forms.ComboBox();
            this.txtTensp = new System.Windows.Forms.ComboBox();
            this.cbDonViTinh = new System.Windows.Forms.ComboBox();
            this.lbtimkem = new System.Windows.Forms.Label();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            this.cbLoaisanpham = new System.Windows.Forms.ComboBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.lbloaisp = new System.Windows.Forms.Label();
            this.lbDionvitinh = new System.Windows.Forms.Label();
            this.lbGiaban = new System.Windows.Forms.Label();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.lbMaSanPham = new System.Windows.Forms.Label();
            this.toolStripqlnv = new System.Windows.Forms.ToolStrip();
            this.tsLamMoi = new System.Windows.Forms.ToolStripButton();
            this.tsThem = new System.Windows.Forms.ToolStripButton();
            this.tsSua = new System.Windows.Forms.ToolStripButton();
            this.tsXoa = new System.Windows.Forms.ToolStripButton();
            this.tsTimKiem = new System.Windows.Forms.ToolStripButton();
            this.tsQuayLai = new System.Windows.Forms.ToolStripButton();
            this.tsThoat = new System.Windows.Forms.ToolStripButton();
            this.lbQuanLySanPham = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            this.toolStripqlnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "tim kiem theo ma",
            "tim kiem theo ten"});
            this.cbTimKiem.Location = new System.Drawing.Point(732, 181);
            this.cbTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(361, 27);
            this.cbTimKiem.TabIndex = 13;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbThongTin.Controls.Add(this.txtMasp);
            this.grbThongTin.Controls.Add(this.txtTensp);
            this.grbThongTin.Controls.Add(this.cbDonViTinh);
            this.grbThongTin.Controls.Add(this.cbTimKiem);
            this.grbThongTin.Controls.Add(this.lbtimkem);
            this.grbThongTin.Controls.Add(this.dgSanPham);
            this.grbThongTin.Controls.Add(this.cbLoaisanpham);
            this.grbThongTin.Controls.Add(this.txtgiaban);
            this.grbThongTin.Controls.Add(this.lbloaisp);
            this.grbThongTin.Controls.Add(this.lbDionvitinh);
            this.grbThongTin.Controls.Add(this.lbGiaban);
            this.grbThongTin.Controls.Add(this.lbTenSanPham);
            this.grbThongTin.Controls.Add(this.lbMaSanPham);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.Location = new System.Drawing.Point(0, 39);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbThongTin.Size = new System.Drawing.Size(1250, 614);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // txtMasp
            // 
            this.txtMasp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMasp.FormattingEnabled = true;
            this.txtMasp.Items.AddRange(new object[] {
            "sp01",
            "sp02",
            "sp03",
            "sp04",
            "sp05",
            "sp06",
            "sp07",
            "sp08",
            "sp09",
            "sp10",
            "sp11",
            "sp12",
            "sp13",
            "sp14",
            "sp15"});
            this.txtMasp.Location = new System.Drawing.Point(156, 50);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(361, 27);
            this.txtMasp.TabIndex = 16;
            // 
            // txtTensp
            // 
            this.txtTensp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTensp.FormattingEnabled = true;
            this.txtTensp.Items.AddRange(new object[] {
            "cafe den",
            "cafe trứng",
            "coca cola",
            "cafe"});
            this.txtTensp.Location = new System.Drawing.Point(732, 50);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(361, 27);
            this.txtTensp.TabIndex = 15;
            // 
            // cbDonViTinh
            // 
            this.cbDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDonViTinh.FormattingEnabled = true;
            this.cbDonViTinh.Items.AddRange(new object[] {
            "Chai",
            "Lon",
            "Cốc",
            "Que",
            "Ly",
            "Đĩa",
            "Gói"});
            this.cbDonViTinh.Location = new System.Drawing.Point(156, 181);
            this.cbDonViTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(361, 27);
            this.cbDonViTinh.TabIndex = 9;
            // 
            // lbtimkem
            // 
            this.lbtimkem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtimkem.AutoSize = true;
            this.lbtimkem.Location = new System.Drawing.Point(564, 187);
            this.lbtimkem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtimkem.Name = "lbtimkem";
            this.lbtimkem.Size = new System.Drawing.Size(115, 21);
            this.lbtimkem.TabIndex = 12;
            this.lbtimkem.Text = "Kiểu Tìm kiếm";
            // 
            // dgSanPham
            // 
            this.dgSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Location = new System.Drawing.Point(0, 245);
            this.dgSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.RowHeadersWidth = 51;
            this.dgSanPham.Size = new System.Drawing.Size(1250, 343);
            this.dgSanPham.TabIndex = 14;
            this.dgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_CellClick);
            // 
            // cbLoaisanpham
            // 
            this.cbLoaisanpham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoaisanpham.FormattingEnabled = true;
            this.cbLoaisanpham.Items.AddRange(new object[] {
            "Không pha chế",
            "Pha chế"});
            this.cbLoaisanpham.Location = new System.Drawing.Point(732, 117);
            this.cbLoaisanpham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoaisanpham.Name = "cbLoaisanpham";
            this.cbLoaisanpham.Size = new System.Drawing.Size(361, 27);
            this.cbLoaisanpham.TabIndex = 11;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtgiaban.Location = new System.Drawing.Point(156, 117);
            this.txtgiaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(361, 27);
            this.txtgiaban.TabIndex = 5;
            this.txtgiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiaban_KeyPress);
            // 
            // lbloaisp
            // 
            this.lbloaisp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbloaisp.AutoSize = true;
            this.lbloaisp.Location = new System.Drawing.Point(564, 120);
            this.lbloaisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloaisp.Name = "lbloaisp";
            this.lbloaisp.Size = new System.Drawing.Size(117, 21);
            this.lbloaisp.TabIndex = 10;
            this.lbloaisp.Text = "Loại sản phẩm";
            // 
            // lbDionvitinh
            // 
            this.lbDionvitinh.AutoSize = true;
            this.lbDionvitinh.Location = new System.Drawing.Point(13, 187);
            this.lbDionvitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDionvitinh.Name = "lbDionvitinh";
            this.lbDionvitinh.Size = new System.Drawing.Size(90, 21);
            this.lbDionvitinh.TabIndex = 8;
            this.lbDionvitinh.Text = "Đơn vị tính";
            // 
            // lbGiaban
            // 
            this.lbGiaban.AutoSize = true;
            this.lbGiaban.Location = new System.Drawing.Point(12, 117);
            this.lbGiaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaban.Name = "lbGiaban";
            this.lbGiaban.Size = new System.Drawing.Size(66, 21);
            this.lbGiaban.TabIndex = 4;
            this.lbGiaban.Text = "Giá bán";
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Location = new System.Drawing.Point(564, 56);
            this.lbTenSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(115, 21);
            this.lbTenSanPham.TabIndex = 2;
            this.lbTenSanPham.Text = "Tên sản phẩm";
            // 
            // lbMaSanPham
            // 
            this.lbMaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaSanPham.AutoSize = true;
            this.lbMaSanPham.Location = new System.Drawing.Point(13, 56);
            this.lbMaSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSanPham.Name = "lbMaSanPham";
            this.lbMaSanPham.Size = new System.Drawing.Size(109, 21);
            this.lbMaSanPham.TabIndex = 0;
            this.lbMaSanPham.Text = "Mã sản phẩm";
            // 
            // toolStripqlnv
            // 
            this.toolStripqlnv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStripqlnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripqlnv.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripqlnv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripqlnv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLamMoi,
            this.tsThem,
            this.tsSua,
            this.tsXoa,
            this.tsTimKiem,
            this.tsQuayLai,
            this.tsThoat});
            this.toolStripqlnv.Location = new System.Drawing.Point(0, 6);
            this.toolStripqlnv.Name = "toolStripqlnv";
            this.toolStripqlnv.Size = new System.Drawing.Size(587, 28);
            this.toolStripqlnv.TabIndex = 0;
            this.toolStripqlnv.Text = "toolStrip1";
            // 
            // tsLamMoi
            // 
            this.tsLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLamMoi.Image = global::ProjectOOP1.Properties.Resources.Thêm;
            this.tsLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLamMoi.Name = "tsLamMoi";
            this.tsLamMoi.Size = new System.Drawing.Size(97, 25);
            this.tsLamMoi.Text = "Làm mới";
            this.tsLamMoi.Click += new System.EventHandler(this.tsLamMoi_Click);
            // 
            // tsThem
            // 
            this.tsThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsThem.Image = global::ProjectOOP1.Properties.Resources.icons8_add_48;
            this.tsThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThem.Name = "tsThem";
            this.tsThem.Size = new System.Drawing.Size(76, 25);
            this.tsThem.Text = "Thêm";
            this.tsThem.Click += new System.EventHandler(this.tsThem_Click);
            // 
            // tsSua
            // 
            this.tsSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSua.Image = global::ProjectOOP1.Properties.Resources.repair;
            this.tsSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSua.Name = "tsSua";
            this.tsSua.Size = new System.Drawing.Size(62, 25);
            this.tsSua.Text = "Sửa";
            this.tsSua.Click += new System.EventHandler(this.tsSua_Click);
            // 
            // tsXoa
            // 
            this.tsXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsXoa.Image = global::ProjectOOP1.Properties.Resources.delete;
            this.tsXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXoa.Name = "tsXoa";
            this.tsXoa.Size = new System.Drawing.Size(62, 25);
            this.tsXoa.Text = "Xóa";
            this.tsXoa.Click += new System.EventHandler(this.tsXoa_Click);
            // 
            // tsTimKiem
            // 
            this.tsTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTimKiem.Image = global::ProjectOOP1.Properties.Resources.search;
            this.tsTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTimKiem.Name = "tsTimKiem";
            this.tsTimKiem.Size = new System.Drawing.Size(102, 25);
            this.tsTimKiem.Text = "Tìm kiếm";
            this.tsTimKiem.Click += new System.EventHandler(this.tsTimKiem_Click);
            // 
            // tsQuayLai
            // 
            this.tsQuayLai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsQuayLai.Image = global::ProjectOOP1.Properties.Resources.back;
            this.tsQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuayLai.Name = "tsQuayLai";
            this.tsQuayLai.Size = new System.Drawing.Size(98, 25);
            this.tsQuayLai.Text = "Quay Lại";
            this.tsQuayLai.Click += new System.EventHandler(this.tsQuayLai_Click);
            // 
            // tsThoat
            // 
            this.tsThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsThoat.Image = global::ProjectOOP1.Properties.Resources.exit;
            this.tsThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThoat.Name = "tsThoat";
            this.tsThoat.Size = new System.Drawing.Size(77, 25);
            this.tsThoat.Text = "Thoát";
            this.tsThoat.Click += new System.EventHandler(this.tsThoat_Click);
            // 
            // lbQuanLySanPham
            // 
            this.lbQuanLySanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbQuanLySanPham.AutoSize = true;
            this.lbQuanLySanPham.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLySanPham.Location = new System.Drawing.Point(473, 30);
            this.lbQuanLySanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuanLySanPham.Name = "lbQuanLySanPham";
            this.lbQuanLySanPham.Size = new System.Drawing.Size(322, 36);
            this.lbQuanLySanPham.TabIndex = 0;
            this.lbQuanLySanPham.Text = "QUẢN LÝ SẢN PHẨM\r\n";
            this.lbQuanLySanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbQuanLySanPham.Click += new System.EventHandler(this.lbQuanLySanPham_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.lbQuanLySanPham);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel2.Controls.Add(this.toolStripqlnv);
            this.splitContainer1.Panel2.Controls.Add(this.grbThongTin);
            this.splitContainer1.Size = new System.Drawing.Size(1250, 768);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 2;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 768);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            this.toolStripqlnv.ResumeLayout(false);
            this.toolStripqlnv.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.ToolStripButton tsTimKiem;
        private System.Windows.Forms.ToolStripButton tsThoat;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.Label lbtimkem;
        private System.Windows.Forms.DataGridView dgSanPham;
        private System.Windows.Forms.ComboBox cbLoaisanpham;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Label lbloaisp;
        private System.Windows.Forms.Label lbDionvitinh;
        private System.Windows.Forms.Label lbGiaban;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.Label lbMaSanPham;
        private System.Windows.Forms.ToolStripButton tsXoa;
        private System.Windows.Forms.ToolStripButton tsSua;
        private System.Windows.Forms.ToolStripButton tsLamMoi;
        private System.Windows.Forms.ToolStrip toolStripqlnv;
        private System.Windows.Forms.ToolStripButton tsThem;
        private System.Windows.Forms.Label lbQuanLySanPham;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsQuayLai;
        private System.Windows.Forms.ComboBox txtTensp;
        private System.Windows.Forms.ComboBox txtMasp;
    }
}
namespace ProjectOOP1
{
    partial class frmthongkephieuxuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthongkephieuxuat));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbThongKePhieuXuat = new System.Windows.Forms.Label();
            this.groupBoxchitiet = new System.Windows.Forms.GroupBox();
            this.dgThongKepx = new System.Windows.Forms.DataGridView();
            this.groupBoxthongtin = new System.Windows.Forms.GroupBox();
            this.btThongKe = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btTongTien = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsTroLai = new System.Windows.Forms.ToolStripButton();
            this.tsThoat = new System.Windows.Forms.ToolStripButton();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTừNgày = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.cbKieuThongKe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKepx)).BeginInit();
            this.groupBoxthongtin.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lbThongKePhieuXuat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxchitiet);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxthongtin);
            this.splitContainer1.Size = new System.Drawing.Size(1322, 664);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbThongKePhieuXuat
            // 
            this.lbThongKePhieuXuat.AutoSize = true;
            this.lbThongKePhieuXuat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKePhieuXuat.Location = new System.Drawing.Point(422, 12);
            this.lbThongKePhieuXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongKePhieuXuat.Name = "lbThongKePhieuXuat";
            this.lbThongKePhieuXuat.Size = new System.Drawing.Size(370, 36);
            this.lbThongKePhieuXuat.TabIndex = 0;
            this.lbThongKePhieuXuat.Text = "THỐNG KÊ PHIẾU XUẤT";
            // 
            // groupBoxchitiet
            // 
            this.groupBoxchitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxchitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxchitiet.Controls.Add(this.dgThongKepx);
            this.groupBoxchitiet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxchitiet.Location = new System.Drawing.Point(0, 247);
            this.groupBoxchitiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxchitiet.Name = "groupBoxchitiet";
            this.groupBoxchitiet.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxchitiet.Size = new System.Drawing.Size(1326, 322);
            this.groupBoxchitiet.TabIndex = 1;
            this.groupBoxchitiet.TabStop = false;
            this.groupBoxchitiet.Text = "Chi tiết";
            // 
            // dgThongKepx
            // 
            this.dgThongKepx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgThongKepx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThongKepx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgThongKepx.Location = new System.Drawing.Point(4, 58);
            this.dgThongKepx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgThongKepx.Name = "dgThongKepx";
            this.dgThongKepx.RowHeadersWidth = 51;
            this.dgThongKepx.Size = new System.Drawing.Size(1318, 259);
            this.dgThongKepx.TabIndex = 0;
            // 
            // groupBoxthongtin
            // 
            this.groupBoxthongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxthongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxthongtin.Controls.Add(this.btThongKe);
            this.groupBoxthongtin.Controls.Add(this.txtTongTien);
            this.groupBoxthongtin.Controls.Add(this.btTongTien);
            this.groupBoxthongtin.Controls.Add(this.toolStrip1);
            this.groupBoxthongtin.Controls.Add(this.lbDenNgay);
            this.groupBoxthongtin.Controls.Add(this.lbTừNgày);
            this.groupBoxthongtin.Controls.Add(this.dtpDenNgay);
            this.groupBoxthongtin.Controls.Add(this.dtpTuNgay);
            this.groupBoxthongtin.Controls.Add(this.cbKieuThongKe);
            this.groupBoxthongtin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxthongtin.Location = new System.Drawing.Point(0, 5);
            this.groupBoxthongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxthongtin.Name = "groupBoxthongtin";
            this.groupBoxthongtin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxthongtin.Size = new System.Drawing.Size(1326, 243);
            this.groupBoxthongtin.TabIndex = 0;
            this.groupBoxthongtin.TabStop = false;
            this.groupBoxthongtin.Text = "Thống kê";
            // 
            // btThongKe
            // 
            this.btThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btThongKe.Image = global::ProjectOOP1.Properties.Resources.chart;
            this.btThongKe.Location = new System.Drawing.Point(321, 93);
            this.btThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(169, 84);
            this.btThongKe.TabIndex = 1;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThongKe.UseVisualStyleBackColor = false;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(1128, 194);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(148, 27);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // btTongTien
            // 
            this.btTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btTongTien.Location = new System.Drawing.Point(1008, 194);
            this.btTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTongTien.Name = "btTongTien";
            this.btTongTien.Size = new System.Drawing.Size(112, 37);
            this.btTongTien.TabIndex = 8;
            this.btTongTien.Text = "Tổng Tiền";
            this.btTongTien.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsTroLai,
            this.tsThoat});
            this.toolStrip1.Location = new System.Drawing.Point(4, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(307, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::ProjectOOP1.Properties.Resources.Thêm;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 28);
            this.toolStripButton1.Text = "Làm mới";
            this.toolStripButton1.Click += new System.EventHandler(this.tsLamMoi_Click);
            // 
            // tsTroLai
            // 
            this.tsTroLai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTroLai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsTroLai.Image = global::ProjectOOP1.Properties.Resources.back;
            this.tsTroLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTroLai.Name = "tsTroLai";
            this.tsTroLai.Size = new System.Drawing.Size(81, 28);
            this.tsTroLai.Text = "Trở lại";
            this.tsTroLai.Click += new System.EventHandler(this.tsTroLai_Click);
            // 
            // tsThoat
            // 
            this.tsThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsThoat.Image = global::ProjectOOP1.Properties.Resources.exit;
            this.tsThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThoat.Name = "tsThoat";
            this.tsThoat.Size = new System.Drawing.Size(77, 28);
            this.tsThoat.Text = "Thoát";
            this.tsThoat.Click += new System.EventHandler(this.tsThoat_Click);
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(907, 105);
            this.lbDenNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(82, 21);
            this.lbDenNgay.TabIndex = 4;
            this.lbDenNgay.Text = "Đến Ngày";
            // 
            // lbTừNgày
            // 
            this.lbTừNgày.AutoSize = true;
            this.lbTừNgày.Location = new System.Drawing.Point(512, 105);
            this.lbTừNgày.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTừNgày.Name = "lbTừNgày";
            this.lbTừNgày.Size = new System.Drawing.Size(70, 21);
            this.lbTừNgày.TabIndex = 2;
            this.lbTừNgày.Text = "Từ ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(1008, 100);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(298, 27);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(600, 100);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(298, 27);
            this.dtpTuNgay.TabIndex = 3;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // cbKieuThongKe
            // 
            this.cbKieuThongKe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKieuThongKe.FormattingEnabled = true;
            this.cbKieuThongKe.Items.AddRange(new object[] {
            "Thống kê ngày",
            "Thống kê tháng",
            "Thống kê năm"});
            this.cbKieuThongKe.Location = new System.Drawing.Point(15, 113);
            this.cbKieuThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbKieuThongKe.Name = "cbKieuThongKe";
            this.cbKieuThongKe.Size = new System.Drawing.Size(298, 27);
            this.cbKieuThongKe.TabIndex = 1;
            this.cbKieuThongKe.Text = "Chọn kiểu thống kê";
            this.cbKieuThongKe.SelectedIndexChanged += new System.EventHandler(this.cbKieuThongKe_SelectedIndexChanged);
            // 
            // frmthongkephieuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 664);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmthongkephieuxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ PHIẾU XUẤT";
            this.Load += new System.EventHandler(this.frmthongkephieuxuat_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxchitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKepx)).EndInit();
            this.groupBoxthongtin.ResumeLayout(false);
            this.groupBoxthongtin.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbThongKePhieuXuat;
        private System.Windows.Forms.GroupBox groupBoxchitiet;
        private System.Windows.Forms.DataGridView dgThongKepx;
        private System.Windows.Forms.GroupBox groupBoxthongtin;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.ComboBox cbKieuThongKe;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsThoat;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTừNgày;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btTongTien;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.ToolStripButton tsTroLai;
    }
}
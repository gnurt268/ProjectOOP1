namespace ProjectOOP1
{
    partial class frmThongkesanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongkesanpham));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbThongKesp = new System.Windows.Forms.Label();
            this.groupBoxdanhsach = new System.Windows.Forms.GroupBox();
            this.dgThongKesp = new System.Windows.Forms.DataGridView();
            this.groupBoxthongkesp = new System.Windows.Forms.GroupBox();
            this.btthongke = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsLamMoi = new System.Windows.Forms.ToolStripButton();
            this.tsTroLai = new System.Windows.Forms.ToolStripButton();
            this.tsThoat = new System.Windows.Forms.ToolStripButton();
            this.cbKieuThongKe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKesp)).BeginInit();
            this.groupBoxthongkesp.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel1.Controls.Add(this.lbThongKesp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxdanhsach);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxthongkesp);
            this.splitContainer1.Size = new System.Drawing.Size(1224, 685);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbThongKesp
            // 
            this.lbThongKesp.AutoSize = true;
            this.lbThongKesp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKesp.Location = new System.Drawing.Point(441, 25);
            this.lbThongKesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongKesp.Name = "lbThongKesp";
            this.lbThongKesp.Size = new System.Drawing.Size(344, 36);
            this.lbThongKesp.TabIndex = 0;
            this.lbThongKesp.Text = "THỐNG KÊ SẢN PHẨM";
            // 
            // groupBoxdanhsach
            // 
            this.groupBoxdanhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxdanhsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxdanhsach.Controls.Add(this.dgThongKesp);
            this.groupBoxdanhsach.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxdanhsach.Location = new System.Drawing.Point(0, 178);
            this.groupBoxdanhsach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxdanhsach.Name = "groupBoxdanhsach";
            this.groupBoxdanhsach.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxdanhsach.Size = new System.Drawing.Size(1228, 403);
            this.groupBoxdanhsach.TabIndex = 1;
            this.groupBoxdanhsach.TabStop = false;
            this.groupBoxdanhsach.Text = "Danh sách";
            // 
            // dgThongKesp
            // 
            this.dgThongKesp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgThongKesp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThongKesp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgThongKesp.Location = new System.Drawing.Point(4, 57);
            this.dgThongKesp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgThongKesp.Name = "dgThongKesp";
            this.dgThongKesp.RowHeadersWidth = 51;
            this.dgThongKesp.Size = new System.Drawing.Size(1220, 341);
            this.dgThongKesp.TabIndex = 0;
            // 
            // groupBoxthongkesp
            // 
            this.groupBoxthongkesp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxthongkesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxthongkesp.Controls.Add(this.btthongke);
            this.groupBoxthongkesp.Controls.Add(this.toolStrip1);
            this.groupBoxthongkesp.Controls.Add(this.cbKieuThongKe);
            this.groupBoxthongkesp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxthongkesp.Location = new System.Drawing.Point(0, -1);
            this.groupBoxthongkesp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxthongkesp.Name = "groupBoxthongkesp";
            this.groupBoxthongkesp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxthongkesp.Size = new System.Drawing.Size(1236, 200);
            this.groupBoxthongkesp.TabIndex = 0;
            this.groupBoxthongkesp.TabStop = false;
            this.groupBoxthongkesp.Text = "Thống kê";
            // 
            // btthongke
            // 
            this.btthongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btthongke.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthongke.Image = global::ProjectOOP1.Properties.Resources.chart;
            this.btthongke.Location = new System.Drawing.Point(429, 93);
            this.btthongke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btthongke.Name = "btthongke";
            this.btthongke.Size = new System.Drawing.Size(169, 84);
            this.btthongke.TabIndex = 1;
            this.btthongke.Text = "Thống kê";
            this.btthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btthongke.UseVisualStyleBackColor = false;
            this.btthongke.Click += new System.EventHandler(this.btthongke_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLamMoi,
            this.tsTroLai,
            this.tsThoat});
            this.toolStrip1.Location = new System.Drawing.Point(4, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(268, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsLamMoi
            // 
            this.tsLamMoi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLamMoi.Image = global::ProjectOOP1.Properties.Resources.Thêm;
            this.tsLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLamMoi.Name = "tsLamMoi";
            this.tsLamMoi.Size = new System.Drawing.Size(97, 28);
            this.tsLamMoi.Text = "Làm mới";
            this.tsLamMoi.Click += new System.EventHandler(this.tsLamMoi_Click);
            // 
            // tsTroLai
            // 
            this.tsTroLai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // cbKieuThongKe
            // 
            this.cbKieuThongKe.FormattingEnabled = true;
            this.cbKieuThongKe.Items.AddRange(new object[] {
            "Thống kê sản phẩm bán chạy",
            "Thống kê sản phẩm bán chậm"});
            this.cbKieuThongKe.Location = new System.Drawing.Point(26, 110);
            this.cbKieuThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbKieuThongKe.Name = "cbKieuThongKe";
            this.cbKieuThongKe.Size = new System.Drawing.Size(394, 27);
            this.cbKieuThongKe.TabIndex = 1;
            this.cbKieuThongKe.Tag = "";
            this.cbKieuThongKe.Text = "Chọn kiểu thống kê";
            // 
            // frmThongkesanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 690);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongkesanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmThongkesanpham_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxdanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKesp)).EndInit();
            this.groupBoxthongkesp.ResumeLayout(false);
            this.groupBoxthongkesp.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbThongKesp;
        private System.Windows.Forms.GroupBox groupBoxdanhsach;
        private System.Windows.Forms.DataGridView dgThongKesp;
        private System.Windows.Forms.GroupBox groupBoxthongkesp;
        private System.Windows.Forms.ComboBox cbKieuThongKe;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsLamMoi;
        private System.Windows.Forms.ToolStripButton tsThoat;
        private System.Windows.Forms.ToolStripButton tsTroLai;
        private System.Windows.Forms.Button btthongke;
    }
}
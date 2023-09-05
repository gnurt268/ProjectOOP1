namespace ProjectOOP1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabhethong = new System.Windows.Forms.TabPage();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.btthaydoitaikhoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabquanly = new System.Windows.Forms.TabPage();
            this.btnhanvien = new System.Windows.Forms.Button();
            this.btphieuxuat = new System.Windows.Forms.Button();
            this.btchitietphieuxuat = new System.Windows.Forms.Button();
            this.btsanpham = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabthongke = new System.Windows.Forms.TabPage();
            this.bttksp = new System.Windows.Forms.Button();
            this.bttkpx = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabtrogiup = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.bttrogiup = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabhethong.SuspendLayout();
            this.tabquanly.SuspendLayout();
            this.tabthongke.SuspendLayout();
            this.tabtrogiup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabhethong);
            this.tabControl1.Controls.Add(this.tabquanly);
            this.tabControl1.Controls.Add(this.tabthongke);
            this.tabControl1.Controls.Add(this.tabtrogiup);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 211);
            this.tabControl1.TabIndex = 2;
            // 
            // tabhethong
            // 
            this.tabhethong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabhethong.Controls.Add(this.btdangnhap);
            this.tabhethong.Controls.Add(this.btthaydoitaikhoan);
            this.tabhethong.Controls.Add(this.label2);
            this.tabhethong.Controls.Add(this.label1);
            this.tabhethong.Location = new System.Drawing.Point(4, 30);
            this.tabhethong.Margin = new System.Windows.Forms.Padding(4);
            this.tabhethong.Name = "tabhethong";
            this.tabhethong.Padding = new System.Windows.Forms.Padding(4);
            this.tabhethong.Size = new System.Drawing.Size(1184, 177);
            this.tabhethong.TabIndex = 0;
            this.tabhethong.Text = "Hệ thống";
            // 
            // btdangnhap
            // 
            this.btdangnhap.Image = global::ProjectOOP1.Properties.Resources.Login;
            this.btdangnhap.Location = new System.Drawing.Point(59, 26);
            this.btdangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(64, 64);
            this.btdangnhap.TabIndex = 0;
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // btthaydoitaikhoan
            // 
            this.btthaydoitaikhoan.Image = global::ProjectOOP1.Properties.Resources.ChangeUser;
            this.btthaydoitaikhoan.Location = new System.Drawing.Point(303, 26);
            this.btthaydoitaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btthaydoitaikhoan.Name = "btthaydoitaikhoan";
            this.btthaydoitaikhoan.Size = new System.Drawing.Size(64, 64);
            this.btthaydoitaikhoan.TabIndex = 3;
            this.btthaydoitaikhoan.UseVisualStyleBackColor = true;
            this.btthaydoitaikhoan.Click += new System.EventHandler(this.btthaydoitaikhoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thay đổi tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đăng nhập";
            // 
            // tabquanly
            // 
            this.tabquanly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabquanly.Controls.Add(this.btnhanvien);
            this.tabquanly.Controls.Add(this.btphieuxuat);
            this.tabquanly.Controls.Add(this.btchitietphieuxuat);
            this.tabquanly.Controls.Add(this.btsanpham);
            this.tabquanly.Controls.Add(this.label6);
            this.tabquanly.Controls.Add(this.label5);
            this.tabquanly.Controls.Add(this.label4);
            this.tabquanly.Controls.Add(this.label3);
            this.tabquanly.Location = new System.Drawing.Point(4, 30);
            this.tabquanly.Margin = new System.Windows.Forms.Padding(4);
            this.tabquanly.Name = "tabquanly";
            this.tabquanly.Padding = new System.Windows.Forms.Padding(4);
            this.tabquanly.Size = new System.Drawing.Size(1184, 177);
            this.tabquanly.TabIndex = 1;
            this.tabquanly.Text = "Quản lý";
            // 
            // btnhanvien
            // 
            this.btnhanvien.Image = global::ProjectOOP1.Properties.Resources.employee;
            this.btnhanvien.Location = new System.Drawing.Point(59, 26);
            this.btnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.btnhanvien.Name = "btnhanvien";
            this.btnhanvien.Size = new System.Drawing.Size(64, 64);
            this.btnhanvien.TabIndex = 3;
            this.btnhanvien.UseVisualStyleBackColor = true;
            this.btnhanvien.Click += new System.EventHandler(this.btnhanvien_Click);
            // 
            // btphieuxuat
            // 
            this.btphieuxuat.Image = global::ProjectOOP1.Properties.Resources.order;
            this.btphieuxuat.Location = new System.Drawing.Point(547, 26);
            this.btphieuxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btphieuxuat.Name = "btphieuxuat";
            this.btphieuxuat.Size = new System.Drawing.Size(64, 64);
            this.btphieuxuat.TabIndex = 5;
            this.btphieuxuat.UseVisualStyleBackColor = true;
            this.btphieuxuat.Click += new System.EventHandler(this.btphieuxuat_Click);
            // 
            // btchitietphieuxuat
            // 
            this.btchitietphieuxuat.Image = global::ProjectOOP1.Properties.Resources.bill;
            this.btchitietphieuxuat.Location = new System.Drawing.Point(791, 26);
            this.btchitietphieuxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btchitietphieuxuat.Name = "btchitietphieuxuat";
            this.btchitietphieuxuat.Size = new System.Drawing.Size(72, 74);
            this.btchitietphieuxuat.TabIndex = 6;
            this.btchitietphieuxuat.UseVisualStyleBackColor = true;
            this.btchitietphieuxuat.Click += new System.EventHandler(this.btchitietphieuxuat_Click);
            // 
            // btsanpham
            // 
            this.btsanpham.Image = global::ProjectOOP1.Properties.Resources.foodncoffee;
            this.btsanpham.Location = new System.Drawing.Point(303, 26);
            this.btsanpham.Margin = new System.Windows.Forms.Padding(4);
            this.btsanpham.Name = "btsanpham";
            this.btsanpham.Size = new System.Drawing.Size(72, 64);
            this.btsanpham.TabIndex = 4;
            this.btsanpham.UseVisualStyleBackColor = true;
            this.btsanpham.Click += new System.EventHandler(this.btsanpham_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(761, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chi tiết phiếu xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quản lý phiếu xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quản lý sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quản lý nhân viên";
            // 
            // tabthongke
            // 
            this.tabthongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabthongke.Controls.Add(this.bttksp);
            this.tabthongke.Controls.Add(this.bttkpx);
            this.tabthongke.Controls.Add(this.label8);
            this.tabthongke.Controls.Add(this.label7);
            this.tabthongke.Location = new System.Drawing.Point(4, 30);
            this.tabthongke.Margin = new System.Windows.Forms.Padding(4);
            this.tabthongke.Name = "tabthongke";
            this.tabthongke.Size = new System.Drawing.Size(1184, 177);
            this.tabthongke.TabIndex = 2;
            this.tabthongke.Text = "Thống kê";
            // 
            // bttksp
            // 
            this.bttksp.Image = global::ProjectOOP1.Properties.Resources.tkphieuxuat;
            this.bttksp.Location = new System.Drawing.Point(59, 26);
            this.bttksp.Margin = new System.Windows.Forms.Padding(4);
            this.bttksp.Name = "bttksp";
            this.bttksp.Size = new System.Drawing.Size(64, 64);
            this.bttksp.TabIndex = 1;
            this.bttksp.UseVisualStyleBackColor = true;
            this.bttksp.Click += new System.EventHandler(this.bttksp_Click);
            // 
            // bttkpx
            // 
            this.bttkpx.Image = global::ProjectOOP1.Properties.Resources.tksanpham;
            this.bttkpx.Location = new System.Drawing.Point(303, 26);
            this.bttkpx.Margin = new System.Windows.Forms.Padding(4);
            this.bttkpx.Name = "bttkpx";
            this.bttkpx.Size = new System.Drawing.Size(64, 64);
            this.bttkpx.TabIndex = 2;
            this.bttkpx.UseVisualStyleBackColor = true;
            this.bttkpx.Click += new System.EventHandler(this.bttkpx_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thống kê sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thống kê phiếu xuất";
            // 
            // tabtrogiup
            // 
            this.tabtrogiup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabtrogiup.Controls.Add(this.label10);
            this.tabtrogiup.Controls.Add(this.bttrogiup);
            this.tabtrogiup.Location = new System.Drawing.Point(4, 30);
            this.tabtrogiup.Margin = new System.Windows.Forms.Padding(4);
            this.tabtrogiup.Name = "tabtrogiup";
            this.tabtrogiup.Size = new System.Drawing.Size(1184, 177);
            this.tabtrogiup.TabIndex = 3;
            this.tabtrogiup.Text = "Trợ giúp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Trợ giúp";
            // 
            // bttrogiup
            // 
            this.bttrogiup.Image = global::ProjectOOP1.Properties.Resources.help;
            this.bttrogiup.Location = new System.Drawing.Point(59, 26);
            this.bttrogiup.Margin = new System.Windows.Forms.Padding(4);
            this.bttrogiup.Name = "bttrogiup";
            this.bttrogiup.Size = new System.Drawing.Size(64, 64);
            this.bttrogiup.TabIndex = 0;
            this.bttrogiup.UseVisualStyleBackColor = true;
            this.bttrogiup.Click += new System.EventHandler(this.bttrogiup_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 23);
            this.label9.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 219);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ProjectOOP1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Coffee";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabhethong.ResumeLayout(false);
            this.tabhethong.PerformLayout();
            this.tabquanly.ResumeLayout(false);
            this.tabquanly.PerformLayout();
            this.tabthongke.ResumeLayout(false);
            this.tabthongke.PerformLayout();
            this.tabtrogiup.ResumeLayout(false);
            this.tabtrogiup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabtrogiup;
        private System.Windows.Forms.TabPage tabthongke;
        private System.Windows.Forms.TabPage tabquanly;
        private System.Windows.Forms.TabPage tabhethong;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btthaydoitaikhoan;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btchitietphieuxuat;
        private System.Windows.Forms.Button btphieuxuat;
        private System.Windows.Forms.Button btsanpham;
        private System.Windows.Forms.Button btnhanvien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttkpx;
        private System.Windows.Forms.Button bttksp;
        private System.Windows.Forms.Button bttrogiup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
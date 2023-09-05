using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }    
        private void btdangnhap_Click(object Sender, EventArgs e)
        {
            frmDangnhap frm = new frmDangnhap();
            frm.ShowDialog();
            if (frm.kt == true)
            {
                //MessageBox.Show("Đăng Nhập Thành Công");
                Dangnhapthanhcong();
            }
        }
        private void btnhanvien_Click(object sender, EventArgs e)
        {
            frmQuanlynhanvien qlnv = new frmQuanlynhanvien();
            qlnv.ShowDialog();
        }
        private void btsanpham_Click(object sender, EventArgs e)
        {
            frmSanPham qlsp = new frmSanPham();
            qlsp.ShowDialog();
        }
        private void btthaydoitaikhoan_Click(object sender, EventArgs e)
        {
            frmThaydoitaikhoan a = new frmThaydoitaikhoan();
            a.ShowDialog();
        }
        private void btchitietphieuxuat_Click(object sender, EventArgs e)
        {
            frmchitietphieuxuat b = new frmchitietphieuxuat();
            b.ShowDialog();
        }       
        private void btphieuxuat_Click(object sender, EventArgs e)
        {
            frmQuanlyphieuxuat qlpx = new frmQuanlyphieuxuat();
            qlpx.ShowDialog();
        }
        private void bttkpx_Click(object sender, EventArgs e)
        {
            frmthongkephieuxuat tkpx = new frmthongkephieuxuat();
            tkpx.ShowDialog();
        }
        private void bttksp_Click(object sender, EventArgs e)
        {
            frmThongkesanpham tkpx = new frmThongkesanpham();
            tkpx.ShowDialog();
        }
        private void bttrogiup_Click(object sender, EventArgs e)
        {
            frmTroGiup tg = new frmTroGiup();
            tg.ShowDialog();
        }
        public void Dangnhapthanhcong()
        {
            btthaydoitaikhoan.Enabled = true;
            //tsQuanLy.Enabled = true;
            //tsThongKe.Enabled = true;
            tabtrogiup.Enabled = true;
            btnhanvien.Enabled = true;
            btsanpham.Enabled = true;
            bttkpx.Enabled = true;
            bttksp.Enabled = true;
            btphieuxuat.Enabled = true;
            btchitietphieuxuat.Enabled = true;
            
        }        
        private void frmquanly_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không?", "Thoát khỏi chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            { e.Cancel = false; }
            else e.Cancel = true;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongTimeString();
        }    
        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayofmonth);
            timer1.Enabled = true;
            timer1.Start();
            label9.Text = DateTime.Now.ToLongTimeString();
            //SoundPlayer a = new SoundPlayer("aa.wav");
            //a.Play();
            btthaydoitaikhoan.Enabled = false;
            tabtrogiup.Enabled = true;
            btnhanvien.Enabled = false;
            btsanpham.Enabled = false;
            btphieuxuat.Enabled = false;
            bttksp.Enabled = false;
            bttkpx.Enabled = false;
            btchitietphieuxuat.Enabled = false;



        }
    }
}

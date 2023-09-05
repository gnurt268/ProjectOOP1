using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectOOP1.DataAccess;
using ProjectOOP1.Entities;
using ProjectOOP1.Business;

namespace ProjectOOP1
{
    public partial class frmchitietphieuxuat : Form
    {
        public frmchitietphieuxuat()
        {
            InitializeComponent();

        }
        ChiTietPhieuXuatBLL bll = new ChiTietPhieuXuatBLL();
        SanPhamBLL dtb = new SanPhamBLL();
        PhieuXuatBLL pxb = new PhieuXuatBLL();
        DataTable dt = new DataTable();
        // xây dựng phương thức tính tổng tiền
        double Tong = 0;
        public double TongTien(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tong = Tong + double.Parse(dt.Rows[i][3].ToString());
            }
            return Tong;
        }
        // tim kiem các chi tiết phiếu xuất để tính tổng tiền
        private void btTimKiem_Click(object sender, EventArgs e)
        {


            DataTable dt = bll.Listctpx(cbTimKiem.Text);
            {
                dgChiTietPhieuXuat.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    txtTongtien.Text = TongTien(dt).ToString();

                }
                else
                {
                    txtTongtien.Text = "";
                }
            }
            cbTimKiem.Text = "";
        }
        // load form
        private void frmchitietphieuxuat_Load(object sender, EventArgs e)
        {
            dgChiTietPhieuXuat.DataSource = bll.Loadctpx();

            // load mã sản phẩm
            SanPhamBLL dtb = new SanPhamBLL();
            cbMaSanPham.DataSource = dtb.LoadSP();
            cbMaSanPham.DisplayMember = "masp";
            cbMaSanPham.ValueMember = "dongia";

            //load ma phieu xuat
            PhieuXuatBLL pxb = new PhieuXuatBLL();
            cbMaPhieuXuat.DataSource = pxb.LoadPX();
            cbMaPhieuXuat.DisplayMember = "mapx";
            
            //load ma phieu xuat vao ô tìm kiếm
            cbTimKiem.DataSource = pxb.LoadPX();
            cbTimKiem.DisplayMember = "mapx";
        }
        // gọi sự kiện cellclick
        private void dgChiTietPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbMaPhieuXuat.Text = dgChiTietPhieuXuat[0, hang].Value.ToString();
            cbMaSanPham.Text = dgChiTietPhieuXuat[1, hang].Value.ToString();
            txtSoLuong.Text = dgChiTietPhieuXuat[2, hang].Value.ToString();
            txtThanhTien.Text = dgChiTietPhieuXuat[3, hang].Value.ToString();

        }       
        // xây dựng phuong thuc tính tiến dùng chung
        public void tinhtien()
        {
            int soluong;
            double dongia, thanhtien;
            if (txtSoLuong.Text == "")
            { MessageBox.Show("Chưa nhập số lượng"); }
            else
            {
                soluong = int.Parse(txtSoLuong.Text);
                dongia = double.Parse(txtDonGia.Text);

                if (soluong <= 0)
                {
                    MessageBox.Show("Số lượng phải >0");
                }
                else
                {
                    thanhtien = soluong * dongia;
                    txtThanhTien.Text = thanhtien.ToString();

                }

            }
        }        
        // xây dựng phương thức nhập vào mã sản phẩm là hiện lên giá bán tương ứng
        private void cbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtb.laygiaban(cbMaSanPham.Text);

            {
                txtDonGia.Text = cbMaSanPham.SelectedValue.ToString();

            }
        }   
        // không cho nhập số lượng là số
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }
        // không cho phép nhập giá bán là số
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }
        // làm mới các textbook và combobox
        private void tsLamMoi_Click(object sender, EventArgs e)
        {

            cbMaSanPham.Text = "";
            cbMaPhieuXuat.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            txtTongtien.Text = "";
        }
        // đóng form
        private void tsThoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
        private void tsTraSP_Click(object sender, EventArgs e)
        {
            frmSanPham s = new frmSanPham();
            s.ShowDialog();
        }
        private void tsQuaylai_Click(object sender, EventArgs e)
        {
            frmchitietphieuxuat_Load(sender, e);
            txtTongtien.Text = "";
        }
        // thêm chi tiết phiếu xuất
        private void tsThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra sự hợp lệ của chi tiết phiếu xuất
            if (bll.tongbanghi(cbMaPhieuXuat.Text, cbMaSanPham.Text) == 1)
                MessageBox.Show("Chi tiết phiếu xuất này không hợp lệ. Nhập chi tiết phiếu xuất khác!");
            else if (bll.tongbanghi(cbMaPhieuXuat.Text, cbMaSanPham.Text) == 0)
            {
                if (txtSoLuong.Text != "" && txtDonGia.Text != "")
                {
                    tinhtien();
                    MessageBox.Show("Số tiền khách hàng phải trả cho sản phẩm này là:" + txtThanhTien.Text + "");
                }

                bll.Thempx(cbMaPhieuXuat.Text, cbMaSanPham.Text, int.Parse(txtSoLuong.Text), double.Parse(txtThanhTien.Text));
                frmchitietphieuxuat_Load(sender, e);

            }
        }
        // xóa các chi tiết phiếu xuât
        private void tsXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chi tiết phiếu xuất này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.XoaChiTietPhieuXuat(cbMaPhieuXuat.Text, cbMaSanPham.Text, int.Parse(txtSoLuong.Text), double.Parse(txtThanhTien.Text));


                MessageBox.Show("Xóa thành công!");
                frmchitietphieuxuat_Load(sender, e);

            }
        }
        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

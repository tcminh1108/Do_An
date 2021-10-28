using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace App_Pharmacy
{
    public partial class FrmQLTK : Form
    {
        QLTK tk = new QLTK();
        int Tong = 0;
        string tendangnhap = "", matkhau = "", maNV = "";
        int phanloai, thuoc, nhanvien, khachhang, ncc, hoadon, dondatthuoc;
        public FrmQLTK()
        {
            InitializeComponent();
        }
        public FrmQLTK(string tendangnhap, string matkhau, int phanloai, string maNV, int thuoc, int nhanvien, int khachhang, int ncc, int hoadon, int dondatthuoc)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.phanloai = phanloai;
            this.maNV = maNV;
            this.thuoc = thuoc;
            this.nhanvien = nhanvien;
            this.khachhang = khachhang;
            this.ncc = ncc;
            this.hoadon = hoadon;
            this.dondatthuoc = dondatthuoc;
        }
        //Hiển thị danh sách thuốc
        private void HienthiTK()
        {
            lsvDanhSachThongTin.Items.Clear();
            DataTable dt = tk.LayDSTK();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                Tong += 1;
            }
            lblTong.Text = Tong.ToString();
            Tong = 0;
        }
        //Hiển thị danh sách thuốc tìm theo tên
        private void DSTimKiemTen()
        {
            lsvDanhSachThongTin.Items.Clear();
            DataTable dt = tk.TimKiemTen(txtTimKiem.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                Tong += 1;
            }
            lblTong.Text = Tong.ToString();
            Tong = 0;
        }
        void setNull()
        {
            txtUsername.Text = "";
            cbThuoc.Checked = false;
            cbNhanVien.Checked = false;
            cbKhachHang.Checked = false;
            cbNhaCungCap.Checked = false;
            cbHoaDon.Checked = false;
            cbDonDatHang.Checked = false;
        }

        void setButton(bool val)
        {
            btnPhanQuyen.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnKhoiPhuc.Enabled = !val;
        }
        private void FrmQLTK_Load(object sender, EventArgs e)
        {
            HienthiTK();
            txtUsername.Text = "";
            txtUsername.ReadOnly = true;
            setButton(true);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                HienthiTK();
            }
            else
            {
                lsvDanhSachThongTin.Items.Clear();
                if (txtTimKiem.Text == "Nhập thông tin cần tìm")
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    DSTimKiemTen();
                }
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                HienthiTK();
            }
        }

        //điều chỉnh khu vực nhập thông tin
        private void dieuchinh(bool e)
        {
            if (e == true)
            {
                pnThongTin.Visible = true;
                pbUpDown.IconChar = IconChar.AngleDown;
            }
            else
            {
                pnThongTin.Visible = false;
                pbUpDown.IconChar = IconChar.AngleUp;
            }
        }

        private void pbUpDown_Click(object sender, EventArgs e)
        {
            if (pbUpDown.IconChar == IconChar.AngleUp)
            {
                dieuchinh(true);
            }
            else
            {
                dieuchinh(false);
            }
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            setNull();
            setButton(false);
            txtUsername.ReadOnly = true;
            dieuchinh(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //thuốc
            if (cbThuoc.Checked == true)
                thuoc = 1;
            else
                thuoc = 2;
            //nhân viên
            if (cbNhanVien.Checked == true)
                nhanvien = 1;
            else
                nhanvien = 2;
            //khách hàng
            if (cbKhachHang.Checked == true)
                khachhang = 1;
            else
                khachhang = 2;
            //Nhà cung cấp
            if (cbNhaCungCap.Checked == true)
                ncc = 1;
            else
                ncc = 2;
            //hóa đơn
            if (cbHoaDon.Checked == true)
                hoadon = 1;
            else
                hoadon = 2;
            //đơn đặt thuốc
            if (cbDonDatHang.Checked == true)
                dondatthuoc = 1;
            else
                dondatthuoc = 2;
            tk.CapNhat(txtUsername.Text, thuoc, nhanvien, khachhang, ncc, hoadon, dondatthuoc);
            MessageBox.Show("Phân Quyền Thành Công!");
            setNull();
            setButton(true);
            txtUsername.ReadOnly = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            txtUsername.ReadOnly = true;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            setNull();
            txtUsername.ReadOnly = true;
        }
        private void lsvDanhSachThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = true;
            if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
            {
                txtUsername.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                //thuốc
                if (thuoc == 1)
                    cbThuoc.Checked = true;
                else
                    cbThuoc.Checked = false;
                //nhân viên
                if (nhanvien == 1)
                    cbNhanVien.Checked = true;
                else
                    cbNhanVien.Checked = false;
                //khách hàng
                if (khachhang == 1)
                    cbKhachHang.Checked = true;
                else
                    cbKhachHang.Checked = false;
                //Nhà cung cấp
                if (ncc == 1)
                    cbNhaCungCap.Checked = true;
                else
                    cbNhaCungCap.Checked = false;
                //hóa đơn
                if (hoadon == 1)
                    cbHoaDon.Checked = true;
                else
                    cbHoaDon.Checked = false;
                //đơn đặt thuốc
                if (dondatthuoc == 1)
                    cbDonDatHang.Checked = true;
                else
                    cbDonDatHang.Checked = false;
            }
        }
    }
}

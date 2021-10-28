using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Pharmacy
{
    public partial class FrmHoaDon : Form
    {
        HoaDon hd = new HoaDon();
        Boolean themmoi;
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        #region set
        void setNull()
        {
            cboTenThuoc.Text = "";
            txtSoLuong.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnLamMoi.Enabled = !val;
            
        }
        void setKhoa(bool val)
        {
            txtMaHD.ReadOnly = val;
            cboTenNV.Enabled = !val;
            cboTenKH.Enabled = !val;
            cboTenThuoc.Enabled = !val;
            txtSoLuong.ReadOnly = val;
            dtNgayLap.Enabled = !val;
        }
        #endregion
        void lockfull()
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        public void HienthiNhanVien()
        {
            DataTable dt = hd.LayNhanVien();
            cboTenNV.DataSource = dt;
            cboTenNV.DisplayMember = "TEN_NHANVIEN";
            cboTenNV.ValueMember = "MA_NHANVIEN";
        }
        public void HienthiKhachHang()
        {
            DataTable dt = hd.LayKhachHang();
            cboTenKH.DataSource = dt;
            cboTenKH.DisplayMember = "TEN_KHACHHANG";
            cboTenKH.ValueMember = "MA_KHACHHANG";
        }
        public void HienthiThuoc()
        {
            DataTable dt = hd.LayThuoc();
            cboTenThuoc.DataSource = dt;
            cboTenThuoc.DisplayMember = "TEN_THUOC";
            cboTenThuoc.ValueMember = "MA_THUOC";
        }
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            setNull();
            lockfull();
            btnLamMoi.Enabled = false;
            setKhoa(true);
            HienthiNhanVien();
            HienthiKhachHang();
            HienthiThuoc();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            txtMaHD.Text = "";
            cboTenNV.Text = "";
            cboTenKH.Text = "";
            txtMaHD.ReadOnly = false;
            cboTenNV.Enabled = true;
            cboTenKH.Enabled = true;
            dtNgayLap.Enabled = true;
            cboTenThuoc.Enabled = false;
            txtSoLuong.ReadOnly = true; 
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            setNull();
            lockfull();
            setButton(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setNull();
            themmoi = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver 
            
            if (themmoi == true)
                hd.ThemHoaDon(txtMaHD.Text, cboTenKH.SelectedValue.ToString(), cboTenNV.SelectedValue.ToString(), dtNgayLap.CustomFormat, cboTenThuoc.SelectedValue.ToString(), txtSoLuong.Text, txtThanhTien.Text);
            //else
                //nv.CapNhatNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text, txtHoten.Text, ngay, txtDiaChi.Text, txtDienThoai.Text, cboBangCap.SelectedValue.ToString());
            lsvDanhSachThongTin.Items.Clear();
            HienthiThuocTrongHD();
            setNull();
            setButton(true);
            setKhoa(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setNull();
            setKhoa(true);
            setButton(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }
        void HienthiThuocTrongHD()
        {
            DataTable dt = hd.LayDSThuocTrongHD(txtMaHD.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
    }
}

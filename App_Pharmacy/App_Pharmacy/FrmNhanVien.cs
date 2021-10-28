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
    public partial class FrmNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        Boolean themmoi;
        int Tong = 0;
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        //Hiển thị danh sách nhân viên
        private void HienthiNhanVien()
        {
            lsvDanhSachThongTin.Items.Clear();
            DataTable dt = nv.LayDSNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                Tong += 1;
            }
            lblTong.Text = Tong.ToString();
            Tong = 0;
        }
        //Hiển thị danh sách nhân viên tìm theo tên
        private void DSTimKiemTen()
        {
            lsvDanhSachThongTin.Items.Clear();
            DataTable dt = nv.TimKiemTen(txtTimKiem.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                Tong += 1;
            }
            lblTong.Text = Tong.ToString();
            Tong = 0;
        }
        #region set
        void setNull()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            dtNgaySinh.Text = "1/1/2021";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            txtSDT_NV.Text = "";
            txtBangCap.Text = "";
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
            txtMaNV.ReadOnly = val;
            txtTenNV.ReadOnly = val;
            dtNgaySinh.Enabled = !val;
            rbtnNam.Enabled = !val;
            rbtnNu.Enabled = !val;
            txtSDT_NV.ReadOnly = val;
            txtBangCap.ReadOnly = val;
        }
        #endregion
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

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            HienthiNhanVien();
            setNull();
            setKhoa(true);
            setButton(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            setNull();
            themmoi = true;
            dieuchinh(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setButton(false);
            setKhoa(false);
            themmoi = false;
            dieuchinh(true);
            txtMaNV.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DateTime dt = dtNgaySinh.Value;
            string date = dt.ToString("ddMMyyyy");
            string taikhoan = "NVPMC" + date;
            if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    
                    nv.CapNhatTaiKhoan(taikhoan);
                    nv.XoaNhanVien(txtMaNV.Text);
                    lsvDanhSachThongTin.Items.RemoveAt(lsvDanhSachThongTin.SelectedIndices[0]);
                    setNull();
                    HienthiNhanVien();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime dt = dtNgaySinh.Value;
            string date = dt.ToString("ddMMyyyy");
            string taikhoan = "NVPMC" + date;
            string ngay = String.Format("{0:dd/MM/yyyy}", dtNgaySinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver 
            string gioitinh;
            if(rbtnNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            if (themmoi == true)
            {
                nv.ThemNhanVien(txtMaNV.Text, txtTenNV.Text, ngay, gioitinh, txtSDT_NV.Text, txtBangCap.Text);
                nv.ThemTaiKhoan(taikhoan, txtSDT_NV.Text, txtMaNV.Text);
                string thongbao = "Tài Khoản: " + txtSDT_NV.Text + "\nMật Khẩu: " + date;
                MessageBox.Show("Thêm Nhân Viên thành Công\n" + thongbao);
            }
            else
            {
                nv.CapNhatNhanVien(txtMaNV.Text, txtTenNV.Text, ngay, gioitinh, txtSDT_NV.Text, txtBangCap.Text);
            }
            HienthiNhanVien();
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
            setNull();
        }

        private void lsvDanhSachThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
            {
                txtMaNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                txtTenNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text);
                string gioitinh = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
                if(gioitinh == "Nam")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                txtSDT_NV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
                txtBangCap.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[5].Text;

            }
        }

        private void lsvDanhSachThongTin_DoubleClick(object sender, EventArgs e)
        {
            if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
            {
                txtMaNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                txtTenNV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text);
                string gioitinh = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
                if (gioitinh == "Nam")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                txtSDT_NV.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
                txtBangCap.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[5].Text;

            }
            dieuchinh(true);
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                HienthiNhanVien();
            }
            else
            {
                btnThem.Enabled = true;
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
                HienthiNhanVien();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }
    }
}

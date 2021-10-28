using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//thêm thư viện
using FontAwesome.Sharp;

namespace App_Pharmacy
{
    public partial class FrmKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        Boolean themmoi;
        int Tong = 0;
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        //Hiển thị danh sách Khách Hàng
        private void HienthiKH()
        {
            lsvDanhSachThongTin.Items.Clear();
            DataTable dt = kh.LayDSKH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                string ngay = String.Format("{0:yyyy/MM/dd}", dt.Rows[i][2].ToString());

                lvi.SubItems.Add(ngay);

                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                Tong += 1;
            }
            lblTong.Text = Tong.ToString();
            Tong = 0;
        }
        //Hiển thị danh sách Khách Hàng tìm theo tên
        private void DSTimKiemTen()
        {
            lsvDanhSachThongTin.Items.Clear();
            DataTable dt = kh.TimKiemTen(txtTimKiem.Text);
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
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            dtNgaySinh.Text = "1/1/2021";
            txtSDTKH.Text = "";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            txtBenhLy.Text = "";
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
            txtMaKH.ReadOnly = val;
            txtTenKH.ReadOnly = val;
            dtNgaySinh.Enabled = !val;
            txtSDTKH.ReadOnly = val ;
            rbtnNam.Enabled = !val;
            rbtnNu.Enabled = !val;
            txtBenhLy.ReadOnly = val;
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

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            HienthiKH();
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
            txtMaKH.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaKH(txtMaKH.Text);
                    lsvDanhSachThongTin.Items.RemoveAt(lsvDanhSachThongTin.SelectedIndices[0]);
                    setNull();
                    HienthiKH();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:dd/MM/yyyy}", dtNgaySinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver 
            string gioitinh;
            if (rbtnNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            if (themmoi == true)
            {
                kh.ThemKH(txtMaKH.Text, txtTenKH.Text, ngay, txtSDTKH.Text, gioitinh, txtBenhLy.Text);
            }
            else
            {
                kh.CapNhatKH(txtMaKH.Text, txtTenKH.Text, ngay, txtSDTKH.Text, gioitinh, txtBenhLy.Text);
            }
            HienthiKH();
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
                txtMaKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                txtTenKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text);
                txtSDTKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
                string gioitinh = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
                if (gioitinh == "Name")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                txtBenhLy.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void lsvDanhSachThongTin_DoubleClick(object sender, EventArgs e)
        {
            if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
            {
                txtMaKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                txtTenKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text);
                txtSDTKH.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
                string gioitinh = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
                if (gioitinh == "Name")
                {
                    rbtnNam.Checked = true;
                }
                else
                {
                    rbtnNu.Checked = true;
                }
                txtBenhLy.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[5].Text;
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
                HienthiKH();
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
                HienthiKH();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }
    }
}

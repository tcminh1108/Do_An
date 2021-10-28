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
    public partial class FrmThuoc : Form
    {
        Thuoc thuoc = new Thuoc();
        Boolean themmoi;
        int Tong = 0;
        public FrmThuoc()
        {
            InitializeComponent();
        }
        //Hiển thị danh sách thuốc
        private void HienthiThuoc()
        {
            lsvDanhSachThongTin.Items.Clear();
            DataTable dt = thuoc.LayDSThuoc();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                Tong += 1;
            }
            lblTong.Text = Tong.ToString();
            Tong = 0;
        }
        //Hiển thị danh sách thuốc tìm theo tên
        private void DSTimKiemTen()
        {
            lsvDanhSachThongTin.Items.Clear();
            DataTable dt = thuoc.TimKiemTen(txtTimKiem.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDanhSachThongTin.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                Tong += 1;
            }
            lblTong.Text = Tong.ToString();
            Tong = 0;
        }
        #region set
        void setNull()
        {
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            txtGiaBan.Text = "";
            cboDonViTinh.Text = "";
            txtSoLuongTon.Text = "";
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
            txtMaThuoc.ReadOnly = val;
            txtTenThuoc.ReadOnly = val;
            txtGiaBan.ReadOnly = val;
            cboDonViTinh.Enabled = !val;
            txtSoLuongTon.ReadOnly = val;
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
        private void FrmThuoc_Load(object sender, EventArgs e)
        {
            HienthiThuoc();
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
            txtMaThuoc.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    thuoc.XoaThuoc(txtMaThuoc.Text);
                    lsvDanhSachThongTin.Items.RemoveAt(lsvDanhSachThongTin.SelectedIndices[0]);
                    setNull();
                    HienthiThuoc();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                thuoc.ThemThuoc(txtMaThuoc.Text, txtTenThuoc.Text, txtGiaBan.Text, cboDonViTinh.Text, txtSoLuongTon.Text);
            }
            else
            {
                thuoc.CapNhatThuoc(txtMaThuoc.Text, txtTenThuoc.Text, txtGiaBan.Text, cboDonViTinh.Text, txtSoLuongTon.Text);
            }
            HienthiThuoc();
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
                txtMaThuoc.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                txtTenThuoc.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                txtGiaBan.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text;
                cboDonViTinh.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
                txtSoLuongTon.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void lsvDanhSachThongTin_DoubleClick(object sender, EventArgs e)
        {
            if (lsvDanhSachThongTin.SelectedIndices.Count > 0)
            {
                txtMaThuoc.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[0].Text;
                txtTenThuoc.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[1].Text;
                txtGiaBan.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[2].Text;
                cboDonViTinh.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[3].Text;
                txtSoLuongTon.Text = lsvDanhSachThongTin.SelectedItems[0].SubItems[4].Text;
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
            if(txtTimKiem.Text == "")
            {
                HienthiThuoc();
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
            if(txtTimKiem.Text == "")
            {
                HienthiThuoc();
                setNull();
                setKhoa(true);
                setButton(true);
            }
        }
    }
}

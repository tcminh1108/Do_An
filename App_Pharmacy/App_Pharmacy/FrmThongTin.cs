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
    public partial class FrmThongTin : Form
    {
        ThongTin tt = new ThongTin();
        string maNV = "";
        public FrmThongTin()
        {
            InitializeComponent();
        }
        public FrmThongTin(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            txtMaNV.ReadOnly = true;
            txtTaiKhoan.ReadOnly = true;
        }
        private void HienthiThongTinNV()
        { 
            DataTable dt = tt.LayThongTinNV(maNV);
            txtMaNV.Text = dt.Rows[0][0].ToString();
            txtTenNV.Text = dt.Rows[0][1].ToString();
            dtNgaySinh.Value = DateTime.Parse(dt.Rows[0][2].ToString());
            string gioitinh = dt.Rows[0][3].ToString();
            if (gioitinh == "Nam")
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            txtSDT.Text = dt.Rows[0][4].ToString();
            txtBangCap.Text = dt.Rows[0][5].ToString();
        }
        private void HienthiTaiKhoan()
        {
            DataTable dt = tt.LayThongTinTK(maNV);
            txtTaiKhoan.Text = dt.Rows[0][0].ToString();
        }

        private void FrmThongTin_Load(object sender, EventArgs e)
        {
            HienthiThongTinNV();
            HienthiTaiKhoan();
        }
        void setButtonTT(bool val)
        {
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }

        void setButtonDMK(bool val)
        {
            btnDoiMatKhau.Enabled = val;
            btnLuuMK.Enabled = !val;
            btnHuyMK.Enabled = !val;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            setButtonTT(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:dd/MM/yyyy}", dtNgaySinh.Value);
            string gioitinh;
            if (rbtnNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            tt.CapNhatThongTinNV(txtMaNV.Text, txtTenNV.Text, ngay, gioitinh, txtSDT.Text, txtBangCap.Text);
            setButtonTT(true);
            HienthiThongTinNV();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButtonTT(true);
            HienthiThongTinNV();
        }
        private void btnLuuMK_Click(object sender, EventArgs e)
        {
            DataTable dt = tt.LayThongTinTK(maNV);
            if (txtMatKhau.Text == dt.Rows[0][1].ToString())
            {
                if(txtMatKhauMoi.Text.Trim().Length >= 6)
                {
                    if (txtMatKhauMoi.Text == txtNhapLai.Text)
                    {
                        tt.DoiMatKhau(maNV, txtMatKhauMoi.Text);
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại mật khẩu không đúng!", "Thông Báo");
                        txtMatKhauMoi.Text = "";
                        txtNhapLai.Text = "";
                        txtMatKhauMoi.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông Báo");
                    txtMatKhauMoi.Text = "";
                    txtNhapLai.Text = "";
                    txtMatKhauMoi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!", "Thông Báo");
                txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
        }

        private void btnHuyMK_Click(object sender, EventArgs e)
        {
            setButtonDMK(true);
            HienthiTaiKhoan();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            setButtonDMK(true);
        }  
    }
}

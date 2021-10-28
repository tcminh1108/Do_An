using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//thêm thư viện
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace App_Pharmacy
{
    public partial class FrmNhaThuoc : Form
    {
        Database dt;
        DangNhap dangnhap = new DangNhap();
        private IconButton currentBtn;
        private Form currentFormCon;
        string tendangnhap = "", matkhau = "", maNV = "";
        int phanloai, thuoc, nhanvien, khachhang, ncc, hoadon, dondatthuoc;
        public FrmNhaThuoc()
        {
            InitializeComponent();
        }
        public FrmNhaThuoc(string tendangnhap, string matkhau, int phanloai, string maNV, int thuoc, int nhanvien, int khachhang, int ncc, int hoadon, int dondatthuoc)
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
            if (phanloai == 2)
            {
                btnHeThong.Enabled = false;
                if (thuoc == 2)
                    btnThuoc.Enabled = false;
                if (nhanvien == 2)
                    btnNhanVien.Enabled = false;
                if (khachhang == 2)
                    btnKhachHang.Enabled = false;
                if (ncc == 2)
                    btnNhaCungCap.Enabled = false;
                if (hoadon == 2)
                    btnHoaDon.Enabled = false;
                if (dondatthuoc == 2)
                    btnDonDatThuoc.Enabled = false;
            }
            hidePnMenu();
            timer1.Start();
        }
        private void FrmNhaThuoc_Load(object sender, EventArgs e)
        {
            pnChucNang.Width = 300;
            guna2ShadowForm1.SetShadowForm(this);
        }

        //ẩn menu của các chức năng
        private void hidePnMenu()
        {
            pnMenuHeThong.Visible = false;
            pnMenuDanhMuc.Visible = false;
            pnMenuDoiTac.Visible = false;
            pnMenuGiaoDich.Visible = false;
        }

        //thực hiện chức năng phóng to thu nhỏ thanh panel
        #region code
        private void ibtnThuPhong_Click(object sender, EventArgs e)
        {
            if (ibtnThuPhong.IconChar == IconChar.AngleLeft)
            {
                pnChucNang.Visible = false;
                ibtnThuPhong.IconChar = IconChar.AngleRight;
            }
            else
            {
                pnChucNang.Visible = true;
                ibtnThuPhong.IconChar = IconChar.AngleLeft;
            }
        }
        #endregion

        //code mở form
        #region code
        private void openForm(Form formCon)
        {
            if (currentFormCon != null)
            {
                currentFormCon.Close();
            }
            currentFormCon = formCon;
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            pnFormCon.Controls.Add(formCon);
            pnFormCon.Tag = formCon;
            formCon.BringToFront();
            formCon.Show();
        }
        #endregion
        private void Reset()
        {
            timer1.Start();
            ibtnCon.IconChar = IconChar.Home;
            ibtnCon.IconColor = Color.Black;
            ibtnCon.ForeColor = Color.Black;
            ibtnCon.Text = "Trang Chủ";
        }

        //Trang chủ
        private void pbHome_Click(object sender, EventArgs e)
        {
            if (currentFormCon != null)
            {
                currentFormCon.Close();
            }
            Reset();
        }

        //Hệ Thống
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("cha",pnMenuHeThong);

        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuHeThong);
            DataTable dt = dangnhap.KiemTraTaiKhoan(tendangnhap, matkhau);
            openForm(new FrmQLTK(tendangnhap, matkhau, phanloai, maNV, thuoc, nhanvien, khachhang, ncc, hoadon, dondatthuoc));
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuHeThong);
            //openForm(new FrmPhanQuyen());
        }

        //Danh Mục
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("cha",pnMenuDanhMuc);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuDanhMuc);
            openForm(new FrmNhanVien());
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuDanhMuc);
            openForm(new FrmThuoc());
        }

        private void btnKhuVucLuuTru_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuDanhMuc);
            //openForm(new FrmKhachHang());
        }

        //Đối Tác
        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("cha",pnMenuDoiTac);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuDoiTac);
            openForm(new FrmKhachHang());
        }

        

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuDoiTac);
            openForm(new FrmNhaCungCap());
        }

        //Giao dịch
        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("cha",pnMenuGiaoDich);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuGiaoDich);
            openForm(new FrmHoaDon());
        }

        private void btnDonDatThuoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showPnMenu("con", pnMenuGiaoDich);
            //openForm(new FrmDonDatThuoc());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                ibtnCon.IconChar = currentBtn.IconChar;
                ibtnCon.Text = currentBtn.Text;                
            }
        }
        private void showPnMenu(string str, Panel panel)
        {
            if(str == "cha")
            {
                
                if (panel.Visible == true)
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
            if(str == "con")
            {
                ibtnCon.IconChar = currentBtn.IconChar;
                ibtnCon.IconColor = Color.Black;
                ibtnCon.ForeColor = Color.Black;
                panel.Visible = true;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.Show();
        }
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            FrmThongTin thongtin = new FrmThongTin(maNV);
            thongtin.Show();
        }
    }
}

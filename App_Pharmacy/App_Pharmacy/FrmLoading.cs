﻿using System;
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
    public partial class FrmLoading : Form
    {
        Database dt;
        DangNhap dangnhap = new DangNhap();
        string tendangnhap = "", matkhau = "";
        public FrmLoading()
        {
            InitializeComponent();
        }
        public FrmLoading(string tendangnhap, string matkhau)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
        }
        private void FrmLoading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                DataTable dt = dangnhap.KiemTraTaiKhoan(tendangnhap, matkhau);
                int phanloai = int.Parse(dt.Rows[0][2].ToString());
                string maNV = dt.Rows[0][3].ToString();
                int thuoc = int.Parse(dt.Rows[0][4].ToString());
                int nhanvien = int.Parse(dt.Rows[0][5].ToString());
                int khachhang = int.Parse(dt.Rows[0][6].ToString());
                int ncc = int.Parse(dt.Rows[0][7].ToString());
                int hoadon = int.Parse(dt.Rows[0][8].ToString());
                int dondatthuoc = int.Parse(dt.Rows[0][9].ToString());
                timer1.Stop();
                FrmNhaThuoc nhathuoc = new FrmNhaThuoc(tendangnhap, matkhau, phanloai, maNV, thuoc, nhanvien, khachhang, ncc, hoadon, dondatthuoc);
                nhathuoc.Show();
                this.Hide();

            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                label_val.Text = (Convert.ToInt32(label_val.Text) + 1).ToString();
            }
        }
    }
}

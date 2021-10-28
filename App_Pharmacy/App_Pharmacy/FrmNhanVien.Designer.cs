﻿
namespace App_Pharmacy
{
    partial class FrmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.pnTop = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.pnThongTin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtBangCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.txtSDT_NV = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlistview = new System.Windows.Forms.Panel();
            this.pbUpDown = new FontAwesome.Sharp.IconPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lsvDanhSachThongTin = new System.Windows.Forms.ListView();
            this.MA_NHANVIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEN_NHANVIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAY_SINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIOI_TINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT_NV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BANG_CAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.pnTop.SuspendLayout();
            this.pnThongTin.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.pnlistview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.txtTimKiem);
            this.pnTop.Controls.Add(this.btnIn);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.lblTong);
            this.pnTop.CustomBorderColor = System.Drawing.Color.Silver;
            this.pnTop.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.Name = "pnTop";
            this.pnTop.ShadowDecoration.Parent = this.pnTop;
            this.pnTop.Size = new System.Drawing.Size(1361, 75);
            this.pnTop.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 20;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconLeft")));
            this.txtTimKiem.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtTimKiem.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtTimKiem.Location = new System.Drawing.Point(939, 14);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập tên nhân viên cần tìm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(267, 43);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.TextOffset = new System.Drawing.Point(5, 0);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BorderColor = System.Drawing.Color.Gray;
            this.btnIn.BorderThickness = 1;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.FillColor = System.Drawing.Color.Transparent;
            this.btnIn.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageSize = new System.Drawing.Size(14, 14);
            this.btnIn.Location = new System.Drawing.Point(1273, 7);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(50, 50);
            this.btnIn.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân Viên";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTong.Location = new System.Drawing.Point(32, 21);
            this.lblTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(51, 36);
            this.lblTong.TabIndex = 0;
            this.lblTong.Text = "76";
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.guna2GroupBox1);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnThongTin.Location = new System.Drawing.Point(0, 535);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.ShadowDecoration.Parent = this.pnThongTin;
            this.pnThongTin.Size = new System.Drawing.Size(1361, 350);
            this.pnThongTin.TabIndex = 4;
            this.pnThongTin.Visible = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dtNgaySinh);
            this.guna2GroupBox1.Controls.Add(this.button2);
            this.guna2GroupBox1.Controls.Add(this.rbtnNu);
            this.guna2GroupBox1.Controls.Add(this.rbtnNam);
            this.guna2GroupBox1.Controls.Add(this.txtBangCap);
            this.guna2GroupBox1.Controls.Add(this.btnLuu);
            this.guna2GroupBox1.Controls.Add(this.txtMaNV);
            this.guna2GroupBox1.Controls.Add(this.btnHuy);
            this.guna2GroupBox1.Controls.Add(this.txtTenNV);
            this.guna2GroupBox1.Controls.Add(this.btnLamMoi);
            this.guna2GroupBox1.Controls.Add(this.txtSDT_NV);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1361, 350);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "Thông Tin Chi Tiết Nhân Viên";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(529, 157);
            this.dtNgaySinh.MaxDate = new System.DateTime(2021, 10, 27, 0, 0, 0, 0);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(248, 30);
            this.dtNgaySinh.TabIndex = 14;
            this.dtNgaySinh.Value = new System.DateTime(2021, 10, 27, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(412, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ngày Sinh:";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.rbtnNu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNu.ForeColor = System.Drawing.Color.Black;
            this.rbtnNu.Location = new System.Drawing.Point(529, 102);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(55, 27);
            this.rbtnNu.TabIndex = 9;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = false;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.rbtnNam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNam.ForeColor = System.Drawing.Color.Black;
            this.rbtnNam.Location = new System.Drawing.Point(427, 102);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(68, 27);
            this.rbtnNam.TabIndex = 10;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = false;
            // 
            // txtBangCap
            // 
            this.txtBangCap.BorderColor = System.Drawing.Color.Gray;
            this.txtBangCap.BorderRadius = 5;
            this.txtBangCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBangCap.DefaultText = "";
            this.txtBangCap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBangCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBangCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBangCap.DisabledState.Parent = this.txtBangCap;
            this.txtBangCap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBangCap.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtBangCap.FocusedState.Parent = this.txtBangCap;
            this.txtBangCap.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBangCap.ForeColor = System.Drawing.Color.Black;
            this.txtBangCap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBangCap.HoverState.Parent = this.txtBangCap;
            this.txtBangCap.Location = new System.Drawing.Point(412, 222);
            this.txtBangCap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.PasswordChar = '\0';
            this.txtBangCap.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBangCap.PlaceholderText = "Nhập bằng cấp";
            this.txtBangCap.SelectedText = "";
            this.txtBangCap.ShadowDecoration.Parent = this.txtBangCap;
            this.txtBangCap.Size = new System.Drawing.Size(365, 40);
            this.txtBangCap.TabIndex = 5;
            this.txtBangCap.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.BorderThickness = 1;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.Transparent;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnLuu.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Location = new System.Drawing.Point(1060, 92);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(112, 37);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderColor = System.Drawing.Color.Gray;
            this.txtMaNV.BorderRadius = 5;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.Parent = this.txtMaNV;
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtMaNV.FocusedState.Parent = this.txtMaNV;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.HoverState.Parent = this.txtMaNV;
            this.txtMaNV.Location = new System.Drawing.Point(38, 89);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaNV.PlaceholderText = "Nhập mã nhân viên";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.ShadowDecoration.Parent = this.txtMaNV;
            this.txtMaNV.Size = new System.Drawing.Size(334, 40);
            this.txtMaNV.TabIndex = 5;
            this.txtMaNV.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.BorderThickness = 1;
            this.btnHuy.CheckedState.Parent = this.btnHuy;
            this.btnHuy.CustomImages.Parent = this.btnHuy;
            this.btnHuy.FillColor = System.Drawing.Color.Transparent;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnHuy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.HoverState.Parent = this.btnHuy;
            this.btnHuy.Location = new System.Drawing.Point(1060, 152);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.Parent = this.btnHuy;
            this.btnHuy.Size = new System.Drawing.Size(112, 37);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderColor = System.Drawing.Color.Gray;
            this.txtTenNV.BorderRadius = 5;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.Parent = this.txtTenNV;
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTenNV.FocusedState.Parent = this.txtTenNV;
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.HoverState.Parent = this.txtTenNV;
            this.txtTenNV.Location = new System.Drawing.Point(38, 153);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTenNV.PlaceholderText = "Nhập tên nhân viên";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.ShadowDecoration.Parent = this.txtTenNV;
            this.txtTenNV.Size = new System.Drawing.Size(334, 40);
            this.txtTenNV.TabIndex = 5;
            this.txtTenNV.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnLamMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLamMoi.BorderRadius = 5;
            this.btnLamMoi.BorderThickness = 1;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLamMoi.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnLamMoi.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(1060, 225);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(112, 37);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtSDT_NV
            // 
            this.txtSDT_NV.BorderColor = System.Drawing.Color.Gray;
            this.txtSDT_NV.BorderRadius = 5;
            this.txtSDT_NV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT_NV.DefaultText = "";
            this.txtSDT_NV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT_NV.DisabledState.Parent = this.txtSDT_NV;
            this.txtSDT_NV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT_NV.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtSDT_NV.FocusedState.Parent = this.txtSDT_NV;
            this.txtSDT_NV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT_NV.ForeColor = System.Drawing.Color.Black;
            this.txtSDT_NV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT_NV.HoverState.Parent = this.txtSDT_NV;
            this.txtSDT_NV.Location = new System.Drawing.Point(38, 222);
            this.txtSDT_NV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSDT_NV.Name = "txtSDT_NV";
            this.txtSDT_NV.PasswordChar = '\0';
            this.txtSDT_NV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSDT_NV.PlaceholderText = "Nhập SDT nhân viên";
            this.txtSDT_NV.SelectedText = "";
            this.txtSDT_NV.ShadowDecoration.Parent = this.txtSDT_NV;
            this.txtSDT_NV.Size = new System.Drawing.Size(334, 40);
            this.txtSDT_NV.TabIndex = 5;
            this.txtSDT_NV.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // pnlistview
            // 
            this.pnlistview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlistview.Controls.Add(this.pbUpDown);
            this.pnlistview.Controls.Add(this.button1);
            this.pnlistview.Controls.Add(this.lsvDanhSachThongTin);
            this.pnlistview.Controls.Add(this.btnXoa);
            this.pnlistview.Controls.Add(this.btnSua);
            this.pnlistview.Controls.Add(this.btnThem);
            this.pnlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlistview.Location = new System.Drawing.Point(0, 75);
            this.pnlistview.Name = "pnlistview";
            this.pnlistview.Size = new System.Drawing.Size(1361, 460);
            this.pnlistview.TabIndex = 5;
            // 
            // pbUpDown
            // 
            this.pbUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pbUpDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbUpDown.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.pbUpDown.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbUpDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbUpDown.IconSize = 38;
            this.pbUpDown.Location = new System.Drawing.Point(1299, 391);
            this.pbUpDown.Name = "pbUpDown";
            this.pbUpDown.Size = new System.Drawing.Size(40, 38);
            this.pbUpDown.TabIndex = 6;
            this.pbUpDown.TabStop = false;
            this.pbUpDown.Click += new System.EventHandler(this.pbUpDown_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click đúp để xem thông tin chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lsvDanhSachThongTin
            // 
            this.lsvDanhSachThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDanhSachThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lsvDanhSachThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvDanhSachThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MA_NHANVIEN,
            this.TEN_NHANVIEN,
            this.NGAY_SINH,
            this.GIOI_TINH,
            this.SDT_NV,
            this.BANG_CAP});
            this.lsvDanhSachThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSachThongTin.FullRowSelect = true;
            this.lsvDanhSachThongTin.HideSelection = false;
            this.lsvDanhSachThongTin.Location = new System.Drawing.Point(12, 7);
            this.lsvDanhSachThongTin.Name = "lsvDanhSachThongTin";
            this.lsvDanhSachThongTin.Size = new System.Drawing.Size(1337, 359);
            this.lsvDanhSachThongTin.TabIndex = 0;
            this.lsvDanhSachThongTin.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachThongTin.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachThongTin.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachThongTin_SelectedIndexChanged);
            this.lsvDanhSachThongTin.DoubleClick += new System.EventHandler(this.lsvDanhSachThongTin_DoubleClick);
            // 
            // MA_NHANVIEN
            // 
            this.MA_NHANVIEN.Text = "Mã Nhân Viên";
            this.MA_NHANVIEN.Width = 150;
            // 
            // TEN_NHANVIEN
            // 
            this.TEN_NHANVIEN.Text = "Tên Nhân Viên";
            this.TEN_NHANVIEN.Width = 270;
            // 
            // NGAY_SINH
            // 
            this.NGAY_SINH.Text = "Ngày Sinh";
            this.NGAY_SINH.Width = 150;
            // 
            // GIOI_TINH
            // 
            this.GIOI_TINH.Text = "Giới Tính";
            this.GIOI_TINH.Width = 150;
            // 
            // SDT_NV
            // 
            this.SDT_NV.Text = "SDT Nhân Viên";
            this.SDT_NV.Width = 150;
            // 
            // BANG_CAP
            // 
            this.BANG_CAP.Text = "Bằng Cấp";
            this.BANG_CAP.Width = 150;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(1180, 392);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(112, 37);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.BorderRadius = 5;
            this.btnSua.BorderThickness = 1;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnSua.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(1060, 392);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(112, 37);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.BorderRadius = 5;
            this.btnThem.BorderThickness = 1;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnThem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(939, 392);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(112, 37);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 885);
            this.Controls.Add(this.pnlistview);
            this.Controls.Add(this.pnThongTin);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnThongTin.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.pnlistview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnTop;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTong;
        private Guna.UI2.WinForms.Guna2Panel pnThongTin;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBangCap;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT_NV;
        private System.Windows.Forms.Panel pnlistview;
        private FontAwesome.Sharp.IconPictureBox pbUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lsvDanhSachThongTin;
        private System.Windows.Forms.ColumnHeader MA_NHANVIEN;
        private System.Windows.Forms.ColumnHeader TEN_NHANVIEN;
        private System.Windows.Forms.ColumnHeader NGAY_SINH;
        private System.Windows.Forms.ColumnHeader GIOI_TINH;
        private System.Windows.Forms.ColumnHeader SDT_NV;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.ColumnHeader BANG_CAP;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
    }
}
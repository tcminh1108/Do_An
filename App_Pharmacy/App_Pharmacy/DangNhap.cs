﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//them 2 thu vien
using System.Data;
using System.Data.SqlClient;

namespace App_Pharmacy
{
    class DangNhap
    {
        Database db;
        //khởi tạo database
        public DangNhap()
        {
            db = new Database();
        }
        public DataTable KiemTraTaiKhoan(string taikhoan, string matkhau)
        {
            string strSQL = @"Select * From DANGNHAP Where USERNAME = '" + taikhoan + "' And MATKHAU = '" + matkhau + "'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
    }
}

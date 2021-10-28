using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//them 2 thu vien
using System.Data;
using System.Data.SqlClient;

namespace App_Pharmacy
{
    class NhanVien
    {
        Database db;
        public NhanVien()
        {
            db = new Database();
        }
        public DataTable LayDSNhanVien()
        {
            string strSQL = @"Select * From NHANVIEN";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public void CapNhatTaiKhoan(string username)
        {
            string manvSua = "None";
            //Cap nhat du lieu
            string str = @"update DANGNHAP set MA_NHANVIEN = '"+ manvSua +"' where(USERNAME = '" + username + "')";
            db.ExecuteNonQuery(str);
        }
        public void XoaNhanVien(string manv)
        {
            string sql = @"delete from NHANVIEN where(MA_NHANVIEN = '" + manv + "')";
            db.ExecuteNonQuery(sql);
        }
        public void ThemNhanVien(string manv, string tennv, string ngaysinh, string gioitinh, string sdt, string bangcap)
        {
            string sql = string.Format("Insert Into NHANVIEN Values('{0}',N'{1}','{2}',N'{3}','{4}',N'{5}')", manv, tennv, ngaysinh, gioitinh, sdt, bangcap);
            db.ExecuteNonQuery(sql);
        }
        public void ThemTaiKhoan(string username, string pass, string manv)
        {
            string sql = string.Format("Insert into DANGNHAP Values('{0}','{1}',{2},'{3}',{4},{5},{6},{7},{8},{9})", username, pass, 2, manv,1,1,1,1,1,1);
            db.ExecuteNonQuery(sql);
        }

        public void CapNhatNhanVien(string manv, string tennv, string ngaysinh, string gioitinh, string sdt, string bangcap)
        {
            //Cap nhat du lieu
            string str = @"update NHANVIEN set MA_NHANVIEN = '" + manv + "', TEN_NHANVIEN = N'" + tennv + "', NV_NGAY_SINH = '" + ngaysinh + "', GIOI_TINH = N'" + gioitinh + "', SDT_NHANVIEN = '" + sdt + "', BANG_CAP = '" + bangcap + "' where(MA_NHANVIEN = '" + manv + "')";
            db.ExecuteNonQuery(str);
        }
        public DataTable TimKiemTen(string timkiem)
        {
            string strSQL = "Select * From NHANVIEN where TEN_NHANVIEN Like N'" + timkiem + "'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }
    }
    
}

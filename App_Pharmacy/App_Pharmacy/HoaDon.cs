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
    class HoaDon
    {
        Database db;
        public HoaDon()
        {
            db = new Database();
        }
        public DataTable LayDSThuocTrongHD(string mahd)
        {
            string strSQL = "Select T.TEN_THUOC, CT.SO_LUONG, T.GIA_BAN, CT.TONG_TIEN From THUOC T, CT_HOADON CT Where T.MA_THUOC = CT.MA_THUOC and CT.MA_HOADON = '"+ mahd +"'";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu 
            return dt;
        }
        public DataTable LayNhanVien()
        {
            string strSQL = "Select * from NHANVIEN";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayKhachHang()
        {
            string strSQL = "Select * from KHACHHANG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayThuoc()
        {
            string strSQL = "Select * from THUOC";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        //Thêm 1 hóa đơn mới
        public void ThemHoaDon(string mahd, string makh, string manv, string ngaylap, string mathuoc, string soluong, string thanhtien )
        {

            string sql1 = string.Format("Insert Into HOADON Values('{0}','{1}',N'{2}','{3}')", mahd, makh, manv, ngaylap );
            db.ExecuteNonQuery(sql1);
            string sql2 = string.Format("Insert Into CT_HOADON Values('{0}','{1}',N'{2}','{3}')", mahd, mathuoc, soluong, thanhtien);
            db.ExecuteNonQuery(sql2);
        }
    }
}

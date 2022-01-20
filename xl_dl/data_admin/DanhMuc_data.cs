using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_ban_hang.xl_dl.data_DanhMuc
{
    public class DanhMuc_data
    {
        xl_chung dungchung = new xl_chung();
        public DataTable load_danhMuc()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.danhmuc";
           tb= dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable load_so_lop()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT danhmuc.madanhmuc,COUNT(masp) AS sosp FROM dbo.danhmuc left JOIN dbo.sanpham ON sanpham.madanhmuc = danhmuc.madanhmuc GROUP BY danhmuc.madanhmuc";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable load_so_lop_tk(string madanhmuc)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT danhmuc.madanhmuc,COUNT(masp) AS sosp FROM dbo.danhmuc left JOIN dbo.sanpham ON sanpham.madanhmuc = danhmuc.madanhmuc WHERE danhmuc.madanhmuc = '"+madanhmuc+"' GROUP BY danhmuc.madanhmuc";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable timkiem_danhMuc(string madanhmuc)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.danhmuc WHERE madanhmuc='"+madanhmuc+"'";
            tb=dungchung.load_dulieu(sql);
            return tb;
        }
        public int them_danhMuc(string madanhmuc,string tendanhmuc)
        {
            
            string sql_test = "SELECT COUNT(*) FROM dbo.danhmuc WHERE madanhmuc='"+madanhmuc+"'";
           if (dungchung.dangnhap(sql_test) <= 0)
            {
                string sql = "INSERT dbo.danhmuc VALUES('" + madanhmuc + "',N'" + tendanhmuc + "')";
               int a= dungchung.them_sua_xoa(sql);
                if (a > 0)
                    return 0;
                else return 1;
            }
            else
               return 1;
        }
        public int sua_danhMuc(string madanhmuc,string tendanhmuc)
        {
            // kiểm tra Mã HS Có trong DS hay Không
            string sql_test = "SELECT COUNT(*) FROM dbo.danhmuc WHERE madanhmuc='" + madanhmuc + "'";
            if (dungchung.dangnhap(sql_test) > 0)
            {
                string sql = "UPDATE dbo.danhmuc SET tendanhmuc=N'" + tendanhmuc + "' WHERE madanhmuc='" + madanhmuc + "'";
                int a=dungchung.them_sua_xoa(sql);
                if (a > 0)
                    return 0;
                else return 1;
            }
            else
                return 1;
        }
        public int xoa_danhMuc(string madanhmuc)
        {
                string sql = "DELETE dbo.danhmuc WHERE madanhmuc='"+madanhmuc+"'";
               int a= dungchung.them_sua_xoa(sql);
            if (a > 0)
            {
                return 0;
            }
            else
                return 1;
        }
    }
}
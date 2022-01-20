using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_ban_hang.xl_dl.data_Home
{

    public class san_pham
    {
        xl_dl.xl_chung dungchung = new xl_dl.xl_chung();
        public DataTable home_load_sp()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.sanpham";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable tim_kiem_theo_maDanhMuc (string madanhmuc)
        {
            string sql = "SELECT * FROM dbo.sanpham WHERE madanhmuc='" + madanhmuc + "'";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable tim_kiem_theo_tenDanhMuc(string tendanhmuc)
        {
            string sql = "SELECT * FROM dbo.sanpham WHERE tensp LIKE '%"+tendanhmuc+"%'";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable gia_thap_cao()
        {
            string sql = "SELECT * FROM dbo.sanpham  ORDER BY dongia ASC";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable gia_cao_thap()
        {
            string sql = "SELECT * FROM dbo.sanpham  ORDER BY dongia DESC";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable tim_sp(string masp)
        {
            string sql = "SELECT * FROM dbo.sanpham WHERE masp='"+masp.Trim()+"'";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
    }
}
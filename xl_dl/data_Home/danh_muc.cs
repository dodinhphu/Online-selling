using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_ban_hang.xl_dl.data_Home
{
    public class danh_muc
    {
        xl_dl.xl_chung dungchung = new xl_dl.xl_chung();

        public DataTable load_danh_muc()
        {
            string sql = "SELECT * FROM dbo.danhmuc";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable load_tung_danh_muc(string madanhmuc)
        {
            string sql = " SELECT * FROM dbo.sanpham WHERE masp='"+madanhmuc.Trim()+"' ";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }    
    }
}
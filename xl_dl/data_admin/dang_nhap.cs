using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_ban_hang.xl_dl.data_DanhMuc
{
    public class dang_nhap
    {
        xl_chung dungchung = new xl_chung();
        public DataTable kt_dangnhap(string taikhoan,string matkhau)
        {
            DataTable tb = new DataTable();
            string sql = " SELECT * FROM dbo.taikhoan WHERE taikhoan='" + taikhoan + "' AND matkhau='" + matkhau + "'";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
    }
}
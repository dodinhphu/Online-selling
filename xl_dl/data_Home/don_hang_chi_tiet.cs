using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_ban_hang.xl_dl.data_Home
{
    public class don_hang_chi_tiet
    {
        xl_dl.xl_chung dungchung = new xl_dl.xl_chung();
        public void them_hoa_don_chi_tiet(string mahoadon,string masp,string soluong,string dongia,string tinhtrang)
        {
            string sql = " INSERT dbo.don_hang_chi_tiet VALUES("+int.Parse(mahoadon.Trim())+" , '"+masp.Trim()+"'  ,"+int.Parse(soluong)+","+int.Parse(dongia.Trim())+", N'"+tinhtrang.Trim()+"') ";
            dungchung.them_sua_xoa(sql);
        }
        public DataTable load_hoa_don_chi_tiet(string mahoadon)
        {
            string sql = "SELECT * FROM dbo.don_hang_chi_tiet  WHERE mahoadon=" + int.Parse(mahoadon.Trim()) +" ";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
    }
}
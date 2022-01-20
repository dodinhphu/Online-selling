using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_ban_hang.xl_dl.data_Home
{
    public class donhang
    {
        xl_dl.xl_chung dungchung = new xl_dl.xl_chung();
        public int them_don_hang(string makhachhang, string ngaytao, string thanhtien, string tenkhachhang, string sdt_kh, string email_kh )
        {
            string sql = " INSERT dbo.donhang VALUES ('"+makhachhang.Trim()+ "',  CONVERT(DATE,'" + ngaytao + "',103), "+int.Parse(thanhtien.Trim())+",  N'"+tenkhachhang.Trim()+"', '"+sdt_kh.Trim()+"', '"+email_kh.Trim()+"' )";
            int a = dungchung.them_sua_xoa(sql);
            if (a > 0)
                return 0;
            else
                return 1;
        }
        public DataTable lay_don_moi_nhat()
        {
            string sql = "SELECT * FROM dbo.donhang  ORDER BY mahoadon DESC";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable lay_tat_ca_hoa_don()
        {
            string sql = "SELECT * FROM dbo.donhang";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
    }
}
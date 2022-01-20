using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_ban_hang.xl_dl.data_Home
{
    public class user
    {
        xl_dl.xl_chung dungchung = new xl_dl.xl_chung();

        public object Response { get; internal set; }

        public int them_user(string taikhoan,string matkhau,string hovaten,string diachi,string email,string sodienthoai ,string ngaysinh)
        {
            string sql_test = "	SELECT  COUNT(*)  FROM dbo.khachhang WHERE taikhoan='" + taikhoan.Trim()+"'";
            if(dungchung.dangnhap(sql_test)<=0)
            {
                string sql = " INSERT dbo.khachhang VALUES ('"+taikhoan+"','"+matkhau+"',N'"+hovaten+"',N'"+diachi+"','"+email+"',"+int.Parse(sodienthoai)+ ", CONVERT(DATE,'" + ngaysinh + "',103)) ";
                int a = dungchung.them_sua_xoa(sql);
                if (a > 0)
                    return 0;
                else return 1;
            }
            return 1;
        }
        public int sua_user(string taikhoan, string matkhau, string hovaten, string diachi, string email, string sodienthoai, string ngaysinh)
        {
            string sql_test = "	SELECT  COUNT(*)  FROM dbo.khachhang WHERE taikhoan='" + taikhoan.Trim() + "'";
            if (dungchung.dangnhap(sql_test) > 0)
            {
                string sql = " UPDATE dbo.khachhang SET matkhau='"+matkhau+"',hovaten=N'"+hovaten+"',diachi=N'"+diachi+"',email='"+email+"',sodienthoai="+int.Parse(sodienthoai)+ ",ngaysinh=CONVERT(DATE,'" + ngaysinh + "',103) WHERE taikhoan='"+taikhoan+"' ";
                int a = dungchung.them_sua_xoa(sql);
                if (a > 0)
                    return 0;
                else return 1;
            }
            return 1;
        }
        public int kt_user_dang_nhap(string taikhoan,string matkhau)
        {
            string sql = " SELECT COUNT(*) FROM dbo.khachhang WHERE taikhoan='"+taikhoan.Trim()+"' AND matkhau='"+matkhau.Trim()+"' ";
            int a = dungchung.dangnhap(sql);
            if (a > 0)
                return 0;
            else
                return 1;
        }
        public DataTable timkiem_use(string taikhoan)
        {
            DataTable tb = new DataTable();
            string sql = " SELECT * FROM dbo.khachhang WHERE taikhoan='" + taikhoan.Trim() + "'";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
    }
}
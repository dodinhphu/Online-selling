using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace web_ban_hang.xl_dl.data_DanhMuc
{
    public class SanPham_data
    {
        xl_chung dungchung = new xl_chung();
        public DataTable load_sp()
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.sanpham";
            tb=dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable load_sp_tk(string masp)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.sanpham WHERE masp='" + masp + "'";
            tb = dungchung.load_dulieu(sql);
            return tb;
        }
        public DataTable tim_kiem_sp(string masp)
        {
            DataTable tb = new DataTable();
            string sql = "SELECT * FROM dbo.sanpham WHERE masp='" + masp + "'";
            tb = dungchung.load_dulieu(sql);
            return tb;
            
        }
        public int them_sp(string masp,string tensp,string dongia,string soluong,string madanhmuc,string diachishop,string thuonghieu,string tenanh,string ngaythem,string mota)
        {
            string sql_kt = "SELECT COUNT(*) FROM dbo.sanpham WHERE masp='"+masp+"'";
            if (dungchung.dangnhap(sql_kt) <= 0)
            {
                string sql = "INSERT dbo.sanpham VALUES ('" + masp + "',N'" + tensp + "'," + int.Parse(dongia) + "," + int.Parse(soluong) + ",'" + madanhmuc + "',N'" + diachishop + "',N'" + thuonghieu + "','"+tenanh+"',CONVERT(DATE,'" + ngaythem + "',103), N'" + mota + "')";
                int a = dungchung.them_sua_xoa(sql);
                if (a > 0)
                    return 0;
                else return 1;
            }
            else return 1;
        }
        public int sua_sp(string masp, string tensp, string dongia, string soluong, string madanhmuc, string diachishop, string thuonghieu, string tenanh, string ngaythem, string mota)
        {
            string sql_kt = "SELECT COUNT(*) FROM dbo.sanpham WHERE masp='" + masp + "'";
            if (dungchung.dangnhap(sql_kt) > 0)
            {
                string sql = "UPDATE dbo.sanpham SET tensp=N'"+tensp+"', dongia="+int.Parse(dongia)+" ,soluong="+int.Parse(soluong)+" ,madanhmuc='"+madanhmuc+"', diachishop=N'"+diachishop+"', thuonghieu=N'"+thuonghieu+"', tenanh=N'"+tenanh+ "',ngaythem=CONVERT(DATE,'" + ngaythem + "',103),mota=N'"+mota+"' WHERE masp='"+masp+"'";
                int a = dungchung.them_sua_xoa(sql); 
                if (a > 0)
                    return 0;
                else return 1;
            }
            else return 1;
        }
        public int  xoa_sanpham(string masp)
        {
            string sql = "DELETE dbo.sanpham WHERE masp='"+masp+"'";
            int a=dungchung.them_sua_xoa(sql);
            if (a > 0)
                return 0;
            else return 1;
        }
    }
}
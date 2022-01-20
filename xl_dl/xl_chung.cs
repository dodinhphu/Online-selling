using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Windows;
using System.IO;

namespace web_ban_hang.xl_dl
{
    public class xl_chung
    {

        string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+@"D:\File ASP\web_ban_hang_NHOM_Do_Dinh_Phu\web_ban_hang\App_Data\Database1.mdf"+@";Integrated Security=True";
        public SqlConnection con;

        public xl_chung()
        {
            con = new SqlConnection(chuoikn);
        }
        public int them_sua_xoa(string sql)
        {
            SqlCommand coman = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)coman.ExecuteNonQuery();
            con.Close();
            return kq;
        }
        public int dangnhap(string sql)
        {
            SqlCommand coman = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)coman.ExecuteScalar();
            con.Close();
            return kq;
        }
        public DataTable load_dulieu(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
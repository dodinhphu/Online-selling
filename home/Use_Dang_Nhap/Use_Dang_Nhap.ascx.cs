using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace web_ban_hang.home.Use_Dang_Nhap
{
    public partial class Use_Dang_Nhap : System.Web.UI.UserControl
    {
        xl_dl.data_Home.user data_user = new xl_dl.data_Home.user();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_dangnhap_Click(object sender, EventArgs e)
        {
            int a = data_user.kt_user_dang_nhap(txt_tk.Text.Trim(), txt_mk.Text.Trim());
            if(a==0)
            {
                DataTable tb = new DataTable();
                tb = data_user.timkiem_use(txt_tk.Text.Trim());
                Session["kt_dang_nhap_user"] = "true";
                Session["tk_use"] = tb.Rows[0]["taikhoan"].ToString().Trim();
                Session["tenkhachhang"] = tb.Rows[0]["hovaten"].ToString().Trim();
                Session["diachi"] = tb.Rows[0]["diachi"].ToString().Trim();
                Session["email"] = tb.Rows[0]["email"].ToString().Trim();
                Session["sodienthoai"] = tb.Rows[0]["sodienthoai"].ToString().Trim();
                Session["ngaysinh"] = tb.Rows[0]["ngaysinh"].ToString().Trim();
                Response.Redirect("Home.aspx");

            }  
            else
            {
                lb_tb.Text = "Sai Tài Khoản Hoặc Mật Khẩu";
                lb_tb.CssClass = "that_bai";
                Session["kt_dang_nhap_user"] = "false";
            }    
        }

        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
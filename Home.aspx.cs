using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_ban_hang
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //tắt slide khi vào trang chi tiết sp
            if (Request.QueryString["modul"] != null && Request.QueryString["modul"] == "chitietsp")
            {
                plhd_slide.Visible = false;
            }

            //tắt slide khi vào trang chi tiết sp
            if (Request.QueryString["modul"] != null && Request.QueryString["modul"] == "giohang")
            {
                plhd_slide.Visible = false;
            }
            // 
            if (Session["kt_dang_nhap_user"]!=null && Session["kt_dang_nhap_user"].ToString().Trim()=="true")
            {
               plhd_dang_ky.Visible = false;
                plhd_dang_nhap.Visible = false;
                list_ten_user.Text = Session["tk_use"].ToString().Trim();
            }  
            else
            {
                plhd_Dang_xuat_ten_use.Visible = false;
            }
            if(!IsPostBack)
            {

            }    
        }

        protected void btn_dangxuat_onclick(object sender, EventArgs e)
        {
            Session["kt_dang_nhap_user"] = "false";
            Session["tk_use"] = null;
            Session["tenkhachhang"] = null;
            Session["diachi"] = null;
            Session["email"] = null;
            Session["sodienthoai"] = null;
            Session["ngaysinh"] = null;
            Response.Redirect("Home.aspx");
        }
     
        protected void btn_tim_kiem_sp_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx?modul=load_danh_muc&modulphu=timkiemsanpham&tensp=" + txt_ten_sp_timkiem.Text.Trim());
               
        }
    }
}
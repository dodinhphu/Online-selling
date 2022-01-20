using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_ban_hang
{
    public partial class Admin_ : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //kiểm tra tài khoản
            if (Session["check_dangnhap"] !=null )
            {
                if (Session["check_dangnhap"].ToString().Trim() == "1" )
                {
                    //đăng nhập thành công.
                }
                else
                {
                        Response.Redirect("/Login.aspx");
                }    
            }
            else
            {
                Response.Redirect("/Login.aspx");
            }    
            if(!IsPostBack)
            {
                list_hienThiTenTKDangNhap.Text = Session["tendangnhap"].ToString().Trim();
            }    
        }

        protected void btn_dangXuat_Click(object sender, EventArgs e)
        {
            // xóa các sesson
            Session["check_dangnhap"] = null;
            Session["tendangnhap"] = null;
            //dẩy về trang login
            Response.Redirect("/Login.aspx");
        }
    }
}
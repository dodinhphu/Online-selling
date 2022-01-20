using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_ban_hang.home.Gio_hang
{
    public partial class Gio_hang : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["kt_dang_nhap_user"] == null || Session["kt_dang_nhap_user"].ToString().Trim()!="true")
            {
                Response.Redirect("Home.aspx?modul=usedangnhap");
            }
         
        }

        protected void btn_tt_mua_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
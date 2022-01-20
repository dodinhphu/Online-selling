using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_ban_hang.home
{
    public partial class Home_Dieu_huong : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // kt load
            string modul = "";
            if (Request.QueryString["modul"] != null)
            {
                modul = Request.QueryString["modul"];
            }
            //load đến contron
            switch (modul)
            {
                case "giohang":
                    Home_dieu_huong.Controls.Add(LoadControl("Gio_hang/Gio_hang.ascx"));
                    break;
                case "usedangky":
                    Home_dieu_huong.Controls.Add(LoadControl("Use_Dang_Ky/Use_dang_Ky.ascx"));
                    break;
                case "usedangnhap":
                    Home_dieu_huong.Controls.Add(LoadControl("Use_Dang_Nhap/Use_Dang_Nhap.ascx"));
                    break;
                case "loaddanhmuc":
                    Home_dieu_huong.Controls.Add(LoadControl("load_danh_muc/Load_danh_muc.ascx"));
                    break;
                case "chitietsp":
                    Home_dieu_huong.Controls.Add(LoadControl("Chi_tiet_SP/chi_tiet_sp.ascx"));
                    break;
                default:
                    Home_dieu_huong.Controls.Add(LoadControl("load_danh_muc/Load_danh_muc.ascx"));
                    break;

            }
        }
    }
}
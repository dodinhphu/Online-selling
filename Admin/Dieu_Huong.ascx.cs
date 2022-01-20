using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_ban_hang.Admin
{
    public partial class Dieu_Huong : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // kt load
            string modul = "";
            if(Request.QueryString["modul"] !=null)
            {
                modul = Request.QueryString["modul"];
            }    
            //load đến contron
            switch (modul)
            {
                case "tatcasp":
                     Dieu_huong.Controls.Add(LoadControl("Contro_SP/Contro_All_SP.ascx"));
                    break;
                case "themsp":
                    Dieu_huong.Controls.Add(LoadControl("Contro_SP/them_sua_sp.ascx"));
                    break;
                case "suasp":
                    Dieu_huong.Controls.Add(LoadControl("Contro_SP/them_sua_sp.ascx"));
                    break;
                case "xoasp":
                    Dieu_huong.Controls.Add(LoadControl("Contro_SP/xoa_sp.ascx"));
                    break;
                    // danh muc 
                case "tatcadanhmuc":
                    Dieu_huong.Controls.Add(LoadControl("Contro_DanhMuc/all_danh_muc.ascx"));
                    break;
                case "xoadanhmuc":
                    Dieu_huong.Controls.Add(LoadControl("Contro_DanhMuc/xoa_danhMuc.ascx"));
                    break;
                case "themdanhmuc":
                    Dieu_huong.Controls.Add(LoadControl("Contro_DanhMuc/them_sua_danhmuc.ascx"));
                    break;
                case "suadanhmuc":
                    Dieu_huong.Controls.Add(LoadControl("Contro_DanhMuc/them_sua_danhmuc.ascx"));
                    break;
                case "hoadon":
                    Dieu_huong.Controls.Add(LoadControl("conTro_HoaDon/Hoa_don.ascx"));
                    break;
                case "hoa_don_chi_tiet":
                    Dieu_huong.Controls.Add(LoadControl("conTro_HoaDon/hoa_don_chi_tiet.ascx"));
                    break;
                default:
                    Dieu_huong.Controls.Add(LoadControl("Contro_SP/Contro_All_SP.ascx"));
                    break;

            }
           
        }
    }
}
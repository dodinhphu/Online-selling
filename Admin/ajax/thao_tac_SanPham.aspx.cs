using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web_ban_hang.Admin.ajax
{
    public partial class thao_tac_SanPham : System.Web.UI.Page
    {
        private string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //kiểm tra tài khoản
            if (Session["check_dangnhap"] != null)
            {
                if (Session["check_dangnhap"].ToString().Trim() == "1")
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
            // thực hiện code
            if (Request.Params["thaotac"] != null)
            {
                thaotac = Request.Params["thaotac"];
            }
            switch (thaotac)
            {
                case "xoasanpham":
                    xoasanpham();
                    break;
            }

        }
        private void xoasanpham()
        {
            string ma = "";
            if (Request.Params["ma"] != null)
            {
                ma = Request.Params["ma"];
            }
            xl_dl.data_DanhMuc.SanPham_data data_sp = new xl_dl.data_DanhMuc.SanPham_data();
            int a=data_sp.xoa_sanpham(ma);
            if(a==0)
            {
                Response.Write("1");
            }    
            else
            {
                Response.Write("0");
            }    
           
        }
    }
}
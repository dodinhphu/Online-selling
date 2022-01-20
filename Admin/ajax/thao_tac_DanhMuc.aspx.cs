using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace web_ban_hang.Admin.ajax
{
    public partial class thao_tac_DanhMuc : System.Web.UI.Page
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
                case "xoadanhmuc":
                     xoadanhmuc();
                      break;
            }
      
        }
        private void xoadanhmuc()
        {
            string ma = "";
            if (Request.Params["ma"] != null)
            {
                ma = Request.Params["ma"];
            }
            xl_dl.data_DanhMuc.DanhMuc_data data_danhmuc = new xl_dl.data_DanhMuc.DanhMuc_data();

            DataTable tb = new DataTable();
            tb=data_danhmuc.load_so_lop_tk(ma);
        
            if (tb.Rows[0]["sosp"].ToString().Trim()=="0")
            {
                data_danhmuc.xoa_danhMuc(ma);
                Response.Write("1");
            }  
            else
            {
                Response.Write("0");
            }    
           
        }

    }
}
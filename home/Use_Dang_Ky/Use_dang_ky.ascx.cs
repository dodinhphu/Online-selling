using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_ban_hang.home.Use_Dang_Ky
{
    public partial class Use_dang_ky : System.Web.UI.UserControl
    {
        xl_dl.data_Home.user data_user = new xl_dl.data_Home.user();
        string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(Request.QueryString["modulphu"]!=null)
            {
                modulphu = Request.QueryString["modulphu"].ToString().Trim();
            }    
            if(modulphu == "chinhsuauser")
            {
                list_tieu_de.Text = "Chỉnh Sửa Tài Khoản";
                Txt_tao_user.Text = "Sửa";
            }
            else
            {
                list_tieu_de.Text = "Tạo Tài Khoản";
                Txt_tao_user.Text = "Tạo";
            }
        }

        protected void Txt_tao_user_Click(object sender, EventArgs e)
        {
            if(modulphu== "chinhsuauser")
            {
             
                int a = data_user.sua_user(txt_userName.Text.Trim(), txt_passwword.Text.Trim(), txt_hoten.Text.Trim(), txt_diachi.Text.Trim(), txt_mail.Text.Trim(), txt_sdt.Text.Trim(), txt_ngaysinh.Text);
                if (a == 0)
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
                else
                {
                    tb.Text = "Không Tồn Tại Tài Khoản Này";
                    tb.CssClass = "that_bai";
                    txt_userName.Text = "";
                    txt_passwword.Text = "";
                }
            }
            else
            {
               
                int a = data_user.them_user(txt_userName.Text.Trim(), txt_passwword.Text.Trim(), txt_hoten.Text.Trim(), txt_diachi.Text.Trim(), txt_mail.Text.Trim(), txt_sdt.Text.Trim(), txt_ngaysinh.Text);
                if (a == 0)
                {
                    Response.Redirect("Home.aspx?modul=usedangnhap");
                }
                else
                {
                    tb.Text = "Đã Tồn Tại Tài Khoản Này";
                    tb.CssClass = "that_bai";
                    txt_userName.Text = "";
                    txt_passwword.Text = "";
                }
            }
         

        }

        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
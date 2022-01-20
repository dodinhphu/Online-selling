using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web_ban_hang
{
    public partial class Login : System.Web.UI.Page
    {
        xl_dl.data_DanhMuc.dang_nhap data_dangnhap = new xl_dl.data_DanhMuc.dang_nhap();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_dangnhap_Click(object sender, EventArgs e)
        {         
            DataTable tb = new DataTable();
           tb= data_dangnhap.kt_dangnhap(txt_tendangnhap.Text.Trim(), txt_matkhau.Text.Trim());
            if(tb.Rows.Count>0)
            {
                //đăng nhập thành công thì lưu giá trị vào sesson .sesson là biết tồn tại trong toàn bộ web
                Session["check_dangnhap"] = "1";//gán bằng 1 để thể hiện đăng nhập thàng công
                //gán thêm thông tin tk đã đăng nhập
                Session["tendangnhap"] = tb.Rows[0]["taikhoan"].ToString().Trim();
                // kiểm tra nếu bằng 1 thì cho phép vào trang quảng trị,nếu có tk mà kt ko bằng 1 thì cho về trang chủ
                if (Session["check_dangnhap"].ToString().Trim() == "1")
                {
                    Response.Redirect("/Admin_.aspx");
                }
                else
                {
                    Response.Redirect("/Login.aspx");
                }  
                   
            }    
            // ko tk k đúng thì  không cho vào
            else
            {
                list_tb.Text = " <asp:Label class='thongbao_dangnhap' runat='server' Text='Label'>Sai Tài Khoản Hoặc Mật Khẩu</asp:Label>";
            }    
        }
    }
}
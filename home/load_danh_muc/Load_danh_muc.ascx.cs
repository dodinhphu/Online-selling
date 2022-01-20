using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web_ban_hang.home.load_danh_muc
{
    public partial class Load_damh_muc : System.Web.UI.UserControl
    {
        xl_dl.data_Home.danh_muc data_danhmuc = new xl_dl.data_Home.danh_muc();
        protected void Page_Load(object sender, EventArgs e)
        {
            // load danh muc
            DataTable tb = new DataTable();
            tb = data_danhmuc.load_danh_muc();
            for(int i=0;i<tb.Rows.Count;i++)
            {
                list_load_danh_muc_home.Text += @" <li class='item_danh_muc'>
                                     <a href = 'Home.aspx?modul=load_danh_muc&modulphu=theotungdanhmuc&madanhmuc="+ tb.Rows[i]["madanhmuc"].ToString().Trim() + "'   class='link_item'>"+tb.Rows[i]["tendanhmuc"].ToString().Trim() + @"</a>
                                </li>";
            }    
            // điều hướng modul phụ
            string modulphu = "";
            if (Request.QueryString["modulphu"] != null)
            {
                modulphu = Request.QueryString["modulphu"];
            }
            switch (modulphu)
            {
                case "tatcadanhmuc":
                    dieu_huong_danhmuc.Controls.Add(LoadControl("all_sp/all_sp.ascx"));
                    break;
                case "theotungdanhmuc":
                    dieu_huong_danhmuc.Controls.Add(LoadControl("sp_theo_tung_muc/tung_danh_muc.ascx"));
                    break;
                case "timkiemsanpham":
                    dieu_huong_danhmuc.Controls.Add(LoadControl("tim_kiem/Tim_kiem_tenSP_gan_dung.ascx"));
                    break;
                case "gia_thap-cao":
                    dieu_huong_danhmuc.Controls.Add(LoadControl("tk_gia_thap-cao/gia_thap-cao.ascx"));
                    break;
                case "gia_cao-thap":
                    dieu_huong_danhmuc.Controls.Add(LoadControl("tk_gia_cao-thap/gia_cao-thap.ascx"));
                    break;
                default:
                    dieu_huong_danhmuc.Controls.Add(LoadControl("all_sp/all_sp.ascx"));
                    break;
                  
            }
        }
    }
}
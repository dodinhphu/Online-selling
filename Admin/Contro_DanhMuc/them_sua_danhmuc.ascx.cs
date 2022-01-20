using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace web_ban_hang.Admin.Contro_DanhMuc
{
    public partial class them_sua_danhmuc : System.Web.UI.UserControl
    {
        xl_dl.data_DanhMuc.DanhMuc_data data_danhmuc = new xl_dl.data_DanhMuc.DanhMuc_data();
        protected void Page_Load(object sender, EventArgs e)
        {   
            if(laymodul()== "themdanhmuc")
            {
                btn_themDanhMuc.Text = "Thêm Mới";
                h2_txt_tensp.InnerText = "Thêm Mới Danh Mục";
            }    
            else
            {
                btn_themDanhMuc.Text = "Sửa";
                h2_txt_tensp.InnerText = "Sửa Danh Mục";
                hienthi_tt_dm_sua();
            }    
        }
        public string laymodul()
        {
            if (Request.QueryString["modul"] != null)
            {
                return  Request.QueryString["modul"].ToString();
            }
            return null;
        }
        public string laymodulphu()
        {
            if (Request.QueryString["madm"] != null)
            {
                return Request.QueryString["madm"].ToString();
            }
            return null;
        }
        public void hienthi_tt_dm_sua()
        {
            DataTable tb = new DataTable();
           tb= data_danhmuc.timkiem_danhMuc(laymodulphu());
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txt_madanhmuc.Text = tb.Rows[i]["madanhmuc"].ToString().Trim();
                    txt_tendanhmuc.Text = tb.Rows[i]["tendanhmuc"].ToString().Trim();
                }
            }
        }
        protected void btn_themDanhMuc_Click(object sender, EventArgs e)
        {
            if(laymodul() == "themdanhmuc")
            {
                int a = data_danhmuc.them_danhMuc(txt_madanhmuc.Text.ToString().Trim(), txt_tendanhmuc.Text.ToString().Trim());
                if (a == 0)
                {
                    lb_tb.CssClass = "thanh_cong";
                    lb_tb.Text = "Thêm Thành Công Danh Mục : "+txt_madanhmuc.Text;
                    txt_madanhmuc.Text = "";
                    txt_tendanhmuc.Text = "";
                }
                else
                {
                    lb_tb.CssClass = "that_bai";
                    lb_tb.Text = "Thêm Thất Bại";
                }
            }    
            else
            {
                int a = data_danhmuc.sua_danhMuc(txt_madanhmuc.Text.ToString().Trim(), txt_tendanhmuc.Text.ToString().Trim());
                if (a == 0)
                {
                    lb_tb.CssClass = "thanh_cong";
                    lb_tb.Text = "Sửa Thành Công Danh Mục: "+txt_madanhmuc.Text;
                    txt_madanhmuc.Text = "";
                    txt_tendanhmuc.Text = "";
                }
                else
                {
                    lb_tb.CssClass = "that_bai";
                    lb_tb.Text = "Sửa Thất Bại";
                }
            }    
          
        }

        protected void btn_huyDanhMuc_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_.aspx?modul=tatcadanhmuc");
        }
    }
}
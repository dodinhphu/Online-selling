using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web_ban_hang.Admin.Contro_DanhMuc
{
    public partial class xoa_danhMuc : System.Web.UI.UserControl
    {
        xl_dl.data_DanhMuc.DanhMuc_data data_danhmuc = new xl_dl.data_DanhMuc.DanhMuc_data();
     
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
       

        protected void btn_tkDanhMuc_Click(object sender, EventArgs e)
        {
            tim_kiem_DM();
        }
        public string tim_kiem_DM()
        {
            string ma_dm_can_xoa = "";
            DataTable tb = new DataTable();
            tb = data_danhmuc.timkiem_danhMuc(txt_tk_DanhMuc.Text.Trim());
            DataTable tb1 = new DataTable();
            tb1 = data_danhmuc.load_so_lop_tk(txt_tk_DanhMuc.Text.Trim()) ;
            if (tb.Rows.Count == 0)
            {
                list_dm_timkiem.Text = "";
            }
            else
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (tb1.Rows[i]["sosp"].ToString().Trim() == "0")
                    {
                        ma_dm_can_xoa = tb.Rows[i]["madanhmuc"].ToString();
                    }
                    list_dm_timkiem.Text = @"
                                        <tr class='hang_table'>
                                    <td class='DL_cac_dong_table'>" + tb.Rows[i]["madanhmuc"] + @"</td>
                                    <td class='DL_cac_dong_table'>" + tb.Rows[i]["tendanhmuc"] + @"</td>
                                    <td class='DL_cac_dong_table'>" + tb1.Rows[i]["sosp"] + @"</td>
                                </tr>";
                }
            }
            return ma_dm_can_xoa;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
                int a = data_danhmuc.xoa_danhMuc(tim_kiem_DM());
                if (a == 0)
                {
                    lb_tb.CssClass = "thanh_cong";
                    lb_tb.Text = "Xóa Thành Công Danh Mục: " + txt_tk_DanhMuc.Text;
                    txt_tk_DanhMuc.Text = "";
                    list_dm_timkiem.Text = "";
                }
                else
                {
                    lb_tb.CssClass = "that_bai";
                    lb_tb.Text = "Xóa Thất Bại";
                }
        }

        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_.aspx?modul=tatcadanhmuc");
        }
    }
}
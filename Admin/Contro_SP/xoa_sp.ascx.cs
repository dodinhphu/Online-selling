using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace web_ban_hang.Admin.Contro_SP
{
    public partial class xoa_sp : System.Web.UI.UserControl
    {
        xl_dl.data_DanhMuc.SanPham_data data_sp = new xl_dl.data_DanhMuc.SanPham_data();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_tk_sp_Click(object sender, EventArgs e)
        {
            tim_kiem_sp();
        }
        public string tim_kiem_sp()
        {
            string ma_sp_can_xoa = "";
            DataTable tb = new DataTable();
            tb = data_sp.tim_kiem_sp(txt_tk_SP.Text.Trim());
            if (tb.Rows.Count == 0)
            {
                list_sp_tim.Text = "";
            }
            else
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    ma_sp_can_xoa = tb.Rows[i]["masp"].ToString();
                    list_sp_tim.Text = @"
                                            <tr class='hang_table'>
                                    
                                    <td class='DL_cac_dong_table'>" + tb.Rows[i]["masp"] + @"</td>
                                    <td class='DL_cac_dong_table'>" + tb.Rows[i]["tensp"] + @"</td>
                                    <td class='DL_cac_dong_table'>" + tb.Rows[i]["madanhmuc"] + @"</td>
                                     <td class='DL_cac_dong_table'>" + tb.Rows[i]["ngaythem"] + @"</td>
                                    <td class='DL_cac_dong_table'>" + tb.Rows[i]["dongia"] + @"</td>
                                    <td class='DL_cac_dong_table'>" + tb.Rows[i]["soluong"] + @"</td>
                                    <td class='DL_cac_dong_table'>" + tb.Rows[i]["tenanh"] + @"</td>
                                </tr>";
                }
            }
            return ma_sp_can_xoa;
        }



        protected void btn_xoa_sp_Click1(object sender, EventArgs e)
        {
            int a = data_sp.xoa_sanpham(tim_kiem_sp());
            if (a == 0)
            {
                lb_tb.CssClass = "thanh_cong";
                lb_tb.Text = "Xóa Thành Công Danh Mục: " + txt_tk_SP.Text;
                txt_tk_SP.Text = "";
                list_sp_tim.Text = "";
            }
            else
            {
                lb_tb.CssClass = "that_bai";
                lb_tb.Text = "Xóa Thất Bại";
            }
        }

        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_.aspx?modul=tatcasp");
        }
    }
}
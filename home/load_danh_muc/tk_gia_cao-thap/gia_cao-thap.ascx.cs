using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_ban_hang.home.load_danh_muc.tk_gia_cao_thap
{
    public partial class gia_cao_thap : System.Web.UI.UserControl
    {
        xl_dl.data_Home.san_pham data_sp = new xl_dl.data_Home.san_pham();
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable tb = new DataTable();
            tb = data_sp.gia_cao_thap();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                list_load_sp.Text += @"  <div class='grid_colum_2_4 '>
                                      <a class='khung_sp' href='Home.aspx?modul=chitietsp&masanpham=" + tb.Rows[i]["masp"].ToString().Trim() + @"'>
                                        <div class='anh_san_pham'
                                            style='background-image :url(/img/img_sp/" + tb.Rows[i]["tenanh"].ToString().Trim() + @")'></div>
                                        <h4 class='ten_sp'>" + tb.Rows[i]["tensp"].ToString().Trim() + @"</h4>
                                        <div class='gia'>
                                            <span class='gia_giacu'>SL: " + tb.Rows[i]["soluong"].ToString().Trim() + @"</span>
                                            <span class='gia_giahientai'>" + tb.Rows[i]["dongia"].ToString().Trim() + @"đ</span>
                                        </div>
                                        <div class='sp__tuong_tac_khach_hang'>
                                            <span class='icon_tuong_tac_tim  da_tim'>
                                                <!-- nếu có class tha_tim thì màu đỏ ngược lại màu trắng -->
                                                <i class='icon_chua_tim far fa-heart'></i>
                                                <i class='icon_da_tim fas fa-heart'></i>
                                            </span>
                                            <div class='icon_tuong_tac_sao'>
                                                <i class='icon_sao fas fa-star  da_danh_gia_sao'></i>
                                                <i class='icon_sao fas fa-star  da_danh_gia_sao'></i>
                                                <i class='icon_sao fas fa-star  da_danh_gia_sao'></i>
                                                <i class='icon_sao fas fa-star  da_danh_gia_sao'></i>
                                                <i class='icon_sao fas fa-star  '></i>
                                            </div>
                                        </div>
                                        <div class='thuonghieu_diachishop'>
                                            <span class='thuonghieu'>" + tb.Rows[i]["thuonghieu"].ToString().Trim() + @"</span>
                                            <span class='diachishop'>" + tb.Rows[i]["diachishop"].ToString().Trim() + @"</span>
                                        </div>
                                    </a>
                                </div> ";
            }
        }
    }
}
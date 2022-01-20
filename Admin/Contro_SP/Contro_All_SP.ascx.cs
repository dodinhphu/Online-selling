using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web_ban_hang.Admin.Contro_SP
{
    public partial class Contro_All_SP : System.Web.UI.UserControl
    {
        xl_dl.data_DanhMuc.SanPham_data data_sp = new xl_dl.data_DanhMuc.SanPham_data();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataTable tb = new DataTable();
            tb = data_sp.load_sp();
            for(int i=0;i<tb.Rows.Count;i++)
            {
                list_sp.Text+= @"
                                    <tr id='madong_" + "" + tb.Rows[i]["masp"].ToString().Trim() + "" + @"' class='hang_table'>
                                <td class='DL_cac_dong_table chua_icon'>
                                    <a class='link_icon_them_xoa' href='" + "javascript:xoasanpham(\"" + tb.Rows[i]["masp"].ToString().Trim() + "\")" + @"'>
                                        <i class='fas fa-trash'></i>
                                    </a>
                                    <a class='link_icon_them_xoa' href='Admin_.aspx?modul=suasp&masp=" + tb.Rows[i]["masp"].ToString().Trim() + @"'>
                                        <i class='icon_them fas fa-edit'></i>
                                    </a>
                                </td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["masp"].ToString().Trim() + @"</td>
                                <td class='DL_cac_dong_table ten_sp_dm'>" + tb.Rows[i]["tensp"].ToString().Trim() + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["madanhmuc"].ToString().Trim() + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["ngaythem"].ToString().Trim() + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["dongia"].ToString().Trim() + @"đ</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["soluong"].ToString().Trim() + @"</td>
                                <td class='DL_cac_dong_table cotanh'>
                                <img class='hien_thi_anh_sp' src=' /img/img_sp/" + tb.Rows[i]["tenanh"].ToString().Trim() + @"' >
                                <img class='hien_thi_anh_sp_hover' src=' /img/img_sp/" + tb.Rows[i]["tenanh"].ToString().Trim() + @"' >
                                </td>
                            </tr>   
                                ";
            }    
        }
    }
}
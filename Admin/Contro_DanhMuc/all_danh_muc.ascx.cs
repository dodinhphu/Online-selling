using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace web_ban_hang.Admin.Contro_DanhMuc
{
    public partial class all_danh_muc : System.Web.UI.UserControl
    {
        xl_dl.data_DanhMuc.DanhMuc_data data_danhmuc = new xl_dl.data_DanhMuc.DanhMuc_data();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_DM();
        }
        public void load_DM()
        {
            DataTable tb = new DataTable();
            tb = data_danhmuc.load_danhMuc();
            DataTable tb1 = new DataTable();
            tb1 = data_danhmuc.load_so_lop();
            for (int i=0;i<tb.Rows.Count;i++)
            {
               
                list_load_danhMuc.Text += @" 
                       <tr id='madong_" + "" + tb.Rows[i]["madanhmuc"].ToString().Trim() + "" + @"'    class='hang_table'>
                                 <td class='DL_cac_dong_table chua_icon'>
                                    <a  class='link_icon_them_xoa' href='" + "javascript:xoadanhmuc(\""+ tb.Rows[i]["madanhmuc"].ToString().Trim() + "\")"+@"'>
                                        <i class='fas fa-trash'></i>
                                    </a>
                                    <a class='link_icon_them_xoa' href='Admin_.aspx?modul=suadanhmuc&madm=" + tb.Rows[i]["madanhmuc"].ToString().Trim() + @"'>
                                        <i class='icon_them fas fa-edit'></i>
                                    </a>
                                </td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["madanhmuc"].ToString().Trim() + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["tendanhmuc"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb1.Rows[i]["sosp"] + @"</td>
                            </tr>";
            }   
            
        }
    }
}
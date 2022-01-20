using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web_ban_hang.Admin.conTro_HoaDon
{
    public partial class Hoa_don : System.Web.UI.UserControl
    {
        xl_dl.data_Home.donhang data_donhang = new xl_dl.data_Home.donhang();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = data_donhang.lay_tat_ca_hoa_don();
            for(int i=0;i<tb.Rows.Count;i++)
            {
                list_hoadon.Text += @"   <div class='table_hienthi'>
                        <table class='table'>
                            <tr class='cot_table'>
                                <th class='ten_cot_table cot_tencongcu'>Công Cụ</th>
                                <th class='ten_cot_table '>Mã Khách Hàng</th>
                                <th class='ten_cot_table '>Ngày Tạo</th>
                                <th class='ten_cot_table '>Tên Khách Hàng</th>
                                <th class='ten_cot_table '>Số Điện Thoại</th>
                                <th class='ten_cot_table '>Email</th>
                                <th class='ten_cot_table '>Tổng Tiền</th>
                               
                            </tr>
                            <tr class='hang_table'>
                                <td class='DL_cac_dong_table chua_icon'>
                                    <a class='link_icon_them_xoa' href='Admin_.aspx?modul=hoa_don_chi_tiet&mahoadon=" + tb.Rows[i]["mahoadon"]+ @"'>
                                        <i class='fas fa-folder-open'></i>
                                    </a>
                                </td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["makhachhang"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["ngaytao"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["tenkhahhang"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["sdt_kh"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["email_kh"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["thanhtien"] + @"VNĐ</td>
                             
                            </tr>
                        </table>
                    </div> ";
            }    
          
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web_ban_hang.Admin.conTro_HoaDon
{
    public partial class hoa_don_chi_tiet : System.Web.UI.UserControl
    {
        xl_dl.data_Home.don_hang_chi_tiet data_hoadon_ct = new xl_dl.data_Home.don_hang_chi_tiet();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = data_hoadon_ct.load_hoa_don_chi_tiet(load_mahd().Trim());
            list_sohoadon.Text =tb.Rows[0]["mahoadon"].ToString().Trim();
            for (int i=0;i<tb.Rows.Count;i++)
            {
                list_hoadonchitiet.Text += @" 
                            <tr class='hang_table'>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["masp"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["soluong"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["dongia"] + @"</td>
                                <td class='DL_cac_dong_table'>" + tb.Rows[i]["tinhtrang"] + @"</td>
                            </tr>
                        ";
            }    
        }
        
        public string load_mahd()
        {
            string mahoadon = "";
            if(Request.QueryString["mahoadon"]!=null)
            {
                mahoadon = Request.QueryString["mahoadon"].ToString().Trim();
            }
            return mahoadon;
        }
    
    }
}
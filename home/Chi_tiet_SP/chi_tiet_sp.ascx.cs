using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_ban_hang.home.Chi_tiet_SP
{
    public partial class chi_tiet_sp : System.Web.UI.UserControl
    {
        xl_dl.data_Home.san_pham data_sp = new xl_dl.data_Home.san_pham();
        protected string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Request.QueryString["masanpham"]!=null)
            {
                id = Request.QueryString["masanpham"].ToString().Trim();
            }   
           if(!IsPostBack)
            {
                laychitietsp(id);
            }    
        }
           
        public void laychitietsp(string masp)
        {
            DataTable tb = new DataTable();
            tb = data_sp.tim_sp(masp);
            if(tb.Rows.Count>0)
            {
                list_anh.Text = @" <div class='grid_colum_4'>
                                          <div class='anh_sp_chitiet' style='background-image: url(/img/img_sp/"+tb.Rows[0]["tenanh"]+@");'></div>
                                    </div>";
                list_tensp.Text = tb.Rows[0]["tensp"].ToString().Trim();
                list_giasp.Text = tb.Rows[0]["dongia"].ToString().Trim();
                list_mota.Text = tb.Rows[0]["mota"].ToString().Trim();
            }    
        }
    }
}
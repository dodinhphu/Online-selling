
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace web_ban_hang.Admin.Contro_SP
{
    public partial class them_sua_sp : System.Web.UI.UserControl
    {
        xl_dl.data_DanhMuc.SanPham_data data_sp = new xl_dl.data_DanhMuc.SanPham_data();
        protected void Page_Load(object sender, EventArgs e)
        {
            load_danh_muc();
            load_time();

            if (laymodul() == "themsp")
            {
                btn_them.Text = "Thêm Mới";
                list_hienthitb.Text = "<h2 class='txt_tensp'>Thêm Sản Phẩm Mới</h2>";
            }
            else
            {
                btn_them.Text = "Sửa";
                list_hienthitb.Text = "<h2 class='txt_tensp'>Sửa Sản Phẩm</h2>";
                hienthi_tt_sp_sua();
            }
        }
        public void hienthi_tt_sp_sua()
        {
            DataTable tb = new DataTable();
            tb = data_sp.tim_kiem_sp(laymodulphu());
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txt_masp.Text = tb.Rows[i]["masp"].ToString().Trim().Trim();
                    txt_tensp.Text= tb.Rows[i]["tensp"].ToString().Trim();
                    lis_danhmuc.SelectedValue= tb.Rows[i]["madanhmuc"].ToString().Trim();
                    txt_diachishop.Text= tb.Rows[i]["diachishop"].ToString().Trim();
                    txt_thuonghieu.Text= tb.Rows[i]["thuonghieu"].ToString().Trim();
                    txt_dongia.Text= tb.Rows[i]["dongia"].ToString().Trim();
                    txt_soluong.Text= tb.Rows[i]["soluong"].ToString().Trim();
                    txt_ngayThem.Text= tb.Rows[i]["ngaythem"].ToString().Trim();
                    txt_mota.Text = tb.Rows[i]["mota"].ToString().Trim();
                }
            }
        }
        public string laymodul()
        {
            if (Request.QueryString["modul"] != null)
            {
                return Request.QueryString["modul"].ToString();
            }
            return null;
        }
        public string laymodulphu()
        {
            if (Request.QueryString["masp"] != null)
            {
                return Request.QueryString["masp"].ToString();
            }
            return null;
        }
        public void load_danh_muc()
        {
            xl_dl.xl_chung dungchung = new xl_dl.xl_chung();
            string sql = "SELECT * FROM dbo.danhmuc";
            DataTable tb = new DataTable();
            tb = dungchung.load_dulieu(sql);
            lis_danhmuc.Items.Clear();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                lis_danhmuc.Items.Add(new ListItem(tb.Rows[i]["tendanhmuc"].ToString().Trim(), tb.Rows[i]["madanhmuc"].ToString().Trim()));
            }
        }
        public void load_time()
        {
            txt_ngayThem.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        protected void btn_huy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_.aspx?modul=tatcasp");
        }

        protected void btn_them_Click(object sender, EventArgs e)
        {
            if (up_anh.FileContent.Length > 0)
            {
                if (up_anh.FileName.EndsWith(".jpeg") || up_anh.FileName.EndsWith(".jpg") || up_anh.FileName.EndsWith(".png") || up_anh.FileName.EndsWith(".gif"))
                {
                    up_anh.SaveAs(Server.MapPath("img/img_sp/") + up_anh.FileName);
                }
            }
            //code thêm sp
            if (laymodul() == "themsp")
            {
                int a = data_sp.them_sp(txt_masp.Text.Trim(), txt_tensp.Text.Trim(), txt_dongia.Text.Trim(), txt_soluong.Text.Trim(), lis_danhmuc.SelectedValue.ToString().Trim(), txt_diachishop.Text.Trim(), txt_thuonghieu.Text.Trim(), up_anh.FileName.ToString().Trim(), txt_ngayThem.Text.Trim(), txt_mota.Text.Trim());
                if (a == 0)
                {
                    lb_tb.CssClass = "thanh_cong";
                    lb_tb.Text = "Thêm Thành Công Sản Phẩm: " + txt_masp.Text;
                    txt_masp.Text = "";
                    txt_tensp.Text = "";
                    txt_dongia.Text = "";
                    txt_soluong.Text = "";
                    txt_thuonghieu.Text = "";
                    txt_diachishop.Text = "";
                    txt_ngayThem.Text = "";
                    txt_mota.Text = "";
                }
                else
                {
                    lb_tb.CssClass = "that_bai";
                    lb_tb.Text = "Thêm Thất Bại";
                }
            }
            else
            {
                int a = data_sp.sua_sp(txt_masp.Text.Trim(), txt_tensp.Text.Trim(), txt_dongia.Text.Trim(), txt_soluong.Text.Trim(), lis_danhmuc.SelectedValue.ToString().Trim(), txt_diachishop.Text.Trim(), txt_thuonghieu.Text.Trim(), up_anh.FileName.ToString().Trim(), txt_ngayThem.Text.Trim(), txt_mota.Text.Trim());
                if(a==0)
                {
                    lb_tb.CssClass = "thanh_cong";
                    lb_tb.Text = "Sửa Thành Công Sản Phẩm: " + txt_masp.Text;
                    txt_masp.Text = "";
                    txt_tensp.Text = "";
                    txt_dongia.Text = "";
                    txt_soluong.Text = "";
                    txt_thuonghieu.Text = "";
                    txt_diachishop.Text = "";
                    txt_ngayThem.Text = "";
                    txt_mota.Text = "";
                }
                else
                {
                    lb_tb.CssClass = "that_bai";
                    lb_tb.Text = "Sửa Thất Bại";
                }
            }
        }
    }
}
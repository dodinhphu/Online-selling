using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace web_ban_hang.home.ajax
{
    public partial class thao_tac_them_vao_gio_hang : System.Web.UI.Page
    {
        xl_dl.data_Home.san_pham data_sp = new xl_dl.data_Home.san_pham();
        xl_dl.data_Home.don_hang_chi_tiet data_donn_hang_chi_tiet = new xl_dl.data_Home.don_hang_chi_tiet();
        xl_dl.data_Home.donhang data_don_hang = new xl_dl.data_Home.donhang();
        private string thaotac = "";
       
        protected void Page_Load(object sender, EventArgs e)
        {
            thaotac = Request.Params["thaotac"];
            switch (thaotac)
            {
                case "themvaogiohang":
                    themvaogiohang();
                    break;
                case "laythongtingiohang":
                    laythongtingiohang();
                    break;
                case "xoa_sp_giohang":
                    xoa_sp_giohang();
                    break;
                case "tong_tien":
                    tong_tien();
                    break;
                case "dat_hang":
                    dat_hang();
                    break;
            }    
        }
        public void dat_hang()
        {
            string ketqua = "";
            // lấy các thông tin lên
            String hoten = Request.Params["hoten"];
            String diachi = Request.Params["diachi"];
            String sdt = Request.Params["sdt"];
            String email = Request.Params["email"];
            String makh = Request.Params["makh"];
            // kiểm tra tồn tại giỏ hàng
            if (Session["giohang"] != null)
            {
                DataTable tb_giohang = new DataTable();
                tb_giohang = (DataTable)Session["giohang"];
                //lấy tổng tiền trên sever
                int thanhtien = 0;
                for (int i = 0; i < tb_giohang.Rows.Count; i++)
                {
                    thanhtien = thanhtien + int.Parse(tb_giohang.Rows[i]["soluong"].ToString()) * int.Parse(tb_giohang.Rows[i]["dongia"].ToString().Trim());
                }
                // thêm thông tin vào bản đơn hàng
                data_don_hang.them_don_hang(makh.ToString().Trim(), DateTime.Now.ToString().Trim(), thanhtien.ToString().Trim(), hoten.ToString().Trim(), sdt.ToString().Trim(), email.ToString().Trim());
                //thêm từng sp vào bản chi tiết đơn hàng
                DataTable tb_don_hang = new DataTable();
                tb_don_hang = data_don_hang.lay_don_moi_nhat();
                string madonhang = tb_don_hang.Rows[0]["mahoadon"].ToString().Trim();
                // thêm các sản phẩm vào bản đơn hàng chi tiết
                for(int i=0;i<tb_giohang.Rows.Count;i++)
                {
                    data_donn_hang_chi_tiet.them_hoa_don_chi_tiet(madonhang.ToString().Trim(), tb_giohang.Rows[i]["masp"].ToString().Trim(), tb_giohang.Rows[i]["soluong"].ToString().Trim(), tb_giohang.Rows[i]["dongia"].ToString().Trim(),"Đang Xử Lý");
                }
                // sau khi lưu thông tin và cái bảng trong database thì xóa giỏ hàng đi
                Session["giohang"] = null;
            }
            else
            {
                ketqua = "Giỏ Hàng Đã Hết Hạng, Vui Lòng Đặt Hàng Lại !!!";
            }
            Response.Write(ketqua);
        }



        //xóa
        public void xoa_sp_giohang()
        {
            String ma = "";
            ma = Request.Params["ma"];

            if (Session["giohang"] != null)
            {
                DataTable tb_giohang = new DataTable();
                tb_giohang = (DataTable)Session["giohang"];
                // kt sp trong gio nếu trùng thì xoa
                for (int i = 0; i < tb_giohang.Rows.Count; i++)
                {
                    if(tb_giohang.Rows[i]["masp"].ToString().Trim()==ma)
                    {
                        tb_giohang.Rows[i].Delete();
                    }    
                }
                // gán lại vào sesson 
                Session["giohang"] = tb_giohang;
            }
            Response.Write("");
        }
        // tính tổng tiền
        public void tong_tien()
        {
            double tongtien = 0;
            if(Session["giohang"]!=null)
            {
                DataTable tb_giohang = new DataTable();
                tb_giohang = (DataTable)Session["giohang"];
                for(int i=0;i<tb_giohang.Rows.Count;i++)
                {
                    tongtien = tongtien + int.Parse(tb_giohang.Rows[i]["soluong"].ToString()) * double.Parse(tb_giohang.Rows[i]["dongia"].ToString());
                }    
            }
            Response.Write(tongtien);
        }
        // thêm vào giỏ hàng
        public void themvaogiohang()
        {
            string ketqua = "";

            string id = Request.Params["id"];
            string soluong = Request.Params["soluong"];
            DataTable tb = new DataTable();
            // lấy thông tin sp được chọn add vào giỏ
            tb = data_sp.tim_sp(id);
            if(tb.Rows.Count>0)
            {
                // nếu chưa có giỏ hàng thì tạo
                if(Session["giohang"]==null)
                {
                    // khai báo bảng sản phẩm đẻ lưu lần đàu tiên
                    DataTable tb_giohang = new DataTable();
                    tb_giohang.Columns.Add("masp");
                    tb_giohang.Columns.Add("tensp");
                    tb_giohang.Columns.Add("tenanh");
                    tb_giohang.Columns.Add("dongia");
                    tb_giohang.Columns.Add("soluong");
                    //lưu thông tin vào bảng
                    tb_giohang.Rows.Add(  tb.Rows[0]["masp"].ToString().Trim(), tb.Rows[0]["tensp"].ToString(), tb.Rows[0]["tenanh"].ToString(), tb.Rows[0]["dongia"].ToString(),soluong);


                    // gán giá trị của bảng tb_giohang và giỏ hàng
                    Session["giohang"] = tb_giohang;
                }
                // nếu đã có giỏ hàng ---> thì thêm mới sp vào giỏ hàng
                else
                {
                    // khai báo datatabe để chứa giỏ hàng
                    DataTable tb_giohang = new DataTable();
                    tb_giohang = (DataTable)Session["giohang"];


                    // kiếm tra xem trong giỏ hàng đã có sp này chưa
                    // nếu có thì tăng số lượng
                    // nếu chưa có thì thêm sp vào cuối giỏ hàng
                    int vitrisp = -1;// nếu sau for vị trí này thay đỗi thì có sp trong giỏ 
                    for(int i=0; i<tb_giohang.Rows.Count;i++)
                    {
                        if(tb_giohang.Rows[i]["masp"].ToString().Trim()==id.Trim())
                        {
                            // đã tồn tại sp trong giỏ
                            vitrisp = i;
                        }  
                     
                    }    
                    // Nếu có
                    if(vitrisp!=-1)
                    {
                        // lấy ra số lượng hiệu tại của sp đó trong giỏ 
                        int soluong_hientai =int.Parse(tb_giohang.Rows[vitrisp]["soluong"].ToString().Trim());
                        // cộng thêm số lượng mua lần sau
                        soluong_hientai =soluong_hientai+ int.Parse(soluong.Trim());
                        // cập nhật lại giỏ hàng tạm
                        tb_giohang.Rows[vitrisp]["soluong"] = soluong_hientai;
                        // gán lại giá tri bảng tạm vào giỏ
                        Session["giohang"] = tb_giohang;
                    }   
                    // Nếu K có trong giỏ hàng
                    else
                    {
                        //lưu thông tin vào bảng
                        tb_giohang.Rows.Add(tb.Rows[0]["masp"].ToString(), tb.Rows[0]["tensp"].ToString(), tb.Rows[0]["tenanh"].ToString(), tb.Rows[0]["dongia"].ToString(), soluong);
                        // gán giá trị của bảng tb_giohang và giỏ hàng
                        Session["giohang"] = tb_giohang;
                    }    
                }
            }
            else
            {
                ketqua = "Không Tồn Tại Sản Phẩm";
            }
            Response.Write(ketqua);
        }

        // lấy thông tin giỏ hàng
        public void laythongtingiohang()
        {
            string ketqua = "";
            // nếu giỏ hàng khác null thì mới lây ra
            if (Session["giohang"]!=null)
            {
                DataTable tb_giohang = new DataTable();
                tb_giohang = (DataTable)Session["giohang"];
                //phần đàu
                ketqua = @"     <div class='bao_quanh_cot_gio'>
                                <div class='cot_gio_hang cot20tren100'>
                                        <h1 class='txt_anhgio'>Hình Ảnh</h1>
                                  </div>
                                 <div class='cot_gio_hang cot40tren100'>
                                      <h1 class='txt_sanphamgio'>Sản Phẩm</h1>
                                 </div>
                                 <div class='cot_gio_hang cot20tren100'>
                                       <h1 class='txt_dongiagio'>Đơn Giá</h1>
                                   </div>
                                <div class='cot_gio_hang cot15tren100'>
                                      <h1 class='txt_So_luong_gio'>Số Lượng</h1>
                                  </div>
                                 <div class='cot_gio_hang cot5tren100'>

                                 </div>
                            </div>";
                //phần lặp
                for(int i=0;i<tb_giohang.Rows.Count;i++)
                {
                   
                    ketqua += @"  <div class='grid__row all_conten hang_gio_hang   '>     
                                <div id='madong_" + "" + tb_giohang.Rows[i]["masp"].ToString().Trim() + "" + @"' class='bao_quanh_tung_hang_gio'>  <!-- chia cot gio hang -->
                                    <div class='hang_gio_hang cot20tren100'>
                                        <img class='phan_anh_gio_hang' src='/img/img_sp/" + tb_giohang.Rows[i]["tenanh"].ToString()+ @"' alt=''>
                                    </div>
                                    <div class='hang_gio_hang hang_gio_hang ten_sp_gio_hang_ cot40tren100'>
                                        <a  href='Home.aspx?modul=chitietsp&masanpham=" + tb_giohang.Rows[i]["masp"].ToString().Trim() + @"' class='txt_txt_sanphamgio'>" + tb_giohang.Rows[i]["tensp"].ToString().Trim() + @"</a>
                                    </div>
                                    <div class='hang_gio_hang cot20tren100'>
                                        <h3 class='txt_txt_dongiagio'>" + tb_giohang.Rows[i]["dongia"].ToString().Trim() + @"đ</h3>
                                    </div>
                                    <div class='hang_gio_hang cot15tren100'>
                                        <h3 class='txt_-txt_So_luong_gio'>" + tb_giohang.Rows[i]["soluong"].ToString().Trim() + @"</h3>
                                    </div>
                                    <div class='hang_gio_hang cot5tren100'>
                                        <a class='link_xoa_hd' href='" + "javascript:xoa_sp_giohang(\"" + tb_giohang.Rows[i]["masp"].ToString().Trim() + "\")" + @"'>
                                            <i class='icon_xoa_hoa_don fas fa-trash'></i>
                                        </a>
                                    </div>
                                </div>
                                </div>
                             ";
                }
                ketqua += @"  <div class='tt_khach_hang_mua--tong_tien'>
                                   <h2 class='txt_tong_tien'></h2>
                            </div>
                            <div class='tt_khach_hang_mua'>
                            <ul class='list_danh_muc_tt_kh'>
                                    <h3 class='txt_kttt_truocTT'>Hãy Đãm Bảo Thông Tin Chính Xác Trước Khi Đặt Hàng</h3>
                                    <li class='tung_muc_tt_kh'>
                                        <span class='txt_tt_kh'>
                                            Tên Khách Hàng
                                        </span>
                                         <input  value='" + Session["tenkhachhang"].ToString().Trim() + @"' readonly type='text' class='ip_tt_kh tenkh'>
                                             <input  value='" + Session["tk_use"].ToString().Trim() + @"' readonly type='text' class='ip_tt_kh hide makh'>
                                    </li>
                                    <li class='tung_muc_tt_kh'>
                                        <span class='txt_tt_kh'>
                                            Địa Chỉ Giao Hàng
                                        </span>
                                       <input  value='" + Session["diachi"].ToString().Trim() + @"' readonly type='text' class='ip_tt_kh diachikhachhang'>
                                    </li>
                                    <li class='tung_muc_tt_kh'>
                                        <span class='txt_tt_kh'>
                                         Số Điện Thoại Người Nhận
                                        </span>
                                      <input  value='" + Session["sodienthoai"].ToString().Trim() + @"' readonly type='text' class='ip_tt_kh sodienthoai'>
                                    </li>
                                    <li class='tung_muc_tt_kh'>
                                        <span class='txt_tt_kh'>
                                            Email Người Nhận
                                        </span>
                                        <input  value='" + Session["email"].ToString().Trim() + @"' readonly type='text' class='ip_tt_kh email'>
                                    </li>
                                </ul>
                                   </div>  
                         <div class='btn_gioi_hang'>
                               <a href='Home.aspx' class='gh_btn gio_hang_mua'>Tiếp Tục Mua Hàng</a>
                                <a href='javascript:dat_hang()' class='gh_btn gio_hang_mua  dat_hang'>Đặt Hàng</a>
                            </div> 
                        ";
            }
            else
            {
                ketqua = @"<h1 class='giohang_trong'>Giỏ Hàng Trống</h1>";
            }
            Response.Write(ketqua);
        }



        // xóa sp trong giỏ
    
    }
}
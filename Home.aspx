<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="web_ban_hang.Home" %>


<%@ Register Src="~/home/Home_Dieu_huong.ascx" TagPrefix="uc1" TagName="Home_Dieu_huong" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="home/css_home/base.css" rel="stylesheet" />
    <link href="home/css_home/css_form_dk_dangnhap.css" rel="stylesheet" />
    <link href="home/css_home/style.css" rel="stylesheet" />
    <link href="icon/icon_code_web/fontawesome-free-5.15.3-web/css/all.min.css" rel="stylesheet" />
    <script src="Admin/js/jquery_web.js"></script> 
    <script src="home/js_home/jquery-1.8.0.min.js"></script>
     <!-- forn chữ-->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;500;700&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
      <div class="app">
        <!--  toàn bộ web -->
        <header class="phan_dau_web">
            <!-- phần đâu web gồm: phần danh sách menu,khung tim kiếm logo giỏ hàng -->
            <div class="grid">
                <nav class="phan_dau_web__phan_menu">
                    <!-- phần menu của phần đầu gồm 2 thẻ ul chứa 2 danh sách menu  -->
                    <!-- danh sách bên trái -->
                    <ul class="phan_dau_web__phan_menu--ds_menu">
                        <li class="phan_dau_web__phan_menu--ds_menu--item   tao_gach">Vào Cửa Hàng Trên Ứng Dụng</li>
                        <li class="phan_dau_web__phan_menu--ds_menu--item">
                            <a class="phan_dau_web-link_menu" href=""><i
                                    class="icon_fb_diagram_thongbaao_hotro far fa-question-circle"></i></a>
                            Trợ Giúp
                        </li>
                        <li class="phan_dau_web__phan_menu--ds_menu--item">
                            <span class="css_ketnoi">Kết Nối</span>
                            <a class="icon_fb_diagram_thongbaao_hotro" href="#"><i
                                    class="icon_fb_diagram_thongbaao_hotro fab fa-facebook"></i></a>
                            <a class="icon_fb_diagram_thongbaao_hotro" href="#"><i
                                    class="icon_fb_diagram_thongbaao_hotro fab fa-instagram"></i></a>
                        </li>
                    </ul>
                    <!-- danh sách bên phải -->
                    <ul class="phan_dau_web__phan_menu--ds_menu">
                           <!-- dang xuat_ ten user--> 
                        <asp:PlaceHolder ID="plhd_Dang_xuat_ten_use" runat="server">
                         <li  class="phan_dau_web__phan_menu--ds_menu--item  ">                   <!-- link use chỉnh sửa --> 
                            <a class="phan_dau_web-link_menu   chu_dam_dk_dangnhap  tao_gach " href="Home.aspx?modul=usedangky&modulphu=chinhsuauser">
                                <i class="icon_fb_diagram_thongbaao_hotro  fas fa-user"></i>
                                <asp:Literal ID="list_ten_user" runat="server"></asp:Literal></a>
                        </li>
                             <li  class="phan_dau_web__phan_menu--ds_menu--item ">                  
                            <asp:Button OnClick="btn_dangxuat_onclick" class="tao_gach  phan_dau_web-link_menu btn_dangxuat1" ID="btn_dangxuat" runat="server" Text="Đăng Xuất" /> 
                        </li>
                        </asp:PlaceHolder>
                          <!-- dang nhap --> 
                        <asp:PlaceHolder ID="plhd_dang_nhap" runat="server">
                             <li  class="phan_dau_web__phan_menu--ds_menu--item  ">              <!-- link use đăng nhập --> 
                            <a class="phan_dau_web-link_menu   chu_dam_dk_dangnhap  tao_gach " href="Home.aspx?modul=usedangnhap">Đăng Nhập</a>
                        </li>
                        </asp:PlaceHolder>
                        <li class="phan_dau_web__phan_menu--ds_menu--item ">                  <!-- link admin dang nhap -->        
                            <a class="phan_dau_web-link_menu   chu_dam_dk_dangnhap  tao_gach" href="Login.aspx?modul=admindangnhap">Admin Đăng Nhập</a>
                        </li>
                           <!--dang ký --> 
                        <asp:PlaceHolder ID="plhd_dang_ky" runat="server">
                             <li class="phan_dau_web__phan_menu--ds_menu--item ">                <!-- link use dang ký -->
                            <a class="phan_dau_web-link_menu   chu_dam_dk_dangnhap" href="Home.aspx?modul=usedangky">Đăng Ký</a>
                        </li>
                        </asp:PlaceHolder>
                    </ul>
                </nav>

                <div class="phandau__logo_seach_giohang">
                    <!-- phần logo , khung tìm kiếm, giỏ hàng -->
                    <div class="phandau__logo">
                        <!-- logo -->
                      
                    </div>

                    <div class="phandau__seach">
                        <!-- phần thanh tìm kiếm -->
                       <asp:TextBox class="input_seach" ID="txt_ten_sp_timkiem" runat="server" placeholder="Nhập Để Tìm Kiếm"></asp:TextBox>
                        <button id="btn_tim_kiem_sp" class="nut_iconseach"  runat="server"  onserverclick="btn_tim_kiem_sp_OnClick">
                            <i class="icon_seach fas fa-search"></i>
                        </button>
                    </div>

                    <div class="phandau__giohang">
                        <!-- giỏ hàng -->        <!-- link Giỏ Hàng --> 
                        <a class="link_trang_gioHang" href="Home.aspx?modul=giohang"> <i class="icon_giohang  fas fa-shopping-cart"></i></a>
                       
                    </div>
                </div>
            </div>
        </header>

        <!-- phần slide -->
          <asp:PlaceHolder ID="plhd_slide" runat="server">
               <div class="slide_mater_page">
            <div class="slide">
                <div class="icon__slide">
                    <i class="icon_icon_trai fas fa-angle-left" onclick="back()"></i>
                    <i class="icon_icon_phai fas fa-angle-right" onclick="next()"></i>
                </div>
                <div class="chuyenslide">
                    <img class="img_slide" src="/img/img_slide/sl1.jpg" alt="">
                    <img class="img_slide" src="/img/img_slide/sl2.png" alt="">
                    <img class="img_slide" src="/img/img_slide/sl3.jpg" alt="">
                    <img class="img_slide" src="/img/img_slide/sl4.jpg" alt="">
                    <img class="img_slide" src="/img/img_slide/sl5.jpg" alt="">
                </div>
            <script src="home/js_home/javar.js"></script>
            </div>
        </div>
          </asp:PlaceHolder>

        <!-- phần nội dung web -->
        <div class="noi_dung_web">
            <!-- contern -->
            <div class="grid">
                <div class="grid__row all_conten">
                    <!-- chiều dài  -->
                    <uc1:Home_Dieu_huong runat="server" id="Home_Dieu_huong" />
                    <!-- tổng phần nội dung -->
                   
                </div>
            </div>
        </div>
        <footer class="cuoi_web">
            <!-- phần cuôi web __ footer-->
            <div class="grid">
                <div class="grid__row">
                    <!-- phần  danh sách-->
                    <div class="grid_colum_2_4">
                        <h3 class="name_cot_footer">Chăm Sóc Khách Hàng</h3>
                        <ul class="list_tung_cot_footer">
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Trung Tâm Hổ Trợ</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Store Mall</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Hướng Dẩn Mua Hàng</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Trung Tâm Hổ Trợ</a>
                            </li>
                        </ul>
                    </div>
                    <div class="grid_colum_2_4">
                        <h3 class="name_cot_footer">Giới Thiệu</h3>
                        <ul class="list_tung_cot_footer">
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Giới Thiệu</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Tuyển Dụng</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Điều Khoản</a>
                            </li>
                        </ul>
                    </div>
                    <div class="grid_colum_2_4">
                        <h3 class="name_cot_footer">Mẹo Vặt</h3>
                        <ul class="list_tung_cot_footer">
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Flash Sales</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Giao Hàng</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Kênh Người Bán</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Chương Trình Tiếp Thị Liên Kết Shopee</a>
                            </li>
                        </ul>
                    </div>
                    <div class="grid_colum_2_4">
                        <h3 class="name_cot_footer">Theo Giõi</h3>
                        <ul class="list_tung_cot_footer">
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer rieng_cot3" href="">
                                    <i class="icon_item_footer fab fa-facebook"></i>
                                    Facebook
                                </a>
                            </li>
                            <li class="list_tung_cot_item ">
                                <a class="link_item_footer rieng_cot3" href="">
                                    <i class="icon_item_footer fab fa-instagram-square"></i>
                                    Instagram
                                </a>
                            </li>
                            <li class="list_tung_cot_item ">
                                <a class="link_item_footer rieng_cot3" href="">
                                    <i class="icon_item_footer fab fa-twitter-square"></i>
                                    Twitter
                                </a>
                            </li>
                        </ul>
                    </div>
                    <div class="grid_colum_2_4">
                        <h3 class="name_cot_footer">Thanh Toán</h3>
                        <ul class="list_tung_cot_footer">
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Viettel Pay</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Zalo Pay</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">Shopee Pay</a>
                            </li>
                            <li class="list_tung_cot_item">
                                <a class="link_item_footer" href="">ATM Visa</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="phan_cuoi_cua_footer">
                <div class="grid">
                    <div class="grid__row">
                        <div class="grid_colum_4cot">
                            <a class="link_cuoi_footer" href="###">CHÍNH SÁCH BẢO MẬT</a>
                        </div>
                        <div class="grid_colum_4cot">
                            <a class="link_cuoi_footer" href="###">QUY CHẾ HOẠT ĐỘNG</>
                        </div>
                        <div class="grid_colum_4cot">
                            <a class="link_cuoi_footer" href="###">CHÍNH SÁCH VẬN CHUYỂN</a>
                        </div>
                        <div class="grid_colum_4cot">
                            <a class="link_cuoi_footer" href="###">CHÍNH SÁCH TRẢ HÀNG VÀ HOÀN TIỀN</a>
                        </div>
                    </div>
                    <p class="ten_ban_quyen">© 2021 Đình Phú Design. Tất cả các quyền được bảo lưu.</p>
                </div>
            </div>
        </footer>
    </div>
    </form>
</body>
</html>

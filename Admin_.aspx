<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_.aspx.cs" Inherits="web_ban_hang.Admin_" %>

<%@ Register Src="~/Admin/Dieu_Huong.ascx" TagPrefix="uc1" TagName="Dieu_Huong" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Admin/CSS/base_admin.css" rel="stylesheet" />
    <link href="Admin/CSS/Style.css" rel="stylesheet" />
    <link href="icon/icon_code_web/fontawesome-free-5.15.3-web/css/all.min.css" rel="stylesheet" />
    <script src="Admin/js/jquery_web.js"></script>
    <script src="Admin/js/js.js"></script>
     <!-- forn chữ-->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;500;700&display=swap" rel="stylesheet">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
             <div class="app">
        <!-- phần đầu trang -->
        <header class="PhanDauTrangAdmin">
             <div class="hien_thi_tk_dang_nhap">            
                <i class="icon_dang_xuat fas fa-user"></i>
                <h5 class="ten_admin_da_dangnhap">
                    <asp:Literal ID="list_hienThiTenTKDangNhap" runat="server"></asp:Literal></h5>
                <asp:Button CssClass="dang_xuat_admin" ID="btn_dangXuat" runat="server" Text="Đăng Xuất" OnClick="btn_dangXuat_Click" />
            </div>
            <h1 class="chao">Trang Quảng Trị WebSite</h1>
            <div class="grid">
                <nav class="Menu_Admin">
                    <ul class="DanhSach_Menu">
                        <li class="item_chuc_nang_menu">
                            <a class="link_item_menu" href="Admin_.aspx">
                                <i class="fas fa-house-user"></i>
                                Trang Chủ
                            </a>
                        </li>
                        <li class="item_chuc_nang_menu">
                            <a class="link_item_menu" href="Admin_.aspx?modul=tatcadanhmuc">
                                <i class="fas fa-folder-open"></i>
                                Danh Mục
                            </a>
                            <!-- phần hover -->
                            <ul class="list_cong_cu">
                                <li class="item_congcu">
                                    <a href="Admin_.aspx?modul=tatcadanhmuc" class="link_item_cong_cu">Tất Cả Danh Mục</a>
                                </li>
                                <li class="item_congcu">
                                    <a href="Admin_.aspx?modul=themdanhmuc" class="link_item_cong_cu">Thêm Danh Mục</a>
                                </li>
                                <li class="item_congcu">
                                    <a href="Admin_.aspx?modul=suadanhmuc" class="link_item_cong_cu">Sửa Danh Mục</a>
                                </li>
                                <li class="item_congcu">
                                    <a href="Admin_.aspx?modul=xoadanhmuc" class="link_item_cong_cu">Xoá Danh Mục</a>
                                </li>
                            </ul>
                            <!-- kết thúc phần hover -->
                        </li>
                        <li class="item_chuc_nang_menu">
                            <a class="link_item_menu" href="Admin_.aspx?modul=tatcasp">
                                <i class="fab fa-product-hunt"></i>
                                Sản Phẩm
                            </a>
                            <!-- phần hover -->
                            <div class="danh_muc_cong_cu">
                                <ul class="list_cong_cu">
                                    <li class="item_congcu">
                                        <a href="Admin_.aspx?modul=tatcasp" class="link_item_cong_cu">Tất Cả Sản Phẩm</a>
                                    </li>
                                    <li class="item_congcu">
                                        <a href="Admin_.aspx?modul=themsp" class="link_item_cong_cu">Thêm Sản Phẩm</a>
                                    </li>
                                    <li class="item_congcu">
                                        <a href="Admin_.aspx?modul=suasp" class="link_item_cong_cu">Sửa Sản Phẩm</a>
                                    </li>
                                    <li class="item_congcu">
                                        <a href="Admin_.aspx?modul=xoasp" class="link_item_cong_cu">Xoá Sản Phẩm</a>
                                    </li>
                                </ul>
                            </div>
                            <!-- kết thúc phần hover -->
                        </li>
                        <li class="item_chuc_nang_menu">
                            <a class="link_item_menu" href="Admin_.aspx?modul=hoadon">
                                <i class="fas fa-file-invoice-dollar"></i>
                               Hóa Đơn
                            </a>
                        </li>
                    </ul>
                    <a class="link_item_menu" href="Home.aspx">
                        <i class="fas fa-home"></i>
                        <i class="fas fa-hand-point-left"></i>
                        Quay Lại Trang Bán Hàng
                    </a>
                </nav>


            </div>
        </header>
        <!-- phần Nội dung -->
        <div class="PhanNoiDungTrangAdmin">
            <div class="grid">
                <!-- độ dài 1200px -->
                <uc1:Dieu_Huong runat="server" ID="Dieu_Huong" />
              
            </div>
        </div>

        <!-- phần foodter -->
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

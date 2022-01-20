<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Load_danh_muc.ascx.cs" Inherits="web_ban_hang.home.load_danh_muc.Load_damh_muc" %>

  <div class="grid_colum_2">
                        <!-- danh mục -->
                        <nav class="danh_muc">
                            <h3 class="danh_muc_vs_icon">
                                <i class="icon_danhmuc fas fa-list"></i> <!-- icon danh mục -->
                                Danh Mục
                            </h3>
                            <a class="txt_tatcasp" href="Home.aspx?modul=load_danh_muc&modulphu=tatcadanhmuc">Tất Cả Sản Phẩm</a>
                            <ul class="danh_sach_danh_muc">
                                <!-- danh sách danh mục -->
                                <!-- từng danh mục -->
                                <asp:Literal ID="list_load_danh_muc_home" runat="server"></asp:Literal>
                               
                                
                            </ul>
                        </nav>
                    </div>



 <div class="grid_colum_sp_10">
         <div class="home_noidung">
                            <!-- Nội dung__phần tìm kiếm sản phẩm -->
                            <span class="lable_sst">Sắp Xếp Theo</span>
                            <button class="home_noidung__btn btn">Phổ Biến</button>
                            <button class="home_noidung__btn btn">Mới Nhất</button>
                            <button class="home_noidung__btn btn">Bán Chạy</button>

                            <div class="sap_xep_theo_gia">
                                <span class="lable_gia">Giá</span>
                                <i class="icon_ss_gia fas fa-angle-down"></i>
                                <!-- xổ xuống khi lia vào -->
                                <ul class="bo_tro_ss_theo_gia">
                                    <li class="con_dk_ss">
                                        <a href="Home.aspx?modul=load_danh_muc&modulphu=gia_thap-cao" class="link_dieu_kien">Giá: Từ Thấp Đến Cao</a>
                                    </li>
                                    <li class="con_dk_ss">
                                        <a href="Home.aspx?modul=load_danh_muc&modulphu=gia_cao-thap" class="link_dieu_kien">Giá: Từ Cao Đến Thấp</a>
                                    </li>
                                </ul>
                            </div>

                            <!-- trang san pham -->
                            <div class="trang">
                                <span class="so_trang">
                                    <span class="so_trang__hien_tai">1</span>/14
                                </span>
                                <div class="chuyen_trang">
                                    <a href="" class="nut_chuyen_trang  nut_chuyen_trang--dautien">
                                        <i class="link__chuyen_trang fas fa-angle-left"></i>
                                    </a>
                                    <a href="" class="nut_chuyen_trang">
                                        <i class="link__chuyen_trang fas fa-angle-right"></i>
                                    </a>
                                </div>
                            </div>
                        </div>
         <!--phần load sản phẩm -->
     <asp:PlaceHolder ID="dieu_huong_danhmuc" runat="server"></asp:PlaceHolder>
         <!--end phần load sản phẩm -->
        
 </div>
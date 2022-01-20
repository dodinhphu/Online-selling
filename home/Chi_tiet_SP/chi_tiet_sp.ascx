<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="chi_tiet_sp.ascx.cs" Inherits="web_ban_hang.home.Chi_tiet_SP.chi_tiet_sp" %>



  <div class="all_sp_chitiet">
        <div class="toan_bo_hien_thi_sp">
           
                            
                                
                                <asp:Literal ID="list_anh" runat="server"></asp:Literal>
                           
                            <div class="grid_colum_sp_6">
                                <h2 class="ten_sp_chitiet"><asp:Literal ID="list_tensp" runat="server"></asp:Literal>
                                </h2>
                                <div class="Khung_gia">
                                    <h1 class="gia_sp_chiTiet"><asp:Literal ID="list_giasp" runat="server"></asp:Literal>đ</h1>
                                </div>
                                <div class="khung_van_chuyen">
                                    <span class="txt_van_chuyen">Vận Chuyển</span>
                                    <ul class="list_chuc_nang_vc">
                                        <li class="chuc_nang_vc">
                                            <i class="icon_vanchuyen fab fa-freebsd"></i>
                                            Miễn Phí Vận Chuyển
                                        </li>
                                        <li class="chuc_nang_vc">
                                            <i class="icon_vanchuyen fas fa-shipping-fast"></i>
                                            Vận Chuyển Mọi Nơi, Nhanh Chóng, An Toàn
                                        </li>
                                        <li class="chuc_nang_vc">
                                            <i class="icon_vanchuyen fas fa-people-carry"></i>
                                            Nhân Viên Nhiệt Tình, Có Trách Nhiệm
                                        </li>
                                    </ul>
                                </div>
                                  <div class="khung_sl_ctsp">
                                    <span class="txt_sl_ctsp">Số Lượng</span>
                                    <asp:TextBox runat="server" min="1" value="1" TextMode="Number"  class="sl_sp_mua"  ID="txt_soluong"></asp:TextBox>
                                </div>
                                <div class="btn_chuc_nang">
                                    <a class="btn_ctsp Them" href="javascript:themvaogiohang()">
                                        <i class="icon_btn fas fa-cart-plus"></i>
                                        Thêm Vào Giỏ Hàng
                                    </a>
                                    <a class="btn_ctsp mua_ngay" href="javascript:muangay()">
                                        Mua Ngay
                                    </a>
                                </div>
                                <div class="tt_bao_hanh">
                                    <div class="cot_bao_hanh">
                                        <i class="icon_baohanh fas fa-undo-alt"></i>
                                        <span class="txt_baoHanh">
                                            7 ngày miễn phí trả hàng
                                        </span>
                                    </div>
                                    <div class="cot_bao_hanh">
                                        <i class="icon_baohanh fas fa-user-shield"></i>
                                        <span class="txt_baoHanh">
                                            Hàng chính hãng 100%
                                        </span>
                                    </div>
                                    <div class="cot_bao_hanh">
                                        <i class="icon_baohanh fas fa-user-check"></i>
                                        <span class="txt_baoHanh">
                                            Kiểm Tra Hàng Trước Khi Thanh Toán
                                        </span>
                                    </div>
                                </div>

                            </div>
                        </div>
          <div class="mo_ta_sp">
                            <h2 class="txt_mota">Mô Tả Sản Phẩm</h2>
                            <div class="noi_dung_mota">
                                <p class="txt_noi_dung_mota">
                                  <asp:Literal ID="list_mota" runat="server"></asp:Literal>
                                </p>
                            </div>
                        </div>    
  </div>
  

<script type="text/javascript">
    function themvaogiohang() {
        var id = "<%=id%>";
        var soluong = $(".sl_sp_mua").val();

        $.post("home/ajax/thao_tac_them_vao_gio_hang.aspx",
            {
                "thaotac": "themvaogiohang",
                "id": id,
                "soluong": soluong
            },

            function (data, status) {

                if (data == "") {
                    alert("Đã Thêm Sản Phẩm Vào Giỏ Thành Công");
                }
                else {
                    alert(data);
                }
            });
    }



    function muangay() {
        var id = "<%=id%>";
        var soluong = $(".sl_sp_mua").val();

        $.post("home/ajax/thao_tac_them_vao_gio_hang.aspx",
            {
                "thaotac": "themvaogiohang",
                "id": id,
                "soluong": soluong
            },

            function (data, status) {

                if (data == "") {
                    alert("Đã Thêm Sản Phẩm Vào Giỏ Thành Công");
                    location.href = "Home.aspx?modul=giohang";
                }
                else {
                    alert(data);
                }
            });
    }
</script>

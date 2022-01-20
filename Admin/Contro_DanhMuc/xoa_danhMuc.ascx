<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="xoa_danhMuc.ascx.cs" Inherits="web_ban_hang.Admin.Contro_DanhMuc.xoa_danhMuc" %>

 <div class="Tong_noi_dung_page_xoa_DanhMuc">
              <asp:Label  CssClass="hide" ID="lb_tb" runat="server" Text=""></asp:Label>
                 <h2 class="txt_tensp">Xóa Danh Mục</h2>
                    <div class="tim_kiem_sp_xoa">
                        <h2 class="txt_moi_nhap">Tìm Kiếm Danh Mục Cần Xóa</h2>
                        <asp:TextBox class="txt_masp_can_xoa" ID="txt_tk_DanhMuc" runat="server"></asp:TextBox>
                        <asp:Button class="btn_tkXoa" ID="btn_tkDanhMuc" runat="server" Text="Tìm Kiếm" OnClick="btn_tkDanhMuc_Click" />
                    </div>
                    <div class="Hien_thi_spXoa">
                        <div class="table_hienthi">
                            <table class="table">
                             <tr class="cot_table">
                                <th class="ten_cot_table cot_Ma_danh_muc">Mã Danh Mục</th>
                                <th class="ten_cot_table cot_ten_danh_muc">Tên Danh Mục</th>
                                <th class="ten_cot_table cot_tong_so_sp">Tổng Số Sản Phẩm</th>
                            </tr>
                                <asp:Literal ID="list_dm_timkiem" runat="server"></asp:Literal>
                            </table>
                        </div>                   
                    </div>
                    <div class="btn_xoa">
                        <asp:Button  class="btn btn_xoa_xoa" ID="btn_xoaDanhMuc" runat="server" Text="Xóa" OnClick="Button1_Click" />
                        <asp:Button class="btn btn_xoa_huy" ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click" />
                    </div>  
                </div>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="xoa_sp.ascx.cs" Inherits="web_ban_hang.Admin.Contro_SP.xoa_sp" %>

<div class="Tong_noi_dung_page_xoa">
                      <asp:Label  CssClass="hide" ID="lb_tb" runat="server" Text=""></asp:Label>
                    <h2 class="txt_tensp">Xóa Sản Phẩm</h2>
                    <div class="tim_kiem_sp_xoa">
                        <h2 class="txt_moi_nhap">Tìm Kiếm Sản Phẩm Cần Xóa</h2>
                        <asp:TextBox class="txt_masp_can_xoa" ID="txt_tk_SP" runat="server"></asp:TextBox>
                        <asp:Button class="btn_tkXoa" ID="btn_tk_sp" runat="server" Text="Tìm Kiếm" OnClick="btn_tk_sp_Click" />
                    </div>
                    <div class="Hien_thi_spXoa">
                        <div class="table_hienthi">
                            <table class="table">
                                <tr class="cot_table">
           
                                    <th class="ten_cot_table cot_masp">Mã Sản Phẩm</th>
                                    <th class="ten_cot_table cot_tensp">Tên Sản Phẩm</th>
                                    <th class="ten_cot_table cot_tenLoai">Loại</th>
                                     <th class="ten_cot_table cot_ngaythem">Ngày Thêm</th>
                                    <th class="ten_cot_table cot_tenDonGia">Đơn Giá</th>
                                    <th class="ten_cot_table cot_tenSoLuong">Số Lượng</th>
                                    <th class="ten_cot_table cot_tenHinhanh">Hình Ảnh</th>
                                </tr>
                                <asp:Literal ID="list_sp_tim" runat="server"></asp:Literal>
                            </table>
                        </div>                   
                    </div>
                    <div class="btn_xoa">
                        <asp:Button class="btn btn_xoa_xoa" ID="btn_xoa_sp" runat="server" Text="Xóa" OnClick="btn_xoa_sp_Click1" />
                       <asp:Button class="btn btn_xoa_huy" ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click" />
                    </div>  
                </div>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="hoa_don_chi_tiet.ascx.cs" Inherits="web_ban_hang.Admin.conTro_HoaDon.hoa_don_chi_tiet" %>

  <div class="Tong_noi_dung_page_danhmuc">
                    <h2 class="txt_tat_ca_dm">Chi Tiết Hóa Đơn Số <asp:Literal ID="list_sohoadon" runat="server"></asp:Literal> </h2>
      
                    <div class="table_hienthi">
                        <table class="table">
                            <tr class="cot_table">
                                <th class="ten_cot_table ">Mã Sản Phẩm</th>
                                <th class="ten_cot_table ">Số Lượng</th>
                                <th class="ten_cot_table ">Đơn Giá</th>
                                <th class="ten_cot_table ">Tình Trạng</th>
                            </tr>
                            <asp:Literal ID="list_hoadonchitiet" runat="server"></asp:Literal>
                        </table>
                    </div>
                </div>
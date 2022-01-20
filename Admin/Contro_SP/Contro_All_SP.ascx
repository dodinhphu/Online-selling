<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Contro_All_SP.ascx.cs" Inherits="web_ban_hang.Admin.Contro_SP.Contro_All_SP" %>

  <div class="all_noi_dung_pagesp">
                     <h2 class="txt_tensp">Tất Cả Sảm Phẩm</h2>
                    <div class="table_hienthi">
                        <table class="table">
                            <tr class="cot_table">
                                <th class="ten_cot_table cot_tencongcu">Công Cụ</th>
                                <th class="ten_cot_table cot_masp">Mã Sản Phẩm</th>
                                <th class="ten_cot_table cot_tensp">Tên Sản Phẩm</th>
                                <th class="ten_cot_table cot_tenLoai">Loại</th>
                                <th class="ten_cot_table cot_ngaythem">Ngày Thêm</th>
                                <th class="ten_cot_table cot_tenDonGia">Đơn Giá</th>
                                <th class="ten_cot_table cot_tenSoLuong">Số Lượng</th>
                                <th class="ten_cot_table cot_tenHinhanh">Hình Ảnh</th>
                            </tr>
                            <asp:Literal ID="list_sp" runat="server"></asp:Literal>
                        </table>
                    </div>

                </div>
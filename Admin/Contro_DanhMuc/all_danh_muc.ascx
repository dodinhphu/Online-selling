<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="all_danh_muc.ascx.cs" Inherits="web_ban_hang.Admin.Contro_DanhMuc.all_danh_muc" %>

<div class="Tong_noi_dung_page_danhmuc">       
                  <h2 class="txt_tensp">Tất Cả Danh Mục</h2>
                    <div class="table_hienthi">
                        <table class="table">
                            <tr class="cot_table">
                                <th class="ten_cot_table cot_tencongcu">Công Cụ</th>
                                <th class="ten_cot_table cot_Ma_danh_muc">Mã Danh Mục</th>
                                <th class="ten_cot_table cot_ten_danh_muc">Tên Danh Mục</th>
                                <th class="ten_cot_table cot_tong_so_sp">Tổng Số Sản Phẩm</th>
                               
                            </tr>
                             <asp:Literal ID="list_load_danhMuc" runat="server"></asp:Literal>
                              <!--  load du liệu-->
                        </table>
                    </div>



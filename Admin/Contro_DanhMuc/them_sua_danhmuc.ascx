<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="them_sua_danhmuc.ascx.cs" Inherits="web_ban_hang.Admin.Contro_DanhMuc.them_sua_danhmuc" %>

   
<asp:Label  CssClass="hide" ID="lb_tb" runat="server" Text=""></asp:Label>
 <div class="Tong_noi_dung_page_sua-them_danh_muc" >        
                    <div class="tong_trang_themmoiSP">
                        <h2 class="txt_tensp"  runat="server" id="h2_txt_tensp">Thêm Mới Danh Mục</h2>
                        <div class="tong_nhap">
                            <ul class="list_cac_thamso">
                                <li class="ten_cac_thamSo"><span class="the_span">Mã Danh Mục</span>
                                    <asp:TextBox ID="txt_madanhmuc" CssClass="theinput" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_madanhmuc" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True" ValidationGroup="truhuy">*</asp:RequiredFieldValidator>
                                <li class="ten_cac_thamSo"><span class="the_span">Tên Danh Mục</span>
                                    <asp:TextBox ID="txt_tendanhmuc" CssClass="theinput" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_tendanhmuc" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True" ValidationGroup="truhuy">*</asp:RequiredFieldValidator>
                                </li>
                            </ul>
                        </div>
                        <div class="nut_bam_themdm  nut_bam">
                            <asp:Button CssClass="btn" ID="btn_themDanhMuc" runat="server" Text="Thêm" OnClick="btn_themDanhMuc_Click" ValidationGroup="truhuy" />
                            <asp:Button CssClass="btn" ID="btn_huyDanhMuc" runat="server" Text="Hủy" OnClick="btn_huyDanhMuc_Click" />
                        </div>
                    </div>
             </div>

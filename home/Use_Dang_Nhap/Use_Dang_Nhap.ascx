<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Use_Dang_Nhap.ascx.cs" Inherits="web_ban_hang.home.Use_Dang_Nhap.Use_Dang_Nhap" %>

   <div class="_form_dang_nhap_user" >
                        <div class="xung_qanh_form">
                            
                            <asp:Label class="hide" ID="lb_tb" runat="server" Text="Label"></asp:Label>
                            <h2 class="txt_dangKy_TK">Đăng Nhập</h2>
                            <ul class="danh_sach_thong_tin">
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> User Name</span>
                                   <asp:TextBox class="ip_thong_tin_kh" ID="txt_tk" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txt_tk" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </li>
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> PassWord</span>
                                    <asp:TextBox class="ip_thong_tin_kh" ID="txt_mk" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txt_tk" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </li>                             
                            </ul>
                            <div class="btn_dk_nguoidung">
                                <asp:Button  class="btn_dangnhap_user" ID="btn_dangnhap" runat="server" Text="Đăng Nhập" OnClick="btn_dangnhap_Click" />
                               <asp:Button  class="btn_dangnhap_user" ID="btn_huy" runat="server" Text="Hủy" ValidationGroup="huuuu" OnClick="btn_huy_Click" />
                            </div>
                        
                        </div>
                    </div>
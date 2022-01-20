<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Use_dang_ky.ascx.cs" Inherits="web_ban_hang.home.Use_Dang_Ky.Use_dang_ky" %>

<div class="_form_dang_ky" >
                        <div class="xung_qanh_form">
                             <asp:Label class="hide" ID="tb" runat="server" Text="Label"></asp:Label>
                            <h2 class="txt_dangKy_TK"><asp:Literal ID="list_tieu_de" runat="server"></asp:Literal></h2>
                            <ul class="danh_sach_thong_tin">
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> User Name</span>
                                   <asp:TextBox class="ip_thong_tin_kh" ID="txt_userName" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_userName" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                                </li>

                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> PassWord</span>
                                  <asp:TextBox class="ip_thong_tin_kh" ID="txt_passwword" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_passwword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </li>
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> Nhập Lại</span>
                                  <asp:TextBox class="ip_thong_tin_kh" ID="txt_passkt" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_passkt" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_passkt" ControlToValidate="txt_passwword" ErrorMessage="CompareValidator" ForeColor="Red">*</asp:CompareValidator>
                                </li>
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> Họ Và Tên</span>
                                    <asp:TextBox class="ip_thong_tin_kh" ID="txt_hoten" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_hoten" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </li>
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> Địa chỉ</span>
                                  <asp:TextBox class="ip_thong_tin_kh" ID="txt_diachi" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_diachi" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </li>
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> Email</span>
                                   <asp:TextBox class="ip_thong_tin_kh" ID="txt_mail" runat="server"></asp:TextBox>
                                </li>
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> Số Điện Thoại</span>
                                    <asp:TextBox class="ip_thong_tin_kh" ID="txt_sdt" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_sdt" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                               
                                </li>
                                <li class="cat_dong_tong_tin">
                                    <span class="txt_thong_tin"> Ngày Sinh</span>
                                    <asp:TextBox class="ip_thong_tin_kh" ID="txt_ngaysinh" runat="server"></asp:TextBox>
                                </li>
                            </ul>
                            <div class="btn_dk_nguoidung">
                                
                                <asp:Button class="btn_themtk_user" ID="Txt_tao_user" runat="server" Text="Tạo" OnClick="Txt_tao_user_Click" />
                             <asp:Button class="btn_themtk_user" ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click" ValidationGroup="huy" />
                            </div>
                         
                        </div>
                    </div>
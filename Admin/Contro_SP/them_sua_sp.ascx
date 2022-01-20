<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="them_sua_sp.ascx.cs" Inherits="web_ban_hang.Admin.Contro_SP.them_sua_sp" %>




 <div class="tong_trang_themmoiSP">
                   <asp:Label CssClass="hide" ID="lb_tb" runat="server" Text="Label"></asp:Label>     
                     <asp:Literal ID="list_hienthitb" runat="server"></asp:Literal>            
                    <div class="tong_nhap">
                        <ul class="list_cac_thamso">
                            <li class="ten_cac_thamSo"><span class="the_span">Mã Sản Phẩm</span>
                                <asp:TextBox class="theinput" ID="txt_masp" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_masp" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Tên Sản Phẩm</span>
                                <asp:TextBox class="theinput" ID="txt_tensp" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_tensp" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Loại Sản Phẩm</span>
                                <asp:DropDownList  class="theinput" ID="lis_danhmuc" runat="server"></asp:DropDownList>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Địa Chỉ Shop</span>
                                <asp:TextBox  class="theinput" ID="txt_diachishop" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_diachishop" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Thương Hiệu</span>
                                <asp:TextBox  class="theinput" ID="txt_thuonghieu" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_thuonghieu" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Đơn Giá</span>
                                <asp:TextBox  class="theinput" ID="txt_dongia" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_dongia" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txt_dongia" ErrorMessage="RangeValidator" ForeColor="Red" Type="Double">*</asp:RangeValidator>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Số Lượng Trong Kho</span>
                                <asp:TextBox  class="theinput" ID="txt_soluong" runat="server" TextMode="Number" minvalue="1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_soluong" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Hình Ảnh</span>
                                <!-- bỏ bt vào -->
                                <asp:FileUpload CssClass="btn_upload" ID="up_anh" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="up_anh" ErrorMessage="RequiredFieldValidator" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Ngày Thêm</span>
                                <asp:TextBox  class="theinput" ID="txt_ngayThem" runat="server" TextMode="DateTime"></asp:TextBox>
                            </li>
                            <li class="ten_cac_thamSo"><span class="the_span">Mô Tả</span>
                                <asp:TextBox ID="txt_mota" CssClass="theinput vanban" runat="server"  TextMode="MultiLine"></asp:TextBox>
                            </li>

                        </ul>
                    </div>
                    <div class="nut_bam">
                       <asp:Button  class="btn Thêm" ID="btn_them" runat="server" Text="thêm" OnClick="btn_them_Click"  />
                       <asp:Button class="btn Hủy" ID="btn_huy" runat="server" Text="Hủy" OnClick="btn_huy_Click" ValidationGroup="huy" />
                    </div>
                </div>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web_ban_hang.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>
    <link href="Admin/CSS/css_dang_nhap.css" rel="stylesheet" />
    <link href="icon/icon_code_web/fontawesome-free-5.15.3-web/css/all.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
             <div class="app">
                <div class="backgroud" style="background: url(/admin/css/main-background1.jpg)">
                    <div class="form">
                          <a class="trovetrangchu" href="Home.aspx"><i class="fas fa-home"></i></a>
                        <div class="tieude">
                          
                            <h1>Đăng Nhập</h1>
                        </div>
                        <div class="tai_khoan">
                            <i class="icon fas fa-user"></i>
                            <asp:TextBox  placeholder="UserName"  class="txt" ID="txt_tendangnhap" runat="server"></asp:TextBox>

                        </div>
                        <div class="mat_nhau">
                            <i class="icon fas fa-lock"></i>
                            <asp:TextBox  placeholder="PassWord"  class="txt" ID="txt_matkhau" runat="server" TextMode="Password"></asp:TextBox>

                        </div>
                        <div class="btn_dangNhap">
                        <asp:Button  class="btn_dang_nhap_admin" ID="btn_dangnhap" runat="server" Text="Đăng Nhập" OnClick="btn_dangnhap_Click" />                            
                        </div>
                         
                         <asp:Literal ID="list_tb" runat="server"></asp:Literal>            
                    </div>
                </div>
          </div>
    </form>
</body>
</html>


<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Gio_hang.ascx.cs" Inherits="web_ban_hang.home.Gio_hang.Gio_hang" %>

  <div class="all_gio_hang noi_dung_load">

  </div>


<script type="text/javascript">
    function laythongtingiohang() {

        $.post("home/ajax/thao_tac_them_vao_gio_hang.aspx",
            {
                "thaotac": "laythongtingiohang"
                
            },

            function (data, status) {

                if (data != null) {
                   
                    $(".noi_dung_load").html(data);
                }
            });
    }

    function tong_tien() {
        $.post("home/ajax/thao_tac_them_vao_gio_hang.aspx",
            {
                "thaotac": "tong_tien",
            },
            function (data, status) {
                $(".txt_tong_tien").html("Tổng Tiền: "+data+"đ");
            });
    }

    $(document)
        .ready(function () {
            laythongtingiohang();
            tong_tien();
        });

    function xoa_sp_giohang(ma) {
        if (confirm("Bạn Chắc Chắn Muốn Xóa " + ma + " Ra Khỏi Giỏ Hàng ?")) {

            $.post("home/ajax/thao_tac_them_vao_gio_hang.aspx",
                {
                    "thaotac": "xoa_sp_giohang",
                    "ma": ma
                },
                function (data, status) {

                    if (data == "") {
                        $("#madong_" + ma).remove();
                        tong_tien();
                    }
                    else {
                        alert("Xóa Không Thầy Công !");
                    }
                });
        }
    }
  
    // đặt hàng
    function dat_hang() {
        if ($(".tenkh").val() !== "" && $(".diachikhachhang").val() !== "" && $(".sodienthoai").val() !== "" && $(".email").val() !== "") {

            $.post("home/ajax/thao_tac_them_vao_gio_hang.aspx",
                {
                    "thaotac": "dat_hang",
                    "makh": $(".makh").val(),
                    "hoten": $(".tenkh").val(),
                    "diachi": $(".diachikhachhang").val(),
                    "sdt": $(".sodienthoai").val(),
                    "email": $(".email").val()
                },
                function (data, status) {
                    if (data == "") {
                        alert("Bạn Đã Đặt Hàng Thành Công !");
                        location.href="home.aspx";
                    }
                    else {
                        alert("Xóa Không Thầy Công !");
                    }
                });
        }
        else {
            alert("Trống");
        }
    }
</script>





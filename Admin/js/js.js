
function xoadanhmuc(ma) {
    if (confirm("Bạn Chắc Chắn Muốn Xóa Danh Mục " + ma+" ?")) {

            $.post("Admin/ajax/thao_tac_DanhMuc.aspx",
                {
                    "thaotac": "xoadanhmuc",
                    "ma": ma
                },
                function (data, status) {
                  
                    if (data == "1") {
                        $("#madong_" + ma).remove();
                    }
                    else {
                        alert("Danh Muc Này Đang Chứa Sản Phẩm !!, Hãy Xóa Hết Sản Phẩm Trong Danh Mục Để Xóa Danh Mục Này");
                    }
                });
        }
    }
function xoasanpham(ma) {
    if (confirm("Bạn Chắc Chắn Muốn Xóa Sản Phẩm " + ma+" ?")) {

        $.post("Admin/ajax/thao_tac_SanPham.aspx",
            {
                "thaotac": "xoasanpham",
                "ma": ma
            },
            function (data, status) {

                if (data == "1") {
                    $("#madong_" + ma).remove();
                }
                else {
                    alert("Xáo Không Thành Công!");
                }
            });
    }
}


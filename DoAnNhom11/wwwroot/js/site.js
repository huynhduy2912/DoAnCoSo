// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var currentPage = 0;
var currentBrandId = 0;
var currentCategoryId = 0;
function activateLink(link) {
    var links = document.querySelectorAll('a');
    links.forEach(function (item) {
        item.classList.remove('active');
    });
    link.classList.add('active');
}
function getProductsByCategory(CategoryId) {
    currentCategoryId = CategoryId;
    currentPage = 1;
    $("#myButton").remove();
    $.ajax({
        type: "GET",
        url: '/Products/GetProductsByCategory?categoryId=' + CategoryId + '&page=' + currentPage,
        success: function (data) {
            $('#productContainer').html(data);
            $(".pagination").hide();
            $('#paginationContainer').append('<button id="myButton" type="button" onclick="getProductsByCategoryAndPage(1)" class="btn btn - fefault cart">Xem thêm</button >');
        },
        error: function () {
            alert("lỗi");
        }
    });
}
function getProductsByBrand(BrandId) {
    currentBrandId = BrandId;
    currentPage = 1;
    $("#myButton").remove();
    $.ajax({
        type: "GET",
        url: '/Products/GetProductsByBrand?brandId=' + BrandId + '&page=' + currentPage,
        success: function (data) {
            $('#productContainer').html(data);
            $(".pagination").hide();
            $('#paginationContainer').append('<button id="myButton" type="button" onclick="getProductsByBrandAndPage(1)" class="btn btn - fefault cart">Xem thêm</button >');
        },
        error: function () {
            alert("lỗi");
        }
    });
} function getProductsByBrandAndPage() {
    currentPage++;
    $("#myButton").remove();
    $.ajax({
        type: "GET",
        url: '/Products/GetProductsByBrand?brandId=' + currentBrandId + '&page=' + currentPage,
        success: function (data) {
            if (data != '') {
                $('#productContainer').append(data);
                $('#paginationContainer').append('<button id="myButton" type="button" onclick="getProductsByBrandAndPage(' + currentBrandId + ')" class="btn btn - fefault cart">Xem thêm</button >');
            }
            else {
                alert("Đã xem hết sản phẩm");
            }
        },
        error: function () {
            alert("lỗi");
        }
    });
}
function getProductsByCategoryAndPage() {
    currentPage++;
    $("#myButton").remove();
    $.ajax({
        type: "GET",
        url: '/Products/GetProductsByCategory?categoryId=' + currentCategoryId + '&page=' + currentPage,
        success: function (data) {
            if (data != '') {
                $('#productContainer').append(data);
                $('#paginationContainer').append('<button id="myButton" type="button" onclick="getProductsByCategoryAndPage(' + currentBrandId + ')" class="btn btn - fefault cart">Xem thêm</button >');

            }
            else {
                alert("Đã xem hết sản phẩm");
            }
        },
        error: function () {
            alert("lỗi");
        }
    });
}
function formatCurrency(number) {
    var formattedNumber = number.toLocaleString('vi-VN');

    formattedNumber += ' ₫';

    return formattedNumber;
}
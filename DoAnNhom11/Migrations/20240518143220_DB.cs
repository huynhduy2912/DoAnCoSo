using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoAnNhom11.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhanHieu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    OrderStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.OrderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "ShopCategories",
                columns: table => new
                {
                    ShopCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCategories", x => x.ShopCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "VoucherCategory",
                columns: table => new
                {
                    VoucherCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherCategory", x => x.VoucherCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCuaHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LienHe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnhBia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                    table.ForeignKey(
                        name: "FK_Shops_ShopCategories_ShopCategoryId",
                        column: x => x.ShopCategoryId,
                        principalTable: "ShopCategories",
                        principalColumn: "ShopCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    VoucherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongCon = table.Column<int>(type: "int", nullable: false),
                    VoucherCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherId);
                    table.ForeignKey(
                        name: "FK_Vouchers_VoucherCategory_VoucherCategoryId",
                        column: x => x.VoucherCategoryId,
                        principalTable: "VoucherCategory",
                        principalColumn: "VoucherCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "ShopId");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThongSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongCon = table.Column<int>(type: "int", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: true),
                    DiemDanhGia = table.Column<int>(type: "int", nullable: true),
                    DaAn = table.Column<bool>(type: "bit", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ShopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "Categories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    OrderStatusId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "OrderStatusId");
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "PaymentId");
                    table.ForeignKey(
                        name: "FK_Orders_Vouchers_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Vouchers",
                        principalColumn: "VoucherId");
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    ProductImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.ProductImageId);
                    table.ForeignKey(
                        name: "FK_ProductImage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemDanhGia = table.Column<int>(type: "int", nullable: true),
                    ThoiGianDanhGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewsId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsReview = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewsImage",
                columns: table => new
                {
                    ReviewsImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewsImage", x => x.ReviewsImageId);
                    table.ForeignKey(
                        name: "FK_ReviewsImage_Reviews_ReviewsId",
                        column: x => x.ReviewsId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", null, "Customer", "CUSTOMER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", null, "ShopOwner", "SHOPOWNER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7213", null, "ShopStaff", "SHOPSTAFF" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "TenNhanHieu" },
                values: new object[,]
                {
                    { 1, "XiaoMi" },
                    { 2, "Apple" },
                    { 3, "Samsung" },
                    { 4, "Dell" },
                    { 5, "HP" },
                    { 6, "Nokia" },
                    { 7, "ASUS" },
                    { 8, "MSI" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ProductCategoryId", "AnhDaiDien", "TenLoai" },
                values: new object[,]
                {
                    { 1, "/categoryImg/balotuivi.png", "Balo & Túi Ví" },
                    { 2, "/categoryImg/dienthoai.png", "Điện Thoại" },
                    { 3, "/categoryImg/dientu.png", "Điện tử" },
                    { 4, "/categoryImg/doan.png", "Thực phẩm" },
                    { 5, "/categoryImg/dobep.png", "Đồ bếp" },
                    { 6, "/categoryImg/dochoi.png", "Đồ chơi" },
                    { 7, "/categoryImg/dongho.png", "Đồng hồ" },
                    { 8, "/categoryImg/giadung.png", "Đồ gia dụng" },
                    { 9, "/categoryImg/giaydepnam.png", "Giày dép nam" },
                    { 10, "/categoryImg/giaydepnu.png", "Giày dép nữ" },
                    { 11, "/categoryImg/mayanh.png", "Máy Ảnh" },
                    { 12, "/categoryImg/maytinh.png", "Máy tính" },
                    { 13, "/categoryImg/noitro.png", "Đồ nội trợ" },
                    { 14, "/categoryImg/phuongtien.png", "Phương tiện" },
                    { 15, "/categoryImg/sacdep.png", "Sắc đẹp" },
                    { 16, "/categoryImg/sach.png", "Sách" },
                    { 17, "/categoryImg/thethao.png", "Thể thao" },
                    { 18, "/categoryImg/thietbi.png", "Thiết bị" },
                    { 19, "/categoryImg/thoitrangnam.png", "Thời trang nam" },
                    { 20, "/categoryImg/thoitrangnu.png", "Thời trang nữ" },
                    { 21, "/categoryImg/thoitrangtreem.png", "Thời trang trẻ em" },
                    { 22, "/categoryImg/thucung'.png", "Thú cưng" },
                    { 23, "/categoryImg/trangsuc.png", "Trang sức" },
                    { 24, "/categoryImg/treem.png", "Trẻ em" },
                    { 25, "/categoryImg/tuivinu.png", "Túi Ví Nữ" },
                    { 26, "/categoryImg/voucherdichvu.png", "Dịch vụ" },
                    { 27, "/categoryImg/yte.png", "Y tế" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "OrderStatusId", "TenTrangThai" },
                values: new object[,]
                {
                    { 1, "Chờ Xác Nhận Đơn Hàng" },
                    { 2, "Đã Xác Nhận Đơn Hàng" },
                    { 3, "Đang Giao Hàng" },
                    { 4, "Đã Giao Hàng" },
                    { 5, "Đã Đã Thanh Toán Và Nhận Hàng" },
                    { 6, "Đã Hủy Đơn" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "TenLoai" },
                values: new object[,]
                {
                    { 1, "Trực Tiếp" },
                    { 2, "Online" }
                });

            migrationBuilder.InsertData(
                table: "ShopCategories",
                columns: new[] { "ShopCategoryId", "TenLoai" },
                values: new object[,]
                {
                    { 1, "Công Nghệ" },
                    { 2, "Thời Trang" },
                    { 3, "Trang Sức" },
                    { 4, "Thực Phẩm" },
                    { 5, "Sách" },
                    { 6, "Làm Đẹp" },
                    { 7, "Đồ Chơi" },
                    { 8, "Đồ Gia Dụng" }
                });

            migrationBuilder.InsertData(
                table: "VoucherCategory",
                columns: new[] { "VoucherCategoryId", "TenLoai" },
                values: new object[,]
                {
                    { 1, "GIAMGIAXIAOMI" },
                    { 2, "GIAMGIADELL" },
                    { 3, "GIAMGIALAPTOP" },
                    { 4, "GIAMGIAMAYTINHBANG" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "AnhBia", "AnhDaiDien", "DiaChi", "LienHe", "MoTa", "NgayTao", "ShopCategoryId", "TenCuaHang" },
                values: new object[,]
                {
                    { 1, "/images/device (136).png", "/images/device (1).png", "gZ80795kKn,egvcz1KvXZ,KJnLp2Dslm", "cPctHxijQU", "Mô tả mẫu của sản phẩm2", new DateTime(2024, 5, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9438), 6, "Shop:uq6RWu9h9L1" },
                    { 2, "/images/device (141).png", "/images/device (98).png", "TJ2uV5bzsc,RzRdp7BMjB,bwbqiFU654", "VkElDFKWmS", "Mô tả mẫu của cửa hàng3", new DateTime(2024, 5, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9464), 2, "ShopOugo6S4CdP2" },
                    { 3, "/images/device (199).png", "/images/device (82).png", "PlwqoNq3dA,qfUobJJNvr,AC8Psr1KmF", "ri73eyCsWs", "Mô tả mẫu của sản phẩm4", new DateTime(2024, 5, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9485), 7, "Shop:Ww6LiF4X833" },
                    { 4, "/images/device (19).png", "/images/device (62).png", "951Ol6HiKZ,s5gjsP0Or0,Ky5P6LzCHZ", "oIXq086Z5X", "Mô tả mẫu của sản phẩm5", new DateTime(2024, 5, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9505), 7, "Shop:JWT1nWtkFP4" },
                    { 5, "/images/device (152).png", "/images/device (5).png", "zwMy7GDXZ6,C7aCYREPfW,Fxt4MzM3Tt", "uo1FdVz0H6", "Mô tả mẫu của sản phẩm6", new DateTime(2024, 5, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9521), 5, "Shop:sdbVLbO72W5" },
                    { 6, "/images/device (237).png", "/images/device (208).png", "oH3ROlDyyl,pzbWD2IIVO,G5AhgbORp1", "oy0QgZiITi", "Mô tả mẫu của sản phẩm7", new DateTime(2024, 5, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9602), 2, "Shop:ccPfJOn3Ct6" },
                    { 7, "/images/device (119).png", "/images/device (205).png", "vO3at4Fl4u,H2cEGsXVUm,xn4wXgUmQY", "1MDFrTL9Er", "Mô tả mẫu của sản phẩm8", new DateTime(2024, 5, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9621), 2, "Shop:Ew3KgPsGLk7" },
                    { 8, "/images/device (248).png", "/images/device (262).png", "hjrzkm6czR,jkOgWh3ENQ,M5XAeMayxk", "fT8XqQUqcH", "Mô tả mẫu của sản phẩm9", new DateTime(2024, 5, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9642), 6, "Shop:NBrERbJFRv8" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "VoucherId", "NgayHetHan", "PhanTramGiam", "SoLuongCon", "VoucherCategoryId", "VoucherCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9318), 20, 100, 1, "GIAMGIA1" },
                    { 2, new DateTime(2024, 7, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9346), 10, 100, 2, "GIAMGIA2" },
                    { 3, new DateTime(2024, 7, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9349), 15, 100, 3, "GIAMGIA3" },
                    { 4, new DateTime(2024, 7, 18, 21, 32, 19, 719, DateTimeKind.Local).AddTicks(9350), 12, 100, 4, "GIAMGIA4" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AnhDaiDien", "BrandId", "DaAn", "DiemDanhGia", "GiaBan", "GiaNhap", "MoTa", "PhanTramGiam", "ProductCategoryId", "ShopId", "SoLuongCon", "TenSp", "ThongSo" },
                values: new object[,]
                {
                    { 1, "/images/device (239).png", 5, false, null, 4000000m, 7000000m, "Mô tả mẫu của sản phẩm1", 35, 5, 5, 200, "U6iWSsNeZg1", "RAM:300GB Man hinh :16inch" },
                    { 2, "/images/device (242).png", 8, false, null, 29000000m, 16000000m, "Mô tả mẫu của sản phẩm2", 30, 6, 4, 100, "0sXsHMJt7i2", "RAM:20Memory:39GB Man hinh :12inch" },
                    { 3, "/images/device (24).png", 5, false, null, 8000000m, 14000000m, "Mô tả mẫu của sản phẩm3", 32, 4, 2, 100, "WLTaCXKnJI3", "RAM:17Memory:293GB Man hinh :8inch" },
                    { 4, "/images/device (225).png", 2, false, null, 7000000m, 44000000m, "Mô tả mẫu của sản phẩm4", 38, 3, 2, 300, "7Oj2YSTbJn4", "RAM:14Memory:510GB Man hinh :16inch" },
                    { 5, "/images/device (112).png", 3, false, null, 4000000m, 10000000m, "Mô tả mẫu của sản phẩm5", 29, 8, 8, 200, "1eD8zt3TL25", "RAM:9Memory:477GB Man hinh :4inch" },
                    { 6, "/images/device (5).png", 2, false, null, 11000000m, 37000000m, "Mô tả mẫu của sản phẩm6", 38, 3, 6, 100, "2QyXLEtR626", "RAM:6Memory:127GB Man hinh :12inch" },
                    { 7, "/images/device (46).png", 7, false, null, 40000000m, 3000000m, "Mô tả mẫu của sản phẩm7", 25, 7, 4, 400, "MUQ3R0SqsT7", "RAM:26Memory:339GB Man hinh :16inch" },
                    { 8, "/images/device (223).png", 5, false, null, 14000000m, 8000000m, "Mô tả mẫu của sản phẩm8", 23, 7, 2, 100, "NjGyeFplD88", "RAM:17Memory:62GB Man hinh :4inch" },
                    { 9, "/images/device (248).png", 3, false, null, 31000000m, 9000000m, "Mô tả mẫu của sản phẩm9", 27, 6, 1, 100, "3AZHSOnOlr9", "RAM:14Memory:437GB Man hinh :12inch" },
                    { 10, "/images/device (167).png", 4, false, null, 9000000m, 12000000m, "Mô tả mẫu của sản phẩm10", 15, 5, 8, 100, "hBlVWpCyNv10", "RAM:27Memory:376GB Man hinh :16inch" },
                    { 11, "/images/device (149).png", 5, false, null, 42000000m, 6000000m, "Mô tả mẫu của sản phẩm11", 38, 3, 1, 400, "VIQovb88uV11", "RAM:2Memory:405GB Man hinh :16inch" },
                    { 12, "/images/device (214).png", 6, false, null, 49000000m, 39000000m, "Mô tả mẫu của sản phẩm12", 25, 2, 2, 100, "6lohI7kg6G12", "RAM:2Memory:366GB Man hinh :12inch" },
                    { 13, "/images/device (42).png", 8, false, null, 21000000m, 10000000m, "Mô tả mẫu của sản phẩm13", 24, 6, 4, 300, "IhQqoAx8oO13", "RAM:14Memory:41GB Man hinh :4inch" },
                    { 14, "/images/device (252).png", 6, false, null, 26000000m, 17000000m, "Mô tả mẫu của sản phẩm14", 22, 3, 7, 100, "ufDlKNzoyS14", "RAM:7Memory:421GB Man hinh :8inch" },
                    { 15, "/images/device (43).png", 5, false, null, 27000000m, 41000000m, "Mô tả mẫu của sản phẩm15", 26, 5, 4, 300, "KNIsTyhUgG15", "RAM:5Memory:77GB Man hinh :12inch" },
                    { 16, "/images/device (80).png", 1, false, null, 42000000m, 36000000m, "Mô tả mẫu của sản phẩm16", 5, 4, 4, 200, "MK5kzDPMez16", "RAM:16Memory:294GB Man hinh :8inch" },
                    { 17, "/images/device (159).png", 2, false, null, 6000000m, 24000000m, "Mô tả mẫu của sản phẩm17", 31, 1, 2, 400, "9Ej1CoMvjg17", "RAM:19Memory:226GB Man hinh :16inch" },
                    { 18, "/images/device (205).png", 6, false, null, 27000000m, 12000000m, "Mô tả mẫu của sản phẩm18", 30, 8, 7, 100, "3cdUMBsRIW18", "RAM:24Memory:80GB Man hinh :16inch" },
                    { 19, "/images/device (182).png", 6, false, null, 41000000m, 17000000m, "Mô tả mẫu của sản phẩm19", 34, 4, 5, 200, "YJFJ0h7ITa19", "RAM:5Memory:266GB Man hinh :12inch" },
                    { 20, "/images/device (235).png", 7, false, null, 40000000m, 34000000m, "Mô tả mẫu của sản phẩm20", 35, 8, 7, 100, "rm21LuBP9D20", "RAM:23Memory:282GB Man hinh :4inch" },
                    { 21, "/images/device (1).png", 8, false, null, 41000000m, 43000000m, "Mô tả mẫu của sản phẩm21", 33, 6, 8, 300, "fUHCXam6Fs21", "RAM:28Memory:251GB Man hinh :8inch" },
                    { 22, "/images/device (155).png", 3, false, null, 15000000m, 34000000m, "Mô tả mẫu của sản phẩm22", 9, 7, 5, 300, "fdyUYe7bjv22", "RAM:28Memory:199GB Man hinh :4inch" },
                    { 23, "/images/device (256).png", 6, false, null, 37000000m, 42000000m, "Mô tả mẫu của sản phẩm23", 26, 2, 1, 200, "qQOZZG28wR23", "RAM:27Memory:434GB Man hinh :12inch" },
                    { 24, "/images/device (28).png", 5, false, null, 2000000m, 21000000m, "Mô tả mẫu của sản phẩm24", 35, 4, 3, 400, "S4JsrYpAc524", "RAM:10Memory:214GB Man hinh :12inch" },
                    { 25, "/images/device (206).png", 2, false, null, 13000000m, 25000000m, "Mô tả mẫu của sản phẩm25", 21, 6, 4, 400, "8CJVgUq7jp25", "RAM:21Memory:486GB Man hinh :4inch" },
                    { 26, "/images/device (126).png", 3, false, null, 14000000m, 45000000m, "Mô tả mẫu của sản phẩm26", 13, 2, 5, 400, "3NyZ259yLN26", "RAM:19Memory:455GB Man hinh :8inch" },
                    { 27, "/images/device (8).png", 7, false, null, 42000000m, 48000000m, "Mô tả mẫu của sản phẩm27", 34, 8, 7, 300, "MSV8OgqMou27", "RAM:1Memory:205GB Man hinh :8inch" },
                    { 28, "/images/device (192).png", 8, false, null, 34000000m, 20000000m, "Mô tả mẫu của sản phẩm28", 28, 1, 7, 100, "WG8SO6K6WK28", "RAM:2Memory:417GB Man hinh :4inch" },
                    { 29, "/images/device (181).png", 5, false, null, 3000000m, 1000000m, "Mô tả mẫu của sản phẩm29", 30, 2, 3, 300, "A1C0Ef6DZt29", "RAM:23Memory:445GB Man hinh :4inch" },
                    { 30, "/images/device (73).png", 8, false, null, 18000000m, 4000000m, "Mô tả mẫu của sản phẩm30", 8, 7, 3, 100, "xXz8ve0fEK30", "RAM:8Memory:416GB Man hinh :8inch" },
                    { 31, "/images/device (120).png", 1, false, null, 10000000m, 6000000m, "Mô tả mẫu của sản phẩm31", 7, 6, 2, 400, "VoURq8w7yA31", "RAM:28Memory:159GB Man hinh :4inch" },
                    { 32, "/images/device (210).png", 3, false, null, 38000000m, 21000000m, "Mô tả mẫu của sản phẩm32", 23, 6, 6, 200, "R4u8tcpIME32", "RAM:30Memory:149GB Man hinh :16inch" },
                    { 33, "/images/device (238).png", 4, false, null, 45000000m, 1000000m, "Mô tả mẫu của sản phẩm33", 30, 1, 4, 200, "drQ4qeRsjq33", "RAM:19Memory:351GB Man hinh :16inch" },
                    { 34, "/images/device (175).png", 3, false, null, 1000000m, 3000000m, "Mô tả mẫu của sản phẩm34", 37, 7, 8, 400, "KlaFcKEwB934", "RAM:22Memory:153GB Man hinh :16inch" },
                    { 35, "/images/device (187).png", 5, false, null, 39000000m, 48000000m, "Mô tả mẫu của sản phẩm35", 28, 2, 7, 400, "ZfiIIeZTzn35", "RAM:19Memory:136GB Man hinh :12inch" },
                    { 36, "/images/device (108).png", 5, false, null, 13000000m, 19000000m, "Mô tả mẫu của sản phẩm36", 36, 7, 2, 400, "nYvmHtVQqk36", "RAM:24Memory:208GB Man hinh :8inch" },
                    { 37, "/images/device (180).png", 1, false, null, 29000000m, 38000000m, "Mô tả mẫu của sản phẩm37", 22, 6, 7, 200, "Jqyqk7IPut37", "RAM:12Memory:152GB Man hinh :12inch" },
                    { 38, "/images/device (152).png", 7, false, null, 5000000m, 37000000m, "Mô tả mẫu của sản phẩm38", 12, 8, 5, 200, "sO1ngZvYaz38", "RAM:29Memory:342GB Man hinh :16inch" },
                    { 39, "/images/device (114).png", 2, false, null, 18000000m, 22000000m, "Mô tả mẫu của sản phẩm39", 10, 3, 5, 100, "EOUFmYxZ6639", "RAM:25Memory:203GB Man hinh :4inch" },
                    { 40, "/images/device (95).png", 3, false, null, 27000000m, 21000000m, "Mô tả mẫu của sản phẩm40", 12, 4, 7, 300, "fJf2uInvtq40", "RAM:6Memory:273GB Man hinh :8inch" },
                    { 41, "/images/device (167).png", 8, false, null, 8000000m, 45000000m, "Mô tả mẫu của sản phẩm41", 24, 2, 5, 100, "A8i2yfRNGE41", "RAM:19Memory:351GB Man hinh :4inch" },
                    { 42, "/images/device (245).png", 8, false, null, 30000000m, 12000000m, "Mô tả mẫu của sản phẩm42", 15, 2, 3, 300, "De5pdOt1Bs42", "RAM:14Memory:371GB Man hinh :16inch" },
                    { 43, "/images/device (128).png", 1, false, null, 2000000m, 31000000m, "Mô tả mẫu của sản phẩm43", 29, 6, 2, 300, "9NNHSqZCQB43", "RAM:6Memory:445GB Man hinh :8inch" },
                    { 44, "/images/device (209).png", 7, false, null, 42000000m, 18000000m, "Mô tả mẫu của sản phẩm44", 6, 6, 8, 200, "7M87H9GAfW44", "RAM:31Memory:292GB Man hinh :12inch" },
                    { 45, "/images/device (219).png", 8, false, null, 2000000m, 27000000m, "Mô tả mẫu của sản phẩm45", 35, 5, 1, 200, "mYdqLu4sh645", "RAM:31Memory:397GB Man hinh :12inch" },
                    { 46, "/images/device (42).png", 5, false, null, 28000000m, 39000000m, "Mô tả mẫu của sản phẩm46", 25, 3, 8, 200, "942h65RtT246", "RAM:22Memory:488GB Man hinh :12inch" },
                    { 47, "/images/device (168).png", 6, false, null, 40000000m, 3000000m, "Mô tả mẫu của sản phẩm47", 16, 2, 4, 300, "9Z5V1WI28147", "RAM:15Memory:434GB Man hinh :12inch" },
                    { 48, "/images/device (39).png", 7, false, null, 35000000m, 45000000m, "Mô tả mẫu của sản phẩm48", 31, 3, 6, 200, "x3YdxleLnX48", "RAM:21Memory:251GB Man hinh :16inch" },
                    { 49, "/images/device (95).png", 4, false, null, 6000000m, 19000000m, "Mô tả mẫu của sản phẩm49", 32, 7, 1, 300, "qo6KFzM2h749", "RAM:26Memory:179GB Man hinh :12inch" },
                    { 50, "/images/device (147).png", 2, false, null, 3000000m, 44000000m, "Mô tả mẫu của sản phẩm50", 20, 2, 5, 100, "Aa1NsU4ZwA50", "RAM:14Memory:79GB Man hinh :16inch" },
                    { 51, "/images/device (260).png", 8, false, null, 15000000m, 23000000m, "Mô tả mẫu của sản phẩm51", 38, 7, 5, 100, "qIFa9YQQ5a51", "RAM:20Memory:326GB Man hinh :16inch" },
                    { 52, "/images/device (107).png", 3, false, null, 4000000m, 43000000m, "Mô tả mẫu của sản phẩm52", 37, 5, 5, 400, "zGAcq3fSKp52", "RAM:27Memory:243GB Man hinh :4inch" },
                    { 53, "/images/device (193).png", 7, false, null, 12000000m, 13000000m, "Mô tả mẫu của sản phẩm53", 18, 2, 7, 200, "h7m9SA73k653", "RAM:6Memory:409GB Man hinh :16inch" },
                    { 54, "/images/device (143).png", 1, false, null, 9000000m, 14000000m, "Mô tả mẫu của sản phẩm54", 29, 4, 6, 300, "3qeDHOCbwC54", "RAM:8Memory:467GB Man hinh :16inch" },
                    { 55, "/images/device (274).png", 8, false, null, 25000000m, 47000000m, "Mô tả mẫu của sản phẩm55", 25, 2, 1, 200, "yoYLGQWa8L55", "RAM:14Memory:180GB Man hinh :4inch" },
                    { 56, "/images/device (35).png", 2, false, null, 13000000m, 16000000m, "Mô tả mẫu của sản phẩm56", 26, 6, 8, 400, "T9LyljLUAV56", "RAM:15Memory:164GB Man hinh :16inch" },
                    { 57, "/images/device (260).png", 2, false, null, 29000000m, 13000000m, "Mô tả mẫu của sản phẩm57", 14, 4, 4, 300, "Sj1kIBamw357", "RAM:13Memory:419GB Man hinh :8inch" },
                    { 58, "/images/device (205).png", 7, false, null, 35000000m, 43000000m, "Mô tả mẫu của sản phẩm58", 38, 1, 2, 400, "WUSzvwSAvB58", "RAM:11Memory:497GB Man hinh :12inch" },
                    { 59, "/images/device (126).png", 5, false, null, 36000000m, 1000000m, "Mô tả mẫu của sản phẩm59", 12, 2, 1, 300, "PzhEsFTdyZ59", "RAM:27Memory:123GB Man hinh :16inch" },
                    { 60, "/images/device (235).png", 5, false, null, 23000000m, 14000000m, "Mô tả mẫu của sản phẩm60", 6, 3, 8, 400, "FbnEq8u6gZ60", "RAM:12Memory:339GB Man hinh :16inch" },
                    { 61, "/images/device (176).png", 3, false, null, 42000000m, 27000000m, "Mô tả mẫu của sản phẩm61", 15, 5, 4, 100, "08f1SjS8RI61", "RAM:3Memory:425GB Man hinh :12inch" },
                    { 62, "/images/device (251).png", 6, false, null, 39000000m, 27000000m, "Mô tả mẫu của sản phẩm62", 23, 5, 1, 400, "uFRl3T33sD62", "RAM:9Memory:348GB Man hinh :16inch" },
                    { 63, "/images/device (224).png", 2, false, null, 38000000m, 4000000m, "Mô tả mẫu của sản phẩm63", 14, 8, 2, 100, "4Is8ZHb3Mc63", "RAM:13Memory:497GB Man hinh :8inch" },
                    { 64, "/images/device (269).png", 7, false, null, 37000000m, 3000000m, "Mô tả mẫu của sản phẩm64", 17, 6, 1, 100, "DrPan2iGit64", "RAM:28Memory:39GB Man hinh :8inch" },
                    { 65, "/images/device (263).png", 3, false, null, 49000000m, 38000000m, "Mô tả mẫu của sản phẩm65", 36, 4, 7, 400, "z5BtNB9xfg65", "RAM:16Memory:203GB Man hinh :8inch" },
                    { 66, "/images/device (106).png", 2, false, null, 7000000m, 41000000m, "Mô tả mẫu của sản phẩm66", 33, 2, 6, 300, "VWGWGt912U66", "RAM:23Memory:100GB Man hinh :12inch" },
                    { 67, "/images/device (135).png", 6, false, null, 10000000m, 24000000m, "Mô tả mẫu của sản phẩm67", 31, 8, 7, 400, "sHu23PuGbk67", "RAM:28Memory:131GB Man hinh :8inch" },
                    { 68, "/images/device (198).png", 4, false, null, 36000000m, 49000000m, "Mô tả mẫu của sản phẩm68", 30, 2, 5, 200, "DKUPBErpvE68", "RAM:27Memory:246GB Man hinh :8inch" },
                    { 69, "/images/device (120).png", 1, false, null, 17000000m, 24000000m, "Mô tả mẫu của sản phẩm69", 11, 6, 5, 100, "UjsROJj13769", "RAM:9Memory:55GB Man hinh :4inch" },
                    { 70, "/images/device (273).png", 8, false, null, 37000000m, 15000000m, "Mô tả mẫu của sản phẩm70", 16, 2, 3, 100, "pq8EuElzmB70", "RAM:18Memory:133GB Man hinh :16inch" },
                    { 71, "/images/device (211).png", 2, false, null, 44000000m, 13000000m, "Mô tả mẫu của sản phẩm71", 33, 1, 5, 300, "WKyNIjJzAM71", "RAM:13Memory:83GB Man hinh :8inch" },
                    { 72, "/images/device (179).png", 8, false, null, 48000000m, 30000000m, "Mô tả mẫu của sản phẩm72", 6, 6, 1, 300, "UDz4L1fG0q72", "RAM:24Memory:118GB Man hinh :16inch" },
                    { 73, "/images/device (225).png", 6, false, null, 3000000m, 1000000m, "Mô tả mẫu của sản phẩm73", 19, 6, 3, 300, "cSwDuArAiR73", "RAM:10Memory:401GB Man hinh :12inch" },
                    { 74, "/images/device (210).png", 6, false, null, 28000000m, 45000000m, "Mô tả mẫu của sản phẩm74", 12, 1, 2, 200, "WXaGGRraOD74", "RAM:11Memory:74GB Man hinh :8inch" },
                    { 75, "/images/device (138).png", 6, false, null, 20000000m, 9000000m, "Mô tả mẫu của sản phẩm75", 33, 4, 8, 300, "NmJT0on87c75", "RAM:23Memory:196GB Man hinh :8inch" },
                    { 76, "/images/device (244).png", 5, false, null, 41000000m, 3000000m, "Mô tả mẫu của sản phẩm76", 27, 2, 2, 300, "AvKdJPLz9R76", "RAM:28Memory:190GB Man hinh :8inch" },
                    { 77, "/images/device (87).png", 3, false, null, 42000000m, 29000000m, "Mô tả mẫu của sản phẩm77", 22, 5, 3, 100, "7pPIzYwV3e77", "RAM:28Memory:338GB Man hinh :16inch" },
                    { 78, "/images/device (31).png", 4, false, null, 36000000m, 36000000m, "Mô tả mẫu của sản phẩm78", 21, 3, 3, 100, "FJzGGVaD6q78", "RAM:21Memory:184GB Man hinh :4inch" },
                    { 79, "/images/device (10).png", 7, false, null, 19000000m, 4000000m, "Mô tả mẫu của sản phẩm79", 19, 2, 7, 300, "zuK4SHaQBA79", "RAM:12Memory:301GB Man hinh :8inch" },
                    { 80, "/images/device (206).png", 7, false, null, 43000000m, 11000000m, "Mô tả mẫu của sản phẩm80", 21, 4, 3, 200, "vvL6Xktc7X80", "RAM:13Memory:104GB Man hinh :8inch" },
                    { 81, "/images/device (189).png", 5, false, null, 27000000m, 16000000m, "Mô tả mẫu của sản phẩm81", 21, 2, 7, 100, "RUAe9AkLLR81", "RAM:6Memory:177GB Man hinh :4inch" },
                    { 82, "/images/device (37).png", 6, false, null, 30000000m, 36000000m, "Mô tả mẫu của sản phẩm82", 19, 3, 4, 400, "NJyRSzQUNV82", "RAM:2Memory:505GB Man hinh :16inch" },
                    { 83, "/images/device (31).png", 2, false, null, 36000000m, 8000000m, "Mô tả mẫu của sản phẩm83", 14, 4, 3, 200, "1HntXCcBKM83", "RAM:27Memory:94GB Man hinh :4inch" },
                    { 84, "/images/device (176).png", 7, false, null, 15000000m, 27000000m, "Mô tả mẫu của sản phẩm84", 7, 5, 1, 400, "2BlM4OgH6j84", "RAM:15Memory:292GB Man hinh :12inch" },
                    { 85, "/images/device (99).png", 5, false, null, 2000000m, 49000000m, "Mô tả mẫu của sản phẩm85", 17, 8, 2, 200, "STl9Ie7Ifa85", "RAM:28Memory:324GB Man hinh :8inch" },
                    { 86, "/images/device (200).png", 4, false, null, 15000000m, 26000000m, "Mô tả mẫu của sản phẩm86", 25, 5, 4, 200, "360gFPBZcY86", "RAM:13Memory:346GB Man hinh :8inch" },
                    { 87, "/images/device (18).png", 2, false, null, 32000000m, 21000000m, "Mô tả mẫu của sản phẩm87", 23, 1, 4, 100, "GJuQVcLNGn87", "RAM:5Memory:431GB Man hinh :8inch" },
                    { 88, "/images/device (71).png", 5, false, null, 16000000m, 8000000m, "Mô tả mẫu của sản phẩm88", 22, 8, 7, 200, "1ARUfuGUCd88", "RAM:13Memory:346GB Man hinh :4inch" },
                    { 89, "/images/device (89).png", 4, false, null, 20000000m, 42000000m, "Mô tả mẫu của sản phẩm89", 20, 3, 5, 300, "jBUUAoC5rA89", "RAM:22Memory:154GB Man hinh :12inch" },
                    { 90, "/images/device (198).png", 2, false, null, 16000000m, 47000000m, "Mô tả mẫu của sản phẩm90", 32, 7, 3, 400, "UXbQHMJHvM90", "RAM:17Memory:320GB Man hinh :16inch" },
                    { 91, "/images/device (258).png", 1, false, null, 24000000m, 10000000m, "Mô tả mẫu của sản phẩm91", 21, 3, 1, 400, "jsCwywKuJQ91", "RAM:4Memory:235GB Man hinh :12inch" },
                    { 92, "/images/device (100).png", 8, false, null, 3000000m, 27000000m, "Mô tả mẫu của sản phẩm92", 8, 2, 3, 300, "aIksV572AW92", "RAM:7Memory:365GB Man hinh :4inch" },
                    { 93, "/images/device (175).png", 4, false, null, 35000000m, 11000000m, "Mô tả mẫu của sản phẩm93", 13, 3, 4, 100, "gSOR4V28vz93", "RAM:26Memory:375GB Man hinh :12inch" },
                    { 94, "/images/device (143).png", 5, false, null, 32000000m, 36000000m, "Mô tả mẫu của sản phẩm94", 12, 8, 4, 200, "lEoMfzlnxh94", "RAM:19Memory:315GB Man hinh :16inch" },
                    { 95, "/images/device (24).png", 8, false, null, 31000000m, 16000000m, "Mô tả mẫu của sản phẩm95", 36, 8, 2, 100, "9TRc6rDKzB95", "RAM:22Memory:98GB Man hinh :16inch" },
                    { 96, "/images/device (112).png", 8, false, null, 3000000m, 13000000m, "Mô tả mẫu của sản phẩm96", 29, 8, 1, 300, "vgYlnWnIwA96", "RAM:18Memory:60GB Man hinh :16inch" },
                    { 97, "/images/device (24).png", 8, false, null, 6000000m, 25000000m, "Mô tả mẫu của sản phẩm97", 25, 3, 6, 200, "EuOUc71F2y97", "RAM:9Memory:90GB Man hinh :12inch" },
                    { 98, "/images/device (184).png", 4, false, null, 23000000m, 11000000m, "Mô tả mẫu của sản phẩm98", 15, 4, 3, 300, "DoLTVsGyhn98", "RAM:27Memory:477GB Man hinh :16inch" },
                    { 99, "/images/device (235).png", 5, false, null, 8000000m, 24000000m, "Mô tả mẫu của sản phẩm99", 7, 8, 3, 400, "l4M1vpc11h99", "RAM:15Memory:398GB Man hinh :8inch" },
                    { 100, "/images/device (62).png", 4, false, null, 2000000m, 45000000m, "Mô tả mẫu của sản phẩm100", 35, 4, 5, 100, "lAPB94OGUs100", "RAM:15Memory:315GB Man hinh :16inch" },
                    { 101, "/images/device (53).png", 2, false, null, 34000000m, 14000000m, "Mô tả mẫu của sản phẩm101", 30, 5, 4, 400, "IJOJqD2dQ5101", "RAM:30Memory:347GB Man hinh :16inch" },
                    { 102, "/images/device (87).png", 5, false, null, 26000000m, 43000000m, "Mô tả mẫu của sản phẩm102", 18, 5, 4, 200, "cidhilKjGZ102", "RAM:28Memory:470GB Man hinh :16inch" },
                    { 103, "/images/device (101).png", 6, false, null, 12000000m, 5000000m, "Mô tả mẫu của sản phẩm103", 21, 5, 4, 200, "b6grt7ky2a103", "RAM:21Memory:462GB Man hinh :8inch" },
                    { 104, "/images/device (120).png", 3, false, null, 22000000m, 42000000m, "Mô tả mẫu của sản phẩm104", 25, 5, 2, 100, "nX0be7rnOH104", "RAM:21Memory:246GB Man hinh :16inch" },
                    { 105, "/images/device (88).png", 2, false, null, 37000000m, 34000000m, "Mô tả mẫu của sản phẩm105", 29, 7, 6, 400, "9UmSLgqYby105", "RAM:30Memory:307GB Man hinh :4inch" },
                    { 106, "/images/device (255).png", 4, false, null, 21000000m, 9000000m, "Mô tả mẫu của sản phẩm106", 29, 5, 1, 400, "iPPmnugjVO106", "RAM:9Memory:260GB Man hinh :8inch" },
                    { 107, "/images/device (259).png", 2, false, null, 2000000m, 6000000m, "Mô tả mẫu của sản phẩm107", 17, 4, 4, 400, "GShGV9V8cn107", "RAM:31Memory:320GB Man hinh :8inch" },
                    { 108, "/images/device (90).png", 5, false, null, 5000000m, 8000000m, "Mô tả mẫu của sản phẩm108", 12, 5, 1, 200, "JYOYQeozjC108", "RAM:25Memory:85GB Man hinh :12inch" },
                    { 109, "/images/device (254).png", 8, false, null, 42000000m, 30000000m, "Mô tả mẫu của sản phẩm109", 13, 4, 4, 300, "6IB4GgYqRo109", "RAM:14Memory:396GB Man hinh :4inch" },
                    { 110, "/images/device (122).png", 6, false, null, 33000000m, 33000000m, "Mô tả mẫu của sản phẩm110", 14, 3, 6, 200, "x5076gNYgq110", "RAM:12Memory:304GB Man hinh :8inch" },
                    { 111, "/images/device (244).png", 6, false, null, 19000000m, 16000000m, "Mô tả mẫu của sản phẩm111", 37, 7, 4, 200, "HyEzfJrhrh111", "RAM:8Memory:287GB Man hinh :16inch" },
                    { 112, "/images/device (58).png", 8, false, null, 1000000m, 23000000m, "Mô tả mẫu của sản phẩm112", 30, 3, 7, 400, "yQd04vJWeA112", "RAM:5Memory:280GB Man hinh :8inch" },
                    { 113, "/images/device (45).png", 4, false, null, 17000000m, 1000000m, "Mô tả mẫu của sản phẩm113", 12, 3, 7, 200, "1C8yilKvQx113", "RAM:4Memory:139GB Man hinh :12inch" },
                    { 114, "/images/device (272).png", 6, false, null, 30000000m, 15000000m, "Mô tả mẫu của sản phẩm114", 29, 1, 4, 200, "irF1RI4z2p114", "RAM:4Memory:56GB Man hinh :4inch" },
                    { 115, "/images/device (161).png", 8, false, null, 36000000m, 39000000m, "Mô tả mẫu của sản phẩm115", 36, 3, 7, 100, "iAwKBjz7Pg115", "RAM:24Memory:201GB Man hinh :4inch" },
                    { 116, "/images/device (142).png", 5, false, null, 12000000m, 3000000m, "Mô tả mẫu của sản phẩm116", 37, 3, 4, 200, "bPgYYXXKyR116", "RAM:11Memory:434GB Man hinh :16inch" },
                    { 117, "/images/device (1).png", 4, false, null, 22000000m, 2000000m, "Mô tả mẫu của sản phẩm117", 16, 6, 3, 300, "CXSmvb9PXT117", "RAM:13Memory:165GB Man hinh :8inch" },
                    { 118, "/images/device (92).png", 8, false, null, 30000000m, 44000000m, "Mô tả mẫu của sản phẩm118", 7, 4, 8, 300, "hMRr17MrRS118", "RAM:15Memory:49GB Man hinh :16inch" },
                    { 119, "/images/device (151).png", 3, false, null, 35000000m, 15000000m, "Mô tả mẫu của sản phẩm119", 25, 4, 2, 400, "kXb16D3Jeg119", "RAM:31Memory:44GB Man hinh :8inch" },
                    { 120, "/images/device (105).png", 3, false, null, 41000000m, 10000000m, "Mô tả mẫu của sản phẩm120", 24, 1, 8, 400, "CRiXqMHbPX120", "RAM:28Memory:250GB Man hinh :4inch" },
                    { 121, "/images/device (31).png", 6, false, null, 46000000m, 31000000m, "Mô tả mẫu của sản phẩm121", 10, 1, 3, 100, "vREN3sCPRW121", "RAM:13Memory:381GB Man hinh :4inch" },
                    { 122, "/images/device (149).png", 5, false, null, 17000000m, 18000000m, "Mô tả mẫu của sản phẩm122", 18, 5, 5, 400, "2EVhuAunt5122", "RAM:1Memory:56GB Man hinh :16inch" },
                    { 123, "/images/device (220).png", 6, false, null, 38000000m, 27000000m, "Mô tả mẫu của sản phẩm123", 20, 3, 3, 400, "S1zg2lRNDP123", "RAM:29Memory:303GB Man hinh :16inch" },
                    { 124, "/images/device (260).png", 5, false, null, 8000000m, 44000000m, "Mô tả mẫu của sản phẩm124", 13, 2, 7, 300, "X8INzz7v0g124", "RAM:26Memory:489GB Man hinh :8inch" },
                    { 125, "/images/device (271).png", 5, false, null, 37000000m, 6000000m, "Mô tả mẫu của sản phẩm125", 11, 5, 6, 300, "KgDKhb73zb125", "RAM:30Memory:436GB Man hinh :4inch" },
                    { 126, "/images/device (248).png", 1, false, null, 48000000m, 38000000m, "Mô tả mẫu của sản phẩm126", 12, 1, 5, 100, "mtAFdmn2sC126", "RAM:16Memory:151GB Man hinh :4inch" },
                    { 127, "/images/device (177).png", 7, false, null, 46000000m, 14000000m, "Mô tả mẫu của sản phẩm127", 13, 7, 2, 300, "MhyMrWmnFp127", "RAM:4Memory:406GB Man hinh :8inch" },
                    { 128, "/images/device (121).png", 5, false, null, 18000000m, 48000000m, "Mô tả mẫu của sản phẩm128", 16, 1, 2, 200, "Qt5XAPh8eI128", "RAM:17Memory:72GB Man hinh :8inch" },
                    { 129, "/images/device (100).png", 8, false, null, 32000000m, 8000000m, "Mô tả mẫu của sản phẩm129", 18, 8, 8, 200, "ZkuciwBhtY129", "RAM:20Memory:171GB Man hinh :12inch" },
                    { 130, "/images/device (26).png", 4, false, null, 10000000m, 33000000m, "Mô tả mẫu của sản phẩm130", 37, 5, 1, 100, "W38fjr9BkW130", "RAM:18Memory:435GB Man hinh :12inch" },
                    { 131, "/images/device (140).png", 4, false, null, 32000000m, 8000000m, "Mô tả mẫu của sản phẩm131", 27, 5, 4, 400, "5HjaK1BEse131", "RAM:20Memory:216GB Man hinh :16inch" },
                    { 132, "/images/device (164).png", 2, false, null, 4000000m, 16000000m, "Mô tả mẫu của sản phẩm132", 37, 6, 4, 400, "TKFR8FDqen132", "RAM:18Memory:353GB Man hinh :8inch" },
                    { 133, "/images/device (129).png", 7, false, null, 11000000m, 23000000m, "Mô tả mẫu của sản phẩm133", 26, 2, 1, 300, "mZhp6RxFbI133", "RAM:2Memory:200GB Man hinh :16inch" },
                    { 134, "/images/device (247).png", 5, false, null, 44000000m, 31000000m, "Mô tả mẫu của sản phẩm134", 36, 6, 6, 300, "D8ZT5ZHbUv134", "RAM:8Memory:151GB Man hinh :4inch" },
                    { 135, "/images/device (90).png", 4, false, null, 47000000m, 40000000m, "Mô tả mẫu của sản phẩm135", 9, 7, 1, 300, "qPvJWVWXC5135", "RAM:31Memory:435GB Man hinh :16inch" },
                    { 136, "/images/device (254).png", 5, false, null, 13000000m, 43000000m, "Mô tả mẫu của sản phẩm136", 9, 7, 7, 300, "X18zfehlhk136", "RAM:26Memory:326GB Man hinh :12inch" },
                    { 137, "/images/device (165).png", 2, false, null, 38000000m, 14000000m, "Mô tả mẫu của sản phẩm137", 10, 5, 6, 300, "AFoXun2Csv137", "RAM:1Memory:509GB Man hinh :12inch" },
                    { 138, "/images/device (260).png", 7, false, null, 47000000m, 48000000m, "Mô tả mẫu của sản phẩm138", 30, 2, 4, 300, "AuzfkP7wlW138", "RAM:31Memory:358GB Man hinh :8inch" },
                    { 139, "/images/device (43).png", 5, false, null, 11000000m, 31000000m, "Mô tả mẫu của sản phẩm139", 14, 5, 3, 300, "bCyUbLTCHc139", "RAM:3Memory:441GB Man hinh :4inch" },
                    { 140, "/images/device (87).png", 6, false, null, 38000000m, 5000000m, "Mô tả mẫu của sản phẩm140", 10, 3, 2, 100, "5E3EZsGACe140", "RAM:29Memory:210GB Man hinh :16inch" },
                    { 141, "/images/device (123).png", 7, false, null, 25000000m, 14000000m, "Mô tả mẫu của sản phẩm141", 10, 5, 4, 300, "VzxSzhkAm2141", "RAM:31Memory:379GB Man hinh :8inch" },
                    { 142, "/images/device (35).png", 4, false, null, 45000000m, 34000000m, "Mô tả mẫu của sản phẩm142", 13, 7, 1, 400, "x6hnqeNeXk142", "RAM:28Memory:315GB Man hinh :16inch" },
                    { 143, "/images/device (242).png", 7, false, null, 30000000m, 32000000m, "Mô tả mẫu của sản phẩm143", 37, 1, 8, 300, "W6uPPDD3zG143", "RAM:31Memory:477GB Man hinh :4inch" },
                    { 144, "/images/device (242).png", 6, false, null, 40000000m, 20000000m, "Mô tả mẫu của sản phẩm144", 36, 5, 4, 400, "tqeJQJ7leJ144", "RAM:15Memory:323GB Man hinh :4inch" },
                    { 145, "/images/device (5).png", 8, false, null, 8000000m, 9000000m, "Mô tả mẫu của sản phẩm145", 29, 5, 4, 300, "7RFTlT0mxg145", "RAM:3Memory:262GB Man hinh :16inch" },
                    { 146, "/images/device (184).png", 1, false, null, 14000000m, 42000000m, "Mô tả mẫu của sản phẩm146", 36, 3, 4, 400, "cjqVwUn7Z6146", "RAM:27Memory:314GB Man hinh :4inch" },
                    { 147, "/images/device (123).png", 4, false, null, 48000000m, 1000000m, "Mô tả mẫu của sản phẩm147", 27, 3, 3, 200, "vXNTUuKTkA147", "RAM:13Memory:297GB Man hinh :16inch" },
                    { 148, "/images/device (262).png", 3, false, null, 46000000m, 33000000m, "Mô tả mẫu của sản phẩm148", 17, 2, 3, 300, "Er5kUaUOey148", "RAM:29Memory:151GB Man hinh :16inch" },
                    { 149, "/images/device (183).png", 2, false, null, 47000000m, 22000000m, "Mô tả mẫu của sản phẩm149", 34, 5, 5, 400, "Gm8QOvoovS149", "RAM:21Memory:311GB Man hinh :12inch" },
                    { 150, "/images/device (250).png", 6, false, null, 31000000m, 6000000m, "Mô tả mẫu của sản phẩm150", 8, 5, 8, 100, "IhzXX7RwLH150", "RAM:6Memory:270GB Man hinh :8inch" },
                    { 151, "/images/device (139).png", 3, false, null, 38000000m, 41000000m, "Mô tả mẫu của sản phẩm151", 34, 1, 4, 300, "G723upN2cP151", "RAM:11Memory:152GB Man hinh :8inch" },
                    { 152, "/images/device (21).png", 6, false, null, 16000000m, 5000000m, "Mô tả mẫu của sản phẩm152", 18, 8, 8, 100, "lL9qz1HJ8F152", "RAM:17Memory:505GB Man hinh :12inch" },
                    { 153, "/images/device (100).png", 7, false, null, 6000000m, 45000000m, "Mô tả mẫu của sản phẩm153", 16, 3, 8, 100, "PPZ7DbldMn153", "RAM:29Memory:200GB Man hinh :12inch" },
                    { 154, "/images/device (113).png", 8, false, null, 45000000m, 39000000m, "Mô tả mẫu của sản phẩm154", 10, 4, 6, 200, "yejnlZsF5B154", "RAM:12Memory:479GB Man hinh :8inch" },
                    { 155, "/images/device (191).png", 1, false, null, 5000000m, 9000000m, "Mô tả mẫu của sản phẩm155", 39, 4, 5, 200, "qcNq35ifif155", "RAM:26Memory:249GB Man hinh :16inch" },
                    { 156, "/images/device (191).png", 6, false, null, 25000000m, 6000000m, "Mô tả mẫu của sản phẩm156", 10, 4, 8, 200, "4HnAHerxCm156", "RAM:23Memory:485GB Man hinh :12inch" },
                    { 157, "/images/device (167).png", 5, false, null, 2000000m, 40000000m, "Mô tả mẫu của sản phẩm157", 16, 4, 6, 200, "O14gIbZRjZ157", "RAM:25Memory:364GB Man hinh :8inch" },
                    { 158, "/images/device (260).png", 4, false, null, 38000000m, 20000000m, "Mô tả mẫu của sản phẩm158", 29, 8, 5, 100, "qcc8lFmO9v158", "RAM:1Memory:235GB Man hinh :8inch" },
                    { 159, "/images/device (271).png", 3, false, null, 44000000m, 35000000m, "Mô tả mẫu của sản phẩm159", 20, 6, 2, 300, "6JzsVSC34l159", "RAM:29Memory:509GB Man hinh :4inch" },
                    { 160, "/images/device (67).png", 3, false, null, 20000000m, 7000000m, "Mô tả mẫu của sản phẩm160", 12, 2, 6, 300, "SLbIt7bmxd160", "RAM:22Memory:299GB Man hinh :4inch" },
                    { 161, "/images/device (1).png", 8, false, null, 34000000m, 22000000m, "Mô tả mẫu của sản phẩm161", 15, 7, 7, 100, "dsMHEZ1poq161", "RAM:21Memory:244GB Man hinh :8inch" },
                    { 162, "/images/device (41).png", 4, false, null, 39000000m, 15000000m, "Mô tả mẫu của sản phẩm162", 38, 3, 3, 300, "MFSZm18gdh162", "RAM:27Memory:166GB Man hinh :12inch" },
                    { 163, "/images/device (272).png", 3, false, null, 4000000m, 45000000m, "Mô tả mẫu của sản phẩm163", 32, 1, 4, 300, "PG4Zx53Dw7163", "RAM:7Memory:302GB Man hinh :16inch" },
                    { 164, "/images/device (130).png", 2, false, null, 33000000m, 24000000m, "Mô tả mẫu của sản phẩm164", 6, 4, 6, 400, "CMNbnxoaHj164", "RAM:20Memory:195GB Man hinh :12inch" },
                    { 165, "/images/device (112).png", 3, false, null, 2000000m, 49000000m, "Mô tả mẫu của sản phẩm165", 26, 8, 2, 200, "CxpAwR02Vp165", "RAM:25Memory:422GB Man hinh :4inch" },
                    { 166, "/images/device (66).png", 3, false, null, 14000000m, 31000000m, "Mô tả mẫu của sản phẩm166", 36, 5, 2, 100, "0hNdDmeH0W166", "RAM:29Memory:304GB Man hinh :8inch" },
                    { 167, "/images/device (146).png", 7, false, null, 27000000m, 25000000m, "Mô tả mẫu của sản phẩm167", 13, 4, 6, 200, "81hU831L69167", "RAM:23Memory:51GB Man hinh :12inch" },
                    { 168, "/images/device (235).png", 7, false, null, 32000000m, 4000000m, "Mô tả mẫu của sản phẩm168", 21, 5, 8, 400, "I1kmAxC8JF168", "RAM:16Memory:463GB Man hinh :8inch" },
                    { 169, "/images/device (196).png", 6, false, null, 26000000m, 25000000m, "Mô tả mẫu của sản phẩm169", 21, 3, 5, 100, "tw4uk7D96f169", "RAM:19Memory:137GB Man hinh :12inch" },
                    { 170, "/images/device (83).png", 2, false, null, 2000000m, 6000000m, "Mô tả mẫu của sản phẩm170", 36, 5, 1, 100, "iIacG6DtaW170", "RAM:24Memory:87GB Man hinh :16inch" },
                    { 171, "/images/device (248).png", 2, false, null, 15000000m, 42000000m, "Mô tả mẫu của sản phẩm171", 8, 6, 4, 300, "ZDyPHNxniu171", "RAM:5Memory:220GB Man hinh :8inch" },
                    { 172, "/images/device (195).png", 2, false, null, 46000000m, 3000000m, "Mô tả mẫu của sản phẩm172", 30, 8, 1, 300, "TTqNVUkAz9172", "RAM:11Memory:108GB Man hinh :16inch" },
                    { 173, "/images/device (213).png", 7, false, null, 40000000m, 7000000m, "Mô tả mẫu của sản phẩm173", 31, 3, 7, 200, "xHDj0s6Prn173", "RAM:13Memory:417GB Man hinh :4inch" },
                    { 174, "/images/device (117).png", 6, false, null, 1000000m, 36000000m, "Mô tả mẫu của sản phẩm174", 39, 1, 3, 400, "nPSQxU6b56174", "RAM:5Memory:236GB Man hinh :8inch" },
                    { 175, "/images/device (231).png", 2, false, null, 21000000m, 23000000m, "Mô tả mẫu của sản phẩm175", 27, 6, 3, 100, "bAgZQhkqoG175", "RAM:11Memory:92GB Man hinh :8inch" },
                    { 176, "/images/device (170).png", 8, false, null, 29000000m, 22000000m, "Mô tả mẫu của sản phẩm176", 7, 6, 6, 300, "zYUOIjJlud176", "RAM:4Memory:162GB Man hinh :8inch" },
                    { 177, "/images/device (199).png", 6, false, null, 15000000m, 29000000m, "Mô tả mẫu của sản phẩm177", 9, 8, 8, 400, "CJATYoBh5c177", "RAM:24Memory:217GB Man hinh :8inch" },
                    { 178, "/images/device (249).png", 2, false, null, 10000000m, 34000000m, "Mô tả mẫu của sản phẩm178", 28, 5, 8, 100, "CKvWBm85sJ178", "RAM:1Memory:379GB Man hinh :4inch" },
                    { 179, "/images/device (32).png", 6, false, null, 16000000m, 6000000m, "Mô tả mẫu của sản phẩm179", 6, 6, 7, 100, "QhA62aYPby179", "RAM:1Memory:264GB Man hinh :16inch" },
                    { 180, "/images/device (156).png", 5, false, null, 21000000m, 29000000m, "Mô tả mẫu của sản phẩm180", 7, 1, 4, 300, "EYufPjW0jU180", "RAM:28Memory:122GB Man hinh :8inch" },
                    { 181, "/images/device (32).png", 3, false, null, 24000000m, 4000000m, "Mô tả mẫu của sản phẩm181", 19, 6, 2, 200, "q3ASByeuvW181", "RAM:20Memory:229GB Man hinh :12inch" },
                    { 182, "/images/device (46).png", 1, false, null, 21000000m, 2000000m, "Mô tả mẫu của sản phẩm182", 36, 6, 5, 300, "Adz3L9GMaX182", "RAM:16Memory:286GB Man hinh :16inch" },
                    { 183, "/images/device (52).png", 3, false, null, 21000000m, 24000000m, "Mô tả mẫu của sản phẩm183", 26, 1, 7, 400, "eJKCQ3oBHn183", "RAM:14Memory:293GB Man hinh :12inch" },
                    { 184, "/images/device (53).png", 1, false, null, 42000000m, 23000000m, "Mô tả mẫu của sản phẩm184", 28, 2, 8, 300, "fOLZeh2p9E184", "RAM:10Memory:216GB Man hinh :16inch" },
                    { 185, "/images/device (44).png", 5, false, null, 22000000m, 2000000m, "Mô tả mẫu của sản phẩm185", 10, 4, 7, 200, "lfgnKmWV2J185", "RAM:28Memory:354GB Man hinh :4inch" },
                    { 186, "/images/device (175).png", 2, false, null, 26000000m, 20000000m, "Mô tả mẫu của sản phẩm186", 39, 7, 2, 100, "leRtcdMHDD186", "RAM:21Memory:199GB Man hinh :8inch" },
                    { 187, "/images/device (117).png", 7, false, null, 22000000m, 44000000m, "Mô tả mẫu của sản phẩm187", 36, 6, 2, 200, "zLiiJlFn71187", "RAM:25Memory:51GB Man hinh :8inch" },
                    { 188, "/images/device (143).png", 1, false, null, 3000000m, 34000000m, "Mô tả mẫu của sản phẩm188", 19, 6, 7, 400, "S8TMD0RXXk188", "RAM:15Memory:315GB Man hinh :12inch" },
                    { 189, "/images/device (182).png", 1, false, null, 13000000m, 26000000m, "Mô tả mẫu của sản phẩm189", 25, 8, 4, 300, "ZewigEnLjp189", "RAM:14Memory:265GB Man hinh :8inch" },
                    { 190, "/images/device (52).png", 5, false, null, 15000000m, 37000000m, "Mô tả mẫu của sản phẩm190", 17, 8, 6, 200, "hh9rMNWRaW190", "RAM:8Memory:403GB Man hinh :12inch" },
                    { 191, "/images/device (162).png", 2, false, null, 7000000m, 43000000m, "Mô tả mẫu của sản phẩm191", 13, 6, 3, 300, "HHtgL01Kn5191", "RAM:16Memory:298GB Man hinh :12inch" },
                    { 192, "/images/device (108).png", 7, false, null, 9000000m, 20000000m, "Mô tả mẫu của sản phẩm192", 9, 6, 5, 400, "ObaakPClLI192", "RAM:4Memory:382GB Man hinh :16inch" },
                    { 193, "/images/device (18).png", 7, false, null, 25000000m, 36000000m, "Mô tả mẫu của sản phẩm193", 15, 2, 7, 200, "J0RThHDD0G193", "RAM:11Memory:234GB Man hinh :8inch" },
                    { 194, "/images/device (11).png", 7, false, null, 5000000m, 4000000m, "Mô tả mẫu của sản phẩm194", 17, 4, 1, 200, "wnMCpgg0lE194", "RAM:31Memory:446GB Man hinh :4inch" },
                    { 195, "/images/device (237).png", 1, false, null, 15000000m, 33000000m, "Mô tả mẫu của sản phẩm195", 24, 2, 3, 400, "1JRdoxJrKl195", "RAM:22Memory:435GB Man hinh :16inch" },
                    { 196, "/images/device (124).png", 7, false, null, 37000000m, 20000000m, "Mô tả mẫu của sản phẩm196", 8, 4, 7, 100, "eUokoTKTR6196", "RAM:4Memory:403GB Man hinh :12inch" },
                    { 197, "/images/device (176).png", 8, false, null, 8000000m, 7000000m, "Mô tả mẫu của sản phẩm197", 32, 4, 5, 100, "SsG1CdiQEu197", "RAM:2Memory:368GB Man hinh :8inch" },
                    { 198, "/images/device (49).png", 4, false, null, 45000000m, 6000000m, "Mô tả mẫu của sản phẩm198", 35, 4, 4, 200, "lTMGNRSHee198", "RAM:11Memory:501GB Man hinh :8inch" },
                    { 199, "/images/device (187).png", 2, false, null, 40000000m, 23000000m, "Mô tả mẫu của sản phẩm199", 24, 8, 3, 400, "l7SMHqjSz0199", "RAM:14Memory:468GB Man hinh :16inch" },
                    { 200, "/images/device (60).png", 6, false, null, 16000000m, 22000000m, "Mô tả mẫu của sản phẩm200", 30, 2, 7, 200, "nfN1Psmf8X200", "RAM:16Memory:119GB Man hinh :8inch" },
                    { 201, "/images/device (265).png", 3, false, null, 42000000m, 37000000m, "Mô tả mẫu của sản phẩm201", 11, 1, 1, 400, "hMKZ0cLqc9201", "RAM:18Memory:322GB Man hinh :12inch" },
                    { 202, "/images/device (30).png", 7, false, null, 22000000m, 3000000m, "Mô tả mẫu của sản phẩm202", 11, 1, 3, 300, "Iy6qzxw1xN202", "RAM:18Memory:207GB Man hinh :12inch" },
                    { 203, "/images/device (58).png", 7, false, null, 16000000m, 31000000m, "Mô tả mẫu của sản phẩm203", 37, 1, 2, 200, "OnptKvXMV9203", "RAM:6Memory:482GB Man hinh :12inch" },
                    { 204, "/images/device (130).png", 8, false, null, 41000000m, 11000000m, "Mô tả mẫu của sản phẩm204", 39, 5, 6, 400, "iWnB7Jttkk204", "RAM:29Memory:83GB Man hinh :4inch" },
                    { 205, "/images/device (65).png", 2, false, null, 7000000m, 43000000m, "Mô tả mẫu của sản phẩm205", 19, 3, 2, 100, "eY7fa2uXAa205", "RAM:10Memory:399GB Man hinh :16inch" },
                    { 206, "/images/device (145).png", 3, false, null, 22000000m, 12000000m, "Mô tả mẫu của sản phẩm206", 6, 5, 6, 200, "wzap5wMABh206", "RAM:29Memory:78GB Man hinh :16inch" },
                    { 207, "/images/device (56).png", 2, false, null, 29000000m, 11000000m, "Mô tả mẫu của sản phẩm207", 12, 5, 2, 400, "nBEfFzrj1z207", "RAM:10Memory:218GB Man hinh :4inch" },
                    { 208, "/images/device (122).png", 1, false, null, 30000000m, 8000000m, "Mô tả mẫu của sản phẩm208", 5, 6, 3, 100, "ewur3ALXLx208", "RAM:10Memory:373GB Man hinh :8inch" },
                    { 209, "/images/device (174).png", 6, false, null, 4000000m, 5000000m, "Mô tả mẫu của sản phẩm209", 6, 3, 4, 300, "ou7Qu10ph0209", "RAM:20Memory:431GB Man hinh :12inch" },
                    { 210, "/images/device (154).png", 3, false, null, 19000000m, 35000000m, "Mô tả mẫu của sản phẩm210", 30, 2, 3, 400, "Jm67tStYGp210", "RAM:17Memory:290GB Man hinh :12inch" },
                    { 211, "/images/device (42).png", 5, false, null, 39000000m, 36000000m, "Mô tả mẫu của sản phẩm211", 11, 1, 5, 400, "kFtV55I1M5211", "RAM:23Memory:447GB Man hinh :8inch" },
                    { 212, "/images/device (39).png", 5, false, null, 38000000m, 3000000m, "Mô tả mẫu của sản phẩm212", 9, 3, 5, 400, "qh3Iyd49vl212", "RAM:21Memory:108GB Man hinh :12inch" },
                    { 213, "/images/device (250).png", 4, false, null, 1000000m, 2000000m, "Mô tả mẫu của sản phẩm213", 20, 4, 3, 300, "d9yJ36Zoiu213", "RAM:9Memory:500GB Man hinh :12inch" },
                    { 214, "/images/device (131).png", 5, false, null, 36000000m, 24000000m, "Mô tả mẫu của sản phẩm214", 26, 1, 8, 200, "dPVwfyxqJb214", "RAM:14Memory:413GB Man hinh :8inch" },
                    { 215, "/images/device (44).png", 5, false, null, 22000000m, 32000000m, "Mô tả mẫu của sản phẩm215", 38, 3, 8, 200, "kM42tjdiW5215", "RAM:20Memory:412GB Man hinh :12inch" },
                    { 216, "/images/device (110).png", 6, false, null, 33000000m, 4000000m, "Mô tả mẫu của sản phẩm216", 39, 8, 6, 300, "UeHDjGvB8o216", "RAM:14Memory:186GB Man hinh :16inch" },
                    { 217, "/images/device (231).png", 3, false, null, 32000000m, 3000000m, "Mô tả mẫu của sản phẩm217", 19, 3, 4, 400, "CntkEPJVAQ217", "RAM:16Memory:281GB Man hinh :12inch" },
                    { 218, "/images/device (118).png", 5, false, null, 24000000m, 17000000m, "Mô tả mẫu của sản phẩm218", 17, 1, 3, 300, "YmNT9vFA56218", "RAM:20Memory:248GB Man hinh :4inch" },
                    { 219, "/images/device (181).png", 1, false, null, 21000000m, 41000000m, "Mô tả mẫu của sản phẩm219", 21, 7, 2, 400, "l3jq1BzTDE219", "RAM:16Memory:293GB Man hinh :8inch" },
                    { 220, "/images/device (3).png", 2, false, null, 29000000m, 24000000m, "Mô tả mẫu của sản phẩm220", 21, 3, 8, 300, "bYfcKegcLr220", "RAM:12Memory:479GB Man hinh :4inch" },
                    { 221, "/images/device (230).png", 8, false, null, 43000000m, 23000000m, "Mô tả mẫu của sản phẩm221", 20, 5, 1, 200, "WvpIbMmrxA221", "RAM:8Memory:433GB Man hinh :8inch" },
                    { 222, "/images/device (76).png", 8, false, null, 19000000m, 26000000m, "Mô tả mẫu của sản phẩm222", 8, 8, 3, 400, "LTP7bGL8iK222", "RAM:5Memory:394GB Man hinh :12inch" },
                    { 223, "/images/device (273).png", 7, false, null, 23000000m, 26000000m, "Mô tả mẫu của sản phẩm223", 16, 8, 5, 100, "54IB0DjhKK223", "RAM:4Memory:166GB Man hinh :16inch" },
                    { 224, "/images/device (257).png", 7, false, null, 17000000m, 44000000m, "Mô tả mẫu của sản phẩm224", 15, 3, 4, 100, "VEUj8WI0sj224", "RAM:16Memory:402GB Man hinh :8inch" },
                    { 225, "/images/device (1).png", 1, false, null, 10000000m, 20000000m, "Mô tả mẫu của sản phẩm225", 37, 3, 3, 400, "jEuM6O8QOO225", "RAM:14Memory:472GB Man hinh :8inch" },
                    { 226, "/images/device (69).png", 8, false, null, 36000000m, 34000000m, "Mô tả mẫu của sản phẩm226", 18, 7, 3, 200, "i29ORRF8ut226", "RAM:19Memory:152GB Man hinh :8inch" },
                    { 227, "/images/device (56).png", 2, false, null, 48000000m, 3000000m, "Mô tả mẫu của sản phẩm227", 28, 4, 5, 100, "F3d2TJn7dW227", "RAM:1Memory:270GB Man hinh :4inch" },
                    { 228, "/images/device (124).png", 7, false, null, 22000000m, 22000000m, "Mô tả mẫu của sản phẩm228", 22, 2, 5, 100, "FPQpjRG4Jm228", "RAM:26Memory:425GB Man hinh :8inch" },
                    { 229, "/images/device (52).png", 8, false, null, 34000000m, 23000000m, "Mô tả mẫu của sản phẩm229", 7, 5, 4, 100, "JsTAatDqkL229", "RAM:5Memory:229GB Man hinh :8inch" },
                    { 230, "/images/device (164).png", 3, false, null, 26000000m, 17000000m, "Mô tả mẫu của sản phẩm230", 22, 2, 6, 300, "Zy8ewPZcEw230", "RAM:30Memory:451GB Man hinh :16inch" },
                    { 231, "/images/device (100).png", 2, false, null, 40000000m, 21000000m, "Mô tả mẫu của sản phẩm231", 37, 5, 2, 400, "fVXL8CiQLe231", "RAM:10Memory:477GB Man hinh :4inch" },
                    { 232, "/images/device (32).png", 5, false, null, 36000000m, 47000000m, "Mô tả mẫu của sản phẩm232", 16, 8, 3, 300, "GV4DmQqSWh232", "RAM:7Memory:432GB Man hinh :16inch" },
                    { 233, "/images/device (135).png", 5, false, null, 17000000m, 44000000m, "Mô tả mẫu của sản phẩm233", 13, 6, 5, 200, "VLMn8bDXUQ233", "RAM:31Memory:185GB Man hinh :8inch" },
                    { 234, "/images/device (30).png", 6, false, null, 20000000m, 11000000m, "Mô tả mẫu của sản phẩm234", 36, 1, 8, 100, "jbouSkGHB4234", "RAM:4Memory:457GB Man hinh :16inch" },
                    { 235, "/images/device (184).png", 8, false, null, 5000000m, 40000000m, "Mô tả mẫu của sản phẩm235", 25, 4, 3, 200, "XBvhy6vIHp235", "RAM:22Memory:390GB Man hinh :16inch" },
                    { 236, "/images/device (92).png", 7, false, null, 45000000m, 1000000m, "Mô tả mẫu của sản phẩm236", 25, 1, 2, 400, "LI76kXXSN0236", "RAM:25Memory:335GB Man hinh :8inch" }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "ProductImageId", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, 75, "/images/device (257).png" },
                    { 2, 43, "/images/device (228).png" },
                    { 3, 11, "/images/device (225).png" },
                    { 4, 94, "/images/device (18).png" },
                    { 5, 100, "/images/device (242).png" },
                    { 6, 91, "/images/device (238).png" },
                    { 7, 208, "/images/device (269).png" },
                    { 8, 149, "/images/device (76).png" },
                    { 9, 197, "/images/device (255).png" },
                    { 10, 34, "/images/device (19).png" },
                    { 11, 98, "/images/device (219).png" },
                    { 12, 58, "/images/device (1).png" },
                    { 13, 184, "/images/device (100).png" },
                    { 14, 90, "/images/device (98).png" },
                    { 15, 151, "/images/device (196).png" },
                    { 16, 204, "/images/device (83).png" },
                    { 17, 192, "/images/device (251).png" },
                    { 18, 154, "/images/device (125).png" },
                    { 19, 181, "/images/device (25).png" },
                    { 20, 97, "/images/device (256).png" },
                    { 21, 36, "/images/device (116).png" },
                    { 22, 4, "/images/device (146).png" },
                    { 23, 169, "/images/device (143).png" },
                    { 24, 214, "/images/device (34).png" },
                    { 25, 227, "/images/device (153).png" },
                    { 26, 122, "/images/device (134).png" },
                    { 27, 179, "/images/device (56).png" },
                    { 28, 51, "/images/device (190).png" },
                    { 29, 163, "/images/device (246).png" },
                    { 30, 24, "/images/device (12).png" },
                    { 31, 6, "/images/device (93).png" },
                    { 32, 46, "/images/device (229).png" },
                    { 33, 185, "/images/device (96).png" },
                    { 34, 162, "/images/device (179).png" },
                    { 35, 22, "/images/device (169).png" },
                    { 36, 160, "/images/device (220).png" },
                    { 37, 201, "/images/device (240).png" },
                    { 38, 9, "/images/device (222).png" },
                    { 39, 64, "/images/device (235).png" },
                    { 40, 128, "/images/device (111).png" },
                    { 41, 235, "/images/device (119).png" },
                    { 42, 161, "/images/device (209).png" },
                    { 43, 8, "/images/device (257).png" },
                    { 44, 185, "/images/device (160).png" },
                    { 45, 222, "/images/device (7).png" },
                    { 46, 50, "/images/device (255).png" },
                    { 47, 204, "/images/device (100).png" },
                    { 48, 135, "/images/device (72).png" },
                    { 49, 232, "/images/device (272).png" },
                    { 50, 36, "/images/device (164).png" },
                    { 51, 138, "/images/device (214).png" },
                    { 52, 202, "/images/device (102).png" },
                    { 53, 63, "/images/device (192).png" },
                    { 54, 145, "/images/device (245).png" },
                    { 55, 14, "/images/device (237).png" },
                    { 56, 68, "/images/device (72).png" },
                    { 57, 60, "/images/device (60).png" },
                    { 58, 173, "/images/device (246).png" },
                    { 59, 224, "/images/device (236).png" },
                    { 60, 210, "/images/device (185).png" },
                    { 61, 89, "/images/device (154).png" },
                    { 62, 102, "/images/device (268).png" },
                    { 63, 173, "/images/device (75).png" },
                    { 64, 220, "/images/device (125).png" },
                    { 65, 105, "/images/device (151).png" },
                    { 66, 100, "/images/device (37).png" },
                    { 67, 21, "/images/device (195).png" },
                    { 68, 75, "/images/device (27).png" },
                    { 69, 49, "/images/device (92).png" },
                    { 70, 43, "/images/device (10).png" },
                    { 71, 204, "/images/device (52).png" },
                    { 72, 131, "/images/device (126).png" },
                    { 73, 234, "/images/device (46).png" },
                    { 74, 174, "/images/device (16).png" },
                    { 75, 203, "/images/device (174).png" },
                    { 76, 87, "/images/device (10).png" },
                    { 77, 184, "/images/device (26).png" },
                    { 78, 115, "/images/device (50).png" },
                    { 79, 218, "/images/device (197).png" },
                    { 80, 196, "/images/device (198).png" },
                    { 81, 12, "/images/device (161).png" },
                    { 82, 10, "/images/device (256).png" },
                    { 83, 37, "/images/device (11).png" },
                    { 84, 93, "/images/device (95).png" },
                    { 85, 128, "/images/device (149).png" },
                    { 86, 34, "/images/device (30).png" },
                    { 87, 144, "/images/device (18).png" },
                    { 88, 88, "/images/device (1).png" },
                    { 89, 78, "/images/device (76).png" },
                    { 90, 74, "/images/device (21).png" },
                    { 91, 80, "/images/device (14).png" },
                    { 92, 209, "/images/device (175).png" },
                    { 93, 154, "/images/device (179).png" },
                    { 94, 53, "/images/device (177).png" },
                    { 95, 193, "/images/device (71).png" },
                    { 96, 19, "/images/device (81).png" },
                    { 97, 40, "/images/device (1).png" },
                    { 98, 81, "/images/device (38).png" },
                    { 99, 29, "/images/device (253).png" },
                    { 100, 64, "/images/device (118).png" },
                    { 101, 112, "/images/device (26).png" },
                    { 102, 16, "/images/device (217).png" },
                    { 103, 14, "/images/device (27).png" },
                    { 104, 182, "/images/device (238).png" },
                    { 105, 21, "/images/device (200).png" },
                    { 106, 148, "/images/device (106).png" },
                    { 107, 164, "/images/device (260).png" },
                    { 108, 94, "/images/device (190).png" },
                    { 109, 186, "/images/device (8).png" },
                    { 110, 14, "/images/device (2).png" },
                    { 111, 114, "/images/device (119).png" },
                    { 112, 46, "/images/device (114).png" },
                    { 113, 75, "/images/device (138).png" },
                    { 114, 17, "/images/device (250).png" },
                    { 115, 221, "/images/device (191).png" },
                    { 116, 69, "/images/device (170).png" },
                    { 117, 32, "/images/device (82).png" },
                    { 118, 107, "/images/device (10).png" },
                    { 119, 91, "/images/device (190).png" },
                    { 120, 69, "/images/device (234).png" },
                    { 121, 217, "/images/device (62).png" },
                    { 122, 137, "/images/device (114).png" },
                    { 123, 46, "/images/device (54).png" },
                    { 124, 66, "/images/device (54).png" },
                    { 125, 5, "/images/device (141).png" },
                    { 126, 198, "/images/device (19).png" },
                    { 127, 49, "/images/device (61).png" },
                    { 128, 169, "/images/device (187).png" },
                    { 129, 207, "/images/device (225).png" },
                    { 130, 10, "/images/device (131).png" },
                    { 131, 97, "/images/device (11).png" },
                    { 132, 144, "/images/device (154).png" },
                    { 133, 123, "/images/device (19).png" },
                    { 134, 230, "/images/device (192).png" },
                    { 135, 174, "/images/device (19).png" },
                    { 136, 70, "/images/device (128).png" },
                    { 137, 122, "/images/device (232).png" },
                    { 138, 220, "/images/device (12).png" },
                    { 139, 88, "/images/device (164).png" },
                    { 140, 3, "/images/device (86).png" },
                    { 141, 155, "/images/device (114).png" },
                    { 142, 179, "/images/device (213).png" },
                    { 143, 233, "/images/device (224).png" },
                    { 144, 163, "/images/device (154).png" },
                    { 145, 13, "/images/device (140).png" },
                    { 146, 157, "/images/device (192).png" },
                    { 147, 47, "/images/device (188).png" },
                    { 148, 90, "/images/device (203).png" },
                    { 149, 206, "/images/device (73).png" },
                    { 150, 115, "/images/device (222).png" },
                    { 151, 20, "/images/device (237).png" },
                    { 152, 6, "/images/device (262).png" },
                    { 153, 220, "/images/device (225).png" },
                    { 154, 127, "/images/device (105).png" },
                    { 155, 122, "/images/device (266).png" },
                    { 156, 202, "/images/device (240).png" },
                    { 157, 179, "/images/device (30).png" },
                    { 158, 177, "/images/device (42).png" },
                    { 159, 84, "/images/device (28).png" },
                    { 160, 75, "/images/device (77).png" },
                    { 161, 151, "/images/device (38).png" },
                    { 162, 14, "/images/device (93).png" },
                    { 163, 55, "/images/device (118).png" },
                    { 164, 5, "/images/device (43).png" },
                    { 165, 163, "/images/device (24).png" },
                    { 166, 215, "/images/device (56).png" },
                    { 167, 153, "/images/device (135).png" },
                    { 168, 106, "/images/device (149).png" },
                    { 169, 3, "/images/device (133).png" },
                    { 170, 136, "/images/device (128).png" },
                    { 171, 123, "/images/device (72).png" },
                    { 172, 183, "/images/device (105).png" },
                    { 173, 136, "/images/device (68).png" },
                    { 174, 220, "/images/device (255).png" },
                    { 175, 235, "/images/device (55).png" },
                    { 176, 131, "/images/device (31).png" },
                    { 177, 106, "/images/device (193).png" },
                    { 178, 62, "/images/device (248).png" },
                    { 179, 142, "/images/device (17).png" },
                    { 180, 157, "/images/device (111).png" },
                    { 181, 220, "/images/device (222).png" },
                    { 182, 9, "/images/device (107).png" },
                    { 183, 66, "/images/device (16).png" },
                    { 184, 214, "/images/device (77).png" },
                    { 185, 44, "/images/device (184).png" },
                    { 186, 161, "/images/device (63).png" },
                    { 187, 103, "/images/device (28).png" },
                    { 188, 123, "/images/device (221).png" },
                    { 189, 18, "/images/device (147).png" },
                    { 190, 3, "/images/device (54).png" },
                    { 191, 1, "/images/device (5).png" },
                    { 192, 22, "/images/device (16).png" },
                    { 193, 118, "/images/device (4).png" },
                    { 194, 164, "/images/device (19).png" },
                    { 195, 200, "/images/device (89).png" },
                    { 196, 180, "/images/device (161).png" },
                    { 197, 141, "/images/device (140).png" },
                    { 198, 63, "/images/device (164).png" },
                    { 199, 73, "/images/device (118).png" },
                    { 200, 110, "/images/device (63).png" },
                    { 201, 32, "/images/device (68).png" },
                    { 202, 150, "/images/device (84).png" },
                    { 203, 139, "/images/device (88).png" },
                    { 204, 173, "/images/device (217).png" },
                    { 205, 68, "/images/device (265).png" },
                    { 206, 80, "/images/device (24).png" },
                    { 207, 144, "/images/device (67).png" },
                    { 208, 108, "/images/device (130).png" },
                    { 209, 167, "/images/device (121).png" },
                    { 210, 42, "/images/device (106).png" },
                    { 211, 101, "/images/device (120).png" },
                    { 212, 47, "/images/device (238).png" },
                    { 213, 144, "/images/device (136).png" },
                    { 214, 179, "/images/device (238).png" },
                    { 215, 10, "/images/device (253).png" },
                    { 216, 140, "/images/device (264).png" },
                    { 217, 208, "/images/device (35).png" },
                    { 218, 71, "/images/device (267).png" },
                    { 219, 187, "/images/device (140).png" },
                    { 220, 123, "/images/device (89).png" },
                    { 221, 134, "/images/device (157).png" },
                    { 222, 72, "/images/device (28).png" },
                    { 223, 130, "/images/device (5).png" },
                    { 224, 81, "/images/device (51).png" },
                    { 225, 36, "/images/device (219).png" },
                    { 226, 108, "/images/device (94).png" },
                    { 227, 42, "/images/device (171).png" },
                    { 228, 100, "/images/device (31).png" },
                    { 229, 94, "/images/device (29).png" },
                    { 230, 217, "/images/device (203).png" },
                    { 231, 14, "/images/device (270).png" },
                    { 232, 139, "/images/device (24).png" },
                    { 233, 151, "/images/device (42).png" },
                    { 234, 169, "/images/device (175).png" },
                    { 235, 231, "/images/device (122).png" },
                    { 236, 190, "/images/device (121).png" },
                    { 237, 88, "/images/device (180).png" },
                    { 238, 45, "/images/device (9).png" },
                    { 239, 77, "/images/device (149).png" },
                    { 240, 117, "/images/device (65).png" },
                    { 241, 68, "/images/device (42).png" },
                    { 242, 125, "/images/device (152).png" },
                    { 243, 152, "/images/device (235).png" },
                    { 244, 41, "/images/device (238).png" },
                    { 245, 52, "/images/device (197).png" },
                    { 246, 171, "/images/device (19).png" },
                    { 247, 236, "/images/device (196).png" },
                    { 248, 223, "/images/device (252).png" },
                    { 249, 2, "/images/device (79).png" },
                    { 250, 45, "/images/device (262).png" },
                    { 251, 161, "/images/device (257).png" },
                    { 252, 131, "/images/device (190).png" },
                    { 253, 199, "/images/device (17).png" },
                    { 254, 24, "/images/device (66).png" },
                    { 255, 54, "/images/device (92).png" },
                    { 256, 236, "/images/device (224).png" },
                    { 257, 185, "/images/device (268).png" },
                    { 258, 86, "/images/device (118).png" },
                    { 259, 95, "/images/device (209).png" },
                    { 260, 13, "/images/device (71).png" },
                    { 261, 3, "/images/device (122).png" },
                    { 262, 114, "/images/device (212).png" },
                    { 263, 81, "/images/device (210).png" },
                    { 264, 29, "/images/device (131).png" },
                    { 265, 174, "/images/device (164).png" },
                    { 266, 97, "/images/device (118).png" },
                    { 267, 51, "/images/device (62).png" },
                    { 268, 181, "/images/device (232).png" },
                    { 269, 40, "/images/device (45).png" },
                    { 270, 74, "/images/device (27).png" },
                    { 271, 204, "/images/device (270).png" },
                    { 272, 158, "/images/device (183).png" },
                    { 273, 31, "/images/device (14).png" },
                    { 274, 13, "/images/device (247).png" },
                    { 275, 41, "/images/device (125).png" },
                    { 276, 44, "/images/device (100).png" },
                    { 277, 169, "/images/device (121).png" },
                    { 278, 100, "/images/device (55).png" },
                    { 279, 192, "/images/device (52).png" },
                    { 280, 10, "/images/device (222).png" },
                    { 281, 122, "/images/device (136).png" },
                    { 282, 48, "/images/device (184).png" },
                    { 283, 220, "/images/device (217).png" },
                    { 284, 178, "/images/device (125).png" },
                    { 285, 158, "/images/device (269).png" },
                    { 286, 18, "/images/device (264).png" },
                    { 287, 157, "/images/device (139).png" },
                    { 288, 218, "/images/device (90).png" },
                    { 289, 1, "/images/device (141).png" },
                    { 290, 80, "/images/device (246).png" },
                    { 291, 201, "/images/device (125).png" },
                    { 292, 10, "/images/device (165).png" },
                    { 293, 148, "/images/device (9).png" },
                    { 294, 106, "/images/device (57).png" },
                    { 295, 200, "/images/device (112).png" },
                    { 296, 79, "/images/device (21).png" },
                    { 297, 159, "/images/device (98).png" },
                    { 298, 160, "/images/device (74).png" },
                    { 299, 125, "/images/device (121).png" },
                    { 300, 204, "/images/device (263).png" },
                    { 301, 124, "/images/device (117).png" },
                    { 302, 179, "/images/device (127).png" },
                    { 303, 220, "/images/device (119).png" },
                    { 304, 53, "/images/device (38).png" },
                    { 305, 111, "/images/device (10).png" },
                    { 306, 60, "/images/device (47).png" },
                    { 307, 177, "/images/device (195).png" },
                    { 308, 43, "/images/device (247).png" },
                    { 309, 85, "/images/device (186).png" },
                    { 310, 107, "/images/device (10).png" },
                    { 311, 45, "/images/device (195).png" },
                    { 312, 199, "/images/device (132).png" },
                    { 313, 88, "/images/device (189).png" },
                    { 314, 106, "/images/device (79).png" },
                    { 315, 184, "/images/device (224).png" },
                    { 316, 57, "/images/device (164).png" },
                    { 317, 34, "/images/device (175).png" },
                    { 318, 186, "/images/device (195).png" },
                    { 319, 173, "/images/device (262).png" },
                    { 320, 96, "/images/device (181).png" },
                    { 321, 38, "/images/device (259).png" },
                    { 322, 85, "/images/device (51).png" },
                    { 323, 84, "/images/device (68).png" },
                    { 324, 195, "/images/device (62).png" },
                    { 325, 137, "/images/device (214).png" },
                    { 326, 81, "/images/device (118).png" },
                    { 327, 134, "/images/device (191).png" },
                    { 328, 199, "/images/device (125).png" },
                    { 329, 188, "/images/device (76).png" },
                    { 330, 165, "/images/device (159).png" },
                    { 331, 8, "/images/device (13).png" },
                    { 332, 145, "/images/device (107).png" },
                    { 333, 82, "/images/device (223).png" },
                    { 334, 68, "/images/device (40).png" },
                    { 335, 122, "/images/device (136).png" },
                    { 336, 173, "/images/device (100).png" },
                    { 337, 157, "/images/device (261).png" },
                    { 338, 12, "/images/device (3).png" },
                    { 339, 70, "/images/device (24).png" },
                    { 340, 141, "/images/device (33).png" },
                    { 341, 167, "/images/device (6).png" },
                    { 342, 138, "/images/device (173).png" },
                    { 343, 213, "/images/device (209).png" },
                    { 344, 103, "/images/device (188).png" },
                    { 345, 200, "/images/device (149).png" },
                    { 346, 167, "/images/device (62).png" },
                    { 347, 61, "/images/device (234).png" },
                    { 348, 7, "/images/device (64).png" },
                    { 349, 1, "/images/device (103).png" },
                    { 350, 125, "/images/device (75).png" },
                    { 351, 193, "/images/device (108).png" },
                    { 352, 95, "/images/device (110).png" },
                    { 353, 103, "/images/device (14).png" },
                    { 354, 40, "/images/device (232).png" },
                    { 355, 165, "/images/device (90).png" },
                    { 356, 166, "/images/device (207).png" },
                    { 357, 32, "/images/device (126).png" },
                    { 358, 136, "/images/device (100).png" },
                    { 359, 45, "/images/device (100).png" },
                    { 360, 101, "/images/device (129).png" },
                    { 361, 51, "/images/device (141).png" },
                    { 362, 167, "/images/device (25).png" },
                    { 363, 236, "/images/device (36).png" },
                    { 364, 202, "/images/device (115).png" },
                    { 365, 211, "/images/device (181).png" },
                    { 366, 65, "/images/device (270).png" },
                    { 367, 21, "/images/device (182).png" },
                    { 368, 117, "/images/device (156).png" },
                    { 369, 49, "/images/device (226).png" },
                    { 370, 202, "/images/device (183).png" },
                    { 371, 47, "/images/device (1).png" },
                    { 372, 87, "/images/device (221).png" },
                    { 373, 146, "/images/device (133).png" },
                    { 374, 114, "/images/device (72).png" },
                    { 375, 223, "/images/device (234).png" },
                    { 376, 46, "/images/device (33).png" },
                    { 377, 201, "/images/device (24).png" },
                    { 378, 136, "/images/device (255).png" },
                    { 379, 82, "/images/device (154).png" },
                    { 380, 122, "/images/device (17).png" },
                    { 381, 92, "/images/device (195).png" },
                    { 382, 114, "/images/device (118).png" },
                    { 383, 87, "/images/device (60).png" },
                    { 384, 141, "/images/device (273).png" },
                    { 385, 31, "/images/device (244).png" },
                    { 386, 52, "/images/device (19).png" },
                    { 387, 205, "/images/device (153).png" },
                    { 388, 215, "/images/device (56).png" },
                    { 389, 169, "/images/device (193).png" },
                    { 390, 20, "/images/device (176).png" },
                    { 391, 106, "/images/device (221).png" },
                    { 392, 202, "/images/device (96).png" },
                    { 393, 216, "/images/device (266).png" },
                    { 394, 84, "/images/device (269).png" },
                    { 395, 144, "/images/device (175).png" },
                    { 396, 48, "/images/device (224).png" },
                    { 397, 172, "/images/device (269).png" },
                    { 398, 76, "/images/device (189).png" },
                    { 399, 116, "/images/device (209).png" },
                    { 400, 209, "/images/device (204).png" },
                    { 401, 114, "/images/device (208).png" },
                    { 402, 98, "/images/device (246).png" },
                    { 403, 234, "/images/device (258).png" },
                    { 404, 169, "/images/device (70).png" },
                    { 405, 46, "/images/device (116).png" },
                    { 406, 130, "/images/device (29).png" },
                    { 407, 151, "/images/device (10).png" },
                    { 408, 22, "/images/device (3).png" },
                    { 409, 59, "/images/device (116).png" },
                    { 410, 128, "/images/device (272).png" },
                    { 411, 95, "/images/device (212).png" },
                    { 412, 41, "/images/device (82).png" },
                    { 413, 2, "/images/device (49).png" },
                    { 414, 226, "/images/device (144).png" },
                    { 415, 148, "/images/device (223).png" },
                    { 416, 189, "/images/device (123).png" },
                    { 417, 84, "/images/device (67).png" },
                    { 418, 1, "/images/device (24).png" },
                    { 419, 231, "/images/device (193).png" },
                    { 420, 84, "/images/device (54).png" },
                    { 421, 204, "/images/device (253).png" },
                    { 422, 194, "/images/device (221).png" },
                    { 423, 18, "/images/device (217).png" },
                    { 424, 222, "/images/device (153).png" },
                    { 425, 210, "/images/device (167).png" },
                    { 426, 46, "/images/device (72).png" },
                    { 427, 110, "/images/device (262).png" },
                    { 428, 185, "/images/device (218).png" },
                    { 429, 132, "/images/device (30).png" },
                    { 430, 232, "/images/device (60).png" },
                    { 431, 94, "/images/device (73).png" },
                    { 432, 219, "/images/device (101).png" },
                    { 433, 41, "/images/device (158).png" },
                    { 434, 56, "/images/device (192).png" },
                    { 435, 99, "/images/device (163).png" },
                    { 436, 33, "/images/device (192).png" },
                    { 437, 139, "/images/device (177).png" },
                    { 438, 189, "/images/device (181).png" },
                    { 439, 24, "/images/device (16).png" },
                    { 440, 116, "/images/device (41).png" },
                    { 441, 227, "/images/device (121).png" },
                    { 442, 190, "/images/device (229).png" },
                    { 443, 58, "/images/device (29).png" },
                    { 444, 48, "/images/device (149).png" },
                    { 445, 181, "/images/device (121).png" },
                    { 446, 49, "/images/device (191).png" },
                    { 447, 60, "/images/device (194).png" },
                    { 448, 126, "/images/device (90).png" },
                    { 449, 22, "/images/device (121).png" },
                    { 450, 105, "/images/device (209).png" },
                    { 451, 173, "/images/device (216).png" },
                    { 452, 89, "/images/device (143).png" },
                    { 453, 96, "/images/device (64).png" },
                    { 454, 46, "/images/device (43).png" },
                    { 455, 153, "/images/device (270).png" },
                    { 456, 166, "/images/device (164).png" },
                    { 457, 66, "/images/device (258).png" },
                    { 458, 86, "/images/device (14).png" },
                    { 459, 125, "/images/device (145).png" },
                    { 460, 61, "/images/device (98).png" },
                    { 461, 183, "/images/device (204).png" },
                    { 462, 175, "/images/device (105).png" },
                    { 463, 96, "/images/device (253).png" },
                    { 464, 212, "/images/device (215).png" },
                    { 465, 31, "/images/device (153).png" },
                    { 466, 195, "/images/device (147).png" },
                    { 467, 27, "/images/device (104).png" },
                    { 468, 10, "/images/device (38).png" },
                    { 469, 31, "/images/device (26).png" },
                    { 470, 173, "/images/device (148).png" },
                    { 471, 44, "/images/device (210).png" },
                    { 472, 210, "/images/device (7).png" },
                    { 473, 84, "/images/device (42).png" },
                    { 474, 17, "/images/device (9).png" },
                    { 475, 42, "/images/device (46).png" },
                    { 476, 178, "/images/device (272).png" },
                    { 477, 70, "/images/device (43).png" },
                    { 478, 148, "/images/device (270).png" },
                    { 479, 126, "/images/device (190).png" },
                    { 480, 218, "/images/device (63).png" },
                    { 481, 215, "/images/device (57).png" },
                    { 482, 42, "/images/device (235).png" },
                    { 483, 78, "/images/device (61).png" },
                    { 484, 32, "/images/device (21).png" },
                    { 485, 232, "/images/device (263).png" },
                    { 486, 16, "/images/device (187).png" },
                    { 487, 28, "/images/device (261).png" },
                    { 488, 125, "/images/device (112).png" },
                    { 489, 159, "/images/device (112).png" },
                    { 490, 22, "/images/device (100).png" },
                    { 491, 52, "/images/device (269).png" },
                    { 492, 197, "/images/device (114).png" },
                    { 493, 51, "/images/device (269).png" },
                    { 494, 199, "/images/device (98).png" },
                    { 495, 187, "/images/device (183).png" },
                    { 496, 72, "/images/device (243).png" },
                    { 497, 74, "/images/device (134).png" },
                    { 498, 196, "/images/device (6).png" },
                    { 499, 206, "/images/device (237).png" },
                    { 500, 194, "/images/device (233).png" },
                    { 501, 158, "/images/device (32).png" },
                    { 502, 172, "/images/device (77).png" },
                    { 503, 70, "/images/device (37).png" },
                    { 504, 135, "/images/device (75).png" },
                    { 505, 230, "/images/device (54).png" },
                    { 506, 77, "/images/device (87).png" },
                    { 507, 140, "/images/device (111).png" },
                    { 508, 199, "/images/device (69).png" },
                    { 509, 218, "/images/device (202).png" },
                    { 510, 12, "/images/device (123).png" },
                    { 511, 207, "/images/device (91).png" },
                    { 512, 227, "/images/device (139).png" },
                    { 513, 120, "/images/device (17).png" },
                    { 514, 49, "/images/device (114).png" },
                    { 515, 78, "/images/device (176).png" },
                    { 516, 200, "/images/device (13).png" },
                    { 517, 131, "/images/device (118).png" },
                    { 518, 44, "/images/device (20).png" },
                    { 519, 205, "/images/device (252).png" },
                    { 520, 37, "/images/device (205).png" },
                    { 521, 30, "/images/device (34).png" },
                    { 522, 56, "/images/device (24).png" },
                    { 523, 219, "/images/device (207).png" },
                    { 524, 106, "/images/device (254).png" },
                    { 525, 194, "/images/device (91).png" },
                    { 526, 91, "/images/device (212).png" },
                    { 527, 79, "/images/device (272).png" },
                    { 528, 201, "/images/device (132).png" },
                    { 529, 71, "/images/device (200).png" },
                    { 530, 9, "/images/device (95).png" },
                    { 531, 139, "/images/device (150).png" },
                    { 532, 164, "/images/device (103).png" },
                    { 533, 41, "/images/device (194).png" },
                    { 534, 189, "/images/device (155).png" },
                    { 535, 73, "/images/device (38).png" },
                    { 536, 148, "/images/device (162).png" },
                    { 537, 173, "/images/device (227).png" },
                    { 538, 191, "/images/device (21).png" },
                    { 539, 192, "/images/device (184).png" },
                    { 540, 40, "/images/device (185).png" },
                    { 541, 199, "/images/device (219).png" },
                    { 542, 95, "/images/device (24).png" },
                    { 543, 236, "/images/device (87).png" },
                    { 544, 188, "/images/device (134).png" },
                    { 545, 136, "/images/device (191).png" },
                    { 546, 8, "/images/device (166).png" },
                    { 547, 188, "/images/device (109).png" },
                    { 548, 79, "/images/device (109).png" },
                    { 549, 180, "/images/device (148).png" },
                    { 550, 17, "/images/device (220).png" },
                    { 551, 161, "/images/device (88).png" },
                    { 552, 12, "/images/device (200).png" },
                    { 553, 116, "/images/device (164).png" },
                    { 554, 216, "/images/device (51).png" },
                    { 555, 150, "/images/device (249).png" },
                    { 556, 128, "/images/device (251).png" },
                    { 557, 41, "/images/device (38).png" },
                    { 558, 100, "/images/device (150).png" },
                    { 559, 155, "/images/device (227).png" },
                    { 560, 59, "/images/device (7).png" },
                    { 561, 22, "/images/device (101).png" },
                    { 562, 145, "/images/device (166).png" },
                    { 563, 32, "/images/device (270).png" },
                    { 564, 173, "/images/device (231).png" },
                    { 565, 18, "/images/device (153).png" },
                    { 566, 154, "/images/device (188).png" },
                    { 567, 104, "/images/device (114).png" },
                    { 568, 115, "/images/device (216).png" },
                    { 569, 16, "/images/device (106).png" },
                    { 570, 43, "/images/device (33).png" },
                    { 571, 185, "/images/device (191).png" },
                    { 572, 196, "/images/device (131).png" },
                    { 573, 4, "/images/device (5).png" },
                    { 574, 83, "/images/device (85).png" },
                    { 575, 127, "/images/device (248).png" },
                    { 576, 65, "/images/device (147).png" },
                    { 577, 46, "/images/device (78).png" },
                    { 578, 133, "/images/device (203).png" },
                    { 579, 183, "/images/device (123).png" },
                    { 580, 134, "/images/device (227).png" },
                    { 581, 229, "/images/device (74).png" },
                    { 582, 214, "/images/device (75).png" },
                    { 583, 41, "/images/device (228).png" },
                    { 584, 150, "/images/device (61).png" },
                    { 585, 169, "/images/device (141).png" },
                    { 586, 199, "/images/device (101).png" },
                    { 587, 63, "/images/device (170).png" },
                    { 588, 165, "/images/device (224).png" },
                    { 589, 11, "/images/device (67).png" },
                    { 590, 109, "/images/device (91).png" },
                    { 591, 27, "/images/device (29).png" },
                    { 592, 27, "/images/device (210).png" },
                    { 593, 28, "/images/device (130).png" },
                    { 594, 221, "/images/device (32).png" },
                    { 595, 84, "/images/device (221).png" },
                    { 596, 24, "/images/device (170).png" },
                    { 597, 149, "/images/device (162).png" },
                    { 598, 68, "/images/device (43).png" },
                    { 599, 47, "/images/device (26).png" },
                    { 600, 111, "/images/device (206).png" },
                    { 601, 158, "/images/device (51).png" },
                    { 602, 233, "/images/device (84).png" },
                    { 603, 118, "/images/device (239).png" },
                    { 604, 236, "/images/device (48).png" },
                    { 605, 189, "/images/device (223).png" },
                    { 606, 136, "/images/device (92).png" },
                    { 607, 58, "/images/device (38).png" },
                    { 608, 56, "/images/device (101).png" },
                    { 609, 106, "/images/device (180).png" },
                    { 610, 6, "/images/device (182).png" },
                    { 611, 206, "/images/device (191).png" },
                    { 612, 205, "/images/device (26).png" },
                    { 613, 136, "/images/device (19).png" },
                    { 614, 26, "/images/device (9).png" },
                    { 615, 5, "/images/device (5).png" },
                    { 616, 8, "/images/device (260).png" },
                    { 617, 183, "/images/device (246).png" },
                    { 618, 212, "/images/device (65).png" },
                    { 619, 14, "/images/device (16).png" },
                    { 620, 59, "/images/device (87).png" },
                    { 621, 61, "/images/device (159).png" },
                    { 622, 221, "/images/device (258).png" },
                    { 623, 75, "/images/device (155).png" },
                    { 624, 214, "/images/device (172).png" },
                    { 625, 190, "/images/device (256).png" },
                    { 626, 203, "/images/device (30).png" },
                    { 627, 214, "/images/device (139).png" },
                    { 628, 54, "/images/device (169).png" },
                    { 629, 178, "/images/device (16).png" },
                    { 630, 141, "/images/device (58).png" },
                    { 631, 14, "/images/device (107).png" },
                    { 632, 232, "/images/device (145).png" },
                    { 633, 220, "/images/device (90).png" },
                    { 634, 231, "/images/device (37).png" },
                    { 635, 1, "/images/device (84).png" },
                    { 636, 228, "/images/device (31).png" },
                    { 637, 197, "/images/device (15).png" },
                    { 638, 66, "/images/device (254).png" },
                    { 639, 145, "/images/device (232).png" },
                    { 640, 20, "/images/device (122).png" },
                    { 641, 22, "/images/device (114).png" },
                    { 642, 176, "/images/device (257).png" },
                    { 643, 111, "/images/device (107).png" },
                    { 644, 194, "/images/device (42).png" },
                    { 645, 119, "/images/device (181).png" },
                    { 646, 209, "/images/device (176).png" },
                    { 647, 75, "/images/device (145).png" },
                    { 648, 77, "/images/device (253).png" },
                    { 649, 196, "/images/device (76).png" },
                    { 650, 202, "/images/device (36).png" },
                    { 651, 4, "/images/device (148).png" },
                    { 652, 139, "/images/device (157).png" },
                    { 653, 48, "/images/device (208).png" },
                    { 654, 131, "/images/device (116).png" },
                    { 655, 1, "/images/device (15).png" },
                    { 656, 108, "/images/device (272).png" },
                    { 657, 111, "/images/device (146).png" },
                    { 658, 40, "/images/device (73).png" },
                    { 659, 150, "/images/device (74).png" },
                    { 660, 230, "/images/device (203).png" },
                    { 661, 138, "/images/device (228).png" },
                    { 662, 98, "/images/device (25).png" },
                    { 663, 171, "/images/device (183).png" },
                    { 664, 218, "/images/device (261).png" },
                    { 665, 4, "/images/device (221).png" },
                    { 666, 3, "/images/device (43).png" },
                    { 667, 29, "/images/device (231).png" },
                    { 668, 173, "/images/device (42).png" },
                    { 669, 42, "/images/device (21).png" },
                    { 670, 103, "/images/device (46).png" },
                    { 671, 25, "/images/device (73).png" },
                    { 672, 213, "/images/device (180).png" },
                    { 673, 166, "/images/device (36).png" },
                    { 674, 87, "/images/device (103).png" },
                    { 675, 124, "/images/device (92).png" },
                    { 676, 193, "/images/device (213).png" },
                    { 677, 45, "/images/device (167).png" },
                    { 678, 134, "/images/device (85).png" },
                    { 679, 104, "/images/device (122).png" },
                    { 680, 37, "/images/device (79).png" },
                    { 681, 97, "/images/device (52).png" },
                    { 682, 229, "/images/device (27).png" },
                    { 683, 230, "/images/device (186).png" },
                    { 684, 90, "/images/device (210).png" },
                    { 685, 173, "/images/device (186).png" },
                    { 686, 202, "/images/device (89).png" },
                    { 687, 169, "/images/device (48).png" },
                    { 688, 39, "/images/device (49).png" },
                    { 689, 87, "/images/device (154).png" },
                    { 690, 153, "/images/device (43).png" },
                    { 691, 92, "/images/device (269).png" },
                    { 692, 144, "/images/device (104).png" },
                    { 693, 146, "/images/device (180).png" },
                    { 694, 204, "/images/device (76).png" },
                    { 695, 78, "/images/device (155).png" },
                    { 696, 146, "/images/device (54).png" },
                    { 697, 105, "/images/device (176).png" },
                    { 698, 206, "/images/device (167).png" },
                    { 699, 212, "/images/device (190).png" },
                    { 700, 232, "/images/device (207).png" },
                    { 701, 224, "/images/device (109).png" },
                    { 702, 15, "/images/device (171).png" },
                    { 703, 46, "/images/device (193).png" },
                    { 704, 54, "/images/device (230).png" },
                    { 705, 120, "/images/device (241).png" },
                    { 706, 59, "/images/device (26).png" },
                    { 707, 34, "/images/device (243).png" },
                    { 708, 41, "/images/device (137).png" },
                    { 709, 47, "/images/device (199).png" },
                    { 710, 97, "/images/device (251).png" },
                    { 711, 185, "/images/device (177).png" },
                    { 712, 187, "/images/device (11).png" },
                    { 713, 140, "/images/device (123).png" },
                    { 714, 132, "/images/device (258).png" },
                    { 715, 136, "/images/device (94).png" },
                    { 716, 201, "/images/device (46).png" },
                    { 717, 216, "/images/device (47).png" },
                    { 718, 60, "/images/device (5).png" },
                    { 719, 19, "/images/device (163).png" },
                    { 720, 49, "/images/device (121).png" },
                    { 721, 62, "/images/device (139).png" },
                    { 722, 226, "/images/device (74).png" },
                    { 723, 130, "/images/device (207).png" },
                    { 724, 93, "/images/device (192).png" },
                    { 725, 101, "/images/device (187).png" },
                    { 726, 139, "/images/device (178).png" },
                    { 727, 52, "/images/device (273).png" },
                    { 728, 194, "/images/device (172).png" },
                    { 729, 136, "/images/device (11).png" },
                    { 730, 55, "/images/device (256).png" },
                    { 731, 222, "/images/device (31).png" },
                    { 732, 142, "/images/device (124).png" },
                    { 733, 72, "/images/device (29).png" },
                    { 734, 134, "/images/device (104).png" },
                    { 735, 78, "/images/device (91).png" },
                    { 736, 157, "/images/device (65).png" },
                    { 737, 206, "/images/device (91).png" },
                    { 738, 88, "/images/device (40).png" },
                    { 739, 154, "/images/device (179).png" },
                    { 740, 136, "/images/device (21).png" },
                    { 741, 214, "/images/device (265).png" },
                    { 742, 77, "/images/device (43).png" },
                    { 743, 27, "/images/device (90).png" },
                    { 744, 159, "/images/device (222).png" },
                    { 745, 66, "/images/device (262).png" },
                    { 746, 117, "/images/device (35).png" },
                    { 747, 102, "/images/device (68).png" },
                    { 748, 141, "/images/device (203).png" },
                    { 749, 65, "/images/device (71).png" },
                    { 750, 169, "/images/device (8).png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShopId",
                table: "AspNetUsers",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_VoucherId",
                table: "Orders",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShopId",
                table: "Products",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewsImage_ReviewsId",
                table: "ReviewsImage",
                column: "ReviewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_ShopCategoryId",
                table: "Shops",
                column: "ShopCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_VoucherCategoryId",
                table: "Vouchers",
                column: "VoucherCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ReviewsImage");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "VoucherCategory");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "ShopCategories");
        }
    }
}

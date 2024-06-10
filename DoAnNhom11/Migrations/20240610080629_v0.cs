using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoAnNhom11.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
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
                    BiChan = table.Column<bool>(type: "bit", nullable: true),
                    ShopCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                    table.ForeignKey(
                        name: "FK_Shops_ShopCategories_ShopCategoryId",
                        column: x => x.ShopCategoryId,
                        principalTable: "ShopCategories",
                        principalColumn: "ShopCategoryId");
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
                    MaSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Vouchers",
                columns: table => new
                {
                    VoucherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: false),
                    GiamToiDa = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DonToiThieu = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongCon = table.Column<int>(type: "int", nullable: false),
                    VoucherCategoryId = table.Column<int>(type: "int", nullable: false),
                    ShopId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherId);
                    table.ForeignKey(
                        name: "FK_Vouchers_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "ShopId");
                    table.ForeignKey(
                        name: "FK_Vouchers_VoucherCategory_VoucherCategoryId",
                        column: x => x.VoucherCategoryId,
                        principalTable: "VoucherCategory",
                        principalColumn: "VoucherCategoryId",
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderStatusId1 = table.Column<int>(type: "int", nullable: true)
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
                        principalColumn: "OrderStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusId1",
                        column: x => x.OrderStatusId1,
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
                    { 6, "Đã Hủy Đơn" },
                    { 9, "Chờ xác nhận yêu cầu trả hàng" },
                    { 10, "Đã xác nhận yêu cầu trả hàng" },
                    { 11, "Đã trả hàng" }
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
                    { 1, "Tạp Hóa" },
                    { 2, "Thời Trang" },
                    { 3, "Trang Sức" },
                    { 4, "Thực Phẩm" },
                    { 5, "Sách" },
                    { 6, "Làm Đẹp" },
                    { 7, "Đồ Chơi" },
                    { 8, "Đồ Gia Dụng" },
                    { 9, "công nghệ" }
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
                columns: new[] { "ShopId", "AnhBia", "AnhDaiDien", "BiChan", "DiaChi", "LienHe", "MoTa", "NgayTao", "ShopCategoryId", "TenCuaHang" },
                values: new object[,]
                {
                    { 1, "/images/device (38).png", "/images/device (147).png", null, "yUuDPJdP06,B9lCVoAIEg,w3jsej96tq", "6ov6q6RD4i", "Mô tả mẫu của sản phẩm2", new DateTime(2024, 6, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3215), 6, "Shop:PJtUceJWUC1" },
                    { 2, "/images/device (119).png", "/images/device (84).png", null, "rX99G9bE0G,7beMsYJTzl,eQi5YiOLFX", "hQCsnMtK5g", "Mô tả mẫu của cửa hàng3", new DateTime(2024, 6, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3246), 7, "ShopuM1WqYbZKy2" },
                    { 3, "/images/device (42).png", "/images/device (54).png", null, "OjBQiZQRXN,jRRtpBFJMT,da4HrZEldy", "JUa1uGMYnc", "Mô tả mẫu của sản phẩm4", new DateTime(2024, 6, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3333), 5, "Shop:6YwyLS2V6M3" },
                    { 4, "/images/device (66).png", "/images/device (124).png", null, "aD3WvwQDCT,sYSRfI5V6T,jKtbJTurhF", "LHgDZakSOp", "Mô tả mẫu của sản phẩm5", new DateTime(2024, 6, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3353), 6, "Shop:u8Sp2uOMqo4" },
                    { 5, "/images/device (79).png", "/images/device (216).png", null, "iigkH96TMs,yy5t5VIiYq,e9imsLxX13", "yRy2pdiTcc", "Mô tả mẫu của sản phẩm6", new DateTime(2024, 6, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3374), 1, "Shop:6qDncIb3Mo5" },
                    { 6, "/images/device (174).png", "/images/device (181).png", null, "UifiQLHp98,vp7m1iHSQq,syRvwlHCKE", "QpdlFhQqnN", "Mô tả mẫu của sản phẩm7", new DateTime(2024, 6, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3392), 7, "Shop:DWyZgzJpw86" },
                    { 7, "/images/device (78).png", "/images/device (179).png", null, "KCtqHH1gkx,Sw9FhBG4fX,Nwp8X2XEiH", "417W7Bcn7D", "Mô tả mẫu của sản phẩm8", new DateTime(2024, 6, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3412), 4, "Shop:VqPeh9RCnC7" },
                    { 8, "/images/device (265).png", "/images/device (184).png", null, "QXrb5YLRdb,R1TWTykY64,0e3sAYFfZ8", "BD2hQxLz8e", "Mô tả mẫu của sản phẩm9", new DateTime(2024, 6, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3433), 1, "Shop:baIUX06AB98" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "VoucherId", "DonToiThieu", "GiamToiDa", "NgayBatDau", "NgayHetHan", "PhanTramGiam", "ShopId", "SoLuongCon", "VoucherCategoryId", "VoucherCode" },
                values: new object[,]
                {
                    { 1, -1m, -1m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3055), 0, null, 100, 1, "mặc định" },
                    { 2, 3000000m, 15000m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3084), 10, null, 100, 2, "GIAMGIA2" },
                    { 3, 10000000m, 50000m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3088), 15, null, 100, 3, "GIAMGIA3" },
                    { 4, 8000000m, 100000m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3092), 12, null, 100, 4, "GIAMGIA4" },
                    { 5, 5000000m, 20000m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3095), 7, null, 100, 4, "GIAMGIA5" },
                    { 6, -1m, -1m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3098), 8, null, 100, 4, "GIAMGIA5" },
                    { 7, 12000000m, -1m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3102), 15, null, 100, 4, "GIAMGIA5" },
                    { 8, -1m, 40000m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3104), 21, null, 100, 4, "GIAMGIA5" },
                    { 9, 12000000m, 1000000m, null, new DateTime(2024, 8, 10, 15, 6, 28, 297, DateTimeKind.Local).AddTicks(3107), 16, null, 100, 4, "GIAMGIA5" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AnhDaiDien", "BrandId", "DaAn", "DiemDanhGia", "GiaBan", "GiaNhap", "MaSP", "MoTa", "PhanTramGiam", "ProductCategoryId", "ShopId", "SoLuongCon", "TenSp", "ThongSo" },
                values: new object[,]
                {
                    { 1, "/images/device (208).png", 7, false, null, 3000000m, 38000000m, null, "Mô tả mẫu của sản phẩm1", 20, 17, 6, 400, "57wqIhQzXx1", "RAM:300GB Man hinh :16inch" },
                    { 2, "/images/device (162).png", 3, false, null, 4700000m, 21000000m, null, "Mô tả mẫu của sản phẩm2", 36, 8, 7, 300, "OieCBuT9Sf2", "RAM:22Memory:461GB Man hinh :16inch" },
                    { 3, "/images/device (106).png", 5, false, null, 3600000m, 12000000m, null, "Mô tả mẫu của sản phẩm3", 9, 10, 3, 400, "v5Y5P8wGpG3", "RAM:11Memory:263GB Man hinh :8inch" },
                    { 4, "/images/device (210).png", 6, false, null, 1300000m, 45000000m, null, "Mô tả mẫu của sản phẩm4", 29, 16, 7, 100, "yqDpV4f8n94", "RAM:22Memory:306GB Man hinh :16inch" },
                    { 5, "/images/device (256).png", 8, false, null, 4700000m, 40000000m, null, "Mô tả mẫu của sản phẩm5", 30, 10, 1, 300, "q2p4wL418E5", "RAM:25Memory:144GB Man hinh :12inch" },
                    { 6, "/images/device (128).png", 1, false, null, 3000000m, 37000000m, null, "Mô tả mẫu của sản phẩm6", 19, 16, 7, 200, "STxfZnZUkU6", "RAM:14Memory:169GB Man hinh :8inch" },
                    { 7, "/images/device (18).png", 2, false, null, 1600000m, 30000000m, null, "Mô tả mẫu của sản phẩm7", 5, 26, 4, 400, "ujjbUPJQOM7", "RAM:30Memory:250GB Man hinh :12inch" },
                    { 8, "/images/device (115).png", 3, false, null, 500000m, 47000000m, null, "Mô tả mẫu của sản phẩm8", 26, 1, 3, 400, "fQ1ljW3qRA8", "RAM:29Memory:419GB Man hinh :16inch" },
                    { 9, "/images/device (131).png", 5, false, null, 4300000m, 48000000m, null, "Mô tả mẫu của sản phẩm9", 10, 21, 2, 100, "4SAsu0mCZa9", "RAM:1Memory:479GB Man hinh :12inch" },
                    { 10, "/images/device (124).png", 4, false, null, 3100000m, 12000000m, null, "Mô tả mẫu của sản phẩm10", 28, 4, 5, 300, "9H08wmpk1p10", "RAM:24Memory:49GB Man hinh :12inch" },
                    { 11, "/images/device (244).png", 4, false, null, 2100000m, 42000000m, null, "Mô tả mẫu của sản phẩm11", 36, 24, 2, 300, "kLyjSrLlUv11", "RAM:13Memory:76GB Man hinh :16inch" },
                    { 12, "/images/device (157).png", 2, false, null, 800000m, 38000000m, null, "Mô tả mẫu của sản phẩm12", 30, 18, 3, 100, "uztjNymOiG12", "RAM:11Memory:61GB Man hinh :8inch" },
                    { 13, "/images/device (231).png", 7, false, null, 3900000m, 28000000m, null, "Mô tả mẫu của sản phẩm13", 14, 16, 7, 300, "mJsNEvEuqL13", "RAM:22Memory:491GB Man hinh :8inch" },
                    { 14, "/images/device (115).png", 6, false, null, 1000000m, 43000000m, null, "Mô tả mẫu của sản phẩm14", 36, 20, 6, 400, "OGaUVaqKjX14", "RAM:16Memory:397GB Man hinh :12inch" },
                    { 15, "/images/device (62).png", 6, false, null, 2800000m, 9000000m, null, "Mô tả mẫu của sản phẩm15", 13, 25, 3, 200, "kmRwKR5hHQ15", "RAM:6Memory:213GB Man hinh :16inch" },
                    { 16, "/images/device (264).png", 6, false, null, 4400000m, 17000000m, null, "Mô tả mẫu của sản phẩm16", 21, 17, 3, 400, "Sb9ptfa1MK16", "RAM:9Memory:295GB Man hinh :8inch" },
                    { 17, "/images/device (211).png", 1, false, null, 300000m, 16000000m, null, "Mô tả mẫu của sản phẩm17", 39, 18, 2, 400, "qKarTjwMeE17", "RAM:25Memory:499GB Man hinh :16inch" },
                    { 18, "/images/device (27).png", 1, false, null, 1100000m, 22000000m, null, "Mô tả mẫu của sản phẩm18", 30, 20, 8, 100, "Fy57kcpS9S18", "RAM:18Memory:141GB Man hinh :12inch" },
                    { 19, "/images/device (151).png", 7, false, null, 1100000m, 16000000m, null, "Mô tả mẫu của sản phẩm19", 33, 23, 8, 300, "R1U7XC73HX19", "RAM:17Memory:47GB Man hinh :8inch" },
                    { 20, "/images/device (67).png", 6, false, null, 4600000m, 33000000m, null, "Mô tả mẫu của sản phẩm20", 25, 15, 6, 300, "4lMszWhi3w20", "RAM:14Memory:85GB Man hinh :4inch" },
                    { 21, "/images/device (41).png", 4, false, null, 3000000m, 32000000m, null, "Mô tả mẫu của sản phẩm21", 25, 12, 2, 400, "P9LVIMKTwK21", "RAM:23Memory:292GB Man hinh :16inch" },
                    { 22, "/images/device (206).png", 5, false, null, 900000m, 2000000m, null, "Mô tả mẫu của sản phẩm22", 27, 1, 5, 200, "gCdm8M0UpP22", "RAM:3Memory:450GB Man hinh :16inch" },
                    { 23, "/images/device (238).png", 6, false, null, 2800000m, 10000000m, null, "Mô tả mẫu của sản phẩm23", 30, 12, 6, 300, "aQzLf9T9HV23", "RAM:11Memory:480GB Man hinh :12inch" },
                    { 24, "/images/device (148).png", 2, false, null, 1100000m, 25000000m, null, "Mô tả mẫu của sản phẩm24", 26, 18, 8, 400, "KozgM4gMZ424", "RAM:6Memory:288GB Man hinh :4inch" },
                    { 25, "/images/device (242).png", 8, false, null, 500000m, 13000000m, null, "Mô tả mẫu của sản phẩm25", 25, 20, 8, 200, "AqBYFzTiJq25", "RAM:10Memory:173GB Man hinh :4inch" },
                    { 26, "/images/device (36).png", 7, false, null, 1300000m, 40000000m, null, "Mô tả mẫu của sản phẩm26", 25, 15, 2, 300, "Xq8DWMNftw26", "RAM:2Memory:305GB Man hinh :8inch" },
                    { 27, "/images/device (40).png", 3, false, null, 3600000m, 20000000m, null, "Mô tả mẫu của sản phẩm27", 10, 6, 7, 200, "np990coiHw27", "RAM:20Memory:331GB Man hinh :4inch" },
                    { 28, "/images/device (181).png", 5, false, null, 1800000m, 43000000m, null, "Mô tả mẫu của sản phẩm28", 15, 24, 5, 200, "ZkFmM4Ztih28", "RAM:30Memory:386GB Man hinh :16inch" },
                    { 29, "/images/device (52).png", 8, false, null, 4300000m, 18000000m, null, "Mô tả mẫu của sản phẩm29", 28, 10, 1, 100, "N0QHiv0lpP29", "RAM:21Memory:253GB Man hinh :12inch" },
                    { 30, "/images/device (15).png", 2, false, null, 4300000m, 45000000m, null, "Mô tả mẫu của sản phẩm30", 38, 21, 3, 100, "K6WTWrzcaO30", "RAM:23Memory:489GB Man hinh :4inch" },
                    { 31, "/images/device (104).png", 5, false, null, 4600000m, 17000000m, null, "Mô tả mẫu của sản phẩm31", 28, 4, 7, 200, "elSx59WyFb31", "RAM:28Memory:433GB Man hinh :16inch" },
                    { 32, "/images/device (236).png", 5, false, null, 3400000m, 14000000m, null, "Mô tả mẫu của sản phẩm32", 26, 19, 6, 300, "rXwZCDepc432", "RAM:1Memory:380GB Man hinh :4inch" },
                    { 33, "/images/device (3).png", 1, false, null, 1400000m, 16000000m, null, "Mô tả mẫu của sản phẩm33", 39, 11, 1, 200, "JJjS8JANtU33", "RAM:24Memory:147GB Man hinh :8inch" },
                    { 34, "/images/device (154).png", 4, false, null, 1200000m, 40000000m, null, "Mô tả mẫu của sản phẩm34", 27, 22, 2, 300, "J10Uze8SJI34", "RAM:29Memory:339GB Man hinh :12inch" },
                    { 35, "/images/device (43).png", 1, false, null, 800000m, 43000000m, null, "Mô tả mẫu của sản phẩm35", 11, 22, 4, 300, "yk3uAldaf735", "RAM:3Memory:438GB Man hinh :8inch" },
                    { 36, "/images/device (146).png", 5, false, null, 2600000m, 23000000m, null, "Mô tả mẫu của sản phẩm36", 31, 20, 6, 400, "P46OeJacpB36", "RAM:5Memory:352GB Man hinh :4inch" },
                    { 37, "/images/device (205).png", 2, false, null, 3500000m, 32000000m, null, "Mô tả mẫu của sản phẩm37", 15, 3, 7, 300, "H5eFenf9m137", "RAM:16Memory:296GB Man hinh :16inch" },
                    { 38, "/images/device (157).png", 2, false, null, 2000000m, 30000000m, null, "Mô tả mẫu của sản phẩm38", 25, 9, 4, 200, "irLUH3mcf638", "RAM:22Memory:57GB Man hinh :4inch" },
                    { 39, "/images/device (270).png", 6, false, null, 500000m, 40000000m, null, "Mô tả mẫu của sản phẩm39", 20, 24, 2, 400, "RAteE00SHz39", "RAM:31Memory:154GB Man hinh :8inch" },
                    { 40, "/images/device (224).png", 7, false, null, 2900000m, 46000000m, null, "Mô tả mẫu của sản phẩm40", 25, 10, 3, 200, "r6Fhpo5bB340", "RAM:22Memory:58GB Man hinh :16inch" },
                    { 41, "/images/device (183).png", 8, false, null, 3200000m, 43000000m, null, "Mô tả mẫu của sản phẩm41", 39, 10, 6, 200, "iK5b0hlvWg41", "RAM:29Memory:347GB Man hinh :8inch" },
                    { 42, "/images/device (245).png", 6, false, null, 3800000m, 33000000m, null, "Mô tả mẫu của sản phẩm42", 17, 22, 5, 300, "4res8JgyHa42", "RAM:19Memory:77GB Man hinh :16inch" },
                    { 43, "/images/device (7).png", 2, false, null, 4000000m, 6000000m, null, "Mô tả mẫu của sản phẩm43", 25, 2, 3, 400, "QhJHNdLeMV43", "RAM:26Memory:485GB Man hinh :16inch" },
                    { 44, "/images/device (68).png", 1, false, null, 1500000m, 40000000m, null, "Mô tả mẫu của sản phẩm44", 14, 26, 3, 300, "ENHqngStDq44", "RAM:12Memory:431GB Man hinh :12inch" },
                    { 45, "/images/device (7).png", 8, false, null, 2000000m, 14000000m, null, "Mô tả mẫu của sản phẩm45", 16, 18, 7, 400, "7QExgUAnoU45", "RAM:12Memory:337GB Man hinh :16inch" },
                    { 46, "/images/device (268).png", 8, false, null, 1300000m, 1000000m, null, "Mô tả mẫu của sản phẩm46", 33, 7, 6, 100, "eLleIa0Jdp46", "RAM:2Memory:83GB Man hinh :12inch" },
                    { 47, "/images/device (29).png", 6, false, null, 4800000m, 47000000m, null, "Mô tả mẫu của sản phẩm47", 19, 3, 8, 400, "c6KbUqsIAI47", "RAM:23Memory:250GB Man hinh :4inch" },
                    { 48, "/images/device (177).png", 3, false, null, 1900000m, 23000000m, null, "Mô tả mẫu của sản phẩm48", 37, 26, 3, 200, "oUNQj5KiJQ48", "RAM:3Memory:505GB Man hinh :12inch" },
                    { 49, "/images/device (233).png", 7, false, null, 2600000m, 42000000m, null, "Mô tả mẫu của sản phẩm49", 21, 3, 6, 300, "RyW961BQ0449", "RAM:29Memory:198GB Man hinh :8inch" },
                    { 50, "/images/device (48).png", 1, false, null, 1500000m, 3000000m, null, "Mô tả mẫu của sản phẩm50", 14, 27, 5, 100, "12iqg2jej850", "RAM:9Memory:455GB Man hinh :12inch" },
                    { 51, "/images/device (190).png", 4, false, null, 1600000m, 14000000m, null, "Mô tả mẫu của sản phẩm51", 13, 4, 4, 400, "wozRhMMmQv51", "RAM:25Memory:92GB Man hinh :12inch" },
                    { 52, "/images/device (103).png", 5, false, null, 3900000m, 39000000m, null, "Mô tả mẫu của sản phẩm52", 9, 15, 5, 100, "yotdNo3qPC52", "RAM:17Memory:321GB Man hinh :12inch" },
                    { 53, "/images/device (89).png", 4, false, null, 4100000m, 26000000m, null, "Mô tả mẫu của sản phẩm53", 31, 3, 6, 400, "GqmIYWrPHV53", "RAM:7Memory:379GB Man hinh :8inch" },
                    { 54, "/images/device (73).png", 5, false, null, 4900000m, 15000000m, null, "Mô tả mẫu của sản phẩm54", 6, 20, 6, 100, "EK5Oggk4R054", "RAM:6Memory:71GB Man hinh :16inch" },
                    { 55, "/images/device (251).png", 7, false, null, 100000m, 12000000m, null, "Mô tả mẫu của sản phẩm55", 19, 3, 1, 200, "p1pkLm9qdC55", "RAM:9Memory:241GB Man hinh :8inch" },
                    { 56, "/images/device (23).png", 1, false, null, 2400000m, 14000000m, null, "Mô tả mẫu của sản phẩm56", 38, 23, 7, 100, "n8ApR7cC4j56", "RAM:20Memory:243GB Man hinh :16inch" },
                    { 57, "/images/device (103).png", 6, false, null, 2700000m, 18000000m, null, "Mô tả mẫu của sản phẩm57", 23, 10, 6, 300, "oxx9OI2ifM57", "RAM:11Memory:141GB Man hinh :4inch" },
                    { 58, "/images/device (243).png", 5, false, null, 600000m, 8000000m, null, "Mô tả mẫu của sản phẩm58", 38, 3, 6, 300, "b93MitzCSs58", "RAM:24Memory:225GB Man hinh :8inch" },
                    { 59, "/images/device (249).png", 5, false, null, 3300000m, 25000000m, null, "Mô tả mẫu của sản phẩm59", 39, 19, 6, 200, "7hKrKXjt1459", "RAM:26Memory:74GB Man hinh :16inch" },
                    { 60, "/images/device (136).png", 6, false, null, 2500000m, 36000000m, null, "Mô tả mẫu của sản phẩm60", 12, 25, 3, 100, "9QASkacOg060", "RAM:5Memory:359GB Man hinh :8inch" },
                    { 61, "/images/device (75).png", 3, false, null, 700000m, 25000000m, null, "Mô tả mẫu của sản phẩm61", 38, 16, 2, 300, "UjgdCTiDx361", "RAM:24Memory:95GB Man hinh :8inch" },
                    { 62, "/images/device (76).png", 7, false, null, 300000m, 42000000m, null, "Mô tả mẫu của sản phẩm62", 26, 1, 8, 200, "ebqEt7s90h62", "RAM:13Memory:92GB Man hinh :16inch" },
                    { 63, "/images/device (227).png", 4, false, null, 1400000m, 40000000m, null, "Mô tả mẫu của sản phẩm63", 21, 6, 5, 100, "ezbxDg6Eqg63", "RAM:22Memory:429GB Man hinh :16inch" },
                    { 64, "/images/device (250).png", 2, false, null, 3600000m, 15000000m, null, "Mô tả mẫu của sản phẩm64", 7, 22, 4, 400, "lYvBupV8Pa64", "RAM:24Memory:173GB Man hinh :16inch" },
                    { 65, "/images/device (38).png", 3, false, null, 1600000m, 15000000m, null, "Mô tả mẫu của sản phẩm65", 31, 6, 8, 300, "gffQz1W2DC65", "RAM:17Memory:96GB Man hinh :4inch" },
                    { 66, "/images/device (255).png", 2, false, null, 2100000m, 30000000m, null, "Mô tả mẫu của sản phẩm66", 28, 15, 2, 200, "wmOuJx2Jr166", "RAM:6Memory:61GB Man hinh :4inch" },
                    { 67, "/images/device (108).png", 7, false, null, 1900000m, 19000000m, null, "Mô tả mẫu của sản phẩm67", 6, 3, 7, 200, "32ENnKOXTU67", "RAM:8Memory:402GB Man hinh :16inch" },
                    { 68, "/images/device (223).png", 5, false, null, 3600000m, 35000000m, null, "Mô tả mẫu của sản phẩm68", 14, 3, 4, 200, "gNiauwk2XP68", "RAM:22Memory:490GB Man hinh :12inch" },
                    { 69, "/images/device (249).png", 5, false, null, 1600000m, 46000000m, null, "Mô tả mẫu của sản phẩm69", 35, 4, 4, 400, "XCCEFDksZ669", "RAM:5Memory:277GB Man hinh :8inch" },
                    { 70, "/images/device (204).png", 1, false, null, 2700000m, 18000000m, null, "Mô tả mẫu của sản phẩm70", 35, 18, 4, 300, "MMJAJC5ezh70", "RAM:5Memory:348GB Man hinh :16inch" },
                    { 71, "/images/device (269).png", 2, false, null, 4900000m, 42000000m, null, "Mô tả mẫu của sản phẩm71", 37, 13, 4, 300, "zhALg6KSxj71", "RAM:18Memory:56GB Man hinh :8inch" },
                    { 72, "/images/device (187).png", 8, false, null, 4600000m, 18000000m, null, "Mô tả mẫu của sản phẩm72", 35, 19, 5, 200, "lWzCREk4lF72", "RAM:7Memory:498GB Man hinh :4inch" },
                    { 73, "/images/device (55).png", 5, false, null, 1500000m, 6000000m, null, "Mô tả mẫu của sản phẩm73", 18, 4, 6, 400, "W82uoWi98p73", "RAM:5Memory:94GB Man hinh :16inch" },
                    { 74, "/images/device (71).png", 7, false, null, 2500000m, 6000000m, null, "Mô tả mẫu của sản phẩm74", 25, 20, 7, 100, "vyEBeq1HDH74", "RAM:4Memory:389GB Man hinh :16inch" },
                    { 75, "/images/device (261).png", 3, false, null, 500000m, 33000000m, null, "Mô tả mẫu của sản phẩm75", 39, 8, 6, 200, "lVASyL3CVl75", "RAM:23Memory:76GB Man hinh :16inch" },
                    { 76, "/images/device (215).png", 2, false, null, 2700000m, 38000000m, null, "Mô tả mẫu của sản phẩm76", 18, 25, 8, 100, "0CxlUIl9rk76", "RAM:29Memory:319GB Man hinh :8inch" },
                    { 77, "/images/device (15).png", 1, false, null, 2800000m, 46000000m, null, "Mô tả mẫu của sản phẩm77", 22, 24, 6, 300, "TYfwjdStH377", "RAM:15Memory:278GB Man hinh :4inch" },
                    { 78, "/images/device (44).png", 3, false, null, 2000000m, 9000000m, null, "Mô tả mẫu của sản phẩm78", 24, 2, 2, 200, "P0Ls6QfdYx78", "RAM:15Memory:419GB Man hinh :12inch" },
                    { 79, "/images/device (244).png", 5, false, null, 1500000m, 34000000m, null, "Mô tả mẫu của sản phẩm79", 14, 3, 3, 200, "394qR75fOJ79", "RAM:14Memory:460GB Man hinh :16inch" },
                    { 80, "/images/device (87).png", 2, false, null, 3100000m, 35000000m, null, "Mô tả mẫu của sản phẩm80", 17, 15, 3, 200, "KrEnIird6l80", "RAM:17Memory:244GB Man hinh :12inch" },
                    { 81, "/images/device (2).png", 7, false, null, 4400000m, 7000000m, null, "Mô tả mẫu của sản phẩm81", 26, 12, 3, 300, "L9L0C58wCh81", "RAM:19Memory:486GB Man hinh :16inch" },
                    { 82, "/images/device (188).png", 3, false, null, 1300000m, 47000000m, null, "Mô tả mẫu của sản phẩm82", 32, 8, 7, 200, "pBOREDdCkK82", "RAM:25Memory:137GB Man hinh :12inch" },
                    { 83, "/images/device (23).png", 2, false, null, 4800000m, 49000000m, null, "Mô tả mẫu của sản phẩm83", 33, 4, 1, 100, "6MGHmMIQFp83", "RAM:14Memory:229GB Man hinh :12inch" },
                    { 84, "/images/device (83).png", 7, false, null, 3100000m, 8000000m, null, "Mô tả mẫu của sản phẩm84", 39, 18, 3, 400, "CI077Cr5dg84", "RAM:16Memory:205GB Man hinh :16inch" },
                    { 85, "/images/device (17).png", 6, false, null, 3100000m, 42000000m, null, "Mô tả mẫu của sản phẩm85", 7, 18, 5, 400, "Tfp0RiZh1l85", "RAM:27Memory:424GB Man hinh :4inch" },
                    { 86, "/images/device (32).png", 4, false, null, 2300000m, 5000000m, null, "Mô tả mẫu của sản phẩm86", 15, 10, 5, 400, "FZoPx4FMMS86", "RAM:24Memory:204GB Man hinh :12inch" },
                    { 87, "/images/device (12).png", 4, false, null, 3800000m, 23000000m, null, "Mô tả mẫu của sản phẩm87", 5, 2, 4, 100, "SxvMVzOfjp87", "RAM:12Memory:151GB Man hinh :12inch" },
                    { 88, "/images/device (43).png", 2, false, null, 3000000m, 5000000m, null, "Mô tả mẫu của sản phẩm88", 12, 17, 8, 300, "t1Fafmv5Dn88", "RAM:29Memory:425GB Man hinh :4inch" },
                    { 89, "/images/device (59).png", 5, false, null, 2700000m, 28000000m, null, "Mô tả mẫu của sản phẩm89", 24, 26, 7, 400, "LwvLLXZitC89", "RAM:7Memory:280GB Man hinh :4inch" },
                    { 90, "/images/device (188).png", 7, false, null, 2800000m, 47000000m, null, "Mô tả mẫu của sản phẩm90", 24, 25, 2, 100, "4c3vZaNZQh90", "RAM:2Memory:404GB Man hinh :12inch" },
                    { 91, "/images/device (71).png", 1, false, null, 3500000m, 17000000m, null, "Mô tả mẫu của sản phẩm91", 33, 2, 4, 400, "tbNSac0Lfr91", "RAM:10Memory:432GB Man hinh :8inch" },
                    { 92, "/images/device (212).png", 7, false, null, 3700000m, 48000000m, null, "Mô tả mẫu của sản phẩm92", 6, 6, 3, 100, "sAbHqR441o92", "RAM:27Memory:93GB Man hinh :4inch" },
                    { 93, "/images/device (144).png", 5, false, null, 1400000m, 11000000m, null, "Mô tả mẫu của sản phẩm93", 8, 20, 5, 200, "D86KFZwjOq93", "RAM:9Memory:125GB Man hinh :8inch" },
                    { 94, "/images/device (231).png", 7, false, null, 4900000m, 15000000m, null, "Mô tả mẫu của sản phẩm94", 19, 27, 1, 100, "xVlQv8KVPQ94", "RAM:1Memory:235GB Man hinh :12inch" },
                    { 95, "/images/device (81).png", 4, false, null, 2200000m, 45000000m, null, "Mô tả mẫu của sản phẩm95", 39, 26, 7, 100, "lSrRGHubQw95", "RAM:3Memory:469GB Man hinh :16inch" },
                    { 96, "/images/device (28).png", 1, false, null, 3900000m, 40000000m, null, "Mô tả mẫu của sản phẩm96", 6, 4, 8, 300, "Nqf52YFOMA96", "RAM:17Memory:368GB Man hinh :8inch" },
                    { 97, "/images/device (237).png", 1, false, null, 3700000m, 40000000m, null, "Mô tả mẫu của sản phẩm97", 17, 16, 3, 200, "6CdjFqP5NR97", "RAM:24Memory:197GB Man hinh :12inch" },
                    { 98, "/images/device (195).png", 6, false, null, 300000m, 24000000m, null, "Mô tả mẫu của sản phẩm98", 26, 22, 4, 100, "OEedcWQpBO98", "RAM:27Memory:169GB Man hinh :16inch" },
                    { 99, "/images/device (264).png", 8, false, null, 1600000m, 15000000m, null, "Mô tả mẫu của sản phẩm99", 31, 8, 7, 400, "HWEoM0jzVM99", "RAM:24Memory:196GB Man hinh :16inch" },
                    { 100, "/images/device (215).png", 1, false, null, 400000m, 43000000m, null, "Mô tả mẫu của sản phẩm100", 35, 12, 8, 400, "BgKNOM0MV7100", "RAM:22Memory:360GB Man hinh :4inch" },
                    { 101, "/images/device (176).png", 8, false, null, 4100000m, 38000000m, null, "Mô tả mẫu của sản phẩm101", 5, 26, 6, 200, "Ud5HHO9cPi101", "RAM:31Memory:437GB Man hinh :8inch" },
                    { 102, "/images/device (68).png", 1, false, null, 600000m, 19000000m, null, "Mô tả mẫu của sản phẩm102", 11, 19, 6, 300, "HFeMzy7QjX102", "RAM:17Memory:350GB Man hinh :4inch" },
                    { 103, "/images/device (43).png", 8, false, null, 900000m, 37000000m, null, "Mô tả mẫu của sản phẩm103", 36, 23, 4, 100, "nEqMlpJqo4103", "RAM:20Memory:262GB Man hinh :12inch" },
                    { 104, "/images/device (54).png", 6, false, null, 2500000m, 49000000m, null, "Mô tả mẫu của sản phẩm104", 32, 21, 1, 400, "NLk5YJapxs104", "RAM:27Memory:305GB Man hinh :8inch" },
                    { 105, "/images/device (147).png", 7, false, null, 1400000m, 7000000m, null, "Mô tả mẫu của sản phẩm105", 23, 9, 1, 400, "6W3Of4H5bf105", "RAM:18Memory:397GB Man hinh :16inch" },
                    { 106, "/images/device (103).png", 3, false, null, 1800000m, 37000000m, null, "Mô tả mẫu của sản phẩm106", 14, 19, 8, 100, "DKEp8sft2t106", "RAM:8Memory:77GB Man hinh :12inch" },
                    { 107, "/images/device (78).png", 1, false, null, 4400000m, 48000000m, null, "Mô tả mẫu của sản phẩm107", 32, 9, 4, 300, "Q6wiWjAHc4107", "RAM:15Memory:99GB Man hinh :8inch" },
                    { 108, "/images/device (200).png", 2, false, null, 3300000m, 48000000m, null, "Mô tả mẫu của sản phẩm108", 33, 24, 1, 100, "gpmankvYj6108", "RAM:6Memory:261GB Man hinh :12inch" },
                    { 109, "/images/device (230).png", 1, false, null, 3000000m, 44000000m, null, "Mô tả mẫu của sản phẩm109", 11, 26, 8, 100, "tU91F3F2rz109", "RAM:25Memory:231GB Man hinh :4inch" },
                    { 110, "/images/device (31).png", 1, false, null, 1800000m, 1000000m, null, "Mô tả mẫu của sản phẩm110", 10, 27, 5, 200, "3sTmFUEvD9110", "RAM:28Memory:276GB Man hinh :4inch" },
                    { 111, "/images/device (168).png", 5, false, null, 1800000m, 44000000m, null, "Mô tả mẫu của sản phẩm111", 21, 3, 5, 400, "fayUZ8HMd5111", "RAM:15Memory:490GB Man hinh :4inch" },
                    { 112, "/images/device (57).png", 6, false, null, 2200000m, 36000000m, null, "Mô tả mẫu của sản phẩm112", 16, 23, 1, 300, "tdu55OOc3B112", "RAM:12Memory:228GB Man hinh :4inch" },
                    { 113, "/images/device (205).png", 7, false, null, 4900000m, 6000000m, null, "Mô tả mẫu của sản phẩm113", 8, 10, 6, 400, "3rG3RFaTGU113", "RAM:11Memory:229GB Man hinh :8inch" },
                    { 114, "/images/device (224).png", 4, false, null, 2800000m, 17000000m, null, "Mô tả mẫu của sản phẩm114", 26, 9, 1, 400, "ow8MM7irTe114", "RAM:31Memory:158GB Man hinh :12inch" },
                    { 115, "/images/device (98).png", 8, false, null, 4300000m, 32000000m, null, "Mô tả mẫu của sản phẩm115", 26, 14, 3, 300, "TCcqcVvbjg115", "RAM:22Memory:394GB Man hinh :8inch" },
                    { 116, "/images/device (24).png", 5, false, null, 2500000m, 13000000m, null, "Mô tả mẫu của sản phẩm116", 14, 27, 5, 100, "MJNeXMpy5I116", "RAM:17Memory:493GB Man hinh :12inch" },
                    { 117, "/images/device (40).png", 7, false, null, 3100000m, 46000000m, null, "Mô tả mẫu của sản phẩm117", 22, 25, 6, 400, "nx19GHfTBa117", "RAM:28Memory:34GB Man hinh :4inch" },
                    { 118, "/images/device (147).png", 1, false, null, 2700000m, 25000000m, null, "Mô tả mẫu của sản phẩm118", 5, 4, 8, 300, "3syxJ5DHQb118", "RAM:15Memory:149GB Man hinh :4inch" },
                    { 119, "/images/device (83).png", 8, false, null, 1200000m, 8000000m, null, "Mô tả mẫu của sản phẩm119", 31, 25, 4, 100, "ixTWkOdcwf119", "RAM:30Memory:467GB Man hinh :4inch" },
                    { 120, "/images/device (212).png", 8, false, null, 2900000m, 3000000m, null, "Mô tả mẫu của sản phẩm120", 36, 8, 2, 100, "wZp0UfrHAX120", "RAM:12Memory:233GB Man hinh :12inch" },
                    { 121, "/images/device (274).png", 2, false, null, 3700000m, 34000000m, null, "Mô tả mẫu của sản phẩm121", 9, 23, 5, 100, "zFY39NaQYH121", "RAM:10Memory:316GB Man hinh :12inch" },
                    { 122, "/images/device (17).png", 4, false, null, 4500000m, 1000000m, null, "Mô tả mẫu của sản phẩm122", 33, 20, 4, 300, "RDhtcdJPGL122", "RAM:31Memory:155GB Man hinh :16inch" },
                    { 123, "/images/device (237).png", 2, false, null, 700000m, 41000000m, null, "Mô tả mẫu của sản phẩm123", 31, 4, 4, 100, "QUoWQCWnLl123", "RAM:26Memory:319GB Man hinh :12inch" },
                    { 124, "/images/device (19).png", 5, false, null, 800000m, 4000000m, null, "Mô tả mẫu của sản phẩm124", 14, 10, 4, 100, "EvPMZAycDD124", "RAM:16Memory:90GB Man hinh :16inch" },
                    { 125, "/images/device (105).png", 7, false, null, 2300000m, 11000000m, null, "Mô tả mẫu của sản phẩm125", 22, 10, 4, 400, "9swNTNpYVM125", "RAM:20Memory:311GB Man hinh :12inch" },
                    { 126, "/images/device (5).png", 4, false, null, 2700000m, 24000000m, null, "Mô tả mẫu của sản phẩm126", 20, 22, 8, 100, "Q4WClqbMU9126", "RAM:11Memory:452GB Man hinh :4inch" },
                    { 127, "/images/device (199).png", 5, false, null, 1200000m, 33000000m, null, "Mô tả mẫu của sản phẩm127", 11, 11, 2, 400, "8LL6JAQnS9127", "RAM:22Memory:277GB Man hinh :16inch" },
                    { 128, "/images/device (190).png", 6, false, null, 1100000m, 41000000m, null, "Mô tả mẫu của sản phẩm128", 17, 24, 3, 100, "G0wY8KPGUx128", "RAM:27Memory:239GB Man hinh :8inch" },
                    { 129, "/images/device (103).png", 3, false, null, 800000m, 14000000m, null, "Mô tả mẫu của sản phẩm129", 17, 23, 4, 300, "SaqOVmbZD1129", "RAM:31Memory:243GB Man hinh :16inch" },
                    { 130, "/images/device (150).png", 4, false, null, 4100000m, 46000000m, null, "Mô tả mẫu của sản phẩm130", 15, 18, 2, 300, "HLODeE3LSj130", "RAM:23Memory:304GB Man hinh :8inch" },
                    { 131, "/images/device (100).png", 2, false, null, 2700000m, 48000000m, null, "Mô tả mẫu của sản phẩm131", 16, 4, 8, 400, "oL1yJ8aeiW131", "RAM:4Memory:47GB Man hinh :12inch" },
                    { 132, "/images/device (228).png", 4, false, null, 3400000m, 21000000m, null, "Mô tả mẫu của sản phẩm132", 5, 15, 5, 200, "Z6r0yYaoXO132", "RAM:4Memory:347GB Man hinh :16inch" },
                    { 133, "/images/device (255).png", 7, false, null, 4700000m, 18000000m, null, "Mô tả mẫu của sản phẩm133", 26, 23, 6, 400, "7lPb2IzZmg133", "RAM:26Memory:97GB Man hinh :12inch" },
                    { 134, "/images/device (166).png", 8, false, null, 2300000m, 45000000m, null, "Mô tả mẫu của sản phẩm134", 16, 1, 6, 300, "hgFjwVU2By134", "RAM:14Memory:232GB Man hinh :4inch" },
                    { 135, "/images/device (171).png", 4, false, null, 1800000m, 32000000m, null, "Mô tả mẫu của sản phẩm135", 15, 19, 5, 300, "waQ3V8wcXo135", "RAM:18Memory:112GB Man hinh :4inch" },
                    { 136, "/images/device (45).png", 5, false, null, 3600000m, 48000000m, null, "Mô tả mẫu của sản phẩm136", 19, 26, 4, 300, "nIH7rj3JR9136", "RAM:21Memory:240GB Man hinh :16inch" },
                    { 137, "/images/device (80).png", 8, false, null, 1000000m, 24000000m, null, "Mô tả mẫu của sản phẩm137", 31, 1, 5, 200, "jiAXapIjsF137", "RAM:8Memory:39GB Man hinh :16inch" },
                    { 138, "/images/device (218).png", 6, false, null, 4500000m, 31000000m, null, "Mô tả mẫu của sản phẩm138", 23, 19, 6, 200, "M6UFRrser9138", "RAM:6Memory:374GB Man hinh :4inch" },
                    { 139, "/images/device (155).png", 2, false, null, 4200000m, 22000000m, null, "Mô tả mẫu của sản phẩm139", 7, 7, 2, 300, "DaZ0a2DwTc139", "RAM:21Memory:415GB Man hinh :16inch" },
                    { 140, "/images/device (244).png", 7, false, null, 1700000m, 15000000m, null, "Mô tả mẫu của sản phẩm140", 33, 20, 4, 200, "tCvvIWAIcR140", "RAM:14Memory:471GB Man hinh :4inch" },
                    { 141, "/images/device (78).png", 7, false, null, 3900000m, 16000000m, null, "Mô tả mẫu của sản phẩm141", 6, 2, 5, 200, "75yZiKE207141", "RAM:25Memory:310GB Man hinh :8inch" },
                    { 142, "/images/device (18).png", 3, false, null, 4500000m, 17000000m, null, "Mô tả mẫu của sản phẩm142", 6, 22, 3, 400, "xlkrZ9m94T142", "RAM:30Memory:199GB Man hinh :4inch" },
                    { 143, "/images/device (103).png", 7, false, null, 4300000m, 35000000m, null, "Mô tả mẫu của sản phẩm143", 39, 16, 8, 200, "qhvrCyaePE143", "RAM:23Memory:142GB Man hinh :8inch" },
                    { 144, "/images/device (161).png", 5, false, null, 3900000m, 31000000m, null, "Mô tả mẫu của sản phẩm144", 32, 10, 2, 400, "b2W7WO2MPp144", "RAM:18Memory:183GB Man hinh :8inch" },
                    { 145, "/images/device (7).png", 1, false, null, 3200000m, 28000000m, null, "Mô tả mẫu của sản phẩm145", 27, 6, 1, 200, "UVFkY1EJaU145", "RAM:22Memory:424GB Man hinh :4inch" },
                    { 146, "/images/device (224).png", 6, false, null, 600000m, 6000000m, null, "Mô tả mẫu của sản phẩm146", 36, 11, 6, 300, "yLvlyLy9xa146", "RAM:12Memory:308GB Man hinh :8inch" },
                    { 147, "/images/device (60).png", 7, false, null, 3100000m, 44000000m, null, "Mô tả mẫu của sản phẩm147", 38, 27, 4, 200, "I8TFHl6xmm147", "RAM:21Memory:169GB Man hinh :8inch" },
                    { 148, "/images/device (119).png", 6, false, null, 2300000m, 9000000m, null, "Mô tả mẫu của sản phẩm148", 30, 15, 6, 100, "XuygTEZD67148", "RAM:2Memory:127GB Man hinh :16inch" },
                    { 149, "/images/device (79).png", 5, false, null, 800000m, 35000000m, null, "Mô tả mẫu của sản phẩm149", 22, 24, 4, 300, "JjHikiIIWu149", "RAM:5Memory:347GB Man hinh :4inch" },
                    { 150, "/images/device (132).png", 2, false, null, 3200000m, 9000000m, null, "Mô tả mẫu của sản phẩm150", 23, 12, 6, 400, "twTB0r5pME150", "RAM:13Memory:205GB Man hinh :12inch" },
                    { 151, "/images/device (203).png", 2, false, null, 3600000m, 35000000m, null, "Mô tả mẫu của sản phẩm151", 39, 27, 8, 400, "P4ovqG5gms151", "RAM:21Memory:405GB Man hinh :16inch" },
                    { 152, "/images/device (115).png", 6, false, null, 400000m, 21000000m, null, "Mô tả mẫu của sản phẩm152", 18, 21, 1, 200, "E8mpN354kF152", "RAM:6Memory:362GB Man hinh :4inch" },
                    { 153, "/images/device (16).png", 7, false, null, 1800000m, 28000000m, null, "Mô tả mẫu của sản phẩm153", 14, 11, 3, 300, "DmxkviNpqm153", "RAM:30Memory:285GB Man hinh :12inch" },
                    { 154, "/images/device (138).png", 4, false, null, 2300000m, 49000000m, null, "Mô tả mẫu của sản phẩm154", 24, 25, 3, 400, "1tA85ApNOz154", "RAM:23Memory:457GB Man hinh :4inch" },
                    { 155, "/images/device (164).png", 6, false, null, 1200000m, 24000000m, null, "Mô tả mẫu của sản phẩm155", 9, 11, 4, 300, "1wfXsg4Tbo155", "RAM:24Memory:289GB Man hinh :16inch" },
                    { 156, "/images/device (131).png", 5, false, null, 1300000m, 37000000m, null, "Mô tả mẫu của sản phẩm156", 29, 10, 1, 400, "5zgCPTge7H156", "RAM:2Memory:81GB Man hinh :8inch" },
                    { 157, "/images/device (237).png", 8, false, null, 2300000m, 11000000m, null, "Mô tả mẫu của sản phẩm157", 19, 23, 1, 300, "PH8cvixKxE157", "RAM:4Memory:168GB Man hinh :8inch" },
                    { 158, "/images/device (73).png", 3, false, null, 1700000m, 49000000m, null, "Mô tả mẫu của sản phẩm158", 12, 23, 1, 200, "kS39qRmXGO158", "RAM:18Memory:345GB Man hinh :4inch" },
                    { 159, "/images/device (48).png", 6, false, null, 2500000m, 8000000m, null, "Mô tả mẫu của sản phẩm159", 24, 2, 7, 400, "yC9YHPJoJo159", "RAM:1Memory:304GB Man hinh :8inch" },
                    { 160, "/images/device (89).png", 8, false, null, 1100000m, 46000000m, null, "Mô tả mẫu của sản phẩm160", 28, 17, 7, 400, "xVlGRUFQp9160", "RAM:14Memory:220GB Man hinh :16inch" },
                    { 161, "/images/device (196).png", 2, false, null, 700000m, 43000000m, null, "Mô tả mẫu của sản phẩm161", 14, 11, 5, 400, "gmxuV1DpSC161", "RAM:25Memory:78GB Man hinh :4inch" },
                    { 162, "/images/device (126).png", 4, false, null, 4400000m, 28000000m, null, "Mô tả mẫu của sản phẩm162", 29, 1, 7, 400, "h11IldomZz162", "RAM:22Memory:420GB Man hinh :16inch" },
                    { 163, "/images/device (60).png", 3, false, null, 4700000m, 25000000m, null, "Mô tả mẫu của sản phẩm163", 16, 2, 8, 200, "zOjVqiZx61163", "RAM:18Memory:139GB Man hinh :4inch" },
                    { 164, "/images/device (46).png", 6, false, null, 1200000m, 39000000m, null, "Mô tả mẫu của sản phẩm164", 27, 21, 6, 200, "I5vrIyv60y164", "RAM:7Memory:244GB Man hinh :16inch" },
                    { 165, "/images/device (79).png", 6, false, null, 600000m, 22000000m, null, "Mô tả mẫu của sản phẩm165", 32, 4, 1, 300, "DbIqlKvlls165", "RAM:1Memory:125GB Man hinh :4inch" },
                    { 166, "/images/device (254).png", 1, false, null, 3300000m, 10000000m, null, "Mô tả mẫu của sản phẩm166", 30, 26, 2, 300, "YxQ3JAMLso166", "RAM:10Memory:106GB Man hinh :12inch" },
                    { 167, "/images/device (146).png", 4, false, null, 3800000m, 26000000m, null, "Mô tả mẫu của sản phẩm167", 17, 26, 5, 300, "xohuuTns0q167", "RAM:12Memory:438GB Man hinh :12inch" },
                    { 168, "/images/device (267).png", 5, false, null, 3200000m, 31000000m, null, "Mô tả mẫu của sản phẩm168", 24, 17, 8, 100, "6r8wTcOtbP168", "RAM:12Memory:422GB Man hinh :4inch" },
                    { 169, "/images/device (243).png", 3, false, null, 200000m, 14000000m, null, "Mô tả mẫu của sản phẩm169", 32, 14, 4, 400, "ifTkNKl1N6169", "RAM:31Memory:439GB Man hinh :4inch" },
                    { 170, "/images/device (75).png", 7, false, null, 1600000m, 35000000m, null, "Mô tả mẫu của sản phẩm170", 6, 16, 7, 200, "oct8sDPtFl170", "RAM:19Memory:132GB Man hinh :8inch" },
                    { 171, "/images/device (1).png", 8, false, null, 3800000m, 20000000m, null, "Mô tả mẫu của sản phẩm171", 32, 19, 1, 300, "vWBhSAWkPC171", "RAM:21Memory:345GB Man hinh :12inch" },
                    { 172, "/images/device (167).png", 5, false, null, 700000m, 46000000m, null, "Mô tả mẫu của sản phẩm172", 21, 11, 3, 200, "yQTKObgysu172", "RAM:1Memory:288GB Man hinh :8inch" },
                    { 173, "/images/device (238).png", 1, false, null, 1300000m, 35000000m, null, "Mô tả mẫu của sản phẩm173", 20, 9, 8, 200, "FSSX0HGW3f173", "RAM:18Memory:46GB Man hinh :12inch" },
                    { 174, "/images/device (212).png", 1, false, null, 600000m, 47000000m, null, "Mô tả mẫu của sản phẩm174", 17, 27, 1, 200, "IyP37X8Xrx174", "RAM:17Memory:488GB Man hinh :16inch" },
                    { 175, "/images/device (141).png", 8, false, null, 2300000m, 49000000m, null, "Mô tả mẫu của sản phẩm175", 9, 23, 6, 200, "wkeb33d1LL175", "RAM:9Memory:52GB Man hinh :4inch" },
                    { 176, "/images/device (258).png", 8, false, null, 3800000m, 47000000m, null, "Mô tả mẫu của sản phẩm176", 39, 26, 3, 400, "QG1uGQbL5E176", "RAM:10Memory:495GB Man hinh :8inch" },
                    { 177, "/images/device (99).png", 2, false, null, 1300000m, 35000000m, null, "Mô tả mẫu của sản phẩm177", 5, 9, 8, 400, "8QzbCY8vIE177", "RAM:13Memory:141GB Man hinh :12inch" },
                    { 178, "/images/device (106).png", 3, false, null, 3100000m, 34000000m, null, "Mô tả mẫu của sản phẩm178", 21, 8, 3, 300, "416ewFe2qZ178", "RAM:5Memory:216GB Man hinh :16inch" },
                    { 179, "/images/device (204).png", 2, false, null, 3500000m, 41000000m, null, "Mô tả mẫu của sản phẩm179", 10, 11, 2, 400, "Oc8DzvkzZj179", "RAM:29Memory:156GB Man hinh :8inch" },
                    { 180, "/images/device (247).png", 8, false, null, 400000m, 1000000m, null, "Mô tả mẫu của sản phẩm180", 9, 26, 8, 200, "akv0lywCqH180", "RAM:10Memory:33GB Man hinh :8inch" },
                    { 181, "/images/device (217).png", 8, false, null, 4600000m, 12000000m, null, "Mô tả mẫu của sản phẩm181", 20, 13, 7, 300, "NGKcCrVZ4z181", "RAM:31Memory:441GB Man hinh :12inch" },
                    { 182, "/images/device (9).png", 5, false, null, 3100000m, 41000000m, null, "Mô tả mẫu của sản phẩm182", 39, 25, 7, 100, "OaW6WZ3nXK182", "RAM:2Memory:175GB Man hinh :12inch" },
                    { 183, "/images/device (17).png", 3, false, null, 800000m, 43000000m, null, "Mô tả mẫu của sản phẩm183", 14, 12, 7, 200, "suecdFlEMi183", "RAM:6Memory:105GB Man hinh :16inch" },
                    { 184, "/images/device (89).png", 6, false, null, 900000m, 35000000m, null, "Mô tả mẫu của sản phẩm184", 29, 17, 3, 200, "P2og6aXkvm184", "RAM:12Memory:159GB Man hinh :16inch" },
                    { 185, "/images/device (53).png", 1, false, null, 3300000m, 8000000m, null, "Mô tả mẫu của sản phẩm185", 6, 20, 5, 300, "45ycXpMt1B185", "RAM:9Memory:416GB Man hinh :16inch" },
                    { 186, "/images/device (90).png", 4, false, null, 1000000m, 34000000m, null, "Mô tả mẫu của sản phẩm186", 32, 3, 4, 300, "DhfpovflK1186", "RAM:12Memory:418GB Man hinh :8inch" },
                    { 187, "/images/device (212).png", 6, false, null, 4100000m, 27000000m, null, "Mô tả mẫu của sản phẩm187", 11, 22, 1, 400, "Jgnn2w2vXz187", "RAM:25Memory:215GB Man hinh :4inch" },
                    { 188, "/images/device (94).png", 6, false, null, 300000m, 4000000m, null, "Mô tả mẫu của sản phẩm188", 12, 27, 3, 300, "KXFIn5hr9q188", "RAM:16Memory:37GB Man hinh :8inch" },
                    { 189, "/images/device (135).png", 8, false, null, 1500000m, 48000000m, null, "Mô tả mẫu của sản phẩm189", 27, 15, 3, 400, "kImgarG2RX189", "RAM:22Memory:153GB Man hinh :12inch" },
                    { 190, "/images/device (199).png", 3, false, null, 600000m, 16000000m, null, "Mô tả mẫu của sản phẩm190", 10, 26, 6, 300, "Is7qhdPpIK190", "RAM:21Memory:208GB Man hinh :4inch" },
                    { 191, "/images/device (38).png", 2, false, null, 2200000m, 13000000m, null, "Mô tả mẫu của sản phẩm191", 25, 14, 2, 300, "ZlT0u1hES8191", "RAM:25Memory:343GB Man hinh :12inch" },
                    { 192, "/images/device (244).png", 5, false, null, 800000m, 20000000m, null, "Mô tả mẫu của sản phẩm192", 18, 8, 6, 200, "EnFTCaL53R192", "RAM:5Memory:95GB Man hinh :8inch" },
                    { 193, "/images/device (166).png", 4, false, null, 400000m, 2000000m, null, "Mô tả mẫu của sản phẩm193", 31, 27, 5, 200, "en1H8Bssql193", "RAM:6Memory:427GB Man hinh :8inch" },
                    { 194, "/images/device (14).png", 1, false, null, 2600000m, 21000000m, null, "Mô tả mẫu của sản phẩm194", 10, 4, 6, 400, "S7PdoUmSw4194", "RAM:14Memory:248GB Man hinh :16inch" },
                    { 195, "/images/device (81).png", 5, false, null, 4300000m, 47000000m, null, "Mô tả mẫu của sản phẩm195", 22, 6, 8, 300, "9qZNX7kocL195", "RAM:24Memory:85GB Man hinh :4inch" },
                    { 196, "/images/device (240).png", 2, false, null, 4100000m, 6000000m, null, "Mô tả mẫu của sản phẩm196", 37, 24, 8, 100, "dNsftb6D7F196", "RAM:9Memory:342GB Man hinh :4inch" },
                    { 197, "/images/device (106).png", 6, false, null, 3800000m, 18000000m, null, "Mô tả mẫu của sản phẩm197", 30, 20, 7, 400, "OorapfYtvX197", "RAM:9Memory:246GB Man hinh :8inch" },
                    { 198, "/images/device (269).png", 7, false, null, 4100000m, 45000000m, null, "Mô tả mẫu của sản phẩm198", 32, 15, 4, 100, "qiMywRdDkV198", "RAM:25Memory:149GB Man hinh :8inch" },
                    { 199, "/images/device (41).png", 3, false, null, 200000m, 34000000m, null, "Mô tả mẫu của sản phẩm199", 18, 2, 6, 200, "pGwn0T4RwS199", "RAM:30Memory:242GB Man hinh :8inch" },
                    { 200, "/images/device (161).png", 6, false, null, 4200000m, 1000000m, null, "Mô tả mẫu của sản phẩm200", 7, 12, 3, 100, "BVwgzyrXFC200", "RAM:17Memory:75GB Man hinh :12inch" },
                    { 201, "/images/device (57).png", 1, false, null, 4800000m, 39000000m, null, "Mô tả mẫu của sản phẩm201", 38, 8, 7, 200, "8mETY5Adux201", "RAM:1Memory:163GB Man hinh :12inch" },
                    { 202, "/images/device (217).png", 1, false, null, 4300000m, 47000000m, null, "Mô tả mẫu của sản phẩm202", 36, 9, 3, 300, "bMqUkWIwkM202", "RAM:8Memory:387GB Man hinh :16inch" },
                    { 203, "/images/device (250).png", 7, false, null, 4800000m, 27000000m, null, "Mô tả mẫu của sản phẩm203", 16, 21, 3, 400, "gCqmfYhUGI203", "RAM:7Memory:408GB Man hinh :12inch" },
                    { 204, "/images/device (253).png", 5, false, null, 4300000m, 36000000m, null, "Mô tả mẫu của sản phẩm204", 16, 24, 5, 400, "P0PC6fPpqg204", "RAM:3Memory:231GB Man hinh :8inch" },
                    { 205, "/images/device (80).png", 4, false, null, 3800000m, 6000000m, null, "Mô tả mẫu của sản phẩm205", 34, 17, 7, 200, "kxmbUNINjh205", "RAM:17Memory:439GB Man hinh :16inch" },
                    { 206, "/images/device (91).png", 3, false, null, 300000m, 10000000m, null, "Mô tả mẫu của sản phẩm206", 29, 11, 2, 100, "rAiDCaZKSv206", "RAM:25Memory:188GB Man hinh :8inch" },
                    { 207, "/images/device (134).png", 4, false, null, 1800000m, 48000000m, null, "Mô tả mẫu của sản phẩm207", 39, 10, 8, 300, "tmCRYobZBu207", "RAM:12Memory:315GB Man hinh :12inch" },
                    { 208, "/images/device (116).png", 5, false, null, 4400000m, 24000000m, null, "Mô tả mẫu của sản phẩm208", 31, 13, 2, 200, "626uVjY1av208", "RAM:14Memory:365GB Man hinh :16inch" },
                    { 209, "/images/device (27).png", 4, false, null, 700000m, 6000000m, null, "Mô tả mẫu của sản phẩm209", 34, 15, 5, 100, "LpWN5cfQb2209", "RAM:30Memory:505GB Man hinh :12inch" },
                    { 210, "/images/device (11).png", 8, false, null, 1400000m, 8000000m, null, "Mô tả mẫu của sản phẩm210", 19, 2, 5, 400, "NuhZ7eY1vK210", "RAM:10Memory:387GB Man hinh :8inch" },
                    { 211, "/images/device (44).png", 3, false, null, 4300000m, 34000000m, null, "Mô tả mẫu của sản phẩm211", 23, 5, 5, 400, "7GaC91HKGO211", "RAM:7Memory:399GB Man hinh :8inch" },
                    { 212, "/images/device (207).png", 3, false, null, 1800000m, 45000000m, null, "Mô tả mẫu của sản phẩm212", 17, 21, 3, 400, "HHZgT52ghN212", "RAM:7Memory:498GB Man hinh :16inch" },
                    { 213, "/images/device (235).png", 6, false, null, 2500000m, 37000000m, null, "Mô tả mẫu của sản phẩm213", 37, 10, 6, 300, "lIKVzeuAYo213", "RAM:20Memory:277GB Man hinh :8inch" },
                    { 214, "/images/device (71).png", 6, false, null, 1200000m, 3000000m, null, "Mô tả mẫu của sản phẩm214", 19, 7, 4, 300, "uCWDyIKgJW214", "RAM:15Memory:104GB Man hinh :8inch" },
                    { 215, "/images/device (212).png", 5, false, null, 200000m, 15000000m, null, "Mô tả mẫu của sản phẩm215", 29, 20, 5, 100, "EKiltte1OD215", "RAM:21Memory:73GB Man hinh :4inch" },
                    { 216, "/images/device (226).png", 7, false, null, 3500000m, 45000000m, null, "Mô tả mẫu của sản phẩm216", 9, 19, 2, 100, "jWCy4gIzTi216", "RAM:4Memory:241GB Man hinh :16inch" },
                    { 217, "/images/device (69).png", 4, false, null, 100000m, 42000000m, null, "Mô tả mẫu của sản phẩm217", 34, 17, 1, 100, "fT0C3RSHbx217", "RAM:28Memory:290GB Man hinh :16inch" },
                    { 218, "/images/device (230).png", 8, false, null, 2000000m, 26000000m, null, "Mô tả mẫu của sản phẩm218", 39, 10, 6, 100, "NmIkVDxDAa218", "RAM:29Memory:452GB Man hinh :4inch" },
                    { 219, "/images/device (76).png", 6, false, null, 1400000m, 23000000m, null, "Mô tả mẫu của sản phẩm219", 16, 22, 8, 300, "A0i3jCP3YK219", "RAM:23Memory:355GB Man hinh :12inch" },
                    { 220, "/images/device (8).png", 5, false, null, 4400000m, 35000000m, null, "Mô tả mẫu của sản phẩm220", 29, 23, 6, 200, "KH4uBOhgJm220", "RAM:30Memory:78GB Man hinh :12inch" },
                    { 221, "/images/device (175).png", 5, false, null, 300000m, 31000000m, null, "Mô tả mẫu của sản phẩm221", 29, 15, 2, 200, "lqT7oPLux4221", "RAM:31Memory:505GB Man hinh :16inch" },
                    { 222, "/images/device (224).png", 2, false, null, 3100000m, 3000000m, null, "Mô tả mẫu của sản phẩm222", 27, 11, 6, 200, "Nic2QFb0WI222", "RAM:15Memory:68GB Man hinh :16inch" },
                    { 223, "/images/device (254).png", 6, false, null, 1500000m, 42000000m, null, "Mô tả mẫu của sản phẩm223", 10, 27, 1, 200, "2dOgasCE60223", "RAM:19Memory:493GB Man hinh :16inch" },
                    { 224, "/images/device (73).png", 8, false, null, 1100000m, 31000000m, null, "Mô tả mẫu của sản phẩm224", 15, 27, 7, 300, "X6nmCEgabv224", "RAM:28Memory:471GB Man hinh :16inch" },
                    { 225, "/images/device (14).png", 5, false, null, 4500000m, 40000000m, null, "Mô tả mẫu của sản phẩm225", 37, 17, 7, 100, "HoSULfygrZ225", "RAM:26Memory:56GB Man hinh :8inch" },
                    { 226, "/images/device (271).png", 4, false, null, 3400000m, 21000000m, null, "Mô tả mẫu của sản phẩm226", 29, 12, 6, 400, "Ig077vqwss226", "RAM:20Memory:285GB Man hinh :8inch" },
                    { 227, "/images/device (61).png", 2, false, null, 4300000m, 24000000m, null, "Mô tả mẫu của sản phẩm227", 6, 9, 5, 100, "2SW8g9X5rA227", "RAM:19Memory:476GB Man hinh :8inch" },
                    { 228, "/images/device (250).png", 2, false, null, 1300000m, 9000000m, null, "Mô tả mẫu của sản phẩm228", 10, 7, 6, 200, "xNi4R6cawn228", "RAM:3Memory:88GB Man hinh :8inch" },
                    { 229, "/images/device (99).png", 3, false, null, 2000000m, 7000000m, null, "Mô tả mẫu của sản phẩm229", 14, 22, 2, 400, "9vIYCbdwdU229", "RAM:28Memory:365GB Man hinh :16inch" },
                    { 230, "/images/device (80).png", 4, false, null, 2600000m, 33000000m, null, "Mô tả mẫu của sản phẩm230", 33, 14, 8, 200, "Hos7DJqjze230", "RAM:24Memory:120GB Man hinh :12inch" },
                    { 231, "/images/device (91).png", 7, false, null, 3300000m, 21000000m, null, "Mô tả mẫu của sản phẩm231", 11, 6, 7, 300, "1KeJfXFTkU231", "RAM:19Memory:60GB Man hinh :12inch" },
                    { 232, "/images/device (239).png", 8, false, null, 2700000m, 21000000m, null, "Mô tả mẫu của sản phẩm232", 33, 17, 1, 200, "MS6REpoBrO232", "RAM:14Memory:76GB Man hinh :8inch" },
                    { 233, "/images/device (50).png", 2, false, null, 800000m, 46000000m, null, "Mô tả mẫu của sản phẩm233", 12, 18, 8, 400, "IkytQ42Muw233", "RAM:25Memory:99GB Man hinh :8inch" },
                    { 234, "/images/device (2).png", 3, false, null, 600000m, 37000000m, null, "Mô tả mẫu của sản phẩm234", 16, 26, 6, 300, "KHw8VDHZt9234", "RAM:26Memory:345GB Man hinh :12inch" },
                    { 235, "/images/device (12).png", 1, false, null, 3300000m, 25000000m, null, "Mô tả mẫu của sản phẩm235", 5, 22, 3, 300, "5fDv29hXwx235", "RAM:13Memory:351GB Man hinh :16inch" },
                    { 236, "/images/device (86).png", 7, false, null, 3500000m, 44000000m, null, "Mô tả mẫu của sản phẩm236", 38, 25, 1, 100, "qxpoX00H4u236", "RAM:30Memory:476GB Man hinh :4inch" }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "ProductImageId", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, 36, "/images/device (144).png" },
                    { 2, 105, "/images/device (212).png" },
                    { 3, 57, "/images/device (62).png" },
                    { 4, 21, "/images/device (184).png" },
                    { 5, 106, "/images/device (227).png" },
                    { 6, 62, "/images/device (16).png" },
                    { 7, 154, "/images/device (39).png" },
                    { 8, 233, "/images/device (121).png" },
                    { 9, 133, "/images/device (221).png" },
                    { 10, 192, "/images/device (215).png" },
                    { 11, 2, "/images/device (76).png" },
                    { 12, 162, "/images/device (63).png" },
                    { 13, 49, "/images/device (251).png" },
                    { 14, 21, "/images/device (251).png" },
                    { 15, 131, "/images/device (108).png" },
                    { 16, 151, "/images/device (1).png" },
                    { 17, 67, "/images/device (239).png" },
                    { 18, 61, "/images/device (75).png" },
                    { 19, 30, "/images/device (44).png" },
                    { 20, 170, "/images/device (110).png" },
                    { 21, 179, "/images/device (240).png" },
                    { 22, 103, "/images/device (231).png" },
                    { 23, 207, "/images/device (72).png" },
                    { 24, 10, "/images/device (117).png" },
                    { 25, 113, "/images/device (130).png" },
                    { 26, 122, "/images/device (115).png" },
                    { 27, 62, "/images/device (209).png" },
                    { 28, 39, "/images/device (269).png" },
                    { 29, 64, "/images/device (233).png" },
                    { 30, 130, "/images/device (109).png" },
                    { 31, 220, "/images/device (149).png" },
                    { 32, 6, "/images/device (92).png" },
                    { 33, 202, "/images/device (248).png" },
                    { 34, 198, "/images/device (206).png" },
                    { 35, 194, "/images/device (89).png" },
                    { 36, 228, "/images/device (214).png" },
                    { 37, 233, "/images/device (64).png" },
                    { 38, 191, "/images/device (42).png" },
                    { 39, 101, "/images/device (234).png" },
                    { 40, 232, "/images/device (89).png" },
                    { 41, 41, "/images/device (173).png" },
                    { 42, 155, "/images/device (190).png" },
                    { 43, 84, "/images/device (33).png" },
                    { 44, 5, "/images/device (150).png" },
                    { 45, 35, "/images/device (164).png" },
                    { 46, 236, "/images/device (168).png" },
                    { 47, 83, "/images/device (202).png" },
                    { 48, 125, "/images/device (50).png" },
                    { 49, 153, "/images/device (201).png" },
                    { 50, 133, "/images/device (174).png" },
                    { 51, 58, "/images/device (64).png" },
                    { 52, 183, "/images/device (268).png" },
                    { 53, 178, "/images/device (223).png" },
                    { 54, 181, "/images/device (74).png" },
                    { 55, 206, "/images/device (105).png" },
                    { 56, 48, "/images/device (271).png" },
                    { 57, 87, "/images/device (100).png" },
                    { 58, 56, "/images/device (88).png" },
                    { 59, 23, "/images/device (263).png" },
                    { 60, 142, "/images/device (58).png" },
                    { 61, 127, "/images/device (205).png" },
                    { 62, 197, "/images/device (165).png" },
                    { 63, 189, "/images/device (4).png" },
                    { 64, 188, "/images/device (94).png" },
                    { 65, 23, "/images/device (223).png" },
                    { 66, 201, "/images/device (196).png" },
                    { 67, 74, "/images/device (160).png" },
                    { 68, 66, "/images/device (161).png" },
                    { 69, 136, "/images/device (236).png" },
                    { 70, 229, "/images/device (138).png" },
                    { 71, 17, "/images/device (144).png" },
                    { 72, 36, "/images/device (262).png" },
                    { 73, 113, "/images/device (3).png" },
                    { 74, 229, "/images/device (171).png" },
                    { 75, 227, "/images/device (62).png" },
                    { 76, 48, "/images/device (91).png" },
                    { 77, 55, "/images/device (90).png" },
                    { 78, 79, "/images/device (75).png" },
                    { 79, 51, "/images/device (215).png" },
                    { 80, 106, "/images/device (67).png" },
                    { 81, 224, "/images/device (201).png" },
                    { 82, 53, "/images/device (81).png" },
                    { 83, 186, "/images/device (18).png" },
                    { 84, 40, "/images/device (160).png" },
                    { 85, 203, "/images/device (25).png" },
                    { 86, 87, "/images/device (147).png" },
                    { 87, 40, "/images/device (63).png" },
                    { 88, 121, "/images/device (118).png" },
                    { 89, 111, "/images/device (159).png" },
                    { 90, 42, "/images/device (182).png" },
                    { 91, 193, "/images/device (69).png" },
                    { 92, 108, "/images/device (123).png" },
                    { 93, 65, "/images/device (72).png" },
                    { 94, 180, "/images/device (211).png" },
                    { 95, 230, "/images/device (88).png" },
                    { 96, 30, "/images/device (221).png" },
                    { 97, 83, "/images/device (241).png" },
                    { 98, 216, "/images/device (167).png" },
                    { 99, 40, "/images/device (135).png" },
                    { 100, 36, "/images/device (199).png" },
                    { 101, 127, "/images/device (240).png" },
                    { 102, 23, "/images/device (132).png" },
                    { 103, 176, "/images/device (154).png" },
                    { 104, 29, "/images/device (210).png" },
                    { 105, 16, "/images/device (58).png" },
                    { 106, 164, "/images/device (64).png" },
                    { 107, 193, "/images/device (9).png" },
                    { 108, 11, "/images/device (252).png" },
                    { 109, 144, "/images/device (126).png" },
                    { 110, 158, "/images/device (25).png" },
                    { 111, 18, "/images/device (92).png" },
                    { 112, 170, "/images/device (158).png" },
                    { 113, 184, "/images/device (195).png" },
                    { 114, 209, "/images/device (251).png" },
                    { 115, 131, "/images/device (73).png" },
                    { 116, 57, "/images/device (148).png" },
                    { 117, 45, "/images/device (52).png" },
                    { 118, 27, "/images/device (19).png" },
                    { 119, 20, "/images/device (19).png" },
                    { 120, 128, "/images/device (12).png" },
                    { 121, 104, "/images/device (227).png" },
                    { 122, 100, "/images/device (173).png" },
                    { 123, 53, "/images/device (191).png" },
                    { 124, 39, "/images/device (269).png" },
                    { 125, 27, "/images/device (209).png" },
                    { 126, 94, "/images/device (53).png" },
                    { 127, 219, "/images/device (127).png" },
                    { 128, 82, "/images/device (51).png" },
                    { 129, 141, "/images/device (80).png" },
                    { 130, 198, "/images/device (258).png" },
                    { 131, 144, "/images/device (124).png" },
                    { 132, 50, "/images/device (185).png" },
                    { 133, 30, "/images/device (249).png" },
                    { 134, 156, "/images/device (124).png" },
                    { 135, 176, "/images/device (44).png" },
                    { 136, 138, "/images/device (87).png" },
                    { 137, 59, "/images/device (121).png" },
                    { 138, 80, "/images/device (107).png" },
                    { 139, 21, "/images/device (264).png" },
                    { 140, 141, "/images/device (189).png" },
                    { 141, 121, "/images/device (270).png" },
                    { 142, 41, "/images/device (32).png" },
                    { 143, 211, "/images/device (247).png" },
                    { 144, 53, "/images/device (42).png" },
                    { 145, 144, "/images/device (22).png" },
                    { 146, 117, "/images/device (8).png" },
                    { 147, 223, "/images/device (19).png" },
                    { 148, 189, "/images/device (218).png" },
                    { 149, 168, "/images/device (90).png" },
                    { 150, 219, "/images/device (59).png" },
                    { 151, 148, "/images/device (258).png" },
                    { 152, 70, "/images/device (233).png" },
                    { 153, 72, "/images/device (71).png" },
                    { 154, 173, "/images/device (32).png" },
                    { 155, 93, "/images/device (12).png" },
                    { 156, 51, "/images/device (128).png" },
                    { 157, 11, "/images/device (31).png" },
                    { 158, 190, "/images/device (30).png" },
                    { 159, 175, "/images/device (147).png" },
                    { 160, 225, "/images/device (147).png" },
                    { 161, 59, "/images/device (125).png" },
                    { 162, 80, "/images/device (69).png" },
                    { 163, 71, "/images/device (175).png" },
                    { 164, 51, "/images/device (1).png" },
                    { 165, 147, "/images/device (150).png" },
                    { 166, 105, "/images/device (138).png" },
                    { 167, 227, "/images/device (130).png" },
                    { 168, 170, "/images/device (98).png" },
                    { 169, 227, "/images/device (69).png" },
                    { 170, 66, "/images/device (198).png" },
                    { 171, 231, "/images/device (97).png" },
                    { 172, 221, "/images/device (122).png" },
                    { 173, 102, "/images/device (121).png" },
                    { 174, 207, "/images/device (231).png" },
                    { 175, 76, "/images/device (252).png" },
                    { 176, 107, "/images/device (195).png" },
                    { 177, 106, "/images/device (79).png" },
                    { 178, 98, "/images/device (14).png" },
                    { 179, 227, "/images/device (102).png" },
                    { 180, 134, "/images/device (208).png" },
                    { 181, 126, "/images/device (178).png" },
                    { 182, 25, "/images/device (151).png" },
                    { 183, 54, "/images/device (235).png" },
                    { 184, 57, "/images/device (135).png" },
                    { 185, 212, "/images/device (249).png" },
                    { 186, 52, "/images/device (11).png" },
                    { 187, 42, "/images/device (23).png" },
                    { 188, 62, "/images/device (206).png" },
                    { 189, 235, "/images/device (214).png" },
                    { 190, 97, "/images/device (240).png" },
                    { 191, 98, "/images/device (42).png" },
                    { 192, 137, "/images/device (35).png" },
                    { 193, 181, "/images/device (17).png" },
                    { 194, 231, "/images/device (41).png" },
                    { 195, 229, "/images/device (104).png" },
                    { 196, 40, "/images/device (190).png" },
                    { 197, 140, "/images/device (48).png" },
                    { 198, 82, "/images/device (183).png" },
                    { 199, 119, "/images/device (270).png" },
                    { 200, 59, "/images/device (219).png" },
                    { 201, 30, "/images/device (84).png" },
                    { 202, 9, "/images/device (233).png" },
                    { 203, 170, "/images/device (193).png" },
                    { 204, 9, "/images/device (87).png" },
                    { 205, 229, "/images/device (32).png" },
                    { 206, 162, "/images/device (118).png" },
                    { 207, 215, "/images/device (255).png" },
                    { 208, 232, "/images/device (227).png" },
                    { 209, 11, "/images/device (99).png" },
                    { 210, 236, "/images/device (114).png" },
                    { 211, 180, "/images/device (53).png" },
                    { 212, 183, "/images/device (186).png" },
                    { 213, 83, "/images/device (200).png" },
                    { 214, 217, "/images/device (188).png" },
                    { 215, 159, "/images/device (138).png" },
                    { 216, 45, "/images/device (117).png" },
                    { 217, 144, "/images/device (25).png" },
                    { 218, 170, "/images/device (60).png" },
                    { 219, 130, "/images/device (15).png" },
                    { 220, 216, "/images/device (20).png" },
                    { 221, 226, "/images/device (31).png" },
                    { 222, 18, "/images/device (145).png" },
                    { 223, 45, "/images/device (91).png" },
                    { 224, 136, "/images/device (70).png" },
                    { 225, 127, "/images/device (85).png" },
                    { 226, 133, "/images/device (192).png" },
                    { 227, 165, "/images/device (105).png" },
                    { 228, 230, "/images/device (112).png" },
                    { 229, 147, "/images/device (34).png" },
                    { 230, 71, "/images/device (180).png" },
                    { 231, 207, "/images/device (102).png" },
                    { 232, 90, "/images/device (248).png" },
                    { 233, 110, "/images/device (271).png" },
                    { 234, 213, "/images/device (35).png" },
                    { 235, 103, "/images/device (68).png" },
                    { 236, 215, "/images/device (21).png" },
                    { 237, 142, "/images/device (236).png" },
                    { 238, 159, "/images/device (57).png" },
                    { 239, 94, "/images/device (23).png" },
                    { 240, 149, "/images/device (3).png" },
                    { 241, 16, "/images/device (39).png" },
                    { 242, 189, "/images/device (179).png" },
                    { 243, 100, "/images/device (221).png" },
                    { 244, 123, "/images/device (146).png" },
                    { 245, 225, "/images/device (17).png" },
                    { 246, 80, "/images/device (87).png" },
                    { 247, 76, "/images/device (102).png" },
                    { 248, 161, "/images/device (47).png" },
                    { 249, 93, "/images/device (193).png" },
                    { 250, 114, "/images/device (173).png" },
                    { 251, 116, "/images/device (19).png" },
                    { 252, 187, "/images/device (21).png" },
                    { 253, 230, "/images/device (142).png" },
                    { 254, 82, "/images/device (127).png" },
                    { 255, 25, "/images/device (174).png" },
                    { 256, 167, "/images/device (258).png" },
                    { 257, 26, "/images/device (208).png" },
                    { 258, 106, "/images/device (20).png" },
                    { 259, 17, "/images/device (50).png" },
                    { 260, 130, "/images/device (138).png" },
                    { 261, 173, "/images/device (70).png" },
                    { 262, 184, "/images/device (268).png" },
                    { 263, 128, "/images/device (225).png" },
                    { 264, 178, "/images/device (130).png" },
                    { 265, 218, "/images/device (220).png" },
                    { 266, 106, "/images/device (34).png" },
                    { 267, 43, "/images/device (55).png" },
                    { 268, 119, "/images/device (37).png" },
                    { 269, 7, "/images/device (208).png" },
                    { 270, 61, "/images/device (24).png" },
                    { 271, 155, "/images/device (110).png" },
                    { 272, 178, "/images/device (242).png" },
                    { 273, 200, "/images/device (37).png" },
                    { 274, 140, "/images/device (63).png" },
                    { 275, 49, "/images/device (146).png" },
                    { 276, 160, "/images/device (27).png" },
                    { 277, 70, "/images/device (227).png" },
                    { 278, 68, "/images/device (62).png" },
                    { 279, 12, "/images/device (131).png" },
                    { 280, 58, "/images/device (198).png" },
                    { 281, 169, "/images/device (97).png" },
                    { 282, 99, "/images/device (167).png" },
                    { 283, 80, "/images/device (62).png" },
                    { 284, 108, "/images/device (205).png" },
                    { 285, 64, "/images/device (132).png" },
                    { 286, 59, "/images/device (1).png" },
                    { 287, 172, "/images/device (189).png" },
                    { 288, 210, "/images/device (197).png" },
                    { 289, 200, "/images/device (261).png" },
                    { 290, 42, "/images/device (86).png" },
                    { 291, 91, "/images/device (259).png" },
                    { 292, 99, "/images/device (8).png" },
                    { 293, 203, "/images/device (162).png" },
                    { 294, 41, "/images/device (62).png" },
                    { 295, 37, "/images/device (116).png" },
                    { 296, 101, "/images/device (204).png" },
                    { 297, 80, "/images/device (225).png" },
                    { 298, 149, "/images/device (111).png" },
                    { 299, 167, "/images/device (146).png" },
                    { 300, 138, "/images/device (2).png" },
                    { 301, 74, "/images/device (196).png" },
                    { 302, 28, "/images/device (259).png" },
                    { 303, 19, "/images/device (111).png" },
                    { 304, 50, "/images/device (119).png" },
                    { 305, 139, "/images/device (247).png" },
                    { 306, 201, "/images/device (101).png" },
                    { 307, 107, "/images/device (184).png" },
                    { 308, 139, "/images/device (219).png" },
                    { 309, 205, "/images/device (64).png" },
                    { 310, 170, "/images/device (34).png" },
                    { 311, 32, "/images/device (182).png" },
                    { 312, 3, "/images/device (77).png" },
                    { 313, 186, "/images/device (92).png" },
                    { 314, 23, "/images/device (5).png" },
                    { 315, 222, "/images/device (269).png" },
                    { 316, 179, "/images/device (239).png" },
                    { 317, 44, "/images/device (57).png" },
                    { 318, 85, "/images/device (215).png" },
                    { 319, 232, "/images/device (213).png" },
                    { 320, 132, "/images/device (51).png" },
                    { 321, 159, "/images/device (106).png" },
                    { 322, 204, "/images/device (114).png" },
                    { 323, 115, "/images/device (234).png" },
                    { 324, 21, "/images/device (102).png" },
                    { 325, 54, "/images/device (139).png" },
                    { 326, 220, "/images/device (216).png" },
                    { 327, 68, "/images/device (157).png" },
                    { 328, 8, "/images/device (181).png" },
                    { 329, 95, "/images/device (227).png" },
                    { 330, 187, "/images/device (32).png" },
                    { 331, 228, "/images/device (109).png" },
                    { 332, 145, "/images/device (39).png" },
                    { 333, 74, "/images/device (243).png" },
                    { 334, 12, "/images/device (182).png" },
                    { 335, 112, "/images/device (248).png" },
                    { 336, 176, "/images/device (120).png" },
                    { 337, 38, "/images/device (225).png" },
                    { 338, 148, "/images/device (36).png" },
                    { 339, 20, "/images/device (19).png" },
                    { 340, 198, "/images/device (8).png" },
                    { 341, 169, "/images/device (11).png" },
                    { 342, 68, "/images/device (117).png" },
                    { 343, 223, "/images/device (44).png" },
                    { 344, 20, "/images/device (242).png" },
                    { 345, 53, "/images/device (249).png" },
                    { 346, 183, "/images/device (128).png" },
                    { 347, 231, "/images/device (232).png" },
                    { 348, 9, "/images/device (42).png" },
                    { 349, 189, "/images/device (207).png" },
                    { 350, 22, "/images/device (162).png" },
                    { 351, 96, "/images/device (101).png" },
                    { 352, 18, "/images/device (209).png" },
                    { 353, 96, "/images/device (104).png" },
                    { 354, 211, "/images/device (28).png" },
                    { 355, 16, "/images/device (135).png" },
                    { 356, 217, "/images/device (132).png" },
                    { 357, 97, "/images/device (80).png" },
                    { 358, 231, "/images/device (129).png" },
                    { 359, 234, "/images/device (32).png" },
                    { 360, 223, "/images/device (180).png" },
                    { 361, 10, "/images/device (75).png" },
                    { 362, 34, "/images/device (245).png" },
                    { 363, 16, "/images/device (159).png" },
                    { 364, 19, "/images/device (62).png" },
                    { 365, 141, "/images/device (149).png" },
                    { 366, 135, "/images/device (77).png" },
                    { 367, 172, "/images/device (216).png" },
                    { 368, 169, "/images/device (27).png" },
                    { 369, 122, "/images/device (227).png" },
                    { 370, 179, "/images/device (129).png" },
                    { 371, 3, "/images/device (165).png" },
                    { 372, 51, "/images/device (37).png" },
                    { 373, 173, "/images/device (201).png" },
                    { 374, 52, "/images/device (227).png" },
                    { 375, 226, "/images/device (91).png" },
                    { 376, 160, "/images/device (145).png" },
                    { 377, 61, "/images/device (216).png" },
                    { 378, 107, "/images/device (104).png" },
                    { 379, 94, "/images/device (122).png" },
                    { 380, 44, "/images/device (53).png" },
                    { 381, 206, "/images/device (215).png" },
                    { 382, 136, "/images/device (169).png" },
                    { 383, 79, "/images/device (37).png" },
                    { 384, 120, "/images/device (168).png" },
                    { 385, 16, "/images/device (106).png" },
                    { 386, 157, "/images/device (5).png" },
                    { 387, 191, "/images/device (16).png" },
                    { 388, 13, "/images/device (90).png" },
                    { 389, 13, "/images/device (193).png" },
                    { 390, 134, "/images/device (105).png" },
                    { 391, 188, "/images/device (177).png" },
                    { 392, 100, "/images/device (7).png" },
                    { 393, 5, "/images/device (227).png" },
                    { 394, 112, "/images/device (13).png" },
                    { 395, 234, "/images/device (113).png" },
                    { 396, 139, "/images/device (164).png" },
                    { 397, 78, "/images/device (97).png" },
                    { 398, 31, "/images/device (5).png" },
                    { 399, 133, "/images/device (52).png" },
                    { 400, 143, "/images/device (45).png" },
                    { 401, 140, "/images/device (225).png" },
                    { 402, 191, "/images/device (273).png" },
                    { 403, 119, "/images/device (3).png" },
                    { 404, 186, "/images/device (204).png" },
                    { 405, 193, "/images/device (17).png" },
                    { 406, 80, "/images/device (146).png" },
                    { 407, 80, "/images/device (246).png" },
                    { 408, 19, "/images/device (18).png" },
                    { 409, 104, "/images/device (265).png" },
                    { 410, 119, "/images/device (274).png" },
                    { 411, 40, "/images/device (257).png" },
                    { 412, 23, "/images/device (42).png" },
                    { 413, 216, "/images/device (15).png" },
                    { 414, 171, "/images/device (140).png" },
                    { 415, 214, "/images/device (210).png" },
                    { 416, 174, "/images/device (169).png" },
                    { 417, 146, "/images/device (124).png" },
                    { 418, 103, "/images/device (41).png" },
                    { 419, 196, "/images/device (26).png" },
                    { 420, 70, "/images/device (143).png" },
                    { 421, 186, "/images/device (247).png" },
                    { 422, 132, "/images/device (259).png" },
                    { 423, 229, "/images/device (3).png" },
                    { 424, 176, "/images/device (161).png" },
                    { 425, 60, "/images/device (199).png" },
                    { 426, 46, "/images/device (181).png" },
                    { 427, 189, "/images/device (46).png" },
                    { 428, 192, "/images/device (43).png" },
                    { 429, 15, "/images/device (96).png" },
                    { 430, 190, "/images/device (121).png" },
                    { 431, 51, "/images/device (166).png" },
                    { 432, 107, "/images/device (169).png" },
                    { 433, 11, "/images/device (130).png" },
                    { 434, 97, "/images/device (101).png" },
                    { 435, 74, "/images/device (195).png" },
                    { 436, 32, "/images/device (196).png" },
                    { 437, 35, "/images/device (248).png" },
                    { 438, 224, "/images/device (44).png" },
                    { 439, 15, "/images/device (22).png" },
                    { 440, 161, "/images/device (273).png" },
                    { 441, 92, "/images/device (153).png" },
                    { 442, 102, "/images/device (63).png" },
                    { 443, 53, "/images/device (104).png" },
                    { 444, 205, "/images/device (9).png" },
                    { 445, 147, "/images/device (68).png" },
                    { 446, 183, "/images/device (222).png" },
                    { 447, 141, "/images/device (194).png" },
                    { 448, 225, "/images/device (70).png" },
                    { 449, 181, "/images/device (182).png" },
                    { 450, 184, "/images/device (162).png" },
                    { 451, 219, "/images/device (112).png" },
                    { 452, 29, "/images/device (12).png" },
                    { 453, 9, "/images/device (211).png" },
                    { 454, 20, "/images/device (134).png" },
                    { 455, 6, "/images/device (68).png" },
                    { 456, 130, "/images/device (183).png" },
                    { 457, 193, "/images/device (51).png" },
                    { 458, 117, "/images/device (163).png" },
                    { 459, 168, "/images/device (30).png" },
                    { 460, 169, "/images/device (63).png" },
                    { 461, 129, "/images/device (87).png" },
                    { 462, 40, "/images/device (197).png" },
                    { 463, 1, "/images/device (53).png" },
                    { 464, 155, "/images/device (249).png" },
                    { 465, 21, "/images/device (246).png" },
                    { 466, 151, "/images/device (75).png" },
                    { 467, 217, "/images/device (95).png" },
                    { 468, 213, "/images/device (141).png" },
                    { 469, 97, "/images/device (226).png" },
                    { 470, 120, "/images/device (33).png" },
                    { 471, 35, "/images/device (231).png" },
                    { 472, 71, "/images/device (204).png" },
                    { 473, 87, "/images/device (194).png" },
                    { 474, 88, "/images/device (147).png" },
                    { 475, 221, "/images/device (60).png" },
                    { 476, 126, "/images/device (4).png" },
                    { 477, 32, "/images/device (69).png" },
                    { 478, 199, "/images/device (26).png" },
                    { 479, 219, "/images/device (242).png" },
                    { 480, 178, "/images/device (128).png" },
                    { 481, 97, "/images/device (217).png" },
                    { 482, 151, "/images/device (90).png" },
                    { 483, 205, "/images/device (28).png" },
                    { 484, 236, "/images/device (27).png" },
                    { 485, 66, "/images/device (94).png" },
                    { 486, 23, "/images/device (59).png" },
                    { 487, 226, "/images/device (184).png" },
                    { 488, 2, "/images/device (185).png" },
                    { 489, 53, "/images/device (41).png" },
                    { 490, 175, "/images/device (86).png" },
                    { 491, 193, "/images/device (209).png" },
                    { 492, 235, "/images/device (160).png" },
                    { 493, 53, "/images/device (265).png" },
                    { 494, 77, "/images/device (203).png" },
                    { 495, 114, "/images/device (269).png" },
                    { 496, 198, "/images/device (215).png" },
                    { 497, 26, "/images/device (198).png" },
                    { 498, 87, "/images/device (250).png" },
                    { 499, 146, "/images/device (24).png" },
                    { 500, 75, "/images/device (215).png" },
                    { 501, 74, "/images/device (117).png" },
                    { 502, 66, "/images/device (190).png" },
                    { 503, 189, "/images/device (91).png" },
                    { 504, 106, "/images/device (83).png" },
                    { 505, 223, "/images/device (110).png" },
                    { 506, 167, "/images/device (243).png" },
                    { 507, 132, "/images/device (263).png" },
                    { 508, 207, "/images/device (125).png" },
                    { 509, 217, "/images/device (64).png" },
                    { 510, 82, "/images/device (124).png" },
                    { 511, 213, "/images/device (104).png" },
                    { 512, 142, "/images/device (109).png" },
                    { 513, 207, "/images/device (180).png" },
                    { 514, 164, "/images/device (151).png" },
                    { 515, 96, "/images/device (45).png" },
                    { 516, 5, "/images/device (101).png" },
                    { 517, 63, "/images/device (163).png" },
                    { 518, 130, "/images/device (63).png" },
                    { 519, 36, "/images/device (260).png" },
                    { 520, 193, "/images/device (182).png" },
                    { 521, 40, "/images/device (93).png" },
                    { 522, 35, "/images/device (176).png" },
                    { 523, 111, "/images/device (70).png" },
                    { 524, 183, "/images/device (8).png" },
                    { 525, 167, "/images/device (143).png" },
                    { 526, 167, "/images/device (119).png" },
                    { 527, 130, "/images/device (73).png" },
                    { 528, 67, "/images/device (129).png" },
                    { 529, 178, "/images/device (49).png" },
                    { 530, 168, "/images/device (53).png" },
                    { 531, 17, "/images/device (265).png" },
                    { 532, 189, "/images/device (212).png" },
                    { 533, 87, "/images/device (70).png" },
                    { 534, 199, "/images/device (157).png" },
                    { 535, 143, "/images/device (136).png" },
                    { 536, 177, "/images/device (236).png" },
                    { 537, 133, "/images/device (104).png" },
                    { 538, 230, "/images/device (252).png" },
                    { 539, 82, "/images/device (93).png" },
                    { 540, 108, "/images/device (198).png" },
                    { 541, 198, "/images/device (268).png" },
                    { 542, 204, "/images/device (170).png" },
                    { 543, 3, "/images/device (254).png" },
                    { 544, 236, "/images/device (149).png" },
                    { 545, 128, "/images/device (255).png" },
                    { 546, 44, "/images/device (8).png" },
                    { 547, 95, "/images/device (128).png" },
                    { 548, 200, "/images/device (193).png" },
                    { 549, 133, "/images/device (260).png" },
                    { 550, 97, "/images/device (201).png" },
                    { 551, 118, "/images/device (139).png" },
                    { 552, 157, "/images/device (250).png" },
                    { 553, 153, "/images/device (75).png" },
                    { 554, 83, "/images/device (106).png" },
                    { 555, 135, "/images/device (96).png" },
                    { 556, 225, "/images/device (239).png" },
                    { 557, 104, "/images/device (32).png" },
                    { 558, 185, "/images/device (96).png" },
                    { 559, 210, "/images/device (228).png" },
                    { 560, 121, "/images/device (54).png" },
                    { 561, 76, "/images/device (147).png" },
                    { 562, 95, "/images/device (31).png" },
                    { 563, 84, "/images/device (55).png" },
                    { 564, 168, "/images/device (31).png" },
                    { 565, 174, "/images/device (145).png" },
                    { 566, 82, "/images/device (75).png" },
                    { 567, 50, "/images/device (243).png" },
                    { 568, 30, "/images/device (150).png" },
                    { 569, 161, "/images/device (71).png" },
                    { 570, 67, "/images/device (77).png" },
                    { 571, 86, "/images/device (128).png" },
                    { 572, 84, "/images/device (188).png" },
                    { 573, 101, "/images/device (94).png" },
                    { 574, 151, "/images/device (211).png" },
                    { 575, 80, "/images/device (49).png" },
                    { 576, 11, "/images/device (209).png" },
                    { 577, 147, "/images/device (139).png" },
                    { 578, 2, "/images/device (74).png" },
                    { 579, 16, "/images/device (153).png" },
                    { 580, 30, "/images/device (213).png" },
                    { 581, 116, "/images/device (26).png" },
                    { 582, 101, "/images/device (269).png" },
                    { 583, 216, "/images/device (147).png" },
                    { 584, 28, "/images/device (127).png" },
                    { 585, 158, "/images/device (157).png" },
                    { 586, 51, "/images/device (204).png" },
                    { 587, 40, "/images/device (87).png" },
                    { 588, 175, "/images/device (33).png" },
                    { 589, 231, "/images/device (75).png" },
                    { 590, 24, "/images/device (38).png" },
                    { 591, 90, "/images/device (198).png" },
                    { 592, 161, "/images/device (101).png" },
                    { 593, 101, "/images/device (198).png" },
                    { 594, 63, "/images/device (114).png" },
                    { 595, 135, "/images/device (258).png" },
                    { 596, 135, "/images/device (211).png" },
                    { 597, 24, "/images/device (187).png" },
                    { 598, 207, "/images/device (82).png" },
                    { 599, 13, "/images/device (115).png" },
                    { 600, 23, "/images/device (137).png" },
                    { 601, 156, "/images/device (162).png" },
                    { 602, 177, "/images/device (230).png" },
                    { 603, 208, "/images/device (267).png" },
                    { 604, 192, "/images/device (30).png" },
                    { 605, 185, "/images/device (187).png" },
                    { 606, 3, "/images/device (98).png" },
                    { 607, 226, "/images/device (185).png" },
                    { 608, 16, "/images/device (156).png" },
                    { 609, 4, "/images/device (36).png" },
                    { 610, 172, "/images/device (246).png" },
                    { 611, 171, "/images/device (18).png" },
                    { 612, 220, "/images/device (28).png" },
                    { 613, 105, "/images/device (7).png" },
                    { 614, 25, "/images/device (8).png" },
                    { 615, 63, "/images/device (18).png" },
                    { 616, 77, "/images/device (14).png" },
                    { 617, 42, "/images/device (272).png" },
                    { 618, 1, "/images/device (152).png" },
                    { 619, 149, "/images/device (21).png" },
                    { 620, 184, "/images/device (168).png" },
                    { 621, 233, "/images/device (194).png" },
                    { 622, 181, "/images/device (50).png" },
                    { 623, 190, "/images/device (173).png" },
                    { 624, 1, "/images/device (7).png" },
                    { 625, 142, "/images/device (12).png" },
                    { 626, 68, "/images/device (181).png" },
                    { 627, 6, "/images/device (81).png" },
                    { 628, 63, "/images/device (241).png" },
                    { 629, 213, "/images/device (228).png" },
                    { 630, 216, "/images/device (203).png" },
                    { 631, 134, "/images/device (12).png" },
                    { 632, 182, "/images/device (33).png" },
                    { 633, 113, "/images/device (21).png" },
                    { 634, 197, "/images/device (26).png" },
                    { 635, 132, "/images/device (41).png" },
                    { 636, 56, "/images/device (265).png" },
                    { 637, 148, "/images/device (246).png" },
                    { 638, 186, "/images/device (192).png" },
                    { 639, 131, "/images/device (210).png" },
                    { 640, 14, "/images/device (31).png" },
                    { 641, 5, "/images/device (20).png" },
                    { 642, 110, "/images/device (68).png" },
                    { 643, 165, "/images/device (78).png" },
                    { 644, 20, "/images/device (228).png" },
                    { 645, 49, "/images/device (48).png" },
                    { 646, 224, "/images/device (243).png" },
                    { 647, 48, "/images/device (259).png" },
                    { 648, 151, "/images/device (161).png" },
                    { 649, 188, "/images/device (273).png" },
                    { 650, 145, "/images/device (5).png" },
                    { 651, 170, "/images/device (13).png" },
                    { 652, 96, "/images/device (179).png" },
                    { 653, 190, "/images/device (266).png" },
                    { 654, 66, "/images/device (73).png" },
                    { 655, 20, "/images/device (177).png" },
                    { 656, 190, "/images/device (251).png" },
                    { 657, 81, "/images/device (21).png" },
                    { 658, 186, "/images/device (32).png" },
                    { 659, 178, "/images/device (166).png" },
                    { 660, 31, "/images/device (93).png" },
                    { 661, 95, "/images/device (110).png" },
                    { 662, 201, "/images/device (209).png" },
                    { 663, 92, "/images/device (107).png" },
                    { 664, 136, "/images/device (22).png" },
                    { 665, 225, "/images/device (200).png" },
                    { 666, 209, "/images/device (117).png" },
                    { 667, 66, "/images/device (33).png" },
                    { 668, 106, "/images/device (148).png" },
                    { 669, 105, "/images/device (149).png" },
                    { 670, 42, "/images/device (153).png" },
                    { 671, 191, "/images/device (39).png" },
                    { 672, 135, "/images/device (102).png" },
                    { 673, 164, "/images/device (123).png" },
                    { 674, 100, "/images/device (110).png" },
                    { 675, 136, "/images/device (40).png" },
                    { 676, 106, "/images/device (27).png" },
                    { 677, 207, "/images/device (41).png" },
                    { 678, 44, "/images/device (264).png" },
                    { 679, 193, "/images/device (36).png" },
                    { 680, 112, "/images/device (151).png" },
                    { 681, 183, "/images/device (253).png" },
                    { 682, 70, "/images/device (126).png" },
                    { 683, 156, "/images/device (46).png" },
                    { 684, 173, "/images/device (205).png" },
                    { 685, 187, "/images/device (238).png" },
                    { 686, 130, "/images/device (192).png" },
                    { 687, 4, "/images/device (6).png" },
                    { 688, 27, "/images/device (260).png" },
                    { 689, 186, "/images/device (25).png" },
                    { 690, 113, "/images/device (63).png" },
                    { 691, 122, "/images/device (64).png" },
                    { 692, 58, "/images/device (37).png" },
                    { 693, 200, "/images/device (55).png" },
                    { 694, 48, "/images/device (207).png" },
                    { 695, 78, "/images/device (168).png" },
                    { 696, 87, "/images/device (120).png" },
                    { 697, 216, "/images/device (155).png" },
                    { 698, 126, "/images/device (137).png" },
                    { 699, 204, "/images/device (186).png" },
                    { 700, 226, "/images/device (67).png" },
                    { 701, 83, "/images/device (273).png" },
                    { 702, 231, "/images/device (139).png" },
                    { 703, 65, "/images/device (52).png" },
                    { 704, 104, "/images/device (25).png" },
                    { 705, 69, "/images/device (210).png" },
                    { 706, 79, "/images/device (110).png" },
                    { 707, 204, "/images/device (264).png" },
                    { 708, 156, "/images/device (191).png" },
                    { 709, 212, "/images/device (274).png" },
                    { 710, 19, "/images/device (211).png" },
                    { 711, 177, "/images/device (182).png" },
                    { 712, 125, "/images/device (68).png" },
                    { 713, 3, "/images/device (267).png" },
                    { 714, 4, "/images/device (103).png" },
                    { 715, 75, "/images/device (17).png" },
                    { 716, 216, "/images/device (247).png" },
                    { 717, 109, "/images/device (221).png" },
                    { 718, 91, "/images/device (50).png" },
                    { 719, 69, "/images/device (264).png" },
                    { 720, 57, "/images/device (223).png" },
                    { 721, 193, "/images/device (108).png" },
                    { 722, 138, "/images/device (28).png" },
                    { 723, 1, "/images/device (212).png" },
                    { 724, 100, "/images/device (90).png" },
                    { 725, 36, "/images/device (239).png" },
                    { 726, 143, "/images/device (229).png" },
                    { 727, 67, "/images/device (69).png" },
                    { 728, 137, "/images/device (102).png" },
                    { 729, 158, "/images/device (201).png" },
                    { 730, 134, "/images/device (200).png" },
                    { 731, 50, "/images/device (193).png" },
                    { 732, 171, "/images/device (218).png" },
                    { 733, 107, "/images/device (235).png" },
                    { 734, 55, "/images/device (67).png" },
                    { 735, 116, "/images/device (68).png" },
                    { 736, 105, "/images/device (258).png" },
                    { 737, 34, "/images/device (233).png" },
                    { 738, 184, "/images/device (52).png" },
                    { 739, 188, "/images/device (270).png" },
                    { 740, 46, "/images/device (114).png" },
                    { 741, 121, "/images/device (253).png" },
                    { 742, 88, "/images/device (66).png" },
                    { 743, 94, "/images/device (171).png" },
                    { 744, 80, "/images/device (156).png" },
                    { 745, 18, "/images/device (216).png" },
                    { 746, 110, "/images/device (85).png" },
                    { 747, 22, "/images/device (211).png" },
                    { 748, 122, "/images/device (195).png" },
                    { 749, 147, "/images/device (81).png" },
                    { 750, 24, "/images/device (187).png" }
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
                name: "IX_Orders_OrderStatusId1",
                table: "Orders",
                column: "OrderStatusId1");

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
                name: "IX_Vouchers_ShopId",
                table: "Vouchers",
                column: "ShopId");

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

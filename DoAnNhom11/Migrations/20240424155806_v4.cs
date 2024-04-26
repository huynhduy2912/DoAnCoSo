using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoAnNhom11.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_ProductCategoryId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", null, "Customer", "CUSTOMER" }
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
                columns: new[] { "ProductCategoryId", "TenLoai" },
                values: new object[,]
                {
                    { 1, "Laptop" },
                    { 2, "Điện Thoại" },
                    { 3, "Máy Tính Bảng" },
                    { 4, "Đồng Hồ" },
                    { 5, "Phụ Kiện" },
                    { 6, "Sim" },
                    { 7, "Bàn phím" },
                    { 8, "Tai Nghe" }
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
                    { 5, "Đã Đã Thanh Toán Và Nhận Hàng" }
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
                    { 1, "/images/device (248).png", "/images/device (167).png", "YfIfvZlnMA,Yhmv48QajP,csgVaIKbtM", "fCOSJuJ527", "Mô tả mẫu của sản phẩm2", new DateTime(2024, 4, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6292), 2, "Shop:BFklxuzv6G1" },
                    { 2, "/images/device (182).png", "/images/device (194).png", "QTkqu7jKEK,kxtvzMP9BE,oo3GgqCMAK", "0XEon3LQXd", "Mô tả mẫu của cửa hàng3", new DateTime(2024, 4, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6350), 2, "ShopoQu8CPZo6Y2" },
                    { 3, "/images/device (115).png", "/images/device (271).png", "Qe83SGRue9,LQNIGj0148,6zbhrXsLzd", "j1x4gJcrN3", "Mô tả mẫu của sản phẩm4", new DateTime(2024, 4, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6366), 8, "Shop:iQE3l941wj3" },
                    { 4, "/images/device (91).png", "/images/device (92).png", "3n8I0U8lvv,U9rnQnVb8q,Sfyofe2NVu", "EQ4DQjjh8Y", "Mô tả mẫu của sản phẩm5", new DateTime(2024, 4, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6380), 1, "Shop:EuksDCA98K4" },
                    { 5, "/images/device (260).png", "/images/device (61).png", "j8MrXFxL09,qcRtSv5hmX,faSfv0nsaX", "CN35c2jB6b", "Mô tả mẫu của sản phẩm6", new DateTime(2024, 4, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6394), 8, "Shop:Hy0FNZSGvM5" },
                    { 6, "/images/device (236).png", "/images/device (20).png", "54gt16Poi4,Ma0UabPLqe,bGavMKGQ4m", "sYapRD9fDf", "Mô tả mẫu của sản phẩm7", new DateTime(2024, 4, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6409), 5, "Shop:5EYOPzUlYu6" },
                    { 7, "/images/device (73).png", "/images/device (114).png", "QiIIrHDKsq,D7kpI1FZV3,ADznN1LBuI", "TBolVBGs78", "Mô tả mẫu của sản phẩm8", new DateTime(2024, 4, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6422), 2, "Shop:BOlPFsMBZ27" },
                    { 8, "/images/device (79).png", "/images/device (46).png", "EHNDEpCLcU,nOnq6cYKYt,mvskPFFfX5", "umRVoHi56p", "Mô tả mẫu của sản phẩm9", new DateTime(2024, 4, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6436), 8, "Shop:ah4nH1Y8pM8" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "VoucherId", "NgayHetHan", "PhanTramGiam", "SoLuongCon", "VoucherCategoryId", "VoucherCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6189), 20, 100, 1, "GIAMGIA1" },
                    { 2, new DateTime(2024, 6, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6212), 10, 100, 2, "GIAMGIA2" },
                    { 3, new DateTime(2024, 6, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6214), 15, 100, 3, "GIAMGIA3" },
                    { 4, new DateTime(2024, 6, 24, 22, 58, 4, 914, DateTimeKind.Local).AddTicks(6216), 12, 100, 4, "GIAMGIA4" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AnhDaiDien", "BrandId", "GiaBan", "GiaNhap", "MoTa", "PhanTramGiam", "ProductCategoryId", "ShopId", "SoLuongCon", "TenSp", "ThongSo" },
                values: new object[,]
                {
                    { 1, "/images/device (92).png", 4, 8000000m, 41000000m, "Mô tả mẫu của sản phẩm1", 35, 5, 2, 100, "oeLZ3Bl9sI1", "RAM:300GB Man hinh :16inch" },
                    { 2, "/images/device (137).png", 5, 35000000m, 48000000m, "Mô tả mẫu của sản phẩm2", 9, 1, 2, 200, "TEXzj5ZZXG2", "RAM:31Memory:72GB Man hinh :16inch" },
                    { 3, "/images/device (233).png", 4, 3000000m, 45000000m, "Mô tả mẫu của sản phẩm3", 26, 5, 3, 400, "V1cm23irqo3", "RAM:12Memory:365GB Man hinh :8inch" },
                    { 4, "/images/device (223).png", 6, 8000000m, 4000000m, "Mô tả mẫu của sản phẩm4", 15, 1, 1, 400, "EbxVGjrmqZ4", "RAM:7Memory:479GB Man hinh :16inch" },
                    { 5, "/images/device (224).png", 7, 4000000m, 26000000m, "Mô tả mẫu của sản phẩm5", 21, 6, 6, 300, "W1mYoWKrLo5", "RAM:24Memory:32GB Man hinh :4inch" },
                    { 6, "/images/device (127).png", 2, 16000000m, 2000000m, "Mô tả mẫu của sản phẩm6", 31, 2, 4, 200, "bjYoK23mQL6", "RAM:10Memory:197GB Man hinh :12inch" },
                    { 7, "/images/device (68).png", 5, 25000000m, 15000000m, "Mô tả mẫu của sản phẩm7", 28, 3, 6, 200, "XKVbBTxDEG7", "RAM:6Memory:474GB Man hinh :16inch" },
                    { 8, "/images/device (141).png", 4, 35000000m, 3000000m, "Mô tả mẫu của sản phẩm8", 30, 5, 4, 400, "OMCFxq3zQI8", "RAM:28Memory:100GB Man hinh :12inch" },
                    { 9, "/images/device (272).png", 7, 24000000m, 28000000m, "Mô tả mẫu của sản phẩm9", 26, 4, 5, 100, "d8qqvYONcx9", "RAM:12Memory:97GB Man hinh :16inch" },
                    { 10, "/images/device (187).png", 4, 35000000m, 41000000m, "Mô tả mẫu của sản phẩm10", 33, 8, 7, 400, "41JbJu6xJc10", "RAM:24Memory:405GB Man hinh :16inch" },
                    { 11, "/images/device (235).png", 7, 9000000m, 14000000m, "Mô tả mẫu của sản phẩm11", 5, 8, 5, 300, "HzdZiGaWTC11", "RAM:17Memory:242GB Man hinh :12inch" },
                    { 12, "/images/device (225).png", 3, 49000000m, 17000000m, "Mô tả mẫu của sản phẩm12", 36, 2, 7, 200, "uqxPrH735C12", "RAM:4Memory:81GB Man hinh :16inch" },
                    { 13, "/images/device (6).png", 8, 48000000m, 36000000m, "Mô tả mẫu của sản phẩm13", 20, 7, 2, 400, "CSw2FJEsxa13", "RAM:8Memory:348GB Man hinh :8inch" },
                    { 14, "/images/device (228).png", 3, 16000000m, 2000000m, "Mô tả mẫu của sản phẩm14", 28, 4, 4, 400, "LDPfGyH3r114", "RAM:2Memory:120GB Man hinh :8inch" },
                    { 15, "/images/device (104).png", 7, 46000000m, 18000000m, "Mô tả mẫu của sản phẩm15", 24, 1, 7, 400, "mTy1r8ntj815", "RAM:5Memory:401GB Man hinh :8inch" },
                    { 16, "/images/device (74).png", 8, 20000000m, 21000000m, "Mô tả mẫu của sản phẩm16", 29, 4, 7, 400, "fQYCkBez4o16", "RAM:30Memory:113GB Man hinh :4inch" },
                    { 17, "/images/device (239).png", 7, 14000000m, 27000000m, "Mô tả mẫu của sản phẩm17", 11, 6, 2, 300, "yUChYYZXso17", "RAM:27Memory:304GB Man hinh :12inch" },
                    { 18, "/images/device (170).png", 1, 1000000m, 34000000m, "Mô tả mẫu của sản phẩm18", 15, 3, 8, 200, "stsMzYlwft18", "RAM:14Memory:496GB Man hinh :12inch" },
                    { 19, "/images/device (46).png", 8, 27000000m, 27000000m, "Mô tả mẫu của sản phẩm19", 22, 3, 3, 300, "MrLABvlGr719", "RAM:5Memory:469GB Man hinh :8inch" },
                    { 20, "/images/device (169).png", 7, 31000000m, 29000000m, "Mô tả mẫu của sản phẩm20", 13, 6, 1, 400, "Fcf1Z0wXc420", "RAM:30Memory:358GB Man hinh :4inch" },
                    { 21, "/images/device (219).png", 7, 36000000m, 4000000m, "Mô tả mẫu của sản phẩm21", 20, 5, 1, 400, "FZ5VWG8Gip21", "RAM:22Memory:210GB Man hinh :12inch" },
                    { 22, "/images/device (144).png", 1, 1000000m, 28000000m, "Mô tả mẫu của sản phẩm22", 28, 8, 7, 300, "gOVTnOwRjP22", "RAM:4Memory:32GB Man hinh :16inch" },
                    { 23, "/images/device (84).png", 8, 41000000m, 34000000m, "Mô tả mẫu của sản phẩm23", 33, 8, 5, 100, "WoC5NEHSks23", "RAM:11Memory:409GB Man hinh :4inch" },
                    { 24, "/images/device (86).png", 3, 47000000m, 12000000m, "Mô tả mẫu của sản phẩm24", 29, 8, 1, 200, "6P8APbp28c24", "RAM:12Memory:392GB Man hinh :12inch" },
                    { 25, "/images/device (11).png", 1, 2000000m, 23000000m, "Mô tả mẫu của sản phẩm25", 24, 5, 3, 100, "tOom8aMZeF25", "RAM:18Memory:393GB Man hinh :12inch" },
                    { 26, "/images/device (209).png", 6, 30000000m, 38000000m, "Mô tả mẫu của sản phẩm26", 23, 8, 1, 400, "3BejbYRNsf26", "RAM:14Memory:478GB Man hinh :16inch" },
                    { 27, "/images/device (245).png", 3, 29000000m, 38000000m, "Mô tả mẫu của sản phẩm27", 35, 4, 1, 300, "OWWtZkVGeU27", "RAM:28Memory:345GB Man hinh :8inch" },
                    { 28, "/images/device (201).png", 6, 46000000m, 6000000m, "Mô tả mẫu của sản phẩm28", 34, 7, 5, 200, "nCdgvhRr0428", "RAM:31Memory:92GB Man hinh :12inch" },
                    { 29, "/images/device (272).png", 4, 49000000m, 20000000m, "Mô tả mẫu của sản phẩm29", 37, 6, 5, 300, "A4zxRd33vU29", "RAM:14Memory:498GB Man hinh :12inch" },
                    { 30, "/images/device (99).png", 6, 30000000m, 14000000m, "Mô tả mẫu của sản phẩm30", 29, 2, 7, 100, "OtqmBKROle30", "RAM:21Memory:426GB Man hinh :12inch" },
                    { 31, "/images/device (121).png", 2, 10000000m, 10000000m, "Mô tả mẫu của sản phẩm31", 34, 7, 7, 200, "yxLlFTry8G31", "RAM:25Memory:218GB Man hinh :12inch" },
                    { 32, "/images/device (160).png", 4, 29000000m, 37000000m, "Mô tả mẫu của sản phẩm32", 29, 5, 2, 300, "5NVXp3ojco32", "RAM:28Memory:409GB Man hinh :16inch" },
                    { 33, "/images/device (202).png", 7, 25000000m, 21000000m, "Mô tả mẫu của sản phẩm33", 36, 1, 4, 300, "DzbY8dRdKe33", "RAM:27Memory:422GB Man hinh :8inch" },
                    { 34, "/images/device (191).png", 7, 5000000m, 36000000m, "Mô tả mẫu của sản phẩm34", 7, 7, 2, 400, "38LS9F2OxB34", "RAM:26Memory:319GB Man hinh :16inch" },
                    { 35, "/images/device (46).png", 1, 24000000m, 15000000m, "Mô tả mẫu của sản phẩm35", 9, 4, 1, 400, "3VMN1bx1se35", "RAM:23Memory:257GB Man hinh :8inch" },
                    { 36, "/images/device (261).png", 2, 2000000m, 18000000m, "Mô tả mẫu của sản phẩm36", 29, 8, 6, 400, "RQngZpXRdl36", "RAM:3Memory:382GB Man hinh :8inch" },
                    { 37, "/images/device (54).png", 3, 32000000m, 23000000m, "Mô tả mẫu của sản phẩm37", 23, 2, 5, 400, "jCHV1a5X6G37", "RAM:20Memory:115GB Man hinh :4inch" },
                    { 38, "/images/device (212).png", 3, 21000000m, 1000000m, "Mô tả mẫu của sản phẩm38", 19, 3, 5, 400, "oHNq3P4O8C38", "RAM:9Memory:188GB Man hinh :12inch" },
                    { 39, "/images/device (265).png", 8, 7000000m, 28000000m, "Mô tả mẫu của sản phẩm39", 22, 2, 7, 100, "YyvwufEUO739", "RAM:13Memory:438GB Man hinh :8inch" },
                    { 40, "/images/device (45).png", 7, 24000000m, 3000000m, "Mô tả mẫu của sản phẩm40", 25, 6, 7, 200, "esoZMygDMe40", "RAM:10Memory:479GB Man hinh :4inch" },
                    { 41, "/images/device (250).png", 1, 42000000m, 25000000m, "Mô tả mẫu của sản phẩm41", 16, 2, 3, 200, "IGUTrq8FPL41", "RAM:11Memory:158GB Man hinh :16inch" },
                    { 42, "/images/device (37).png", 3, 39000000m, 42000000m, "Mô tả mẫu của sản phẩm42", 33, 1, 1, 400, "AxW3CNV6cj42", "RAM:7Memory:104GB Man hinh :12inch" },
                    { 43, "/images/device (169).png", 4, 3000000m, 42000000m, "Mô tả mẫu của sản phẩm43", 27, 7, 7, 300, "CiH1OOKbb243", "RAM:10Memory:264GB Man hinh :12inch" },
                    { 44, "/images/device (239).png", 3, 26000000m, 22000000m, "Mô tả mẫu của sản phẩm44", 9, 5, 5, 200, "RDFkTQm5gv44", "RAM:2Memory:126GB Man hinh :12inch" },
                    { 45, "/images/device (63).png", 2, 12000000m, 36000000m, "Mô tả mẫu của sản phẩm45", 17, 7, 8, 200, "LO7A18ye6M45", "RAM:15Memory:72GB Man hinh :12inch" },
                    { 46, "/images/device (43).png", 7, 14000000m, 44000000m, "Mô tả mẫu của sản phẩm46", 10, 2, 2, 100, "JmPcS8uTDX46", "RAM:4Memory:231GB Man hinh :8inch" },
                    { 47, "/images/device (106).png", 1, 48000000m, 4000000m, "Mô tả mẫu của sản phẩm47", 5, 7, 3, 100, "xug24n05h347", "RAM:9Memory:182GB Man hinh :4inch" },
                    { 48, "/images/device (14).png", 2, 7000000m, 39000000m, "Mô tả mẫu của sản phẩm48", 15, 2, 1, 300, "7UYj3nsMOR48", "RAM:5Memory:439GB Man hinh :12inch" },
                    { 49, "/images/device (174).png", 5, 14000000m, 17000000m, "Mô tả mẫu của sản phẩm49", 22, 4, 2, 200, "kRcH8e28AE49", "RAM:15Memory:472GB Man hinh :16inch" },
                    { 50, "/images/device (83).png", 6, 19000000m, 12000000m, "Mô tả mẫu của sản phẩm50", 39, 1, 1, 200, "SMWzSDOQhr50", "RAM:27Memory:189GB Man hinh :12inch" },
                    { 51, "/images/device (93).png", 3, 7000000m, 2000000m, "Mô tả mẫu của sản phẩm51", 10, 8, 3, 300, "sAww6FKfqY51", "RAM:26Memory:294GB Man hinh :12inch" },
                    { 52, "/images/device (147).png", 2, 5000000m, 9000000m, "Mô tả mẫu của sản phẩm52", 33, 8, 6, 200, "bS6OVn0Irk52", "RAM:24Memory:166GB Man hinh :8inch" },
                    { 53, "/images/device (48).png", 7, 6000000m, 43000000m, "Mô tả mẫu của sản phẩm53", 14, 3, 2, 200, "Ap594RMxxx53", "RAM:28Memory:290GB Man hinh :8inch" },
                    { 54, "/images/device (55).png", 3, 17000000m, 31000000m, "Mô tả mẫu của sản phẩm54", 31, 1, 2, 100, "0chNus5k2l54", "RAM:1Memory:120GB Man hinh :16inch" },
                    { 55, "/images/device (125).png", 8, 15000000m, 39000000m, "Mô tả mẫu của sản phẩm55", 6, 2, 3, 200, "gfsV10P0Pf55", "RAM:25Memory:479GB Man hinh :4inch" },
                    { 56, "/images/device (104).png", 2, 17000000m, 39000000m, "Mô tả mẫu của sản phẩm56", 15, 8, 2, 100, "0Po7EDglHb56", "RAM:7Memory:415GB Man hinh :8inch" },
                    { 57, "/images/device (83).png", 4, 25000000m, 20000000m, "Mô tả mẫu của sản phẩm57", 7, 2, 6, 400, "qni5z8gKUn57", "RAM:16Memory:35GB Man hinh :8inch" },
                    { 58, "/images/device (164).png", 5, 1000000m, 30000000m, "Mô tả mẫu của sản phẩm58", 11, 1, 3, 400, "60ykZRBVyj58", "RAM:26Memory:60GB Man hinh :12inch" },
                    { 59, "/images/device (106).png", 6, 4000000m, 27000000m, "Mô tả mẫu của sản phẩm59", 17, 3, 6, 300, "VUhfzxCrjl59", "RAM:30Memory:361GB Man hinh :4inch" },
                    { 60, "/images/device (101).png", 1, 40000000m, 20000000m, "Mô tả mẫu của sản phẩm60", 39, 6, 7, 100, "wQa1F3LZeV60", "RAM:1Memory:484GB Man hinh :8inch" },
                    { 61, "/images/device (111).png", 6, 32000000m, 28000000m, "Mô tả mẫu của sản phẩm61", 7, 4, 4, 100, "ieKPqPZno161", "RAM:7Memory:326GB Man hinh :12inch" },
                    { 62, "/images/device (142).png", 5, 7000000m, 20000000m, "Mô tả mẫu của sản phẩm62", 26, 5, 5, 100, "bJZjO3zXZJ62", "RAM:14Memory:402GB Man hinh :4inch" },
                    { 63, "/images/device (263).png", 8, 36000000m, 43000000m, "Mô tả mẫu của sản phẩm63", 36, 2, 7, 300, "Dfrs9VNkhL63", "RAM:25Memory:352GB Man hinh :8inch" },
                    { 64, "/images/device (46).png", 4, 27000000m, 35000000m, "Mô tả mẫu của sản phẩm64", 29, 2, 5, 300, "Cxci6PVj2M64", "RAM:15Memory:318GB Man hinh :16inch" },
                    { 65, "/images/device (57).png", 2, 43000000m, 25000000m, "Mô tả mẫu của sản phẩm65", 6, 4, 6, 300, "3ci99PDHRg65", "RAM:12Memory:121GB Man hinh :8inch" },
                    { 66, "/images/device (271).png", 1, 10000000m, 25000000m, "Mô tả mẫu của sản phẩm66", 39, 6, 2, 100, "rJ3opoAVm166", "RAM:30Memory:480GB Man hinh :4inch" },
                    { 67, "/images/device (25).png", 2, 3000000m, 43000000m, "Mô tả mẫu của sản phẩm67", 15, 5, 2, 200, "vMYTDOufcU67", "RAM:26Memory:46GB Man hinh :8inch" },
                    { 68, "/images/device (176).png", 6, 37000000m, 47000000m, "Mô tả mẫu của sản phẩm68", 24, 8, 4, 100, "deUZHoKBbb68", "RAM:23Memory:134GB Man hinh :8inch" },
                    { 69, "/images/device (118).png", 6, 40000000m, 9000000m, "Mô tả mẫu của sản phẩm69", 23, 1, 4, 100, "zJmm53zPxB69", "RAM:27Memory:361GB Man hinh :4inch" },
                    { 70, "/images/device (85).png", 2, 38000000m, 2000000m, "Mô tả mẫu của sản phẩm70", 11, 7, 3, 100, "BHHB2yFHW170", "RAM:19Memory:394GB Man hinh :12inch" },
                    { 71, "/images/device (33).png", 1, 16000000m, 16000000m, "Mô tả mẫu của sản phẩm71", 12, 7, 4, 200, "tl02FFQJk071", "RAM:18Memory:222GB Man hinh :4inch" },
                    { 72, "/images/device (40).png", 7, 33000000m, 24000000m, "Mô tả mẫu của sản phẩm72", 20, 2, 7, 400, "v74hNEUlMe72", "RAM:16Memory:293GB Man hinh :16inch" },
                    { 73, "/images/device (273).png", 1, 36000000m, 45000000m, "Mô tả mẫu của sản phẩm73", 33, 4, 8, 300, "Ffw2TjbyhB73", "RAM:15Memory:465GB Man hinh :16inch" },
                    { 74, "/images/device (124).png", 1, 12000000m, 35000000m, "Mô tả mẫu của sản phẩm74", 29, 5, 2, 200, "M0G98tBAoB74", "RAM:28Memory:439GB Man hinh :8inch" },
                    { 75, "/images/device (56).png", 2, 23000000m, 36000000m, "Mô tả mẫu của sản phẩm75", 20, 1, 7, 300, "KO7yYdWgUe75", "RAM:25Memory:179GB Man hinh :12inch" },
                    { 76, "/images/device (142).png", 6, 34000000m, 8000000m, "Mô tả mẫu của sản phẩm76", 27, 2, 3, 300, "qsa98JtbHz76", "RAM:1Memory:367GB Man hinh :16inch" },
                    { 77, "/images/device (209).png", 6, 40000000m, 44000000m, "Mô tả mẫu của sản phẩm77", 33, 4, 2, 100, "VdITsTjj6A77", "RAM:27Memory:457GB Man hinh :4inch" },
                    { 78, "/images/device (14).png", 3, 28000000m, 46000000m, "Mô tả mẫu của sản phẩm78", 11, 5, 2, 100, "Z6AJgwmemN78", "RAM:13Memory:82GB Man hinh :16inch" },
                    { 79, "/images/device (71).png", 2, 39000000m, 15000000m, "Mô tả mẫu của sản phẩm79", 36, 1, 2, 200, "ZMxwwTMV5X79", "RAM:1Memory:451GB Man hinh :4inch" },
                    { 80, "/images/device (120).png", 6, 8000000m, 16000000m, "Mô tả mẫu của sản phẩm80", 38, 6, 5, 400, "cDIb5CuAOa80", "RAM:25Memory:136GB Man hinh :12inch" },
                    { 81, "/images/device (170).png", 2, 42000000m, 17000000m, "Mô tả mẫu của sản phẩm81", 23, 6, 4, 100, "ISaSlyeDDo81", "RAM:25Memory:87GB Man hinh :4inch" },
                    { 82, "/images/device (185).png", 2, 32000000m, 15000000m, "Mô tả mẫu của sản phẩm82", 10, 2, 4, 100, "6mjyWyI5Jl82", "RAM:22Memory:77GB Man hinh :12inch" },
                    { 83, "/images/device (85).png", 5, 19000000m, 3000000m, "Mô tả mẫu của sản phẩm83", 17, 1, 3, 300, "4f0hcoGxda83", "RAM:26Memory:130GB Man hinh :4inch" },
                    { 84, "/images/device (70).png", 5, 19000000m, 10000000m, "Mô tả mẫu của sản phẩm84", 31, 6, 4, 400, "J3OyRMefv984", "RAM:24Memory:312GB Man hinh :4inch" },
                    { 85, "/images/device (93).png", 3, 17000000m, 42000000m, "Mô tả mẫu của sản phẩm85", 16, 2, 3, 100, "KN2CzciuLt85", "RAM:23Memory:181GB Man hinh :12inch" },
                    { 86, "/images/device (51).png", 7, 38000000m, 34000000m, "Mô tả mẫu của sản phẩm86", 39, 2, 4, 200, "vIULt1Sx6J86", "RAM:14Memory:186GB Man hinh :12inch" },
                    { 87, "/images/device (201).png", 8, 1000000m, 7000000m, "Mô tả mẫu của sản phẩm87", 24, 8, 2, 300, "aEdBw9zlsY87", "RAM:1Memory:412GB Man hinh :4inch" },
                    { 88, "/images/device (239).png", 5, 13000000m, 10000000m, "Mô tả mẫu của sản phẩm88", 12, 7, 8, 400, "XxSKkrROMr88", "RAM:19Memory:39GB Man hinh :4inch" },
                    { 89, "/images/device (264).png", 8, 33000000m, 37000000m, "Mô tả mẫu của sản phẩm89", 6, 6, 1, 300, "k8zYZH6oG989", "RAM:19Memory:468GB Man hinh :16inch" },
                    { 90, "/images/device (17).png", 7, 14000000m, 26000000m, "Mô tả mẫu của sản phẩm90", 37, 2, 7, 300, "QaP3FDRDEp90", "RAM:27Memory:38GB Man hinh :16inch" },
                    { 91, "/images/device (70).png", 4, 2000000m, 31000000m, "Mô tả mẫu của sản phẩm91", 29, 6, 4, 100, "Ym7zrWRh5d91", "RAM:26Memory:160GB Man hinh :8inch" },
                    { 92, "/images/device (210).png", 7, 27000000m, 16000000m, "Mô tả mẫu của sản phẩm92", 24, 5, 1, 100, "6pLSRbmy7692", "RAM:11Memory:232GB Man hinh :16inch" },
                    { 93, "/images/device (240).png", 1, 29000000m, 27000000m, "Mô tả mẫu của sản phẩm93", 13, 2, 1, 100, "n10qnUGjrZ93", "RAM:16Memory:378GB Man hinh :8inch" },
                    { 94, "/images/device (266).png", 4, 38000000m, 46000000m, "Mô tả mẫu của sản phẩm94", 5, 3, 3, 400, "E6d3OOMgIo94", "RAM:3Memory:190GB Man hinh :8inch" },
                    { 95, "/images/device (132).png", 2, 26000000m, 1000000m, "Mô tả mẫu của sản phẩm95", 13, 6, 7, 300, "VYeo0LgVSo95", "RAM:16Memory:53GB Man hinh :8inch" },
                    { 96, "/images/device (265).png", 8, 18000000m, 33000000m, "Mô tả mẫu của sản phẩm96", 20, 2, 5, 400, "uNkzmQ2Vyb96", "RAM:11Memory:363GB Man hinh :4inch" },
                    { 97, "/images/device (193).png", 5, 24000000m, 24000000m, "Mô tả mẫu của sản phẩm97", 38, 5, 2, 400, "YwcYX2i0ia97", "RAM:15Memory:403GB Man hinh :8inch" },
                    { 98, "/images/device (110).png", 2, 24000000m, 44000000m, "Mô tả mẫu của sản phẩm98", 20, 8, 7, 300, "T3ZN5OxckT98", "RAM:11Memory:112GB Man hinh :4inch" },
                    { 99, "/images/device (54).png", 5, 17000000m, 23000000m, "Mô tả mẫu của sản phẩm99", 11, 3, 1, 200, "w4JnzIUCAA99", "RAM:23Memory:129GB Man hinh :12inch" },
                    { 100, "/images/device (94).png", 5, 5000000m, 6000000m, "Mô tả mẫu của sản phẩm100", 39, 4, 6, 100, "ptmAZnQh5G100", "RAM:25Memory:74GB Man hinh :12inch" },
                    { 101, "/images/device (130).png", 1, 18000000m, 3000000m, "Mô tả mẫu của sản phẩm101", 15, 1, 3, 300, "poiQihci5i101", "RAM:12Memory:127GB Man hinh :16inch" },
                    { 102, "/images/device (265).png", 7, 16000000m, 37000000m, "Mô tả mẫu của sản phẩm102", 19, 5, 6, 300, "iqgGuTQoqD102", "RAM:27Memory:498GB Man hinh :8inch" },
                    { 103, "/images/device (135).png", 3, 12000000m, 22000000m, "Mô tả mẫu của sản phẩm103", 33, 3, 2, 400, "46sSefKTAY103", "RAM:19Memory:163GB Man hinh :16inch" },
                    { 104, "/images/device (243).png", 6, 1000000m, 4000000m, "Mô tả mẫu của sản phẩm104", 26, 5, 3, 200, "HhHFm3JKHh104", "RAM:28Memory:419GB Man hinh :4inch" },
                    { 105, "/images/device (148).png", 8, 42000000m, 47000000m, "Mô tả mẫu của sản phẩm105", 31, 3, 3, 400, "JqEETCmUhx105", "RAM:15Memory:65GB Man hinh :12inch" },
                    { 106, "/images/device (173).png", 3, 15000000m, 48000000m, "Mô tả mẫu của sản phẩm106", 32, 1, 8, 400, "FKk5oIEQH4106", "RAM:27Memory:395GB Man hinh :12inch" },
                    { 107, "/images/device (194).png", 4, 15000000m, 24000000m, "Mô tả mẫu của sản phẩm107", 18, 7, 4, 300, "YgcXUcE5hm107", "RAM:3Memory:153GB Man hinh :8inch" },
                    { 108, "/images/device (182).png", 6, 30000000m, 11000000m, "Mô tả mẫu của sản phẩm108", 5, 1, 1, 100, "KEdKvLqRoG108", "RAM:25Memory:88GB Man hinh :4inch" },
                    { 109, "/images/device (97).png", 6, 12000000m, 49000000m, "Mô tả mẫu của sản phẩm109", 20, 3, 4, 100, "2Gme0AXkq3109", "RAM:21Memory:365GB Man hinh :4inch" },
                    { 110, "/images/device (221).png", 2, 32000000m, 25000000m, "Mô tả mẫu của sản phẩm110", 12, 2, 2, 100, "qFvdbGIO8P110", "RAM:5Memory:509GB Man hinh :12inch" },
                    { 111, "/images/device (101).png", 3, 9000000m, 11000000m, "Mô tả mẫu của sản phẩm111", 28, 5, 3, 300, "RdvKoMwqTG111", "RAM:22Memory:150GB Man hinh :12inch" },
                    { 112, "/images/device (35).png", 2, 6000000m, 49000000m, "Mô tả mẫu của sản phẩm112", 39, 6, 2, 300, "h74FEGwVPa112", "RAM:18Memory:194GB Man hinh :16inch" },
                    { 113, "/images/device (17).png", 1, 36000000m, 34000000m, "Mô tả mẫu của sản phẩm113", 32, 3, 4, 400, "iZppgycIwU113", "RAM:16Memory:312GB Man hinh :4inch" },
                    { 114, "/images/device (82).png", 1, 15000000m, 32000000m, "Mô tả mẫu của sản phẩm114", 21, 1, 8, 100, "QiiCxFqTxF114", "RAM:18Memory:238GB Man hinh :8inch" },
                    { 115, "/images/device (207).png", 4, 31000000m, 2000000m, "Mô tả mẫu của sản phẩm115", 23, 6, 2, 100, "bwPpGstICE115", "RAM:12Memory:395GB Man hinh :8inch" },
                    { 116, "/images/device (132).png", 6, 1000000m, 20000000m, "Mô tả mẫu của sản phẩm116", 20, 1, 3, 100, "cScjCGeUSW116", "RAM:2Memory:193GB Man hinh :12inch" },
                    { 117, "/images/device (197).png", 6, 14000000m, 49000000m, "Mô tả mẫu của sản phẩm117", 15, 8, 6, 100, "B8fEh3kPOH117", "RAM:27Memory:313GB Man hinh :16inch" },
                    { 118, "/images/device (267).png", 2, 32000000m, 11000000m, "Mô tả mẫu của sản phẩm118", 25, 6, 7, 400, "z7uuNktqLE118", "RAM:6Memory:217GB Man hinh :12inch" },
                    { 119, "/images/device (71).png", 8, 47000000m, 48000000m, "Mô tả mẫu của sản phẩm119", 7, 3, 3, 400, "430mfznLNj119", "RAM:31Memory:199GB Man hinh :8inch" },
                    { 120, "/images/device (17).png", 5, 31000000m, 47000000m, "Mô tả mẫu của sản phẩm120", 21, 2, 6, 400, "CyB0fZAOHC120", "RAM:11Memory:96GB Man hinh :16inch" },
                    { 121, "/images/device (246).png", 7, 9000000m, 26000000m, "Mô tả mẫu của sản phẩm121", 14, 7, 2, 200, "e27WzwUCu6121", "RAM:4Memory:468GB Man hinh :4inch" },
                    { 122, "/images/device (81).png", 7, 1000000m, 34000000m, "Mô tả mẫu của sản phẩm122", 16, 1, 5, 400, "EqEemD75QT122", "RAM:1Memory:212GB Man hinh :16inch" },
                    { 123, "/images/device (201).png", 2, 45000000m, 45000000m, "Mô tả mẫu của sản phẩm123", 13, 2, 1, 200, "nwUGOMTIZj123", "RAM:2Memory:299GB Man hinh :4inch" },
                    { 124, "/images/device (214).png", 2, 43000000m, 9000000m, "Mô tả mẫu của sản phẩm124", 27, 8, 1, 300, "gd8JwHbhgl124", "RAM:14Memory:411GB Man hinh :12inch" },
                    { 125, "/images/device (23).png", 1, 32000000m, 8000000m, "Mô tả mẫu của sản phẩm125", 12, 3, 7, 100, "X6j5FQtqWY125", "RAM:7Memory:430GB Man hinh :16inch" },
                    { 126, "/images/device (232).png", 5, 12000000m, 8000000m, "Mô tả mẫu của sản phẩm126", 38, 6, 2, 100, "zHZ12Bvn83126", "RAM:12Memory:315GB Man hinh :16inch" },
                    { 127, "/images/device (69).png", 5, 18000000m, 46000000m, "Mô tả mẫu của sản phẩm127", 29, 2, 8, 100, "PUtBcjc03c127", "RAM:28Memory:176GB Man hinh :16inch" },
                    { 128, "/images/device (127).png", 1, 5000000m, 10000000m, "Mô tả mẫu của sản phẩm128", 12, 4, 7, 200, "8zdFTPAvDo128", "RAM:26Memory:118GB Man hinh :16inch" },
                    { 129, "/images/device (220).png", 7, 11000000m, 30000000m, "Mô tả mẫu của sản phẩm129", 12, 3, 2, 400, "To6OVDuv22129", "RAM:15Memory:172GB Man hinh :8inch" },
                    { 130, "/images/device (237).png", 8, 2000000m, 47000000m, "Mô tả mẫu của sản phẩm130", 16, 3, 7, 200, "v9TmIWOS4z130", "RAM:30Memory:410GB Man hinh :12inch" },
                    { 131, "/images/device (53).png", 4, 19000000m, 27000000m, "Mô tả mẫu của sản phẩm131", 11, 1, 7, 100, "oShVpondpq131", "RAM:27Memory:161GB Man hinh :8inch" },
                    { 132, "/images/device (54).png", 4, 9000000m, 3000000m, "Mô tả mẫu của sản phẩm132", 32, 4, 2, 400, "Udkcpbklis132", "RAM:23Memory:222GB Man hinh :8inch" },
                    { 133, "/images/device (164).png", 2, 25000000m, 30000000m, "Mô tả mẫu của sản phẩm133", 20, 8, 6, 300, "YZ7R5HdWaI133", "RAM:19Memory:150GB Man hinh :4inch" },
                    { 134, "/images/device (195).png", 8, 42000000m, 48000000m, "Mô tả mẫu của sản phẩm134", 20, 7, 5, 300, "FX0yoG2S4A134", "RAM:23Memory:449GB Man hinh :8inch" },
                    { 135, "/images/device (203).png", 7, 47000000m, 38000000m, "Mô tả mẫu của sản phẩm135", 29, 8, 8, 100, "E9imZztJ9A135", "RAM:17Memory:273GB Man hinh :8inch" },
                    { 136, "/images/device (200).png", 2, 7000000m, 49000000m, "Mô tả mẫu của sản phẩm136", 30, 2, 4, 300, "OhXm857FNw136", "RAM:28Memory:261GB Man hinh :16inch" },
                    { 137, "/images/device (68).png", 4, 16000000m, 3000000m, "Mô tả mẫu của sản phẩm137", 29, 7, 5, 400, "HLo67fwWLD137", "RAM:22Memory:453GB Man hinh :4inch" },
                    { 138, "/images/device (228).png", 8, 23000000m, 40000000m, "Mô tả mẫu của sản phẩm138", 33, 4, 5, 300, "BDeMsq5j6n138", "RAM:8Memory:273GB Man hinh :4inch" },
                    { 139, "/images/device (32).png", 6, 2000000m, 3000000m, "Mô tả mẫu của sản phẩm139", 36, 1, 2, 300, "yghqhLiL8l139", "RAM:10Memory:499GB Man hinh :16inch" },
                    { 140, "/images/device (185).png", 6, 23000000m, 27000000m, "Mô tả mẫu của sản phẩm140", 19, 3, 7, 100, "T0IRGMusKm140", "RAM:26Memory:404GB Man hinh :12inch" },
                    { 141, "/images/device (56).png", 2, 1000000m, 42000000m, "Mô tả mẫu của sản phẩm141", 37, 7, 2, 300, "E1gQk7SAYI141", "RAM:25Memory:406GB Man hinh :16inch" },
                    { 142, "/images/device (181).png", 7, 7000000m, 27000000m, "Mô tả mẫu của sản phẩm142", 9, 2, 5, 400, "nQzSxfLazA142", "RAM:22Memory:73GB Man hinh :8inch" },
                    { 143, "/images/device (184).png", 1, 27000000m, 11000000m, "Mô tả mẫu của sản phẩm143", 9, 1, 8, 200, "KKGsmPkQJy143", "RAM:17Memory:322GB Man hinh :16inch" },
                    { 144, "/images/device (64).png", 7, 3000000m, 48000000m, "Mô tả mẫu của sản phẩm144", 37, 8, 8, 100, "w61pZOQAps144", "RAM:9Memory:203GB Man hinh :4inch" },
                    { 145, "/images/device (173).png", 3, 12000000m, 16000000m, "Mô tả mẫu của sản phẩm145", 11, 8, 3, 400, "1KZPcIaXdj145", "RAM:28Memory:217GB Man hinh :12inch" },
                    { 146, "/images/device (217).png", 4, 8000000m, 18000000m, "Mô tả mẫu của sản phẩm146", 16, 3, 2, 400, "Skt52mGZiT146", "RAM:31Memory:376GB Man hinh :8inch" },
                    { 147, "/images/device (255).png", 6, 36000000m, 40000000m, "Mô tả mẫu của sản phẩm147", 14, 2, 7, 100, "OlzTNdt2P0147", "RAM:2Memory:208GB Man hinh :4inch" },
                    { 148, "/images/device (111).png", 1, 26000000m, 30000000m, "Mô tả mẫu của sản phẩm148", 10, 6, 2, 400, "pKVA2k6rdb148", "RAM:14Memory:448GB Man hinh :4inch" },
                    { 149, "/images/device (239).png", 1, 49000000m, 27000000m, "Mô tả mẫu của sản phẩm149", 27, 2, 3, 200, "bygaeI8d4h149", "RAM:6Memory:425GB Man hinh :16inch" },
                    { 150, "/images/device (180).png", 6, 28000000m, 9000000m, "Mô tả mẫu của sản phẩm150", 34, 3, 7, 400, "GT2tvTYzfo150", "RAM:16Memory:419GB Man hinh :12inch" },
                    { 151, "/images/device (161).png", 6, 18000000m, 42000000m, "Mô tả mẫu của sản phẩm151", 19, 2, 8, 400, "GDLz1LzZFF151", "RAM:16Memory:186GB Man hinh :16inch" },
                    { 152, "/images/device (16).png", 4, 49000000m, 37000000m, "Mô tả mẫu của sản phẩm152", 33, 3, 7, 200, "GchpNpttZL152", "RAM:27Memory:59GB Man hinh :16inch" },
                    { 153, "/images/device (123).png", 6, 29000000m, 18000000m, "Mô tả mẫu của sản phẩm153", 25, 2, 3, 100, "DaQEXRokHr153", "RAM:16Memory:382GB Man hinh :8inch" },
                    { 154, "/images/device (145).png", 1, 37000000m, 19000000m, "Mô tả mẫu của sản phẩm154", 20, 1, 1, 100, "8dYeg4y9j6154", "RAM:8Memory:155GB Man hinh :16inch" },
                    { 155, "/images/device (68).png", 4, 1000000m, 40000000m, "Mô tả mẫu của sản phẩm155", 11, 4, 1, 400, "FeHllvPwn7155", "RAM:4Memory:133GB Man hinh :12inch" },
                    { 156, "/images/device (24).png", 1, 1000000m, 41000000m, "Mô tả mẫu của sản phẩm156", 39, 6, 2, 100, "SqoE01IOzT156", "RAM:27Memory:345GB Man hinh :12inch" },
                    { 157, "/images/device (63).png", 2, 13000000m, 43000000m, "Mô tả mẫu của sản phẩm157", 33, 8, 6, 300, "pL6R0NosOY157", "RAM:27Memory:464GB Man hinh :4inch" },
                    { 158, "/images/device (10).png", 7, 24000000m, 5000000m, "Mô tả mẫu của sản phẩm158", 27, 1, 5, 100, "CTnVBALNtn158", "RAM:24Memory:271GB Man hinh :8inch" },
                    { 159, "/images/device (207).png", 6, 27000000m, 48000000m, "Mô tả mẫu của sản phẩm159", 13, 2, 2, 400, "rpVdqpYdl9159", "RAM:2Memory:33GB Man hinh :4inch" },
                    { 160, "/images/device (217).png", 1, 17000000m, 10000000m, "Mô tả mẫu của sản phẩm160", 15, 2, 1, 400, "QptehliLBX160", "RAM:10Memory:310GB Man hinh :4inch" },
                    { 161, "/images/device (183).png", 5, 14000000m, 31000000m, "Mô tả mẫu của sản phẩm161", 15, 3, 3, 200, "E1DJyP6L9q161", "RAM:13Memory:444GB Man hinh :4inch" },
                    { 162, "/images/device (21).png", 7, 24000000m, 31000000m, "Mô tả mẫu của sản phẩm162", 21, 7, 1, 400, "lGcnYJNTWK162", "RAM:8Memory:132GB Man hinh :4inch" },
                    { 163, "/images/device (251).png", 1, 38000000m, 40000000m, "Mô tả mẫu của sản phẩm163", 11, 7, 4, 300, "ww9D4kKDtG163", "RAM:2Memory:349GB Man hinh :16inch" },
                    { 164, "/images/device (59).png", 3, 33000000m, 38000000m, "Mô tả mẫu của sản phẩm164", 9, 4, 5, 300, "sdotJgO5vH164", "RAM:11Memory:100GB Man hinh :4inch" },
                    { 165, "/images/device (40).png", 2, 28000000m, 37000000m, "Mô tả mẫu của sản phẩm165", 28, 4, 7, 100, "hl1SewOBs6165", "RAM:12Memory:461GB Man hinh :12inch" },
                    { 166, "/images/device (54).png", 1, 48000000m, 8000000m, "Mô tả mẫu của sản phẩm166", 25, 7, 7, 400, "xSRzhRUerr166", "RAM:21Memory:498GB Man hinh :16inch" },
                    { 167, "/images/device (200).png", 7, 6000000m, 13000000m, "Mô tả mẫu của sản phẩm167", 25, 2, 7, 100, "XAMmd3DmiP167", "RAM:6Memory:485GB Man hinh :16inch" },
                    { 168, "/images/device (6).png", 4, 30000000m, 18000000m, "Mô tả mẫu của sản phẩm168", 7, 6, 2, 200, "KpiT1rpg25168", "RAM:9Memory:217GB Man hinh :8inch" },
                    { 169, "/images/device (203).png", 2, 19000000m, 42000000m, "Mô tả mẫu của sản phẩm169", 34, 3, 3, 300, "vPo15kKJo6169", "RAM:25Memory:409GB Man hinh :12inch" },
                    { 170, "/images/device (117).png", 8, 26000000m, 14000000m, "Mô tả mẫu của sản phẩm170", 32, 6, 4, 300, "BnI0AdRI27170", "RAM:18Memory:293GB Man hinh :8inch" },
                    { 171, "/images/device (183).png", 5, 37000000m, 37000000m, "Mô tả mẫu của sản phẩm171", 10, 2, 2, 100, "2LzPgYYE69171", "RAM:15Memory:303GB Man hinh :8inch" },
                    { 172, "/images/device (179).png", 2, 25000000m, 21000000m, "Mô tả mẫu của sản phẩm172", 10, 7, 4, 400, "5J4DVyPUlT172", "RAM:26Memory:442GB Man hinh :12inch" },
                    { 173, "/images/device (269).png", 5, 7000000m, 29000000m, "Mô tả mẫu của sản phẩm173", 9, 2, 6, 300, "GIBiljKqi8173", "RAM:31Memory:66GB Man hinh :12inch" },
                    { 174, "/images/device (132).png", 3, 5000000m, 13000000m, "Mô tả mẫu của sản phẩm174", 12, 1, 4, 100, "9FLj8iUcqK174", "RAM:8Memory:280GB Man hinh :12inch" },
                    { 175, "/images/device (232).png", 8, 24000000m, 41000000m, "Mô tả mẫu của sản phẩm175", 29, 8, 7, 200, "hzqNfJpdRX175", "RAM:16Memory:262GB Man hinh :16inch" },
                    { 176, "/images/device (120).png", 3, 10000000m, 13000000m, "Mô tả mẫu của sản phẩm176", 34, 7, 5, 100, "ukav6D0a7J176", "RAM:13Memory:86GB Man hinh :4inch" },
                    { 177, "/images/device (162).png", 2, 19000000m, 25000000m, "Mô tả mẫu của sản phẩm177", 25, 7, 2, 300, "IFuKZQOm97177", "RAM:13Memory:70GB Man hinh :4inch" },
                    { 178, "/images/device (100).png", 2, 25000000m, 45000000m, "Mô tả mẫu của sản phẩm178", 16, 5, 5, 100, "XXgKkv7oyu178", "RAM:3Memory:499GB Man hinh :4inch" },
                    { 179, "/images/device (116).png", 1, 49000000m, 32000000m, "Mô tả mẫu của sản phẩm179", 18, 8, 2, 300, "NxKirx0Ees179", "RAM:28Memory:45GB Man hinh :16inch" },
                    { 180, "/images/device (270).png", 2, 30000000m, 37000000m, "Mô tả mẫu của sản phẩm180", 5, 4, 4, 400, "xujY2ex9YA180", "RAM:25Memory:242GB Man hinh :4inch" },
                    { 181, "/images/device (85).png", 7, 9000000m, 30000000m, "Mô tả mẫu của sản phẩm181", 38, 4, 4, 100, "143Mhem8bC181", "RAM:14Memory:196GB Man hinh :4inch" },
                    { 182, "/images/device (196).png", 7, 12000000m, 3000000m, "Mô tả mẫu của sản phẩm182", 13, 5, 6, 200, "rCsY9WSmN7182", "RAM:24Memory:213GB Man hinh :4inch" },
                    { 183, "/images/device (109).png", 1, 5000000m, 30000000m, "Mô tả mẫu của sản phẩm183", 30, 7, 5, 200, "RoJDaEPchU183", "RAM:15Memory:343GB Man hinh :12inch" },
                    { 184, "/images/device (106).png", 4, 34000000m, 28000000m, "Mô tả mẫu của sản phẩm184", 12, 6, 6, 200, "zGwWstl1QF184", "RAM:30Memory:181GB Man hinh :16inch" },
                    { 185, "/images/device (74).png", 2, 45000000m, 44000000m, "Mô tả mẫu của sản phẩm185", 24, 7, 8, 100, "pp1SmaIoir185", "RAM:31Memory:406GB Man hinh :8inch" },
                    { 186, "/images/device (176).png", 3, 30000000m, 38000000m, "Mô tả mẫu của sản phẩm186", 19, 8, 2, 400, "zhtGwE7DIw186", "RAM:28Memory:207GB Man hinh :16inch" },
                    { 187, "/images/device (97).png", 3, 31000000m, 20000000m, "Mô tả mẫu của sản phẩm187", 17, 6, 6, 200, "L1Y1MeLjxc187", "RAM:16Memory:382GB Man hinh :8inch" },
                    { 188, "/images/device (112).png", 1, 25000000m, 36000000m, "Mô tả mẫu của sản phẩm188", 33, 3, 3, 100, "xnkL03t8Gb188", "RAM:21Memory:466GB Man hinh :16inch" },
                    { 189, "/images/device (35).png", 5, 20000000m, 28000000m, "Mô tả mẫu của sản phẩm189", 25, 7, 2, 100, "zE4SX3BK6W189", "RAM:19Memory:229GB Man hinh :4inch" },
                    { 190, "/images/device (10).png", 1, 45000000m, 18000000m, "Mô tả mẫu của sản phẩm190", 24, 7, 7, 200, "WzMNkNQrP1190", "RAM:13Memory:482GB Man hinh :4inch" },
                    { 191, "/images/device (135).png", 1, 4000000m, 31000000m, "Mô tả mẫu của sản phẩm191", 38, 4, 6, 200, "4QIpVTpSFF191", "RAM:26Memory:65GB Man hinh :8inch" },
                    { 192, "/images/device (1).png", 7, 38000000m, 27000000m, "Mô tả mẫu của sản phẩm192", 33, 3, 5, 300, "EOUvbh9anf192", "RAM:10Memory:460GB Man hinh :8inch" },
                    { 193, "/images/device (146).png", 7, 17000000m, 17000000m, "Mô tả mẫu của sản phẩm193", 5, 7, 8, 200, "Mg7zfpbg6j193", "RAM:23Memory:52GB Man hinh :16inch" },
                    { 194, "/images/device (200).png", 6, 46000000m, 34000000m, "Mô tả mẫu của sản phẩm194", 36, 6, 3, 200, "I9Qc2Gzo0R194", "RAM:8Memory:179GB Man hinh :16inch" },
                    { 195, "/images/device (133).png", 6, 20000000m, 42000000m, "Mô tả mẫu của sản phẩm195", 13, 5, 7, 300, "3kLFi2LhUu195", "RAM:29Memory:187GB Man hinh :16inch" },
                    { 196, "/images/device (221).png", 4, 21000000m, 48000000m, "Mô tả mẫu của sản phẩm196", 26, 2, 1, 300, "uKWHCnvEG5196", "RAM:22Memory:309GB Man hinh :8inch" },
                    { 197, "/images/device (83).png", 5, 47000000m, 11000000m, "Mô tả mẫu của sản phẩm197", 27, 5, 3, 300, "HXoX52Yca8197", "RAM:26Memory:427GB Man hinh :12inch" },
                    { 198, "/images/device (126).png", 2, 7000000m, 21000000m, "Mô tả mẫu của sản phẩm198", 7, 2, 3, 300, "cJn2D6uH1F198", "RAM:9Memory:312GB Man hinh :8inch" },
                    { 199, "/images/device (248).png", 3, 42000000m, 38000000m, "Mô tả mẫu của sản phẩm199", 24, 2, 5, 400, "xCxW6O5suL199", "RAM:29Memory:95GB Man hinh :16inch" },
                    { 200, "/images/device (33).png", 1, 25000000m, 31000000m, "Mô tả mẫu của sản phẩm200", 8, 7, 3, 200, "OtFdtMlMPi200", "RAM:26Memory:328GB Man hinh :16inch" },
                    { 201, "/images/device (231).png", 6, 4000000m, 40000000m, "Mô tả mẫu của sản phẩm201", 25, 5, 4, 200, "BnGmSgT1OJ201", "RAM:9Memory:130GB Man hinh :12inch" },
                    { 202, "/images/device (162).png", 5, 38000000m, 26000000m, "Mô tả mẫu của sản phẩm202", 34, 2, 7, 400, "TXFtDNfdXj202", "RAM:31Memory:357GB Man hinh :12inch" },
                    { 203, "/images/device (52).png", 7, 18000000m, 28000000m, "Mô tả mẫu của sản phẩm203", 27, 7, 6, 100, "GLxkZZCY3E203", "RAM:16Memory:134GB Man hinh :4inch" },
                    { 204, "/images/device (223).png", 2, 13000000m, 4000000m, "Mô tả mẫu của sản phẩm204", 7, 5, 2, 300, "ctpvjGp3cB204", "RAM:27Memory:489GB Man hinh :4inch" },
                    { 205, "/images/device (21).png", 1, 24000000m, 9000000m, "Mô tả mẫu của sản phẩm205", 17, 2, 8, 100, "Lf6MyfbQin205", "RAM:11Memory:292GB Man hinh :4inch" },
                    { 206, "/images/device (29).png", 5, 30000000m, 3000000m, "Mô tả mẫu của sản phẩm206", 22, 7, 8, 200, "memr0GYbfi206", "RAM:7Memory:478GB Man hinh :4inch" },
                    { 207, "/images/device (244).png", 4, 29000000m, 8000000m, "Mô tả mẫu của sản phẩm207", 19, 3, 2, 100, "fMNNY5e0Mn207", "RAM:22Memory:305GB Man hinh :8inch" },
                    { 208, "/images/device (131).png", 5, 32000000m, 44000000m, "Mô tả mẫu của sản phẩm208", 32, 4, 4, 400, "579VV8ZkWu208", "RAM:23Memory:279GB Man hinh :8inch" },
                    { 209, "/images/device (127).png", 3, 13000000m, 36000000m, "Mô tả mẫu của sản phẩm209", 11, 3, 8, 300, "hZhixIjkLl209", "RAM:30Memory:437GB Man hinh :16inch" },
                    { 210, "/images/device (75).png", 1, 48000000m, 41000000m, "Mô tả mẫu của sản phẩm210", 9, 6, 8, 400, "wHBvsYvrok210", "RAM:4Memory:195GB Man hinh :16inch" },
                    { 211, "/images/device (195).png", 4, 39000000m, 42000000m, "Mô tả mẫu của sản phẩm211", 10, 7, 8, 300, "St5shybwnr211", "RAM:20Memory:358GB Man hinh :8inch" },
                    { 212, "/images/device (68).png", 5, 45000000m, 23000000m, "Mô tả mẫu của sản phẩm212", 35, 2, 4, 200, "Z3rFZc5pNW212", "RAM:25Memory:279GB Man hinh :8inch" },
                    { 213, "/images/device (243).png", 2, 14000000m, 48000000m, "Mô tả mẫu của sản phẩm213", 12, 5, 6, 300, "DNm3ejIEH0213", "RAM:11Memory:193GB Man hinh :8inch" },
                    { 214, "/images/device (15).png", 7, 6000000m, 33000000m, "Mô tả mẫu của sản phẩm214", 9, 5, 5, 300, "YRE5lMOIt1214", "RAM:12Memory:170GB Man hinh :12inch" },
                    { 215, "/images/device (165).png", 6, 5000000m, 44000000m, "Mô tả mẫu của sản phẩm215", 23, 2, 6, 100, "iTsbujUcdt215", "RAM:2Memory:424GB Man hinh :12inch" },
                    { 216, "/images/device (248).png", 1, 43000000m, 2000000m, "Mô tả mẫu của sản phẩm216", 24, 2, 3, 400, "AJj2jBTC1l216", "RAM:27Memory:139GB Man hinh :4inch" },
                    { 217, "/images/device (123).png", 7, 13000000m, 14000000m, "Mô tả mẫu của sản phẩm217", 36, 1, 3, 300, "yDhyUDwkVX217", "RAM:18Memory:356GB Man hinh :8inch" },
                    { 218, "/images/device (55).png", 6, 49000000m, 39000000m, "Mô tả mẫu của sản phẩm218", 5, 1, 3, 300, "YjNWVTBSmJ218", "RAM:28Memory:453GB Man hinh :4inch" },
                    { 219, "/images/device (204).png", 2, 17000000m, 4000000m, "Mô tả mẫu của sản phẩm219", 23, 2, 2, 300, "V2cCYl6WCp219", "RAM:3Memory:36GB Man hinh :12inch" },
                    { 220, "/images/device (105).png", 7, 19000000m, 4000000m, "Mô tả mẫu của sản phẩm220", 23, 3, 6, 300, "Dt7yM8j8Dj220", "RAM:7Memory:261GB Man hinh :4inch" },
                    { 221, "/images/device (154).png", 7, 21000000m, 49000000m, "Mô tả mẫu của sản phẩm221", 8, 3, 6, 300, "NRD7HRNgid221", "RAM:19Memory:224GB Man hinh :12inch" },
                    { 222, "/images/device (268).png", 7, 46000000m, 5000000m, "Mô tả mẫu của sản phẩm222", 37, 1, 8, 200, "jtvlqy0BJX222", "RAM:29Memory:228GB Man hinh :8inch" },
                    { 223, "/images/device (217).png", 5, 14000000m, 22000000m, "Mô tả mẫu của sản phẩm223", 24, 8, 1, 100, "Z6c7wJwOO5223", "RAM:18Memory:197GB Man hinh :4inch" },
                    { 224, "/images/device (128).png", 5, 29000000m, 39000000m, "Mô tả mẫu của sản phẩm224", 27, 1, 6, 200, "9MYeCdgVR2224", "RAM:2Memory:119GB Man hinh :12inch" },
                    { 225, "/images/device (64).png", 8, 2000000m, 14000000m, "Mô tả mẫu của sản phẩm225", 11, 3, 8, 200, "oVUrB3QC5B225", "RAM:18Memory:225GB Man hinh :8inch" },
                    { 226, "/images/device (130).png", 6, 14000000m, 28000000m, "Mô tả mẫu của sản phẩm226", 12, 1, 8, 200, "WmLNlQY8is226", "RAM:12Memory:237GB Man hinh :12inch" },
                    { 227, "/images/device (83).png", 8, 36000000m, 20000000m, "Mô tả mẫu của sản phẩm227", 12, 2, 6, 100, "av225Oo3g0227", "RAM:21Memory:270GB Man hinh :4inch" },
                    { 228, "/images/device (223).png", 8, 1000000m, 38000000m, "Mô tả mẫu của sản phẩm228", 31, 6, 3, 200, "0HgJM3IyH2228", "RAM:1Memory:404GB Man hinh :16inch" },
                    { 229, "/images/device (162).png", 7, 17000000m, 19000000m, "Mô tả mẫu của sản phẩm229", 33, 7, 1, 400, "Ock628SmC2229", "RAM:28Memory:445GB Man hinh :12inch" },
                    { 230, "/images/device (88).png", 1, 20000000m, 32000000m, "Mô tả mẫu của sản phẩm230", 22, 8, 8, 400, "vSLbkLfS9R230", "RAM:23Memory:47GB Man hinh :4inch" },
                    { 231, "/images/device (186).png", 8, 23000000m, 29000000m, "Mô tả mẫu của sản phẩm231", 6, 1, 3, 200, "QVxYx5PrUD231", "RAM:15Memory:159GB Man hinh :4inch" },
                    { 232, "/images/device (94).png", 3, 46000000m, 1000000m, "Mô tả mẫu của sản phẩm232", 30, 3, 3, 400, "7krs6YdYfi232", "RAM:27Memory:343GB Man hinh :4inch" },
                    { 233, "/images/device (158).png", 6, 34000000m, 31000000m, "Mô tả mẫu của sản phẩm233", 8, 7, 7, 300, "vSBG631DA1233", "RAM:13Memory:453GB Man hinh :4inch" },
                    { 234, "/images/device (190).png", 5, 26000000m, 3000000m, "Mô tả mẫu của sản phẩm234", 39, 4, 1, 400, "2fznM4Er9p234", "RAM:24Memory:393GB Man hinh :8inch" },
                    { 235, "/images/device (206).png", 4, 24000000m, 31000000m, "Mô tả mẫu của sản phẩm235", 25, 3, 5, 100, "mWkuT6Fmv1235", "RAM:17Memory:284GB Man hinh :12inch" },
                    { 236, "/images/device (77).png", 1, 2000000m, 49000000m, "Mô tả mẫu của sản phẩm236", 30, 7, 1, 100, "q5iQVKKPdX236", "RAM:25Memory:432GB Man hinh :4inch" }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "ProductImageId", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, 171, "/images/device (126).png" },
                    { 2, 229, "/images/device (241).png" },
                    { 3, 52, "/images/device (5).png" },
                    { 4, 93, "/images/device (243).png" },
                    { 5, 110, "/images/device (235).png" },
                    { 6, 124, "/images/device (49).png" },
                    { 7, 182, "/images/device (154).png" },
                    { 8, 46, "/images/device (91).png" },
                    { 9, 89, "/images/device (62).png" },
                    { 10, 172, "/images/device (20).png" },
                    { 11, 155, "/images/device (92).png" },
                    { 12, 127, "/images/device (131).png" },
                    { 13, 195, "/images/device (69).png" },
                    { 14, 188, "/images/device (27).png" },
                    { 15, 164, "/images/device (103).png" },
                    { 16, 159, "/images/device (70).png" },
                    { 17, 101, "/images/device (87).png" },
                    { 18, 57, "/images/device (148).png" },
                    { 19, 166, "/images/device (73).png" },
                    { 20, 103, "/images/device (81).png" },
                    { 21, 56, "/images/device (230).png" },
                    { 22, 68, "/images/device (235).png" },
                    { 23, 55, "/images/device (29).png" },
                    { 24, 32, "/images/device (185).png" },
                    { 25, 53, "/images/device (194).png" },
                    { 26, 123, "/images/device (196).png" },
                    { 27, 123, "/images/device (236).png" },
                    { 28, 30, "/images/device (24).png" },
                    { 29, 71, "/images/device (158).png" },
                    { 30, 98, "/images/device (134).png" },
                    { 31, 170, "/images/device (26).png" },
                    { 32, 81, "/images/device (127).png" },
                    { 33, 82, "/images/device (205).png" },
                    { 34, 47, "/images/device (256).png" },
                    { 35, 2, "/images/device (66).png" },
                    { 36, 144, "/images/device (83).png" },
                    { 37, 192, "/images/device (67).png" },
                    { 38, 141, "/images/device (230).png" },
                    { 39, 63, "/images/device (6).png" },
                    { 40, 202, "/images/device (177).png" },
                    { 41, 89, "/images/device (245).png" },
                    { 42, 122, "/images/device (268).png" },
                    { 43, 141, "/images/device (13).png" },
                    { 44, 124, "/images/device (235).png" },
                    { 45, 185, "/images/device (147).png" },
                    { 46, 49, "/images/device (254).png" },
                    { 47, 105, "/images/device (77).png" },
                    { 48, 43, "/images/device (168).png" },
                    { 49, 158, "/images/device (66).png" },
                    { 50, 13, "/images/device (121).png" },
                    { 51, 116, "/images/device (130).png" },
                    { 52, 96, "/images/device (187).png" },
                    { 53, 59, "/images/device (44).png" },
                    { 54, 78, "/images/device (88).png" },
                    { 55, 47, "/images/device (188).png" },
                    { 56, 98, "/images/device (108).png" },
                    { 57, 55, "/images/device (127).png" },
                    { 58, 229, "/images/device (238).png" },
                    { 59, 147, "/images/device (187).png" },
                    { 60, 132, "/images/device (150).png" },
                    { 61, 60, "/images/device (132).png" },
                    { 62, 223, "/images/device (92).png" },
                    { 63, 3, "/images/device (240).png" },
                    { 64, 193, "/images/device (235).png" },
                    { 65, 57, "/images/device (258).png" },
                    { 66, 168, "/images/device (46).png" },
                    { 67, 114, "/images/device (159).png" },
                    { 68, 205, "/images/device (40).png" },
                    { 69, 98, "/images/device (62).png" },
                    { 70, 226, "/images/device (261).png" },
                    { 71, 157, "/images/device (242).png" },
                    { 72, 118, "/images/device (228).png" },
                    { 73, 13, "/images/device (31).png" },
                    { 74, 79, "/images/device (36).png" },
                    { 75, 13, "/images/device (54).png" },
                    { 76, 147, "/images/device (26).png" },
                    { 77, 212, "/images/device (213).png" },
                    { 78, 217, "/images/device (110).png" },
                    { 79, 105, "/images/device (203).png" },
                    { 80, 91, "/images/device (183).png" },
                    { 81, 154, "/images/device (45).png" },
                    { 82, 71, "/images/device (151).png" },
                    { 83, 232, "/images/device (97).png" },
                    { 84, 10, "/images/device (182).png" },
                    { 85, 111, "/images/device (188).png" },
                    { 86, 12, "/images/device (243).png" },
                    { 87, 9, "/images/device (177).png" },
                    { 88, 47, "/images/device (71).png" },
                    { 89, 40, "/images/device (102).png" },
                    { 90, 71, "/images/device (166).png" },
                    { 91, 16, "/images/device (202).png" },
                    { 92, 171, "/images/device (189).png" },
                    { 93, 115, "/images/device (212).png" },
                    { 94, 217, "/images/device (220).png" },
                    { 95, 16, "/images/device (158).png" },
                    { 96, 145, "/images/device (160).png" },
                    { 97, 181, "/images/device (76).png" },
                    { 98, 36, "/images/device (83).png" },
                    { 99, 45, "/images/device (119).png" },
                    { 100, 178, "/images/device (88).png" },
                    { 101, 221, "/images/device (226).png" },
                    { 102, 175, "/images/device (68).png" },
                    { 103, 6, "/images/device (262).png" },
                    { 104, 105, "/images/device (101).png" },
                    { 105, 222, "/images/device (264).png" },
                    { 106, 122, "/images/device (5).png" },
                    { 107, 141, "/images/device (83).png" },
                    { 108, 212, "/images/device (162).png" },
                    { 109, 198, "/images/device (214).png" },
                    { 110, 11, "/images/device (257).png" },
                    { 111, 111, "/images/device (75).png" },
                    { 112, 124, "/images/device (49).png" },
                    { 113, 71, "/images/device (23).png" },
                    { 114, 53, "/images/device (92).png" },
                    { 115, 24, "/images/device (8).png" },
                    { 116, 156, "/images/device (73).png" },
                    { 117, 193, "/images/device (137).png" },
                    { 118, 59, "/images/device (96).png" },
                    { 119, 156, "/images/device (246).png" },
                    { 120, 147, "/images/device (174).png" },
                    { 121, 224, "/images/device (190).png" },
                    { 122, 82, "/images/device (149).png" },
                    { 123, 71, "/images/device (183).png" },
                    { 124, 120, "/images/device (152).png" },
                    { 125, 225, "/images/device (85).png" },
                    { 126, 125, "/images/device (188).png" },
                    { 127, 152, "/images/device (219).png" },
                    { 128, 62, "/images/device (268).png" },
                    { 129, 123, "/images/device (19).png" },
                    { 130, 117, "/images/device (256).png" },
                    { 131, 96, "/images/device (66).png" },
                    { 132, 198, "/images/device (240).png" },
                    { 133, 111, "/images/device (268).png" },
                    { 134, 210, "/images/device (59).png" },
                    { 135, 172, "/images/device (142).png" },
                    { 136, 202, "/images/device (129).png" },
                    { 137, 14, "/images/device (254).png" },
                    { 138, 35, "/images/device (254).png" },
                    { 139, 188, "/images/device (212).png" },
                    { 140, 71, "/images/device (150).png" },
                    { 141, 209, "/images/device (224).png" },
                    { 142, 211, "/images/device (92).png" },
                    { 143, 7, "/images/device (147).png" },
                    { 144, 79, "/images/device (39).png" },
                    { 145, 147, "/images/device (222).png" },
                    { 146, 157, "/images/device (2).png" },
                    { 147, 163, "/images/device (181).png" },
                    { 148, 52, "/images/device (164).png" },
                    { 149, 121, "/images/device (177).png" },
                    { 150, 209, "/images/device (210).png" },
                    { 151, 19, "/images/device (88).png" },
                    { 152, 133, "/images/device (232).png" },
                    { 153, 213, "/images/device (139).png" },
                    { 154, 31, "/images/device (107).png" },
                    { 155, 170, "/images/device (240).png" },
                    { 156, 163, "/images/device (196).png" },
                    { 157, 104, "/images/device (162).png" },
                    { 158, 35, "/images/device (234).png" },
                    { 159, 13, "/images/device (137).png" },
                    { 160, 221, "/images/device (113).png" },
                    { 161, 117, "/images/device (1).png" },
                    { 162, 17, "/images/device (117).png" },
                    { 163, 48, "/images/device (147).png" },
                    { 164, 117, "/images/device (56).png" },
                    { 165, 77, "/images/device (184).png" },
                    { 166, 211, "/images/device (224).png" },
                    { 167, 108, "/images/device (153).png" },
                    { 168, 30, "/images/device (270).png" },
                    { 169, 207, "/images/device (209).png" },
                    { 170, 126, "/images/device (91).png" },
                    { 171, 185, "/images/device (37).png" },
                    { 172, 216, "/images/device (255).png" },
                    { 173, 68, "/images/device (3).png" },
                    { 174, 135, "/images/device (157).png" },
                    { 175, 113, "/images/device (271).png" },
                    { 176, 66, "/images/device (256).png" },
                    { 177, 181, "/images/device (182).png" },
                    { 178, 141, "/images/device (126).png" },
                    { 179, 83, "/images/device (2).png" },
                    { 180, 178, "/images/device (240).png" },
                    { 181, 16, "/images/device (224).png" },
                    { 182, 7, "/images/device (225).png" },
                    { 183, 212, "/images/device (117).png" },
                    { 184, 219, "/images/device (219).png" },
                    { 185, 88, "/images/device (141).png" },
                    { 186, 142, "/images/device (169).png" },
                    { 187, 176, "/images/device (59).png" },
                    { 188, 51, "/images/device (189).png" },
                    { 189, 91, "/images/device (265).png" },
                    { 190, 196, "/images/device (53).png" },
                    { 191, 144, "/images/device (27).png" },
                    { 192, 119, "/images/device (13).png" },
                    { 193, 144, "/images/device (41).png" },
                    { 194, 182, "/images/device (6).png" },
                    { 195, 78, "/images/device (168).png" },
                    { 196, 62, "/images/device (18).png" },
                    { 197, 19, "/images/device (112).png" },
                    { 198, 139, "/images/device (117).png" },
                    { 199, 54, "/images/device (207).png" },
                    { 200, 229, "/images/device (252).png" },
                    { 201, 236, "/images/device (211).png" },
                    { 202, 212, "/images/device (161).png" },
                    { 203, 194, "/images/device (29).png" },
                    { 204, 79, "/images/device (84).png" },
                    { 205, 141, "/images/device (186).png" },
                    { 206, 119, "/images/device (63).png" },
                    { 207, 185, "/images/device (39).png" },
                    { 208, 23, "/images/device (174).png" },
                    { 209, 63, "/images/device (209).png" },
                    { 210, 112, "/images/device (170).png" },
                    { 211, 45, "/images/device (20).png" },
                    { 212, 191, "/images/device (165).png" },
                    { 213, 89, "/images/device (216).png" },
                    { 214, 73, "/images/device (194).png" },
                    { 215, 232, "/images/device (25).png" },
                    { 216, 49, "/images/device (235).png" },
                    { 217, 41, "/images/device (205).png" },
                    { 218, 187, "/images/device (149).png" },
                    { 219, 125, "/images/device (215).png" },
                    { 220, 9, "/images/device (178).png" },
                    { 221, 172, "/images/device (233).png" },
                    { 222, 151, "/images/device (183).png" },
                    { 223, 40, "/images/device (158).png" },
                    { 224, 174, "/images/device (268).png" },
                    { 225, 54, "/images/device (209).png" },
                    { 226, 49, "/images/device (184).png" },
                    { 227, 185, "/images/device (18).png" },
                    { 228, 10, "/images/device (1).png" },
                    { 229, 182, "/images/device (46).png" },
                    { 230, 128, "/images/device (42).png" },
                    { 231, 65, "/images/device (104).png" },
                    { 232, 110, "/images/device (46).png" },
                    { 233, 145, "/images/device (262).png" },
                    { 234, 76, "/images/device (83).png" },
                    { 235, 202, "/images/device (226).png" },
                    { 236, 99, "/images/device (251).png" },
                    { 237, 140, "/images/device (53).png" },
                    { 238, 91, "/images/device (75).png" },
                    { 239, 231, "/images/device (129).png" },
                    { 240, 165, "/images/device (270).png" },
                    { 241, 149, "/images/device (9).png" },
                    { 242, 106, "/images/device (192).png" },
                    { 243, 116, "/images/device (169).png" },
                    { 244, 180, "/images/device (108).png" },
                    { 245, 33, "/images/device (208).png" },
                    { 246, 144, "/images/device (63).png" },
                    { 247, 99, "/images/device (260).png" },
                    { 248, 207, "/images/device (142).png" },
                    { 249, 61, "/images/device (94).png" },
                    { 250, 186, "/images/device (62).png" },
                    { 251, 177, "/images/device (196).png" },
                    { 252, 147, "/images/device (4).png" },
                    { 253, 81, "/images/device (93).png" },
                    { 254, 183, "/images/device (130).png" },
                    { 255, 181, "/images/device (88).png" },
                    { 256, 59, "/images/device (6).png" },
                    { 257, 43, "/images/device (27).png" },
                    { 258, 222, "/images/device (118).png" },
                    { 259, 211, "/images/device (270).png" },
                    { 260, 137, "/images/device (230).png" },
                    { 261, 117, "/images/device (16).png" },
                    { 262, 32, "/images/device (21).png" },
                    { 263, 197, "/images/device (177).png" },
                    { 264, 37, "/images/device (33).png" },
                    { 265, 117, "/images/device (202).png" },
                    { 266, 129, "/images/device (241).png" },
                    { 267, 74, "/images/device (150).png" },
                    { 268, 54, "/images/device (175).png" },
                    { 269, 25, "/images/device (120).png" },
                    { 270, 205, "/images/device (87).png" },
                    { 271, 11, "/images/device (44).png" },
                    { 272, 31, "/images/device (120).png" },
                    { 273, 207, "/images/device (160).png" },
                    { 274, 136, "/images/device (132).png" },
                    { 275, 217, "/images/device (103).png" },
                    { 276, 167, "/images/device (11).png" },
                    { 277, 2, "/images/device (86).png" },
                    { 278, 136, "/images/device (184).png" },
                    { 279, 108, "/images/device (202).png" },
                    { 280, 140, "/images/device (53).png" },
                    { 281, 92, "/images/device (139).png" },
                    { 282, 145, "/images/device (30).png" },
                    { 283, 176, "/images/device (5).png" },
                    { 284, 37, "/images/device (255).png" },
                    { 285, 233, "/images/device (208).png" },
                    { 286, 192, "/images/device (184).png" },
                    { 287, 106, "/images/device (25).png" },
                    { 288, 145, "/images/device (207).png" },
                    { 289, 92, "/images/device (230).png" },
                    { 290, 134, "/images/device (155).png" },
                    { 291, 225, "/images/device (61).png" },
                    { 292, 231, "/images/device (49).png" },
                    { 293, 198, "/images/device (37).png" },
                    { 294, 108, "/images/device (130).png" },
                    { 295, 74, "/images/device (51).png" },
                    { 296, 154, "/images/device (53).png" },
                    { 297, 173, "/images/device (131).png" },
                    { 298, 190, "/images/device (33).png" },
                    { 299, 171, "/images/device (71).png" },
                    { 300, 188, "/images/device (199).png" },
                    { 301, 150, "/images/device (71).png" },
                    { 302, 118, "/images/device (133).png" },
                    { 303, 63, "/images/device (266).png" },
                    { 304, 149, "/images/device (106).png" },
                    { 305, 22, "/images/device (242).png" },
                    { 306, 54, "/images/device (179).png" },
                    { 307, 100, "/images/device (221).png" },
                    { 308, 44, "/images/device (184).png" },
                    { 309, 65, "/images/device (191).png" },
                    { 310, 28, "/images/device (30).png" },
                    { 311, 135, "/images/device (88).png" },
                    { 312, 145, "/images/device (38).png" },
                    { 313, 185, "/images/device (57).png" },
                    { 314, 222, "/images/device (269).png" },
                    { 315, 153, "/images/device (56).png" },
                    { 316, 137, "/images/device (202).png" },
                    { 317, 19, "/images/device (53).png" },
                    { 318, 53, "/images/device (2).png" },
                    { 319, 93, "/images/device (265).png" },
                    { 320, 211, "/images/device (129).png" },
                    { 321, 102, "/images/device (95).png" },
                    { 322, 209, "/images/device (98).png" },
                    { 323, 146, "/images/device (82).png" },
                    { 324, 219, "/images/device (40).png" },
                    { 325, 180, "/images/device (194).png" },
                    { 326, 213, "/images/device (205).png" },
                    { 327, 2, "/images/device (45).png" },
                    { 328, 9, "/images/device (203).png" },
                    { 329, 196, "/images/device (13).png" },
                    { 330, 208, "/images/device (236).png" },
                    { 331, 104, "/images/device (210).png" },
                    { 332, 226, "/images/device (273).png" },
                    { 333, 26, "/images/device (224).png" },
                    { 334, 36, "/images/device (49).png" },
                    { 335, 81, "/images/device (216).png" },
                    { 336, 83, "/images/device (54).png" },
                    { 337, 3, "/images/device (243).png" },
                    { 338, 149, "/images/device (22).png" },
                    { 339, 51, "/images/device (27).png" },
                    { 340, 224, "/images/device (37).png" },
                    { 341, 14, "/images/device (23).png" },
                    { 342, 53, "/images/device (76).png" },
                    { 343, 142, "/images/device (33).png" },
                    { 344, 38, "/images/device (200).png" },
                    { 345, 166, "/images/device (20).png" },
                    { 346, 97, "/images/device (56).png" },
                    { 347, 145, "/images/device (136).png" },
                    { 348, 38, "/images/device (197).png" },
                    { 349, 127, "/images/device (258).png" },
                    { 350, 70, "/images/device (258).png" },
                    { 351, 193, "/images/device (205).png" },
                    { 352, 12, "/images/device (60).png" },
                    { 353, 70, "/images/device (203).png" },
                    { 354, 131, "/images/device (227).png" },
                    { 355, 126, "/images/device (180).png" },
                    { 356, 180, "/images/device (271).png" },
                    { 357, 27, "/images/device (179).png" },
                    { 358, 157, "/images/device (45).png" },
                    { 359, 175, "/images/device (134).png" },
                    { 360, 184, "/images/device (167).png" },
                    { 361, 52, "/images/device (69).png" },
                    { 362, 59, "/images/device (17).png" },
                    { 363, 185, "/images/device (195).png" },
                    { 364, 215, "/images/device (128).png" },
                    { 365, 92, "/images/device (159).png" },
                    { 366, 119, "/images/device (211).png" },
                    { 367, 85, "/images/device (231).png" },
                    { 368, 67, "/images/device (231).png" },
                    { 369, 77, "/images/device (173).png" },
                    { 370, 213, "/images/device (218).png" },
                    { 371, 87, "/images/device (136).png" },
                    { 372, 200, "/images/device (82).png" },
                    { 373, 200, "/images/device (72).png" },
                    { 374, 50, "/images/device (107).png" },
                    { 375, 15, "/images/device (144).png" },
                    { 376, 228, "/images/device (117).png" },
                    { 377, 23, "/images/device (259).png" },
                    { 378, 164, "/images/device (152).png" },
                    { 379, 205, "/images/device (36).png" },
                    { 380, 128, "/images/device (250).png" },
                    { 381, 232, "/images/device (137).png" },
                    { 382, 54, "/images/device (111).png" },
                    { 383, 216, "/images/device (143).png" },
                    { 384, 84, "/images/device (255).png" },
                    { 385, 73, "/images/device (210).png" },
                    { 386, 176, "/images/device (50).png" },
                    { 387, 201, "/images/device (18).png" },
                    { 388, 194, "/images/device (48).png" },
                    { 389, 136, "/images/device (140).png" },
                    { 390, 24, "/images/device (129).png" },
                    { 391, 209, "/images/device (234).png" },
                    { 392, 177, "/images/device (36).png" },
                    { 393, 46, "/images/device (271).png" },
                    { 394, 47, "/images/device (260).png" },
                    { 395, 116, "/images/device (258).png" },
                    { 396, 97, "/images/device (46).png" },
                    { 397, 3, "/images/device (230).png" },
                    { 398, 234, "/images/device (178).png" },
                    { 399, 205, "/images/device (245).png" },
                    { 400, 225, "/images/device (235).png" },
                    { 401, 119, "/images/device (9).png" },
                    { 402, 16, "/images/device (22).png" },
                    { 403, 5, "/images/device (246).png" },
                    { 404, 137, "/images/device (244).png" },
                    { 405, 119, "/images/device (224).png" },
                    { 406, 131, "/images/device (15).png" },
                    { 407, 141, "/images/device (208).png" },
                    { 408, 103, "/images/device (214).png" },
                    { 409, 178, "/images/device (67).png" },
                    { 410, 14, "/images/device (236).png" },
                    { 411, 218, "/images/device (208).png" },
                    { 412, 141, "/images/device (71).png" },
                    { 413, 58, "/images/device (76).png" },
                    { 414, 31, "/images/device (188).png" },
                    { 415, 193, "/images/device (263).png" },
                    { 416, 56, "/images/device (211).png" },
                    { 417, 176, "/images/device (30).png" },
                    { 418, 114, "/images/device (29).png" },
                    { 419, 129, "/images/device (93).png" },
                    { 420, 7, "/images/device (46).png" },
                    { 421, 148, "/images/device (96).png" },
                    { 422, 179, "/images/device (95).png" },
                    { 423, 35, "/images/device (263).png" },
                    { 424, 103, "/images/device (273).png" },
                    { 425, 175, "/images/device (182).png" },
                    { 426, 232, "/images/device (230).png" },
                    { 427, 108, "/images/device (174).png" },
                    { 428, 103, "/images/device (49).png" },
                    { 429, 79, "/images/device (41).png" },
                    { 430, 194, "/images/device (226).png" },
                    { 431, 198, "/images/device (75).png" },
                    { 432, 7, "/images/device (17).png" },
                    { 433, 9, "/images/device (221).png" },
                    { 434, 213, "/images/device (227).png" },
                    { 435, 231, "/images/device (111).png" },
                    { 436, 157, "/images/device (85).png" },
                    { 437, 190, "/images/device (75).png" },
                    { 438, 88, "/images/device (26).png" },
                    { 439, 132, "/images/device (123).png" },
                    { 440, 35, "/images/device (4).png" },
                    { 441, 107, "/images/device (28).png" },
                    { 442, 158, "/images/device (81).png" },
                    { 443, 47, "/images/device (165).png" },
                    { 444, 212, "/images/device (179).png" },
                    { 445, 135, "/images/device (87).png" },
                    { 446, 231, "/images/device (44).png" },
                    { 447, 197, "/images/device (19).png" },
                    { 448, 77, "/images/device (158).png" },
                    { 449, 28, "/images/device (215).png" },
                    { 450, 145, "/images/device (141).png" },
                    { 451, 116, "/images/device (186).png" },
                    { 452, 10, "/images/device (182).png" },
                    { 453, 225, "/images/device (141).png" },
                    { 454, 170, "/images/device (102).png" },
                    { 455, 12, "/images/device (270).png" },
                    { 456, 5, "/images/device (87).png" },
                    { 457, 38, "/images/device (56).png" },
                    { 458, 152, "/images/device (248).png" },
                    { 459, 61, "/images/device (62).png" },
                    { 460, 164, "/images/device (95).png" },
                    { 461, 32, "/images/device (184).png" },
                    { 462, 180, "/images/device (175).png" },
                    { 463, 20, "/images/device (144).png" },
                    { 464, 202, "/images/device (204).png" },
                    { 465, 85, "/images/device (136).png" },
                    { 466, 70, "/images/device (185).png" },
                    { 467, 4, "/images/device (192).png" },
                    { 468, 173, "/images/device (194).png" },
                    { 469, 70, "/images/device (257).png" },
                    { 470, 218, "/images/device (136).png" },
                    { 471, 105, "/images/device (122).png" },
                    { 472, 188, "/images/device (79).png" },
                    { 473, 151, "/images/device (40).png" },
                    { 474, 13, "/images/device (213).png" },
                    { 475, 162, "/images/device (270).png" },
                    { 476, 143, "/images/device (136).png" },
                    { 477, 227, "/images/device (40).png" },
                    { 478, 89, "/images/device (201).png" },
                    { 479, 87, "/images/device (161).png" },
                    { 480, 33, "/images/device (246).png" },
                    { 481, 140, "/images/device (117).png" },
                    { 482, 32, "/images/device (214).png" },
                    { 483, 221, "/images/device (114).png" },
                    { 484, 161, "/images/device (113).png" },
                    { 485, 187, "/images/device (104).png" },
                    { 486, 137, "/images/device (200).png" },
                    { 487, 201, "/images/device (27).png" },
                    { 488, 23, "/images/device (51).png" },
                    { 489, 65, "/images/device (130).png" },
                    { 490, 191, "/images/device (67).png" },
                    { 491, 188, "/images/device (239).png" },
                    { 492, 199, "/images/device (254).png" },
                    { 493, 66, "/images/device (33).png" },
                    { 494, 157, "/images/device (86).png" },
                    { 495, 112, "/images/device (147).png" },
                    { 496, 176, "/images/device (117).png" },
                    { 497, 200, "/images/device (130).png" },
                    { 498, 61, "/images/device (66).png" },
                    { 499, 81, "/images/device (207).png" },
                    { 500, 150, "/images/device (263).png" },
                    { 501, 38, "/images/device (145).png" },
                    { 502, 139, "/images/device (175).png" },
                    { 503, 68, "/images/device (126).png" },
                    { 504, 30, "/images/device (187).png" },
                    { 505, 1, "/images/device (271).png" },
                    { 506, 148, "/images/device (64).png" },
                    { 507, 81, "/images/device (9).png" },
                    { 508, 179, "/images/device (246).png" },
                    { 509, 183, "/images/device (202).png" },
                    { 510, 57, "/images/device (242).png" },
                    { 511, 226, "/images/device (131).png" },
                    { 512, 80, "/images/device (64).png" },
                    { 513, 101, "/images/device (139).png" },
                    { 514, 57, "/images/device (263).png" },
                    { 515, 80, "/images/device (29).png" },
                    { 516, 163, "/images/device (247).png" },
                    { 517, 144, "/images/device (126).png" },
                    { 518, 233, "/images/device (259).png" },
                    { 519, 52, "/images/device (80).png" },
                    { 520, 56, "/images/device (230).png" },
                    { 521, 53, "/images/device (91).png" },
                    { 522, 53, "/images/device (24).png" },
                    { 523, 53, "/images/device (269).png" },
                    { 524, 51, "/images/device (114).png" },
                    { 525, 95, "/images/device (273).png" },
                    { 526, 193, "/images/device (271).png" },
                    { 527, 9, "/images/device (238).png" },
                    { 528, 176, "/images/device (57).png" },
                    { 529, 171, "/images/device (71).png" },
                    { 530, 161, "/images/device (212).png" },
                    { 531, 86, "/images/device (189).png" },
                    { 532, 195, "/images/device (150).png" },
                    { 533, 108, "/images/device (60).png" },
                    { 534, 213, "/images/device (91).png" },
                    { 535, 88, "/images/device (18).png" },
                    { 536, 222, "/images/device (243).png" },
                    { 537, 205, "/images/device (10).png" },
                    { 538, 77, "/images/device (229).png" },
                    { 539, 169, "/images/device (194).png" },
                    { 540, 120, "/images/device (243).png" },
                    { 541, 191, "/images/device (218).png" },
                    { 542, 196, "/images/device (17).png" },
                    { 543, 149, "/images/device (59).png" },
                    { 544, 105, "/images/device (197).png" },
                    { 545, 134, "/images/device (91).png" },
                    { 546, 21, "/images/device (171).png" },
                    { 547, 116, "/images/device (105).png" },
                    { 548, 77, "/images/device (4).png" },
                    { 549, 222, "/images/device (257).png" },
                    { 550, 87, "/images/device (233).png" },
                    { 551, 69, "/images/device (78).png" },
                    { 552, 181, "/images/device (100).png" },
                    { 553, 226, "/images/device (238).png" },
                    { 554, 109, "/images/device (181).png" },
                    { 555, 78, "/images/device (39).png" },
                    { 556, 227, "/images/device (195).png" },
                    { 557, 194, "/images/device (274).png" },
                    { 558, 78, "/images/device (240).png" },
                    { 559, 154, "/images/device (157).png" },
                    { 560, 86, "/images/device (126).png" },
                    { 561, 182, "/images/device (69).png" },
                    { 562, 178, "/images/device (191).png" },
                    { 563, 7, "/images/device (49).png" },
                    { 564, 80, "/images/device (144).png" },
                    { 565, 38, "/images/device (39).png" },
                    { 566, 82, "/images/device (149).png" },
                    { 567, 229, "/images/device (68).png" },
                    { 568, 116, "/images/device (220).png" },
                    { 569, 91, "/images/device (187).png" },
                    { 570, 61, "/images/device (87).png" },
                    { 571, 12, "/images/device (34).png" },
                    { 572, 169, "/images/device (224).png" },
                    { 573, 42, "/images/device (86).png" },
                    { 574, 43, "/images/device (95).png" },
                    { 575, 30, "/images/device (159).png" },
                    { 576, 225, "/images/device (157).png" },
                    { 577, 146, "/images/device (68).png" },
                    { 578, 169, "/images/device (131).png" },
                    { 579, 122, "/images/device (227).png" },
                    { 580, 176, "/images/device (145).png" },
                    { 581, 180, "/images/device (265).png" },
                    { 582, 42, "/images/device (158).png" },
                    { 583, 94, "/images/device (43).png" },
                    { 584, 104, "/images/device (97).png" },
                    { 585, 203, "/images/device (37).png" },
                    { 586, 96, "/images/device (164).png" },
                    { 587, 65, "/images/device (213).png" },
                    { 588, 156, "/images/device (24).png" },
                    { 589, 130, "/images/device (106).png" },
                    { 590, 57, "/images/device (239).png" },
                    { 591, 87, "/images/device (206).png" },
                    { 592, 27, "/images/device (79).png" },
                    { 593, 198, "/images/device (78).png" },
                    { 594, 200, "/images/device (186).png" },
                    { 595, 41, "/images/device (258).png" },
                    { 596, 195, "/images/device (122).png" },
                    { 597, 52, "/images/device (27).png" },
                    { 598, 175, "/images/device (5).png" },
                    { 599, 208, "/images/device (150).png" },
                    { 600, 59, "/images/device (38).png" },
                    { 601, 200, "/images/device (124).png" },
                    { 602, 135, "/images/device (203).png" },
                    { 603, 103, "/images/device (118).png" },
                    { 604, 234, "/images/device (63).png" },
                    { 605, 5, "/images/device (197).png" },
                    { 606, 30, "/images/device (108).png" },
                    { 607, 3, "/images/device (235).png" },
                    { 608, 67, "/images/device (198).png" },
                    { 609, 42, "/images/device (114).png" },
                    { 610, 94, "/images/device (273).png" },
                    { 611, 95, "/images/device (178).png" },
                    { 612, 157, "/images/device (26).png" },
                    { 613, 51, "/images/device (37).png" },
                    { 614, 232, "/images/device (7).png" },
                    { 615, 145, "/images/device (35).png" },
                    { 616, 71, "/images/device (64).png" },
                    { 617, 108, "/images/device (187).png" },
                    { 618, 96, "/images/device (137).png" },
                    { 619, 12, "/images/device (254).png" },
                    { 620, 118, "/images/device (167).png" },
                    { 621, 203, "/images/device (114).png" },
                    { 622, 14, "/images/device (210).png" },
                    { 623, 224, "/images/device (217).png" },
                    { 624, 130, "/images/device (258).png" },
                    { 625, 79, "/images/device (245).png" },
                    { 626, 212, "/images/device (56).png" },
                    { 627, 75, "/images/device (90).png" },
                    { 628, 4, "/images/device (167).png" },
                    { 629, 9, "/images/device (164).png" },
                    { 630, 35, "/images/device (203).png" },
                    { 631, 148, "/images/device (69).png" },
                    { 632, 201, "/images/device (198).png" },
                    { 633, 161, "/images/device (23).png" },
                    { 634, 112, "/images/device (23).png" },
                    { 635, 217, "/images/device (65).png" },
                    { 636, 135, "/images/device (94).png" },
                    { 637, 121, "/images/device (95).png" },
                    { 638, 224, "/images/device (198).png" },
                    { 639, 154, "/images/device (106).png" },
                    { 640, 61, "/images/device (88).png" },
                    { 641, 157, "/images/device (116).png" },
                    { 642, 115, "/images/device (6).png" },
                    { 643, 209, "/images/device (178).png" },
                    { 644, 185, "/images/device (214).png" },
                    { 645, 159, "/images/device (156).png" },
                    { 646, 4, "/images/device (247).png" },
                    { 647, 52, "/images/device (155).png" },
                    { 648, 145, "/images/device (230).png" },
                    { 649, 46, "/images/device (171).png" },
                    { 650, 82, "/images/device (134).png" },
                    { 651, 155, "/images/device (117).png" },
                    { 652, 20, "/images/device (61).png" },
                    { 653, 226, "/images/device (246).png" },
                    { 654, 60, "/images/device (256).png" },
                    { 655, 31, "/images/device (195).png" },
                    { 656, 222, "/images/device (187).png" },
                    { 657, 56, "/images/device (225).png" },
                    { 658, 26, "/images/device (209).png" },
                    { 659, 185, "/images/device (143).png" },
                    { 660, 215, "/images/device (217).png" },
                    { 661, 161, "/images/device (47).png" },
                    { 662, 82, "/images/device (268).png" },
                    { 663, 87, "/images/device (71).png" },
                    { 664, 236, "/images/device (121).png" },
                    { 665, 146, "/images/device (213).png" },
                    { 666, 82, "/images/device (15).png" },
                    { 667, 100, "/images/device (59).png" },
                    { 668, 179, "/images/device (145).png" },
                    { 669, 144, "/images/device (219).png" },
                    { 670, 123, "/images/device (46).png" },
                    { 671, 27, "/images/device (274).png" },
                    { 672, 57, "/images/device (244).png" },
                    { 673, 218, "/images/device (180).png" },
                    { 674, 216, "/images/device (85).png" },
                    { 675, 6, "/images/device (253).png" },
                    { 676, 188, "/images/device (11).png" },
                    { 677, 150, "/images/device (222).png" },
                    { 678, 187, "/images/device (57).png" },
                    { 679, 8, "/images/device (229).png" },
                    { 680, 226, "/images/device (51).png" },
                    { 681, 10, "/images/device (220).png" },
                    { 682, 99, "/images/device (79).png" },
                    { 683, 141, "/images/device (40).png" },
                    { 684, 228, "/images/device (235).png" },
                    { 685, 169, "/images/device (220).png" },
                    { 686, 168, "/images/device (214).png" },
                    { 687, 102, "/images/device (11).png" },
                    { 688, 94, "/images/device (227).png" },
                    { 689, 5, "/images/device (59).png" },
                    { 690, 218, "/images/device (250).png" },
                    { 691, 1, "/images/device (146).png" },
                    { 692, 193, "/images/device (95).png" },
                    { 693, 206, "/images/device (171).png" },
                    { 694, 39, "/images/device (256).png" },
                    { 695, 223, "/images/device (170).png" },
                    { 696, 177, "/images/device (142).png" },
                    { 697, 117, "/images/device (13).png" },
                    { 698, 197, "/images/device (274).png" },
                    { 699, 69, "/images/device (63).png" },
                    { 700, 171, "/images/device (273).png" },
                    { 701, 126, "/images/device (200).png" },
                    { 702, 168, "/images/device (149).png" },
                    { 703, 64, "/images/device (11).png" },
                    { 704, 5, "/images/device (179).png" },
                    { 705, 54, "/images/device (137).png" },
                    { 706, 153, "/images/device (184).png" },
                    { 707, 224, "/images/device (40).png" },
                    { 708, 87, "/images/device (90).png" },
                    { 709, 219, "/images/device (48).png" },
                    { 710, 10, "/images/device (81).png" },
                    { 711, 225, "/images/device (199).png" },
                    { 712, 86, "/images/device (274).png" },
                    { 713, 181, "/images/device (101).png" },
                    { 714, 186, "/images/device (155).png" },
                    { 715, 157, "/images/device (231).png" },
                    { 716, 151, "/images/device (69).png" },
                    { 717, 21, "/images/device (63).png" },
                    { 718, 40, "/images/device (161).png" },
                    { 719, 157, "/images/device (104).png" },
                    { 720, 118, "/images/device (268).png" },
                    { 721, 11, "/images/device (137).png" },
                    { 722, 197, "/images/device (47).png" },
                    { 723, 233, "/images/device (73).png" },
                    { 724, 7, "/images/device (122).png" },
                    { 725, 146, "/images/device (107).png" },
                    { 726, 107, "/images/device (26).png" },
                    { 727, 27, "/images/device (121).png" },
                    { 728, 204, "/images/device (184).png" },
                    { 729, 115, "/images/device (26).png" },
                    { 730, 137, "/images/device (9).png" },
                    { 731, 27, "/images/device (202).png" },
                    { 732, 66, "/images/device (83).png" },
                    { 733, 70, "/images/device (98).png" },
                    { 734, 236, "/images/device (212).png" },
                    { 735, 42, "/images/device (160).png" },
                    { 736, 70, "/images/device (253).png" },
                    { 737, 83, "/images/device (36).png" },
                    { 738, 177, "/images/device (46).png" },
                    { 739, 19, "/images/device (125).png" },
                    { 740, 22, "/images/device (22).png" },
                    { 741, 134, "/images/device (209).png" },
                    { 742, 140, "/images/device (162).png" },
                    { 743, 147, "/images/device (261).png" },
                    { 744, 63, "/images/device (138).png" },
                    { 745, 145, "/images/device (239).png" },
                    { 746, 49, "/images/device (50).png" },
                    { 747, 235, "/images/device (7).png" },
                    { 748, 158, "/images/device (61).png" },
                    { 749, 34, "/images/device (209).png" },
                    { 750, 39, "/images/device (262).png" },
                    { 751, 122, "/images/device (42).png" },
                    { 752, 55, "/images/device (151).png" },
                    { 753, 22, "/images/device (82).png" },
                    { 754, 124, "/images/device (248).png" },
                    { 755, 1, "/images/device (39).png" },
                    { 756, 2, "/images/device (257).png" },
                    { 757, 94, "/images/device (34).png" },
                    { 758, 144, "/images/device (137).png" },
                    { 759, 14, "/images/device (148).png" },
                    { 760, 158, "/images/device (189).png" },
                    { 761, 150, "/images/device (51).png" },
                    { 762, 111, "/images/device (37).png" },
                    { 763, 206, "/images/device (206).png" },
                    { 764, 104, "/images/device (104).png" },
                    { 765, 59, "/images/device (268).png" },
                    { 766, 83, "/images/device (198).png" },
                    { 767, 148, "/images/device (221).png" },
                    { 768, 128, "/images/device (78).png" },
                    { 769, 2, "/images/device (213).png" },
                    { 770, 76, "/images/device (153).png" },
                    { 771, 197, "/images/device (250).png" },
                    { 772, 200, "/images/device (7).png" },
                    { 773, 228, "/images/device (45).png" },
                    { 774, 22, "/images/device (205).png" },
                    { 775, 140, "/images/device (98).png" },
                    { 776, 66, "/images/device (216).png" },
                    { 777, 166, "/images/device (261).png" },
                    { 778, 33, "/images/device (28).png" },
                    { 779, 189, "/images/device (95).png" },
                    { 780, 5, "/images/device (12).png" },
                    { 781, 116, "/images/device (187).png" },
                    { 782, 98, "/images/device (2).png" },
                    { 783, 59, "/images/device (176).png" },
                    { 784, 75, "/images/device (77).png" },
                    { 785, 117, "/images/device (223).png" },
                    { 786, 42, "/images/device (1).png" },
                    { 787, 212, "/images/device (108).png" },
                    { 788, 185, "/images/device (85).png" },
                    { 789, 185, "/images/device (182).png" },
                    { 790, 154, "/images/device (227).png" },
                    { 791, 63, "/images/device (249).png" },
                    { 792, 121, "/images/device (270).png" },
                    { 793, 235, "/images/device (16).png" },
                    { 794, 66, "/images/device (23).png" },
                    { 795, 179, "/images/device (156).png" },
                    { 796, 208, "/images/device (269).png" },
                    { 797, 100, "/images/device (232).png" },
                    { 798, 12, "/images/device (171).png" },
                    { 799, 160, "/images/device (125).png" },
                    { 800, 153, "/images/device (58).png" },
                    { 801, 214, "/images/device (9).png" },
                    { 802, 128, "/images/device (46).png" },
                    { 803, 28, "/images/device (40).png" },
                    { 804, 224, "/images/device (135).png" },
                    { 805, 23, "/images/device (77).png" },
                    { 806, 230, "/images/device (195).png" },
                    { 807, 32, "/images/device (52).png" },
                    { 808, 14, "/images/device (13).png" },
                    { 809, 185, "/images/device (176).png" },
                    { 810, 101, "/images/device (241).png" },
                    { 811, 91, "/images/device (100).png" },
                    { 812, 141, "/images/device (13).png" },
                    { 813, 202, "/images/device (19).png" },
                    { 814, 208, "/images/device (28).png" },
                    { 815, 163, "/images/device (39).png" },
                    { 816, 182, "/images/device (148).png" },
                    { 817, 164, "/images/device (16).png" },
                    { 818, 165, "/images/device (51).png" },
                    { 819, 230, "/images/device (254).png" },
                    { 820, 227, "/images/device (76).png" },
                    { 821, 21, "/images/device (144).png" },
                    { 822, 151, "/images/device (205).png" },
                    { 823, 89, "/images/device (242).png" },
                    { 824, 235, "/images/device (6).png" },
                    { 825, 18, "/images/device (36).png" },
                    { 826, 37, "/images/device (262).png" },
                    { 827, 134, "/images/device (37).png" },
                    { 828, 98, "/images/device (152).png" },
                    { 829, 169, "/images/device (224).png" },
                    { 830, 194, "/images/device (273).png" },
                    { 831, 75, "/images/device (132).png" },
                    { 832, 151, "/images/device (158).png" },
                    { 833, 84, "/images/device (207).png" },
                    { 834, 79, "/images/device (174).png" },
                    { 835, 150, "/images/device (133).png" },
                    { 836, 157, "/images/device (85).png" },
                    { 837, 108, "/images/device (110).png" },
                    { 838, 70, "/images/device (179).png" },
                    { 839, 178, "/images/device (190).png" },
                    { 840, 56, "/images/device (231).png" },
                    { 841, 129, "/images/device (199).png" },
                    { 842, 117, "/images/device (37).png" },
                    { 843, 225, "/images/device (224).png" },
                    { 844, 207, "/images/device (88).png" },
                    { 845, 226, "/images/device (206).png" },
                    { 846, 79, "/images/device (220).png" },
                    { 847, 55, "/images/device (102).png" },
                    { 848, 178, "/images/device (75).png" },
                    { 849, 172, "/images/device (207).png" },
                    { 850, 34, "/images/device (34).png" },
                    { 851, 92, "/images/device (205).png" },
                    { 852, 212, "/images/device (90).png" },
                    { 853, 88, "/images/device (2).png" },
                    { 854, 226, "/images/device (246).png" },
                    { 855, 93, "/images/device (183).png" },
                    { 856, 149, "/images/device (161).png" },
                    { 857, 151, "/images/device (243).png" },
                    { 858, 117, "/images/device (247).png" },
                    { 859, 126, "/images/device (155).png" },
                    { 860, 72, "/images/device (230).png" },
                    { 861, 96, "/images/device (242).png" },
                    { 862, 174, "/images/device (186).png" },
                    { 863, 49, "/images/device (173).png" },
                    { 864, 157, "/images/device (192).png" },
                    { 865, 154, "/images/device (266).png" },
                    { 866, 192, "/images/device (59).png" },
                    { 867, 83, "/images/device (98).png" },
                    { 868, 89, "/images/device (181).png" },
                    { 869, 228, "/images/device (208).png" },
                    { 870, 8, "/images/device (173).png" },
                    { 871, 30, "/images/device (10).png" },
                    { 872, 17, "/images/device (268).png" },
                    { 873, 105, "/images/device (102).png" },
                    { 874, 6, "/images/device (110).png" },
                    { 875, 60, "/images/device (63).png" },
                    { 876, 26, "/images/device (251).png" },
                    { 877, 198, "/images/device (208).png" },
                    { 878, 51, "/images/device (188).png" },
                    { 879, 72, "/images/device (12).png" },
                    { 880, 93, "/images/device (26).png" },
                    { 881, 105, "/images/device (135).png" },
                    { 882, 227, "/images/device (164).png" },
                    { 883, 70, "/images/device (136).png" },
                    { 884, 65, "/images/device (104).png" },
                    { 885, 233, "/images/device (120).png" },
                    { 886, 17, "/images/device (174).png" },
                    { 887, 64, "/images/device (217).png" },
                    { 888, 184, "/images/device (132).png" },
                    { 889, 91, "/images/device (70).png" },
                    { 890, 94, "/images/device (34).png" },
                    { 891, 91, "/images/device (256).png" },
                    { 892, 10, "/images/device (71).png" },
                    { 893, 33, "/images/device (24).png" },
                    { 894, 53, "/images/device (144).png" },
                    { 895, 21, "/images/device (66).png" },
                    { 896, 144, "/images/device (214).png" },
                    { 897, 18, "/images/device (217).png" },
                    { 898, 222, "/images/device (186).png" },
                    { 899, 162, "/images/device (72).png" },
                    { 900, 33, "/images/device (63).png" },
                    { 901, 114, "/images/device (228).png" },
                    { 902, 8, "/images/device (82).png" },
                    { 903, 171, "/images/device (57).png" },
                    { 904, 195, "/images/device (236).png" },
                    { 905, 138, "/images/device (237).png" },
                    { 906, 207, "/images/device (99).png" },
                    { 907, 117, "/images/device (85).png" },
                    { 908, 143, "/images/device (18).png" },
                    { 909, 200, "/images/device (64).png" },
                    { 910, 72, "/images/device (247).png" },
                    { 911, 128, "/images/device (45).png" },
                    { 912, 208, "/images/device (115).png" },
                    { 913, 19, "/images/device (38).png" },
                    { 914, 164, "/images/device (86).png" },
                    { 915, 187, "/images/device (73).png" },
                    { 916, 195, "/images/device (45).png" },
                    { 917, 40, "/images/device (61).png" },
                    { 918, 155, "/images/device (207).png" },
                    { 919, 109, "/images/device (25).png" },
                    { 920, 81, "/images/device (116).png" },
                    { 921, 118, "/images/device (242).png" },
                    { 922, 222, "/images/device (91).png" },
                    { 923, 24, "/images/device (2).png" },
                    { 924, 178, "/images/device (100).png" },
                    { 925, 27, "/images/device (214).png" },
                    { 926, 70, "/images/device (22).png" },
                    { 927, 96, "/images/device (225).png" },
                    { 928, 195, "/images/device (6).png" },
                    { 929, 93, "/images/device (156).png" },
                    { 930, 135, "/images/device (87).png" },
                    { 931, 214, "/images/device (195).png" },
                    { 932, 180, "/images/device (94).png" },
                    { 933, 103, "/images/device (206).png" },
                    { 934, 226, "/images/device (265).png" },
                    { 935, 60, "/images/device (108).png" },
                    { 936, 180, "/images/device (66).png" },
                    { 937, 144, "/images/device (132).png" },
                    { 938, 63, "/images/device (69).png" },
                    { 939, 16, "/images/device (140).png" },
                    { 940, 220, "/images/device (41).png" },
                    { 941, 216, "/images/device (128).png" },
                    { 942, 43, "/images/device (53).png" },
                    { 943, 15, "/images/device (169).png" },
                    { 944, 186, "/images/device (260).png" },
                    { 945, 54, "/images/device (24).png" },
                    { 946, 76, "/images/device (13).png" },
                    { 947, 69, "/images/device (98).png" },
                    { 948, 1, "/images/device (69).png" },
                    { 949, 5, "/images/device (228).png" },
                    { 950, 2, "/images/device (217).png" },
                    { 951, 98, "/images/device (83).png" },
                    { 952, 87, "/images/device (9).png" },
                    { 953, 13, "/images/device (131).png" },
                    { 954, 225, "/images/device (16).png" },
                    { 955, 107, "/images/device (197).png" },
                    { 956, 199, "/images/device (194).png" },
                    { 957, 140, "/images/device (153).png" },
                    { 958, 156, "/images/device (260).png" },
                    { 959, 182, "/images/device (30).png" },
                    { 960, 29, "/images/device (18).png" },
                    { 961, 100, "/images/device (19).png" },
                    { 962, 128, "/images/device (33).png" },
                    { 963, 168, "/images/device (70).png" },
                    { 964, 126, "/images/device (220).png" },
                    { 965, 56, "/images/device (206).png" },
                    { 966, 41, "/images/device (198).png" },
                    { 967, 183, "/images/device (34).png" },
                    { 968, 235, "/images/device (15).png" },
                    { 969, 47, "/images/device (225).png" },
                    { 970, 124, "/images/device (40).png" },
                    { 971, 137, "/images/device (166).png" },
                    { 972, 72, "/images/device (115).png" },
                    { 973, 63, "/images/device (162).png" },
                    { 974, 97, "/images/device (95).png" },
                    { 975, 111, "/images/device (219).png" },
                    { 976, 77, "/images/device (225).png" },
                    { 977, 109, "/images/device (173).png" },
                    { 978, 41, "/images/device (96).png" },
                    { 979, 57, "/images/device (259).png" },
                    { 980, 60, "/images/device (126).png" },
                    { 981, 198, "/images/device (217).png" },
                    { 982, 216, "/images/device (235).png" },
                    { 983, 116, "/images/device (54).png" },
                    { 984, 42, "/images/device (227).png" },
                    { 985, 183, "/images/device (252).png" },
                    { 986, 149, "/images/device (192).png" },
                    { 987, 199, "/images/device (110).png" },
                    { 988, 223, "/images/device (217).png" },
                    { 989, 146, "/images/device (11).png" },
                    { 990, 151, "/images/device (260).png" },
                    { 991, 203, "/images/device (129).png" },
                    { 992, 19, "/images/device (199).png" },
                    { 993, 86, "/images/device (20).png" },
                    { 994, 189, "/images/device (231).png" },
                    { 995, 153, "/images/device (220).png" },
                    { 996, 59, "/images/device (169).png" },
                    { 997, 149, "/images/device (48).png" },
                    { 998, 96, "/images/device (243).png" },
                    { 999, 37, "/images/device (7).png" },
                    { 1000, 86, "/images/device (94).png" },
                    { 1001, 114, "/images/device (125).png" },
                    { 1002, 122, "/images/device (139).png" },
                    { 1003, 30, "/images/device (43).png" },
                    { 1004, 112, "/images/device (132).png" },
                    { 1005, 213, "/images/device (96).png" },
                    { 1006, 136, "/images/device (181).png" },
                    { 1007, 16, "/images/device (225).png" },
                    { 1008, 86, "/images/device (13).png" },
                    { 1009, 222, "/images/device (69).png" },
                    { 1010, 125, "/images/device (228).png" },
                    { 1011, 46, "/images/device (198).png" },
                    { 1012, 75, "/images/device (8).png" },
                    { 1013, 103, "/images/device (128).png" },
                    { 1014, 155, "/images/device (262).png" },
                    { 1015, 106, "/images/device (165).png" },
                    { 1016, 23, "/images/device (75).png" },
                    { 1017, 198, "/images/device (267).png" },
                    { 1018, 128, "/images/device (92).png" },
                    { 1019, 228, "/images/device (7).png" },
                    { 1020, 77, "/images/device (159).png" },
                    { 1021, 109, "/images/device (54).png" },
                    { 1022, 84, "/images/device (47).png" },
                    { 1023, 160, "/images/device (198).png" },
                    { 1024, 40, "/images/device (104).png" },
                    { 1025, 138, "/images/device (32).png" },
                    { 1026, 123, "/images/device (81).png" },
                    { 1027, 148, "/images/device (15).png" },
                    { 1028, 23, "/images/device (167).png" },
                    { 1029, 201, "/images/device (264).png" },
                    { 1030, 74, "/images/device (188).png" },
                    { 1031, 212, "/images/device (193).png" },
                    { 1032, 31, "/images/device (79).png" },
                    { 1033, 65, "/images/device (11).png" },
                    { 1034, 120, "/images/device (270).png" },
                    { 1035, 32, "/images/device (9).png" },
                    { 1036, 75, "/images/device (41).png" },
                    { 1037, 113, "/images/device (263).png" },
                    { 1038, 71, "/images/device (113).png" },
                    { 1039, 21, "/images/device (92).png" },
                    { 1040, 56, "/images/device (206).png" },
                    { 1041, 76, "/images/device (69).png" },
                    { 1042, 104, "/images/device (98).png" },
                    { 1043, 61, "/images/device (96).png" },
                    { 1044, 65, "/images/device (251).png" },
                    { 1045, 111, "/images/device (179).png" },
                    { 1046, 126, "/images/device (3).png" },
                    { 1047, 90, "/images/device (41).png" },
                    { 1048, 68, "/images/device (251).png" },
                    { 1049, 48, "/images/device (126).png" },
                    { 1050, 55, "/images/device (210).png" },
                    { 1051, 41, "/images/device (92).png" },
                    { 1052, 66, "/images/device (104).png" },
                    { 1053, 35, "/images/device (9).png" },
                    { 1054, 196, "/images/device (222).png" },
                    { 1055, 204, "/images/device (218).png" },
                    { 1056, 4, "/images/device (122).png" },
                    { 1057, 62, "/images/device (220).png" },
                    { 1058, 188, "/images/device (63).png" },
                    { 1059, 189, "/images/device (8).png" },
                    { 1060, 226, "/images/device (30).png" },
                    { 1061, 113, "/images/device (163).png" },
                    { 1062, 136, "/images/device (96).png" },
                    { 1063, 4, "/images/device (49).png" },
                    { 1064, 212, "/images/device (274).png" },
                    { 1065, 71, "/images/device (84).png" },
                    { 1066, 174, "/images/device (197).png" },
                    { 1067, 207, "/images/device (190).png" },
                    { 1068, 187, "/images/device (125).png" },
                    { 1069, 203, "/images/device (259).png" },
                    { 1070, 198, "/images/device (74).png" },
                    { 1071, 168, "/images/device (192).png" },
                    { 1072, 68, "/images/device (205).png" },
                    { 1073, 180, "/images/device (104).png" },
                    { 1074, 20, "/images/device (40).png" },
                    { 1075, 11, "/images/device (170).png" },
                    { 1076, 183, "/images/device (207).png" },
                    { 1077, 170, "/images/device (117).png" },
                    { 1078, 186, "/images/device (191).png" },
                    { 1079, 138, "/images/device (211).png" },
                    { 1080, 205, "/images/device (169).png" },
                    { 1081, 108, "/images/device (145).png" },
                    { 1082, 48, "/images/device (182).png" },
                    { 1083, 12, "/images/device (220).png" },
                    { 1084, 228, "/images/device (5).png" },
                    { 1085, 50, "/images/device (225).png" },
                    { 1086, 23, "/images/device (242).png" },
                    { 1087, 129, "/images/device (111).png" },
                    { 1088, 148, "/images/device (9).png" },
                    { 1089, 98, "/images/device (145).png" },
                    { 1090, 213, "/images/device (93).png" },
                    { 1091, 150, "/images/device (217).png" },
                    { 1092, 222, "/images/device (264).png" },
                    { 1093, 96, "/images/device (31).png" },
                    { 1094, 170, "/images/device (132).png" },
                    { 1095, 63, "/images/device (269).png" },
                    { 1096, 191, "/images/device (99).png" },
                    { 1097, 125, "/images/device (125).png" },
                    { 1098, 30, "/images/device (103).png" },
                    { 1099, 223, "/images/device (48).png" },
                    { 1100, 160, "/images/device (62).png" },
                    { 1101, 35, "/images/device (25).png" },
                    { 1102, 67, "/images/device (177).png" },
                    { 1103, 86, "/images/device (188).png" },
                    { 1104, 43, "/images/device (201).png" },
                    { 1105, 173, "/images/device (192).png" },
                    { 1106, 145, "/images/device (36).png" },
                    { 1107, 208, "/images/device (3).png" },
                    { 1108, 73, "/images/device (191).png" },
                    { 1109, 12, "/images/device (183).png" },
                    { 1110, 63, "/images/device (38).png" },
                    { 1111, 79, "/images/device (171).png" },
                    { 1112, 58, "/images/device (81).png" },
                    { 1113, 110, "/images/device (75).png" },
                    { 1114, 230, "/images/device (22).png" },
                    { 1115, 77, "/images/device (64).png" },
                    { 1116, 145, "/images/device (76).png" },
                    { 1117, 158, "/images/device (270).png" },
                    { 1118, 221, "/images/device (67).png" },
                    { 1119, 29, "/images/device (87).png" },
                    { 1120, 202, "/images/device (213).png" },
                    { 1121, 197, "/images/device (225).png" },
                    { 1122, 209, "/images/device (50).png" },
                    { 1123, 142, "/images/device (198).png" },
                    { 1124, 20, "/images/device (56).png" },
                    { 1125, 215, "/images/device (52).png" },
                    { 1126, 132, "/images/device (238).png" },
                    { 1127, 141, "/images/device (202).png" },
                    { 1128, 230, "/images/device (235).png" },
                    { 1129, 201, "/images/device (206).png" },
                    { 1130, 139, "/images/device (271).png" },
                    { 1131, 146, "/images/device (244).png" },
                    { 1132, 187, "/images/device (85).png" },
                    { 1133, 151, "/images/device (160).png" },
                    { 1134, 200, "/images/device (50).png" },
                    { 1135, 212, "/images/device (56).png" },
                    { 1136, 148, "/images/device (262).png" },
                    { 1137, 69, "/images/device (42).png" },
                    { 1138, 155, "/images/device (63).png" },
                    { 1139, 47, "/images/device (14).png" },
                    { 1140, 43, "/images/device (139).png" },
                    { 1141, 151, "/images/device (111).png" },
                    { 1142, 228, "/images/device (160).png" },
                    { 1143, 211, "/images/device (82).png" },
                    { 1144, 187, "/images/device (72).png" },
                    { 1145, 144, "/images/device (31).png" },
                    { 1146, 153, "/images/device (31).png" },
                    { 1147, 112, "/images/device (200).png" },
                    { 1148, 133, "/images/device (21).png" },
                    { 1149, 13, "/images/device (64).png" },
                    { 1150, 45, "/images/device (223).png" },
                    { 1151, 150, "/images/device (15).png" },
                    { 1152, 174, "/images/device (259).png" },
                    { 1153, 191, "/images/device (268).png" },
                    { 1154, 138, "/images/device (41).png" },
                    { 1155, 90, "/images/device (85).png" },
                    { 1156, 146, "/images/device (210).png" },
                    { 1157, 4, "/images/device (87).png" },
                    { 1158, 198, "/images/device (216).png" },
                    { 1159, 19, "/images/device (121).png" },
                    { 1160, 20, "/images/device (209).png" },
                    { 1161, 12, "/images/device (29).png" },
                    { 1162, 21, "/images/device (162).png" },
                    { 1163, 29, "/images/device (273).png" },
                    { 1164, 53, "/images/device (81).png" },
                    { 1165, 184, "/images/device (268).png" },
                    { 1166, 13, "/images/device (240).png" },
                    { 1167, 147, "/images/device (13).png" },
                    { 1168, 25, "/images/device (143).png" },
                    { 1169, 70, "/images/device (103).png" },
                    { 1170, 136, "/images/device (265).png" },
                    { 1171, 202, "/images/device (84).png" },
                    { 1172, 187, "/images/device (114).png" },
                    { 1173, 236, "/images/device (11).png" },
                    { 1174, 71, "/images/device (210).png" },
                    { 1175, 122, "/images/device (104).png" },
                    { 1176, 66, "/images/device (223).png" },
                    { 1177, 215, "/images/device (253).png" },
                    { 1178, 1, "/images/device (169).png" },
                    { 1179, 17, "/images/device (260).png" },
                    { 1180, 223, "/images/device (4).png" },
                    { 1181, 120, "/images/device (141).png" },
                    { 1182, 107, "/images/device (27).png" },
                    { 1183, 218, "/images/device (245).png" },
                    { 1184, 39, "/images/device (12).png" },
                    { 1185, 102, "/images/device (12).png" },
                    { 1186, 10, "/images/device (89).png" },
                    { 1187, 124, "/images/device (43).png" },
                    { 1188, 22, "/images/device (79).png" },
                    { 1189, 20, "/images/device (20).png" },
                    { 1190, 115, "/images/device (31).png" },
                    { 1191, 151, "/images/device (135).png" },
                    { 1192, 32, "/images/device (70).png" },
                    { 1193, 49, "/images/device (6).png" },
                    { 1194, 81, "/images/device (191).png" },
                    { 1195, 51, "/images/device (85).png" },
                    { 1196, 163, "/images/device (245).png" },
                    { 1197, 154, "/images/device (223).png" },
                    { 1198, 24, "/images/device (38).png" },
                    { 1199, 102, "/images/device (104).png" },
                    { 1200, 81, "/images/device (142).png" },
                    { 1201, 193, "/images/device (65).png" },
                    { 1202, 205, "/images/device (151).png" },
                    { 1203, 42, "/images/device (256).png" },
                    { 1204, 180, "/images/device (40).png" },
                    { 1205, 69, "/images/device (36).png" },
                    { 1206, 51, "/images/device (179).png" },
                    { 1207, 75, "/images/device (57).png" },
                    { 1208, 125, "/images/device (214).png" },
                    { 1209, 81, "/images/device (95).png" },
                    { 1210, 235, "/images/device (52).png" },
                    { 1211, 4, "/images/device (242).png" },
                    { 1212, 144, "/images/device (260).png" },
                    { 1213, 48, "/images/device (114).png" },
                    { 1214, 13, "/images/device (147).png" },
                    { 1215, 14, "/images/device (43).png" },
                    { 1216, 49, "/images/device (211).png" },
                    { 1217, 202, "/images/device (125).png" },
                    { 1218, 36, "/images/device (210).png" },
                    { 1219, 1, "/images/device (54).png" },
                    { 1220, 52, "/images/device (80).png" },
                    { 1221, 153, "/images/device (139).png" },
                    { 1222, 93, "/images/device (139).png" },
                    { 1223, 181, "/images/device (9).png" },
                    { 1224, 85, "/images/device (89).png" },
                    { 1225, 229, "/images/device (192).png" },
                    { 1226, 130, "/images/device (174).png" },
                    { 1227, 127, "/images/device (173).png" },
                    { 1228, 129, "/images/device (216).png" },
                    { 1229, 48, "/images/device (172).png" },
                    { 1230, 24, "/images/device (197).png" },
                    { 1231, 90, "/images/device (125).png" },
                    { 1232, 219, "/images/device (73).png" },
                    { 1233, 120, "/images/device (16).png" },
                    { 1234, 132, "/images/device (14).png" },
                    { 1235, 110, "/images/device (28).png" },
                    { 1236, 81, "/images/device (21).png" },
                    { 1237, 168, "/images/device (66).png" },
                    { 1238, 231, "/images/device (30).png" },
                    { 1239, 198, "/images/device (17).png" },
                    { 1240, 158, "/images/device (54).png" },
                    { 1241, 59, "/images/device (186).png" },
                    { 1242, 177, "/images/device (249).png" },
                    { 1243, 104, "/images/device (72).png" },
                    { 1244, 226, "/images/device (101).png" },
                    { 1245, 218, "/images/device (49).png" },
                    { 1246, 236, "/images/device (255).png" },
                    { 1247, 146, "/images/device (1).png" },
                    { 1248, 105, "/images/device (261).png" },
                    { 1249, 40, "/images/device (12).png" },
                    { 1250, 68, "/images/device (193).png" },
                    { 1251, 117, "/images/device (180).png" },
                    { 1252, 95, "/images/device (7).png" },
                    { 1253, 155, "/images/device (188).png" },
                    { 1254, 180, "/images/device (143).png" },
                    { 1255, 220, "/images/device (124).png" },
                    { 1256, 225, "/images/device (3).png" },
                    { 1257, 16, "/images/device (115).png" },
                    { 1258, 46, "/images/device (193).png" },
                    { 1259, 133, "/images/device (146).png" },
                    { 1260, 91, "/images/device (101).png" },
                    { 1261, 151, "/images/device (14).png" },
                    { 1262, 73, "/images/device (247).png" },
                    { 1263, 109, "/images/device (135).png" },
                    { 1264, 76, "/images/device (94).png" },
                    { 1265, 48, "/images/device (178).png" },
                    { 1266, 200, "/images/device (253).png" },
                    { 1267, 89, "/images/device (66).png" },
                    { 1268, 228, "/images/device (46).png" },
                    { 1269, 186, "/images/device (90).png" },
                    { 1270, 177, "/images/device (174).png" },
                    { 1271, 153, "/images/device (209).png" },
                    { 1272, 35, "/images/device (142).png" },
                    { 1273, 144, "/images/device (30).png" },
                    { 1274, 71, "/images/device (162).png" },
                    { 1275, 117, "/images/device (202).png" },
                    { 1276, 113, "/images/device (185).png" },
                    { 1277, 220, "/images/device (197).png" },
                    { 1278, 78, "/images/device (97).png" },
                    { 1279, 62, "/images/device (188).png" },
                    { 1280, 56, "/images/device (205).png" },
                    { 1281, 63, "/images/device (11).png" },
                    { 1282, 133, "/images/device (113).png" },
                    { 1283, 120, "/images/device (97).png" },
                    { 1284, 32, "/images/device (263).png" },
                    { 1285, 129, "/images/device (127).png" },
                    { 1286, 121, "/images/device (272).png" },
                    { 1287, 94, "/images/device (210).png" },
                    { 1288, 9, "/images/device (64).png" },
                    { 1289, 161, "/images/device (232).png" },
                    { 1290, 159, "/images/device (176).png" },
                    { 1291, 29, "/images/device (173).png" },
                    { 1292, 15, "/images/device (53).png" },
                    { 1293, 135, "/images/device (177).png" },
                    { 1294, 124, "/images/device (235).png" },
                    { 1295, 199, "/images/device (81).png" },
                    { 1296, 84, "/images/device (75).png" },
                    { 1297, 131, "/images/device (102).png" },
                    { 1298, 127, "/images/device (63).png" },
                    { 1299, 208, "/images/device (248).png" },
                    { 1300, 111, "/images/device (202).png" },
                    { 1301, 195, "/images/device (179).png" },
                    { 1302, 114, "/images/device (15).png" },
                    { 1303, 143, "/images/device (32).png" },
                    { 1304, 234, "/images/device (27).png" },
                    { 1305, 97, "/images/device (233).png" },
                    { 1306, 166, "/images/device (32).png" },
                    { 1307, 9, "/images/device (107).png" },
                    { 1308, 159, "/images/device (263).png" },
                    { 1309, 113, "/images/device (103).png" },
                    { 1310, 154, "/images/device (191).png" },
                    { 1311, 108, "/images/device (85).png" },
                    { 1312, 186, "/images/device (53).png" },
                    { 1313, 215, "/images/device (38).png" },
                    { 1314, 84, "/images/device (240).png" },
                    { 1315, 165, "/images/device (199).png" },
                    { 1316, 228, "/images/device (11).png" },
                    { 1317, 137, "/images/device (153).png" },
                    { 1318, 207, "/images/device (254).png" },
                    { 1319, 186, "/images/device (80).png" },
                    { 1320, 3, "/images/device (262).png" },
                    { 1321, 85, "/images/device (39).png" },
                    { 1322, 133, "/images/device (46).png" },
                    { 1323, 197, "/images/device (38).png" },
                    { 1324, 44, "/images/device (248).png" },
                    { 1325, 194, "/images/device (110).png" },
                    { 1326, 53, "/images/device (233).png" },
                    { 1327, 204, "/images/device (35).png" },
                    { 1328, 61, "/images/device (161).png" },
                    { 1329, 225, "/images/device (138).png" },
                    { 1330, 184, "/images/device (128).png" },
                    { 1331, 58, "/images/device (38).png" },
                    { 1332, 64, "/images/device (150).png" },
                    { 1333, 85, "/images/device (46).png" },
                    { 1334, 214, "/images/device (52).png" },
                    { 1335, 2, "/images/device (80).png" },
                    { 1336, 162, "/images/device (232).png" },
                    { 1337, 236, "/images/device (53).png" },
                    { 1338, 154, "/images/device (73).png" },
                    { 1339, 99, "/images/device (129).png" },
                    { 1340, 120, "/images/device (115).png" },
                    { 1341, 167, "/images/device (3).png" },
                    { 1342, 7, "/images/device (24).png" },
                    { 1343, 86, "/images/device (235).png" },
                    { 1344, 74, "/images/device (61).png" },
                    { 1345, 118, "/images/device (27).png" },
                    { 1346, 88, "/images/device (95).png" },
                    { 1347, 226, "/images/device (201).png" },
                    { 1348, 38, "/images/device (184).png" },
                    { 1349, 141, "/images/device (44).png" },
                    { 1350, 204, "/images/device (101).png" },
                    { 1351, 67, "/images/device (26).png" },
                    { 1352, 139, "/images/device (53).png" },
                    { 1353, 187, "/images/device (191).png" },
                    { 1354, 124, "/images/device (221).png" },
                    { 1355, 21, "/images/device (168).png" },
                    { 1356, 5, "/images/device (28).png" },
                    { 1357, 187, "/images/device (221).png" },
                    { 1358, 216, "/images/device (19).png" },
                    { 1359, 3, "/images/device (149).png" },
                    { 1360, 25, "/images/device (180).png" },
                    { 1361, 162, "/images/device (244).png" },
                    { 1362, 4, "/images/device (62).png" },
                    { 1363, 99, "/images/device (233).png" },
                    { 1364, 187, "/images/device (223).png" },
                    { 1365, 34, "/images/device (14).png" },
                    { 1366, 184, "/images/device (4).png" },
                    { 1367, 191, "/images/device (179).png" },
                    { 1368, 215, "/images/device (248).png" },
                    { 1369, 147, "/images/device (187).png" },
                    { 1370, 215, "/images/device (145).png" },
                    { 1371, 35, "/images/device (2).png" },
                    { 1372, 173, "/images/device (269).png" },
                    { 1373, 234, "/images/device (173).png" },
                    { 1374, 196, "/images/device (46).png" },
                    { 1375, 6, "/images/device (153).png" },
                    { 1376, 54, "/images/device (203).png" },
                    { 1377, 164, "/images/device (166).png" },
                    { 1378, 199, "/images/device (97).png" },
                    { 1379, 37, "/images/device (251).png" },
                    { 1380, 22, "/images/device (33).png" },
                    { 1381, 194, "/images/device (20).png" },
                    { 1382, 208, "/images/device (6).png" },
                    { 1383, 57, "/images/device (38).png" },
                    { 1384, 77, "/images/device (235).png" },
                    { 1385, 188, "/images/device (217).png" },
                    { 1386, 152, "/images/device (76).png" },
                    { 1387, 181, "/images/device (46).png" },
                    { 1388, 122, "/images/device (126).png" },
                    { 1389, 230, "/images/device (114).png" },
                    { 1390, 5, "/images/device (71).png" },
                    { 1391, 153, "/images/device (51).png" },
                    { 1392, 28, "/images/device (188).png" },
                    { 1393, 105, "/images/device (97).png" },
                    { 1394, 180, "/images/device (219).png" },
                    { 1395, 108, "/images/device (12).png" },
                    { 1396, 131, "/images/device (217).png" },
                    { 1397, 27, "/images/device (47).png" },
                    { 1398, 167, "/images/device (215).png" },
                    { 1399, 226, "/images/device (194).png" },
                    { 1400, 8, "/images/device (123).png" },
                    { 1401, 47, "/images/device (244).png" },
                    { 1402, 95, "/images/device (127).png" },
                    { 1403, 138, "/images/device (105).png" },
                    { 1404, 207, "/images/device (78).png" },
                    { 1405, 230, "/images/device (261).png" },
                    { 1406, 162, "/images/device (172).png" },
                    { 1407, 188, "/images/device (125).png" },
                    { 1408, 129, "/images/device (224).png" },
                    { 1409, 204, "/images/device (165).png" },
                    { 1410, 172, "/images/device (161).png" },
                    { 1411, 180, "/images/device (93).png" },
                    { 1412, 63, "/images/device (32).png" },
                    { 1413, 13, "/images/device (96).png" },
                    { 1414, 161, "/images/device (104).png" },
                    { 1415, 177, "/images/device (140).png" },
                    { 1416, 18, "/images/device (51).png" },
                    { 1417, 233, "/images/device (173).png" },
                    { 1418, 21, "/images/device (44).png" },
                    { 1419, 159, "/images/device (94).png" },
                    { 1420, 144, "/images/device (79).png" },
                    { 1421, 208, "/images/device (209).png" },
                    { 1422, 220, "/images/device (59).png" },
                    { 1423, 102, "/images/device (192).png" },
                    { 1424, 140, "/images/device (161).png" },
                    { 1425, 130, "/images/device (156).png" },
                    { 1426, 90, "/images/device (98).png" },
                    { 1427, 62, "/images/device (6).png" },
                    { 1428, 142, "/images/device (108).png" },
                    { 1429, 115, "/images/device (81).png" },
                    { 1430, 69, "/images/device (93).png" },
                    { 1431, 73, "/images/device (178).png" },
                    { 1432, 168, "/images/device (273).png" },
                    { 1433, 87, "/images/device (270).png" },
                    { 1434, 59, "/images/device (90).png" },
                    { 1435, 52, "/images/device (54).png" },
                    { 1436, 92, "/images/device (13).png" },
                    { 1437, 160, "/images/device (81).png" },
                    { 1438, 70, "/images/device (226).png" },
                    { 1439, 224, "/images/device (157).png" },
                    { 1440, 153, "/images/device (235).png" },
                    { 1441, 190, "/images/device (68).png" },
                    { 1442, 221, "/images/device (97).png" },
                    { 1443, 51, "/images/device (58).png" },
                    { 1444, 203, "/images/device (157).png" },
                    { 1445, 67, "/images/device (70).png" },
                    { 1446, 21, "/images/device (10).png" },
                    { 1447, 194, "/images/device (33).png" },
                    { 1448, 92, "/images/device (103).png" },
                    { 1449, 92, "/images/device (216).png" },
                    { 1450, 101, "/images/device (51).png" },
                    { 1451, 131, "/images/device (49).png" },
                    { 1452, 179, "/images/device (105).png" },
                    { 1453, 99, "/images/device (210).png" },
                    { 1454, 143, "/images/device (119).png" },
                    { 1455, 78, "/images/device (126).png" },
                    { 1456, 77, "/images/device (92).png" },
                    { 1457, 82, "/images/device (123).png" },
                    { 1458, 125, "/images/device (53).png" },
                    { 1459, 134, "/images/device (1).png" },
                    { 1460, 14, "/images/device (202).png" },
                    { 1461, 19, "/images/device (128).png" },
                    { 1462, 183, "/images/device (248).png" },
                    { 1463, 64, "/images/device (89).png" },
                    { 1464, 222, "/images/device (37).png" },
                    { 1465, 67, "/images/device (247).png" },
                    { 1466, 152, "/images/device (32).png" },
                    { 1467, 114, "/images/device (86).png" },
                    { 1468, 101, "/images/device (201).png" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "Categories",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211");

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "OrderStatusId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "ProductImage",
                keyColumn: "ProductImageId",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "ShopCategories",
                keyColumn: "ShopCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShopCategories",
                keyColumn: "ShopCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ShopCategories",
                keyColumn: "ShopCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ShopCategories",
                keyColumn: "ShopCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "VoucherCategory",
                keyColumn: "VoucherCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VoucherCategory",
                keyColumn: "VoucherCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VoucherCategory",
                keyColumn: "VoucherCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VoucherCategory",
                keyColumn: "VoucherCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ProductCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ProductCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ProductCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ProductCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ProductCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ProductCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ProductCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ProductCategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ShopCategories",
                keyColumn: "ShopCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShopCategories",
                keyColumn: "ShopCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShopCategories",
                keyColumn: "ShopCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShopCategories",
                keyColumn: "ShopCategoryId",
                keyValue: 8);

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

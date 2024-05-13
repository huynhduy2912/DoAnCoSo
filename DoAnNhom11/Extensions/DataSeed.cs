using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using DoAnNhom11.Models;

namespace DoAnNhom11.Extensions
{

    public static class DataSeed
    {
        public static string GenerateRandomString(Random random, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] buffer = new char[length];
            for (int i = 0; i < length; i++)
            {
                buffer[i] = chars[random.Next(chars.Length)];
            }
            return new string(buffer);
        }
        public static void Seed(this ModelBuilder modelBuilder)
        {
            int count = 1;
            Random random = new Random();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "ADMIN".ToUpper() },
                new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "Customer", NormalizedName = "CUSTOMER".ToUpper() });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                ProductCategoryId = 1,
                TenLoai = "Laptop"
            },
                new ProductCategory
                {
                    ProductCategoryId = 2,
                    TenLoai = "Điện Thoại"
                }, new ProductCategory
                {
                    ProductCategoryId = 3,
                    TenLoai = "Máy Tính Bảng"
                }, new ProductCategory
                {
                    ProductCategoryId = 4,
                    TenLoai = "Đồng Hồ"
                }, new ProductCategory
                {
                    ProductCategoryId = 5,
                    TenLoai = "Phụ Kiện"
                }, new ProductCategory
                {
                    ProductCategoryId = 6,
                    TenLoai = "Sim"
                }, new ProductCategory
                {
                    ProductCategoryId = 7,
                    TenLoai = "Bàn phím"
                }, new ProductCategory
                {
                    ProductCategoryId = 8,
                    TenLoai = "Tai Nghe"
                });
            modelBuilder.Entity<Payment>().HasData(new Payment
            {
                PaymentId = 1,
                TenLoai = "Trực Tiếp"
            },
                new Payment
                {
                    PaymentId = 2,
                    TenLoai = "Online"
                });
            modelBuilder.Entity<ShopCategory>().HasData(new ShopCategory
            {
                ShopCategoryId = 1,
                TenLoai = "Công Nghệ"
            },
                new ShopCategory
                {
                    ShopCategoryId = 2,
                    TenLoai = "Thời Trang"
                }, new ShopCategory
                {
                    ShopCategoryId = 3,
                    TenLoai = "Trang Sức"
                }, new ShopCategory
                {
                    ShopCategoryId = 4,
                    TenLoai = "Thực Phẩm"
                }, new ShopCategory
                {
                    ShopCategoryId = 5,
                    TenLoai = "Sách"
                }, new ShopCategory
                {
                    ShopCategoryId = 6,
                    TenLoai = "Làm Đẹp"
                }, new ShopCategory
                {
                    ShopCategoryId = 7,
                    TenLoai = "Đồ Chơi"
                }, new ShopCategory
                {
                    ShopCategoryId = 8,
                    TenLoai = "Đồ Gia Dụng"
                });

            modelBuilder.Entity<Brand>().HasData(new Brand
            {
                BrandId = 1,
                TenNhanHieu = "XiaoMi"
            },
            new Brand
            {
                BrandId = 2,
                TenNhanHieu = "Apple"
            }, new Brand
            {
                BrandId = 3,
                TenNhanHieu = "Samsung"
            }, new Brand
            {
                BrandId = 4,
                TenNhanHieu = "Dell"
            }, new Brand
            {
                BrandId = 5,
                TenNhanHieu = "HP"
            }, new Brand
            {
                BrandId = 6,
                TenNhanHieu = "Nokia"
            }, new Brand
            {
                BrandId = 7,
                TenNhanHieu = "ASUS"
            }, new Brand
            {
                BrandId = 8,
                TenNhanHieu = "MSI"
            });

            modelBuilder.Entity<VoucherCategory>().HasData(new VoucherCategory
            {
                VoucherCategoryId = 1,
                TenLoai = "GIAMGIAXIAOMI"
            },
            new VoucherCategory
            {
                VoucherCategoryId = 2,
                TenLoai = "GIAMGIADELL"
            },
            new VoucherCategory
            {
                VoucherCategoryId = 3,
                TenLoai = "GIAMGIALAPTOP"
            },
            new VoucherCategory
            {
                VoucherCategoryId = 4,
                TenLoai = "GIAMGIAMAYTINHBANG"
            });
            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus
            {
                OrderStatusId = 1,
                TenTrangThai = "Chờ Xác Nhận Đơn Hàng"
            },
            new OrderStatus
            {
                OrderStatusId = 2,
                TenTrangThai = "Đã Xác Nhận Đơn Hàng"
            },
            new OrderStatus
            {
                OrderStatusId = 3,
                TenTrangThai = "Đang Giao Hàng"
            }
            ,
            new OrderStatus
            {
                OrderStatusId = 4,
                TenTrangThai = "Đã Giao Hàng"
            }
            ,
            new OrderStatus
            {
                OrderStatusId = 5,
                TenTrangThai = "Đã Đã Thanh Toán Và Nhận Hàng"
            },
            new OrderStatus
            {
                OrderStatusId = 6,
                TenTrangThai = "Đã Hủy Đơn"
            }
           );

            modelBuilder.Entity<Voucher>().HasData(new Voucher
            {
                VoucherId = 1,
                VoucherCode = "GIAMGIA1",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 20,
                VoucherCategoryId = 1,
            },
            new Voucher
            {
                VoucherId = 2,
                VoucherCode = "GIAMGIA2",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 10,
                VoucherCategoryId = 2,
            },
            new Voucher
            {
                VoucherId = 3,
                VoucherCode = "GIAMGIA3",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 15,
                VoucherCategoryId = 3,
            },
            new Voucher
            {
                VoucherId = 4,
                VoucherCode = "GIAMGIA4",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 12,
                VoucherCategoryId = 4,
            }
            );

            modelBuilder.Entity<Shop>().HasData(new Shop
            {
                ShopId = count,
                ShopCategoryId = random.Next(1, 9),
                TenCuaHang = "Shop:" + GenerateRandomString(random, 10) + (count++),
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275) + ").png",
                AnhBia = "/images/device (" + random.Next(1, 275) + ").png",
                NgayTao = DateTime.Now,
                DiaChi = GenerateRandomString(random, 10)+","+ GenerateRandomString(random, 10) + ","+GenerateRandomString(random, 10),
                LienHe= GenerateRandomString(random, 10)

            },new Shop
            {
                ShopId = count,
                ShopCategoryId = random.Next(1, 9),
                TenCuaHang = "Shop" + GenerateRandomString(random, 10) + (count++),
                MoTa = "Mô tả mẫu của cửa hàng" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275) + ").png",
                AnhBia = "/images/device (" + random.Next(1, 275) + ").png",
                NgayTao = DateTime.Now,
                DiaChi = GenerateRandomString(random, 10)+","+ GenerateRandomString(random, 10) + ","+GenerateRandomString(random, 10),
                LienHe= GenerateRandomString(random, 10)

            },new Shop
            {
                ShopId = count,
                ShopCategoryId = random.Next(1, 9),
                TenCuaHang = "Shop:" + GenerateRandomString(random, 10) + (count++),
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275) + ").png",
                AnhBia = "/images/device (" + random.Next(1, 275) + ").png",
                NgayTao = DateTime.Now,
                DiaChi = GenerateRandomString(random, 10)+","+ GenerateRandomString(random, 10) + ","+GenerateRandomString(random, 10),
                LienHe= GenerateRandomString(random, 10)

            },new Shop
            {
                ShopId = count,
                ShopCategoryId = random.Next(1, 9),
                TenCuaHang = "Shop:" + GenerateRandomString(random, 10) + (count++),
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275) + ").png",
                AnhBia = "/images/device (" + random.Next(1, 275) + ").png",
                NgayTao = DateTime.Now,
                DiaChi = GenerateRandomString(random, 10)+","+ GenerateRandomString(random, 10) + ","+GenerateRandomString(random, 10),
                LienHe= GenerateRandomString(random, 10)

            },new Shop
            {
                ShopId = count,
                ShopCategoryId = random.Next(1, 9),
                TenCuaHang = "Shop:" + GenerateRandomString(random, 10) + (count++),
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275) + ").png",
                AnhBia = "/images/device (" + random.Next(1, 275) + ").png",
                NgayTao = DateTime.Now,
                DiaChi = GenerateRandomString(random, 10)+","+ GenerateRandomString(random, 10) + ","+GenerateRandomString(random, 10),
                LienHe= GenerateRandomString(random, 10)

            },new Shop
            {
                ShopId = count,
                ShopCategoryId = random.Next(1, 9),
                TenCuaHang = "Shop:" + GenerateRandomString(random, 10) + (count++),
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275) + ").png",
                AnhBia = "/images/device (" + random.Next(1, 275) + ").png",
                NgayTao = DateTime.Now,
                DiaChi = GenerateRandomString(random, 10)+","+ GenerateRandomString(random, 10) + ","+GenerateRandomString(random, 10),
                LienHe= GenerateRandomString(random, 10)

            },new Shop
            {
                ShopId = count,
                ShopCategoryId = random.Next(1, 9),
                TenCuaHang = "Shop:" + GenerateRandomString(random, 10) + (count++),
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275) + ").png",
                AnhBia = "/images/device (" + random.Next(1, 275) + ").png",
                NgayTao = DateTime.Now,
                DiaChi = GenerateRandomString(random, 10)+","+ GenerateRandomString(random, 10) + ","+GenerateRandomString(random, 10),
                LienHe= GenerateRandomString(random, 10)

            },new Shop
            {
                ShopId = count,
                ShopCategoryId = random.Next(1, 9),
                TenCuaHang = "Shop:" + GenerateRandomString(random, 10) + (count++),
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275) + ").png",
                AnhBia = "/images/device (" + random.Next(1, 275) + ").png",
                NgayTao = DateTime.Now,
                DiaChi = GenerateRandomString(random, 10)+","+ GenerateRandomString(random, 10) + ","+GenerateRandomString(random, 10),
                LienHe= GenerateRandomString(random, 10)

            });
            count = 1;
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:"+ (random.Next(1, 5) * 100)+"GB Man hinh :"+ (random.Next(1, 5) * 4)+"inch",
                MoTa = "Mô tả mẫu của sản phẩm"+count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5)* 100,
                GiaNhap = random.Next(1, 50)*1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam= random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 9),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),
            }
            );
            count = 1;
            modelBuilder.Entity<ProductImage>().HasData(new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 44) + ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            },
            new ProductImage
            {
                ProductImageId = count++,
                ProductId = random.Next(1, 237),
                Url= "/images/device (" + random.Next(1, 275)+ ").png"
            }

            ) ;
        }
    }
}

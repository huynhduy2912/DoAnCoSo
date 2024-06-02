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
                new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "Customer", NormalizedName = "CUSTOMER".ToUpper() },
                new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7212", Name = "ShopOwner", NormalizedName = "SHOPOWNER".ToUpper() },
                new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7213", Name = "ShopStaff", NormalizedName = "SHOPSTAFF".ToUpper() }
                );
            
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                ProductCategoryId = count++,AnhDaiDien="/categoryImg/balotuivi.png",
                TenLoai = "Balo & Túi Ví",
            },
                new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/dienthoai.png",
                    TenLoai = "Điện Thoại"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/dientu.png",
                    TenLoai = "Điện tử"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/doan.png",
                    TenLoai = "Thực phẩm"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/dobep.png",
                    TenLoai = "Đồ bếp"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/dochoi.png",
                    TenLoai = "Đồ chơi"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/dongho.png",
                    TenLoai = "Đồng hồ"
                },new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/giadung.png",
                    TenLoai = "Đồ gia dụng"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/giaydepnam.png",
                    TenLoai = "Giày dép nam"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/giaydepnu.png",
                    TenLoai = "Giày dép nữ"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/mayanh.png",
                    TenLoai = "Máy Ảnh"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/maytinh.png",
                    TenLoai = "Máy tính"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/noitro.png",
                    TenLoai = "Đồ nội trợ"
                },new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/phuongtien.png",
                    TenLoai = "Phương tiện"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/sacdep.png",
                    TenLoai = "Sắc đẹp"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/sach.png",
                    TenLoai = "Sách"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/thethao.png",
                    TenLoai = "Thể thao"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/thietbi.png",
                    TenLoai = "Thiết bị"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/thoitrangnam.png",
                    TenLoai = "Thời trang nam"
                },new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/thoitrangnu.png",
                    TenLoai = "Thời trang nữ"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/thoitrangtreem.png",
                    TenLoai = "Thời trang trẻ em"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/thucung'.png",
                    TenLoai = "Thú cưng"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/trangsuc.png",
                    TenLoai = "Trang sức"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/treem.png",
                    TenLoai = "Trẻ em"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/tuivinu.png",
                    TenLoai = "Túi Ví Nữ"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/voucherdichvu.png",
                    TenLoai = "Dịch vụ"
                }, new ProductCategory
                {
                    ProductCategoryId = count++,AnhDaiDien="/categoryImg/yte.png",
                    TenLoai = "Y tế"
                });
            count = 1;
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
                TenLoai = "Tạp Hóa"
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
                }, new ShopCategory
                {
                    ShopCategoryId = 9,
                    TenLoai = "công nghệ"
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
            },
            new OrderStatus
            {
                OrderStatusId = 7,
                TenTrangThai = "Yêu cầu trả hàng"
            },
            new OrderStatus
            {
                OrderStatusId = 8,
                TenTrangThai = "Đã xác nhận yêu cầu trả hàng"
            }
           );

            modelBuilder.Entity<Voucher>().HasData(new Voucher
            {
                VoucherId = 1,
                VoucherCode = "mặc định",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 0,
                VoucherCategoryId = 1,
                DonToiThieu = -1,
                GiamToiDa = -1,
            },
            new Voucher
            {
                VoucherId = 2,
                VoucherCode = "GIAMGIA2",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 10,
                VoucherCategoryId = 2,
                DonToiThieu = 3000000,
                GiamToiDa= 15000,
            },
            new Voucher
            {
                VoucherId = 3,
                VoucherCode = "GIAMGIA3",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 15,
                VoucherCategoryId = 3,
                DonToiThieu = 10000000,
                GiamToiDa = 50000,
            },
            new Voucher
            {
                VoucherId = 4,
                VoucherCode = "GIAMGIA4",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 12,
                VoucherCategoryId = 4,
                DonToiThieu = 8000000,
                GiamToiDa = 100000,
            },
            new Voucher
            {
                VoucherId = 5,
                VoucherCode = "GIAMGIA5",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 7,
                VoucherCategoryId = 4,
                DonToiThieu = 5000000,
                GiamToiDa = 20000,
            },
            new Voucher
            {
                VoucherId = 5,
                VoucherCode = "GIAMGIA5",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 8,
                VoucherCategoryId = 4,
                DonToiThieu = -1,
                GiamToiDa = -1,
            },
            new Voucher
            {
                VoucherId = 5,
                VoucherCode = "GIAMGIA5",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 15,
                VoucherCategoryId = 4,
                DonToiThieu = 12000000,
                GiamToiDa = -1,
            },
            new Voucher
            {
                VoucherId = 5,
                VoucherCode = "GIAMGIA5",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 21,
                VoucherCategoryId = 4,
                DonToiThieu = -1,
                GiamToiDa = 40000,
            },
            new Voucher
            {
                VoucherId = 5,
                VoucherCode = "GIAMGIA5",
                SoLuongCon = 100,
                NgayHetHan = DateTime.Now.AddMonths(2),
                PhanTramGiam = 16,
                VoucherCategoryId = 4,
                DonToiThieu = 12000000,
                GiamToiDa = 1000000,
            }
            );
            count = 1;
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
                ProductCategoryId = random.Next(1, 28),
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
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
                
                
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            },
            new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
            }, new Product
            {
                ProductId = count,ShopId = random.Next(1, 9),
                ProductCategoryId = random.Next(1, 28),
                BrandId= random.Next(1, 9),
                ThongSo = "RAM:" + (random.Next(1, 32) ) +"Memory:"+random.Next(32, 512)+ "GB Man hinh :" + (random.Next(1, 5) * 4) + "inch",
                MoTa = "Mô tả mẫu của sản phẩm" + count,
                AnhDaiDien = "/images/device (" + random.Next(1, 275)+ ").png",
                TenSp = GenerateRandomString(random, 10) + (count++),
                SoLuongCon = random.Next(1, 5) * 100,
                GiaNhap = random.Next(1, 50) * 1000000,
                GiaBan = random.Next(1, 50) * 1000000,
                PhanTramGiam = random.Next(5, 40),DaAn=false,
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
            }

            ) ;
        }
    }
}

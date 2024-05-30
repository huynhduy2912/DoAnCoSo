using DoAnNhom11.Extensions;
using DoAnNhom11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DoAnNhom11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RandomProductService _randomProductService;

        public HomeController(ApplicationDbContext context, RandomProductService randomProductService)
        {
            _context = context;
            _randomProductService = randomProductService;
        }
        public async Task<IActionResult> Index()
        {
            DateTime today = DateTime.Today;

            // Kiểm tra xem đã có danh sách sản phẩm ngẫu nhiên cho ngày hôm nay chưa
            if (_randomProductService.GetLastUpdate() != today)
            {
                // Lấy tổng số lượng sản phẩm
                int totalProducts = await _context.Products.Where(p => p.DaAn == false && p.SoLuongCon > 0).CountAsync();

                // Tạo danh sách các chỉ số ngẫu nhiên không trùng lặp
                Random rnd = new Random();
                HashSet<int> randomIndices = new HashSet<int>();

                while (randomIndices.Count < 12)
                {
                    randomIndices.Add(rnd.Next(totalProducts));
                }

                // Lấy sản phẩm dựa trên các chỉ số ngẫu nhiên
                List<Product> randomProducts = new List<Product>();

                foreach (int index in randomIndices)
                {
                    var product = await _context.Products.Where(p=>p.DaAn==false&&p.SoLuongCon>0).Skip(index).FirstOrDefaultAsync();
                    if (product != null)
                    {
                        randomProducts.Add(product);
                    }
                }

                // Lưu kết quả ngẫu nhiên vào service
                _randomProductService.SetRandomProducts(randomProducts);
            }

            // Lấy danh sách sản phẩm ngẫu nhiên từ service
            var recommentProduct = _randomProductService.GetRandomProducts();
            List<Product> listItemShow = new List<Product>();
            listItemShow.Add(_context.Products.Where(p=>p.ProductId==33).FirstOrDefault());
            listItemShow.Add(_context.Products.Where(p => p.ProductId == 34).FirstOrDefault());
            listItemShow.Add(_context.Products.Where(p => p.ProductId == 35).FirstOrDefault());
            ViewBag.categories = await _context.Categories.ToListAsync();
            ViewBag.listItemShow=listItemShow;
            return View(recommentProduct);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

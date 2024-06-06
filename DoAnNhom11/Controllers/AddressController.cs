using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DoAnNhom11.Models;

namespace DoAnNhom11.Controllers
{
    public class AddressController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public AddressController(IWebHostEnvironment env)
        {
            _env = env;
        }        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetDistricts(string provinceId)
        {
            var districts = ReadJsonFile<List<District>>("json/districts.json");   
            var listShow = districts.Where(p=>p.parent_code==provinceId).ToList();         
            return Json(listShow);
        }
        public IActionResult GetProvinces()
        {
            var provinces = ReadJsonFile<List<Province>>("json/provinces.json");
            return Json(provinces);
        }

        public IActionResult GetWards(string districtId)
        {
            
            var wards = ReadJsonFile<List<Ward>>("json/wards.json");

            var listShow = wards.Where(p => p.parent_code == districtId).ToList();

            
            return Json(listShow);
        }

        private T ReadJsonFile<T>(string filePath)
        {
            var fullPath = Path.Combine(_env.WebRootPath, filePath);
            var jsonData = System.IO.File.ReadAllText(fullPath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
    }




}

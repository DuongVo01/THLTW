using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VoTrungDuong_2180604816.Models;
using VoTrungDuong_2180604816.Repository;

namespace VoTrungDuong_2180604816.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //Hien thi danh sach san pham
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }     
    }
}

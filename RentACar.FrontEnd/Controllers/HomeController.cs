using Microsoft.AspNetCore.Mvc;
using RentACar.FrontEnd.ApiServices.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarApiService _carApiService;
        public HomeController(ICarApiService carApiService)
        {
            _carApiService = carApiService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _carApiService.GetAllAsync();
            return View(data);
        }
    }
}

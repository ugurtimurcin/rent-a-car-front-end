using Microsoft.AspNetCore.Mvc;
using RentACar.FrontEnd.ApiServices.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.FrontEnd.ViewComponents
{
    public class Wrapper : ViewComponent
    {
        private readonly IBrandApiService _brandApiService;
        public Wrapper(IBrandApiService brandApiService)
        {
            _brandApiService = brandApiService;
        }
        public IViewComponentResult Invoke()
        {

            return View(_brandApiService.GetAllAsync().Result);
        }
    }
}

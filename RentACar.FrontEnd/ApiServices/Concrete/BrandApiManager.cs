using Newtonsoft.Json;
using RentACar.FrontEnd.ApiServices.Abstract;
using RentACar.FrontEnd.Models.Brand;
using RentACar.FrontEnd.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RentACar.FrontEnd.ApiServices.Concrete
{
    public class BrandApiManager : IBrandApiService
    {
        private readonly HttpClient _httpClient;
        public BrandApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:53224/api/brands/");
        }
        public async Task<List<BrandListModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("getall");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BrandListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}

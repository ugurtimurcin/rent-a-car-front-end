using Newtonsoft.Json;
using RentACar.FrontEnd.ApiServices.Abstract;
using RentACar.FrontEnd.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RentACar.FrontEnd.ApiServices.Concrete
{
    public class CarApiManager : ICarApiService
    {
        private readonly HttpClient _httpClient;
        public CarApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:53224/api/cars/");
        }
        public async Task<List<CarListModel>> GetAllAsync()
        {
            var responseMessage = await _httpClient.GetAsync("getallcarsdetail");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CarListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}

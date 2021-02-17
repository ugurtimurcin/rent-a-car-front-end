using RentACar.FrontEnd.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.FrontEnd.ApiServices.Abstract
{
    public interface ICarApiService
    {
        Task<List<CarListModel>> GetAllAsync();
    }
}

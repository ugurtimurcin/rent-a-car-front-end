using RentACar.FrontEnd.Models.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.FrontEnd.ApiServices.Abstract
{
    public interface IBrandApiService
    {
        Task<List<BrandListModel>> GetAllAsync();
    }
}

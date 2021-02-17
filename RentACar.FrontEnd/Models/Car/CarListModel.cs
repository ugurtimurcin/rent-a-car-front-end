using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.FrontEnd.Models.Car
{
    public class CarListModel
    {
        public int Id { get; set; }
        public int ModelYear { get; set; }
        public string CarImage { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }
}

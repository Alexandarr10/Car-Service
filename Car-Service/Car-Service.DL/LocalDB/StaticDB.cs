using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Service.Models.Dto;

namespace Car_Service.DL.LocalDB
{
    internal class StaticDB
    {
        public static List<Car> Cars = new List<Car>()
        {
            new Car() { Id = 1, Model = "Toyota Camry", Year = 2020 },
            new Car() { Id = 2, Model = "Honda Accord", Year = 2019 },
            new Car() { Id = 3, Model = "Ford Mustang", Year = 2021 },
        };
    }
}

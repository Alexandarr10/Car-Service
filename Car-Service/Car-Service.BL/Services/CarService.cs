using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Service.BL.Interfaces;
using Car_Service.DL.Interfaces;
using Car_Service.Models.Dto;

namespace Car_Service.BL.Services
{
    internal class CarService : ICarService
    {

        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public void deleteCar(int id)
        {
            _carRepository.deleteCar(id);
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }
    }
}

using Car_Service.DL.Interfaces;
using Car_Service.DL.LocalDB;
using Car_Service.Models.Dto;

namespace Car_Service.DL.Repositories
{
    internal class CarLocalRepository : ICarRepository
    {
        public void AddCar(Car car)
        {
            StaticDB.Cars.Add(car);
        }

        public void deleteCar(int id)
        {
            StaticDB.Cars.RemoveAll(c => c.Id == id);
        }

        public List<Car> GetAllCars()
        {
            return StaticDB.Cars;
        }
    }
}

using Car_Service.Models.Dto;

namespace Car_Service.DL.Interfaces
{
    public interface ICarRepository
    {
        void AddCar(Car car);

        void deleteCar(int id);

        List<Car> GetAllCars();
    }
}

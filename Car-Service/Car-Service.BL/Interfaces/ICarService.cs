using Car_Service.Models.Dto;

namespace Car_Service.BL.Interfaces
{
    public interface ICarService
    {
        void AddCar(Car car);

        void deleteCar(int id);

        List<Car> GetAllCars();
    }
}

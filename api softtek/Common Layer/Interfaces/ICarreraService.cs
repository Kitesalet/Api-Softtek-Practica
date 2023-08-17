using api_softtek.Common_Layer.DTOs;

namespace api_softtek.Common_Layer.Interfaces
{
    public interface ICarreraService
    {

        public List<CarreraDto> GetAllCarreras();

        public CarreraDto GetCarreraById(int id);

        public int CreateCarrera(CarreraDto carrera);

        public CarreraDto UpdateCarrera(CarreraDto carrera);

        public bool DeleteCarrera(int id);


    }
}

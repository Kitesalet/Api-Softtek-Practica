using api_softtek.Common_Layer.DTOs;

namespace api_softtek.Common_Layer.Interfaces
{
    public interface ICarreraService
    {

        public List<CarreraDto> GetAllCarreras();

        public CarreraDto GetCarreraById(int id);

        public int CreateCarrera(CarreraDto estudiante);

        public CarreraDto UpdateCarrera(CarreraDto estudiante);

        public bool DeleteCarrera(int id);


    }
}

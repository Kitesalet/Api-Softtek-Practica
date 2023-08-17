using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using api_softtek.Common_Layer.Models;
using AutoMapper;

namespace api_softtek.Busissness_Layer
{
    public class CarreraService : ICarreraService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Carrera> _repository;
        private readonly IGenericRepository<Estudiante> _repoEst;

        public CarreraService(IMapper mapper, IGenericRepository<Carrera> repository, IGenericRepository<Estudiante> repoEst)
        {

            _mapper = mapper;
            _repository = repository;
            _repoEst = repoEst;

        }

        public int CreateCarrera(CarreraDto carrera)
        {
            
            var x = _mapper.Map<Carrera>(carrera);

            _repository.Create(x);

            return x.Id;

        }

        public bool DeleteCarrera(int id)
        {

            _repository.Delete(id);

            return true;

        }

        public List<CarreraDto> GetAllCarreras()
        {
            
            var x = _repository.GetAll();

            var mapeadas = _mapper.Map<List<CarreraDto>>(x);

            foreach(var carrera in mapeadas)
            {

                var estId = _repoEst.ListById(e => e.Id == carrera.Id).Select(e => e.Id).ToList();

                carrera.EstudiantesId = estId;

            }

            return mapeadas;

        }

        public CarreraDto GetCarreraById(int id)
        {

            var x = _repository.GetById(id);

            var est = _repoEst.ListById(e => e.Id == id);

            var estIds = est.Select(e => e.Id).ToList();

            var mapeado = _mapper.Map<CarreraDto>(x);

            mapeado.EstudiantesId = estIds;

            return mapeado;


        }

        public CarreraDto UpdateCarrera(CarreraDto carrera)
        {

            var x = _mapper.Map<Carrera>(carrera);

            _repository.Update(x);

            return carrera;

        }
    }
}

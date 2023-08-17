using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using api_softtek.Common_Layer.Models;
using AutoMapper;

namespace api_softtek.Busissness_Layer
{
    public class EstudianteService : IEstudianteService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Estudiante> _repository;

        public EstudianteService(IMapper mapper, IGenericRepository<Estudiante> repository)
        {

            _mapper = mapper;
            _repository = repository;



        }
        public int CreateEstudiante(CarreraDto estudiante)
        {
           
            var est = _mapper.Map<Estudiante>(estudiante);   

            return _repository.Create(est);


        }

        public bool DeleteEstudiante(int id)
        {

            return _repository.Delete(id);

        }

        public List<CarreraDto> GetAllEstudiantes()
        {
            var est = _repository.GetAll();

            var newEst = _mapper.Map<List<CarreraDto>>(est);

            return newEst;


        }

        public CarreraDto GetEstudianteById(int id)
        {
            var est = _repository.GetById(id);

            return _mapper.Map<CarreraDto>(est);
        }

        public CarreraDto UpdateEstudiante(CarreraDto estudiante)
        {

            var est = _mapper.Map<Estudiante>(estudiante);
            

            _repository.Update(est);

            return estudiante;

        }
    }
}

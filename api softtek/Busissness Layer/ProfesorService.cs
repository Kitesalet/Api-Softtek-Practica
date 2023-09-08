using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using api_softtek.Common_Layer.Models;
using AutoMapper;

namespace api_softtek.Busissness_Layer
{
    public class ProfesorService : IProfesorService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Profesor> _repository;

        public ProfesorService(IMapper mapper, IGenericRepository<Profesor> repository)
        {

            _mapper = mapper;
            _repository = repository;
            
        }

    


        public int CreateProfesor(ProfesorDto profesor)
        {
            var mat = _mapper.Map<Profesor>(profesor);

            var x = _repository.Create(mat);


            return x;

        }

        public bool DeleteProfesor(int id)
        {
            return _repository.Delete(id);
        }

        public List<ProfesorDto> GetAllProfesores()
        {


            var x = _repository.GetAll();

            var mapped = _mapper.Map<List<ProfesorDto>>(x);

            return mapped;

        }

        public ProfesorDto GetProfesorById(int id)
        {

            var x = _repository.GetById(id);

            return _mapper.Map<ProfesorDto>(x);

        }

        public ProfesorDto UpdateProfesor(ProfesorDto profesor)
        {
            var x = _mapper.Map<Profesor>(profesor);

            _repository.Update(x);

            return profesor;
        }
    }
}

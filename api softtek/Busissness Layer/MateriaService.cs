using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using api_softtek.Common_Layer.Models;
using AutoMapper;

namespace api_softtek.Busissness_Layer
{
    public class MateriaService : IMateriaService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Materia> _repository;

        public MateriaService(IMapper mapper, IGenericRepository<Materia> repository)
        {

            _mapper = mapper;
            _repository = repository;

        }


        public int CreateMateria(MateriaDto materia)
        {
            var mat = _mapper.Map<Materia>(materia);

            var x = _repository.Create(mat);


            return x;

        }

        public bool DeleteMateria(int id)
        {


           return _repository.Delete(id);



        }

        public List<MateriaDto> GetAllMaterias()
        {
            
            var x = _repository.GetAll();

            var mapped = _mapper.Map<List<MateriaDto>>(x);

            return mapped;

        }

        public MateriaDto GetMateriaById(int id)
        {
            var x = _repository.GetById(id);

            return _mapper.Map<MateriaDto>(x);  


        }

        public MateriaDto UpdateMateria(MateriaDto materia)
        {

            var x = _mapper.Map<Materia>(materia);

            _repository.Update(x);

            return materia;


        }
    }
}

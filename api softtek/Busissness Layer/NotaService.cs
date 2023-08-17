using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using api_softtek.Common_Layer.Models;
using AutoMapper;
using System.Security.Principal;

namespace api_softtek.Busissness_Layer
{
    public class NotaService : INotaService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Nota> _repository;

        public NotaService(IMapper mapper, IGenericRepository<Nota> repository)
        {

            _mapper = mapper;
            _repository = repository;

        }


        public int CreateNota(NotaDto nota)
        {

            var x = _mapper.Map<Nota>(nota);

            return _repository.Create(x);


        }

        public bool DeleteNota(int id)
        {
            return _repository.Delete(id);
        }

        public List<NotaDto> GetAllNotas()
        {
            
            var x = _repository.GetAll();

            var mapped = _mapper.Map<List<NotaDto>>(x);

            return mapped;

        }

        public NotaDto GetNotaById(int id)
        {
           
            var x = _repository.GetById(id);

            var mapped = _mapper.Map<NotaDto>(x);

            return mapped;

        }

        public NotaDto UpdateNota(NotaDto materia)
        {

            var x = _mapper.Map<Nota>(materia);

            _repository.Update(x);

            return materia;
        }
    }
}

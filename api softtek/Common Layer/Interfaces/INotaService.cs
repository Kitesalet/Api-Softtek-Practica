using api_softtek.Common_Layer.DTOs;

namespace api_softtek.Common_Layer.Interfaces
{
    public interface INotaService
    {

        public List<NotaDto> GetAllNotas();

        public NotaDto GetNotaById(int id);

        public int CreateNota(NotaDto nota);

        public NotaDto UpdateNota(NotaDto materia);

        public bool DeleteNota(int id);



    }
}

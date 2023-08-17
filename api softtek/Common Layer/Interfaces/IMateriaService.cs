using api_softtek.Common_Layer.DTOs;
using api_softtek.Top_Layer.Controllers;

namespace api_softtek.Common_Layer.Interfaces
{
    public interface IMateriaService
    {



        public List<MateriaDto> GetAllMaterias();

        public MateriaDto GetMateriaById(int id);

        public int CreateMateria(MateriaDto materia);

        public MateriaDto UpdateMateria(MateriaDto materia);

        public bool DeleteMateria(int id);



    }
}

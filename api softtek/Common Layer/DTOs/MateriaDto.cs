using api_softtek.Common_Layer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_softtek.Common_Layer.DTOs
{
    public class MateriaDto : BaseEntityDTO
    {

        public string Nombre { get; set; }

        public int CarreraId { get; set; }

        public List<int> ProfesoresId { get; set; }

    }
}

using api_softtek.Common_Layer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_softtek.Common_Layer.DTOs
{
    public class NotaDto : BaseEntityDTO
    {

        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }
        public int Calificacion { get; set; }

    }
}

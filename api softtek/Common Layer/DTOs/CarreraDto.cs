using api_softtek.Common_Layer.Models;

namespace api_softtek.Common_Layer.DTOs
{
    public class CarreraDto : BaseEntityDTO
    {

        public string Nombre { get; set; }

        public List<int> MateriasId { get; set; }

        public List<int> EstudiantesId { get; set; }

    }
}

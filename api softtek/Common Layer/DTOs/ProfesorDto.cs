using api_softtek.Common_Layer.Models;

namespace api_softtek.Common_Layer.DTOs
{
    public class ProfesorDto : PersonaDto
    {

        public List<int> MateriasId { get; set; }

    }
}

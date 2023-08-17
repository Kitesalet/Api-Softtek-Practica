namespace api_softtek.Common_Layer.DTOs
{
    public class PersonaDto : BaseEntityDTO
    {

        public int Dni { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }
    }
}

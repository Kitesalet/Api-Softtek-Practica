using api_softtek.DAL;
using System.ComponentModel.DataAnnotations;

namespace api_softtek.Common_Layer.Models
{
    public abstract class Persona : BaseEntity
    {
        
        public int Dni { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }    

        public string Direccion { get; set; }   

    }
}

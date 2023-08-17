using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Models;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;


namespace api_softtek.Common_Layer.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            
            CreateMap<Carrera, CarreraDto>().ReverseMap();
            CreateMap<Estudiante, CarreraDto>().ReverseMap();    
            CreateMap<Materia, MateriaDto>().ReverseMap();
            CreateMap<Nota,NotaDto>().ReverseMap();
            CreateMap<Profesor,ProfesorDto>().ReverseMap();


        }


    }
}

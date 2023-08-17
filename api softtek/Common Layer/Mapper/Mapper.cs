using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Models;
using api_softtek.Top_Layer.Controllers;
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
            CreateMap<Estudiante, EstudianteDto>().ReverseMap();    
            CreateMap<Materia, MateriaDto>().ReverseMap();
            CreateMap<Nota,NotaDto>().ReverseMap();
            CreateMap<Profesor,ProfesorDto>().ReverseMap();


        }


    }
}

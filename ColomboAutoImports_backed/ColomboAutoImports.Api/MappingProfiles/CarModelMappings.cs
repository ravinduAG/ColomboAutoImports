using AutoMapper;
using ColomboAutoImports.Core.Entities;
using ColomboAutoImports.Core.Models;

namespace ColomboAutoImports.Api.MappingProfiles
{
    public class CarModelMappings : Profile
    {
        public CarModelMappings()
        {
            CreateMap<CarModelEntity, CarModelModel>().ReverseMap();
        }
    }
}

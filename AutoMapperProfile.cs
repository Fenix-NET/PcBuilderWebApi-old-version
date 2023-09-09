using AutoMapper;
using PcBuilderWebApi.Dtos;
using PcBuilderWebApi.Dtos.CatalogDtos;
using PcBuilderWebApi.Models;

namespace PcBuilderWebApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Case, ProductDto>();
            CreateMap<Cpu, ProductDto>();
            CreateMap<Gpu, ProductDto>();
            CreateMap<Hdd, ProductDto>();
            CreateMap<Motherboard, ProductDto>();
            CreateMap<Psu, ProductDto>();
            CreateMap<Ram, ProductDto>();
            CreateMap<Ssd, ProductDto>();

        }
    }
}

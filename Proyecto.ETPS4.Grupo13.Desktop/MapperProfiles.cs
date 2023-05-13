using AutoMapper;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Models;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<UserUpdateDto, User>().ReverseMap();
            CreateMap<UserForRegistrationDto, User>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<ProductDto, ProductFormDto>().ReverseMap();
            CreateMap<Product, ProductFormDto>().ReverseMap();
            CreateMap<Supplier, SupplierFormDto>().ReverseMap();
            CreateMap<SaleHeaderFormDto, SaleHeader>().ReverseMap();
        }
    }
}

using AutoMapper;
using Itemizer.Domain.DTOs;
using Itemizer.Domain.Entities;

namespace Itemizer.Infrastructure.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile() 
    { 
        CreateMap<ItemDTO, Item>().ReverseMap();
        CreateMap<InventoryDTO, Inventory>().ReverseMap();
    }
}

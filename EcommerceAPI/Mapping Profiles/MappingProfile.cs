﻿
using AutoMapper;
using Ecommerce.Core.Entities;
using Ecommerce.Core.Entities.DTO;

namespace Ecommerce.API.Mapping_Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<Products, ProductDTO>().ForMember(To => To.Category_Name, from => from.MapFrom(x => x.Category !=null ? x.Category.Name : null));
            CreateMap<ProductFormDTO, Products>().ReverseMap();
            CreateMap<Orders, OrdersDTO>().ForMember(To => To.User_Name, from => from.MapFrom(x => x.LocalUser != null ? x.LocalUser.Name : null));
        }

    }
}

﻿using Aikings.Dtos;
using Aikings.Models;
using AutoMapper;

namespace Aikings.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
        }
    }
}

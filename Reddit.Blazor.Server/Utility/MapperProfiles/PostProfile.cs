﻿using AutoMapper;
using Reddit.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Blazor.Server.Utility.MapperProfiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Child, Post>()
                .ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(src => src.Data.Title))
                .ForMember(
                    dest => dest.URL,
                    opt => opt.MapFrom(src => src.Data.Url)
                );
        }
    }
}

using AutoMapper;
using Blazeddit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazeddit.Server.Utility.MapperProfiles
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
                    dest => dest.Url,
                    opt => opt.MapFrom(src => src.Data.Url)
                )
                .ForMember(
                    dest => dest.Permalink,
                    opt => opt.MapFrom(src => src.Data.Permalink)
                )
                .ForMember(
                    dest => dest.NumComments,
                    opt => opt.MapFrom(src => src.Data.NumComments)
                );
        }
    }
}

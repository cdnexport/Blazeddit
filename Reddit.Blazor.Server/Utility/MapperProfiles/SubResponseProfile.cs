using AutoMapper;
using Reddit.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Blazor.Server.Utility.MapperProfiles
{
    public class SubResponseProfile : Profile
    {
        public SubResponseProfile()
        {
            CreateMap<SubResponse, Subreddit>();
        }
    }
}

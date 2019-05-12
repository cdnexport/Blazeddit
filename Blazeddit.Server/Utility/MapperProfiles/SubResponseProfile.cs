using AutoMapper;
using Blazeddit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazeddit.Server.Utility.MapperProfiles
{
    public class SubResponseProfile : Profile
    {
        public SubResponseProfile()
        {
            CreateMap<SubResponse, Subreddit>();
        }
    }
}

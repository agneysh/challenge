using AutoMapper;
using Challenge.Domain.Models;
using Challenge.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Mapping
{
    public class ResourceToModelProfile: Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveOrderResource, Order>();
        }
    }
}

using AutoMapper;
using Challenge.Domain.Models;
using Challenge.Resources;

namespace Challenge.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Order, OrderResource>();
        }
    }
}

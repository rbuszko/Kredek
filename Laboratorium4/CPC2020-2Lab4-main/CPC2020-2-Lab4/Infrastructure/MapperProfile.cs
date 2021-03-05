using AutoMapper;
using CPC2020_2_Lab4.Models.Entities;

namespace CPC2020_2_Lab4.Infrastructure
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Book, BookSimpleViewModel>();
        }
    }
}
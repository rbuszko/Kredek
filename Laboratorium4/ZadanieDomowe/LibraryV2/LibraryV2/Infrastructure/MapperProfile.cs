using AutoMapper;
using LibraryV2.Models.Entities;
using LibraryV2.ViewModels;

namespace LibraryV2.Infrastructure
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Books, BooksViewModel>();
            CreateMap<Books, BooksViewModel>()
                .ForMember(b => b.AuthorFirstName, opt => opt.MapFrom(src => src.Authors.FirstName))
                .ForMember(b => b.AuthorLastName, opt => opt.MapFrom(src => src.Authors.LastName))
                .ForMember(b => b.Genre, opt => opt.MapFrom(src => src.Genres.Name))
                .ForMember(b => b.State, opt => opt.MapFrom(src => src.States.Rental))
                .ForMember(b => b.Restriction, opt => opt.MapFrom(src => src.Restrictions.AgeLimit));

            CreateMap<Users, UsersViewModel>();
            CreateMap<Users, UsersViewModel>()
                .ForMember(u => u.IdentityId, opt => opt.MapFrom(src => src.Identities.Id))
                .ForMember(u => u.Role, opt => opt.MapFrom(src => src.Roles.Name));
        }
    }
}

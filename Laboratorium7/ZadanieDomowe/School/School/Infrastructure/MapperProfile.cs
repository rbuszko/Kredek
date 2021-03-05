using AutoMapper;
using School.Models;
using School.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Mapowanie studenta na studentViewModel
            CreateMap<Student, StudentViewModel>();
            CreateMap<StudentCreateUpdateViewModel, Student>();
            // Nie mam pojęcia czemu to nie działa nie łapało mi imienia
            //CreateMap<Student, StudentViewModel>().ForMember(s => s.TeachersName, opt => opt.MapFrom(t => t.TeachersId));

            // Mapowanie Nauczyciela na nauczycielViewModel (DTO)
            CreateMap<Teacher, TeacherViewModel>();
            CreateMap<TeacherCreateUpdateViewModel, Teacher>();
        }
    }
}

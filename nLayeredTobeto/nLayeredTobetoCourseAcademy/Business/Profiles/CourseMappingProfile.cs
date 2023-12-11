using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class CourseMappingProfile : Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<CreatedCourseResponse, Course>().ReverseMap();
            CreateMap<CreateCourseRequest, Course>().ReverseMap();
            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
            CreateMap<Course, GetListCourseResponse>()
                .ForMember(destinationMember:c => c.CategoryName, memberOptions:opt => opt.MapFrom(c => c.Category.Name))
                .ForMember(destinationMember:i => i.InstructorName, memberOptions:opt => opt.MapFrom(i => i.Instructor.Name)).ReverseMap();

        }
    }
}

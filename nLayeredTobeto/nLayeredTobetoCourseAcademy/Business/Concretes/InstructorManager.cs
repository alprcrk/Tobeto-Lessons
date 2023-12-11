using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstract;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        private readonly IMapper _mapper;

        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;

        }
        public async Task<Paginate<GetListInstructorResponse>> GetListAsync()
        {
            var result = await _instructorDal.GetListAsync(include: i => i.Include(i => i.Courses));
            return _mapper.Map<Paginate<GetListInstructorResponse>>(result);
        }

        public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
            var createInstructor = await _instructorDal.AddAsync(instructor);
            return _mapper.Map<CreatedInstructorResponse>(createInstructor);

        }
    }
}

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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        IMapper _mapper;
        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
        }
        public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
            var createdInstructor = await _instructorDal.AddAsync(instructor);
            CreatedInstructorResponse createdInstructorResponse = _mapper.Map<CreatedInstructorResponse>(createdInstructor);
            return createdInstructorResponse;
        }

        public async Task<DeletedInstructorResponse> Delete(DeleteInstructorRequest deleteInstructorRequest)
        {
            Instructor instructor = await _instructorDal.GetAsync(c => c.Id == deleteInstructorRequest.Id);
            var deletedInstructor = await _instructorDal.DeleteAsync(instructor);
            DeletedInstructorResponse deletedInstructorResponse = _mapper.Map<DeletedInstructorResponse>(deletedInstructor);
            return deletedInstructorResponse;
        }

        public async Task<GetInstructorResponse> GetAsync(Expression<Func<Instructor, bool>> filter)
        {
            var result = await _instructorDal.GetAsync(filter);
            GetInstructorResponse getInstructorResponse = _mapper.Map<GetInstructorResponse>(result);
            return getInstructorResponse;
        }

        public async Task<Paginate<GetListInstructorResponse>> GetListAsync()
        {
            var result = await _instructorDal.GetListAsync();
            Paginate<GetListInstructorResponse> getListedInstructorResponse = _mapper.Map<Paginate<GetListInstructorResponse>>(result);
            return getListedInstructorResponse;
        }

        public async Task<UpdatedInstructorResponse> Update(UpdateInstructorRequest updateInstructorRequest)
        {
            Instructor instructor = _mapper.Map<Instructor>(updateInstructorRequest);
            var updatedInstructor = await _instructorDal.UpdateAsync(instructor);
            UpdatedInstructorResponse updatedInstructorResponse = _mapper.Map<UpdatedInstructorResponse>(updatedInstructor);
            return updatedInstructorResponse;
        }
    }
}

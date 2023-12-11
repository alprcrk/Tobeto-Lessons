using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Dynamic;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        private readonly IMapper _mapper;


        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }
        public async Task<Paginate<GetListCategoryResponse>> GetListAsync()
        {
            var result = await _categoryDal.GetListAsync(include: ca => ca.Include(ca => ca.Courses));
            return _mapper.Map<Paginate<GetListCategoryResponse>>(result);
        }

        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
        {
            Category category = _mapper.Map<Category>(createCategoryRequest);
            var createCategory = await _categoryDal.AddAsync(category);
            return _mapper.Map<CreatedCategoryResponse>(createCategory);

        }

        public async Task<GetCategoryResponse> GetAsync(Expression<Func<Category, bool>> Filter = null)
        {
            var result = await _categoryDal.GetAsync(Filter);
            return _mapper.Map<GetCategoryResponse>(result);
        }

        public async Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCategoryRequest)
        {
            Category category = _mapper.Map<Category>(updateCategoryRequest);
            var updateCategory = await _categoryDal.UpdateAsync(category);
            return _mapper.Map<UpdatedCategoryResponse>(updateCategory);
        }

        public async Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCategoryRequest)
        {
            Category category = await _categoryDal.GetAsync(c => c.Id == deleteCategoryRequest.Id);
            var deleteCategory = await _categoryDal.DeleteAsync(category);
            return _mapper.Map<DeletedCategoryResponse>(deleteCategory);
        }
    }
}
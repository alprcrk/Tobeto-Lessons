﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<Paginate<CreatedCategoryResponse>> GetListAsync()
        {
            var result = await _categoryDal.GetListAsync();
            return _mapper.Map<Paginate<CreatedCategoryResponse>>(result);
        }

        public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
        {
            Category category = _mapper.Map<Category>(createCategoryRequest);
            var createCategory = await _categoryDal.AddAsync(category);
            return _mapper.Map<CreatedCategoryResponse>(createCategory);

        }
    }
}
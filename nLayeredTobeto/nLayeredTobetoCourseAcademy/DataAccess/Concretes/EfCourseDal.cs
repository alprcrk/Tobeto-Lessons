﻿using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfCourseDal : EfRepositoryBase<Course, Guid, TobetoCourseAcademyContext>, ICourseDal
    {
        public EfCourseDal(TobetoCourseAcademyContext context) : base(context)
        {
        }
    }
}

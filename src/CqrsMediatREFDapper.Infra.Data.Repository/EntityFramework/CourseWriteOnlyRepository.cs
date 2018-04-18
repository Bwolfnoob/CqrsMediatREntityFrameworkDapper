﻿using CqrsMediatREFDapper.Domain.CourseContext.Interfaces.Repositories;
using CqrsMediatREFDapper.Domain.CourseContext.Models;
using CqrsMediatREFDapper.Infra.Data.Repository.Common;

namespace CqrsMediatREFDapper.Infra.Data.Repository.EntityFramework
{
    public sealed class CourseWriteOnlyRepository : WriteOnlyRepository<Course>, ICourseWriteOnlyRepository
    {
    }
}

using Abp.Application.Services;
using Abp.Domain.Repositories;
using SIS.Students.StudentInfo;
using SIS.Students.StudentInfoServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Students.StudentInfoServices
{
    public class StudentInfoAppService : CrudAppService<StudentInformation, StudentInformationDto, int, PagedAndSortedResultRequestDto,
                       CreateStudentInfoDto, StudentInformationUpdateDto>,
        IStudentInfoAppService
    {
        public StudentInfoAppService(IRepository<StudentInformation, int> repository) : base(repository)
        {
        }
    }
}

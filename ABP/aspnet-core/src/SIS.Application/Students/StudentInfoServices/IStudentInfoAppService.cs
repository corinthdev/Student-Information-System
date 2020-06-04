using Abp.Application.Services;
using SIS.Students.StudentInfoServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Students.StudentInfoServices
{
    public interface IStudentInfoAppService : ICrudAppService<StudentInformationDto, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            CreateStudentInfoDto, //Used to create a new book
            StudentInformationUpdateDto> 
    {
    }
}

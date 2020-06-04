using AutoMapper;
using SIS.Students.StudentInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Students.StudentInfoServices.Dto
{
    public class StudentInformationMapProfile : Profile
    {


        public StudentInformationMapProfile()
        {
            CreateMap<StudentInformation, StudentInformationDto>();
            CreateMap<CreateStudentInfoDto, StudentInformation>();
        }
    }
}

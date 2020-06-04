using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SIS.Students.StudentInfoServices.Dto
{
    public class StudentInformationUpdateDto : AuditedEntityDto<int>
    {
        [Display(Name = "PSA No.")]
        public string PsaNo { get; set; }
        //Learner Reference Number
        [Display(Name = "LRN No.")]
        public string Lrn { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Extension Name")]
        public string ExtensionName { get; set; }
        [Display(Name = "Date of Birth")]
        public string Birthdate { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string MotherTongue { get; set; }
        public string Religion { get; set; }

    }
}

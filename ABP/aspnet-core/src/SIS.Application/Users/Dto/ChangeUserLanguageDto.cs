using System.ComponentModel.DataAnnotations;

namespace SIS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
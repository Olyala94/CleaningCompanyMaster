using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleaningCompanyMaster.Models
{
    public class RegisterUserModel 
    {
        [Required]
        [DisplayName("Lütfen Adınınızı Girin")]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Lütfen  soyadınızı Girin")]
        public string? Surname { get; set; }

        [Required]
        [DisplayName("Lütfen Kullanıcı Adını Girin")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [DisplayName("Lütfen Şifreyi Girin")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Compare("Password", ErrorMessage = "Lütfen şifreyi tekrar Girin")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Lütfen mail girin")]  
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lütfen resim url değeri girin")]
        public string? ImageUrl { get; set; }

        public string? Master { get; set; }

        public string? Customer { get; set; }
    }
}

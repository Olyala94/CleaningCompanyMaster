using System.ComponentModel.DataAnnotations;

namespace CleaningCompanyMaster.Models
{
    public class LoginUserViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adını giriniz...!")]

        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi giriniz...!")]

        public string Password { get; set; }
    }
}

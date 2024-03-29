using System.ComponentModel.DataAnnotations;

namespace MyBlogProject.Models
{
    public class UserSignInViewModel
    {

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Lütfen mail adresi giriniz")]
        public string email { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string password { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace MyBlogProject.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Lütfen ad soyad giriniz")]
        public string nameSurname { get; set; }


        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string mail { get; set; }


        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string userName { get; set; }



        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string password { get; set; }


        [Display(Name = "Şifre Tekrar")]
        [Required(ErrorMessage = "Şifreler uyuşmuyor!")]
        public string confirmPassword { get; set; }
    }
}

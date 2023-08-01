using System.ComponentModel.DataAnnotations;

namespace Core_WebSitem.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adını girin")]
        public string Username { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifreyi girin")]
        public string Password { get; set; }
    }
}

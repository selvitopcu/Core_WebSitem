using System.ComponentModel.DataAnnotations;

namespace Core_WebSitem.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı soyadınızı girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adını girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen görsel bilgisi girin")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("Password",ErrorMessage ="Şifreler uyyumlu değil!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen mail girin")]
        public string Mail { get; set; }    
    }
}

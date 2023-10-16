using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SPaPS.Models.AccountModels
{
    public class LoginModel
    {
        [Required]
        [DisplayName("Кориснички име")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Лозинка")]
        public string Password { get; set; }
    }
}

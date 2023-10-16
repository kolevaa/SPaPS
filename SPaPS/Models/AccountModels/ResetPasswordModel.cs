using System.ComponentModel.DataAnnotations;

namespace SPaPS.Models.AccountModels
{
    public class ResetPasswordModel
    {
        [Required]
        [Display(Name = "email")]
        public string Email { get; set; } =  string.Empty;
        [Required]
        [Display(Name = "token")]
        public string Token { get; set; } = string.Empty;
        [Required]
        public string NewPassword { get; set; } = string.Empty;
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace SPaPS.Models.AccountModels
{
    public class ForgotPasswordModel
    {
        [Required]
        [Display(Name = "email")]
        public string Email { get; set; }
    }
}

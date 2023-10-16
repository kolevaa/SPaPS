using System.ComponentModel.DataAnnotations;

namespace SPaPS.Models.AccountModels
{
    public class ChangePasswordModel
    {
        [Required]
        [Display(Name = "old password")]
        public string OldPassword { get; set; } = string.Empty;
        [Required]
        [Display(Name = "new password")]
        public string NewPassword { get; set; } = string.Empty;
        [Required]
        [Display(Name = "confirm password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}

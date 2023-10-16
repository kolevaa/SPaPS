using System.ComponentModel.DataAnnotations;

namespace SPaPS.Models.AccountModels
{
    public class RegisterModel
    {
        [Required]
        [Display(Name = "E-маил")]
        public string? Email { get; set; }
        [Required]
        [Display(Name = "phone number")]
        public string? PhoneNumber { get; set; }
        [Required]
        [Display(Name = "client type id")]
        public int ClientTypeId { get; set; }
        [Required]
        [Display(Name = "name")]
        public string Name { get; set; } = null!;
        [Required]
        [Display(Name = "address")]
        public string Address { get; set; } = null!;
        [Required]
        [Display(Name = "Idno")]
        public string IdNo { get; set; } = null!;
        [Required]
        [Display(Name = "city id")]
        public int CityId { get; set; }
        [Required]
        [Display(Name = "country id")]
        public int CountryId { get; set; }
        [Required]
        [Display(Name = "role")]
        public string? Role { get; set; }
        [Required]
        [Display(Name = "noofemployees")]
        public int? NoOfEmployees { get; set; }
        public DateTime? DateOfEstablishment { get; set; }

        public int ServiceId { get; set; }

    }
}

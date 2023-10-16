using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SPaPS.Models.AccountModels
{
    public class ChangeUserInfo
    {
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
        [Display(Name = "adress")]
        public string Address { get; set; } = null!;
        [Required]
        [Display(Name = "idno")]
        public string IdNo { get; set; } = null!;
        [Required]
        [Display(Name = "city id")]
        public int CityId { get; set; }
        [Required]
        [Display(Name = "country id")]
        public int? CountryId { get; set; }
    }
}

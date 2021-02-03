using System.ComponentModel.DataAnnotations;

namespace NBSUltra.Models.DataModels
{
    public class CustomerSite
    {
        public int Id { get; set; }

        [Display(Name = "#")]
        public string SiteNumber { get; set; }

        [Display(Name = "Site")]
        public string SiteName { get; set; }

        [Display(Name = "Kontakt")]
        public string SiteContact { get; set; }

        [Display(Name = "Adress")]
        public string SiteAddress { get; set; }
        [Display(Name = "Tele#")]
        public string SitePhoneNumber { get; set; }
    }
}
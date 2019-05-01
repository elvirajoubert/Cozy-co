using System.ComponentModel.DataAnnotations;

namespace CozyCo.Domain.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Display(Name = "Address cont.")]
        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Zipcode { get; set; }
        public string Image { get; set; }
    }
}

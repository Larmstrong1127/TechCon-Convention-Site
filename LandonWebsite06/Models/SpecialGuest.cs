using System.ComponentModel.DataAnnotations;

namespace LandonWebsite06.Models
{
    public class SpecialGuests
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Guest name is required.")]
        [Display(Name = "Full Name")]
        [StringLength(100)]
        public string guestName { get; set; }

        [Display(Name = "Title / Role")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Display(Name = "Company / Organization")]
        [StringLength(100)]
        public string? Company { get; set; }

        [Display(Name = "Bio")]
        [StringLength(500)]
        public string? Bio { get; set; }
    }
}

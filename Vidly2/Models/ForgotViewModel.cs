using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Courrier électronique")]
        public string Email { get; set; }
    }
}

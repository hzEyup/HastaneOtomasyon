#nullable disable
using System.ComponentModel.DataAnnotations;

namespace HastaneOtomasyon.Models
{
    public class DoktorIletısım
    {
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty!")]
        public string TelefonNumarasi { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty!")]
        public string Adres { get; set; }

    }
}

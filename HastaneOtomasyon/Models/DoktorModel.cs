#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HastaneOtomasyon.Models
{
    public class DoktorModel
    {
        [Required(ErrorMessage = "{0} Cannot be empty!")]
        [StringLength(30, ErrorMessage = "{0} must be have max{1} characters!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty!")]
        [StringLength(50, ErrorMessage = "{0} must be have max {1} charcters! ")]
        [DisplayName("Soy Ad")]
        public string SoyAd { get; set; }

        public class Doktor
        {
            public Brans Brans { get; set; }
        }

        [Required(ErrorMessage ="{0} cannot be empty!")]
        public DoktorIletısım doktorIletısım { get; set; }

    }
}

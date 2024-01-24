#nullable disable
using System.ComponentModel.DataAnnotations;

namespace HastaneOtomasyon.Models
{
    public class RandevuBilgileriModel
    {
        [Required(ErrorMessage =" {0} cannot be empty")]
        public DateTime RandevuTarihi { get; set; }
        
        [Required(ErrorMessage = " {0} cannot be empty")]
        public string HastaAdi { get; set; }

        [Required(ErrorMessage = " {0} cannot be empty")]
        public string DoktorAdi { get; set; }
        public  { get; set; }
    }
}

#nullable disable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static HastaneOtomasyon.Enums.Sex;

namespace HastaneOtomasyon.Models
{
    public class HastaModel
    {
        [Required(ErrorMessage = "{0} Cannot be empty!")]
        [StringLength(30, ErrorMessage = "{0} must be have max{1} characters!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty!")]
        [StringLength(50, ErrorMessage = "{0} must be have max {1} charcters! ")]
        [DisplayName("Soy Ad")]
        public string SoyAd { get; set; }


        [Required(ErrorMessage = "{0} Cannot be empty!")]
        //[StringLength(30,ErrorMessage = "{0} must be have max{1} charcters!")]
        public int TcNo { get; set; }


        public DateOnly DogumTarihi{ get; set; }

        public class Hasta
        {
            public Cinsiyet Cinsiyet { get; set; }

        }

        [Required(ErrorMessage = "{0} Cannot be empty!")]
        public int TelefonNo { get; set; }



        [Required(ErrorMessage = "{0} Cannot be empty!")]
        public string eposta { get; set; }

        [Required(ErrorMessage ="{0} Cannot be empty!")]
        public string Adres { get; set; }


    }
}

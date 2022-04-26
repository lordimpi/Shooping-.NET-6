using System.ComponentModel.DataAnnotations;

namespace Shooping.Data.Entities
{
    public class TemporalSale
    {
        public int Id { get; set; }
        
        public User User { get; set; }

        public Product Product { get; set; }
        
        [Display(Name ="Cantitdad")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString ="{0:N2}")]
        public float Quantity { get; set; }
        
        [DataType(DataType.MultilineText)]
        [Display(Name ="Comentarios")]
        public string Remarks { get; set; }
    }
}

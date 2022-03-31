using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Shooping.Models
{
    public class EditUserViewModel
    {
        public string? Id { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Document { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tene máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? LastName { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Address { get; set; }

        [Display(Name = "Teléfono")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }


        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44357/images/noimage.png"
            : $"https://genericshooping.blob.core.windows.net/users/{ImageId}";

        [Display(Name = "Imagen")]
        public IFormFile? ImageFile { get; set; }

        [Display(Name = "País")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes de seleccionar un país")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int CountryId { get; set; }

        public IEnumerable<SelectListItem>? Countries { get; set; }

        [Display(Name = "Departamento / Estado")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un Departamento/Estado.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int StateId { get; set; }

        public IEnumerable<SelectListItem>? States { get; set; }

        [Display(Name = "Ciudadees")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar una ciudad.")]
        public int CityId { get; set; }

        public IEnumerable<SelectListItem>? Cities { get; set; }
    }
}

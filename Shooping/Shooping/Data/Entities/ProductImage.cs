using System.ComponentModel.DataAnnotations;

namespace Shooping.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        //TODO: Pending to change to the correct path
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            //? $"https://localhost:44357/images/noimage.png"
            ? $"https://impistoreshop.azurewebsites.net/images/noimage.png"
            : $"https://genericshooping.blob.core.windows.net/products/{ImageId}";
    }
}

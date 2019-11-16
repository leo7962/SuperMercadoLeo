using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Stock")]
        public int Stock { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class TypeProduct
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Nombre tipo de producto")]
        public string Name { get; set; }

        [Display(Name = "Descripción tipo de producto")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
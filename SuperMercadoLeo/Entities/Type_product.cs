using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMercadoLeo.Entities
{
    public class Type_product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nombre del tipo de producto")]
        public string Name_Type_Product { get; set; }

        [Display(Name ="Descripción del producto")]
        public string Description { get; set; }
    }
}

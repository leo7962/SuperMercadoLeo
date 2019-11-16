using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMercadoLeo.Entities
{
    public class Branch
    {
        [KeyAttribute]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        [Display(Name ="Telefono")]
        public string Telephone { get; set; }

        [Display(Name ="Dirección")]
        public string Direction { get; set; }
    }
}

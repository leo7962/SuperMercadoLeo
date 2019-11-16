using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMercadoLeo.Entities
{
    public class Customer
    {
        [KeyAttribute]
        public int Id { get; set; }

        [Display(Name ="Documento")]
        public string Document { get; set; }

        [Display(Name ="Nombre")]
        public string Name { get; set; }

        [Display(Name ="Apellido")]
        public string LastName { get; set; }

        [Display(Name ="Estado")]
        public bool State { get; set; }
    }
}

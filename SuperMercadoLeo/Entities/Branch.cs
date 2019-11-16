using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength( 50, ErrorMessage = "El nombre no puede ser mayor a 50 caracteres." )]  
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        [Display(Name = "Telefono")]
        [StringLength( 10, ErrorMessage = "el número de telefono no puede ser mayor a 10 digitos." )]  
        public string Telephone { get; set; }

        [Display(Name = "Dirección")]
        public string Direction { get; set; }

        public List<Employee> Employees {get; set;}
    }
}

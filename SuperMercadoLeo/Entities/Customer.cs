using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Documento")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [StringLength( 50, ErrorMessage = "El nombre no puede ser mayor a 50 caracteres" )]  
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        [StringLength( 50, ErrorMessage = "El nombre no puede ser mayor a 50 caracteres" )]  
        public string LastName { get; set; }

        [Display(Name = "Estado")]
        public bool State { get; set; }
    }
}

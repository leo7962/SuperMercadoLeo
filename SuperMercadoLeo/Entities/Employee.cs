using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Documento")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        public int BranchId {get; set;}
        public Branch Branch { get; set; }
    }
}

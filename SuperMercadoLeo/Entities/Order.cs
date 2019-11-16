using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public Branch Id_branch { get; set; }
        public Employee Id_Employee { get; set; }
        public Customer Id_Customer { get; set; }
    }
}

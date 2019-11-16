using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Order_Detail
    {
        [Key]
        public int Id { get; set; }
        public Product Id_product { get; set; }
    }
}

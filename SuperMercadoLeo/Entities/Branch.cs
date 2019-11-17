using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Branch
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Nombre de la Franquicia")]
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
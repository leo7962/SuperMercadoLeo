using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Position
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Cargo Laboral")] public string Post { get; set; }

        [Display(Name = "Descripción cargo laboral")]
        public string Description { get; set; }

        [Display(Name = "Salario mensual")] public decimal Money { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
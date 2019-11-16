using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMercadoLeo.Entities
{
    public class Country
    {
        [Key] public int Id { get; set; }
        [Display (Name = "Pais")] public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }
}

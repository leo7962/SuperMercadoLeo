using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Gender
    {
        [Key] public int Id { get; set; }
        [Display(Name = "Tipo de sexo")] public string Sex { get; set; }
        public List<Person> Persons { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Person
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Primer Nombre")] public string FirstName { get; set; }
        [Display(Name = "Segundo Nombre")] public string SecondName { get; set; }
        [Display(Name = "Primer Apellido")] public string LastName { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Número de documento")]
        public int Document { get; set; }

        [Display(Name = "Dirección de residencia")]
        public string Direction { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public Employee Employee { get; set; }
        public Person Persons { get; set; }
    }
}
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class City
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Nombre de la ciudad")]
        public string Name { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<City> Cities { get; set; }
        public List<Person> Persons { get; set; }
    }
}
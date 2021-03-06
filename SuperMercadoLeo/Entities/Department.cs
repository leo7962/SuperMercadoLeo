﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Department
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Nombre del departamento")]
        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<City> Cities { get; set; }
    }
}
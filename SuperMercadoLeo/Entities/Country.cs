﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Country
    {
        [Key] public int Id { get; set; }
        [Display(Name = "Pais")] public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Employee
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Fecha de contratación")]
        public DateTime DateInit { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
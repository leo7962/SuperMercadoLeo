using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMercadoLeo.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Branch Id_branch { get; set; }
        public Employee Id_Employee { get; set; }
        public Customer Id_Customer { get; set; }

    }
}

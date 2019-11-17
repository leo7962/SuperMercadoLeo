using System;
using System.ComponentModel.DataAnnotations;

namespace SuperMercadoLeo.Entities
{
    public class Product
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Nombre del producto")]
        public string Name { get; set; }

        [Display(Name = "Fecha de elaboración del producto")]
        public DateTime DateFactory { get; set; }

        [Display(Name = "Fecha de vencimiento")]
        public DateTime DateExp { get; set; }

        [Display(Name = "Compra del producto")]
        public decimal PurchaseProduct { get; set; }

        [Display(Name = "Venta del producto")] public decimal SellProduct { get; set; }

        [Display(Name = "Cantidad de productos")]
        public int Stock { get; set; }

        [Display(Name = "Descripción del producto")]
        public string Description { get; set; }

        public int ProductId { get; set; }
        public TypeProduct TypeProduct { get; set; }
    }
}
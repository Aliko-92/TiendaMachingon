﻿namespace TiendaMachingon.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Product: IEntity
    {
        [key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name="Nombre del producto")]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}

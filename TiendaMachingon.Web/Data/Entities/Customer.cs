using System.ComponentModel.DataAnnotations;

namespace TiendaMachingon.Web.Data.Entities
{
    public class Customer: IEntity
    {
        [key]

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Display(Name = "Nombre del cliente")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Teléfono del cliente")]
        public int Telephone { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Dirección de entrega")]
        private string Adress { get; set; }
    }
    
}

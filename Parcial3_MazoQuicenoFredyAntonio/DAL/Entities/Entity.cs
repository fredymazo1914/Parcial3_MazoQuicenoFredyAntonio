using System.ComponentModel.DataAnnotations;

namespace Parcial3_MazoQuicenoFredyAntonio.DAL.Entities
{
    public class Entity
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime? CreateDate { get; set; }

        [Display(Name = "Fecha de Modificación")]
        public DateTime? ModifieDate { get; set; }
    }
}

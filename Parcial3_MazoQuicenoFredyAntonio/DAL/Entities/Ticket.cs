using System.ComponentModel.DataAnnotations;

namespace Parcial3_MazoQuicenoFredyAntonio.DAL.Entities
{
    public class Ticket : Entity
    {
        
        [Display(Name = "Fecha de Creación")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "¿La boleta fue usada?")]
        public bool IsUsed { get; set; }

        [Display(Name = "Portería de ingreso")]
        public string? EntranceGate { get; set; }

    }
}

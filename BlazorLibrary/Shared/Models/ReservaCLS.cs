using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorLibrary.Shared.Models
{
   public class ReservaCLS
    {
        [Required(ErrorMessage ="Debe ingresar el usuario")]
        public string iidUsuario { get; set; }
        [Required(ErrorMessage = "Debe ingresar el libro")]
        public int? iidLibro { get; set; }
        [Required(ErrorMessage = "Debe ingresar la cantidad")]
        public int? cantidad { get; set; }
        public DateTime fechaInicio { get; set; } = DateTime.Now;

        public DateTime fechaFin { get; set; } = DateTime.Now;
    }
}

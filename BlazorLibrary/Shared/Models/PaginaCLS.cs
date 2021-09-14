using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorLibrary.Shared.Models
{
	public class PaginaCLS
	{
		public int iidpagina { get; set; }
		[Required(ErrorMessage ="Debe ingresar el mensaje que dira")]
		[MaxLength(ErrorMessage ="La longitud maxima del nombre del mensaje es 100")]
		public string mensaje { get; set; }
		[Required(ErrorMessage = "Debe ingresar el nombre de la acciòn que dira")]
		[MaxLength(ErrorMessage = "La longitud maxima de la acciòn  es 100")]

		public string accion { get; set; }
		//Me servira para agregar
		public bool bvisible { get; set; }
		//Esta columna sera para el lista
		public string nombreVisible { get; set; }
	}
}

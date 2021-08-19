using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MiPrimeraAplicacionUsandoBlazor.Shared.Models
{
	public class TipoLibroCLS
	{
		public int IIDTIPOLIBRO { get; set; }

		[Required(ErrorMessage ="Debe ingresar el nombre del tipo libro")]
		public string NOMBRETIPOLIBRO { get; set; }
		
		[Required(ErrorMessage = "Debe ingresar el nombre de la descripcion")]
		public string DESCRIPCIONTIPOLIBRO { get; set; }

	}
}

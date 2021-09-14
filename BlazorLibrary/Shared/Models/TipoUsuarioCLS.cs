using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorLibrary.Shared.Models
{
	public class TipoUsuarioCLS
	{
		public int iidTipoUsuario { get; set; }
		[MaxLength(100,ErrorMessage ="La longitud maxima es 100 caracteres del nombre")]
		[Required(ErrorMessage ="Debe ingresar el nombre")]
		public string nombre { get; set; }
		[MaxLength(100, ErrorMessage = "La longitud maxima es 100 caracteres de la descripcion")]
		[Required(ErrorMessage = "Debe ingresar la descripciòn")]

		public string descripcion { get; set; }

		public List<int> arrayId { get; set; } = new List<int>();
	}
}

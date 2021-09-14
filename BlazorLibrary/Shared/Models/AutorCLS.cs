using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorLibrary.Shared.Models
{
	public class AutorCLS
	{
		public int iidautor { get; set; }
		//aÑADO NUEVA PROPIEDAD QUE ES NOMBRE AUTOR

		[Required(ErrorMessage ="Debe ingresar el nombre del autor")]
		[MaxLength(100,ErrorMessage ="La longitud maxima debe ser 100")]
		[MinLength(2,ErrorMessage ="La longitud minima es 2")]
		public string nombreAutor { get; set; }

		[Required(ErrorMessage = "Debe ingresar el apellido paterno del autor")]
		[MaxLength(150, ErrorMessage = "La longitud maxima debe ser 150")]
		[MinLength(3, ErrorMessage = "La longitud minima es 3")]

		public string apPaterno { get; set; }


		[Required(ErrorMessage = "Debe ingresar el apellido materno del autor")]
		[MaxLength(150, ErrorMessage = "La longitud maxima debe ser 150")]
		[MinLength(3, ErrorMessage = "La longitud minima es 3")]
		public string apMaterno { get; set; }

		[Required(ErrorMessage ="Debe seleccionar un sexo")]
		public string iidSexo { get; set; }
		[Required(ErrorMessage = "Debe seleccionar un paìs")]

		public string iidPais { get; set; }

		public string nombrecompleto { get; set; }
		public string nombresexo { get; set; }
		public string nombrepais { get; set; }

		[Required(ErrorMessage = "Debe ingresar la descripcion")]
		[MaxLength(500,ErrorMessage ="La longitud maxima es 500")]
		[MinLength(10, ErrorMessage = "La longitud minima es 10")]

		public string descripcion { get; set; }
	}
}

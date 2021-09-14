using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorLibrary.Shared.Models
{
	public class PersonaCLS
	{
		public int iidPersona { get; set; }
		public string nombreCompleto { get; set; }
		[MaxLength(100, ErrorMessage = "La longitud maximo del correo  es 100")]

		public string correo { get; set; }
		public string fechaMostrarCadena { get; set; }

		//Vamos a poner las demas propiedades
		[Required(ErrorMessage = "Ingrese nombre de la persona")]
		[MaxLength(100, ErrorMessage = "La longitud maximo del nombre es 100")]
		public string nombre { get; set; }
		[Required(ErrorMessage = "Ingrese apellido paterno de la persona")]
		[MaxLength(150, ErrorMessage = "La longitud maximo del apellido paterno es 150")]

		public string apPaterno { get; set; }
		[Required(ErrorMessage = "Ingrese apellido materno de la persona")]
		[MaxLength(150, ErrorMessage = "La longitud maximo del apellido materno es 150")]

		public string apMaterno { get; set; }

		[MaxLength(50, ErrorMessage = "La longitud maximo del telefono  es 50")]

		public string telefono { get; set; }

		public DateTime fechaNacimiento { get; set; } = DateTime.Now;
		
		[Required(ErrorMessage ="Debe ingresar el tipo de usuario")]
		public string iidTipoUsuario { get; set; }

		[Required(ErrorMessage ="Debe ingresar el nombre del usuario")]
		public string nombreUsuario { get; set; }

		[MinLength(8,ErrorMessage ="La contraseña debe tener minimo 8 caracteres")]
		public string contra { get; set; } = "12345678";

	}
}

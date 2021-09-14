using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorLibrary.Shared.Models
{
	public class LibroCLS
	{
		public int IIDLIBRO { get; set; }

		[Required(ErrorMessage ="Ingrese un titulo")]
		public string TITUlO { get; set; }

		[Required(ErrorMessage = "Ingrese resumen")]

		public string RESUMEN { get; set; }

		public string LIBROPDF { get; set; }
		public string FOTOCARATULA { get; set; }

		public string NOMBREAUTOR { get; set; }

		[Required(ErrorMessage = "Ingrese numero paginas")]

		public int NUMEROPAGINAS { get; set; }

		[Required(ErrorMessage = "Ingrese stock")]

		public int STOCK { get; set; }

		[Required(ErrorMessage = "Ingrese Autor")]

		public string IIDAUTOR { get; set; }


	}
}

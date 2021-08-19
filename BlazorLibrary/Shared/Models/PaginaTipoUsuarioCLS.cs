using System;
using System.Collections.Generic;
using System.Text;

namespace MiPrimeraAplicacionUsandoBlazor.Shared.Models
{
	public class PaginaTipoUsuarioCLS
	{
		public int iidpaginatipousuario { get; set; }

		public string nombrePagina { get; set; }

		public string nombreTipoUsuario { get; set; }


		public List<int> IdButtons { get; set; } = new List<int>();

	}
}

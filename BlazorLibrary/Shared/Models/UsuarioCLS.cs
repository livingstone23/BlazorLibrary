using System.ComponentModel.DataAnnotations;


namespace MiPrimeraAplicacionUsandoBlazor.Shared.Models
{
    public class UsuarioCLS
	{
		public int iidUsuario { get; set; }
		[Required(ErrorMessage = "Debe ingresar el nombre del usuario")]
		public string nombre { get; set; }
		[MinLength(8, ErrorMessage = "La contraseña debe tener minimo 8 caracteres")]
		public string contra { get; set; }

		public int iidTipousuario { get; set; }
	}
}

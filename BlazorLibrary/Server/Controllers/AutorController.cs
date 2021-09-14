using BlazorLibrary.Server.Models;
using BlazorLibrary.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorLibrary.Server.Controllers;

[ApiController]
public class AutorController : Controller
{
    [HttpGet]
    [Route("api/Autor/listarAutor")]
    public List<AutorCLS> listaAutor()
    {
        List<AutorCLS> listaAutor = new List<AutorCLS>();

        using (var db = new BlazorLibraryContext())
        {
            listaAutor =(from autor in db.Autors
                        join pais in db.Pais
                        on autor.Iidpais equals pais.Iidpais
                        join sexo in db.Sexos
                        on autor.Iidsexo equals sexo.Iidsexo
                        select new AutorCLS
                        {
                            iidautor = autor.Iidautor,
                            nombreAutor = autor.Nombre,
                            nombrecompleto = autor.Nombre + " " + autor.Appaterno + "" + autor.Apmaterno,
                            nombrepais = pais.Nombre,
                            nombresexo = sexo.Nombre,
                            descripcion = autor.Descripcion
                        }).ToList();
        }

            return listaAutor;
    }


}

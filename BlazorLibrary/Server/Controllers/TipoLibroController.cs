using BlazorLibrary.Server.Models;
using Microsoft.AspNetCore.Mvc;
using BlazorLibrary.Shared.Models;

namespace BlazorLibrary.Server.Controllers;

[ApiController]
public class TipoLibroController : Controller
{

    [HttpGet]
    [Route("api/TipoLibro/Get")]
    public List<TipoLibroCLS> Get()
    {
        List<TipoLibroCLS> lista = new List<TipoLibroCLS>();
        using (BlazorLibraryContext db = new BlazorLibraryContext())
        {
            lista = (from tipoLibro in db.TipoLibros
                     where tipoLibro.Bhabilitado == 1
                     select new TipoLibroCLS
                     {
                         IIDTIPOLIBRO = tipoLibro.Iidtipolibro,
                         NOMBRETIPOLIBRO = tipoLibro.Nombretipolibro,
                         DESCRIPCIONTIPOLIBRO = tipoLibro.Descripcion
                     }).ToList();

        }
        return lista;
    }

    //[HttpGet]
    //[Route("api/TipoLibro/obtenerTipoLibro/{iidTipoLibro}")]
    //public TipoLibroCLS obtenerTipoLibro(int iidTipoLibro)
    //{
    //    TipoLibroCLS oTipoLibroCLS = new TipoLibroCLS();
    //    using (BDBibliotecaContext db = new BDBibliotecaContext())
    //    {

    //        oTipoLibroCLS = (from tipoLibro in db.TipoLibro
    //                         where tipoLibro.Iidtipolibro == iidTipoLibro
    //                         select new TipoLibroCLS
    //                         {
    //                             IIDTIPOLIBRO = tipoLibro.Iidtipolibro,
    //                             NOMBRETIPOLIBRO = tipoLibro.Nombretipolibro,
    //                             DESCRIPCIONTIPOLIBRO = tipoLibro.Descripcion
    //                         }).First();
    //        return oTipoLibroCLS;

    //    }
    //}


    //[HttpPost]
    //[Route("api/TipoLibro/Guardar")]
    //public int Guardar([FromBody] TipoLibroCLS oTipoLibroCLS)
    //{
    //    int rpta = 0;

    //    try
    //    {
    //        using (BDBibliotecaContext db = new BDBibliotecaContext())
    //        {
    //            if (oTipoLibroCLS.IIDTIPOLIBRO == 0)
    //            {
    //                TipoLibro oTipoLibro = new TipoLibro();
    //                oTipoLibro.Nombretipolibro = oTipoLibroCLS.NOMBRETIPOLIBRO;
    //                oTipoLibro.Descripcion = oTipoLibroCLS.DESCRIPCIONTIPOLIBRO;
    //                oTipoLibro.Bhabilitado = 1;
    //                db.TipoLibro.Add(oTipoLibro);
    //                db.SaveChanges();
    //                rpta = 1;

    //            }
    //            else
    //            {
    //                TipoLibro oTipoLibro =
    //                    db.TipoLibro.Where(p => p.Iidtipolibro == oTipoLibroCLS.IIDTIPOLIBRO).First();
    //                oTipoLibro.Nombretipolibro = oTipoLibroCLS.NOMBRETIPOLIBRO;
    //                oTipoLibro.Descripcion = oTipoLibroCLS.DESCRIPCIONTIPOLIBRO;
    //                db.SaveChanges();
    //                rpta = 1;
    //            }


    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        rpta = 0;
    //    }


    //    return rpta;



    //}






    //[HttpGet]
    //[Route("api/TipoLibro/eliminarTipoLibro/{data?}")]
    //public int eliminarTipoLibro(string data)
    //{
    //    int rpta = 0;
    //    try
    //    {
    //        using (BDBibliotecaContext db = new BDBibliotecaContext())
    //        {
    //            int idTipoLibro = int.Parse(data);
    //            TipoLibro oTipoLibro = db.TipoLibro.Where(p => p.Iidtipolibro == idTipoLibro).First();
    //            oTipoLibro.Bhabilitado = 0;
    //            db.SaveChanges();
    //            rpta = 1;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        rpta = 0;
    //    }


    //    return rpta;
    //}




    [HttpGet]
    [Route("api/TipoLibro/Filtrar/{data?}")]
    public List<TipoLibroCLS> Filtrar(string data)
    {
        List<TipoLibroCLS> lista = new List<TipoLibroCLS>();
        using (BlazorLibraryContext db = new BlazorLibraryContext())
        {
            if (data == null)
            {
                lista = (from tipoLibro in db.TipoLibros
                         where tipoLibro.Bhabilitado == 1
                         select new TipoLibroCLS
                         {
                             IIDTIPOLIBRO = tipoLibro.Iidtipolibro,
                             NOMBRETIPOLIBRO = tipoLibro.Nombretipolibro,
                             DESCRIPCIONTIPOLIBRO = tipoLibro.Descripcion
                         }).ToList();
            }
            else
            {
                lista = (from tipoLibro in db.TipoLibros
                         where tipoLibro.Bhabilitado == 1
                         && tipoLibro.Nombretipolibro.Contains(data)
                         select new TipoLibroCLS
                         {
                             IIDTIPOLIBRO = tipoLibro.Iidtipolibro,
                             NOMBRETIPOLIBRO = tipoLibro.Nombretipolibro,
                             DESCRIPCIONTIPOLIBRO = tipoLibro.Descripcion
                         }).ToList();
            }


        }
        return lista;
    }




}
